'----------------------------------------------------------------------------------------------
'  機能名　　　　    : DBAccessクラス
'  機能説明　　　    : DB機能を提供します。
'  備考　　　　　    : なし
'  作成日　　　　    : 2019/09/05
'  作成者　　　　    : 
'----------------------------------------------------------------------------------------------
'  更新日，更新者    : 
'  更新内容　　　    : 
'----------------------------------------------------------------------------------------------
Imports System.Text
Imports System.Collections.Specialized
Imports VWS.iSenseOpenLib.Librarys.ComCns
Imports VWS.VSMS.VSMSLib.Librarys

Namespace Acc
    ''' <summary>
    ''' DBAccessクラス
    ''' </summary>
    ''' <remarks>DB機能を提供します。</remarks>
    ''' <history>Arche Info. Inc. 2019/09/05 Created</history>
    Public Class AccVSMSS310
        Inherits ComAccBase

#Region " 定数 "

#End Region

#Region " 変数 "
        ''' <summary>ピッキング情報</summary>
        Public g_srtPicres As T_Picres

#Region " 変数 FindNyukaKb "
        ''' <summary>
        ''' 棚卸検索条件
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Class FindNyukaKb
            Private strSysCd As String = String.Empty
            Private strCode As String = String.Empty
            Private strStatus As String = String.Empty


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
            ''' コード
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


            ''' <summary>
            ''' work status
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property Status() As String
                Get
                    Return strStatus
                End Get
                Set(ByVal value As String)
                    strStatus = value
                End Set
            End Property
        End Class
#End Region

#Region " 変数 PicProgressParam "
        ''' <summary>
        ''' 棚卸検索条件
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Class PicProgressParam
            Private strSysCd As String = String.Empty
            Private strCenterCd As String = String.Empty
            Private strLocCd As String = String.Empty

            Private strShipDate As String = String.Empty
            Private strBlsDeliCd As String = String.Empty
            Private strBlsDeliNm As String = String.Empty

            Private strStatus As String = String.Empty
            Private strItemNm As String = String.Empty
            Private strBlsItemCd As String = String.Empty
            Private strZone As String = String.Empty
            Private strWorkUserNm As String = String.Empty
            Private strRejKb As String = String.Empty
            Private strZaiko As String = String.Empty

            Private strTanaOroshi_No As String = String.Empty
            Private strTanaOroshi_Kbn As String = String.Empty
            Private strchkDiff As String = String.Empty


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
            ''' 棚卸NO
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property TanaOroshi_No() As String
                Get
                    Return strTanaOroshi_No
                End Get
                Set(ByVal value As String)
                    strTanaOroshi_No = value
                End Set
            End Property

            ''' <summary>
            ''' 棚卸区分
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property TanaOroshi_Kbn() As String
                Get
                    Return strTanaOroshi_Kbn
                End Get
                Set(ByVal value As String)
                    strTanaOroshi_Kbn = value
                End Set
            End Property

            ''' <summary>
            ''' ステータス
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property Status() As String
                Get
                    Return strStatus
                End Get
                Set(ByVal value As String)
                    strStatus = value
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
            ''' Locationコード
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

            ''' <summary>
            ''' 商品BLSコード
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Item_Code() As String
                Get
                    Return strBlsItemCd
                End Get
                Set(ByVal value As String)
                    strBlsItemCd = value
                End Set
            End Property

            ''' <summary>
            ''' 商品名称
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Item_Name() As String
                Get
                    Return strItemNm
                End Get
                Set(ByVal value As String)
                    strItemNm = value
                End Set
            End Property

            ''' <summary>
            ''' ゾーン
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Zone() As String
                Get
                    Return strZone
                End Get
                Set(ByVal value As String)
                    strZone = value
                End Set
            End Property

            ''' <summary>
            ''' 作業者
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property WorkUsr_Name() As String
                Get
                    Return strWorkUserNm
                End Get
                Set(ByVal value As String)
                    strWorkUserNm = value
                End Set
            End Property


            ''' <summary>
            ''' 不良品区分
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property RejectKb() As String
                Get
                    Return strRejKb
                End Get
                Set(ByVal value As String)
                    strRejKb = value
                End Set
            End Property

            ''' <summary>
            ''' 在庫ゼロ
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Zaiko() As String
                Get
                    Return strZaiko
                End Get
                Set(ByVal value As String)
                    strZaiko = value
                End Set
            End Property

            ''' <summary>
            ''' 差異あり
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property chkDiff() As String
                Get
                    Return strchkDiff
                End Get
                Set(ByVal value As String)
                    strchkDiff = value
                End Set
            End Property



        End Class
#End Region

#Region " 変数 FindZoneCode "
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
            ''' ロケーションコード
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

#Region " 構造体 "

#Region " T_Picres "
        ''' <summary>
        ''' ピッキング実績情報構造体
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Public Structure T_Picres
#Region " 変数 "
            ''' <summary>GAEA区分コード</summary>
            Private strSysCd As String

            ''' <summary>センターコード</summary>
            Private strCenterCd As String

            ''' <summary>出荷日</summary>
            Private strShipDate As String

            ''' <summary>納品先BLSコード</summary>
            Private strBlsDeliCd As String

            ''' <summary>納品先名称</summary>
            Private strBlsDeliNm As String

            ''' <summary>商品BLSコード</summary>
            Private strBlsItemCd As String

            ''' <summary>商品名称</summary>
            Private strBlsItemNm As String

            ''' <summary>JANコード(単品)</summary>
            Private strJanCd As String

            ''' <summary>JANコード(ケース)</summary>
            Private strCsJanCd As String

            ''' <summary>ITFコード</summary>
            Private strItfCd As String

            ''' <summary>ロケーション</summary>
            Private strLocCd As String

            ''' <summary>商品管理日</summary>
            Private strItemMngDate As String

            ''' <summary>作業ステータス</summary>
            Private strWorkSts As String

            ''' <summary>作業者名称</summary>
            Private strWorkUserNm As String

            ''' <summary>最終更新日時</summary>
            Private strPreUpdYb As String

            ''' <summary>更新日時(現在日付)</summary>
            Private strUpdYbNow As String

            ''' <summary>行数</summary>
            Private intRow As Integer

            Private strTanaOroshiNo As String
            Private strTanaOroshiKb As String
#End Region

#Region " プロパティ "

#Region " Sys_Cd "
            ''' <summary>
            ''' センターコードを取得・設定します。
            ''' </summary>
            ''' <value>センターコード</value>
            ''' <returns>センターコード</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Sys_Cd() As String
                Get
                    Return strSysCd
                End Get
                Set(ByVal value As String)
                    strSysCd = value
                End Set
            End Property
#End Region

