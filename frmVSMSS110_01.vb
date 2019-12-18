'----------------------------------------------------------------------------------------------
'  機能名　　　　    : 入荷実績照会画面クラス
'  機能説明　　　    : 入荷実績照会画面の機能を提供します。
'  備考　　　　　    : なし
'  作成日　　　　    : 2019/10/23
'  作成者　　　　    : 
'----------------------------------------------------------------------------------------------
'  更新日，更新者    : 
'  更新内容　　　    : 
'----------------------------------------------------------------------------------------------
Imports System.Collections.Specialized
Imports VWS.iSenseOpenLib
Imports VWS.iSenseOpenLib.Librarys.ComCns
Imports VWS.VSMS.VSMSLib.Librarys
Imports VWS.VSMS.VSMSS110.Acc.AccVSMSS110
Imports VWS.VSMS.VSMSS210
Imports VWS.VSMS.VSMSS210.Forms
Imports VWS.VSMS.VSMSLib.Resources
Imports VWS.BaseSpreadsheetGearOpen.Base.BaseSpreadsheetGear

Namespace Forms
    ''' <summary>
    ''' 入荷実績照会画面クラス
    ''' </summary>
    ''' <remarks>入荷実績照会画面の機能を提供します。</remarks>
    ''' <history>S.Toshino 2018/09/04 Created</history>
    Public Class frmVSMSS110_01

#Region " 変数 "
        ''' <summary>検索結果</summary>
        Private m_dtbData As DataTable = Nothing
        Private m_dtzData As DataTable = Nothing
        ''' <summary>タイマー</summary>
        Private m_timerUpdate As Timer
        ''' <summary>システムコード</summary>
        Private m_strSysCd As String = String.Empty
#End Region

#Region " 定数 "
        ''' <summary>CSVファイル名</summary>
        Private Const CSV_NM As String = "入荷実績一覧_" & ComConst.Format.VB_DATETIME & ".csv"
        ''' <summary>作業ステータス:未完了</summary>
        Private Const WORK_STS_UNFINISHED As String = "0"
        ''' <summary>作業ステータス:欠品</summary>
        Private Const WORK_STS_SHORTAGE As String = "2"
#End Region

#Region " 変数 "
        ''' <summary>実行モード</summary>
        Private m_intMode As Integer


        ''' <summary>選択行</summary>
        Private m_intSelectedRow As Integer
        ''' <summary>システム時間</summary>
        Private m_strSysDate As String
        ''' <summary>更新件数</summary>
        Private m_Update_Cnt As Integer

        ' ''' <summary>納品先BLSコード</summary>
        '' Private m_strBlsDeliCd  As String

        '' <summary>納品先名称</summary>
        Private m_strBlsDeliNm As String

        ''' <summary>入出荷区分</summary>
        Private m_strNyukaKb As String

        ''' <summary>入荷予定日</summary>
        Private m_strInplanDate As String

        ''' <summary>発地コード</summary>
        Private m_strVendorCd As String

        ''' <summary>発地名称</summary>
        Private m_VendorNm As String



#Region " インスタンス "
        ''' <summary>DBアクセスクラス</summary>
        Private m_clsAcc As Acc.AccVSMSS110 = Nothing
        ''' <summary>ステータス情報</summary>
        Private m_nvcSts As New NameValueCollection
        ''' <summary>入荷実績情報</summary>
        Private m_lstPicres As New List(Of T_Picres)
        ''' <summary>入荷実績情報(ログ用)</summary>
        Private m_lstPicresLog As New List(Of T_Picres)
#End Region

#End Region

#Region " 列挙体 "
        ''' <summary>
        ''' 実行モード
        ''' </summary>
        ''' <remarks></remarks>
        Private Enum MODE As Integer
            ''' <summary>検索</summary>
            Search = 0
            ''' <summary>明細クリック</summary>
            Detail
            ''' <summary>CSV出力</summary>
            CSV
            ''' <summary>更新</summary>
            Update
        End Enum

#End Region

#Region " 構造体 "

#Region " CSV_ITEM "
        ''' <summary>
        ''' CSV作成用構造体
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Structure CSV_ITEM

#Region " 定数 "
            ''' <summary>作業ステータス</summary>
            Public Const WORK_STS As String = "ステータス"
            ''' <summary>発地コード</summary>
            Public Const VENDOR_CD As String = "発地コード"
            ''' <summary>発地名称</summary>
            Public Const VENDOR_NM As String = "発地名称"
            ''' <summary>商品BLSコード</summary>
            Public Const BLS_ITEM_CD As String = "商品BLSコード"
            ''' <summary>商品名称</summary>
            Public Const BLS_ITEM_NM As String = "商品名称"
            ''' <summary>商品管理日</summary>
            Public Const ITEM_MNG_DATE As String = "商品管理日"
            ''' <summary>入数</summary>
            Public Const CS_CARTON As String = "入数"
            ''' <summary>指示数(ケース)</summary>
            Public Const EXP_CS_QTY As String = "指示数(ケース)"
            ''' <summary>指示数(バラ)</summary>
            Public Const EXP_PL_QTY As String = "指示数(バラ)"
            ''' <summary>指示数(総バラ)</summary>
            Public Const EXP_SPL_QTY As String = "指示数(総バラ)"
            ''' <summary>実績数(ケース)</summary>
            Public Const ACT_CS_QTY As String = "実績数(ケース)"
            ''' <summary>実績数(バラ)</summary>
            Public Const ACT_PS_QTY As String = "実績数(バラ)"
            ''' <summary>実績数(総バラ)</summary>
            Public Const ACT_SPS_QTY As String = "実績数(総バラ)"
            ''' <summary>在庫最新管理日</summary>
            Public Const NEW_INV_DATE As String = "在庫最新管理日"
            ''' <summary>不良品区分</summary>
            Public Const REJECT_KB As String = "不良品区分"
            ''' <summary>入荷予定ＮＯ</summary>
            Public Const INPLAN_NO As String = "入荷予定ＮＯ"
            ''' <summary>ロケーション</summary>
            Public Const LOC_CD As String = "ロケーション"
            ''' <summary>単品JAN</summary>
            Public Const JAN_CD As String = "単品JAN"
            ''' <summary>ケースJAN</summary>
            Public Const CS_JAN_CD As String = "ケースJAN"
            ''' <summary>ITFコード</summary>
            Public Const ITF_CD As String = "ITFコード"

            Public Const INOUT_KB As String = "入出荷区分"
            Public Const INOUT_NM As String = "入出荷区分名称"
            Public Const INPLAN_DATE As String = "入荷予定日"

            Public Const SEND_FLG As String = "実績送信"
            Public Const WORK_USER_NM As String = "作業者"
            Public Const INS_YB As String = "作業時間"


#End Region

#Region " 変数 "
            ''' <summary>ダミー</summary>
            Private Dummy As Boolean
#End Region

#Region " GetColItem "
            ''' <summary>
            ''' CSVの項目名取得処理
            ''' </summary>
            ''' <param name="pstrColNm">項目名(データ)</param>
            ''' <returns>項目名(CSV)</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/05 Created</history>
            Public Function GetColItem(ByVal pstrColNm As String) As String
                Try
                    Return CallByName(New CSV_ITEM, pstrColNm.ToUpper, CallType.Get).ToString

                Catch ex As Exception
                    Throw ex
                End Try
            End Function
#End Region

        End Structure

#End Region

#End Region

#Region " コンストラクタ "
        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Public Sub New()
            MyBase.New(ComConst.ProgramID.PGIDS110)
            Try
                ' この呼び出しは、Windows フォーム デザイナで必要です。
                InitializeComponent()

                ' InitializeComponent() 呼び出しの後で初期化を追加します。

                '明細グリッドにダミー行を表示するかを設定します
                MyBase.setMsiDmyRowFlg(False)
                MyBase.setMsi2DmyRowFlg(False)
                '明細グリッドにてENTERを許すか
                MyBase.setMsiKeyEnter(True)
                'エラーメッセージの表示を任せない
                MyBase.setMsgCtlFlg(False)
                '親画面グリッドとの連携
                MyBase.setDgvMsi(Me.dgvMsi)
                MyBase.setDgvMsi2(Me.dgvMsiDtl)
                '親画面にフォーム名の連携
                MyBase.FormName = Me.Name
                '親画面に明細2存在フラグの連携
                MyBase.Dmy2Exist = True
                '明細の最大行数を設定します
                MyBase.setMsiMaxRow(11)
                MyBase.setMsi2MaxRow(6)
                '終了前処理実行フラグをONに設定
                MyBase.SetGmnEndPrcFlg(True)
                'ボタン色の一括変更
                MyBase.ChangeButtonColor(pnlControl05)

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub
#End Region

