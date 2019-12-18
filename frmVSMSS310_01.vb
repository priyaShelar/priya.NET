'----------------------------------------------------------------------------------------------
'  機能名　　　　    : 棚卸実績照会
'  機能説明　　　    : 棚卸実績を表示
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
Imports VWS.VSMS.VSMSS310.Acc.AccVSMSS310
Imports VWS.VSMS.VSMSS210
Imports VWS.VSMS.VSMSS210.Forms
Imports VWS.VSMS.VSMSLib.Resources
Imports VWS.BaseSpreadsheetGearOpen.Base.BaseSpreadsheetGear
Imports VWS.VSMSReports
Imports VWS.VSMSReports.Forms

Namespace Forms
    ''' <summary>
    ''' 棚卸実績照会画面クラス
    ''' </summary>
    ''' <remarks>棚卸実績を表示。</remarks>
    ''' <history> Arche Inc 2019/09/24 Created</history>
    Public Class frmVSMSS310_01

#Region " 定数 "
        ''' <summary>CSVファイル名</summary>
        Private Const CSV_NM As String = "棚卸実績一覧_" & ComConst.Format.VB_DATETIME & ".csv"
        ''' <summary>ハイフン</summary>
        Private Const HAFN As String = "-"
        ''' <summary>パーセント</summary>
        Private Const PERCENT As String = "%"
        ''' <summary>進捗グラフのタイトル</summary>
        Private Const PROC_TITLE As String = "0%                        50%                     100%"
#End Region

#Region " 構造体 CSV_ITEM "
        ''' <summary>
        ''' CSV作成用構造体
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Private Structure CSV_ITEM

#Region " 定数 "
            ''' <summary>作業ステータス</summary>
            Public Const WORK_STS As String = "ステータス"

            ''' <summary>商品BLSコード</summary>
            Public Const BLS_ITEM_CD As String = "商品BLSコード"

            ''' <summary>商品名称</summary>
            Public Const BLS_ITEM_NM As String = "商品名称"

            ''' <summary>商品管理日</summary>
            Public Const ITEM_MNG_DATE As String = "商品管理日"

            ''' <summary>商品管理日</summary>
            Public Const R_ITEM_MNG_DATE As String = "実績商品管理日"

            ''' <summary>入数</summary>
            Public Const CS_CARTON As String = "入数"

            ''' <summary>指示数(ケース)</summary>
            Public Const EXP_CS_QTY As String = "指示数(ケース)"

            ''' <summary>指示数(バラ)</summary>
            Public Const EXP_PL_QTY As String = "指示数(バラ)"

            ''' <summary>指示数(総バラ)</summary>
            Public Const EXP_SPL_QTY As String = "指示数(総バラ)"

            ''' <summary>実績数(ケース)</summary>
            Public Const R_S_ACT_CS_QTY As String = "実績数(ケース)"

            ''' <summary>実績数(バラ)</summary>
            Public Const R_S_ACT_PS_QTY As String = "実績数(バラ)"

            ''' <summary>実績数(総バラ)</summary>
            Public Const R_S_ACT_SPS_QTY As String = "実績数(総バラ)"

            ''' <summary>差異数(ケース)</summary>
            Public Const DIF_CS_QTY As String = "差異数(ケース)"

            ''' <summary>差異数(バラ)</summary>
            Public Const DIF_PL_QTY As String = "差異数(バラ)"

            ''' <summary>差異数(総バラ)</summary>
            Public Const DIF_SPL_QTY As String = "差異数(総バラ)"

            ''' <summary>不良品区分</summary>
            Public Const REJECT_KB As String = "不良品区分"

            ''' <summary>ピッキングゾーン</summary>
            Public Const PICK_ZONE As String = "ゾーン"

            ''' <summary>ロケーション</summary>
            Public Const LOC_CD As String = "ロケーション"

            ''' <summary>棚卸NO</summary>
            Public Const INV_NO As String = "棚卸NO"

            ''' <summary>棚卸範囲区分</summary>
            Public Const INV_KB As String = "棚卸範囲区分"

            ''' <summary>単品JAN</summary>
            Public Const JAN_CD As String = "単品JAN"

            ''' <summary>ケースJAN</summary>
            Public Const CS_JAN_CD As String = "ケースJAN"

            ''' <summary>ITFコード</summary>
            Public Const ITF_CD As String = "ITFコード"

            ''' <summary>作業日時</summary>
            Public Const WORK_DATE As String = "作業日"

            ''' <summary>作業者</summary>
            Public Const WORK_USER_NM As String = "作業者名称"

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

#Region " 変数 "
        ''' <summary>実行モード</summary>
        Private m_intMode As Integer

        ''' <summary>検索結果</summary>
        Private m_dtbData As DataTable = Nothing
        Private m_dtzData As DataTable = Nothing

        ''' <summary>タイマー</summary>
        Private m_timerUpdate As Timer

        ''' <summary>システムコード</summary>
        Private m_strSysCd As String = String.Empty

        ''' <summary>棚卸実施日</summary>
        Private m_strShipDate As String

        Private m_strTanaKbn As String

        Private m_strTanaNo As String

        Private m_strZONE As String

        Private m_strBlsDeliNm As String

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
            ''' <summary>帳票出力</summary>
            Print
        End Enum

#End Region

#Region " インスタンス "
        ''' <summary>DBアクセスクラス</summary>
        Private m_clsAcc As Acc.AccVSMSS310 = Nothing
        ''' <summary>ステータス情報</summary>
        Private m_nvcSts As New NameValueCollection
#End Region

#End Region

#Region " プロパティ "

#Region " SHIP_DATE "
        ''' <summary>
        ''' 棚卸実施日
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public WriteOnly Property SHIP_DATE() As String
            Set(ByVal value As String)
                m_strShipDate = value
            End Set
        End Property
#End Region

#Region " TANA_KBN "
        ''' <summary>
        ''' 棚卸区分
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history> 2019/09/07 Created</history>
        Public WriteOnly Property TANA_KBN() As String
            Set(ByVal value As String)
                m_strTanaKbn = value
            End Set
        End Property
#End Region

#Region " TANA_NO "
        ''' <summary>
        ''' 棚卸NO
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history> 2019/09/07 Created</history>
        Public WriteOnly Property TANA_NO() As String
            Set(ByVal value As String)
                m_strTanaNo = value
            End Set
        End Property
#End Region

#Region " ZONE "
        ''' <summary>
        ''' ゾーン
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public WriteOnly Property ZONE() As String
            Set(ByVal value As String)
                m_strZONE = value
            End Set
        End Property
