'----------------------------------------------------------------------------------------------
'  機能名　　　　    : 棚卸進捗照会
'  機能説明　　　    : 棚卸作業の進捗状況の照会をグラフで行う。
'  備考　　　　　    : なし
'  作成日　　　　    : 2019/09/24
'  作成者　　　　    : Arche Inc.
'----------------------------------------------------------------------------------------------
'  更新日，更新者    : 
'  更新内容　　　    : 
'----------------------------------------------------------------------------------------------
Imports System.Collections.Specialized
Imports VWS.iSenseOpenLib
Imports VWS.iSenseOpenLib.Librarys.ComCns
Imports VWS.VSMS.VSMSLib.Librarys
Imports VWS.VSMS.VSMSS320.Acc.AccVSMSS320
Imports VWS.VSMS.VSMSS210
Imports VWS.VSMS.VSMSS210.Forms
Imports VWS.VSMS.VSMSLib.Resources
Imports VWS.BaseSpreadsheetGearOpen.Base.BaseSpreadsheetGear
Imports VWS.VSMS.VSMSS310
Imports VWS.VSMS.VSMSS310.Forms

Namespace Forms
    ''' <summary>
    ''' 棚卸進捗照会画面ｸﾗｽ
    ''' </summary>
    ''' <remarks>棚卸作業の進捗状況の照会をグラフで行う。</remarks>
    ''' <history> Arche Inc 2019/09/24 Created</history>
    Public Class frmVSMSS320_01



#Region " 定数 "
        ''' <summary>ハイフン</summary>
        Private Const HAFN As String = "-"
        ''' <summary>パーセント</summary>
        Private Const PERCENT As String = "%"
        ''' <summary>進捗グラフのタイトル</summary>
        Private Const PROC_TITLE As String = "0%                        50%                     100%"
#End Region

#Region " 変数 "
        ''' <summary>検索結果</summary>
        Private m_dtbData As DataTable = Nothing
        Private m_dtzData As DataTable = Nothing
        ''' <summary>ﾀｲﾏｰ</summary>
        Private m_timerUpdate As Timer
        ''' <summary>ｼｽﾃﾑｺｰﾄﾞ</summary>
        Private m_strSysCd As String = String.Empty
#End Region

#Region " ｲﾝｽﾀﾝｽ "
        ''' <summary>DBｱｸｾｽｸﾗｽ</summary>
        Private m_clsAcc As Acc.AccVSMSS320 = Nothing
#End Region

#Region " ｺﾝｽﾄﾗｸﾀ "

        Public Sub New()
            MyBase.New(ComConst.ProgramID.PGIDS221)
            Try
                ' この呼び出しは、Windows フォーム デザイナで必要です。
                InitializeComponent()

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub
#End Region


#Region " Init "
        ''' <summary>
        ''' 初期化処理を行います。
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub Init()
            Try
                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS320(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS320.DbAccessResultStatus.Normal) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Exit Sub
                End If
                SetCombo()


                'GAEA区分ｺｰﾄﾞ
                m_strSysCd = m_clsVSMSConfig.SysCd

                '画面の初期化
                Me.Initialize()

            Catch ex As Exception
                Throw ex
            Finally
                'DBクローズ
                Me.ExDbClose()
            End Try
        End Sub
#End Region