#Region " プロパティ "

#Region " INPLAN_DATE "
        ''' <summary>
        ''' 入荷予定日
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public WriteOnly Property INPLAN_DATE() As String
            Set(ByVal value As String)
                m_strInplanDate = value
            End Set
        End Property
#End Region

#Region " VENDOR_CD "
        ''' <summary>
        ''' 発地コード
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public WriteOnly Property VENDOR_CD() As String
            Set(ByVal value As String)
                m_strVendorCd = value
            End Set
        End Property
#End Region

#Region " VENDOR_NM "
        ''' <summary>
        ''' 発地名称
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public WriteOnly Property VENDOR_NM() As String
            Set(ByVal value As String)
                m_VendorNm = value
            End Set
        End Property
#End Region

#Region " NYUKAKB "
        ''' <summary>
        ''' 納品先名
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public WriteOnly Property NYUKA_KB() As String
            Set(ByVal value As String)
                m_strNyukaKb = value
            End Set
        End Property
#End Region
#End Region

#Region " イベント "

#Region " frmVSMSS110_01_Load "
        ''' <summary>
        ''' 画面起動時の処理を行います
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub frmVSMSS110_01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'DB起動チェック
                If Not Me.CheckDatabase Then
                    'システム終了
                    Me.Dispose()
                    Me.Close()
                End If

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
                'システム終了
                Me.Dispose()
                Me.Close()
            Finally
                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " frmVSMSS110_01_Shown "
        ''' <summary>
        ''' 画面表示時の処理を行います
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub frmVSMSS110_01_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS110(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS110.DbAccessResultStatus.Normal) Then
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Exit Sub
                End If

                'ステータスの取得
                m_nvcSts.Clear()
                m_nvcSts = m_clsAcc.FindCodeByCombo(ComConst.CODE_KEY.MCODE_42, m_clsVSMSConfig.SysCd)

                '画面の初期化
                Me.Init()

                MyBase.adjustMsi(1)
                MyBase.adjustMsi2(1)

                'ボタンを使用不可にする
                Select Case Me.m_clsVSMSConfig.DataRefKb
                    Case ComConst.AuthKb.GENERAL    '一般
                        Me.btnSearch.Enabled = True
                        Me.btnClear.Enabled = True

                        Me.btnDownload.Enabled = True
                    Case ComConst.AuthKb.ADMIN      '管理
                        Me.btnSearch.Enabled = True
                        Me.btnClear.Enabled = True

                        Me.btnDownload.Enabled = True
                    Case ComConst.AuthKb.HEAD       '本部
                        Me.btnSearch.Enabled = True
                        Me.btnClear.Enabled = True

                        Me.btnDownload.Enabled = True
                End Select

                'モードの変更
                Me.m_intMode = MODE.Search

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'DBクローズ
                Me.DbClose(CType(m_clsAcc, ComAccBase))
                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " btnMenu_Click "
        ''' <summary>
        ''' メニュー画面に遷移します。
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Public Overloads Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                '画面終了処理
                MyBase.DoGmnEndPrc()

                '再描画処理
                Me.Refresh()

                '呼び出し元画面を開く
                If Not Me.Owner Is Nothing Then
                    Me.Owner.Show()
                End If

                'ダイアログにOKで返す
                Me.DialogResult = Windows.Forms.DialogResult.OK

                'リソースを解放
                Me.Close()
                Me.Dispose()

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " btnClose_Click "
        ''' <summary>
        ''' 呼び出し元画面に遷移します。
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Public Overloads Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                Me.Refresh()
                '呼び出し元画面を開く
                If Not Me.Owner Is Nothing Then
                    Me.Owner.TopMost = True
                End If

                'ダイアログにキャンセルで返す
                Me.DialogResult = Windows.Forms.DialogResult.Cancel

                If Not Me.Owner Is Nothing Then
                    Me.Owner.TopLevel = True
                    Me.Owner.TopMost = False
                End If

                'リソースを解放
                Me.Close()
                Me.Dispose()

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " dgvMsi_CellClick "
        ''' <summary>
        ''' クリッドクリック処理
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub dgvMsi_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMsi.CellClick
            Dim fileId As String = ""
            Dim fileLineNo As String = ""
            Try
                '明細ボタン以外は処理を行わない
                If e.ColumnIndex <> Me.colDetail.Index OrElse e.RowIndex < 0 Then
                    Exit Sub
                End If

                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'レコードの背景色を戻す
                For intIdx As Integer = 0 To Me.dgvMsi.Rows.Count - 1
                    Me.dgvMsi.Rows(intIdx).DefaultCellStyle.BackColor = Nothing
                Next

                '処理モード設定
                Me.m_intMode = MODE.Detail

                '指定行の設定
                Me.m_intSelectedRow = e.RowIndex

                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS110(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS110.DbAccessResultStatus.Normal) Then
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return
                End If

                '行初期化
                Me.dgvMsiDtl.RowCount = 0

                '検索処理
                fileId = Me.dgvMsi.Rows(e.ColumnIndex).Cells(Me.colFILE_ID.Index).Value
                fileLineNo = Me.dgvMsi.Rows(e.ColumnIndex).Cells(Me.colFILE_LINE_NO.Index).Value
                If Not SearchDetailData(fileId, fileLineNo) Then
                    Return
                End If

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'DBのクローズ
                Me.DbClose(CType(m_clsAcc, ComAccBase))

                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " btnSearch_Click "
        ''' <summary>
        ''' 検索ボタン押下処理
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                '処理モード設定
                Me.m_intMode = MODE.Search

                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS110(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS110.DbAccessResultStatus.Normal) Then
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return
                End If

                '行初期化
                Me.dgvMsi.RowCount = 0
                Me.dgvMsiDtl.RowCount = 0

                '選択行初期化
                Me.m_intSelectedRow = -1

                '検索処理
                If Not SearchData() Then
                    Return
                End If

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'DBのクローズ
                Me.DbClose(CType(m_clsAcc, ComAccBase))

                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " btnClear_Click "
        ''' <summary>
        ''' クリアボタン押下処理
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'クリア
                resetParams()

                '引き継ぎ項目を初期化
                m_strInplanDate = String.Empty
                m_strVendorCd = String.Empty
                m_VendorNm = String.Empty

                '初期化
                Me.Init()

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " btnDownload_Click "
        ''' <summary>
        ''' ダウンロードボタン押下処理
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub btnDownload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDownload.Click
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS110(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS110.DbAccessResultStatus.Normal) Then
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Exit Sub
                End If

                'CSV出力処理
                If Not Me.SetCsvFile() Then
                    Exit Sub
                End If

                '完了メッセージ
                Me.m_clsMsgBox.Show(ComMsg.MSGI0001, String.Empty, Me.m_clsSysConfig.SysName)

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'DBのクローズ
                Me.DbClose(CType(m_clsAcc, ComAccBase))

                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try

        End Sub

#End Region

#End Region

#Region " メソッド "

#Region " Public "

#End Region

#Region " Protected "

