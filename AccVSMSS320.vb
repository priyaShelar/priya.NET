'----------------------------------------------------------------------------------------------
'  機能名　　　　    : DBAccessｸﾗｽ
'  機能説明　　　    : DBへ初期ｺﾝﾀｸﾄする機能を提供します。
'  備考　　　　　    : なし
'  作成日　　　　    : 2018/09/07
'  作成者　　　　    : S.Toshino
'----------------------------------------------------------------------------------------------
'  更新日，更新者    : 
'  更新内容　　　    : 
'----------------------------------------------------------------------------------------------
Imports System.Text
Imports VWS.iSenseOpenLib.Librarys.ComCns
Imports VWS.VSMS.VSMSLib.Librarys
Imports System.Drawing

Imports System.Windows.Forms
Imports System.Collections.Specialized
Imports VWS.iSenseOpenLib.Librarys
Imports VWS.iSenseOpenLib

Namespace Acc
    ''' <summary>
    ''' DBAccessｸﾗｽ
    ''' </summary>
    ''' <remarks>DBへ初期ｺﾝﾀｸﾄする機能を提供します。</remarks>
    ''' <history>S.Toshino 2018/09/07 Created</history>
    Public Class AccVSMSS320
        Inherits ComAccBase

#Region " 定数 "

#End Region

#Region " 変数 "

#Region "  PicProgressParam "
        ''' <summary>
        ''' 棚卸検索条件
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Class PicProgressParam
            Private strSysCd As String = String.Empty
            Private strCenterCd As String = String.Empty
            Private strZone As String = String.Empty

            Private strShipDate As String = String.Empty
            Private strBlsDeliCd As String = String.Empty
            Private strBlsDeliNm As String = String.Empty

            Private strTanaOroshiNo As String = String.Empty
            Private strTanaOroshiKbn As String = String.Empty

            Public Sub New()
            End Sub

            ''' <summary>
            ''' システムコード
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property SysCd() As String
                Get
                    Return strSysCd
                End Get
                Set(ByVal value As String)
                    strSysCd = value
                End Set
            End Property

            ''' <summary>
            ''' センターコード
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property CenterCd() As String
                Get
                    Return strCenterCd
                End Get
                Set(ByVal value As String)
                    strCenterCd = value
                End Set
            End Property

            ''' <summary>
            ''' Zone
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property Zone() As String
                Get
                    Return strZone
                End Get
                Set(ByVal value As String)
                    strZone = value
                End Set
            End Property

            ''' <summary>
            ''' 棚卸No.
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property TanaOroshiNo() As String
                Get
                    Return strTanaOroshiNo
                End Get
                Set(ByVal value As String)
                    strTanaOroshiNo = value
                End Set
            End Property

            ''' <summary>
            ''' 棚卸区分
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property TanaOroshiKbn() As String
                Get
                    Return strTanaOroshiKbn
                End Get
                Set(ByVal value As String)
                    strTanaOroshiKbn = value
                End Set
            End Property

            ''' <summary>
            ''' 棚卸実施日
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Ship_Date() As String
                Get
                    Return strShipDate
                End Get
                Set(ByVal value As String)
                    strShipDate = value
                End Set
            End Property

            ''' <summary>
            ''' 納品先BLSコード
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Bls_Deli_Cd() As String
                Get
                    Return strBlsDeliCd
                End Get
                Set(ByVal value As String)
                    strBlsDeliCd = value
                End Set
            End Property

            ''' <summary>
            ''' 納品先名
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Bls_Deli_Nm() As String
                Get
                    Return strBlsDeliNm
                End Get
                Set(ByVal value As String)
                    strBlsDeliNm = value
                End Set
            End Property

        End Class
#End Region

#Region "  FindZoneCode "
        ''' <summary>
        ''' 棚卸検索条件
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Class FindZoneCode
            Private strSysCd As String = String.Empty
            Private strLocCd As String = String.Empty


            Public Sub New()
            End Sub

            ''' <summary>
            ''' システムコード
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property SysCd() As String
                Get
                    Return strSysCd
                End Get
                Set(ByVal value As String)
                    strSysCd = value
                End Set
            End Property

            ''' <summary>
            ''' システムコード
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property LocCd() As String
                Get
                    Return strLocCd
                End Get
                Set(ByVal value As String)
                    strLocCd = value
                End Set
            End Property

        End Class
#End Region

#End Region

#Region " ｺﾝｽﾄﾗｸﾀ "
        ''' <summary>
        ''' ｺﾝｽﾄﾗｸﾀ
        ''' </summary>
        ''' <param name="pstrUserId">ﾕｰｻﾞID</param>
        ''' <param name="pstrTarmId">端末ID</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/10 Created</history>
        Public Sub New(ByVal pstrUserId As String, ByVal pstrTarmId As String)
            MyBase.New(pstrUserId, pstrTarmId, ComConst.ProgramID.PGIDS220)
            Try

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region " ﾒｿｯﾄﾞ "