#Region " Initialize "
        ''' <summary>
        ''' 初期化処理を行います。
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub Initialize()
            Try
                'コントロールの初期化

                '検索条件
                '出荷日
                Me.datShipDate.FromValue = Date.Now
                Me.datShipDate.FromText = Date.Now.ToString(ComConst.Format.VB_DATE_SEP)
                Me.datShipDate.ToValue = Date.Now
                Me.datShipDate.ToText = String.Empty
                '納品先BLSコード
                '   Me.HaniKubun.Text = String.Empty
                '納品先名称
                Me.txtTanaOroshiNo.Text = String.Empty
                '棚卸区分
                Me.cmbTanaOroshiKbn.SelectedIndex = 0
                'ﾘｽﾄのｸﾘｱ
                Me.ClearItem()

                'ｸﾞﾘｯﾄﾞの設定
                With Me.dgvMsi
                    .Rows.Clear()
                    .AllowDrop = False                                                  'ﾕｰｻﾞによるDrop禁止
                    .AllowUserToOrderColumns = False                                    'ﾕｰｻﾞによる列の入れ替え禁止
                    .DeleteCellValue = True                                             'Delete可
                    .EditMode = DataGridViewEditMode.EditProgrammatically               '直接ｾﾙ編集不可
                    .KeyAction = VariedDataGridView.KeyActions.MoveToNextColRow         'Enter押下時ｶｰｿﾙの移動方向
                    .MultiSelect = True                                                 '複数選択可
                    .PasteCellValue = False                                             '貼付け不可
                    .ReadOnly = True                                                    '編集不可
                    .SelectionMode = DataGridViewSelectionMode.CellSelect               'ｾﾙ単位で選択
                    .StandardTab = True                                                 'Tab押下時ｺﾝﾄﾛｰﾙ内を移動
                    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                    .RowCount = 0
                    'ｾﾙｽﾀｲﾙの設定
                    .ColumnHeadersDefaultCellStyle.Font = _
                        New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, Drawing.FontStyle.Bold, _
                        Me.Font.Unit, Me.Font.GdiCharSet, Me.Font.GdiVerticalFont)

                    '進捗グラフのタイトル
                    .Columns(Me.colProc.Index).HeaderText = PROC_TITLE

                End With

                MyBase.setKomUse(Me.dgvMsi, True)

                'ﾌｫｰｶｽ設定
                Me.datShipDate.Focus()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
#End Region


#Region " イベント "

#Region " frmVSMSS220_01_Load "
        ''' <summary>
        ''' 画面起動時の処理を行います
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub frmVSMSS320_01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'DB起動ﾁｪｯｸ
                If Not Me.CheckDatabase Then
                    'ｼｽﾃﾑ終了
                    Me.Dispose()
                    Me.Close()
                End If

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
                'ｼｽﾃﾑ終了
                Me.Dispose()
                Me.Close()
            Finally
                'ｶｰｿﾙを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " frmVSMSS320_01_Shown "
        ''' <summary>
        ''' 画面表示時の処理を行います
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub frmVSMSS320_01_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                '画面の初期化
                Me.Init()

                MyBase.adjustMsi()

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'ｶｰｿﾙを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " frmVSMSS320_01_Disposed "
        ''' <summary>
        ''' 画面破棄時の処理
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub frmVSMSS220_01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

            'ﾀｲﾏｰを使用不可にする
            If m_timerUpdate IsNot Nothing Then
                m_timerUpdate.Enabled = False
            End If

        End Sub

#End Region

#Region " btnSearch_Click "
        ''' <summary>
        ''' 検索ﾎﾞﾀﾝ押下処理
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                ' 入力チェック
                ' Me.InputCheck()

                '描画停止
                Me.SuspendLayout()

                '検索処理
                If Not SearchData() Then
                    Return
                End If

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'DBのクローズ
                Me.ExDbClose()

                '描画再開
                Me.ResumeLayout()

                'ｶｰｿﾙを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub

#End Region