#Region " doCheckBusiness "
        ''' <summary>
        ''' 業務チェック処理を行います。
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Protected Overrides Function doCheckBusiness() As Boolean
            Try
                Select Case m_intMode
                    Case MODE.Search, MODE.CSV  '検索,CSV
                        '検索条件のチェック
                        If Not Me.CheckHeader() Then
                            Return False
                        End If
                    Case MODE.Detail            '明細
                        '一覧のチェック
                        Me.CheckDetail()

                        '//disabled
                        'Case MODE.Update            '更新
                        '    '更新チェック
                        '    If Not Me.CheckLstData() Then
                        '        Return False
                        '    End If
                End Select

                Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region " doSearch "
        ''' <summary>
        ''' 検索処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Protected Overrides Sub doSearch()
            Try
                '条件取得

                Dim param As New PicProgressParam
                param.SysCd = m_clsVSMSConfig.SysCd                             'システムコード
                param.CenterCd = m_strCenterCd                                  'CENTER_CD

                param.Ship_Date = ComLib.DateToYmd(Me.datShipDate.FromText)     '出荷日
                param.Location = Me.txtLocCd.Text                               'ロケーション
                param.VendorCd = Me.txtVendorCD.Text                            '発地コード
                param.VendorNm = Me.txtVendorNm.Text                            '発地名称
                param.WrkUserNm = Me.txtWorkUserNm.Text                         '作業者名称
                If ChkRejectKb.Checked = True Then
                    param.RejectKb = "1"
                    '不良品を検索。この値はDB内の値ではなく、クエリーを作るときのフラグ
                End If

                If ChkWarning.Checked = True Then
                    param.Warning = "1"
                    'ワーニングありを検索。この値はDB内の値ではなく、クエリーを作るときのフラグ
                End If

                Dim strCodeNm As String() = ComAcs.GetCboItem(Me.cmbInOutKb, True).Split(":")
                param.Nyuka_Kb = strCodeNm(0)        '入荷区分

                Dim strStatus As String() = ComAcs.GetCboItem(Me.cmbWorkSts, True).Split(":")
                param.Status = strStatus(0)  'ステータス

                param.Bls_Item_Cd = Me.txtBlsItemCd.Text '商品BLSコード
                param.Bls_Item_Nm = Me.txtItemNm.Text    '商品名称
                param.NyuYotNo = Me.txtInplanNo.Text     '入荷予定No.

                Select Case Me.m_intMode
                    Case MODE.Search    '検索
                        m_dtbData = m_clsAcc.FindPicProgress(param)
                    Case MODE.Detail    '明細
                        m_dtbData = m_clsAcc.FindPicresDtl(param)
                    Case MODE.CSV       'CSV
                        'm_dtbData = m_clsAcc.FindPicres(True)
                        m_dtbData = m_clsAcc.FindPicProgress(param)
                End Select

                '入荷進捗情報検索
                ' m_dtbData = m_clsAcc.FindPicProgress(param)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region

#Region " doSearchDetail "
        ''' <summary>
        ''' 検索処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Private Sub doSearchDetail(ByVal FileId As String, ByVal FileLineNo As String)
            Try
                '条件取得

                Dim param As New PicProgressParam
                param.SysCd = m_clsVSMSConfig.SysCd                             'システムコード
                param.CenterCd = m_strCenterCd                                  'CENTER_CD

                param.Ship_Date = ComLib.DateToYmd(Me.datShipDate.FromText)     '入荷予定日
                param.Location = Me.txtLocCd.Text                               'ロケーション
                param.VendorCd = Me.txtVendorCD.Text                            '発地コード
                param.VendorNm = Me.txtVendorNm.Text                            '発地名称
                param.WrkUserNm = Me.txtWorkUserNm.Text                         '作業者名称
                If ChkRejectKb.Checked = True Then
                    param.RejectKb = "1"
                    '不良品を検索。この値はDB内の値ではなく、クエリーを作るときのフラグ
                End If

                If ChkWarning.Checked = True Then
                    param.Warning = "1"
                    'ワーニングありを検索。この値はDB内の値ではなく、クエリーを作るときのフラグ
                End If

                Dim strCodeNm As String() = ComAcs.GetCboItem(Me.cmbInOutKb, True).Split(":")
                param.Nyuka_Kb = strCodeNm(0)        '入荷区分

                Dim strStatus As String() = ComAcs.GetCboItem(Me.cmbWorkSts, True).Split(":")
                param.Status = strStatus(0)  'ステータス

                param.Bls_Deli_Cd = Me.txtBlsItemCd.Text '商品BLSコード
                param.Bls_Deli_Nm = Me.txtItemNm.Text    '商品名称
                param.NyuYotNo = Me.txtInplanNo.Text     '入荷予定No.

                param.FileId = FileId
                param.FileLineNo = FileLineNo

                Select Case Me.m_intMode
                    Case MODE.Search    '検索
                        m_dtbData = m_clsAcc.FindPicProgress(param)

                    Case MODE.Detail    '明細
                        m_dtbData = m_clsAcc.FindPicresDtl(param)

                    Case MODE.CSV       'CSV
                        'm_dtbData = m_clsAcc.FindPicres(True)
                        m_dtbData = m_clsAcc.FindPicProgress(param)
                End Select

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region