#Region " Center_Cd "
            ''' <summary>
            ''' センターコードを取得・設定します。
            ''' </summary>
            ''' <value>センターコード</value>
            ''' <returns>センターコード</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Center_Cd() As String
                Get
                    Return strCenterCd
                End Get
                Set(ByVal value As String)
                    strCenterCd = value
                End Set
            End Property
#End Region

#Region " Ship_Date "
            ''' <summary>
            ''' 棚卸実施日を取得・設定します。
            ''' </summary>
            ''' <value>棚卸実施日</value>
            ''' <returns>棚卸実施日</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Ship_Date() As String
                Get
                    Return strShipDate
                End Get
                Set(ByVal value As String)
                    strShipDate = value
                End Set
            End Property
#End Region

#Region " Bls_Deli_Cd "
            ''' <summary>
            ''' 納品先BLSコードを取得・設定します。
            ''' </summary>
            ''' <value>納品先BLSコード</value>
            ''' <returns>納品先BLSコード</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Bls_Deli_Cd() As String
                Get
                    Return strBlsDeliCd
                End Get
                Set(ByVal value As String)
                    strBlsDeliCd = value
                End Set
            End Property
#End Region

#Region " Bls_Deli_Nm "
            ''' <summary>
            ''' 納品先名称を取得・設定します。
            ''' </summary>
            ''' <value>納品先名称</value>
            ''' <returns>納品先名称</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Bls_Deli_Nm() As String
                Get
                    Return strBlsDeliNm
                End Get
                Set(ByVal value As String)
                    strBlsDeliNm = value
                End Set
            End Property
#End Region

#Region " Bls_Item_Cd "
            ''' <summary>
            ''' 商品BLSコードを取得・設定します。
            ''' </summary>
            ''' <value>商品BLSコード</value>
            ''' <returns>商品BLSコード</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Bls_Item_Cd() As String
                Get
                    Return strBlsItemCd
                End Get
                Set(ByVal value As String)
                    strBlsItemCd = value
                End Set
            End Property
#End Region

#Region " Bls_Item_Nm "
            ''' <summary>
            ''' 商品名称を取得・設定します。
            ''' </summary>
            ''' <value>商品名称</value>
            ''' <returns>商品名称</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Bls_Item_Nm() As String
                Get
                    Return strBlsItemNm
                End Get
                Set(ByVal value As String)
                    strBlsItemNm = value
                End Set
            End Property
#End Region

#Region " Jan_Cd "
            ''' <summary>
            ''' JANコード(単品)を取得・設定します。
            ''' </summary>
            ''' <value>JANコード(単品)</value>
            ''' <returns>JANコード(単品)</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Jan_Cd() As String
                Get
                    Return strJanCd
                End Get
                Set(ByVal value As String)
                    strJanCd = value
                End Set
            End Property
#End Region

#Region " Cs_Jan_Cd "
            ''' <summary>
            ''' JANコード(ケース)を取得・設定します。
            ''' </summary>
            ''' <value>JANコード(ケース)</value>
            ''' <returns>JANコード(ケース)</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Cs_Jan_Cd() As String
                Get
                    Return strCsJanCd
                End Get
                Set(ByVal value As String)
                    strCsJanCd = value
                End Set
            End Property
#End Region

#Region " Itf_Cd "
            ''' <summary>
            ''' ITFコードを取得・設定します。
            ''' </summary>
            ''' <value>ITFコード</value>
            ''' <returns>ITFコード</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Itf_Cd() As String
                Get
                    Return strItfCd
                End Get
                Set(ByVal value As String)
                    strItfCd = value
                End Set
            End Property
#End Region

#Region " Loc_Cd "
            ''' <summary>
            ''' ロケーションを取得・設定します。
            ''' </summary>
            ''' <value>ロケーション</value>
            ''' <returns>ロケーション</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Loc_Cd() As String
                Get
                    Return strLocCd
                End Get
                Set(ByVal value As String)
                    strLocCd = value
                End Set
            End Property
#End Region

#Region " Item_Mng_Date "
            ''' <summary>
            ''' 商品管理日を取得・設定します。
            ''' </summary>
            ''' <value>商品管理日</value>
            ''' <returns>商品管理日</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Item_Mng_Date() As String
                Get
                    Return strItemMngDate
                End Get
                Set(ByVal value As String)
                    strItemMngDate = value
                End Set
            End Property
#End Region

#Region " Work_Sts "
            ''' <summary>
            ''' 作業ステータスを取得・設定します。
            ''' </summary>
            ''' <value>作業ステータス</value>
            ''' <returns>作業ステータス</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Work_Sts() As String
                Get
                    Return strWorkSts
                End Get
                Set(ByVal value As String)
                    strWorkSts = value
                End Set
            End Property
#End Region

#Region " Work_User_Nm "
            ''' <summary>
            ''' 作業者名称を取得・設定します。
            ''' </summary>
            ''' <value>作業者名称</value>
            ''' <returns>作業者名称</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Work_User_Nm() As String
                Get
                    Return strWorkUserNm
                End Get
                Set(ByVal value As String)
                    strWorkUserNm = value
                End Set
            End Property
#End Region

#Region " Pre_Upd_Yb "
            ''' <summary>
            ''' 最終更新日時を取得・設定します。
            ''' </summary>
            ''' <value>最終更新日時</value>
            ''' <returns>最終更新日時</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Pre_Upd_Yb() As String
                Get
                    Return strPreUpdYb
                End Get
                Set(ByVal value As String)
                    strPreUpdYb = value
                End Set
            End Property
#End Region

#Region " Upd_Yb_Now "
            ''' <summary>
            ''' 更新日時(現在日付)を取得・設定します。
            ''' </summary>
            ''' <value>更新日時(現在日付)</value>
            ''' <returns>更新日時(現在日付)</returns>
            ''' <remarks></remarks>
            ''' <history>AST H.Ishikawa 2016/02/03 Created</history>
            Public Property Upd_Yb_Now() As String
                Get
                    Return strUpdYbNow
                End Get
                Set(ByVal value As String)
                    strUpdYbNow = value
                End Set
            End Property
#End Region

#Region " Row "
            ''' <summary>
            ''' 行数を取得・設定します。
            ''' </summary>
            ''' <value>行数</value>
            ''' <returns>行数</returns>
            ''' <remarks></remarks>
            ''' <history>AST H.Ishikawa 2016/02/03 Created</history>
            Public Property Row() As Integer
                Get
                    Return intRow
                End Get
                Set(ByVal value As Integer)
                    intRow = value
                End Set
            End Property
#End Region

#Region " TanaOroshi_No "
            ''' <summary>
            ''' 棚卸No.を取得・設定します。
            ''' </summary>
            ''' <value>棚卸No.</value>
            ''' <returns>棚卸No.</returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/09/04 Created</history>
            Public Property TanaOroshi_No() As String
                Get
                    Return strTanaOroshiNo
                End Get
                Set(ByVal value As String)
                    strTanaOroshiNo = value
                End Set
            End Property
#End Region

#Region " TanaOroshi_Kb "
            ''' <summary>
            ''' 棚卸区分を取得・設定します。
            ''' </summary>
            ''' <value>棚卸区分</value>
            ''' <returns>棚卸区分</returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/09/04 Created</history>
            Public Property TanaOroshi_Kb() As String
                Get
                    Return strTanaOroshiKb
                End Get
                Set(ByVal value As String)
                    strTanaOroshiKb = value
                End Set
            End Property