#End Region

#Region " BLS_DELI_NM "
        ''' <summary>
        ''' BLS_DELI_NM
        ''' </summary>
        ''' <value></value>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/10/31 Created</history>
        Public WriteOnly Property BLS_DELI_NM() As String
            Set(ByVal value As String)
                m_strBlsDeliNm = value
            End Set
        End Property
#End Region
#End Region

#Region " コンストラクタ "

        Public Sub New()
            MyBase.New(ComConst.ProgramID.PGIDS310)
            Try
                ' この呼び出しは、Windows フォーム デザイナで必要です。
                InitializeComponent()

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub
#End Region

#Region " イベント "

#Region " frmVSMSS220_01_Load "
        ''' <summary>
        ''' 画面起動時の処理を行います
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub frmVSMSS310_01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

#Region " frmVSMSS310_01_Shown "
        ''' <summary>
        ''' 画面表示時の処理を行います
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub frmVSMSS310_01_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                '画面の初期化
                Me.Init()

                MyBase.adjustMsi()

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'カーソルを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " frmVSMSS310_01_Disposed "
        ''' <summary>
        ''' 画面破棄時の処理
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub frmVSMSS220_01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

            'タイマーを使用不可にする
            If m_timerUpdate IsNot Nothing Then
                m_timerUpdate.Enabled = False
            End If

        End Sub

#End Region

#Region " doCheckBusiness "
        ''' <summary>
        ''' 業務ﾁｪｯｸ処理を行います。
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Protected Overrides Function doCheckBusiness() As Boolean
            Try
                Select Case m_intMode
                    Case MODE.CSV  '検索,CSV
                        '検索条件のﾁｪｯｸ
                        If Not Me.CheckHeader() Then
                            Return False
                        End If
                    Case MODE.Print  '差異リスト
                        '検索条件のﾁｪｯｸ
                        If Not Me.CheckInput() Then
                            Return False
                        End If
                End Select

                Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region " CheckHeader "
        ''' <summary>
        ''' 検索条件ﾁｪｯｸ(ﾍｯﾀﾞ)
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Private Function CheckHeader() As Boolean
            Try
                Dim strShipDate As String = ComLib.DateToYmd(Me.datShipDate.FromText)
                Me.ChkRejectKb.BackColor = Color.Transparent     '不良品区分
                Me.chkDiffren.BackColor = Color.Transparent      '差異あり
                '必須チェック
                If String.IsNullOrEmpty(strShipDate) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0003, String.Empty, Me.datShipDate.Name, 0, 0)
                    Return False
                End If

                Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
#Region " CheckInput "
        ''' <summary>
        ''' 検索条件ﾁｪｯｸ(ﾍｯﾀﾞ)
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Private Function CheckInput() As Boolean
            Try

                Me.ChkRejectKb.BackColor = Color.Transparent     '不良品区分
                Me.chkDiffren.BackColor = Color.Transparent      '差異あり

                '必須チェック
                If Not String.IsNullOrEmpty(Me.cmbWorkSts.Text) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.cmbWorkSts.Name, 0, 0)
                    Return False
                End If
                If chkDiffren.Checked = True Then
                    'ｴﾗｰ情報をｾｯﾄ
                    ' SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.chkDiffren.Name, 0, 0)
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.chkDiffren.Name, 0, 0)
                    Return False
                End If
                If Not String.IsNullOrEmpty(Me.cmbZaikoChk.Text) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.cmbZaikoChk.Name, 0, 0)
                    Return False
                End If
                If Not String.IsNullOrEmpty(Me.txtItemNm.Text) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.txtItemNm.Name, 0, 0)
                    Return False
                End If
                If Not String.IsNullOrEmpty(Me.txtBlsItemCd.Text) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.txtBlsItemCd.Name, 0, 0)
                    Return False
                End If
                If Not String.IsNullOrEmpty(Me.txtWorkUserNm.Text) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.txtWorkUserNm.Name, 0, 0)
                    Return False
                End If
                If Not String.IsNullOrEmpty(Me.txtTanaOroshiNo.Text) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.txtTanaOroshiNo.Name, 0, 0)
                    Return False
                End If
                If Not String.IsNullOrEmpty(Me.txtLocation.Text) Then

                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.txtLocation.Name, 0, 0)
                    Return False
                End If
                If ChkRejectKb.Checked = True Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0073, String.Empty, Me.ChkRejectKb.Name, 0, 0)
                    Return False
                End If
                Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
#Region " btnSearch_Click "
        ''' <summary>
        ''' 検索ボタン押下処理
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                '描画停止
                Me.SuspendLayout()

                '処理ﾓｰﾄﾞ設定
                Me.m_intMode = MODE.Search

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
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
            Try

                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'クリア
                resetParams()

                '初期化
                Me.Init()

                MyBase.adjustMsi(1)

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

        Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS310(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS310.DbAccessResultStatus.Normal) Then
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

