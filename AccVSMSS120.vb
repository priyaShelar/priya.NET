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
    Public Class AccVSMSS120
        Inherits ComAccBase

#Region " 定数 "

#End Region

#Region " 変数 "

#Region " PicProgressParam "
        ''' <summary>
        ''' 棚卸検索条件
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Class PicProgressParam
            Private strSysCd As String = String.Empty
            Private strCenterCd As String = String.Empty
            Private strArrivalDate As String = String.Empty
            Private strVendorCd As String = String.Empty
            Private strVendorNm As String = String.Empty
            Private StrInKb As String = String.Empty

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
            Property InKb() As String
                Get
                    Return StrInKb
                End Get
                Set(ByVal value As String)
                    StrInKb = value
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
            ''' 出荷日
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Arrival_Date() As String
                Get
                    Return strArrivalDate
                End Get
                Set(ByVal value As String)
                    strArrivalDate = value
                End Set
            End Property

            ''' <summary>
            ''' 納品先BLSコード
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Vendor_Cd() As String
                Get
                    Return strVendorCd
                End Get
                Set(ByVal value As String)
                    strVendorCd = value
                End Set
            End Property

            ''' <summary>
            ''' 納品先名
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Vendor_Nm() As String
                Get
                    Return strVendorNm
                End Get
                Set(ByVal value As String)
                    strVendorNm = value
                End Set
            End Property

        End Class
#End Region

#Region " FindNyukaKb "
        ''' <summary>
        ''' 棚卸検索条件
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Class FindNyukaKb
            Private strSysCd As String = String.Empty
            Private strCode As String = String.Empty


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
            Property Code() As String
                Get
                    Return strCode
                End Get
                Set(ByVal value As String)
                    strCode = value
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
                    .AddParameter("ARRIVAL_DATE", SqlType.VarChar, param.Arrival_Date)          '入荷予定日
                    If Not String.IsNullOrEmpty(param.Vendor_Cd) Then
                        .AddParameter("VENDOR_CD", SqlType.VarChar, param.Vendor_Cd)            '発地コード
                    End If
                    If Not String.IsNullOrEmpty(param.Vendor_Nm) Then
                        .AddParameter("VENDOR_NM", SqlType.VarChar, param.Vendor_Nm)            '発地名称
                    End If
                    If Not String.IsNullOrEmpty(param.InKb) Then
                        .AddParameter("IN_KB", SqlType.VarChar, param.InKb)                     '入荷区分
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
        Public Function FindNyukaKbByCombo(ByVal pstrCodeKey As String, _
                                        Optional ByVal pstrSysCd As String = "", _
                                        Optional ByVal pblnBlank As Boolean = True, _
                                        Optional ByVal pblnClose As Boolean = False) As NameValueCollection
            Dim dstDat As New DataSet
            Dim nvcDat As New NameValueCollection
            Try
                If pblnBlank Then
                    '空白追加
                    nvcDat.Add(String.Empty, String.Empty)
                End If

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
                dstDat = m_clsDbReader.GetTableData(CreateFindNyukaKbByComboSql(pstrSysCd))

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
        Public Function FindNyukaKbn(ByVal param As FindNyukaKb) As String
            Dim dstDat As New DataSet
            Dim pickNyuuka As String

            Try
                With m_clsDbReader
                    '取得ﾊﾟﾗﾒｰﾀ
                    .ClearParameter()
                    .AddParameter("CODE", SqlType.VarChar, param.Code)                                       'ロケーション（ゾーン）
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)                                       'システムコード

                End With

                'ゾーンマスタ情報取得SQL実行
                dstDat = m_clsDbReader.GetTableData(FindNyukaKbnSQL(param))
                If (dstDat.Tables(0).Rows.Count = 0) Then
                    pickNyuuka = ""
                Else
                    pickNyuuka = dstDat.Tables(0).Rows(0).Item("CODE_NM").ToString
                End If

                'ゾーンマスタ情報
                Return pickNyuuka

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

#Region " FindSobara "
        ''' <summary>
        ''' 棚卸進捗状況を検索します。
        ''' </summary>
        ''' <param name="param">棚卸進捗検索パラメータ</param>
        ''' <returns>棚卸進捗情報</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info. 2019/10/24 Created</history>
        Public Function FindSobara(ByVal param As PicProgressParam) As DataTable
            Dim dstDat As New DataSet

            Try
                With m_clsDbReader
                    '取得ﾊﾟﾗﾒｰﾀ
                    .ClearParameter()
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)                           'システムコード
                    .AddParameter("CENTER_CD", SqlType.VarChar, param.CenterCd)                     'センターコード
                    .AddParameter("ARRIVAL_DATE", SqlType.VarChar, param.Arrival_Date)              '入荷予定日
                    If Not String.IsNullOrEmpty(param.Vendor_Cd) Then
                        .AddParameter("VENDOR_CD", SqlType.VarChar, param.Vendor_Cd)                '発地コード
                    End If
                    If Not String.IsNullOrEmpty(param.Vendor_Nm) Then
                        .AddParameter("VENDOR_NM", SqlType.VarChar, param.Vendor_Nm)                '発地名称
                    End If
                    If Not String.IsNullOrEmpty(param.InKb) Then
                        .AddParameter("IN_KB", SqlType.VarChar, param.InKb)                        '入荷区分
                    End If
                End With

                '棚卸進捗情報取得SQL実行
                dstDat = m_clsDbReader.GetTableData(CreateFindSobaraSql(param))

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