#Region " Public "

#Region " FindPicProgress "
        ''' <summary>
        ''' 棚卸進捗状況を検索します。
        ''' </summary>
        ''' <param name="param">棚卸進捗検索パラメータ</param>
        ''' <returns>棚卸進捗情報</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Function FindPicProgress(ByVal param As PicProgressParam) As DataTable
            Dim dstDat As New DataSet

            Try
                With m_clsDbReader
                    '取得ﾊﾟﾗﾒｰﾀ
                    .ClearParameter()
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)                       'システムコード
                    .AddParameter("CENTER_CD", SqlType.VarChar, param.CenterCd)                 'センターコード
                    .AddParameter("SHIP_DATE", SqlType.VarChar, param.Ship_Date)                '実施日
                    If Not String.IsNullOrEmpty(param.Zone) Then
                        .AddParameter("ZONE", SqlType.VarChar, param.Zone)                      'zone
                    End If
                    If Not String.IsNullOrEmpty(param.TanaOroshiKbn) Then
                        .AddParameter("TANA_KBN", SqlType.VarChar, param.TanaOroshiKbn)         '棚卸区分
                    End If
                    If Not String.IsNullOrEmpty(param.TanaOroshiNo) Then
                        .AddParameter("TANANO", SqlType.VarChar, param.TanaOroshiNo)            '棚卸No.
                    End If
                End With

                '棚卸進捗情報取得SQL実行
                dstDat = m_clsDbReader.GetTableData(CreateFindPicProgressSql(param))

                '棚卸進捗情報
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

#Region " FindCodeByCombo "
        ''' <summary>
        ''' 汎用ｺｰﾄﾞﾏｽﾀ情報(ｺﾝﾎﾞﾎﾞｯｽｸ)を取得します。
        ''' </summary>
        ''' <param name="pstrCodeKey">ｷｰｺｰﾄﾞ</param>
        ''' <param name="pstrSysCd">ｼｽﾃﾑｺｰﾄﾞ</param>
        ''' <param name="pblnBlank">ﾌﾞﾗﾝｸﾌﾗｸﾞ(Trueの場合、先頭空白を追加する)</param>
        ''' <param name="pblnClose">ｸﾛｰｽﾞﾌﾗｸﾞ(Trueの場合、DBをｸﾛｰｽﾞする)</param>
        ''' <returns>ﾕｰｻﾞﾏｽﾀ件数</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2015/04/01 Created</history>
        Public Function FindHaniKbByCombo(ByVal pstrCodeKey As String, _
                                        Optional ByVal pstrSysCd As String = "", _
                                        Optional ByVal pblnBlank As Boolean = True, _
                                        Optional ByVal pblnClose As Boolean = False) As NameValueCollection
            Dim dstDat As New DataSet
            Dim nvcDat As New NameValueCollection
            Try
                ' If pblnBlank Then
                '空白追加
                'nvcDat.Add(String.Empty, String.Empty)
                '  End If

                'DBｵｰﾌﾟﾝ
                If Not DBReaderOpen().Equals(DbAccessResultStatus.Normal) Then
                    Return nvcDat
                End If

                With m_clsDbReader
                    .ClearParameter()
                    '取得ﾊﾟﾗﾒｰﾀ
                    .AddParameter("CODE_KEY", SqlType.VarChar, pstrCodeKey)             'ｼｽﾃﾑｺｰﾄﾞ
                    .AddParameter("CODE", SqlType.VarChar, ComConst.CODE_KEY.MTITLE)    'ｺｰﾄﾞ
                    If Not pstrSysCd.Equals(String.Empty) Then
                        .AddParameter("SYS_CD", SqlType.VarChar, pstrSysCd)             'ｼｽﾃﾑｺｰﾄﾞ
                    End If
                End With

                '汎用ｺｰﾄﾞﾏｽﾀ取得SQL実行
                dstDat = m_clsDbReader.GetTableData(CreateFindHaniKbByComboSql(pstrSysCd))

                For Each dtrDat As DataRow In dstDat.Tables(0).Rows
                    nvcDat.Add(dtrDat("CODE").ToString, dtrDat("CODE_NM").ToString)
                Next

                '汎用ｺｰﾄﾞﾏｽﾀ情報
                Return nvcDat

            Catch ex As Exception
                Throw ex
            Finally
                If pblnClose Then
                    'DBｺﾈｸﾄ開放(例外時にはRollbackを行う)
                    ConnectDispose()
                End If
            End Try
        End Function
#End Region

#Region " FindZone "
        ''' <summary>
        ''' 棚卸進捗状況を検索します。
        ''' </summary>
        ''' <param name="param">棚卸進捗検索パラメータ</param>
        ''' <returns>棚卸進捗情報</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Function FindZone(ByVal param As FindZoneCode) As String
            Dim dstDat As New DataSet
            Dim pickZone As String

            Try
                With m_clsDbReader
                    '取得ﾊﾟﾗﾒｰﾀ
                    .ClearParameter()
                    .AddParameter("LOC_CD", SqlType.VarChar, param.LocCd)                                       'ロケーション（ゾーン）
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)                                       'システムコード

                End With

                'ゾーンマスタ情報取得SQL実行
                dstDat = m_clsDbReader.GetTableData(FindZoneMaster(param))
                pickZone = dstDat.Tables(0).Rows(0).Item("PICK_ZONE").ToString

                'ゾーンマスタ情報
                Return pickZone

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