#Region " btnUpdate_Click "
        ''' <summary>
        ''' 差異ボタン押下処理
        ''' </summary>
        ''' <param name="sender">イベントソース</param>
        ''' <param name="e">イベントデータ</param>
        ''' <remarks></remarks>
        ''' <history> 2019/10/23 Created</history>
        Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutDifList.Click
            Try
                'カーソルを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                '描画停止
                Me.SuspendLayout()

                '処理ﾓｰﾄﾞ設定
                Me.m_intMode = MODE.Print

                '検索処理
                If Not SearchDiffData() Then
                    Return
                End If

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'DBのクローズ
                Me.DbClose(CType(m_clsAcc, ComAccBase))

                'ｶｰｿﾙを元に戻す
                Me.Cursor = Cursors.Default
            End Try

        End Sub
#End Region

#Region " ShowData "
        ''' <summary>
        ''' ﾌﾟﾚﾋﾞｭｰ処理
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/10/31 Created</history>
        Private Function ShowData() As Boolean

            Try

                'ﾃﾞｰﾀｾｯﾄ新規作成
                Dim dtsRptData As New dtsVSMSP99D
                Me.SetData(dtsRptData)

                If dtsRptData.TanaSaiList.Rows.Count = 0 Then
                    'エラー処理
                    Me.ErrAfter()
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0007, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return True
                End If

                'ﾚﾎﾟｰﾄｵﾌﾞｼﾞｪｸﾄの作成
                Dim rptReport As rptVSMSP99D = New rptVSMSP99D

                'ﾃﾞｰﾀをｸﾘｽﾀﾙﾚﾎﾟｰﾄに渡す
                Using frmDat As New VSMSReports.Forms.frmVSMSP010_01(rptReport, dtsRptData)
                    frmDat.ShowDialog(Me)
                End Using


                Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

#Region "SetData"
        ''' <summary>
        ''' 棚卸差異リスト帳票データセット処理
        ''' </summary>
        ''' <param name="rdtsRptData">帳票用ﾃﾞｰﾀｾｯﾄ</param>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/10/31 Created</history>
        Private Sub SetData(ByRef rdtsRptData As dtsVSMSP99D)
            Dim rej_kb As String
            Dim param As New FindNyukaKb
            Dim tmpLocCd As String = "0000000"
            Dim tmpZone As String = ""
            Dim tmpListName As String = ""
            Dim tmpFileId As String = ""
            Dim tmpFileLineNo As String = ""
            Dim LocCd As String = ""

            Try
                ' set the zon-zero suryo
                For Each dtrData As DataRow In m_dtbData.Rows

                    Dim dtrDat As dtsVSMSP99D.TanaSaiListRow = _
                          CType(rdtsRptData.TanaSaiList.NewRow, dtsVSMSP99D.TanaSaiListRow)

                    If (dtrData.Item("SUM_DIF_CS_QTY").ToString.Trim.Equals("0")) AndAlso _
                       (dtrData.Item("SUM_DIF_PL_QTY").ToString.Trim.Equals("0")) AndAlso _
                       (dtrData.Item("SUM_DIF_SPL_QTY").ToString.Trim.Equals("0")) AndAlso _
                        (dtrData.Item("MNG_DT_CNT").ToString.Trim.Equals("0")) Then
                        Continue For
                    End If

                    If (dtrData.Item("EXP_SPL_QTY").ToString).Equals("0") Then
                        Continue For
                    ElseIf (dtrData.Item("INV_KB").ToString).Equals("1") Then
                        dtrDat.rptListName = "当日稼働品・差異"
                    ElseIf (dtrData.Item("INV_KB").ToString).Equals("2") Then
                        dtrDat.rptListName = "循環棚卸・差異"
                    End If


                    '不良品区分
                    Dim strRejkb As String = ComLib.ToStrEx(dtrData.Item("REJECT_KB"))
                    rej_kb = ""
                    If strRejkb.Trim().Length > 0 Then
                        param.Status = ComConst.CODE_KEY.MCODE_17
                        param.Code = strRejkb
                        param.SysCd = dtrData.Item("SYS_CD").ToString
                        rej_kb = m_clsAcc.FindStatus(param)
                    End If

                    Dim dtS As String = ComLib.DateToYmd(Me.datShipDate.FromText)    '棚卸実施日
                    If dtS.Length >= 8 Then
                        dtS = dtS.Substring(2, 2) & "/" & dtS.Substring(4, 2) & "/" & dtS.Substring(6, 2)
                    End If

                    dtrDat.rptShipDate = dtS
                    dtrDat.rptTanaOroshiNo = dtrData.Item("INV_NO").ToString                    '棚卸NO
                    dtrDat.rptZone = dtrData.Item("PICK_ZONE").ToString                         'ゾーン
                    dtrDat.rptCenterNm = dtrData.Item("CENTER_CD").ToString & ":" & dtrData.Item("CENTER_NM").ToString
                    dtrDat.rptBlsItemNm = dtrData.Item("BLS_ITEM_CD") & " " & dtrData.Item("BLS_ITEM_NM")
                    dtrDat.rptMaker = dtrData.Item("VENDOR_CD") & " " & dtrData.Item("VENDOR_NM")
                    dtrDat.rptDefItem = rej_kb
                    LocCd = dtrData.Item("LOC_CD").ToString.Trim
                    dtrDat.rptLocCd = If(LocCd.Length <= 4, "", LocCd.Substring(3)).Trim
                    dtrDat.rptLocPart = If(LocCd.Length <= 3, LocCd, LocCd.Substring(0, 3)).Trim

                    If Not IsDBNull(dtrData.Item("R_ITEM_MNG_DATE")) Then
                        Dim dtRMng As String = dtrData.Item("R_ITEM_MNG_DATE")
                        If dtRMng.Length >= 8 Then
                            dtRMng = dtRMng.Substring(2, 2) & "/" & dtRMng.Substring(4, 2) & "/" & dtRMng.Substring(6, 2)
                        End If
                        dtrDat.rptRItemMngDate = dtRMng
                    End If


                    Dim dtMng As String = dtrData.Item("ITEM_MNG_DATE")
                    If dtMng.Length >= 8 Then
                        dtMng = dtMng.Substring(2, 2) & "/" & dtMng.Substring(4, 2) & "/" & dtMng.Substring(6, 2)
                    End If

                    dtrDat.rptInvItemMngDate = dtMng

                    dtrDat.rptZaikoCsQty = FormatNumber(dtrData.Item("EXP_CS_QTY"), 0, , , )
                    dtrDat.rptZaikoLotQty = FormatNumber(dtrData.Item("EXP_PL_QTY"), 0, , , )
                    dtrDat.rptZaikoTtl = FormatNumber(dtrData.Item("EXP_SPL_QTY"), 0, , , )
                    dtrDat.rptActCsQty = FormatNumber(dtrData.Item("R_S_ACT_CS_QTY"), 0, , , )
                    dtrDat.rptActLotQty = FormatNumber(dtrData.Item("R_S_ACT_PS_QTY"), 0, , , )
                    dtrDat.rptActTtl = FormatNumber(dtrData.Item("R_S_ACT_SPS_QTY"), 0, , , )
                    dtrDat.rptDifCsQty = FormatNumber(dtrData.Item("DIF_CS_QTY"), 0, , , )
                    dtrDat.rptDifLotQty = FormatNumber(dtrData.Item("DIF_PL_QTY"), 0, , , )
                    dtrDat.rptDifTtl = FormatNumber(dtrData.Item("DIF_SPL_QTY"), 0, , , )


                    If (tmpFileId.Equals(dtrData.Item("FILE_ID").ToString.Trim) AndAlso tmpFileLineNo.Equals(dtrData.Item("FILE_LINE_NO").ToString.Trim)) Then
                        dtrDat.rptInvItemMngDate = ""
                        dtrDat.rptZaikoCsQty = ""
                        dtrDat.rptZaikoLotQty = ""
                        dtrDat.rptZaikoTtl = ""
                        dtrDat.rptBlsItemNm = ""
                        'dtrDat.rptLocCd = ""
                        'dtrDat.rptLocPart = ""
                        dtrDat.rptMaker = ""
                        dtrDat.rptDifCsQty = FormatNumber(dtrData.Item("R_S_ACT_CS_QTY"), 0, , , )
                        dtrDat.rptDifLotQty = FormatNumber(dtrData.Item("R_S_ACT_PS_QTY"), 0, , , )
                        dtrDat.rptDifTtl = FormatNumber(dtrData.Item("R_S_ACT_SPS_QTY"), 0, , , )
                    End If

                    tmpLocCd = dtrData.Item("LOC_CD")
                    If dtrData.IsNull("PICK_ZONE") Then
                        tmpZone = ""
                    Else
                        tmpZone = dtrData.Item("PICK_ZONE")
                    End If
                    ' tmpZone = dtrData.Item("PICK_ZONE")
                    tmpFileId = dtrData.Item("FILE_ID")
                    tmpFileLineNo = dtrData.Item("FILE_LINE_NO")
                    tmpListName = dtrDat.rptListName
                    LocCd = ""
                    rdtsRptData.TanaSaiList.AddTanaSaiListRow(dtrDat)
                Next

                tmpLocCd = "0000000"
                tmpZone = ""
                tmpListName = ""
                tmpFileId = ""
                tmpFileLineNo = ""
                LocCd = ""

                ' set the zero suryo

                For Each dtrData As DataRow In m_dtbData.Rows

                    Dim dtrDat As dtsVSMSP99D.TanaSaiListRow = _
                          CType(rdtsRptData.TanaSaiList.NewRow, dtsVSMSP99D.TanaSaiListRow)

                    If Not (dtrData.Item("EXP_SPL_QTY").ToString).Equals("0") Then
                        Continue For
                    End If


                    dtrDat.rptListName = "当日稼働品・在庫ゼロ"

                    '不良品区分
                    Dim strRejkb As String = ComLib.ToStrEx(dtrData.Item("REJECT_KB"))
                    rej_kb = ""
                    If strRejkb.Trim().Length > 0 Then
                        param.Status = ComConst.CODE_KEY.MCODE_17
                        param.Code = strRejkb
                        param.SysCd = dtrData.Item("SYS_CD").ToString
                        rej_kb = m_clsAcc.FindStatus(param)
                    End If

                    Dim dtS As String = ComLib.DateToYmd(Me.datShipDate.FromText)    '棚卸実施日
                    If dtS.Length >= 8 Then
                        dtS = dtS.Substring(2, 2) & "/" & dtS.Substring(4, 2) & "/" & dtS.Substring(6, 2)
                    End If

                    dtrDat.rptShipDate = dtS
                    dtrDat.rptTanaOroshiNo = dtrData.Item("INV_NO").ToString                    '棚卸NO
                    dtrDat.rptZone = dtrData.Item("PICK_ZONE").ToString                                'ゾーン

                    If (dtrData.Item("EXP_SPL_QTY").ToString).Equals("0") Then
                        dtrDat.rptListName = "当日稼働品・在庫ゼロ"
                    End If


                    'If tmpListName.Equals(dtrDat.rptListName) AndAlso tmpZone.Equals(dtrDat.rptZone) Then
                    '    If (tmpLocCd.Equals(dtrData.Item("LOC_CD").ToString.Trim)) Then
                    '        ' dtrDat.rptLocCd = dtrData.Item("LOC_CD").ToString.Trim
                    '        dtrDat.rptLocCd = "    " & If(LocCd.Length <= 4, LocCd, LocCd.Substring(LocCd.Length - 4)).Trim

                    '    Else

                    '        If tmpLocCd.Substring(0, 3).EndsWith(dtrData.Item("LOC_CD").ToString.Substring(0, 3)) Then

                    '            dtrDat.rptLocCd = "    " & If(LocCd.Length <= 4, LocCd, LocCd.Substring(LocCd.Length - 4)).Trim

                    '        Else
                    '            dtrDat.rptLocCd = dtrData.Item("LOC_CD").ToString.Trim
                    '        End If
                    '    End If
                    'Else
                    '    dtrDat.rptLocCd = dtrData.Item("LOC_CD").ToString.Trim
                    'End If

                    dtrDat.rptCenterNm = dtrData.Item("CENTER_CD").ToString & ":" & dtrData.Item("CENTER_NM").ToString
                    dtrDat.rptBlsItemNm = dtrData.Item("BLS_ITEM_CD") & " " & dtrData.Item("BLS_ITEM_NM")
                    dtrDat.rptMaker = dtrData.Item("VENDOR_CD") & " " & dtrData.Item("VENDOR_NM")
                    dtrDat.rptDefItem = rej_kb
                    LocCd = dtrData.Item("LOC_CD").ToString.Trim
                    dtrDat.rptLocCd = If(LocCd.Length <= 4, "", LocCd.Substring(3)).Trim
                    dtrDat.rptLocPart = If(LocCd.Length <= 3, LocCd, LocCd.Substring(0, 3)).Trim


                        If Not IsDBNull(dtrData.Item("R_ITEM_MNG_DATE")) Then
                        Dim dtRMng As String = dtrData.Item("R_ITEM_MNG_DATE")
                            If dtRMng.Length >= 8 Then
                                dtRMng = dtRMng.Substring(2, 2) & "/" & dtRMng.Substring(4, 2) & "/" & dtRMng.Substring(6, 2)
                            End If
                            dtrDat.rptRItemMngDate = dtRMng
                        End If



                        Dim dtMng As String = dtrData.Item("ITEM_MNG_DATE")
                        If dtMng.Length >= 8 Then
                            dtMng = dtMng.Substring(2, 2) & "/" & dtMng.Substring(4, 2) & "/" & dtMng.Substring(6, 2)
                        End If

                        dtrDat.rptInvItemMngDate = dtMng

                        '在庫ゼロ

                        dtrDat.rptZaikoCsQty = ""
                        dtrDat.rptZaikoLotQty = ""
                        dtrDat.rptZaikoTtl = ""
                        dtrDat.rptActCsQty = ""
                        dtrDat.rptActLotQty = ""
                        dtrDat.rptActTtl = ""
                        dtrDat.rptDifCsQty = ""
                        dtrDat.rptDifLotQty = ""
                        dtrDat.rptDifTtl = ""



                    tmpLocCd = dtrData.Item("LOC_CD").ToString.Trim
                    If dtrData.IsNull("PICK_ZONE") Then
                        tmpZone = ""
                    Else
                        tmpZone = dtrData.Item("PICK_ZONE")
                    End If
                    ' tmpZone = dtrData.Item("PICK_ZONE")
                    tmpListName = dtrDat.rptListName
                    LocCd = ""
                        rdtsRptData.TanaSaiList.AddTanaSaiListRow(dtrDat)
                Next

            Catch ex As Exception
                Throw ex
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

#End Region

#Region " メソッド "

#Region " Public "

#End Region

#Region " Protected "

#Region " setDataTableToForm "
        ''' <summary>
        ''' 検索結果を画面項目にセットします。
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
                Dim param1 As New FindZoneCode
                Dim param As New FindNyukaKb
                Dim status As String
                Dim rej_kb As String
                'Dim strWorkSts As String


                Dim tmpLocCd As String = "0000000"
                Dim tmpZone As String = ""
                Dim tmpFileId As String = ""
                Dim tmpFileLineNo As String = ""
                Dim tmpBlsItemCd As String = ""
                Dim tmpBlsItemName As String = ""

                'ヘッダ情報用(開始時間、終了時間、作業品数、完了品数、指示数、指示完了数)
                Dim strMinStartTime As String = String.Empty
                Dim strMaxEndTime As String = String.Empty

                'Dim zone As String


                For Each dtrData As DataRow In m_dtbData.Rows
                    With Me.dgvMsi.Rows(intRow)

                        param1.SysCd = m_strSysCd
                        param1.LocCd = ComLib.ToStrEx(dtrData.Item("LOC_CD"))
                        'zone = m_clsAcc.FindZone(param1)

                        param.SysCd = m_strSysCd

                        ' work status
                        param.Status = ComConst.CODE_KEY.MCODE_47
                        param.Code = ComLib.ToStrEx(dtrData.Item("WORK_STS"))
                        status = m_clsAcc.FindStatus(param)

                        '不良品区分
                        Dim strRejkb As String = ComLib.ToStrEx(dtrData.Item("REJECT_KB"))
                        rej_kb = ""
                        If strRejkb.Trim().Length > 0 Then
                            param.Status = ComConst.CODE_KEY.MCODE_17
                            param.Code = strRejkb
                            rej_kb = m_clsAcc.FindStatus(param)
                        End If


                        .Cells(Me.colWorkStsVal.Index).Value = status  'ステータス
                        .Cells(Me.colBlsItemCd.Index).Value = ComLib.ToStrEx(dtrData.Item("BLS_ITEM_CD")) '商品BLSコード
                        .Cells(Me.colBlsItemNm.Index).Value = ComLib.ToStrEx(dtrData.Item("BLS_ITEM_NM")) '商品名称
                        .Cells(Me.colItemMngDate.Index).Value = ComLib.YmdToDateStr(dtrData.Item("ITEM_MNG_DATE")) '商品管理日
                        .Cells(Me.colCsCartonDtl.Index).Value = ComLib.ToStrEx(dtrData.Item("CS_CARTON"))     '入数  
                        .Cells(Me.colExpCsQty.Index).Value = ComLib.SetComma(dtrData.Item("EXP_CS_QTY"))     '指示数（ケース） 
                        .Cells(Me.colExpPsQty.Index).Value = ComLib.SetComma(dtrData.Item("EXP_PL_QTY"))     '指示数（バラ）
                        .Cells(Me.colExpSpsQty.Index).Value = ComLib.SetComma(dtrData.Item("EXP_SPL_QTY"))   '指示数（総バラ）
                        '.Cells(Me.colActCsQty.Index).Value = ComLib.ToStrEx(dtrData.Item("ACT_CS_QTY"))     '実績数（ケース）
                        '.Cells(Me.colActPsQty.Index).Value = ComLib.ToStrEx(dtrData.Item("ACT_PS_QTY"))     '実績数（バラ）
                        '.Cells(Me.colActSpsQty.Index).Value = ComLib.ToStrEx(dtrData.Item("ACT_SPS_QTY"))   '実績数（総バラ）
                        .Cells(Me.colActCsQty.Index).Value = ComLib.SetComma(dtrData.Item("R_S_ACT_CS_QTY"))     '実績数（ケース）
                        .Cells(Me.colActPsQty.Index).Value = ComLib.SetComma(dtrData.Item("R_S_ACT_PS_QTY"))     '実績数（バラ）
                        .Cells(Me.colActSpsQty.Index).Value = ComLib.SetComma(dtrData.Item("R_S_ACT_SPS_QTY"))   '実績数（総バラ）
                        .Cells(Me.colDiffCase.Index).Value = ComLib.SetComma(dtrData.Item("DIF_CS_QTY"))     '差異数（ケース）
                        .Cells(Me.colDiffBal.Index).Value = ComLib.SetComma(dtrData.Item("DIF_PL_QTY"))      '差異数（バラ）
                        .Cells(Me.colDiffTotBal.Index).Value = ComLib.SetComma(dtrData.Item("DIF_SPL_QTY"))  '差異数（総バラ）
                        .Cells(Me.colDefItem.Index).Value = rej_kb      '不良品区分
                        .Cells(Me.colPicZone.Index).Value = ComLib.ToStrEx(dtrData.Item("PICK_ZONE"))        'ゾーン
                        .Cells(Me.colLocCd.Index).Value = ComLib.ToStrEx(dtrData.Item("LOC_CD"))     'ロケーション
                        .Cells(Me.colTanaNo.Index).Value = ComLib.ToStrEx(dtrData.Item("INV_NO"))    '棚卸NO
                        .Cells(Me.colJanCd.Index).Value = ComLib.ToStrEx(dtrData.Item("JAN_CD"))     '単品JAN
                        .Cells(Me.colCsJanCd.Index).Value = ComLib.ToStrEx(dtrData.Item("CS_JAN_CD"))     'ケースJAN
                        .Cells(Me.colItfCd.Index).Value = ComLib.ToStrEx(dtrData.Item("ITF_CD"))     'ITFコード

                        .Cells(Me.colItemMngDateRes.Index).Value = ""
                        'If ComLib.ToIntEx(dtrData.Item("RES_ITEM_MNG_DATE")) > 0 Then
                        If ComLib.ToIntEx(dtrData.Item("R_ITEM_MNG_DATE")) > 0 Then
                            '.Cells(Me.colItemMngDateRes.Index).Value = ComLib.YmdToDateStr(dtrData.Item("RES_ITEM_MNG_DATE")) '商品管理日
                            .Cells(Me.colItemMngDateRes.Index).Value = ComLib.YmdToDateStr(dtrData.Item("R_ITEM_MNG_DATE")) '商品管理日
                        End If

                        If (tmpZone.Equals(dtrData.Item("PICK_ZONE").ToString.Trim)) AndAlso _
                             (tmpLocCd.Equals(dtrData.Item("LOC_CD").ToString.Trim)) Then

                            If (tmpBlsItemName.Equals(dtrData.Item("BLS_ITEM_NM").ToString.Trim)) Then
                                .Cells(Me.colBlsItemCd.Index).Value = ""
                                .Cells(Me.colBlsItemNm.Index).Value = ""

                            End If
                        End If

                        If (tmpFileId.Equals(dtrData.Item("FILE_ID").ToString.Trim) AndAlso _
                             tmpFileLineNo.Equals(dtrData.Item("FILE_LINE_NO").ToString.Trim)) Then
                            .Cells(Me.colItemMngDate.Index).Value = ""
                            .Cells(Me.colBlsItemCd.Index).Value = ""
                            .Cells(Me.colExpCsQty.Index).Value = 0
                            .Cells(Me.colExpPsQty.Index).Value = 0
                            .Cells(Me.colExpSpsQty.Index).Value = 0
                            .Cells(Me.colBlsItemNm.Index).Value = ""
                            .Cells(Me.colDiffCase.Index).Value = ComLib.ToStrEx(dtrData.Item("R_S_ACT_CS_QTY"))
                            .Cells(Me.colDiffBal.Index).Value = ComLib.ToStrEx(dtrData.Item("R_S_ACT_PS_QTY"))
                            .Cells(Me.colDiffTotBal.Index).Value = ComLib.ToStrEx(dtrData.Item("R_S_ACT_SPS_QTY"))
                        End If



                        tmpLocCd = dtrData.Item("LOC_CD")

                        If dtrData.IsNull("PICK_ZONE") Then
                            'If (dtrData.Item("PICK_ZONE") = "") Then
                            tmpZone = ""
                        Else
                            tmpZone = dtrData.Item("PICK_ZONE")
                        End If

                        tmpFileId = dtrData.Item("FILE_ID")
                        tmpFileLineNo = dtrData.Item("FILE_LINE_NO")
                        tmpBlsItemCd = dtrData.Item("BLS_ITEM_CD")
                        tmpBlsItemName = dtrData.Item("BLS_ITEM_NM")


                    End With
                    intRow = intRow + 1
                Next



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
                Dim sailist_check As Boolean = True

                param.SysCd = m_strSysCd                                       'システムコード

                param.Ship_Date = ComLib.DateToYmd(Me.datShipDate.FromText)    '棚卸実施日

                param.CenterCd = m_strCenterCd             'CENTER_CD

                Dim strCodeNm As String() = ComAcs.GetCboItem(Me.cmbTanaOroshiKbn, True).Split(":") 'this makes ["1", "荷働品棚卸"]

                param.TanaOroshi_Kbn = "1"
                If strCodeNm.Length = 2 Then
                    param.TanaOroshi_Kbn = strCodeNm(0)
                End If

                Dim strStatus As String() = ComAcs.GetCboItem(Me.cmbWorkSts, True).Split(":")
                param.Status = strStatus(0)  'ステータス

                param.LocCd = Me.txtLocation.Text      'ロケーション
                param.TanaOroshi_No = Me.txtTanaOroshiNo.Text          '棚卸NO
                param.Item_Name = Me.txtItemNm.Text          '商品名称
                param.Item_Code = Me.txtBlsItemCd.Text       '商品BLSコード
                param.Zone = Me.txtZone.Text                 'ゾーン

                param.WorkUsr_Name = Me.txtWorkUserNm.Text   '作業者
                If ChkRejectKb.Checked = True Then
                    param.RejectKb = 1
                End If

                If chkDiffren.Checked = True Then
                    param.chkDiff = 1
                End If

                Dim strZaiko As String() = ComAcs.GetCboItem(Me.cmbZaikoChk, True).Split(":")       '在庫ゼロ
                If strZaiko(0) <> "" Then
                    If strZaiko(0) = 0 Then
                        param.Zaiko = 1
                    End If
                    If strZaiko(0) = 1 Then
                        param.Zaiko = 0
                    End If
                End If



                '棚卸実績情報検索
                If m_intMode = MODE.Search Then
                    'm_dtbData = m_clsAcc.FindPicProgress(param)
                    m_dtbData = m_clsAcc.FindDiffPicProgress(param)
                ElseIf m_intMode = MODE.Print Then
                    m_dtbData = m_clsAcc.FindDiffPicProgress(param)
                ElseIf m_intMode = MODE.CSV Then
                    m_dtbData = m_clsAcc.FindDiffPicProgressCSV(param)
                End If


            Catch ex As Exception
                Throw ex
            End Try
        End Sub



#End Region

#Region " resetParams "
        ''' <summary>
        ''' 入力項目クリア
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history> 2019/09/07 Created</history>
        Protected Function resetParams() As Boolean
            Me.cmbTanaOroshiKbn.SelectedIndex = 0      '棚卸区分
            Me.cmbWorkSts.SelectedIndex = 0     'status
            Me.chkDiffren.Checked = False       '差異あり
            Me.cmbZaikoChk.SelectedIndex = 0    '在庫ゼロ
            Me.txtItemNm.Text = ""              '商品名称
            Me.txtBlsItemCd.Text = ""           'BLS_ITEM_CD
            Me.txtWorkUserNm.Text = ""          '作業者名
            Me.txtTanaOroshiNo.Text = ""           '棚卸NO
            Me.txtZone.Text = ""                'ZONE
            Me.ChkRejectKb.Checked = False      '不良品区分
            Me.txtLocation.Text = ""            'Location
            Me.ChkRejectKb.BackColor = Color.Transparent     '不良品区分
            Me.chkDiffren.BackColor = Color.Transparent      '差異あり
            Return True
        End Function
#End Region

#End Region

#Region " Private "

#Region " Init "
        ''' <summary>
        ''' 初期化処理を行います。
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Sub Init()
            Try
                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS310(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS310.DbAccessResultStatus.Normal) Then
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Exit Sub
                End If

                Me.SetCombo2()
                Me.SetCombo1()
                Me.SetCombo()

                'GAEA区分コード
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
                If String.IsNullOrEmpty(m_strShipDate) Then
                    '初期値
                    Me.datShipDate.FromValue = Date.Now
                    Me.datShipDate.FromText = Date.Now.ToString(ComConst.Format.VB_DATE_SEP)
                    Me.datShipDate.ToValue = Date.Now
                    Me.datShipDate.ToText = String.Empty
                Else
                    '他画面からの引き継ぎ項目
                    Me.datShipDate.FromValue = ComLib.YmdToDate(m_strShipDate)
                    Me.datShipDate.FromText = ComLib.YmdToDateStr(m_strShipDate)
                End If
                Me.ChkRejectKb.BackColor = Color.Transparent     '不良品区分
                Me.chkDiffren.BackColor = Color.Transparent      '差異あり

                '納品先BLSコード
                If String.IsNullOrEmpty(m_strZONE) Then
                    '初期値
                    Me.txtZone.Text = String.Empty
                Else
                    '他画面からの引き継ぎ項目
                    Me.txtZone.Text = m_strZONE
                End If

                '納品先名称
                If String.IsNullOrEmpty(m_strTanaNo) Then
                    '初期値
                    Me.txtTanaOroshiNo.Text = String.Empty
                Else
                    '他画面からの引き継ぎ項目
                    Me.txtTanaOroshiNo.Text = m_strTanaNo
                End If



                '棚卸区分
                If String.IsNullOrEmpty(m_strTanaKbn) Then
                    '初期値
                    Me.cmbTanaOroshiKbn.SelectedIndex = 0
                Else
                    '他画面からの引き継ぎ項目
                    Me.cmbTanaOroshiKbn.Text = m_strTanaKbn
                End If
                '棚卸区分

                Me.cmbWorkSts.SelectedIndex = 0
                Me.cmbZaikoChk.SelectedIndex = 0
                'リストのクリア
                Me.ClearItem()

                'グリッドの設定
                With Me.dgvMsi
                    .Rows.Clear()
                    .AllowDrop = False                                                  'ユーザによるDrop禁止
                    .AllowUserToOrderColumns = True                                   'ユーザによる列の入れ替え禁止
                    .DeleteCellValue = True                                             'Delete可
                    .EditMode = DataGridViewEditMode.EditProgrammatically               '直接セル編集不可
                    .KeyAction = VariedDataGridView.KeyActions.MoveToNextColRow         'Enter押下時カーソルの移動方向
                    .MultiSelect = True                                                 '複数選択可
                    .PasteCellValue = False                                             '貼付け不可
                    .ReadOnly = True                                                    '編集不可
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

                'フォーカス設定
                Me.datShipDate.Focus()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
#End Region

#Region " DiffCheckFill "
        ''' <summary>
        ''' 差異、パラメーターチェック
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info 2019/10/23 Created</history>
        Private Function DiffCheckFill() As Boolean
            ' place holder parameters
            Dim param As New PicProgressParam

            '-- need
            param.SysCd = m_strSysCd            'システムコード
            param.CenterCd = m_strCenterCd      'CENTER_CD

            '棚卸実施日
            param.Ship_Date = ComLib.DateToYmd(Me.datShipDate.FromText)

            '棚卸区分
            Dim strINV_KB As String() = ComAcs.GetCboItem(Me.cmbTanaOroshiKbn, True).Split(":") 'this makes ["1", "荷働品棚卸"]
            param.Bls_Deli_Nm = strINV_KB(0)

            'status
            Dim strWORK_STS As String() = ComAcs.GetCboItem(Me.cmbWorkSts, True).Split(":")
            param.Status = strWORK_STS(0)


            '-- not need
            Dim filled As Integer = 0

            If Me.chkDiffren.Checked Then  '差異ありチェック
                filled = filled + 1
            End If
            If Not String.IsNullOrEmpty(ComAcs.GetCboItem(Me.cmbZaikoChk, True)) Then   '在庫ゼロ
                filled = filled + 1
            End If
            If Not String.IsNullOrEmpty(Me.txtItemNm.Text) Then        '商品名
                filled = filled + 1
            End If
            If Not String.IsNullOrEmpty(Me.txtBlsItemCd.Text) Then     '商品コード
                filled = filled + 1
            End If
            If Not String.IsNullOrEmpty(Me.txtWorkUserNm.Text) Then    '作業者名
                filled = filled + 1
            End If
            If Not String.IsNullOrEmpty(Me.txtTanaOroshiNo.Text) Then     '棚卸No
                filled = filled + 1
            End If
            If Not String.IsNullOrEmpty(Me.txtZone.Text) Then          'zone
                filled = filled + 1
            End If
            If Me.ChkRejectKb.Checked Then              '不良区分
                filled = filled + 1
            End If
            If Not String.IsNullOrEmpty(Me.txtLocation.Text) Then  'Location
                filled = filled + 1
            End If

            If filled > 0 Then
                m_clsMsgBox.Show("M0068W", "棚卸実施日、棚卸区分、ステータス以外に値が入力されています。値を削除してください。指定", "指定エラー")
                Return False
            End If

            Return True
        End Function
#End Region

#Region " DiffSearch "
        ''' <summary>
        ''' 差異
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info 2019/10/23 Created</history>
        Private Function DiffSearch() As Boolean
            Try
                ' m_clsAcc instance var



            Catch ex As Exception

            Finally

            End Try
        End Function
#End Region

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

                'クライアントチェック
                If Not Me.doCheckClient Then
                    'エラー
                    Return False
                End If

                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS310(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS310.DbAccessResultStatus.Normal) Then
                    'エラー処理
                    Me.ErrAfter()
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If
                Me.ChkRejectKb.BackColor = Color.Transparent     '不良品区分
                Me.chkDiffren.BackColor = Color.Transparent      '差異あり
                '棚卸情報取得
                Me.doSearch()

                If m_dtbData.Rows.Count = 0 Or m_dtbData Is Nothing Then
                    'エラー処理
                    Me.ErrAfter()
                    'エラー情報をセット
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

#Region " SearchData "
        ''' <summary>
        ''' 検索処理
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/10/31 Created</history>
        Private Function SearchDiffData() As Boolean
            Try

                'クライアントチェック
                If Not Me.doCheckClient Then
                    'エラー
                    Return False
                End If

                'DBのオープン
                m_clsAcc = New Acc.AccVSMSS310(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSS310.DbAccessResultStatus.Normal) Then
                    'エラー処理
                    Me.ErrAfter()
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                '棚卸情報取得
                Me.doSearch()

                If m_dtbData.Rows.Count = 0 Then
                    'エラー処理
                    Me.ErrAfter()
                    'エラー情報をセット
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0007, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                If Not Me.ShowData() Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0024, "印刷処理", String.Empty, 0, 0)      '印刷処理が失敗しました
                    dispErrorInfo()
                    Return False
                End If

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

#Region " ErrAfter "
        ''' <summary>
        ''' エラー後処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/10 Created</history>
        Private Sub ErrAfter()
            Try
                'リストのクリア
                Me.ClearItem()

            Catch ex As Exception
                Throw ex
            End Try

        End Sub
#End Region

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

#Region " SetCombo INV_KB 棚卸区分 "
        ''' <summary>
        ''' コンボボックスの設定処理
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
        ''' コンボボックスの設定処理
        ''' </summary>
        ''' <param name="robjCbo">コンボボックス</param>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo(ByRef robjCbo As NamedComboBox)
            Dim nvcDat As New NameValueCollection
            Try
                nvcDat = m_clsAcc.FindHaniKbByCombo(ComConst.CODE_KEY.MCODE_44, m_clsVSMSConfig.SysCd, False)
                robjCbo.Items.Clear()
                ComAcs.CreateCombo(robjCbo, nvcDat)

            Catch ex As Exception
                Throw ex
            Finally
                nvcDat = Nothing
            End Try
        End Sub