#End Region

#Region " Private "

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
                    '.AppendLine("SELECT")
                    '.AppendLine("   SYS_CD")
                    '.AppendLine(",  CENTER_CD")
                    '.AppendLine(",  VENDOR_CD")
                    '.AppendLine(",  VENDOR_NM")
                    '.AppendLine(",  INPLAN_DATE")
                    '.AppendLine(",  INOUT_KB")
                    '.AppendLine(",  MIN(UPD_YB) AS START_TIME")
                    '.AppendLine(",  MAX(UPD_YB) AS END_TIME")
                    '.AppendLine(",  COUNT(BLS_ITEM_CD) AS TOTAL_CNT")
                    '.AppendLine(",  SUM (CASE WORK_STS  WHEN  N'1' THEN 1 ELSE 0 END) AS DONE_CNT")
                    '.AppendLine(",  SUM(EXP_SPL_QTY) AS TOTAL")
                    '.AppendLine("FROM")
                    '.AppendLine("    T_INPLAN ")
                    '.AppendLine("WHERE SYS_CD   = :SYS_CD")
                    'If Not String.IsNullOrEmpty(pParam.Vendor_Cd) Then
                    '    .AppendLine("   AND VENDOR_CD LIKE :VENDOR_CD || '%'")
                    'End If

                    '.AppendLine("   AND INPLAN_DATE    =   :ARRIVAL_DATE ")

                    'If Not String.IsNullOrEmpty(pParam.Vendor_Nm) Then
                    '    .AppendLine("   AND VENDOR_NM LIKE '%' || :VENDOR_NM || '%'")
                    'End If

                    'If Not String.IsNullOrEmpty(pParam.InKb) Then
                    '    .AppendLine("   AND INOUT_KB    =   :IN_KB ")
                    'End If

                    '.AppendLine("  AND WORK_STS <> 9 ")
                    '.AppendLine("GROUP BY")
                    '.AppendLine("   SYS_CD      ,   CENTER_CD")
                    '.AppendLine("  ,VENDOR_CD   ,   VENDOR_NM")
                    '.AppendLine("  ,INPLAN_DATE ,   INOUT_KB")
                    '.AppendLine("ORDER BY")
                    '.AppendLine("  VENDOR_CD")

                    .AppendLine("SELECT ")
                    .AppendLine("  A.SYS_CD ")
                    .AppendLine("  , A.CENTER_CD ")
                    .AppendLine("  , A.VENDOR_CD ")
                    .AppendLine("  , A.VENDOR_NM ")
                    .AppendLine("  , A.INPLAN_DATE ")
                    .AppendLine("  , A.INOUT_KB ")
                    .AppendLine("  , MAX(B.START_TIME) AS START_TIME ")     '--開始。oracleのgroup by制限を避けるためのトリックでmax使っている
                    .AppendLine("  , MAX(B.END_TIME) AS END_TIME ")         '--終了時間
                    .AppendLine("  , MAX(NVL(Z.cnt,0)) AS TOTAL_CNT ")      '--明細の総数(ALL)
                    .AppendLine("  , SUM(CASE WHEN A.WORK_STS='1' THEN 1 ELSE 0 END) AS DONE_CNT ") '--完了の明細総数(ALL)
                    .AppendLine("  , SUM(NVL(A.EXP_SPL_QTY,0)) AS TOTAL ")                  '--予定のロット数
                    .AppendLine("  , SUM(NVL(B.ACT_SPS_QTY,0)) AS RES_LOT_TOTAL ")          '--完了のロット数
                    .AppendLine("  , MAX(NVL(X.sum_exp_spl_qty,0)) AS sum_exp_spl_qty ")    '--予定のロット総数(ALL)
                    .AppendLine("  , MAX(NVL(Y.sum_act_sps_qty,0)) AS sum_act_sps_qty ")    '--完了のロット総数(ALL)

                    .AppendLine("FROM T_INPLAN     A ")

                    '-- start,end時間は T_INRES。
                    '-- 完了実績数カウントのとき、FILE_IDは無視。どのメーカーのものがどれだけ終わったか？を見たい
                    .AppendLine("LEFT JOIN ( ")
                    .AppendLine("  SELECT ")
                    .AppendLine("    SYS_CD ")
                    .AppendLine("    , CENTER_CD ")
                    .AppendLine("    , VENDOR_CD ")
                    .AppendLine("    , INPLAN_DATE ")
                    .AppendLine("    , INOUT_KB ")
                    .AppendLine("    , MIN(INS_YB) AS START_TIME ")     '--開始時間
                    .AppendLine("    , MAX(INS_YB) AS END_TIME ")       '--終了時間
                    .AppendLine("    , SUM(NVL(ACT_SPS_QTY,0)) AS ACT_SPS_QTY ")    '--完了ロット数
                    .AppendLine("  FROM T_INRES ")
                    .AppendLine("  GROUP BY ")
                    .AppendLine("      SYS_CD ")
                    .AppendLine("    , CENTER_CD ")
                    .AppendLine("    , VENDOR_CD ")
                    .AppendLine("    , INPLAN_DATE ")
                    .AppendLine("    , INOUT_KB ")
                    .AppendLine(") B ")
                    .AppendLine("  ON ")
                    .AppendLine("    B.SYS_CD = A.SYS_CD ")
                    .AppendLine("    AND B.CENTER_CD     = A.CENTER_CD ")
                    .AppendLine("    AND B.VENDOR_CD     = A.VENDOR_CD ")
                    .AppendLine("    AND B.INPLAN_DATE   = A.INPLAN_DATE ")
                    .AppendLine("    AND B.INOUT_KB      = A.INOUT_KB ")
                    '.AppendLine("    AND B.FILE_ID       = A.FILE_ID ")
                    '.AppendLine("    AND B.FILE_LINE_NO  = A.FILE_LINE_NO ")
                    '.AppendLine("    AND B.BLS_ITEM_CD   = A.BLS_ITEM_CD ")

                    '-- Z明細数のカウント。FILE_ID, ITEM_CD は無視。
                    .AppendLine("LEFT JOIN ( ")
                    .AppendLine("  SELECT ")
                    .AppendLine("    COUNT(*) AS cnt ")
                    .AppendLine("    , SYS_CD ")
                    .AppendLine("    , CENTER_CD ")
                    .AppendLine("    , VENDOR_CD ")
                    .AppendLine("    , INPLAN_DATE ")
                    .AppendLine("    , INOUT_KB ")
                    .AppendLine("  FROM T_INPLAN ")
                    .AppendLine("  GROUP BY ")
                    .AppendLine("      SYS_CD ")
                    .AppendLine("    , CENTER_CD ")
                    .AppendLine("    , VENDOR_CD ")
                    .AppendLine("    , INPLAN_DATE ")
                    .AppendLine("    , INOUT_KB ")
                    .AppendLine(") Z ")
                    .AppendLine("  ON  Z.SYS_CD = A.SYS_CD ")
                    .AppendLine("    AND Z.CENTER_CD = A.CENTER_CD ")
                    .AppendLine("    AND Z.VENDOR_CD = A.VENDOR_CD ")
                    .AppendLine("    AND Z.INPLAN_DATE   = A.INPLAN_DATE ")
                    .AppendLine("    AND Z.INOUT_KB = A.INOUT_KB ")

                    '-- X予定のロット総数
                    .AppendLine("LEFT JOIN ( ")
                    .AppendLine("    SELECT ")
                    .AppendLine("    SUM(NVL(EXP_SPL_QTY,0)) AS sum_exp_spl_qty ")
                    .AppendLine("    , INPLAN_DATE ")
                    .AppendLine("    , SYS_CD ")
                    .AppendLine("    , CENTER_CD ")
                    .AppendLine("    FROM T_INPLAN  ")
                    .AppendLine("    WHERE  WORK_STS <> '9' ")
                    .AppendLine("    GROUP BY SYS_CD, CENTER_CD, INPLAN_DATE ")
                    .AppendLine(") X ")
                    .AppendLine("  ON    X.SYS_CD = A.SYS_CD ")
                    .AppendLine("    AND X.CENTER_CD = A.CENTER_CD ")
                    .AppendLine("    AND X.INPLAN_DATE = A.INPLAN_DATE ")

                    '-- Y実績のロット総数
                    .AppendLine("LEFT JOIN ( ")
                    .AppendLine("    SELECT ")
                    .AppendLine("    SUM(NVL(ACT_SPS_QTY,0)) AS sum_act_sps_qty ")
                    .AppendLine("    , INPLAN_DATE ")
                    .AppendLine("    , SYS_CD ")
                    .AppendLine("    , CENTER_CD ")
                    .AppendLine("    FROM T_INRES ")
                    .AppendLine("    GROUP BY SYS_CD, CENTER_CD, INPLAN_DATE ")
                    .AppendLine(") Y ")
                    .AppendLine("  ON    Y.SYS_CD = A.SYS_CD ")
                    .AppendLine("    AND Y.CENTER_CD = A.CENTER_CD ")
                    .AppendLine("    AND Y.INPLAN_DATE = A.INPLAN_DATE ")

                    '-- 絞り込み条件
                    .AppendLine("WHERE A.SYS_CD   = :SYS_CD")
                    .AppendLine("    AND WORK_STS <> 9 ")
                    .AppendLine("    AND A.INPLAN_DATE    =   :ARRIVAL_DATE ")

                    If Not String.IsNullOrEmpty(pParam.Vendor_Cd) Then
                        .AppendLine("   AND A.VENDOR_CD LIKE :VENDOR_CD || '%'")
                    End If

                    If Not String.IsNullOrEmpty(pParam.Vendor_Nm) Then
                        .AppendLine("   AND A.VENDOR_NM LIKE '%' || :VENDOR_NM || '%'")
                    End If

                    If Not String.IsNullOrEmpty(pParam.InKb) Then
                        .AppendLine("   AND A.INOUT_KB    =   :IN_KB ")
                    End If

                    .AppendLine("GROUP BY ")
                    .AppendLine("    A.SYS_CD ")
                    .AppendLine("  , A.CENTER_CD ")
                    .AppendLine("  , A.VENDOR_CD  ,   A.VENDOR_NM ")
                    .AppendLine("  , A.INPLAN_DATE ")
                    .AppendLine("  , A.INOUT_KB ")

                    .AppendLine("ORDER BY ")
                    .AppendLine("    A.VENDOR_CD ")

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