#Region " setDataTableToForm "
        ''' <summary>
        ''' 検索結果を画面項目にセットします。
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Protected Overrides Function setDataTableToForm() As Boolean
            Try
                '検索時（ヘッダ）
                If Me.m_intMode = MODE.Search Then
                    Me.dgvMsi.RowCount = 0
                    Me.dgvMsi.SuspendLayout()
                    Me.dgvMsi.RowCount = m_dtbData.Rows.Count
                    Dim intRow As Integer = 0
                    Dim strWorkSts As String
                    Dim param As New FindNyukaKb
                    Dim nyuukakbn As String
                    Dim status As String
                    Dim rej_kb As String

                    For Each dtrData As DataRow In m_dtbData.Rows
                        With Me.dgvMsi.Rows(intRow)
                            .Cells(Me.colDetail.Index).Value = "詳細"

                            strWorkSts = ComLib.ToStrEx(dtrData.Item("WORK_STS"))               'ステータス
                            param.Status = ComConst.CODE_KEY.MCODE_47
                            param.Code = strWorkSts
                            param.SysCd = m_clsVSMSConfig.SysCd                                 'システムコード
                            status = m_clsAcc.FindStatus(param)                                 '入荷作業ステータス



                            param.Code = ComLib.ToStrEx(dtrData.Item("INOUT_KB"))               '入荷区分
                            nyuukakbn = m_clsAcc.FindNyukaKbn(param)
                            .Cells(Me.colArrivalKbn.Index).Value = nyuukakbn

                            '不良品区分
                            param.Status = ComConst.CODE_KEY.MCODE_17
                            param.Code = ComLib.ToStrEx(dtrData.Item("REJECT_KB"))
                            rej_kb = m_clsAcc.FindStatus(param)

                            .Cells(Me.colRejKb.Index).Value = rej_kb                             '不良品区分
                            If String.Compare("良品", rej_kb) = 0 Then
                                .Cells(Me.colRejKb.Index).Value = ""
                            End If

                            .Cells(Me.colWorkStsVal.Index).Value = status
                            .Cells(Me.colVendorCd.Index).Value = ComLib.ToStrEx(dtrData.Item("VENDOR_CD"))                     '発地コード
                            .Cells(Me.colVendorNm.Index).Value = ComLib.ToStrEx(dtrData.Item("VENDOR_NM"))                     '発地名称
                            .Cells(Me.colBlsItemCd.Index).Value = ComLib.ToStrEx(dtrData.Item("BLS_ITEM_CD"))                   '商品BLSコード
                            .Cells(Me.colBlsItemNm.Index).Value = ComLib.ToStrEx(dtrData.Item("BLS_ITEM_NM"))                   '商品名称
                            .Cells(Me.colItemMngDate.Index).Value = ComLib.YmdToDateStr(dtrData.Item("ITEM_MNG_DATE").ToString) '商品管理日
                            .Cells(Me.colCsCarton.Index).Value = ComLib.SetComma(dtrData.Item("CS_CARTON"))                      '入数
                            .Cells(Me.colExpCsQty.Index).Value = ComLib.SetComma(dtrData.Item("EXP_CS_QTY"))                     '指示数(ケース)
                            .Cells(Me.colExpPsQty.Index).Value = ComLib.SetComma(dtrData.Item("EXP_PL_QTY"))                     '指示数(バラ)
                            .Cells(Me.colExpSpsQty.Index).Value = ComLib.SetComma(dtrData.Item("EXP_SPL_QTY"))                   '指示数(総バラ)

                            If (ComLib.ToDecEx(dtrData.Item("ACT_CS_QTY")) = 0) Then
                                .Cells(Me.colActCsQty.Index).Value = ""
                            Else
                                .Cells(Me.colActCsQty.Index).Value = ComLib.SetComma(dtrData.Item("ACT_CS_QTY"))                 '実績数(ケース)
                            End If
                            If (ComLib.ToDecEx(dtrData.Item("ACT_PS_QTY")) = 0) Then
                                .Cells(Me.colActPsQty.Index).Value = ""
                            Else
                                .Cells(Me.colActPsQty.Index).Value = ComLib.SetComma(dtrData.Item("ACT_PS_QTY"))                 '実績数(ケース)
                            End If

                            If (ComLib.ToDecEx(dtrData.Item("ACT_SPS_QTY")) = 0) Then
                                .Cells(Me.colActSpsQty.Index).Value = ""
                            Else
                                .Cells(Me.colActSpsQty.Index).Value = ComLib.SetComma(dtrData.Item("ACT_SPS_QTY"))               '実績数(ケース)
                            End If


                            .Cells(Me.colWarMngDate.Index).Value = ComLib.YmdToDateStr(dtrData.Item("NEW_INV_DATE"))            '在庫最新管理日
                            ' .Cells(Me.colRejKb.Index).Value = ComLib.ToDecEx(dtrData.Item("REJECT_KB"))                       '不良品区分
                            .Cells(Me.colInplanNo.Index).Value = ComLib.ToStrEx(dtrData.Item("INPLAN_NO"))                         '入荷予定ＮＯ
                            .Cells(Me.colLocCd.Index).Value = ComLib.ToStrEx(dtrData.Item("LOC_CD"))                            'ロケーション
                            .Cells(Me.colJanCd.Index).Value = ComLib.ToStrEx(dtrData.Item("JAN_CD"))                            '単品JAN
                            .Cells(Me.colCsJanCd.Index).Value = ComLib.ToStrEx(dtrData.Item("CS_JAN_CD"))                       'ケースJAN
                            .Cells(Me.colItfCd.Index).Value = ComLib.ToStrEx(dtrData.Item("ITF_CD"))                            'ITFコード
                            .Cells(Me.colFILE_ID.Index).Value = ComLib.ToStrEx(dtrData.Item("FILE_ID"))                         'FILE_ID KKT
                            .Cells(Me.colFILE_LINE_NO.Index).Value = ComLib.ToStrEx(dtrData.Item("FILE_LINE_NO"))               'FILE_LINE_NO KKT
                        End With

                        '特定セル読み取り専用に変更
                        Me.SetReadonlyCell(intRow)

                        intRow += 1
                    Next

                    'スクロール初期化
                    dgvMsi.HorizontalScrollingOffset = 0
                    MyBase.setYkoRow(dgvMsi.RowCount)
                    MyBase.adjustMsi(2)
                    Me.dgvMsi.ClearSelection()


                    '------------------------------------------
                    '検索（明細）
                ElseIf Me.m_intMode = MODE.Detail Then
                    Me.dgvMsiDtl.RowCount = 1
                    Me.dgvMsiDtl.SuspendLayout()
                    Me.dgvMsiDtl.RowCount = m_dtbData.Rows.Count
                    Dim sendStatusStr() As String = {"未送信", "送信対象", "送信済み"}
                    Dim param As New FindNyukaKb
                    Dim sendflg_kb As String
                    Dim intRow As Integer = 0
                    For Each dtrData As DataRow In m_dtbData.Rows
                        With Me.dgvMsiDtl.Rows(intRow)
                            .ReadOnly = False
                            .Cells(Me.colItemMngDateDtl.Index).Value = ComLib.YmdToDateStr(dtrData.Item("ITEM_MNG_DATE").ToString)      'T_INRES 商品管理日
                            ' ComLib.YmdToDateStr() set "" when incorrect date value
                            .Cells(Me.colBlsItemNmDtl.Index).Value = ComLib.ToStrEx(dtrData.Item("BLS_ITEM_NM"))                        '商品名称
                            .Cells(Me.colCsCartonDtl.Index).Value = ComLib.ToDecEx(dtrData.Item("CS_CARTON"))                           '入数
                            .Cells(Me.colActCsQtyDtl.Index).Value = ComLib.ToDecEx(dtrData.Item("ACT_CS_QTY"))                          '実績数(ケース)
                            .Cells(Me.colActPsQtyDtl.Index).Value = ComLib.ToDecEx(dtrData.Item("ACT_PS_QTY"))                          '実績数(バラ)
                            .Cells(Me.colActSpsQtyDtl.Index).Value = ComLib.ToDecEx(dtrData.Item("ACT_SPS_QTY"))                        '実績数(総バラ)
                            .Cells(Me.colWorkUserNmDtl.Index).Value = ComLib.ToStrEx(dtrData.Item("WORK_USER_NM"))                      '作業者
                            .Cells(Me.colPicDateTimeDtl.Index).Value = ConvertDateYmdHms(dtrData.Item("INS_YB").ToString.TrimEnd) '作業時間
                            Dim x As String = ""
                            If ComLib.ToIntEx(dtrData.Item("SEND_FLG")) < sendStatusStr.Length Then
                                x = sendStatusStr(ComLib.ToIntEx(dtrData.Item("SEND_FLG")))
                            End If

                            '実績送信
                            param.Status = ComConst.CODE_KEY.MCODE_24
                            param.Code = ComLib.ToStrEx(dtrData.Item("SEND_FLG"))
                            param.SysCd = m_clsVSMSConfig.SysCd
                            sendflg_kb = m_clsAcc.FindStatus(param)
                            .Cells(Me.colActuSend.Index).Value = sendflg_kb    '実績送信

                        End With
                        intRow += 1
                    Next

                    'スクロール初期化
                    dgvMsiDtl.HorizontalScrollingOffset = 0

                    MyBase.setYkoRow2(dgvMsiDtl.RowCount)
                    MyBase.adjustMsi2()

                    Me.dgvMsiDtl.ClearSelection()

                End If

                '指定行を黄色にする
                If Me.m_intSelectedRow >= 0 Then
                    Me.dgvMsi.Rows(Me.m_intSelectedRow).DefaultCellStyle.BackColor = Color.Yellow
                End If

                Return True

            Catch ex As Exception
                Throw ex

            Finally
                If Me.m_intMode = MODE.Search Then
                    '初期時
                    Me.dgvMsi.ResumeLayout()
                Else
                    '明細クリック時
                    Me.dgvMsiDtl.ResumeLayout()
                End If
            End Try

        End Function

#End Region

#Region " resetParams "
        ''' <summary>
        ''' 入力項目クリア
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history> 2019/09/07 Created</history>
        Protected Function resetParams() As Boolean
            Me.txtVendorNm.Text = ""            '発送地名前
            Me.txtVendorCD.Text = ""            '発送地コード
            Me.cmbWorkSts.SelectedIndex = 0     'status
            Me.ChkRejectKb.Checked = False      '不良品区分
            Me.txtItemNm.Text = ""              '商品名称
            Me.txtBlsItemCd.Text = ""           'BLS_ITEM_CD
            Me.txtInplanNo.Text = ""            '入荷予定NO
            Me.ChkWarning.Checked = False       'warning
            Me.txtWorkUserNm.Text = ""          '作業者名
            Me.txtLocCd.Text = ""               'Location
            Me.cmbInOutKb.SelectedIndex = 0     '入荷区分

            Return True
        End Function
#End Region

#End Region

#Region " Private "