#End Region

#Region " SetCombo1 INV_WORK_STS 棚卸作業ステータス "
        ''' <summary>
        ''' コンボボックスの設定処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo1()
            Try
                'ステータス
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
                nvcDat = m_clsAcc.FindHaniKbByCombo(ComConst.CODE_KEY.MCODE_46, m_clsVSMSConfig.SysCd, True)

                robjCbo.Items.Clear()
                ComAcs.CreateCombo(robjCbo, nvcDat)

            Catch ex As Exception
                Throw ex
            Finally
                nvcDat = Nothing
            End Try
        End Sub

#End Region

#Region " SetCombo2 INV_DSP_KB 棚卸表示区分 "
        ''' <summary>
        ''' コンボボックスの設定処理
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>EBP K.Niina 2018/08/17 Created</history>
        Private Sub SetCombo2()
            Try
                'ステータス
                Me.SetCombo2(Me.cmbZaikoChk)

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
        Private Sub SetCombo2(ByRef robjCbo As NamedComboBox)
            Dim nvcDat As New NameValueCollection
            Try
                nvcDat = m_clsAcc.FindHaniKbByCombo(ComConst.CODE_KEY.MCODE_48, m_clsVSMSConfig.SysCd, True)
                robjCbo.Items.Clear()
                ComAcs.CreateCombo(robjCbo, nvcDat)

            Catch ex As Exception
                Throw ex
            Finally
                nvcDat = Nothing
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

                'グラフ


            Catch ex As Exception
                Throw ex
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
                'DBコネクト開放(例外時にはRollbackを行う)
                m_clsAcc.ConnectDispose()
                m_clsAcc = Nothing
            End If

        End Sub

