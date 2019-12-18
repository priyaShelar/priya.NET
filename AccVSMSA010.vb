'----------------------------------------------------------------------------------------------
'  機能名　　　　    : ﾛｸﾞｲﾝ画面DBAccessｸﾗｽ
'  機能説明　　　    : ﾛｸﾞｲﾝ画面のﾃﾞｰﾀﾍﾞｰｽｱｸｾｽ機能を提供します。
'  備考　　　　　    : なし
'  作成日　　　　    : 2018/09/03
'  作成者　　　　    : S.Toshino
'----------------------------------------------------------------------------------------------
'  更新日，更新者    : 
'  更新内容　　　    : 
'----------------------------------------------------------------------------------------------
Imports System.Text
Imports VWS.iSenseOpenLib
Imports VWS.VSMS.VSMSLib.Librarys

Namespace Acc
    ''' <summary>
    ''' ﾛｸﾞｲﾝ画面DBAccessｸﾗｽ
    ''' </summary>
    ''' <remarks>ﾛｸﾞｲﾝ画面のﾃﾞｰﾀﾍﾞｰｽｱｸｾｽ機能を提供します。</remarks>
    ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
    Public Class AccVSMSA010
        Inherits ComAccBase

#Region " 定数 "

#End Region

#Region " 変数 "

#Region " ｲﾝｽﾀﾝｽ "

#End Region

#End Region

#Region " ｺﾝｽﾄﾗｸﾀ "
        ''' <summary>
        ''' ｺﾝｽﾄﾗｸﾀ
        ''' </summary>
        ''' <param name="pstrUserId">ﾕｰｻﾞID</param>
        ''' <param name="pstrTarmId">端末ID</param>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Public Sub New(ByVal pstrUserId As String, ByVal pstrTarmId As String)
            MyBase.New(pstrUserId, pstrTarmId, ComConst.ProgramID.PGIDA010)
            Try

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region " ﾒｿｯﾄﾞ "

#Region " Public "

#Region " FindUser "
        ''' <summary>
        ''' 利用者ﾏｽﾀを取得します。
        ''' </summary>
        ''' <param name="pstrUserId">利用者ID</param>
        ''' <returns>ﾕｰｻﾞﾏｽﾀ情報</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Public Function FindUser(ByVal pstrUserId As String) As DataTable
            Dim dstDat As New DataSet
            Try
                With m_clsDbReader
                    .ClearParameter()
                    '取得ﾊﾟﾗﾒｰﾀ
                    .AddParameter("USER_ID", Librarys.ComCns.SqlType.VarChar, pstrUserId)   '利用者ID
                End With

                '利用者ﾏｽﾀ取得SQL実行
                dstDat = m_clsDbReader.GetTableData(CreateFindUserSql())

                '利用者ﾏｽﾀ情報
                Return dstDat.Tables(0)

            Catch ex As Exception
                Throw ex
            Finally
                '解放
                If Not dstDat Is Nothing Then
                    dstDat.Dispose()
                    dstDat = Nothing
                End If
            End Try
        End Function
#End Region

#End Region

#Region " Private "

#Region " CreateFindUserSql "
        ''' <summary>
        ''' 利用者ﾏｽﾀ取得用SQL文を生成します。
        ''' </summary>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2016/01/08 Created</history>
        Private Function CreateFindUserSql() As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT")
                    .AppendLine("       SYS_CD")                'ｼｽﾃﾑｺｰﾄﾞ
                    .AppendLine("     , USER_ID")               '利用者ID
                    .AppendLine("     , USER_NM")               '利用者名称
                    .AppendLine("     , PASSWORD")              'ﾊﾟｽﾜｰﾄﾞ
                    .AppendLine("     , AUTH_KB")               '権限区分
                    .AppendLine("     , CENTER_CD")             'ｾﾝﾀｰｺｰﾄﾞ
                    .AppendLine("     , CON_SCHEMA")            '接続ｽｷｰﾏ
                    .AppendLine("     , REMARK")                '備考
                    .AppendLine("  FROM")
                    .AppendLine("       COMM.M_USER")           '利用者ﾏｽﾀ
                    .AppendLine(" WHERE")
                    .AppendLine("       USER_ID = :USER_ID")    '利用者ID
                End With

                Return strSql.ToString

            Catch ex As Exception
                Throw ex
            Finally
                '解放
                strSql = Nothing
            End Try
        End Function
#End Region

#End Region

#End Region

    End Class

End Namespace

