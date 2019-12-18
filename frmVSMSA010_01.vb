'----------------------------------------------------------------------------------------------
'  機能名　　　　    : ﾛｸﾞｲﾝ画面ｸﾗｽ
'  機能説明　　　    : ﾛｸﾞｲﾝ画面の機能を提供します。
'  備考　　　　　    : なし
'  作成日　　　　    : 2018/09/03
'  作成者　　　　    : S.Toshino
'----------------------------------------------------------------------------------------------
'  更新日，更新者    : 
'  更新内容　　　    : 
'----------------------------------------------------------------------------------------------
Imports System.Diagnostics.Process
Imports VWS.iSenseOpenLib
Imports VWS.VSMS.VSMSLib.Librarys
Imports VWS.VSMS.VSMSA020.Forms

Namespace Forms
    ''' <summary>
    ''' ﾛｸﾞｲﾝ画面ｸﾗｽ
    ''' </summary>
    ''' <remarks>ﾛｸﾞｲﾝ画面の機能を提供します。</remarks>
    ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
    Public Class frmVSMSA010_01

#Region " 定数 "

#End Region

#Region " 変数 "

#Region " ｲﾝｽﾀﾝｽ "
        ''' <summary>DBｱｸｾｽｸﾗｽ</summary>
        Private m_clsAcc As Acc.AccVSMSA010 = Nothing
#End Region

#End Region

#Region " ｺﾝｽﾄﾗｸﾀ "
        ''' <summary>
        ''' ｺﾝｽﾄﾗｸﾀ
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Public Sub New()
            MyBase.New(ComConst.ProgramID.PGIDA010)
            Try
                ' この呼び出しは、Windows フォーム デザイナで必要です。
                InitializeComponent()

                ' InitializeComponent() 呼び出しの後で初期化を追加します。

            Catch ex As Exception
                Throw New Exception(ex.Message, ex)
            End Try
        End Sub
#End Region

#Region " ｲﾍﾞﾝﾄ "

#Region " frmVSMSA010_01_Load "
        ''' <summary>
        ''' 画面を起動します。
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Sub frmVSMSA010_01_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                If m_clsVSMSConfig.StartingKb.Equals("0") Then
                    '重複起動不可の場合

                    '重複起動ﾁｪｯｸ
                    If Not Me.ChkProcess Then
                        'ｼｽﾃﾑ終了
                        Me.Dispose()
                        Me.Close()
                    End If

                End If

                'DB起動ﾁｪｯｸ
                If Not Me.ChkDatabase Then
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

#Region " frmVSMSA010_01_Shown "
        ''' <summary>
        ''' 画面を初期化します。
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Sub frmVSMSA010_01_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                '必須項目ｶﾗｰ設定（ﾗﾍﾞﾙ/Blue 太字）
                With Me.lblUserId
                    .ForeColor = Color.FromName(ComConst.ConstColor.MANDATORY_COLOR_B)      'ID
                    .Font = New Font(.Font, FontStyle.Bold)
                End With
                With Me.lblPassword
                    .ForeColor = Color.FromName(ComConst.ConstColor.MANDATORY_COLOR_B)      'ﾊﾟｽﾜｰﾄﾞ
                    .Font = New Font(.Font, FontStyle.Bold)
                End With

                MyBase.setFcsBgnKom(Me.pnlControl06)

            Catch ex As Exception
                m_clsMsgBox.Show(ex)
            Finally
                'ｶｰｿﾙを元に戻す
                Me.Cursor = Cursors.Default
            End Try
        End Sub
#End Region

#Region " btnLogIn_Click "
        ''' <summary>
        ''' ｼｽﾃﾑにﾛｸﾞｲﾝします。
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                'ﾕｰｻﾞｰ認証ﾁｪｯｸ
                If Not CheckUser() Then
                    Return
                End If

                'ﾒﾆｭｰ画面表示
                Using frmNext As New frmVSMSA020_01
                    If frmNext.ShowDialog(Me).Equals(DialogResult.OK) Then

                    End If
                End Using

                'ﾕｰｻﾞｰID、ﾊﾟｽﾜｰﾄﾞの初期化
                Me.txtUserId.Text = String.Empty
                Me.txtPassword.Text = String.Empty
                Me.txtUserId.Focus()

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

#Region " btnQuit_Click "
        ''' <summary>
        ''' ｼｽﾃﾑを終了します。
        ''' </summary>
        ''' <param name="sender">ｲﾍﾞﾝﾄｿｰｽ</param>
        ''' <param name="e">ｲﾍﾞﾝﾄﾃﾞｰﾀ</param>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
            Try
                'ｶｰｿﾙを砂時計にする
                Me.Cursor = Cursors.WaitCursor

                Me.btnClose_Click(sender, e)

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

#End Region

#Region " ﾒｿｯﾄﾞ "

#Region " Protected "