#End Region

#Region " dgvMsi_CellFormatting "
        Private Sub dgvMsi_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMsi.CellFormatting
            dgvMsi.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
        End Sub
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

                'ピッキング実績情報取得
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
            Dim strRejkb As String = ""
            Dim strWorkSts As String = ""
            Dim param As New FindNyukaKb
            Dim tmpFileId As String = ""
            Dim tmpFileLineNo As String = ""
            Try
                param.SysCd = m_strSysCd
                'ヘッダ作成
                For Each dtcCsv As DataColumn In m_dtbData.Columns
                    If (dtcCsv.ColumnName.Equals("FILE_ID") Or dtcCsv.ColumnName.Equals("FILE_LINE_NO") Or _
                        dtcCsv.ColumnName.Equals("MNG_DT_CNT")) Then
                        Continue For
                    End If

                    dtbCsv.Columns.Add(clsCsv.GetColItem(dtcCsv.ColumnName))
                Next

                'データ作成
                For Each dtrData As DataRow In m_dtbData.Rows

                    dtrCsv = dtbCsv.NewRow

                    For intItem As Integer = 0 To m_dtbData.Columns.Count - 1
                        If intItem.Equals(0) Then
                            '作業ステータス
                            strWorkSts = ""
                            If dtrData.Item(intItem).ToString.Trim().Length > 0 Then
                                param.Status = ComConst.CODE_KEY.MCODE_47
                                param.Code = dtrData.Item(intItem).ToString.Trim()
                                strWorkSts = m_clsAcc.FindStatus(param)
                            End If
                            dtrCsv.Item(intItem) = dtrData.Item(intItem).ToString & ":" & strWorkSts
                        ElseIf intItem > 21 Then 'ignore file_id,file_line_no,date_mng_cnt

                        ElseIf intItem.Equals(5) Then
                            '日時
                            dtrCsv.Item(intItem) = ComLib.YmdToDateStr(dtrData.Item(intItem).ToString.TrimEnd)
                        ElseIf intItem.Equals(10) Then
                            '日時
                            dtrCsv.Item(intItem) = ComLib.YmdToDateStr(dtrData.Item(intItem).ToString.TrimEnd)
                        ElseIf intItem.Equals(17) Then
                            '不良品区分
                            strRejkb = ""
                            If dtrData.Item(intItem).ToString.Trim().Length > 0 Then
                                param.Status = ComConst.CODE_KEY.MCODE_17
                                param.Code = dtrData.Item(intItem).ToString.Trim()
                                strRejkb = m_clsAcc.FindStatus(param)
                            End If
                            dtrCsv.Item(intItem) = strRejkb

                        Else
                            '上記以外
                            dtrCsv.Item(intItem) = dtrData.Item(intItem)
                        End If
                    Next
                    If (tmpFileId.Equals(dtrData.Item(22).ToString.Trim) AndAlso tmpFileLineNo.Equals(dtrData.Item(23).ToString.Trim)) Then

                        dtrCsv.Item(7) = "0"
                        dtrCsv.Item(8) = "0"
                        dtrCsv.Item(9) = "0"
                        dtrCsv.Item(14) = dtrData.Item(11)
                        dtrCsv.Item(15) = dtrData.Item(12)
                        dtrCsv.Item(16) = dtrData.Item(13)
                    End If
                    tmpFileId = dtrData.Item(22).ToString.Trim
                    tmpFileLineNo = dtrData.Item(23).ToString.Trim


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

    
    End Class
End Namespace