#End Region

#End Region

        End Structure
#End Region

#End Region

#Region " コンストラクタ "
        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="pstrUserId">ユーザID</param>
        ''' <param name="pstrTarmId">端末ID</param>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/05 Created</history>
        Public Sub New(ByVal pstrUserId As String, ByVal pstrTarmId As String)
            MyBase.New(pstrUserId, pstrTarmId, ComConst.ProgramID.PGIDS210)
            Try

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region " メソッド "

#Region " Public "


#Region " FindCodeByCombo "
        ''' <summary>
        ''' 汎用コードマスタ情報(コンボボッスク)を取得します。
        ''' </summary>
        ''' <param name="pstrCodeKey">キーコード</param>
        ''' <param name="pstrSysCd">システムコード</param>
        ''' <param name="pblnBlank">ブランクフラグ(Trueの場合、先頭空白を追加する)</param>
        ''' <param name="pblnClose">クローズフラグ(Trueの場合、DBをクローズする)</param>
        ''' <returns>ユーザマスタ件数</returns>
        ''' <remarks></remarks>
        ''' <history>AST H.Ishikawa 2015/04/01 Created</history>
        Public Function FindHaniKbByCombo(ByVal pstrCodeKey As String, _
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

                'DBオープン
                If Not DBReaderOpen().Equals(DbAccessResultStatus.Normal) Then
                    Return nvcDat
                End If

                With m_clsDbReader
                    .ClearParameter()
                    '取得パラメータ
                    .AddParameter("CODE_KEY", SqlType.VarChar, pstrCodeKey)             'システムコード
                    .AddParameter("CODE", SqlType.VarChar, ComConst.CODE_KEY.MTITLE)    'コード
                    If Not pstrSysCd.Equals(String.Empty) Then
                        .AddParameter("SYS_CD", SqlType.VarChar, pstrSysCd)             'システムコード
                    End If
                End With

                '汎用コードマスタ取得SQL実行
                dstDat = m_clsDbReader.GetTableData(CreateFindHaniKbByComboSql(pstrSysCd))

                For Each dtrDat As DataRow In dstDat.Tables(0).Rows
                    nvcDat.Add(dtrDat("CODE").ToString, dtrDat("CODE_NM").ToString)
                Next

                '汎用コードマスタ情報
                Return nvcDat

            Catch ex As Exception
                Throw ex
            Finally
                If pblnClose Then
                    'DBコネクト開放(例外時にはRollbackを行う)
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
                    '取得パラメータ
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

#Region " FindPicProgress "
        ''' <summary>
        ''' 棚卸実績を検索します。
        ''' </summary>
        ''' <param name="param">棚卸実績パラメータ</param>
        ''' <returns>棚卸実績情報</returns>
        ''' <remarks></remarks>
        ''' <history> 2019/09/07 Created</history>
        Public Function FindPicProgress(ByVal param As PicProgressParam) As DataTable
            Dim dstDat As New DataSet

            Try
                With m_clsDbReader
                    '取得パラメータ
                    .ClearParameter()
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)                   'システムコード
                    .AddParameter("CENTER_CD", SqlType.VarChar, param.CenterCd)             'センターコード
                    .AddParameter("SHIP_DATE", SqlType.VarChar, param.Ship_Date)            '棚卸実施日
                    If Not String.IsNullOrEmpty(param.LocCd) Then
                        .AddParameter("LOC_CD", SqlType.VarChar, param.LocCd)    '納品先BLSコード
                    End If
                    If Not String.IsNullOrEmpty(param.TanaOroshi_Kbn) Then
                        .AddParameter("TANA_KB", SqlType.VarChar, param.TanaOroshi_Kbn)    '棚卸区分
                    End If
                    If Not String.IsNullOrEmpty(param.TanaOroshi_No) Then
                        .AddParameter("TANA_NO", SqlType.VarChar, param.TanaOroshi_No)      '棚卸No
                    End If
                    If Not String.IsNullOrEmpty(param.Status) Then
                        .AddParameter("STATUS", SqlType.VarChar, param.Status)              'ステータス
                    End If
                    If Not String.IsNullOrEmpty(param.Item_Name) Then
                        .AddParameter("BLS_ITEM_NM", SqlType.VarChar, param.Item_Name)      '商品名称
                    End If
                    If Not String.IsNullOrEmpty(param.Item_Code) Then
                        .AddParameter("BLS_ITEM_CD", SqlType.VarChar, param.Item_Code)      '商品BLSコード
                    End If
                    If Not String.IsNullOrEmpty(param.Zone) Then
                        .AddParameter("ZONE", SqlType.VarChar, param.Zone)                  'ゾーン
                    End If
                    If Not String.IsNullOrEmpty(param.WorkUsr_Name) Then
                        .AddParameter("WORK_USER_NM", SqlType.VarChar, param.WorkUsr_Name)  '作業者
                    End If
                    If Not String.IsNullOrEmpty(param.RejectKb) Then
                        .AddParameter("REJECT_KB", SqlType.VarChar, param.RejectKb)         '作業者
                    End If
                    If Not String.IsNullOrEmpty(param.Zaiko) Then
                        .AddParameter("EXP_SPL_QTY", SqlType.VarChar, param.Zaiko)          '在庫ゼロ
                    End If
                End With

                '棚卸実績情報取得SQL実行
                Dim sql As String = CreateFindPicProgressSql(param)
                dstDat = m_clsDbReader.GetTableData(sql)

                '棚卸実績情報
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