#Region " doCheckBusiness "
        ''' <summary>
        ''' 業務ﾁｪｯｸ処理を行います。
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Protected Overrides Function doCheckBusiness() As Boolean
            Try
                Dim strValue As String = String.Empty

                '編集欄の背景色を戻す
                Me.txtUserId.BackColor = Color.White
                Me.txtPassword.BackColor = Color.White

                '入力ﾁｪｯｸ
                If Me.txtUserId.Text.Length.Equals(0) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0003, String.Empty, Me.txtUserId.Name, 0, 0)
                    Return False
                End If
                If Me.txtPassword.Text.Length.Equals(0) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0003, String.Empty, Me.txtPassword.Name, 0, 0)
                    Return False
                End If

                Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#End Region

#Region " Private "

#Region " ChkProcess "
        ''' <summary>
        ''' 既にｼｽﾃﾑが起動していないかﾁｪｯｸします。
        ''' </summary>
        ''' <returns>True:OK, False:NG</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Function ChkProcess() As Boolean
            Try
                '同名のﾌﾟﾛｾｽが起動していない時は起動する
                If PrevInstance() Then
                    '既に起動中である旨を表示
                    m_clsMsgBox.Show(ComMsg.MSGW0001, m_clsSysConfig.SysName) '既に起動しています。
                    Return False
                End If

                Return True

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region " PrevInstance "
        ''' <summary>
        ''' 同名のﾌﾟﾛｾｽが起動しているかどうかを判定します。
        ''' </summary>
        ''' <returns>同名のﾌﾟﾛｾｽが起動中:True, それ以外:False</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Function PrevInstance() As Boolean
            Try
                'このｱﾌﾟﾘｹｰｼｮﾝのﾌﾟﾛｾｽ名を取得
                Dim strThisProcess As String = GetCurrentProcess().ProcessName

                '同名のﾌﾟﾛｾｽが他に存在する場合は、既に起動していると判断する
                If GetProcessesByName(strThisProcess).Length > 1 Then
                    Return True
                End If

                '存在しない場合は False を返す
                Return False

            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region " ChkDatabase "
        ''' <summary>
        ''' DBへ初期ｺﾝﾀｸﾄを行います。
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Function ChkDatabase() As Boolean
            Try
                m_clsAcc = New Acc.AccVSMSA010(m_clsSysConfig.InUserId, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSA010.DbAccessResultStatus.Normal) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, Me.txtUserId.Name, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                Return True

            Catch ex As Exception
                Throw ex
            Finally
                'DBのクローズ
                Me.DbClose(Me.m_clsAcc)
            End Try
        End Function
#End Region