#Region " CreateCombo "
        Public Shared Sub CreateCombo(ByVal pcmbDat As NamedComboBox, _
                                             ByVal pnvcDat As NameValueCollection, _
                                             Optional ByVal pblnColon As Boolean = True)
            Try
                With pcmbDat.Items
                    'ｺｰﾄﾞﾏｽﾀからｺｰﾄﾞ取得
                    For intIdx As Integer = 0 To pnvcDat.Count - 1
                        Dim strItem As String = String.Empty
                        If Not String.IsNullOrEmpty(pnvcDat.GetKey(intIdx)) Then
                            'コロン編集
                            If pblnColon Then
                                strItem = pnvcDat.GetKey(intIdx) & ":" & pnvcDat(intIdx)
                            Else
                                strItem = pnvcDat(intIdx)
                            End If
                        End If
                        'コンボに追加
                        .Add(strItem, pnvcDat.GetKey(intIdx))
                    Next
                End With
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

#End Region

#End Region

#Region " Private "

#Region " CreateFindPicProgressSql1 "
        ''' <summary>
        ''' 棚卸進捗照会用SQL文を生成します。
        ''' </summary>
        ''' <param name="pParam">検索条件</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Function CreateFindPicProgressSql1(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder

            Try
                'SQL発行
                With strSql

                    .AppendLine("SELECT")
                    .AppendLine("  SYS_CD	")
                    .AppendLine(" , 	CENTER_CD")
                    .AppendLine(" , 	WORK_DATE")
                    .AppendLine(" , 	INV_KB	")
                    .AppendLine(" , 	ZONE	")
                    .AppendLine(" , 	INV_NO	")
                    .AppendLine(" , 	LOC_CD	")
                    .AppendLine(" , 	START_TIME	")
                    .AppendLine(" , 	END_TIME")
                    .AppendLine(" , 	TOTAL_CNT")
                    .AppendLine(" , 	DONE_CNT")
                    .AppendLine(" ,	TRUNC((DONE_CNT / TOTAL_CNT) * 100,1)     AS PERSENT	")
                    .AppendLine("FROM")
                    .AppendLine("(")
                    .AppendLine("  SELECT	")
                    .AppendLine("    A.SYS_CD, A.CENTER_CD, A.WORK_DATE, A.INV_KB, M.PICK_ZONE AS ZONE")
                    .AppendLine("    , A.INV_NO,SUBSTR(A.LOC_CD,1,1) AS LOC_CD")
                    .AppendLine("    , MIN(A.UPD_YB) AS START_TIME")
                    .AppendLine("    , MAX(A.UPD_YB) AS END_TIME")
                    .AppendLine("    , COUNT(A.BLS_ITEM_CD) AS TOTAL_CNT")
                    .AppendLine("    , SUM(CASE A.WORK_STS	WHEN  N'1' THEN 1 ELSE 0 END) AS DONE_CNT")
                    .AppendLine("  FROM")
                    .AppendLine("    T_INVINST A")
                    .AppendLine("  LEFT JOIN")
                    .AppendLine("    (")
                    .AppendLine("      SELECT")
                    .AppendLine("        PICK_ZONE")
                    .AppendLine("        , LOC_CD")
                    .AppendLine("        , SYS_CD")
                    .AppendLine("      FROM")
                    .AppendLine("	 M_ZONE")
                    .AppendLine("      WHERE SYS_CD= :SYS_CD")
                    If Not String.IsNullOrEmpty(pParam.Zone) Then
                        .AppendLine("      AND PICK_ZONE =  :ZONE")
                    End If
                    .AppendLine("    ) M")
                    .AppendLine("  ON A.SYS_CD = M.SYS_CD")
                    .AppendLine("     AND A.LOC_CD = M.LOC_CD")
                    .AppendLine("  WHERE")
                    .AppendLine("    A.WORK_DATE = :SHIP_DATE ")
                    If Not String.IsNullOrEmpty(pParam.TanaOroshiKbn) Then
                        .AppendLine("    AND A.INV_KB = :TANA_KBN")
                    Else
                        .AppendLine("    AND A.INV_KB <>  'A' ")
                    End If
                    If Not String.IsNullOrEmpty(pParam.Zone) Then
                        .AppendLine("    AND M.LOC_CD = A.LOC_CD")
                    End If
                    If Not String.IsNullOrEmpty(pParam.TanaOroshiNo) Then
                        .AppendLine("    AND A.INV_NO LIKE :TANANO || '%'")
                    End If
                    .AppendLine("    AND A.WORK_STS <> 9 ")
                    .AppendLine("    AND A.EXP_SPL_QTY <> 0 ")
                    .AppendLine("  GROUP BY")
                    .AppendLine("    A.SYS_CD")
                    .AppendLine("   , A.CENTER_CD")
                    .AppendLine("   , A.WORK_DATE")
                    .AppendLine("   , A.INV_KB")
                    .AppendLine("   , M.PICK_ZONE")
                    .AppendLine("   , A.INV_NO")
                    .AppendLine("   , SUBSTR(A.LOC_CD,1,1)")
                    .AppendLine(")")
                    .AppendLine("ORDER BY")
                    .AppendLine("  INV_NO")
                    .AppendLine(" , LOC_CD")

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
#Region " CreateFindPicProgressSql "
        ''' <summary>
        ''' 棚卸進捗照会用SQL文を生成します。
        ''' </summary>
        ''' <param name="pParam">検索条件</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Private Function CreateFindPicProgressSql(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder

            Try
                'SQL発行
                With strSql

                    .AppendLine("  SELECT")
                    .AppendLine(" SYS_CD	")
                    .AppendLine(" , 	CENTER_CD")
                    .AppendLine(" , 	WORK_DATE")
                    .AppendLine(" , 	INV_KB	")
                    .AppendLine(" , 	ZONE	")
                    .AppendLine(" , 	INV_NO	")
                    .AppendLine(" , 	LOC_CD	")
                    .AppendLine(" , 	START_TIME")
                    .AppendLine(" , 	END_TIME")
                    .AppendLine(" , 	TOTAL_CNT")
                    .AppendLine(" , 	DONE_CNT")
                    .AppendLine(" ,	TRUNC((DONE_CNT / TOTAL_CNT) * 100,1)  AS PERSENT	")
                    .AppendLine(" from (")
                    .AppendLine(" select")
                    .AppendLine(" A.SYS_CD, A.CENTER_CD, A.WORK_DATE, A.INV_KB, M.PICK_ZONE AS ZONE, A.INV_NO,SUBSTR(A.LOC_CD,1,1) AS LOC_CD ,   MIN(S2.START_TIME) AS START_TIME ,  MAX(S2.END_TIME) AS END_TIME, COUNT(A.BLS_ITEM_CD) AS TOTAL_CNT  , SUM(CASE A.WORK_STS	WHEN  N'1' THEN 1 ELSE 0 END) AS DONE_CNT")
                    .AppendLine("  FROM T_INVINST A")
                    .AppendLine("  LEFT JOIN")
                    .AppendLine(" (")
                    .AppendLine(" SELECT")
                    .AppendLine(" A.SYS_CD   , A.FILE_ID, A.FILE_LINE_NO ,  MIN(B.UPD_YB) AS START_TIME,  MAX(B.UPD_YB) AS END_TIME, COUNT(A.BLS_ITEM_CD) AS TOTAL_CNT")
                    .AppendLine(" FROM")
                    .AppendLine(" T_INVINST A")
                    .AppendLine(" LEFT JOIN T_INVRES B")
                    .AppendLine(" ON A.SYS_CD = B.SYS_CD ")
                    .AppendLine("AND A.FILE_ID = B.FILE_ID ")
                    .AppendLine(" AND A.FILE_LINE_NO = B.FILE_LINE_NO")
                    .AppendLine(" WHERE")
                    .AppendLine(" A.WORK_DATE = :SHIP_DATE")
                    .AppendLine(" AND A.INV_KB = :TANA_KBN")
                    .AppendLine(" AND A.WORK_STS <> 9 ")
                    .AppendLine("  AND A.EXP_SPL_QTY <> 0 ")
                    .AppendLine("  GROUP BY A.SYS_CD, A.SYS_CD, A.FILE_LINE_NO, A.FILE_ID")
                    .AppendLine("  ) S2")
                    .AppendLine(" ON A.SYS_CD = S2.SYS_CD ")
                    .AppendLine("AND A.FILE_ID = S2.FILE_ID")
                    .AppendLine("AND A.FILE_LINE_NO = S2.FILE_LINE_NO")
                    .AppendLine("LEFT JOIN M_ZONE M")
                    .AppendLine("ON A.SYS_CD = M.SYS_CD")
                    .AppendLine("AND A.LOC_CD = M.LOC_CD")
                    .AppendLine(" WHERE")
                    .AppendLine(" A.WORK_DATE = :SHIP_DATE ")
                    If Not String.IsNullOrEmpty(pParam.Zone) Then
                        .AppendLine("      AND M.PICK_ZONE =  :ZONE")
                    End If
                    If Not String.IsNullOrEmpty(pParam.TanaOroshiKbn) Then
                        .AppendLine("    AND A.INV_KB = :TANA_KBN")
                    Else
                        .AppendLine("    AND A.INV_KB <>  'A' ")
                    End If
                    If Not String.IsNullOrEmpty(pParam.Zone) Then
                        .AppendLine("    AND M.LOC_CD = A.LOC_CD")
                    End If
                    If Not String.IsNullOrEmpty(pParam.TanaOroshiNo) Then
                        .AppendLine("    AND A.INV_NO LIKE :TANANO || '%'")
                    End If
                    .AppendLine("AND A.WORK_STS <> 9 ")
                    .AppendLine(" AND A.EXP_SPL_QTY <> 0 ")
                    .AppendLine("GROUP BY")
                    .AppendLine(" A.SYS_CD")
                    .AppendLine(", A.CENTER_CD")
                    .AppendLine(", A.WORK_DATE")
                    .AppendLine(", A.INV_KB")
                    .AppendLine(", M.PICK_ZONE")
                    .AppendLine(", A.INV_NO")
                    .AppendLine(", SUBSTR(A.LOC_CD,1,1)")
                    .AppendLine(" ) A")
                    .AppendLine(" ORDER BY INV_NO, LOC_CD")







                    '.AppendLine("SELECT")
                    '.AppendLine("  SYS_CD	")
                    '.AppendLine(" , 	CENTER_CD")
                    '.AppendLine(" , 	WORK_DATE")
                    '.AppendLine(" , 	INV_KB	")
                    '.AppendLine(" , 	ZONE	")
                    '.AppendLine(" , 	INV_NO	")
                    '.AppendLine(" , 	LOC_CD	")
                    '.AppendLine(" , 	START_TIME	")
                    '.AppendLine(" , 	END_TIME")
                    '.AppendLine(" , 	TOTAL_CNT")
                    '.AppendLine(" , 	DONE_CNT")
                    '.AppendLine(" ,	TRUNC((DONE_CNT / TOTAL_CNT) * 100,1)     AS PERSENT	")
                    '.AppendLine("FROM")
                    '.AppendLine("(")
                    '.AppendLine("  SELECT	")
                    '.AppendLine("    A.SYS_CD, A.CENTER_CD, A.WORK_DATE, A.INV_KB, M.PICK_ZONE AS ZONE")
                    '.AppendLine("    , A.INV_NO,SUBSTR(A.LOC_CD,1,1) AS LOC_CD")
                    '.AppendLine("    ,   MIN(RES_V.UPD_YB) AS START_TIME")
                    '.AppendLine("    ,  MAX(RES_V.UPD_YB) AS END_TIME")
                    '.AppendLine("    , COUNT(A.BLS_ITEM_CD) AS TOTAL_CNT")
                    '.AppendLine("    , SUM(CASE A.WORK_STS	WHEN  N'1' THEN 1 ELSE 0 END) AS DONE_CNT")
                    '.AppendLine("  FROM")
                    '.AppendLine("    T_INVINST A")

                    '.AppendLine(" LEFT JOIN  ( ")
                    '.AppendLine(" SELECT  SYS_CD ,CENTER_CD,WORK_DATE ,BLS_ITEM_CD ,  UPD_YB   ")
                    '.AppendLine("  FROM T_INVRES   ")
                    '.AppendLine("  WHERE     SYS_CD = :SYS_CD AND CENTER_CD = :CENTER_CD AND WORK_DATE = :SHIP_DATE ")
                    '.AppendLine("  GROUP BY ")
                    '.AppendLine("  SYS_CD, WORK_DATE, BLS_ITEM_CD, CENTER_CD, UPD_YB ")
                    '.AppendLine("    ) RES_V ")
                    '.AppendLine("   ON A.SYS_CD = RES_V.SYS_CD ")
                    '.AppendLine("   AND A.CENTER_CD = RES_V.CENTER_CD ")
                    '.AppendLine("  AND A.BLS_ITEM_CD = RES_V.BLS_ITEM_CD       ")



                    '.AppendLine("  LEFT JOIN")
                    '.AppendLine("    (")
                    '.AppendLine("      SELECT")
                    '.AppendLine("        PICK_ZONE")
                    '.AppendLine("        , LOC_CD")
                    '.AppendLine("        , SYS_CD")
                    '.AppendLine("      FROM")
                    '.AppendLine("	 M_ZONE")
                    '.AppendLine("      WHERE SYS_CD= :SYS_CD")
                    'If Not String.IsNullOrEmpty(pParam.Zone) Then
                    '    .AppendLine("      AND PICK_ZONE =  :ZONE")
                    'End If
                    '.AppendLine("    ) M")
                    '.AppendLine("  ON A.SYS_CD = M.SYS_CD")
                    '.AppendLine("     AND A.LOC_CD = M.LOC_CD")
                    '.AppendLine("  WHERE")
                    '.AppendLine("    A.WORK_DATE = :SHIP_DATE ")
                    'If Not String.IsNullOrEmpty(pParam.TanaOroshiKbn) Then
                    '    .AppendLine("    AND A.INV_KB = :TANA_KBN")
                    'Else
                    '    .AppendLine("    AND A.INV_KB <>  'A' ")
                    'End If
                    'If Not String.IsNullOrEmpty(pParam.Zone) Then
                    '    .AppendLine("    AND M.LOC_CD = A.LOC_CD")
                    'End If
                    'If Not String.IsNullOrEmpty(pParam.TanaOroshiNo) Then
                    '    .AppendLine("    AND A.INV_NO LIKE :TANANO || '%'")
                    'End If
                    '.AppendLine("    AND A.WORK_STS <> 9 ")
                    '.AppendLine("    AND A.EXP_SPL_QTY <> 0 ")
                    '.AppendLine("  GROUP BY")
                    '.AppendLine("    A.SYS_CD")
                    '.AppendLine("   , A.CENTER_CD")
                    '.AppendLine("   , A.WORK_DATE")
                    '.AppendLine("   , A.INV_KB")
                    '.AppendLine("   , M.PICK_ZONE")
                    '.AppendLine("   , A.INV_NO")
                    '.AppendLine("   , SUBSTR(A.LOC_CD,1,1)")
                    '.AppendLine(")")
                    '.AppendLine("ORDER BY")
                    '.AppendLine("  INV_NO")
                    '.AppendLine(" , LOC_CD")

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
#Region " CreateFindCodeByComboSql "
        ''' <summary>
        ''' 汎用ｺｰﾄﾞﾏｽﾀ情報(ｺﾝﾎﾞﾎﾞｯｽｸ)検索用SQL文を生成します。
        ''' </summary>
        ''' <param name="pstrSysCd">ｼｽﾃﾑｺｰﾄﾞ</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/09/30 Created</history>
        Private Function CreateFindHaniKbByComboSql(Optional ByVal pstrSysCd As String = "") As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT DISTINCT")
                    .AppendLine("      CODE")       'ｺｰﾄﾞ
                    .AppendLine("    , CODE_NM")    'ｺｰﾄﾞ名称
                    .AppendLine("FROM  M_CODE")
                    .AppendLine("WHERE CODE_KEY  = :CODE_KEY ")      'ｺｰﾄﾞｷｰ
                    '   .AppendLine("  AND   CODE     <> :CODE")          'ｺｰﾄﾞ
                    .AppendLine("  AND   CODE     <>  'HEADER'")
                    If Not pstrSysCd.Equals(String.Empty) Then
                        .AppendLine("  AND   SYS_CD  = :SYS_CD")      'ｼｽﾃﾑｺｰﾄﾞ
                    End If

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

#Region " FindZoneMaster "
        ''' <summary>
        ''' ロケーション（ゾーン）検索用SQL文を生成します。
        ''' </summary>
        ''' <param name="Param">ゾーンｺｰﾄﾞ</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/09/30 Created</history>
        Private Function FindZoneMaster(ByVal Param As FindZoneCode) As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT DISTINCT")
                    .AppendLine("      PICK_ZONE")       'ｺｰﾄﾞ
                    .AppendLine("    , LOC_CD")    'ｺｰﾄﾞ名称
                    .AppendLine("    , SYS_CD")    'ｺｰﾄﾞ名称
                    .AppendLine("FROM  M_ZONE")
                    .AppendLine("WHERE LOC_CD  = :LOC_CD ")      'ｺｰﾄﾞｷｰ
                    .AppendLine("  AND   SYS_CD  = :SYS_CD")      'ｼｽﾃﾑｺｰﾄﾞ

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