#Region " FindStatus "
        ''' <summary>
        ''' 棚卸進捗状況を検索します。
        ''' </summary>
        ''' <param name="param">棚卸進捗検索パラメータ</param>
        ''' <returns>棚卸進捗情報</returns>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/07 Created</history>
        Public Function FindStatus(ByVal param As FindNyukaKb) As String
            Dim dstDat As New DataSet
            Dim pickNyuuka As String

            Try
                With m_clsDbReader
                    '取得パラメータ
                    .ClearParameter()
                    .AddParameter("CODE", SqlType.VarChar, param.Code)
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)           'システムコード
                    .AddParameter("CODE_KEY", SqlType.VarChar, param.Status)

                End With

                'ゾーンマスタ情報取得SQL実行
                dstDat = m_clsDbReader.GetTableData(FindStatusSQL(param))
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

#Region " FindZoneMaster "
        ''' <summary>
        ''' ロケーション（ゾーン）検索用SQL文を生成します。
        ''' </summary>
        ''' <param name="Param">ゾーンコード</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/09/30 Created</history>
        Private Function FindStatusSQL(ByVal Param As FindNyukaKb) As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT DISTINCT")
                    .AppendLine("      CODE_NM")       'コード
                    .AppendLine("    , SYS_CD")    'コード名称
                    .AppendLine("FROM  M_CODE")
                    .AppendLine("WHERE CODE  = :CODE ")      'コードキー
                    .AppendLine("  AND   CODE_KEY  = :CODE_KEY")      'システムコード
                    .AppendLine("  AND   SYS_CD  = :SYS_CD")      'システムコード

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

#Region " FindDiffPicProgress "
        ''' <summary>
        ''' 棚卸差異を検索します。
        ''' </summary>
        ''' <param name="param">棚卸差異パラメータ</param>
        ''' <returns>棚卸差異情報</returns>
        ''' <remarks></remarks>
        ''' <history> 2019/10/31 Created</history>
        Public Function FindDiffPicProgress(ByVal param As PicProgressParam) As DataTable
            Dim dstDat As New DataSet

            Try
                With m_clsDbReader
                    '取得パラメータ
                    .ClearParameter()
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)                   'システムコード
                    .AddParameter("CENTER_CD", SqlType.VarChar, param.CenterCd)             'センターコード
                    .AddParameter("SHIP_DATE", SqlType.VarChar, param.Ship_Date)            '棚卸実施日
                    If Not String.IsNullOrEmpty(param.LocCd) Then
                        .AddParameter("LOC_CD", SqlType.VarChar, param.LocCd)    '納品先BLSコード
                    End If
                    If Not String.IsNullOrEmpty(param.TanaOroshi_Kbn) Then
                        .AddParameter("TANA_KB", SqlType.VarChar, param.TanaOroshi_Kbn)    '棚卸区分
                    End If
                    If Not String.IsNullOrEmpty(param.TanaOroshi_No) Then
                        .AddParameter("TANA_NO", SqlType.VarChar, param.TanaOroshi_No)      '棚卸No
                    End If
                    If Not String.IsNullOrEmpty(param.Status) Then
                        .AddParameter("STATUS", SqlType.VarChar, param.Status)              'ステータス
                    End If
                    If Not String.IsNullOrEmpty(param.Item_Name) Then
                        .AddParameter("BLS_ITEM_NM", SqlType.VarChar, param.Item_Name)      '商品名称
                    End If
                    If Not String.IsNullOrEmpty(param.Item_Code) Then
                        .AddParameter("BLS_ITEM_CD", SqlType.VarChar, param.Item_Code)      '商品BLSコード
                    End If
                    If Not String.IsNullOrEmpty(param.Zone) Then
                        .AddParameter("ZONE", SqlType.VarChar, param.Zone)                  'ゾーン
                    End If
                    If Not String.IsNullOrEmpty(param.WorkUsr_Name) Then
                        .AddParameter("WORK_USER_NM", SqlType.VarChar, param.WorkUsr_Name)  '作業者
                    End If
                    If Not String.IsNullOrEmpty(param.RejectKb) Then
                        .AddParameter("REJECT_KB", SqlType.VarChar, param.RejectKb)         '作業者
                    End If
                    If Not String.IsNullOrEmpty(param.Zaiko) Then
                        .AddParameter("EXP_SPL_QTY", SqlType.VarChar, param.Zaiko)          '在庫ゼロ
                    End If
                End With

                '棚卸差異情報取得SQL実行
                Dim sql As String = CreateDiffSearch(param)
                dstDat = m_clsDbReader.GetTableData(sql)

                '棚卸差異情報
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