#Region " SetReadonlyCell "
        ''' <summary>
        ''' 特定のセルを読み取り専用にする
        ''' </summary>
        ''' <param name="pintRow">行</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub SetReadonlyCell(ByVal pintRow As Integer)
            Try
                With Me.dgvMsi.Rows(pintRow)
                    '.Cells(Me.colWorkStsVal.Index).ReadOnly = True          'ステータス名称
                    '.Cells(Me.colArrivalKbn.Index).ReadOnly = True            '出荷日
                    '.Cells(Me.colBlsDeliCd.Index).ReadOnly = True           '納品先BLSコード
                    '.Cells(Me.colBlsDeliNm.Index).ReadOnly = True           '納品先名称
                    '.Cells(Me.colJanCd.Index).ReadOnly = True               '単品JAN
                    '.Cells(Me.colCsJanCd.Index).ReadOnly = True             'ケースJAN
                    '.Cells(Me.colItfCd.Index).ReadOnly = True               'ITFコード
                    '.Cells(Me.colBlsItemCd.Index).ReadOnly = True           '商品BLSコード
                    '.Cells(Me.colBlsItemNm.Index).ReadOnly = True           '商品名称
                    '.Cells(Me.colPicZone.Index).ReadOnly = True                'ゾーン
                    '.Cells(Me.colLocCd.Index).ReadOnly = True               'ロケーション
                    '.Cells(Me.colItemMngDate.Index).ReadOnly = True         '商品管理日
                    '.Cells(Me.colCsCarton.Index).ReadOnly = True            '入数
                    '.Cells(Me.colExpCsQty.Index).ReadOnly = True            '指示数(ケース)
                    '.Cells(Me.colExpPsQty.Index).ReadOnly = True            '指示数(バラ)
                    '.Cells(Me.colExpSpsQty.Index).ReadOnly = True           '指示数(総バラ)
                    '.Cells(Me.colActCsQty.Index).ReadOnly = True            '実績数(ケース)
                    '.Cells(Me.colActPsQty.Index).ReadOnly = True            '実績数(バラ)
                    '.Cells(Me.colActSpsQty.Index).ReadOnly = True           '実績数(総バラ)
                    '.Cells(Me.colWorkSts2.Index).ReadOnly = True            'ステータス(値)
                    '.Cells(Me.colPreUpdYb.Index).ReadOnly = True            '更新日時

                    .Cells(Me.colWorkStsVal.Index).ReadOnly = True          'ステータス名称
                    .Cells(Me.colArrivalKbn.Index).ReadOnly = True          '入荷区分
                    .Cells(Me.colVendorCd.Index).ReadOnly = True            '発地コード
                    .Cells(Me.colVendorNm.Index).ReadOnly = True            '発地名称
                    .Cells(Me.colBlsItemCd.Index).ReadOnly = True           '商品BLSコード
                    .Cells(Me.colBlsItemNm.Index).ReadOnly = True           '商品名称
                    .Cells(Me.colItemMngDate.Index).ReadOnly = True         '商品管理日
                    .Cells(Me.colCsCarton.Index).ReadOnly = True            '入数
                    .Cells(Me.colExpCsQty.Index).ReadOnly = True            '指示数(ケース)
                    .Cells(Me.colExpPsQty.Index).ReadOnly = True            '指示数(バラ)
                    .Cells(Me.colExpSpsQty.Index).ReadOnly = True           '指示数(総バラ)
                    .Cells(Me.colActCsQty.Index).ReadOnly = True            '実績数(ケース)
                    .Cells(Me.colActPsQty.Index).ReadOnly = True            '実績数(バラ)
                    .Cells(Me.colActSpsQty.Index).ReadOnly = True           '実績数(総バラ)
                    .Cells(Me.colWarMngDate.Index).ReadOnly = True          '在庫最新管理日
                    .Cells(Me.colRejKb.Index).ReadOnly = True               '不良品区分
                    .Cells(Me.colInplanNo.Index).ReadOnly = True            '入荷予定ＮＯ
                    .Cells(Me.colLocCd.Index).ReadOnly = True               'ロケーション
                    .Cells(Me.colJanCd.Index).ReadOnly = True               '単品JAN
                    .Cells(Me.colCsJanCd.Index).ReadOnly = True             'ケースJAN
                    .Cells(Me.colItfCd.Index).ReadOnly = True               'ITFコード
                    .Cells(Me.colFILE_ID.Index).ReadOnly = True             'FILE_ID KKT
                    .Cells(Me.colFILE_LINE_NO.Index).ReadOnly = True        'FILE_LINE_NO KKT
                End With
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

#End Region

#Region " dgvMsi_CellPainting "
        ''' <summary>
        ''' 読み取り専用のチェックボックス描画制御
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub dgvMsi_CellPainting(ByVal sender As System.Object, _
                                        ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) _
                                        Handles dgvMsi.CellPainting
            Try
                If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
                    'チェックボックス列であれば
                    If TypeOf dgvMsi.Columns(e.ColumnIndex) Is DataGridViewCheckBoxColumn Then

                        '変更不可行であれば
                        If dgvMsi(e.ColumnIndex, e.RowIndex).ReadOnly Then
                            '読み取り専用のチェックボックスの描画を塗りつぶす
                            Dim selected As Boolean = _
                                DataGridViewElementStates.Selected = _
                                (e.State And DataGridViewElementStates.Selected)
                            e.PaintBackground(e.CellBounds, selected)
                            e.Handled = True
                        End If
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region " dgvMsi_CellLeave "
        ''' <summary>
        ''' クリッドクリック処理
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/11 Created</history>
        Private Sub dgvMsi_CellLeave(ByVal sender As Object, _
                                     ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
                                     Handles dgvMsi.CellLeave
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'エラー解除
                Me.dgvMsi.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.Empty

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub

#End Region

#Region " SearchData "
        ''' <summary>
        ''' 検索処理
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Function SearchData() As Boolean
            Try
                'クライアントチェック
                If Not Me.doCheckClient Then
                    'エラー
                    Return False
                End If

                '入荷実績情報取得
                Me.doSearch()

                If m_dtbData.Rows.Count = 0 Then
                    'エラー情報をセット
                    If m_intMode = MODE.Search Then
                        '検索処理
                        SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0007, String.Empty, String.Empty, 0, 0)
                        dispErrorInfo()
                        Return False
                    ElseIf m_intMode = MODE.Detail Then
                        '詳細検索
                        SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0055, String.Empty, String.Empty, 0, 0)
                        dispErrorInfo()
                        Return False
                    End If
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

#Region " SearchDetailData "
        ''' <summary>
        ''' 明細検索処理
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Function SearchDetailData(ByVal FileId As String, ByVal FileLineNo As String) As Boolean
            Try
                'クライアントチェック
                If Not Me.doCheckClient Then
                    'エラー
                    Return False
                End If

                '入荷実績情報取得
                Me.doSearchDetail(FileId, FileLineNo)

                If m_dtbData.Rows.Count = 0 Then
                    'エラー情報をセット
                    If m_intMode = MODE.Search Then
                        '検索処理
                        SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0007, String.Empty, String.Empty, 0, 0)
                        dispErrorInfo()
                        Return False
                    ElseIf m_intMode = MODE.Detail Then
                        '詳細検索
                        SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0055, String.Empty, String.Empty, 0, 0)
                        dispErrorInfo()
                        Return False
                    End If
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

#Region " SetCsvFile "
        ''' <summary>
        ''' CSVファイルの作成
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Private Function SetCsvFile() As Boolean
            Dim strFilePt As String = String.Empty
            Dim dtbCsv As DataTable = Nothing
            Try
                '処理モード設定
                Me.m_intMode = MODE.CSV

                'クライアントチェック
                If Not Me.doCheckClient Then
                    'エラー
                    Return False
                End If

                '入荷実績情報取得
                Me.doSearch()

                If m_dtbData.Rows.Count = 0 Then
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0007, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                'カーソルを元に戻す
                Me.Cursor = Cursors.Default

                'ダイアログ出力
                If Not ComFiles.OpenSaveDaialogCsv(strFilePt, m_clsAcc, CSV_NM) Then
                    Exit Function
                End If

                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'CSVデータ作成
                dtbCsv = Me.CreateCsvData

                'CSV出力
                If Not ComFiles.OutputCSV(dtbCsv, strFilePt, ComConst.Encode.SHIFTJIS) Then
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0032, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                Return True

            Catch ex As Exception
                Throw ex
            Finally
                '破棄
                If dtbCsv IsNot Nothing Then
                    dtbCsv.Dispose()
                    dtbCsv = Nothing
                End If
            End Try
        End Function

#End Region