#Region " btnClear_Click "
        ''' <summary>
        ''' ｸﾘｱﾎﾞﾀﾝ押下処理
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
            Try

                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'ｸﾘｱ
                Me.cmbTanaOroshiKbn.SelectedIndex = 0      '棚卸区分
                Me.txtZone.Text = ""                'ZONE
                Me.txtTanaOroshiNo.Text = ""           '棚卸NO

                '初期化
                Me.Init()

                MyBase.adjustMsi(1)

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'ｶｰｿﾙを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " btnResult_Click "
        ''' <summary>
        ''' 実績照会ﾎﾞﾀﾝ押下処理
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub btnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResult.Click
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'ピッキング実績照会画面表示
                Using frmNext As New frmVSMSS310_01
                    'ﾌﾟﾛﾊﾟﾃｨ設定
                    With frmNext
                        .SHIP_DATE = ComLib.DateToYmd(Me.datShipDate.FromText)  '棚卸実施日
                        .TANA_KBN = ComAcs.GetCboItem(Me.cmbTanaOroshiKbn, True)   '棚卸区分
                        .ZONE = Me.txtZone.Text.TrimEnd
                        .TANA_NO = Me.txtTanaOroshiNo.Text.TrimEnd '棚卸No.
                    End With

                    If frmNext.ShowDialog(Me).Equals(DialogResult.OK) Then

                        'ﾒﾆｭｰ画面へ
                        Me.Refresh()
                        '呼び出し元画面を開く
                        If Not Me.Owner Is Nothing Then
                            Me.Owner.Show()
                        End If
                        'ﾀﾞｲｱﾛｸﾞにOKで返す
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        'ﾘｿｰｽを解放
                        Me.Dispose()

                    End If

                End Using
            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'ｶｰｿﾙを元に戻す
                Me.Cursor = Cursors.Default
            End Try

        End Sub

#End Region

#Region " btnMenu_Click "
        ''' <summary>
        ''' ﾒﾆｭｰ画面に遷移します。
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Public Overloads Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                '画面終了処理
                MyBase.DoGmnEndPrc()

                '再描画処理
                Me.Refresh()

                '呼び出し元画面を開く
                If Not Me.Owner Is Nothing Then
                    Me.Owner.Show()
                End If

                'ﾀﾞｲｱﾛｸﾞにOKで返す
                Me.DialogResult = Windows.Forms.DialogResult.OK

                'ﾘｿｰｽを解放
                Me.Close()
                Me.Dispose()

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'ｶｰｿﾙを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#End Region


#Region " ﾒｿｯﾄﾞ "

#Region " Public "

#End Region

#Region " Private "
       
#Region " SearchData "
        ''' <summary>
        ''' 検索処理
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Function SearchData() As Boolean
            Try
                '行初期化
                Me.dgvMsi.RowCount = 0

                'ｸﾗｲｱﾝﾄﾁｪｯｸ
                If Not Me.doCheckClient Then
                    'ｴﾗｰ
                    Return False
                End If

                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS320(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS320.DbAccessResultStatus.Normal) Then
                    'ｴﾗｰ処理
                    Me.ErrAfter()
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                '棚卸情報取得
                Me.doSearch()

                If m_dtbData.Rows.Count = 0 Then
                    'ｴﾗｰ処理
                    Me.ErrAfter()
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0007, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                '一覧表示
                Me.setDataTableToForm()

                Return True

            Catch ex As Exception
                Throw ex
            Finally
                '解放
                If Not m_dtbData Is Nothing Then
                    m_dtbData.Dispose()
                    m_dtbData = Nothing
                End If
            End Try
        End Function

#End Region