#Region " FindDiffPicProgressCSV "
        ''' <summary>
        ''' 棚卸差異を検索します。
        ''' </summary>
        ''' <param name="param">棚卸差異パラメータ</param>
        ''' <returns>棚卸差異情報</returns>
        ''' <remarks></remarks>
        ''' <history> 2019/10/31 Created</history>
        Public Function FindDiffPicProgressCSV(ByVal param As PicProgressParam) As DataTable
            Dim dstDat As New DataSet

            Try
                With m_clsDbReader
                    '取得パラメータ
                    .ClearParameter()
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)                   'システムコード
                    .AddParameter("CENTER_CD", SqlType.VarChar, param.CenterCd)             'センターコード
                    .AddParameter("SHIP_DATE", SqlType.VarChar, param.Ship_Date)            '棚卸実施日
                    If Not String.IsNullOrEmpty(param.LocCd) Then
                        .AddParameter("LOC_CD", SqlType.VarChar, param.LocCd)    '納品先BLSコード
                    End If
                    If Not String.IsNullOrEmpty(param.TanaOroshi_Kbn) Then
                        .AddParameter("TANA_KB", SqlType.VarChar, param.TanaOroshi_Kbn)    '棚卸区分
                    End If
                    If Not String.IsNullOrEmpty(param.TanaOroshi_No) Then
                        .AddParameter("TANA_NO", SqlType.VarChar, param.TanaOroshi_No)      '棚卸No
                    End If
                    If Not String.IsNullOrEmpty(param.Status) Then
                        .AddParameter("STATUS", SqlType.VarChar, param.Status)              'ステータス
                    End If
                    If Not String.IsNullOrEmpty(param.Item_Name) Then
                        .AddParameter("BLS_ITEM_NM", SqlType.VarChar, param.Item_Name)      '商品名称
                    End If
                    If Not String.IsNullOrEmpty(param.Item_Code) Then
                        .AddParameter("BLS_ITEM_CD", SqlType.VarChar, param.Item_Code)      '商品BLSコード
                    End If
                    If Not String.IsNullOrEmpty(param.Zone) Then
                        .AddParameter("ZONE", SqlType.VarChar, param.Zone)                  'ゾーン
                    End If
                    If Not String.IsNullOrEmpty(param.WorkUsr_Name) Then
                        .AddParameter("WORK_USER_NM", SqlType.VarChar, param.WorkUsr_Name)  '作業者
                    End If
                    If Not String.IsNullOrEmpty(param.RejectKb) Then
                        .AddParameter("REJECT_KB", SqlType.VarChar, param.RejectKb)         '作業者
                    End If
                    If Not String.IsNullOrEmpty(param.Zaiko) Then
                        .AddParameter("EXP_SPL_QTY", SqlType.VarChar, param.Zaiko)          '在庫ゼロ
                    End If
                End With

                '棚卸差異情報取得SQL実行
                Dim sql As String = CreateDiffSearchCSV(param)
                dstDat = m_clsDbReader.GetTableData(sql)

                '棚卸差異情報
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


#Region " DiffSearch "
        ''' <summary>
        ''' for 差異。get data from DB
        ''' </summary>
        ''' <remarks>get 差異data from DB</remarks>
        ''' <history>Arche Info. 2019/10/23 Created</history>
        Private Function CreateDiffSearch(ByVal pParam As PicProgressParam) As String


            Dim strSql As New StringBuilder
            Try
                With strSql
                    .AppendLine("SELECT ")
                    '  .AppendLine("   M1.PICK_ZONE ")
                    .AppendLine("   NVL(M1.PICK_ZONE, ' ') As PICK_ZONE ")
                    .AppendLine("   ,A.WORK_STS")
                    .AppendLine("   ,A.INV_KB")
                    .AppendLine("  , A.SYS_CD ")
                    .AppendLine("  , A.LOC_CD ")
                    .AppendLine("  , A.BLS_ITEM_CD ")   ' 商品
                    .AppendLine("  , A.BLS_ITEM_NM ")
                    .AppendLine("  , A.ITEM_MNG_DATE")
                    .AppendLine("  , NVL(A.EXP_CS_QTY, 0)  AS EXP_CS_QTY  ")
                    .AppendLine("  , NVL(A.EXP_PL_QTY, 0)  AS EXP_PL_QTY ")
                    .AppendLine("  , NVL(A.EXP_SPL_QTY, 0) AS EXP_SPL_QTY  ")
                    .AppendLine("  , NVL(A.R_S_ACT_CS_QTY, 0)  AS R_S_ACT_CS_QTY  ")
                    .AppendLine("  , NVL(A.R_S_ACT_PS_QTY, 0)  AS R_S_ACT_PS_QTY ")
                    .AppendLine("  , NVL(A.R_S_ACT_SPS_QTY, 0) AS R_S_ACT_SPS_QTY  ")

                    .AppendLine("  , ( NVL(A.R_S_ACT_CS_QTY, 0)- NVL(A.EXP_CS_QTY,0) ) AS DIF_CS_QTY  ")
                    .AppendLine("  , ( NVL(A.R_S_ACT_PS_QTY, 0) - NVL(A.EXP_PL_QTY,0)   ) AS DIF_PL_QTY  ")
                    .AppendLine("  , (NVL(A.R_S_ACT_SPS_QTY, 0) -NVL(A.EXP_SPL_QTY,0)  ) AS DIF_SPL_QTY ")
                    .AppendLine("  , A.REJECT_KB")     ' 不良品区分
                    .AppendLine("  , A.INV_NO")
                    .AppendLine("  , A.VENDOR_CD")
                    .AppendLine("  , A.VENDOR_NM")
                    .AppendLine("  , A.R_ITEM_MNG_DATE")
                    .AppendLine("  , A.CENTER_CD")
                    .AppendLine("  , A.CENTER_NM")
                    .AppendLine("  , A.FILE_ID")
                    .AppendLine("  , A.FILE_LINE_NO")
                    .AppendLine("  , A.SUM_DIF_CS_QTY")
                    .AppendLine("  , A.SUM_DIF_PL_QTY")
                    .AppendLine("  , A.SUM_DIF_SPL_QTY")
                    .AppendLine("  , A.MNG_DT_CNT")
                    .AppendLine("  , A.CS_CARTON")
                    .AppendLine("  , A.JAN_CD")
                    .AppendLine("  , A.CS_JAN_CD")
                    .AppendLine("  , A.ITF_CD")

                    .AppendLine("FROM V_INVENTORY A ")
                    .AppendLine("LEFT JOIN M_ZONE M1 ")
                    .AppendLine("   ON  M1.SYS_CD = A.SYS_CD ")
                    .AppendLine("      AND M1.LOC_CD = A.LOC_CD ")

                    .AppendLine("WHERE ")
                    .AppendLine(CreateFindPicProgressSqlSubWhere(pParam))
                    If Not String.IsNullOrEmpty(pParam.WorkUsr_Name) Then
                        .AppendLine("   AND A.WORK_USER_NM LIKE '%' || :WORK_USER_NM || '%'")   '作業者
                    End If
                   
                    If Not String.IsNullOrEmpty(pParam.chkDiff) Then
                        .AppendLine("   AND  NOT (A.SUM_DIF_CS_QTY=0 AND  A.SUM_DIF_PL_QTY=0 AND A.SUM_DIF_SPL_QTY=0  AND A.MNG_DT_CNT=0)")
                    End If
                    .AppendLine("ORDER BY")
                    .AppendLine("A.SYS_CD , A.CENTER_CD , A.WORK_DATE , A.INV_KB , PICK_ZONE, A.LOC_CD, A.BLS_ITEM_CD, A.REJECT_KB, A.ITEM_MNG_DATE,A.R_ITEM_MNG_DATE")
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