#Region " CheckUser "
        ''' <summary>
        ''' User IDとﾊﾟｽﾜｰﾄﾞの認証を行います。
        ''' </summary>
        ''' <returns>True:正常, False:異常</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Function CheckUser() As Boolean
            Dim dtbUser As DataTable = Nothing
            Dim clsCode As New ComAccBase.CODE_DATA
            Try
                'ｸﾗｲｱﾝﾄﾁｪｯｸ
                If Not Me.doCheckClient Then
                    'ｴﾗｰ
                    Return False
                End If

                m_clsAcc = New Acc.AccVSMSA010(String.Empty, m_clsSysConfig.TerminalNm)
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSA010.DbAccessResultStatus.Normal) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                Dim datNowTime As Date = m_clsAcc.GetServerNowDate      'ｼｽﾃﾑ日時
                Dim strUserId As String = Me.txtUserId.Text.TrimEnd

                '担当者ﾏｽﾀ検索
                dtbUser = m_clsAcc.FindUser(strUserId)
                '判定
                If dtbUser.Rows.Count.Equals(0) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0013, String.Empty, Me.txtUserId.Name, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                'ﾊﾟｽﾜｰﾄﾞﾁｪｯｸ
                If Not dtbUser.Rows(0).Item("PASSWORD").ToString.Equals(Me.txtPassword.Text.TrimEnd) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0039, String.Empty, Me.txtPassword.Name, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                '接続ｽｷｰﾏﾁｪｯｸ
                If String.IsNullOrEmpty(dtbUser.Rows(0).Item("CON_SCHEMA").ToString.TrimEnd) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0025, "DB情報が取得", Me.txtUserId.Name, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                'sysconfig.xml書き込み
                Dim clsSys As New ComSysConSet
                clsSys.User = dtbUser.Rows(0).Item("CON_SCHEMA").ToString
                clsSys.Pass = dtbUser.Rows(0).Item("CON_SCHEMA").ToString
                clsSys.WriteDBInfo()

                'DBのクローズ
                m_clsAcc.ConnectDispose()

                'DB再接続
                If Not m_clsAcc.DBReaderOpen().Equals(Acc.AccVSMSA010.DbAccessResultStatus.Normal) Then
                    'ｴﾗｰ情報をｾｯﾄ
                    SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0022, String.Empty, String.Empty, 0, 0)
                    dispErrorInfo()
                    Return False
                End If

                'GAEA区分名称の取得
                clsCode = m_clsAcc.FindCode(Space(1), ComConst.CODE_KEY.MCODE_01, dtbUser.Rows(0).Item("SYS_CD").ToString)
                Dim strGaeaNm As String = clsCode.Code_Nm

                'ｾﾝﾀｰ名取得
                clsCode = New ComAccBase.CODE_DATA
                clsCode = m_clsAcc.FindCode(dtbUser.Rows(0).Item("SYS_CD").ToString, ComConst.CODE_KEY.MCODE_02, dtbUser.Rows(0).Item("CENTER_CD").ToString)
                Dim strCenterNm As String = clsCode.Code_Nm

                If Not dtbUser.Rows(0).Item("AUTH_KB").ToString.Equals("3") Then
                    '本部以外の場合
                    'ﾛｸﾞ情報ｾｯﾄ
                    'ﾛｸﾞ情報ｴﾝﾃｨﾃｨ初期化
                    m_clsAcc.m_srtLogData = New ComAccBase.LOG_DATA
                    With m_clsAcc.m_srtLogData
                        .Sys_Cd = dtbUser.Rows(0).Item("SYS_CD").ToString
                        .Proc_Date = datNowTime.ToString(ComConst.Format.VB_DATE)
                        .Proc_Time = datNowTime.ToString(ComConst.Format.VB_TIME)
                        .Proc_Kb = ComConst.LogInfo.PROC_KB.PC
                        .Msg_Kb = ComConst.LogInfo.MSG_KB.INFO
                        .Msg_Id = String.Empty
                        .Log_Msg = "ログイン　ユーザID = " & dtbUser.Rows(0).Item("USER_ID").ToString
                        .Sys_Yb = datNowTime.ToString(ComConst.Format.VB_DATETIME_LONG)
                        .Usr_Id = dtbUser.Rows(0).Item("USER_ID").ToString
                    End With
                    'ﾛｸﾞ情報登録
                    If Not m_clsAcc.EntryLogInfo Then
                        'ｴﾗｰ情報をｾｯﾄ
                        SetErrInfoToAppInfo(String.Empty, ComMsg.MSGW0041, String.Empty, String.Empty, 0, 0)
                        dispErrorInfo()
                        Return False
                    End If
                End If

                'ﾛｸﾞｲﾝ情報書き込み
                SetXmlFile(dtbUser.Rows(0), strCenterNm, strGaeaNm)

                Return True

            Catch ex As Exception
                Throw ex
            Finally
                '解放
                If Not dtbUser Is Nothing Then
                    dtbUser.Dispose()
                    dtbUser = Nothing
                End If

                If Not CheckUser Then
                    '処理が正しくない場合
                    'DB情報を戻す
                    ReturnDBInfo()
                End If

                'DBのクローズ
                Me.DbClose(Me.m_clsAcc)
            End Try
        End Function
#End Region

#Region " SetXmlFile "
        ''' <summary>
        ''' xmlﾌｧｲﾙに書込み
        ''' </summary>
        ''' <param name="pdrwUser">利用者ﾏｽﾀ情報</param>
        ''' <param name="pstrCenterNm">ｾﾝﾀｰ名</param>
        ''' <param name="pstrGaeaNm">GAEA区分名称</param>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Sub SetXmlFile(ByVal pdrwUser As DataRow, ByVal pstrCenterNm As String, ByVal pstrGaeaNm As String)
            Dim clsSysConset As Librarys.SysConSet = Nothing
            Dim clsVSMSConset As ComConSet = Nothing
            Try
                '取得した情報をxmlﾌｧｲﾙに書き込む
                clsSysConset = New Librarys.SysConSet
                With clsSysConset
                    .InUserId = pdrwUser("USER_ID").ToString.TrimEnd    '利用者ID
                    .InUserNM = pdrwUser("USER_NM").ToString.TrimEnd    '利用者名称

                    Dim strTermID As String = System.Net.Dns.GetHostName()
                    If ComLib.ByteLength(strTermID) > ComConst.ConstForm.m_intMAXLEN_TERMID Then
                        strTermID = ComLib.ByteSubstring(strTermID, 0, ComConst.ConstForm.m_intMAXLEN_TERMID, ComConst.Encode.UTF8)
                    End If
                    .TerminalNm = strTermID                             '端末名
                    .WrtLogin()
                End With

                clsVSMSConset = New ComConSet
                With clsVSMSConset
                    .SysCd = pdrwUser("SYS_CD").ToString.TrimEnd        'ｼｽﾃﾑｺｰﾄﾞ
                    .SysNm = pstrCenterNm                               'ｼｽﾃﾑ名称
                    .DataRefKb = pdrwUser("AUTH_KB").ToString.TrimEnd   '参照権限
                    .GaeaNm = pstrGaeaNm                                'GAEA区分名称
                    .WriteSystem()
                End With

            Catch ex As Exception
                Throw ex
            Finally
                '解放
                clsSysConset = Nothing
                clsVSMSConset = Nothing
            End Try
        End Sub
#End Region

#End Region

#End Region

    End Class

End Namespace