#Region " CreateCsvData "
        ''' <summary>
        ''' CSVデータ作成処理
        ''' </summary>
        ''' <returns>CSVデータ</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Function CreateCsvData() As DataTable
            Dim dtbCsv As New DataTable
            Dim clsCsv As New CSV_ITEM
            Dim dtrCsv As DataRow = Nothing
            Try
                'ヘッダ作成
                For Each dtcCsv As DataColumn In m_dtbData.Columns
                    If dtcCsv.ColumnName = "FILE_ID" Then
                        Continue For
                    End If
                    If dtcCsv.ColumnName = "FILE_LINE_NO" Then
                        Continue For
                    End If
                    dtbCsv.Columns.Add(clsCsv.GetColItem(dtcCsv.ColumnName))
                Next

                'データ作成
                For Each dtrData As DataRow In m_dtbData.Rows

                    dtrCsv = dtbCsv.NewRow

                    For intItem As Integer = 0 To m_dtbData.Columns.Count - 3
                        If intItem.Equals(0) Then
                            '作業ステータス
                            Dim st As String = GetWorkStsInstNm(1)
                            dtrCsv.Item(intItem) = dtrData.Item(intItem).ToString & ":" & Me.GetWorkStsInstNm(dtrData.Item(intItem))

                            '出荷日、商品管理日
                            'dtrCsv.Item(intItem) = ComLib.YmdToDateStr(dtrData.Item(intItem).ToString)
                        ElseIf intItem.Equals(20) Then
                            '日時
                            dtrCsv.Item(intItem) = ConvertDateYmdHms(dtrData.Item(intItem).ToString.TrimEnd)
                        Else
                            '上記以外
                            dtrCsv.Item(intItem) = dtrData.Item(intItem)
                        End If
                    Next

                    '行追加
                    dtbCsv.Rows.Add(dtrCsv)
                Next

                Return dtbCsv

            Catch ex As Exception
                Throw ex
            Finally
                dtbCsv.Dispose()
                dtbCsv = Nothing
                clsCsv = Nothing
            End Try
        End Function

#End Region