#Region " CreateDiffSearchCSV "
        ''' <summary>
        ''' for 差異。get data from DB
        ''' </summary>
        ''' <remarks>get 差異data from DB</remarks>
        ''' <history>Arche Info. 2019/10/23 Created</history>
        Private Function CreateDiffSearchCSV(ByVal pParam As PicProgressParam) As String


            Dim strSql As New StringBuilder
            Try
                With strSql
                    .AppendLine("SELECT ")
                    .AppendLine("    A.WORK_STS")
                    .AppendLine("  ,M1.PICK_ZONE")
                    .AppendLine("  , A.LOC_CD ")
                    .AppendLine("  , A.BLS_ITEM_CD ")   ' 商品
                    .AppendLine("  , A.BLS_ITEM_NM ")
                    .AppendLine("  , A.ITEM_MNG_DATE")
                    .AppendLine("   ,A.CS_CARTON")
                    .AppendLine("  , NVL(A.EXP_CS_QTY, 0)  AS EXP_CS_QTY  ")
                    .AppendLine("  , NVL(A.EXP_PL_QTY, 0)  AS EXP_PL_QTY ")
                    .AppendLine("  , NVL(A.EXP_SPL_QTY, 0) AS EXP_SPL_QTY  ")
                    .AppendLine("  , A.R_ITEM_MNG_DATE")
                    .AppendLine("  , NVL(A.R_S_ACT_CS_QTY, 0)  AS R_S_ACT_CS_QTY  ")
                    .AppendLine("  , NVL(A.R_S_ACT_PS_QTY, 0)  AS R_S_ACT_PS_QTY ")
                    .AppendLine("  , NVL(A.R_S_ACT_SPS_QTY, 0) AS R_S_ACT_SPS_QTY  ")
                    .AppendLine("  , ( NVL(A.R_S_ACT_CS_QTY, 0)- NVL(A.EXP_CS_QTY,0) ) AS DIF_CS_QTY  ")
                    .AppendLine("  , ( NVL(A.R_S_ACT_PS_QTY, 0) - NVL(A.EXP_PL_QTY,0)   ) AS DIF_PL_QTY  ")
                    .AppendLine("  , (NVL(A.R_S_ACT_SPS_QTY, 0) -NVL(A.EXP_SPL_QTY,0)  ) AS DIF_SPL_QTY ")
                    .AppendLine("  , A.REJECT_KB")     ' 不良品区分
                    .AppendLine("  , A.INV_NO")
                    .AppendLine("   ,A.JAN_CD")
                    .AppendLine("   ,A.CS_JAN_CD")
                    .AppendLine("   ,A.ITF_CD")
                    .AppendLine("   ,A.FILE_ID")
                    .AppendLine("   ,A.FILE_LINE_NO")
                    .AppendLine("  , A.MNG_DT_CNT")
                    .AppendLine("FROM V_INVENTORY A ")
                    .AppendLine("LEFT JOIN M_ZONE M1 ")
                    .AppendLine("   ON  M1.SYS_CD = A.SYS_CD ")
                    .AppendLine("      AND M1.LOC_CD = A.LOC_CD ")
                    .AppendLine("WHERE ")
                    .AppendLine(CreateFindPicProgressSqlSubWhere(pParam))
                    If Not String.IsNullOrEmpty(pParam.WorkUsr_Name) Then
                        .AppendLine("   AND A.WORK_USER_NM LIKE '%' || :WORK_USER_NM || '%'")   '作業者
                    End If
                    If Not String.IsNullOrEmpty(pParam.chkDiff) Then
                        .AppendLine("   AND  NOT (A.SUM_DIF_CS_QTY=0 AND  A.SUM_DIF_PL_QTY=0 AND A.SUM_DIF_SPL_QTY=0  AND A.MNG_DT_CNT=0)")
                    End If
                    .AppendLine("ORDER BY")
                    .AppendLine("A.SYS_CD , A.CENTER_CD , A.WORK_DATE , A.INV_KB , M1.PICK_ZONE, A.LOC_CD, A.BLS_ITEM_CD, A.REJECT_KB, A.ITEM_MNG_DATE,A.R_ITEM_MNG_DATE")
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



#Region " Private "


#Region " CreateFindCodeByComboSql "
        ''' <summary>
        ''' 汎用コードマスタ情報(コンボボッスク)検索用SQL文を生成します。
        ''' </summary>
        ''' <param name="pstrSysCd">システムコード</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/09/30 Created</history>
        Private Function CreateFindHaniKbByComboSql(Optional ByVal pstrSysCd As String = "") As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT DISTINCT")
                    .AppendLine("      CODE")       'コード
                    .AppendLine("    , CODE_NM")    'コード名称
                    .AppendLine("FROM  M_CODE")
                    .AppendLine("WHERE CODE_KEY  = :CODE_KEY ")      'コードキー
                    .AppendLine("  AND   CODE     <> :CODE")          'コード
                    '.AppendLine("  AND   CODE     <>  'HEADER'")
                    If Not pstrSysCd.Equals(String.Empty) Then
                        .AppendLine("  AND   SYS_CD  = :SYS_CD")      'システムコード
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


#Region " CreateFindPicProgressSql "
        ''' <summary>
        ''' 棚卸実績照会用SQL文を生成します。
        ''' </summary>
        ''' <param name="pParam">検索条件</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history> 2019/09/07 Created</history>
        Private Function CreateFindPicProgressSql(ByVal pParam As PicProgressParam) As String
            Dim strSql As String = Nothing

            Try
                Dim x As Integer
                '-- switch by WORK STATUS
                x = ComLib.ToIntEx(pParam.Status)
                Select Case x
                    Case 0
                        strSql = CreateFindPicProgressSqlSubSt0(pParam)

                    Case 1
                        strSql = CreateFindPicProgressSqlSubSt1(pParam)

                    Case Else
                        strSql = CreateFindPicProgressSqlSubSt0(pParam)
                        'strSql = CreateFindPicProgressSqlSubGeneral(pParam)
                End Select

                Return strSql

            Catch ex As Exception
                Throw ex

            Finally
                strSql = Nothing

            End Try
        End Function

        '---- where XXXX
        Private Function CreateFindPicProgressSqlSubWhere(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder

            Try
                'SQL発行
                With strSql
                    .AppendLine("           A.SYS_CD		=	:SYS_CD		")
                    .AppendLine("       AND A.CENTER_CD     =   :CENTER_CD")
                    .AppendLine("       AND	A.WORK_DATE		=	:SHIP_DATE	")
                    .AppendLine("       AND	A.WORK_STS		<>	9	")

                    If Not String.IsNullOrEmpty(pParam.TanaOroshi_Kbn) Then                 '棚卸区分
                        .AppendLine("   AND A.INV_KB = :TANA_KB")
                    End If
                    If Not String.IsNullOrEmpty(pParam.TanaOroshi_No) Then                  '棚卸No
                        .AppendLine("   AND A.INV_NO LIKE :TANA_NO || '%'")
                    End If
                    If Not String.IsNullOrEmpty(pParam.LocCd) Then                    'ロケーション
                        .AppendLine("   AND A.LOC_CD LIKE :LOC_CD || '%'")
                    End If
                    If Not String.IsNullOrEmpty(pParam.Status) Then
                        .AppendLine("   AND A.WORK_STS	=	:STATUS	")                      'ステータス
                    End If
                    If Not String.IsNullOrEmpty(pParam.Item_Name) Then
                        .AppendLine("   AND A.BLS_ITEM_NM LIKE '%' || :BLS_ITEM_NM || '%'") '商品名称
                    End If
                    If Not String.IsNullOrEmpty(pParam.Item_Code) Then
                        .AppendLine("   AND A.BLS_ITEM_CD LIKE :BLS_ITEM_CD || '%'")        '商品BLSコード
                    End If
                    If Not String.IsNullOrEmpty(pParam.Zone) Then                           'ゾーン
                        .AppendLine("   AND M1.PICK_ZONE = :ZONE")
                    End If

                    If Not String.IsNullOrEmpty(pParam.RejectKb) Then                       '不良品区分
                        .AppendLine("   AND TRIM(A.REJECT_KB) IS NOT NULL") '不良品を出す
                        ' oracle "IS NULL" match ""(empty string). TRIM() change " " to ""
                        ' REJECT_KB: (NULL, "", " ") == 良品。otherwise 不良品
                    End If

                    If Not String.IsNullOrEmpty(pParam.Zaiko) Then
                        If pParam.Zaiko = 0 Then
                            .AppendLine("   AND A.EXP_SPL_QTY = :EXP_SPL_QTY")               '在庫ゼロ
                        End If
                        If pParam.Zaiko = 1 Then
                            .AppendLine("   AND A.EXP_SPL_QTY <> 0 AND 1 = :EXP_SPL_QTY")  '在庫ゼロ
                        End If
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

        '---- when work status == 0
        Private Function CreateFindPicProgressSqlSubSt0(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder
            Try
                With strSql
                    .AppendLine("SELECT")
                    .AppendLine("  A.WORK_DATE")

                    .AppendLine(", A.WORK_STS")
                    .AppendLine(", M1.PICK_ZONE")
                    .AppendLine(", A.LOC_CD")
                    .AppendLine(", A.BLS_ITEM_CD")
                    .AppendLine(", A.BLS_ITEM_NM")
                    .AppendLine(", A.ITEM_MNG_DATE")

                    .AppendLine(", A.CS_CARTON")
                    .AppendLine(", A.EXP_CS_QTY")
                    .AppendLine(", A.EXP_PL_QTY")
                    .AppendLine(", A.EXP_SPL_QTY")

                    .AppendLine(", '' AS RES_ITEM_MNG_DATE")

                    .AppendLine(", NULL AS ACT_CS_QTY")
                    .AppendLine(", NULL AS ACT_PS_QTY")
                    .AppendLine(", NULL AS ACT_SPS_QTY")

                    .AppendLine(", NULL AS DIF_CS_QTY")
                    .AppendLine(", NULL AS DIF_PL_QTY")
                    .AppendLine(", NULL AS DIF_SPL_QTY")

                    .AppendLine(", A.REJECT_KB")
                    .AppendLine(", A.INV_KB")
                    .AppendLine(", A.INV_NO")
                    .AppendLine(", A.JAN_CD")
                    .AppendLine(", A.CS_JAN_CD	")
                    .AppendLine(", A.ITF_CD")

                    '.AppendLine(", NULL AS BRANCH_NO")
                    '.AppendLine(", NULL AS WORK_USER_NM")

                    .AppendLine("FROM       T_INVINST  A ")

                    .AppendLine("LEFT JOIN  M_ZONE     M1")
                    .AppendLine("  ON  M1.SYS_CD = A.SYS_CD  AND  M1.LOC_CD = A.LOC_CD")


                    .AppendLine("WHERE")
                    .AppendLine(CreateFindPicProgressSqlSubWhere(pParam))
                    If Not String.IsNullOrEmpty(pParam.WorkUsr_Name) Then
                        '.AppendLine("   AND B.WORK_USER_NM LIKE '%' || :WORK_USER_NM || '%'")
                        '作業者
                        .AppendLine("   AND (A.FILE_ID, A.FILE_LINE_NO) IN (")
                        .AppendLine("           SELECT FILE_ID, FILE_LINE_NO")
                        .AppendLine("           FROM T_INVRES ")
                        .AppendLine("           WHERE WORK_USER_NM LIKE '%' || :WORK_USER_NM  || '%'")
                        .AppendLine("             AND SYS_CD = :SYS_CD")
                        .AppendLine("             AND CENTER_CD = :CENTER_CD")
                        .AppendLine("             AND WORK_DATE = :SHIP_DATE")
                        .AppendLine("           )")

                    End If

                    .AppendLine("ORDER BY")
                    .AppendLine(" A.SYS_CD , A.CENTER_CD , A.WORK_DATE , A.INV_KB , M1.PICK_ZONE, A.LOC_CD, A.BLS_ITEM_CD, A.REJECT_KB, A.ITEM_MNG_DATE")
                End With

                Return strSql.ToString

            Catch ex As Exception
                Throw ex

            Finally
                '解放
                strSql = Nothing
            End Try
        End Function

        '---- when work status == 1
        Private Function CreateFindPicProgressSqlSubSt1(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder
            Try
                With strSql
                    .AppendLine("SELECT * from (")
                    .AppendLine("SELECT ")
                    .AppendLine("    A.SYS_CD, A.CENTER_CD ")
                    .AppendLine("  , A.FILE_ID ")
                    .AppendLine("  , A.FILE_LINE_NO ")
                    .AppendLine("  , A.WORK_DATE ")     ' 作業日

                    .AppendLine("  , A.WORK_STS ")
                    .AppendLine("  , M1.PICK_ZONE")
                    .AppendLine("  , A.LOC_CD ")
                    .AppendLine("  , A.BLS_ITEM_CD ")   ' 商品
                    .AppendLine("  , A.BLS_ITEM_NM ")
                    .AppendLine("  , A.ITEM_MNG_DATE")

                    .AppendLine("  , A.CS_CARTON")
                    .AppendLine("  , MAX(NVL(A.EXP_CS_QTY, 0))  AS EXP_CS_QTY ")
                    .AppendLine("  , MAX(NVL(A.EXP_PL_QTY, 0))  AS EXP_PL_QTY ")
                    .AppendLine("  , MAX(NVL(A.EXP_SPL_QTY, 0)) AS EXP_SPL_QTY ")

                    .AppendLine("  , B.ITEM_MNG_DATE AS RES_ITEM_MNG_DATE")

                    .AppendLine("  , SUM(B.ACT_CS_QTY)  AS ACT_CS_QTY ")
                    .AppendLine("  , SUM(B.ACT_PS_QTY)  AS ACT_PS_QTY ")
                    .AppendLine("  , SUM(B.ACT_SPS_QTY) AS ACT_SPS_QTY ")

                    .AppendLine("  , ( MAX(NVL(A.EXP_CS_QTY,0)) - SUM(NVL(B.ACT_CS_QTY,0)) ) AS DIF_CS_QTY ")
                    .AppendLine("  , ( MAX(NVL(A.EXP_PL_QTY,0)) - SUM(NVL(B.ACT_PS_QTY,0)) ) AS DIF_PL_QTY ")
                    .AppendLine("  , ( MAX(NVL(A.EXP_SPL_QTY,0)) - SUM(NVL(B.ACT_SPS_QTY,0)) ) AS DIF_SPL_QTY ")


                    .AppendLine("  , A.REJECT_KB")     ' 不良品区分
                    .AppendLine("  , A.INV_KB")        ' 棚卸し区分
                    .AppendLine("  , A.INV_NO")
                    .AppendLine("  , A.JAN_CD")
                    .AppendLine("  , A.CS_JAN_CD")
                    .AppendLine("  , A.ITF_CD")

                    .AppendLine("FROM T_INVINST A ")

                    .AppendLine("INNER JOIN M_ZONE M1 ")
                    .AppendLine("   ON  M1.SYS_CD = A.SYS_CD ")
                    .AppendLine("      AND M1.LOC_CD = A.LOC_CD ")

                    .AppendLine("LEFT JOIN T_INVRES B ")
                    .AppendLine("   ON  A.SYS_CD = B.SYS_CD ")
                    .AppendLine("       AND A.CENTER_CD    = B.CENTER_CD ")
                    .AppendLine("       AND A.WORK_DATE    = B.WORK_DATE ")
                    .AppendLine("       AND A.INV_KB       = B.INV_KB ")
                    .AppendLine("       AND A.BLS_ITEM_CD  = B.BLS_ITEM_CD ")
                    .AppendLine("       AND A.REJECT_KB    = B.REJECT_KB ")
                    .AppendLine("       AND A.FILE_ID      = B.FILE_ID ")
                    .AppendLine("       AND A.FILE_LINE_NO = B.FILE_LINE_NO ")

                    .AppendLine("WHERE ")
                    .AppendLine(CreateFindPicProgressSqlSubWhere(pParam))
                    If Not String.IsNullOrEmpty(pParam.WorkUsr_Name) Then
                        .AppendLine("   AND B.WORK_USER_NM LIKE '%' || :WORK_USER_NM || '%'") '作業者
                    End If

                    .AppendLine("GROUP BY ")
                    .AppendLine("    A.SYS_CD, A.CENTER_CD ")
                    .AppendLine("  , A.WORK_DATE ")     ' 作業日
                    .AppendLine("  , A.INV_KB  ")       ' 棚卸し区分
                    .AppendLine("  , A.BLS_ITEM_CD ")   ' 商品
                    .AppendLine("  , A.REJECT_KB ")     ' 不良品区分
                    .AppendLine("  , A.FILE_ID ")
                    .AppendLine("  , A.FILE_LINE_NO ")
                    .AppendLine("  , A.WORK_STS ")
                    .AppendLine("  , A.INV_NO ")
                    .AppendLine("  , A.LOC_CD ")
                    .AppendLine("  , A.ITEM_MNG_DATE")
                    .AppendLine("  , B.ITEM_MNG_DATE")
                    .AppendLine("  , A.ITF_CD")
                    .AppendLine("  , A.BLS_ITEM_NM ")
                    .AppendLine("  , A.CS_CARTON")
                    .AppendLine("  , M1.PICK_ZONE")
                    .AppendLine("  , A.JAN_CD")
                    .AppendLine("  , A.CS_JAN_CD	")
                    '.AppendLine("  , A.EXP_CS_QT ")
                    '.AppendLine("  , A.EXP_PL_QTY ")
                    '.AppendLine("  , A.EXP_SPL_QTY ")

                    .AppendLine("ORDER BY")
                    .AppendLine("  A.SYS_CD , A.CENTER_CD ")
                    .AppendLine("  , A.WORK_DATE ")
                    .AppendLine("  , A.INV_KB ")
                    .AppendLine("  , M1.PICK_ZONE")
                    .AppendLine("  , A.LOC_CD ")
                    .AppendLine("  , A.BLS_ITEM_CD ")
                    .AppendLine("  , A.REJECT_KB ")
                    .AppendLine("  , A.ITEM_MNG_DATE ")
                    .AppendLine("  , B.ITEM_MNG_DATE ")
                    .AppendLine(")")
                   
                End With
                Return strSql.ToString

            Catch ex As Exception
                Throw ex

            Finally
                '解放
                strSql = Nothing
            End Try
        End Function

        '---- old way
        Private Function CreateFindPicProgressSqlSubGeneral(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder

            Try
                'SQL発行
                With strSql
                    .AppendLine("SELECT")
                    .AppendLine(" A.WORK_STS,   A.WORK_DATE,    A.INV_KB,       A.INV_NO,       A.LOC_CD")
                    .AppendLine(", A.ITF_CD,    A.BLS_ITEM_CD,	A.BLS_ITEM_NM,  A.CS_CARTON,    A.EXP_CS_QTY")
                    .AppendLine(", A.EXP_PL_QTY, A.EXP_SPL_QTY")
                    .AppendLine(", B.ACT_CS_QTY, B.ACT_PS_QTY, B.ACT_SPS_QTY")
                    .AppendLine(", M1.PICK_ZONE")
                    '.AppendLine(", B.BRANCH_NO, B.WORK_USER_NM")
                    .AppendLine(", (NVL(A.EXP_CS_QTY, 0) - NVL(B.ACT_CS_QTY, 0)) AS DIF_CS_QTY")
                    .AppendLine(", (NVL(A.EXP_PL_QTY, 0) - NVL(B.ACT_PS_QTY, 0)) AS DIF_PL_QTY")
                    .AppendLine(", (NVL(A.EXP_SPL_QTY, 0) - NVL(B.ACT_SPS_QTY, 0)) AS DIF_SPL_QTY")
                    .AppendLine(", A.ITEM_MNG_DATE , A.REJECT_KB, A.JAN_CD, A.CS_JAN_CD	")
                    .AppendLine("FROM T_INVINST  A ")

                    .AppendLine("LEFT JOIN M_ZONE M1")
                    .AppendLine("  ON	A.SYS_CD = M1.SYS_CD AND A.LOC_CD = M1.LOC_CD	")

                    .AppendLine("LEFT JOIN ")
                    .AppendLine("(")
                    .AppendLine("       SELECT")
                    .AppendLine("           SYS_CD, CENTER_CD,	WORK_DATE, INV_KB , BLS_ITEM_CD")
                    .AppendLine("           , LOC_CD, ITEM_MNG_DATE,	REJECT_KB")
                    '.AppendLine("           ,	BRANCH_NO, WORK_USER_NM")
                    .AppendLine("           , SUM(ACT_CS_QTY)  AS ACT_CS_QTY")
                    .AppendLine("           , SUM(ACT_PS_QTY)  AS ACT_PS_QTY")
                    .AppendLine("           , SUM(ACT_SPS_QTY) AS ACT_SPS_QTY")
                    .AppendLine("       FROM")
                    .AppendLine("           T_INVRES	")
                    .AppendLine("       WHERE")
                    .AppendLine("               SYS_CD      =	:SYS_CD	")
                    .AppendLine("           AND	WORK_DATE	=	:SHIP_DATE	")
                    .AppendLine("         AND	CENTER_CD	=   :CENTER_CD	")
                    .AppendLine("       GROUP BY")
                    .AppendLine("           SYS_CD,	CENTER_CD, WORK_DATE, INV_KB, BLS_ITEM_CD")
                    .AppendLine("           , LOC_CD, ITEM_MNG_DATE, REJECT_KB")
                    '.AppendLine("           , WORK_USER_NM, BRANCH_NO	")
                    .AppendLine(") B ")
                    .AppendLine("ON     A.SYS_CD		=	B.SYS_CD	")
                    .AppendLine("   AND	A.CENTER_CD		=	B.CENTER_CD	")
                    .AppendLine("   AND	A.BLS_ITEM_CD	=       B.BLS_ITEM_CD	")
                    .AppendLine("   AND	A.ITEM_MNG_DATE		=	B.ITEM_MNG_DATE	")
                    ' .AppendLine("	AND	A.WORK_DATE		=	B.WORK_DATE	")
                    ' .AppendLine("	AND	A.INV_KB		=	B.INV_KB")
                    ' .AppendLine(" AND	A.INV_NO		=	B.INV_NO	")
                    ' .AppendLine(" AND	A.LOC_CD		=	B.LOC_CD	")
                    ' .AppendLine(" AND	A.REJECT_KB		=	B.REJECT_KB	")

                    .AppendLine("WHERE")
                    .AppendLine(CreateFindPicProgressSqlSubWhere(pParam))
                    If Not String.IsNullOrEmpty(pParam.WorkUsr_Name) Then
                        .AppendLine("   AND B.WORK_USER_NM LIKE '%' || :WORK_USER_NM || '%'") '作業者
                    End If

                    .AppendLine("ORDER BY")
                    .AppendLine(" M1.PICK_ZONE, A.LOC_CD, A.BLS_ITEM_CD, A.REJECT_KB")
                    '.AppendLine(" , A.ITEM_MNG_DATE, B.BRANCH_NO")

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
        ''' <param name="Param">ゾーンコード</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche 2019/09/30 Created</history>
        Private Function FindZoneMaster(ByVal Param As FindZoneCode) As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT DISTINCT")
                    .AppendLine("      PICK_ZONE")       'コード
                    .AppendLine("    , LOC_CD")    'コード名称
                    .AppendLine("    , SYS_CD")    'コード名称
                    .AppendLine("FROM  M_ZONE")
                    .AppendLine("WHERE LOC_CD  = :LOC_CD ")      'コードキー
                    .AppendLine("  AND   SYS_CD  = :SYS_CD")      'システムコード



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