#Region " CreateFindNyukaKbByComboSql "
        ''' <summary>
        ''' 汎用ｺｰﾄﾞﾏｽﾀ情報(ｺﾝﾎﾞﾎﾞｯｽｸ)検索用SQL文を生成します。
        ''' </summary>
        ''' <param name="pstrSysCd">ｼｽﾃﾑｺｰﾄﾞ</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/09/30 Created</history>
        Private Function CreateFindNyukaKbByComboSql(Optional ByVal pstrSysCd As String = "") As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT DISTINCT")
                    .AppendLine("      CODE")       'ｺｰﾄﾞ
                    .AppendLine("    , CODE_NM")    'ｺｰﾄﾞ名称
                    .AppendLine("FROM  M_CODE")
                    .AppendLine("WHERE CODE_KEY  = :CODE_KEY ")      'ｺｰﾄﾞｷｰ
                    '   .AppendLine("AND   CODE     <> :CODE")          'ｺｰﾄﾞ
                    .AppendLine("   AND   CODE     <>  'HEADER'")
                    If Not pstrSysCd.Equals(String.Empty) Then
                        .AppendLine("   AND   SYS_CD  = :SYS_CD")      'ｼｽﾃﾑｺｰﾄﾞ
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

#Region " FindNyukaKbnSQL "
        ''' <summary>
        ''' ロケーション（ゾーン）検索用SQL文を生成します。
        ''' </summary>
        ''' <param name="Param">棚卸検索条件</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/09/30 Created</history>
        Private Function FindNyukaKbnSQL(ByVal Param As FindNyukaKb) As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT DISTINCT")
                    .AppendLine("      CODE_NM")       'ｺｰﾄﾞ
                    .AppendLine("    , SYS_CD")    'ｺｰﾄﾞ名称
                    .AppendLine("FROM  M_CODE")
                    .AppendLine("WHERE CODE  = :CODE ")      'ｺｰﾄﾞｷｰ

                    .AppendLine("AND   SYS_CD  = :SYS_CD")      'ｼｽﾃﾑｺｰﾄﾞ



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