#Region " 表示用時分作成 "
        ''' <summary>
        ''' コロンで区切られた表示用の時分を作成します。
        ''' </summary>
        ''' <param name="strTime">１７桁日時文字列</param>
        ''' <returns>H24:MM</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/10 Created</history>
        Private Function formatH24Time(ByVal strTime As String) As String
            If Not String.IsNullOrEmpty(strTime) Then
                Return strTime.Substring(8, 2) & ":" & strTime.Substring(10, 2)
            End If
            Return Nothing
        End Function
#End Region

#Region " GetMinTime "
        ''' <summary>
        ''' 最小日時を取得
        ''' </summary>
        ''' <param name="pstrValue">日時</param>
        ''' <param name="pstrMinValue">最小日時</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/10 Created</history>
        Private Function GetMinTime(ByVal pstrValue As String, ByVal pstrMinValue As String) As String
            Dim ret As String = String.Empty
            Try
                '最小日時の比較判定
                If String.IsNullOrEmpty(pstrValue) And String.IsNullOrEmpty(pstrMinValue) Then
                    '日時=空白かつ最小日時=空白 ⇒ 空白
                    ret = String.Empty
                ElseIf Not String.IsNullOrEmpty(pstrValue) And Not String.IsNullOrEmpty(pstrMinValue) Then
                    '日時≠空白かつ最小日時≠空白 ⇒ 日時比較

                    '最小日時 > 日時 ⇒ 日時 else 最小日時
                    If pstrMinValue > pstrValue Then
                        ret = pstrValue
                    Else
                        ret = pstrMinValue
                    End If
                ElseIf Not String.IsNullOrEmpty(pstrValue) And String.IsNullOrEmpty(pstrMinValue) Then
                    '日時≠空白かつ最小日時=空白 ⇒ 日時
                    ret = pstrValue
                ElseIf String.IsNullOrEmpty(pstrValue) And Not String.IsNullOrEmpty(pstrMinValue) Then
                    '日時=空白かつ最小日時≠空白 ⇒ 最小日時
                    ret = pstrMinValue
                End If

            Catch ex As Exception
                Throw ex
            End Try
            Return ret
        End Function

#End Region