#Region " SetLogMsg "
        ''' <summary>
        ''' ログ登録するキー情報を設定する
        ''' </summary>
        ''' <param name="pPicres">入荷実績情報</param>
        ''' <returns>ログメッセージ</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Function SetLogMsg(ByVal pPicres As T_Picres) As String
            Try
                Const COMMA As String = "," 'コンマ
                Dim strRet As String = String.Empty '戻り値

                With pPicres
                    ''納品先BLSコード
                    'strRet &= COMMA & .Bls_Deli_Cd

                    ''納品先名称
                    'strRet &= COMMA & .Bls_Deli_Nm

                    '単品JAN
                    strRet &= COMMA & .Jan_Cd

                    'ケースJAN
                    strRet &= COMMA & .Cs_Jan_Cd

                    'ITFコード
                    strRet &= COMMA & .Itf_Cd

                    '商品BLSコード
                    strRet &= COMMA & .Bls_Item_Cd

                    '商品名称
                    strRet &= COMMA & .Bls_Item_Nm

                    'ロケーション
                    strRet &= COMMA & .Loc_Cd

                    '商品管理日
                    strRet &= COMMA & .Item_Mng_Date

                    '更新者名
                    strRet &= COMMA & m_clsSysConfig.InUserNM
                End With

                Return strRet

            Catch ex As Exception
                Throw ex
            End Try

        End Function

#End Region

#Region " 初期化 "

#Region " Init "
        ''' <summary>
        ''' 初期化処理を行います。
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Sub Init()
            Try
                'コンボボックスの設定
                Me.SetCombo1()
                Me.SetCombo()

                '画面の初期化
                Me.Initialize()

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region

#Region " Initialize "
        ''' <summary>
        ''' 初期化処理を行います。
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Private Sub Initialize()
            Dim intIndex As Integer = 0
            Try
                '検索条件
                '入荷予定日
                If String.IsNullOrEmpty(m_strInplanDate) Then
                    '初期値
                    Me.datShipDate.FromValue = Date.Now
                    Me.datShipDate.FromText = Date.Now.ToString(ComConst.Format.VB_DATE_SEP)
                    Me.datShipDate.ToValue = Date.Now
                    Me.datShipDate.ToText = String.Empty
                Else
                    '他画面からの引き継ぎ項目
                    Me.datShipDate.FromValue = ComLib.YmdToDate(m_strInplanDate)
                    Me.datShipDate.FromText = ComLib.YmdToDateStr(m_strInplanDate)
                    '   Me.datShipDate.ToValue = Date.Now
                    '  Me.datShipDate.ToText = String.Empty
                End If

                '発地コード
                If String.IsNullOrEmpty(m_strVendorCd) Then
                    '初期値
                    Me.txtVendorCD.Text = String.Empty
                Else
                    '他画面からの引き継ぎ項目
                    Me.txtVendorCD.Text = m_strVendorCd
                End If

                '発地名称
                If String.IsNullOrEmpty(m_VendorNm) Then
                    '初期値
                    Me.txtVendorNm.Text = String.Empty
                Else
                    '他画面からの引き継ぎ項目
                    Me.txtVendorNm.Text = m_VendorNm
                End If

                'ステータス
                'Me.SetCombo1(m_nvcSts, Me.cmbWorkSts)
                '入荷区分
                If String.IsNullOrEmpty(m_strNyukaKb) Then
                    '初期値
                    Me.cmbInOutKb.SelectedIndex = 0
                Else
                    '他画面からの引き継ぎ項目
                    Me.cmbInOutKb.Text = m_strNyukaKb
                End If

                Me.cmbWorkSts.SelectedIndex = 0

                '単品JAN
                ' Me.txtJanCd.Text = String.Empty
                'ケースJAN
                '  Me.txtCsJanCd.Text = String.Empty
                'ITFコード
                Me.txtInplanNo.Text = String.Empty
                '商品BLSコード
                Me.txtBlsItemCd.Text = String.Empty
                'ロケーション
                Me.txtLocCd.Text = String.Empty
                '商品管理日
                ' Me.datItemMngDate.FromValue = Date.Now
                ' Me.datItemMngDate.FromText = String.Empty
                ' Me.datItemMngDate.ToValue = Date.Now
                ' Me.datItemMngDate.ToText = String.Empty
                '商品名称
                Me.txtItemNm.Text = String.Empty
                '作業者
                Me.txtWorkUserNm.Text = String.Empty
                '一覧
                '選択行の設定
                m_intSelectedRow = -1
                Me.dgvMsi.ClearSelection()

                'グリッドの設定
                Me.setDgvMsi(Me.dgvMsi)
                With Me.dgvMsi
                    .Rows.Clear()
                    .AllowDrop = False                                                  'ユーザによるDrop禁止
                    .AllowUserToAddRows = False                                         'ユーザによる行の追加許可
                    .AllowUserToDeleteRows = True                                       'ユーザによる行の削除禁止
                    .AllowUserToOrderColumns = True                                     'ユーザによる列の入れ替え禁止
                    .AllowUserToResizeColumns = True                                    'ユーザによる列のリサイズ許可
                    .AllowUserToResizeRows = True                                       'ユーザによる行のリサイズ禁止
                    .DeleteCellValue = False                                            'Delete不可
                    .EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2                '直接セル編集可
                    .KeyAction = VariedDataGridView.KeyActions.MoveToNextColRow         'Enter押下時カーソルの移動方向
                    .MultiSelect = True                                                 '複数選択可
                    .PasteCellValue = False                                             '貼付け不可
                    .ReadOnly = False                                                   '編集不可
                    .SelectionMode = DataGridViewSelectionMode.CellSelect               'セル単位で選択
                    .StandardTab = True                                                 'Tab押下時コントロール内を移動
                    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                    .RowCount = 0
                    'セルスタイルの設定
                    .ColumnHeadersDefaultCellStyle.Font = _
                        New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, Drawing.FontStyle.Bold, _
                                         Me.Font.Unit, Me.Font.GdiCharSet, Me.Font.GdiVerticalFont)
                End With

                MyBase.setKomUse(Me.dgvMsi, True)

                MyBase.setYkoRow(dgvMsi.RowCount)
                MyBase.adjustMsi()

                Me.setDgvMsi2(Me.dgvMsiDtl)
                With Me.dgvMsiDtl
                    .Rows.Clear()
                    .AllowDrop = False                                                  'ユーザによるDrop禁止
                    .AllowUserToAddRows = False                                         'ユーザによる行の追加許可
                    .AllowUserToDeleteRows = True                                       'ユーザによる行の削除禁止
                    .AllowUserToOrderColumns = True                                     'ユーザによる列の入れ替え禁止
                    .AllowUserToResizeColumns = True                                    'ユーザによる列のリサイズ許可
                    .AllowUserToResizeRows = True                                       'ユーザによる行のリサイズ禁止
                    .DeleteCellValue = False                                            'Delete不可
                    .EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2                '直接セル編集可
                    .KeyAction = VariedDataGridView.KeyActions.MoveToNextColRow         'Enter押下時カーソルの移動方向
                    .MultiSelect = True                                                 '複数選択可
                    .PasteCellValue = False                                             '貼付け不可
                    .ReadOnly = True                                                    '編集可
                    .SelectionMode = DataGridViewSelectionMode.CellSelect               'セル単位で選択
                    .StandardTab = True                                                 'Tab押下時コントロール内を移動
                    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                    .RowCount = 0
                    'セルスタイルの設定
                    .ColumnHeadersDefaultCellStyle.Font = _
                        New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, Drawing.FontStyle.Bold, _
                                         Me.Font.Unit, Me.Font.GdiCharSet, Me.Font.GdiVerticalFont)
                End With

                MyBase.setKomUse(Me.dgvMsiDtl, True)

                MyBase.setYkoRow2(dgvMsiDtl.RowCount)
                MyBase.adjustMsi2()

                'フォーカス設定
                Me.datShipDate.Focus()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
#End Region

#Region " SetCombo "
        ''' <summary>
        ''' コンボボックスの設定処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo()
            Try
                'ステータス
                Me.SetCombo(Me.cmbInOutKb)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ''' <summary>
        ''' コンボボックスの設定処理
        ''' </summary>
        ''' <param name="robjCbo">コンボボックス</param>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo(ByRef robjCbo As NamedComboBox)
            Dim nvcDat As New NameValueCollection
            Try
                nvcDat = m_clsAcc.FindHaniKbByCombo(ComConst.CODE_KEY.MCODE_45, m_clsVSMSConfig.SysCd, True)
                robjCbo.Items.Clear()
                ComAcs.CreateCombo(robjCbo, nvcDat)

            Catch ex As Exception
                Throw ex
            Finally
                nvcDat = Nothing
            End Try
        End Sub

#End Region
#Region " SetCombo1 "
        ''' <summary>
        ''' コンボボックスの設定処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo1()
            Try
                'ステータス
                'Me.SetCombo1(m_nvcSts, Me.cmbWorkSts)
                Me.SetCombo1(Me.cmbWorkSts)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ''' <summary>
        ''' コンボボックスの設定処理
        ''' </summary>
        ''' <param name="robjCbo">コンボボックス</param>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo1(ByRef robjCbo As NamedComboBox)
            Dim nvcDat As New NameValueCollection
            Try
                nvcDat = m_clsAcc.FindHaniKbByCombo(ComConst.CODE_KEY.MCODE_47, m_clsVSMSConfig.SysCd, True)
                ' If pblnBlank Then
                '空白追加
                'nvcDat.Add(String.Empty, String.Empty)
                '  End If
                robjCbo.Items.Clear()
                ComAcs.CreateCombo(robjCbo, nvcDat)

            Catch ex As Exception
                Throw ex
            Finally
                nvcDat = Nothing
            End Try
        End Sub



#End Region

#End Region

#Region " チェック "

#Region " CheckHeader "
        ''' <summary>
        ''' 検索条件チェック(ヘッダ)
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Private Function CheckHeader() As Boolean
            Try
                Dim strShipDate As String = ComLib.DateToYmd(Me.datShipDate.FromText)

                '必須チェック
                If String.IsNullOrEmpty(strShipDate) Then
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0003, String.Empty, Me.datShipDate.Name, 0, 0)
                    Return False
                End If

                '検索条件初期化
                m_clsAcc.g_srtPicres = New T_Picres

                '検索条件セット
                With m_clsAcc.g_srtPicres
                    .Sys_Cd = m_clsVSMSConfig.SysCd
                    .Center_Cd = m_strCenterCd

                    .Ship_Date = strShipDate        '入荷予定日
                    .Vendor_Cd = Me.txtVendorCD.Text.TrimEnd  '発送地名称
                    .Vendor_Nm = Me.txtVendorNm.Text.TrimEnd  '発送地コード
                    .Work_Sts = ComAcs.GetCboItem(Me.cmbWorkSts)
                    ' .Jan_Cd = Me.txtJanCd.Text.TrimEnd
                    ' .Cs_Jan_Cd = Me.txtCsJanCd.Text.TrimEnd
                    .Itf_Cd = Me.txtInplanNo.Text.TrimEnd
                    .Bls_Item_Cd = Me.txtBlsItemCd.Text.TrimEnd
                    .Loc_Cd = Me.txtLocCd.Text.TrimEnd
                    ' .Item_Mng_Date = ComLib.DateToYmd(Me.datItemMngDate.FromText)
                    .Bls_Item_Nm = Me.txtItemNm.Text.TrimEnd
                    .Work_User_Nm = Me.txtWorkUserNm.Text.TrimEnd
                End With

                Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region " CheckDetail "
        ''' <summary>
        ''' 一覧チェック
        ''' </summary>
        ''' <remarks>詳細表示に使用される</remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Private Sub CheckDetail()
            Try
                '検索条件初期化
                m_clsAcc.g_srtPicres = New T_Picres

                With Me.dgvMsi.Rows(m_intSelectedRow)
                    m_clsAcc.g_srtPicres.Sys_Cd = m_clsVSMSConfig.SysCd
                    m_clsAcc.g_srtPicres.Center_Cd = m_strCenterCd

                    'm_clsAcc.g_srtPicres.Ship_Date = ComLib.DateToYmd(.Cells(Me.colArrivalKbn.Index).Value.ToString)    '入荷予定日
                    'm_clsAcc.g_srtPicres.Arrival_Kbn = ComLib.ToStrEx(.Cells(Me.colArrivalKbn.Index).Value) '入荷区分
                    'm_clsAcc.g_srtPicres.Bls_Deli_Cd = ComLib.ToStrEx(.Cells(Me.colBlsDeliCd.Index).Value)  'nothing
                    'm_clsAcc.g_srtPicres.Bls_Item_Cd = ComLib.ToStrEx(.Cells(Me.colBlsItemCd.Index).Value)  '商品BLSコード
                    'm_clsAcc.g_srtPicres.Jan_Cd = ComLib.ToStrEx(.Cells(Me.colJanCd.Index).Value)           'JAN
                    'm_clsAcc.g_srtPicres.Cs_Jan_Cd = ComLib.ToStrEx(.Cells(Me.colCsJanCd.Index).Value)      'ケースJAN
                    'm_clsAcc.g_srtPicres.Itf_Cd = ComLib.ToStrEx(.Cells(Me.colItfCd.Index).Value)           'ITFコード
                    'm_clsAcc.g_srtPicres.Loc_Cd = ComLib.ToStrEx(.Cells(Me.colLocCd.Index).Value)           'Location
                    'm_clsAcc.g_srtPicres.Item_Mng_Date = ComLib.DateToYmd(.Cells(Me.colItemMngDate.Index).Value.ToString)   'nothing
                    'm_clsAcc.g_srtPicres.Work_Sts = ComLib.ToStrEx(.Cells(Me.colWorkStsVal.Index).Value)    'STATUS

                    'm_clsAcc.g_srtPicres. = ComLib.ToStrEx(.Cells(Me.colDetail.Index).Value.ToString)    '詳細ボタン
                    m_clsAcc.g_srtPicres.Work_Sts = ComLib.ToStrEx(.Cells(Me.colWorkStsVal.Index).Value.ToString)   'WORK_STS
                    m_clsAcc.g_srtPicres.Arrival_Kbn  = ComLib.ToStrEx(.Cells(Me.colArrivalKbn.Index).Value.ToString)    '入荷区分
                    m_clsAcc.g_srtPicres.Vendor_Cd = ComLib.ToStrEx(.Cells(Me.colVendorCd.Index).Value.ToString)  '発送地
                    m_clsAcc.g_srtPicres.Vendor_Nm = ComLib.ToStrEx(.Cells(Me.colVendorNm.Index).Value.ToString)  '発送地
                    m_clsAcc.g_srtPicres.Bls_Item_Cd = ComLib.ToStrEx(.Cells(Me.colBlsItemCd.Index).Value.ToString) '商品
                    m_clsAcc.g_srtPicres.Bls_Item_Nm = ComLib.ToStrEx(.Cells(Me.colBlsItemNm.Index).Value.ToString) '商品
                    m_clsAcc.g_srtPicres.Item_Mng_Date = ComLib.ToStrEx(.Cells(Me.colItemMngDate.Index).Value.ToString)   '商品管理日

                    m_clsAcc.g_srtPicres.CsCarton = ComLib.ToDecEx(.Cells(Me.colCsCarton.Index).Value.ToString)  '入数
                    m_clsAcc.g_srtPicres.ExpCsQty = ComLib.ToDecEx(.Cells(Me.colExpCsQty.Index).Value.ToString)  '予定数ケース
                    m_clsAcc.g_srtPicres.ExpPsQty = ComLib.ToDecEx(.Cells(Me.colExpPsQty.Index).Value.ToString)  '予定数バラ
                    m_clsAcc.g_srtPicres.ExpSpsQty = ComLib.ToDecEx(.Cells(Me.colExpSpsQty.Index).Value.ToString)  '予定数総
                    m_clsAcc.g_srtPicres.ActCsQty = ComLib.ToDecEx(.Cells(Me.colActCsQty.Index).Value.ToString)  '実績数ケース
                    m_clsAcc.g_srtPicres.ActPsQty = ComLib.ToDecEx(.Cells(Me.colActPsQty.Index).Value.ToString)  '実績数バラ
                    m_clsAcc.g_srtPicres.ActSpsQty = ComLib.ToDecEx(.Cells(Me.colActSpsQty.Index).Value.ToString)  '実績数総

                    m_clsAcc.g_srtPicres.WarMngDate = ComLib.ToStrEx(.Cells(Me.colWarMngDate.Index).Value.ToString)    '在庫最新管理日
                    m_clsAcc.g_srtPicres.RejectKbn = ComLib.ToStrEx(.Cells(Me.colRejKb.Index).Value.ToString)    '不良品
                    m_clsAcc.g_srtPicres.InplanNo = ComLib.ToStrEx(.Cells(Me.colInplanNo.Index).Value.ToString)  '入荷予定No
                    m_clsAcc.g_srtPicres.Loc_Cd = ComLib.ToStrEx(.Cells(Me.colLocCd.Index).Value.ToString) 'location
                    m_clsAcc.g_srtPicres.Jan_Cd = ComLib.ToStrEx(.Cells(Me.colJanCd.Index).Value.ToString) 'JAN
                    m_clsAcc.g_srtPicres.Cs_Jan_Cd = ComLib.ToStrEx(.Cells(Me.colCsJanCd.Index).Value.ToString)   'JANケース
                    m_clsAcc.g_srtPicres.Itf_Cd = ComLib.ToStrEx(.Cells(Me.colItfCd.Index).Value.ToString) 'ITF
                    m_clsAcc.g_srtPicres.FILE_ID = ComLib.ToStrEx(.Cells(Me.colFILE_ID.Index).Value.ToString)   'FILE_ID
                    m_clsAcc.g_srtPicres.FILE_LINE_NO = ComLib.ToStrEx(.Cells(Me.colFILE_LINE_NO.Index).Value.ToString)  'FILE_LINE_NO

                End With

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region

#Region "-- CheckLstData "
        '''' <summary>
        '''' 一覧チェック
        '''' </summary>
        '''' <returns>True:正常, False:異常</returns>
        '''' <remarks></remarks>
        '''' <history>S.Toshino 2018/09/05 Created</history>
        'Private Function CheckLstData() As Boolean
        '    Try
        '        Dim clsDat As Acc.AccVSMSS110.T_Picres = Nothing
        '        m_lstPicres = New List(Of T_Picres)
        '        m_lstPicresLog = New List(Of T_Picres)

        '        With Me.dgvMsi
        '            For intRow = 0 To .Rows.Count - 1

        '                '欠品チェックボックスが読み取り専用の場合はスキップ
        '                If .Rows(intRow).Cells(Me.colWrokSts.Index).ReadOnly Then
        '                    Continue For
        '                End If

        '                '欠品チェックボックス
        '                Dim chkWork As String = .Rows(intRow).Cells(Me.colWrokSts.Index).Value.ToString
        '                Dim chkWorkHidden As String = .Rows(intRow).Cells(Me.colWorkStsHidden.Index).Value.ToString

        '                '欠品チェックボックス変更判定(検索時のチェックボックスが変更された行のみ)
        '                If Not chkWork.Equals(chkWorkHidden) Then
        '                    clsDat = New T_Picres
        '                    clsDat.Sys_Cd = m_clsVSMSConfig.SysCd
        '                    clsDat.Center_Cd = m_strCenterCd

        '                    '作業ステータス
        '                    If CBool(chkWork) Then
        '                        '欠品
        '                        clsDat.Work_Sts = WORK_STS_SHORTAGE
        '                    Else
        '                        '未完了
        '                        clsDat.Work_Sts = WORK_STS_UNFINISHED
        '                    End If

        '                    clsDat.Ship_Date = ComLib.DateToYmd(.Rows(intRow).Cells(Me.colArrivalKbn.Index).Value.ToString)
        '                    clsDat.Bls_Deli_Cd = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colBlsDeliCd.Index).Value)
        '                    clsDat.Bls_Deli_Nm = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colBlsDeliNm.Index).Value)
        '                    clsDat.Bls_Item_Cd = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colBlsItemCd.Index).Value)
        '                    clsDat.Bls_Item_Nm = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colBlsItemNm.Index).Value)
        '                    clsDat.Jan_Cd = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colJanCd.Index).Value)
        '                    clsDat.Cs_Jan_Cd = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colCsJanCd.Index).Value)
        '                    clsDat.Itf_Cd = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colItfCd.Index).Value)
        '                    clsDat.Loc_Cd = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colLocCd.Index).Value)
        '                    clsDat.Item_Mng_Date = ComLib.DateToYmd(.Rows(intRow).Cells(Me.colItemMngDate.Index).Value.ToString)
        '                    clsDat.Pre_Upd_Yb = ComLib.ToStrEx(.Rows(intRow).Cells(Me.colPreUpdYb.Index).Value)
        '                    clsDat.Upd_Yb_Now = m_strSysDate
        '                    clsDat.Row = intRow
        '                    m_lstPicres.Add(clsDat)
        '                    m_lstPicresLog.Add(clsDat)
        '                End If
        '            Next
        '        End With

        '        If m_lstPicres.Count = 0 Then
        '            'チェックがない場合
        '            'エラー情報をセット
        '            SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0063, String.Empty, Me.dgvMsi.Name, 1, 0)
        '            Return False
        '        End If

        '        Return True

        '    Catch ex As Exception
        '        Throw ex
        '    End Try

        'End Function

#End Region

#End Region

#Region " 更新処理 "

#End Region

#Region " 値取得 "

#Region " GetWorkStsInstNm "
        ''' <summary>
        ''' 作業ステータス(指示)名称取得処理
        ''' </summary>
        ''' <param name="pobjWorkSts">作業ステータス</param>
        ''' <returns>値</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Function GetWorkStsInstNm(ByVal pobjWorkSts As Object) As String
            Try
                Return m_nvcSts(pobjWorkSts.ToString)

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region " GetErrRow "
        ''' <summary>
        ''' エラー行No取得
        ''' </summary>
        ''' <returns>エラー行No</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Function GetErrRow() As Integer
            Dim intVal As Integer = 0
            Dim lstCnt As Integer = m_lstPicres.Count - 1
            Try
                If lstCnt >= m_Update_Cnt Then
                    intVal = m_lstPicres(m_Update_Cnt).Row
                End If

                Return intVal

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#End Region

#Region " 日付変換"

#Region " ConvertDateYmdHms "
        ''' <summary>
        ''' 日付変換処理
        ''' </summary>
        ''' <returns>エラー行No</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Function ConvertDateYmdHms(ByVal pVal As String) As String
            Dim ret As String = String.Empty
            Try
                If String.IsNullOrEmpty(pVal) Then
                    Return ret
                End If
                If pVal.Length > 14 Then
                    ret = pVal.Substring(0, 14)
                End If
                ret = ComLib.YmdHmsToDateStr(ret).TrimEnd
                Return ret
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#End Region

#End Region

#End Region


    End Class

End Namespace