#Region " CreateFindSobaraSql "
        ''' <summary>
        ''' 棚卸進捗照会用SQL文を生成します。
        ''' </summary>
        ''' <param name="pParam">検索条件</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info. 2019/10/23 Created</history>
        Private Function CreateFindSobaraSql(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder

            Try
                'SQL発行
                With strSql
                    .AppendLine("SELECT")
                    .AppendLine("  SYS_CD , CENTER_CD ")
                    .AppendLine("  , VENDOR_CD , VENDOR_NM")
                    .AppendLine("  , INPLAN_DATE")
                    .AppendLine("  , INOUT_KB")
                    .AppendLine("  , SUM(EXP_SPL_QTY) AS TOTAL")
                    .AppendLine("FROM")
                    .AppendLine("    T_INRES ")
                    .AppendLine("WHERE SYS_CD= :SYS_CD")
                    If Not String.IsNullOrEmpty(pParam.Vendor_Cd) Then
                        .AppendLine("   AND VENDOR_CD LIKE :VENDOR_CD || '%'")
                    End If
                    .AppendLine("    AND INPLAN_DATE=:ARRIVAL_DATE ")
                    If Not String.IsNullOrEmpty(pParam.Vendor_Nm) Then
                        .AppendLine("   AND VENDOR_NM LIKE '%' || :VENDOR_NM || '%'")
                    End If
                    If Not String.IsNullOrEmpty(pParam.InKb) Then
                        .AppendLine("   AND INOUT_KB=:IN_KB ")
                    End If

                    .AppendLine("GROUP BY")
                    .AppendLine("  SYS_CD , CENTER_CD ")
                    .AppendLine("  , VENDOR_CD , VENDOR_NM")
                    .AppendLine("  , INPLAN_DATE")
                    .AppendLine("  , INOUT_KB")
                    .AppendLine("ORDER BY")
                    .AppendLine("  VENDOR_CD")

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