#Region " GetMaxTime "
        ''' <summary>
        ''' 最大日時を取得
        ''' </summary>
        ''' <param name="pstrValue">日時</param>
        ''' <param name="pstrMaxValue">最大日時</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/10 Created</history>
        Private Function GetMaxTime(ByVal pstrValue As String, ByVal pstrMaxValue As String) As String
            Dim ret As String = String.Empty
            Try
                '最大日時の比較判定
                If String.IsNullOrEmpty(pstrValue) And String.IsNullOrEmpty(pstrMaxValue) Then
                    '日時=空白かつ最大日時の=空白 ⇒ 空白
                    ret = String.Empty
                ElseIf Not String.IsNullOrEmpty(pstrValue) And Not String.IsNullOrEmpty(pstrMaxValue) Then
                    '日時≠空白かつ最大日時の≠空白 ⇒ 日時比較

                    '最大日時 > 日時 ⇒ 最大日時 else 日時
                    If pstrMaxValue > pstrValue Then
                        ret = pstrMaxValue
                    Else
                        ret = pstrValue
                    End If
                ElseIf Not String.IsNullOrEmpty(pstrValue) And String.IsNullOrEmpty(pstrMaxValue) Then
                    '日時≠空白かつ最大日時の=空白 ⇒ 日時
                    ret = pstrValue
                ElseIf String.IsNullOrEmpty(pstrValue) And Not String.IsNullOrEmpty(pstrMaxValue) Then
                    '日時=空白かつ最大日時の≠空白 ⇒ 最大日時
                    ret = pstrMaxValue
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return ret
        End Function

#End Region

#Region " SetCombo "
        ''' <summary>
        ''' ｺﾝﾎﾞﾎﾞｯｸｽの設定処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo()
            Try
                'ステータス
                Me.SetCombo(Me.cmbTanaOroshiKbn)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ''' <summary>
        ''' ｺﾝﾎﾞﾎﾞｯｸｽの設定処理
        ''' </summary>
        ''' <param name="robjCbo">コンボボックス</param>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo(ByRef robjCbo As NamedComboBox)
            Dim nvcDat As New NameValueCollection
            Try
                nvcDat = m_clsAcc.FindHaniKbByCombo(ComConst.CODE_KEY.MCODE_44, m_clsVSMSConfig.SysCd)
                robjCbo.Items.Clear()
                ComAcs.CreateCombo(robjCbo, nvcDat)

            Catch ex As Exception
                Throw ex
            Finally
                nvcDat = Nothing
            End Try
        End Sub

#End Region

#Region " ExDbClose "
        ''' <summary>
        ''' DBのクローズ
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/10 Created</history>
        Private Sub ExDbClose()

            If (Not m_clsAcc Is Nothing) Then
                'DBｺﾈｸﾄ開放(例外時にはRollbackを行う)
                m_clsAcc.ConnectDispose()
                m_clsAcc = Nothing
            End If

        End Sub

#End Region

#Region " ErrAfter "
        ''' <summary>
        ''' ｴﾗｰ後処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/10 Created</history>
        Private Sub ErrAfter()
            Try
                'ﾘｽﾄのｸﾘｱ
                Me.ClearItem()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
#End Region

#Region " ClearItem "
        ''' <summary>
        ''' 一覧の初期化
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/10 Created</history>
        Private Sub ClearItem()
            Try
                '合計
                Me.lblStartTime.Text = HAFN
                Me.lblEndTime.Text = HAFN
                Me.lblSplVal.Text = HAFN
                Me.lblActVal.Text = HAFN
                Me.lblProcVal.Text = HAFN
                'グラフ
                Me.picGraph.GraphValue = String.Empty
                Me.picGraph.Refresh()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
#End Region

#Region " dgvMsi_CellFormatting "
        Private Sub dgvMsi_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMsi.CellFormatting
            dgvMsi.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
        End Sub
#End Region

      




#End Region

#Region " Protected "

#Region " setDataTableToForm "
        ''' <summary>
        ''' 検索結果を画面項目にｾｯﾄします。
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Protected Overrides Function setDataTableToForm() As Boolean
            Try
                '明細初期化
                Me.dgvMsi.RowCount = 1
                Me.dgvMsi.SuspendLayout()
                Me.dgvMsi.RowCount = m_dtbData.Rows.Count

                Dim intRow As Integer = 0
                Dim param As New FindZoneCode

                'ヘッダ情報用(開始時間、終了時間、作業品数、完了品数、指示数、指示完了数)
                Dim strMinStartTime As String = String.Empty
                Dim strMaxEndTime As String = String.Empty
                Dim decSumComp As Decimal
                Dim decSumTotal As Decimal

                '明細情報用(開始時間、終了時間、指示数、完了数)
                Dim strStartTime As String
                Dim strEndTime As String
                Dim decComp As Decimal
                Dim decTotal As Decimal
                Dim decPgs As Decimal
                'Dim decSpec As Decimal
                Dim zone As String
                'グラフ
                Dim decBlue As Decimal
                Dim decWhite As Decimal

                For Each dtrData As DataRow In m_dtbData.Rows
                    With Me.dgvMsi.Rows(intRow)

                        '開始時間、終了時間、指示数、完了数、進捗率

                        decComp = ComLib.ToDecEx(dtrData.Item("DONE_CNT"))
                        decTotal = ComLib.ToDecEx(dtrData.Item("TOTAL_CNT"))
                        If (decComp = 0) Then
                            strStartTime = ""
                            strEndTime = ""
                        Else
                            strStartTime = ComLib.ToStrEx(dtrData.Item("START_TIME"))
                            strEndTime = ComLib.ToStrEx(dtrData.Item("END_TIME"))
                        End If
                        decPgs = ComLib.GetRound((decComp / decTotal) * 100, 2, 1)

                        'zone = ComLib.ToDecEx(dtrData.Item("ZONE"))
                        zone = ComLib.ToStrEx(dtrData.Item("ZONE"))

                        'crystal report columns
                        .Cells(Me.colTanaOroshiNo.Index).Value = ComLib.ToStrEx(dtrData.Item("INV_NO"))

                        param.SysCd = m_strSysCd
                        param.LocCd = ComLib.ToStrEx(dtrData.Item("LOC_CD"))

                        ' zone = m_clsAcc.FindZone(param)

                        .Cells(Me.colZone.Index).Value = zone
                        .Cells(Me.colStartTime.Index).Value = formatH24Time(strStartTime)
                        .Cells(Me.colEndTime.Index).Value = formatH24Time(strEndTime)
                        .Cells(Me.colTotalCnt.Index).Value = ComLib.SetComma(decTotal)   '作業品数
                        .Cells(Me.colCompCnt.Index).Value = ComLib.SetComma(decComp)      '完了品数                      
                        .Cells(Me.colProcPer.Index).Value = ComLib.SpacePading(decPgs, 6) & Space(1) & PERCENT

                        '進捗率グラフ
                        '作業完了（青）
                        If decPgs > 100 Then
                            decBlue = 100
                        Else
                            decBlue = decPgs
                        End If
                        '作業完了（白）
                        decWhite = 100 - decBlue
                        .Cells(Me.colProc.Index).Value = decBlue.ToString & "," & decWhite.ToString

                        'ヘッダ用集計値
                        strMinStartTime = GetMinTime(strStartTime, strMinStartTime)
                        strMaxEndTime = GetMaxTime(strMaxEndTime, strEndTime)
                        decSumComp = decSumComp + decComp
                        decSumTotal = decSumTotal + decTotal

                    End With
                    intRow = intRow + 1
                Next

                'ヘッダ情報を設定
                '開始時間
                If Not String.IsNullOrEmpty(strMinStartTime) Then
                    Me.lblStartTime.Text = formatH24Time(strMinStartTime)
                Else
                    Me.lblStartTime.Text = HAFN
                End If

                '終了時間
                If Not String.IsNullOrEmpty(strMaxEndTime) Then
                    Me.lblEndTime.Text = formatH24Time(strMaxEndTime)
                Else
                    Me.lblEndTime.Text = HAFN
                End If

                '指示数
                Me.lblSplVal.Text = ComLib.SetComma(decSumTotal)
                '完了数
                Me.lblActVal.Text = ComLib.SetComma(decSumComp)
                '進捗率
                Dim decSumPgs As Decimal = ComLib.GetRound((decSumComp / decSumTotal) * 100, 2, 1)
                Me.lblProcVal.Text = ComLib.ToStrEx(decSumPgs) & Space(1) & PERCENT
                '進捗率フラグ
                If decSumPgs > 100 Then
                    decBlue = 100
                Else
                    decBlue = decSumPgs
                End If
                '作業完了（白）
                decWhite = 100 - decBlue
                Me.picGraph.GraphValue = decBlue.ToString & "," & decWhite.ToString

                '一覧表示設定
                MyBase.setYkoRow(dgvMsi.RowCount)
                MyBase.adjustMsi()

                Me.dgvMsi.ClearSelection()
                Return True

            Catch ex As Exception
                Throw ex
            Finally
                Me.dgvMsi.ResumeLayout()
            End Try

        End Function

#End Region

#Region " doSearch "
        ''' <summary>
        ''' 検索します。
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Protected Overrides Sub doSearch()
            Try
                '条件取得
                Dim param As New PicProgressParam
                param.SysCd = m_strSysCd                                       'システムコード

                param.Ship_Date = ComLib.DateToYmd(Me.datShipDate.FromText)    '棚卸実施日

                param.CenterCd = m_strCenterCd                                 'CENTER_CD

                Dim strCodeNm As String() = ComAcs.GetCboItem(Me.cmbTanaOroshiKbn, True).Split(":")  ' ["2", "循環棚卸"]
                'Dim tanaKbn As String = "循環棚卸"

                'If String.Compare(strCodeNm(1), tanaKbn) = 0 Then
                'param.TanaOroshiKbn = "2"             '棚卸区分
                'Else
                'param.TanaOroshiKbn = "1"             '棚卸区分
                'End If
                If strCodeNm.Length = 2 Then
                    param.TanaOroshiKbn = strCodeNm(0)
                End If
                param.Zone = Me.txtZone.Text
                param.TanaOroshiNo = Me.txtTanaOroshiNo.Text

                '棚卸進捗情報検索
                m_dtbData = m_clsAcc.FindPicProgress(param)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#End Region

#End Region




    End Class
End Namespace