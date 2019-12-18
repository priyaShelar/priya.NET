'----------------------------------------------------------------------------------------------
'  機能名　　　　    : DBAccessクラス
'  機能説明　　　    : DBへ初期コンタクトする機能を提供します。
'  備考　　　　　    : なし
'  作成日　　　　    : 2019/10/23
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
    ''' <remarks>DB操作する機能を提供します。</remarks>
    ''' <history> 2019/09/05 Created</history>
    Public Class AccVSMSS110
        Inherits ComAccBase

#Region " 変数 "
        ''' <summary>
        ''' 入荷検索条件
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
            ''' status
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

        ''' <summary>
        ''' 入荷検索条件
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history> 2019/09/07 Created</history>
        Public Class PicProgressParam
            Private strSysCd As String = String.Empty
            Private strCenterCd As String = String.Empty
            Private strShipDate As String = String.Empty
            Private strBlsItemCd As String = String.Empty
            Private strBlsItemNm As String = String.Empty
            Private strBlsDeliCd As String = String.Empty
            Private strBlsDeliNm As String = String.Empty
            Private strVendorCd As String = String.Empty
            Private strVendorNm As String = String.Empty
            Private strNyukayoteiNo As String = String.Empty
            Private strStatus As String = String.Empty
            Private strInKb As String = String.Empty
            Private strLocation As String = String.Empty
            Private strVenCd As String = String.Empty
            Private strVenNm As String = String.Empty
            Private strRejKb As String = String.Empty
            Private strWrkUsrNm As String = String.Empty
            Private strWarning As String = String.Empty
            Private strFileId As String = String.Empty
            Private strFileLineNo As String = String.Empty


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
            ''' 入荷予定NO
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property NyuYotNo() As String
                Get
                    Return strNyukayoteiNo
                End Get
                Set(ByVal value As String)
                    strNyukayoteiNo = value
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
            ''' 入荷予定日
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
            ''' BLS商品コード
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Bls_Item_Cd() As String
                Get
                    Return strBlsItemCd
                End Get
                Set(ByVal value As String)
                    strBlsItemCd = value
                End Set
            End Property

            ''' <summary>
            ''' BLS商品名
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Bls_Item_Nm() As String
                Get
                    Return strBlsItemNm
                End Get
                Set(ByVal value As String)
                    strBlsItemNm = value
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
            ''' 入荷区分
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Nyuka_Kb() As String
                Get
                    Return strInKb
                End Get
                Set(ByVal value As String)
                    strInKb = value
                End Set
            End Property

            ''' <summary>
            ''' Location名
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Location() As String
                Get
                    Return strLocation
                End Get
                Set(ByVal value As String)
                    strLocation = value
                End Set
            End Property

            ''' <summary>
            ''' 発送地 vendor code
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property VendorCd() As String
                Get
                    Return strVenCd
                End Get
                Set(ByVal value As String)
                    strVenCd = value
                End Set
            End Property

            ''' <summary>
            ''' 発送地 vendor 名
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property VendorNm() As String
                Get
                    Return strVenNm
                End Get
                Set(ByVal value As String)
                    strVenNm = value
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
            ''' 作業者名
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property WrkUserNm() As String
                Get
                    Return strWrkUsrNm
                End Get
                Set(ByVal value As String)
                    strWrkUsrNm = value
                End Set
            End Property

            ''' <summary>
            ''' ワーニング
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property Warning() As String
                Get
                    Return strWarning
                End Get
                Set(ByVal value As String)
                    strWarning = value
                End Set
            End Property

            ''' <summary>
            ''' File_ID
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property FileId() As String
                Get
                    Return strFileId
                End Get
                Set(ByVal value As String)
                    strFileId = value
                End Set
            End Property

            ''' <summary>
            ''' File_Line_No
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Property FileLineNo() As String
                Get
                    Return strFileLineNo
                End Get
                Set(ByVal value As String)
                    strFileLineNo = value
                End Set
            End Property

        End Class


        ''' <summary>入荷情報</summary>
        Public g_srtPicres As T_Picres
#End Region

#Region " 構造体 "

#Region " T_Picres "
        ''' <summary>
        ''' 入荷実績情報構造体
        ''' </summary>
        ''' <remarks></remarks>
        ''' <history>S.Toshino 2018/09/04 Created</history>
        Public Structure T_Picres
#Region "   変数 "
            ''' <summary>GAEA区分コード</summary>
            Private strSysCd As String

            ''' <summary>センターコード</summary>
            Private strCenterCd As String

            ''' <summary>入荷予定日</summary>
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

            ''' <summary>入荷区分</summary>
            Private strArrivalKb As String

            ''' <summary>作業者名称</summary>
            Private strWorkUserNm As String

            ''' <summary>最終更新日時</summary>
            Private strPreUpdYb As String

            ''' <summary>更新日時(現在日付)</summary>
            Private strUpdYbNow As String

            ''' <summary>行数</summary>
            Private intRow As Integer

            ''' <summary>発送地コード</summary>
            Private strVendorCd As String

            ''' <summary>発送地名称</summary>
            Private strVendorNm As String

            '
            Private strRejectKbn As String

            '入荷予定No.
            Private strInplanNo As String

            ''' <summary>在庫最新管理日</summary>
            Private strWarMngDate As String

            '
            Private strFILE_ID As String
            Private strFILE_LINE_NO As String

            '入数
            Private intCsCarton As Decimal

            '予定数ケース
            Private intExpCsQty As Decimal

            '予定数バラ
            Private intExpPsQty As Decimal

            '予定数総
            Private intExpSpsQty As Decimal

            '実績数ケース
            Private intActCsQty As Decimal

            '実績数バラ
            Private intActPsQty As Decimal

            '実績数総
            Private intActSpsQty As Decimal
#End Region

#Region "   プロパティ "

#Region "     Sys_Cd "
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

#Region "     Center_Cd "
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

#Region "     Ship_Date "
            ''' <summary>
            ''' 入荷予定日を取得・設定します。
            ''' </summary>
            ''' <value>入荷予定日</value>
            ''' <returns>入荷予定日</returns>
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

#Region "     Bls_Deli_Cd "
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

#Region "     Bls_Deli_Nm "
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

#Region "     Bls_Item_Cd "
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

#Region "     Bls_Item_Nm "
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

#Region "     Vendor_Cd "
            ''' <summary>
            ''' 発送地コードを取得・設定します。
            ''' </summary>
            ''' <value>発送地コード</value>
            ''' <returns>発送地コード</returns>
            ''' <remarks></remarks>
            ''' <history> 2019/09/04 Created</history>
            Public Property Vendor_Cd() As String
                Get
                    Return strVendorCd
                End Get
                Set(ByVal value As String)
                    strVendorCd = value
                End Set
            End Property
#End Region

#Region "     Vendor_Nm "
            ''' <summary>
            ''' 商品名称を取得・設定します。
            ''' </summary>
            ''' <value>商品名称</value>
            ''' <returns>商品名称</returns>
            ''' <remarks></remarks>
            ''' <history> 2019/09/04 Created</history>
            Public Property Vendor_Nm() As String
                Get
                    Return strVendorNm
                End Get
                Set(ByVal value As String)
                    strVendorNm = value
                End Set
            End Property
#End Region

#Region "     Jan_Cd "
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

#Region "     Cs_Jan_Cd "
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

#Region "     Itf_Cd "
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

#Region "     Loc_Cd "
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

#Region "     Item_Mng_Date "
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

#Region "     Work_Sts "
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

#Region "     ArrivalKbn "
            ''' <summary>
            ''' 入荷区分を取得・設定します。
            ''' </summary>
            ''' <value>入荷区分</value>
            ''' <returns>入荷区分</returns>
            ''' <remarks></remarks>
            ''' <history>S.Toshino 2018/09/04 Created</history>
            Public Property Arrival_Kbn() As String
                Get
                    Return strArrivalKb
                End Get
                Set(ByVal value As String)
                    strArrivalKb = value
                End Set
            End Property
#End Region

#Region "     Work_User_Nm "
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

#Region "     RejectKbn "
            ''' <summary>
            ''' 不良品区分
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property RejectKbn() As String
                Get
                    Return strRejectKbn
                End Get
                Set(ByVal value As String)
                    strRejectKbn = value
                End Set
            End Property
#End Region

#Region "     InplanNo "
            ''' <summary>
            ''' 入荷予定No.
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history> Created</history>
            Public Property InplanNo() As String
                Get
                    Return strInplanNo
                End Get
                Set(ByVal value As String)
                    strInplanNo = value
                End Set
            End Property
#End Region

#Region "     WarMngDate "
            ''' <summary>
            ''' 在庫最新管理日
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history> Created</history>
            Public Property WarMngDate() As String
                Get
                    Return strWarMngDate
                End Get
                Set(ByVal value As String)
                    strWarMngDate = value
                End Set
            End Property
#End Region

#Region "     Pre_Upd_Yb "
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

#Region "     Upd_Yb_Now "
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

#Region "     Row "
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

#Region "     FILE_ID "
            ''' <summary>
            ''' 
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property FILE_ID() As String
                Get
                    Return strFILE_ID
                End Get
                Set(ByVal value As String)
                    strFILE_ID = value
                End Set
            End Property
#End Region

#Region "     FILE_LINE_NO "
            ''' <summary>
            ''' 
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property FILE_LINE_NO() As String
                Get
                    Return strFILE_LINE_NO
                End Get
                Set(ByVal value As String)
                    strFILE_LINE_NO = value
                End Set
            End Property
#End Region

#Region "     CsCarton "
            ''' <summary>
            ''' 入数
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property CsCarton() As Decimal
                Get
                    Return intCsCarton
                End Get
                Set(ByVal value As Decimal)
                    intCsCarton = value
                End Set
            End Property
#End Region

#Region "     ExpCsQty "
            ''' <summary>
            ''' 予定数ケース
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property ExpCsQty() As Decimal
                Get
                    Return intExpCsQty
                End Get
                Set(ByVal value As Decimal)
                    intExpCsQty = value
                End Set
            End Property
#End Region

#Region "     ExpPsQty "
            ''' <summary>
            ''' 予定数バラ
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property ExpPsQty() As Decimal
                Get
                    Return intExpPsQty
                End Get
                Set(ByVal value As Decimal)
                    intExpPsQty = value
                End Set
            End Property
#End Region

#Region "     ExpSpsQty "
            ''' <summary>
            ''' 予定数総
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property ExpSpsQty() As Decimal
                Get
                    Return intExpSpsQty
                End Get
                Set(ByVal value As Decimal)
                    intExpSpsQty = value
                End Set
            End Property
#End Region

#Region "     ActCsQty "
            ''' <summary>
            ''' 実績数ケース
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property ActCsQty() As Decimal
                Get
                    Return intActCsQty
                End Get
                Set(ByVal value As Decimal)
                    intActCsQty = value
                End Set
            End Property
#End Region

#Region "     ActPsQty "
            ''' <summary>
            ''' 実績数バラ
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property ActPsQty() As Decimal
                Get
                    Return intActPsQty
                End Get
                Set(ByVal value As Decimal)
                    intActPsQty = value
                End Set
            End Property
#End Region

#Region "     ActSpsQty "
            ''' <summary>
            ''' 実績数総
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            ''' <history>Arche Info. 2019/10/03 Created</history>
            Public Property ActSpsQty() As Decimal
                Get
                    Return intActSpsQty
                End Get
                Set(ByVal value As Decimal)
                    intActSpsQty = value
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

#Region " FindPicresDtl "
        ''' <summary>
        ''' 入荷実績情報(明細)を検索します。
        ''' </summary>
        ''' <returns>入荷実績情報</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info 2019/10/23 Created</history>
        Public Function FindPicresDtl(ByVal param As PicProgressParam) As DataTable
            Dim dstDat As New DataSet
            Dim sts As String = "未完了"
            Dim kbn As String = "通常入荷"
            Try
                With m_clsDbReader
                    '取得パラメータ
                    .ClearParameter()
                    .AddParameter("SYS_CD", SqlType.VarChar, g_srtPicres.Sys_Cd)                'システムコード
                    .AddParameter("CENTER_CD", SqlType.VarChar, g_srtPicres.Center_Cd)          'センタコード
                    .AddParameter("SHIP_DATE", SqlType.VarChar, param.Ship_Date)                '入荷予定日
                    .AddParameter("BLS_ITEM_CD", SqlType.VarChar, g_srtPicres.Bls_Item_Cd)       '商品BLSコード

                    '.AddParameter("JAN_CD", SqlType.VarChar, g_srtPicres.Jan_Cd)                 '単品JANコード
                    '.AddParameter("CS_JAN_CD", SqlType.VarChar, g_srtPicres.Cs_Jan_Cd)           'ケースJANコード
                    '.AddParameter("ITF_CD", SqlType.VarChar, g_srtPicres.Itf_Cd)                 'ITFコード
                    '.AddParameter("LOC_CD", SqlType.VarChar, g_srtPicres.Loc_Cd)                 'ロケーション
                    '.AddParameter("ITEM_MNG_DATE", SqlType.VarChar, g_srtPicres.Item_Mng_Date)   '商品管理日

                    Dim strStatus As String() = g_srtPicres.Work_Sts.Split(":")
                    If String.Compare(strStatus(0), sts) = 0 Then
                        .AddParameter("WORK_STS", SqlType.VarChar, 0)   'ステータス
                    Else
                        .AddParameter("WORK_STS", SqlType.VarChar, 1)   'ステータス
                    End If
                    ' .AddParameter("WORK_STS", SqlType.VarChar, g_srtPicres.Work_Sts)   'ステータス

                    Dim strCodeNm As String() = g_srtPicres.Arrival_Kbn.Split(":")
                    If String.Compare(strCodeNm(0), kbn) = 0 Then
                        .AddParameter("INOUT_KB", SqlType.VarChar, 111)   '荷区分
                    Else
                        .AddParameter("INOUT_KB", SqlType.VarChar, 123)   '荷区分
                    End If
                    ' .AddParameter("INOUT_KB", SqlType.VarChar, g_srtPicres.Arrival_Kbn)   '荷区分

                    '.AddParameter("FILE_ID", SqlType.VarChar, param.FileId)
                    '.AddParameter("FILE_LINE_NO", SqlType.VarChar, param.FileLineNo)
                    .AddParameter("FILE_ID", SqlType.VarChar, g_srtPicres.FILE_ID)
                    .AddParameter("FILE_LINE_NO", SqlType.VarChar, g_srtPicres.FILE_LINE_NO)

                End With

                '入荷実績情報取得SQL実行
                Dim sql As String = CreateFindPicresDtlSql()
                dstDat = m_clsDbReader.GetTableData(sql)

                '入荷実績情報
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

#Region "-- ModifyPicres "
        '''' <summary>
        '''' 入荷情報更新
        '''' </summary>
        '''' <param name="plstDat">構造体</param>
        '''' <returns>入荷情報更新</returns>
        '''' <remarks></remarks>
        '''' <history>Arche Info. 2019/10/23 Created</history>
        'Public Function ModifyPicres(ByVal plstDat As T_Picres) As Integer
        '    Try
        '        With m_clsDbReader
        '            .ClearParameter()
        '            '取得パラメータ
        '            '更新項目
        '            .AddParameter("WORK_STS", SqlType.VarChar, plstDat.Work_Sts)                     '作業ステータス
        '            .AddParameter("NOW_DATE", SqlType.VarChar, plstDat.Upd_Yb_Now)                   '更新日
        '            .AddParameter("UPD_USR_ID", SqlType.VarChar, m_strUserId)                        '更新ユーザー
        '            .AddParameter("UPD_PRC_ID", SqlType.VarChar, ComConst.ProgramID.PGIDS210)        '更新プログラム
        '            '更新条件
        '            .AddParameter("SYS_CD", SqlType.VarChar, plstDat.Sys_Cd)                         'システムコード
        '            .AddParameter("CENTER_CD", SqlType.VarChar, plstDat.Center_Cd)                   'センタコード
        '            .AddParameter("SHIP_DATE", SqlType.VarChar, plstDat.Ship_Date)                   '入荷予定日
        '            .AddParameter("BLS_DELI_CD", SqlType.VarChar, plstDat.Bls_Deli_Cd)               '納品先BLSコード
        '            .AddParameter("BLS_ITEM_CD", SqlType.VarChar, plstDat.Bls_Item_Cd)               '商品BLSコード
        '            .AddParameter("JAN_CD", SqlType.VarChar, plstDat.Jan_Cd)                         '単品JANコード
        '            .AddParameter("CS_JAN_CD", SqlType.VarChar, plstDat.Cs_Jan_Cd)                   'ケースJANコード
        '            .AddParameter("ITF_CD", SqlType.VarChar, plstDat.Itf_Cd)                         'ITFコード
        '            .AddParameter("LOC_CD", SqlType.VarChar, plstDat.Loc_Cd)                         'ロケーション
        '            .AddParameter("ITEM_MNG_DATE", SqlType.VarChar, plstDat.Item_Mng_Date)           '商品管理日
        '        End With

        '        'ピッキング指示情報更新SQL実行
        '        Return m_clsDbReader.ExecuteNonQuery(CreateModifyPicresSql())

        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
#End Region

#Region " FindPicProgress "
        ''' <summary>
        ''' 入荷指示状況を検索します。
        ''' </summary>
        ''' <param name="param">入荷指示検索パラメータ</param>
        ''' <returns>入荷指示情報</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info. 2019/10/23 Created</history>
        Public Function FindPicProgress(ByVal param As PicProgressParam) As DataTable
            Dim dstDat As New DataSet

            Try
                With m_clsDbReader
                    '取得パラメータ
                    .ClearParameter()
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)                   'システムコード
                    .AddParameter("CENTER_CD", SqlType.VarChar, param.CenterCd)             'センターコード
                    .AddParameter("SHIP_DATE", SqlType.VarChar, param.Ship_Date)            '入荷予定日
                    If Not String.IsNullOrEmpty(param.Bls_Item_Cd) Then
                        .AddParameter("BLS_ITEM_CD", SqlType.VarChar, param.Bls_Item_Cd)    'ロケーション
                    End If
                    If Not String.IsNullOrEmpty(param.Bls_Item_Nm) Then
                        .AddParameter("BLS_ITEM_NM", SqlType.VarChar, param.Bls_Item_Nm)    '商品名称
                    End If
                    If Not String.IsNullOrEmpty(param.NyuYotNo) Then
                        .AddParameter("NYUYOTNO", SqlType.VarChar, param.NyuYotNo)          '入荷予定NO
                    End If
                    If Not String.IsNullOrEmpty(param.Status) Then
                        .AddParameter("STATUS", SqlType.VarChar, param.Status)              'ステータス
                    End If
                    If Not String.IsNullOrEmpty(param.Nyuka_Kb) Then
                        .AddParameter("NYUKBN", SqlType.VarChar, param.Nyuka_Kb)            '入荷区分
                    End If
                    If Not String.IsNullOrEmpty(param.Location) Then
                        .AddParameter("LOC_CD", SqlType.VarChar, param.Location)            'ロケーション
                    End If
                    If Not String.IsNullOrEmpty(param.VendorCd) Then
                        .AddParameter("VENDOR_CD", SqlType.VarChar, param.VendorCd)         '発地コード
                    End If
                    If Not String.IsNullOrEmpty(param.VendorNm) Then
                        .AddParameter("VENDOR_NM", SqlType.VarChar, param.VendorNm)         '発地名称
                    End If
                    If Not String.IsNullOrEmpty(param.WrkUserNm) Then
                        .AddParameter("WORK_USER_NM", SqlType.VarChar, param.WrkUserNm)     '発地名称
                    End If
                    If Not String.IsNullOrEmpty(param.RejectKb) Then
                        .AddParameter("REJECT_KB", SqlType.VarChar, param.RejectKb)         '不良品検索のフラグ
                        '何か値がセットされていれば、不良品だけ検索
                    End If
                    If Not String.IsNullOrEmpty(param.Warning) Then
                        .AddParameter("WARNING", SqlType.VarChar, param.Warning)            'ワーニング
                        '1がセットされていれば、ワーニングありのものだけ検索
                    End If

                End With

                '入荷指示情報取得SQL実行
                Dim sql As String = ""
                If "1".Equals(param.Warning) Then
                    sql = CreateWarningSql(param)
                Else
                    sql = CreateFindPicProgressSql(param)
                End If

                dstDat = m_clsDbReader.GetTableData(sql)

                '入荷指示情報
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

#Region " FindNyukaKbn "
        ''' <summary>
        ''' 入荷区分を検索します。
        ''' </summary>
        ''' <param name="param"></param>
        ''' <returns>入荷区分</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info. 2019/10/23 Created</history>
        Public Function FindNyukaKbn(ByVal param As FindNyukaKb) As String
            Dim dstDat As New DataSet
            Dim pickNyuuka As String

            Try
                With m_clsDbReader
                    '取得パラメータ
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

#Region " FindStatus "
        ''' <summary>
        ''' 入荷作業ステータスを検索します。
        ''' </summary>
        ''' <param name="param"></param>
        ''' <returns>入荷作業ステータス</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info. 2019/10/23 Created</history>
        Public Function FindStatus(ByVal param As FindNyukaKb) As String
            Dim dstDat As New DataSet
            Dim pickNyuuka As String

            Try
                With m_clsDbReader
                    '取得パラメータ
                    .ClearParameter()
                    .AddParameter("CODE", SqlType.VarChar, param.Code)              'ロケーション（ゾーン）
                    .AddParameter("SYS_CD", SqlType.VarChar, param.SysCd)           'システムコード
                    .AddParameter("CODE_KEY", SqlType.VarChar, param.Status)        'システムコード

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

#End Region

#Region " Private "

#Region " CreateFindPicresDtlSql "
        ''' <summary>
        ''' 入荷実情報検索(明細)用SQL文を生成します。
        ''' </summary>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info 2019/10/20 Created</history>
        Private Function CreateFindPicresDtlSql() As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT")
                    .AppendLine("   A.BLS_ITEM_CD	,	A.BLS_ITEM_NM	")
                    .AppendLine(" ,	A.EXP_CS_QTY	,	A.EXP_PL_QTY	,	A.EXP_SPL_QTY ")
                    .AppendLine(" ,	B.ITEM_MNG_DATE") '実績の管理日
                    .AppendLine(" ,	A.CS_CARTON")
                    .AppendLine(" ,	A.VENDOR_CD	,	A.VENDOR_NM	")
                    .AppendLine(" ,	A.ORDER_NO")
                    .AppendLine(" ,	A.EXP_CS_QTY AS EXP_CS_QTY")
                    .AppendLine(" ,	A.EXP_PL_QTY AS EXP_PL_QTY")
                    .AppendLine(" ,	A.EXP_SPL_QTY AS EXP_SPL_QTY")
                    .AppendLine(" ,	A.UPD_YB AS UPD_YB")
                    .AppendLine(" ,	B.ACT_CS_QTY")
                    .AppendLine(" ,	B.ACT_PS_QTY")
                    .AppendLine(" ,	B.ACT_SPS_QTY")
                    .AppendLine(" ,	B.WORK_USER_NM")
                    .AppendLine(" ,	B.INS_YB")
                    .AppendLine(" ,	B.SEND_FLG")
                    .AppendLine(" ,	B.INPLAN_DATE")
                    .AppendLine(" ,	B.INPLAN_NO")
                    .AppendLine(" ,	B.BRANCH_NO")
                    .AppendLine(" ,	B.UPD_YB")
                    .AppendLine("FROM")
                    .AppendLine("  T_INPLAN			A	")
                    .AppendLine("INNER JOIN	")
                    .AppendLine("  T_INRES			B	")
                    .AppendLine("   ON		A.SYS_CD			=	B.SYS_CD	")
                    .AppendLine("	    AND		A.CENTER_CD	    =	B.CENTER_CD	")
                    .AppendLine("       AND		A.FILE_ID		=	B.FILE_ID		")
                    .AppendLine("       AND		A.FILE_LINE_NO	=	B.FILE_LINE_NO	")
                    .AppendLine("	    AND		A.CENTER_CD     =   B.CENTER_CD")
                    .AppendLine("       AND		A.INPLAN_DATE	=	B.INPLAN_DATE	")
                    .AppendLine("       AND		A.INPLAN_NO	    =	B.INPLAN_NO		")
                    .AppendLine("WHERE")
                    .AppendLine("           A.SYS_CD		=	:SYS_CD		")
                    .AppendLine("    AND    A.WORK_STS <> 9	")                  'ステータス 9以外であること
                    .AppendLine("    AND	A.CENTER_CD		=	:CENTER_CD		")
                    .AppendLine("    AND	A.INPLAN_DATE	=	:SHIP_DATE		")
                    .AppendLine("    AND	A.WORK_STS		=	:WORK_STS		")
                    .AppendLine("    AND	A.BLS_ITEM_CD	=	:BLS_ITEM_CD	")
                    .AppendLine("    AND	A.INOUT_KB		=	:INOUT_KB		")
                    .AppendLine("    AND	A.FILE_ID		=	:FILE_ID		")
                    .AppendLine("    AND	A.FILE_LINE_NO	=	:FILE_LINE_NO	")
                    .AppendLine("ORDER BY")
                    .AppendLine("  B.BRANCH_NO")
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

#Region "-- CreateModifyPicresSql "
        '''' <summary>
        '''' ピッキング指示情報更新用SQL文を生成します。
        '''' </summary>
        '''' <returns>SQL文</returns>
        '''' <remarks></remarks>
        '''' <history>S.Toshino 2018/09/05 Created</history>
        'Private Function CreateModifyPicresSql() As String
        '    Dim strSql As New StringBuilder
        '    Try
        '        'SQL生成
        '        With strSql
        '            .AppendLine("UPDATE  T_PICINST")                       'ピッキング指示情報
        '            .AppendLine(" SET ")
        '            .AppendLine("       WORK_STS       = :WORK_STS")       '作業ステータス
        '            .AppendLine("        ,UPD_YB        = :NOW_DATE")      '更新日
        '            .AppendLine("        ,UPD_USR_ID    = :UPD_USR_ID")    '更新ユーザー
        '            .AppendLine("        ,UPD_PRC_ID    = :UPD_PRC_ID")    '更新プログラム
        '            .AppendLine(" WHERE")
        '            .AppendLine("        SYS_CD         = :SYS_CD")
        '            .AppendLine("  AND   CENTER_CD      = :CENTER_CD")
        '            .AppendLine("  AND   SHIP_DATE      = :SHIP_DATE")
        '            .AppendLine("  AND   BLS_DELI_CD    = :BLS_DELI_CD")
        '            .AppendLine("  AND   BLS_ITEM_CD    = :BLS_ITEM_CD")
        '            .AppendLine("  AND   JAN_CD         = :JAN_CD")
        '            .AppendLine("  AND   CS_JAN_CD      = :CS_JAN_CD")
        '            .AppendLine("  AND   ITF_CD         = :ITF_CD")
        '            .AppendLine("  AND   LOC_CD         = :LOC_CD")
        '            .AppendLine("  AND   ITEM_MNG_DATE  = :ITEM_MNG_DATE")
        '        End With

        '        Return strSql.ToString

        '    Catch ex As Exception
        '        Throw ex
        '    Finally
        '        '解放
        '        strSql = Nothing
        '    End Try
        'End Function
#End Region

#Region " CreateFindPicProgressSql "
        ''' <summary>
        ''' 入荷指示照会用SQL文を生成します。
        ''' </summary>
        ''' <param name="pParam">検索条件</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info. 2019/10/23 Created</history>
        Private Function CreateFindPicProgressSql(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder

            Try
                'SQL発行
                With strSql
                    .AppendLine("   SELECT")
                    .AppendLine("       A.WORK_STS      ")
                    '.AppendLine("       , M.CODE_NM AS INOUT_NM ")
                    .AppendLine("       , A.INOUT_KB	")
                    .AppendLine("       , A.VENDOR_CD ")
                    .AppendLine("       , A.VENDOR_NM ")
                    .AppendLine("       , A.BLS_ITEM_CD")
                    .AppendLine("       , A.BLS_ITEM_NM")
                    .AppendLine("       , A.ITEM_MNG_DATE")
                    .AppendLine("       , A.CS_CARTON")
                    .AppendLine("       , MAX(NVL(A.EXP_CS_QTY, 0))  AS EXP_CS_QTY") ' using MAX() is trick for oracle. this is always equals T_INPLAN.EXP_CS_QTY value.
                    .AppendLine("       , MAX(NVL(A.EXP_PL_QTY, 0))  AS EXP_PL_QTY")
                    .AppendLine("       , MAX(NVL(A.EXP_SPL_QTY, 0)) AS EXP_SPL_QTY")
                    .AppendLine("       , SUM(NVL(B.ACT_CS_QTY, 0))  AS ACT_CS_QTY")
                    .AppendLine("       , SUM(NVL(B.ACT_PS_QTY, 0))  AS ACT_PS_QTY")
                    .AppendLine("       , SUM(NVL(B.ACT_SPS_QTY, 0)) AS ACT_SPS_QTY")
                    .AppendLine("       , A.NEW_INV_DATE")
                    .AppendLine("       , A.REJECT_KB")
                    .AppendLine("       , A.INPLAN_NO   ")
                    .AppendLine("       , A.LOC_CD")
                    .AppendLine("       , A.JAN_CD")
                    .AppendLine("       , A.CS_JAN_CD")
                    .AppendLine("       , A.ITF_CD")
                    .AppendLine("       , A.FILE_ID")
                    .AppendLine("       , A.FILE_LINE_NO")
                    '.AppendLine("       , A.INPLAN_DATE")
                    '.AppendLine("       , A.DATE_MNG_FLG")
                    '.AppendLine("       , B.SEND_FLG  ")
                    '.AppendLine("      , B.WORK_USER_NM , B.INS_YB ")
                    .AppendLine("   FROM")
                    .AppendLine("         T_INPLAN  A ")
                    .AppendLine("   LEFT JOIN")
                    .AppendLine("         T_INRES   B ")
                    .AppendLine("     ON		A.SYS_CD	=	B.SYS_CD	")
                    .AppendLine("	    AND		A.CENTER_CD	=	B.CENTER_CD	")
                    .AppendLine("	    AND		A.FILE_ID	=	B.FILE_ID	")
                    .AppendLine("	    AND		A.FILE_LINE_NO	=	B.FILE_LINE_NO	")
                    .AppendLine("	    AND		A.CENTER_CD     =   B.CENTER_CD")
                    .AppendLine("	    AND		A.INPLAN_DATE	=	B.INPLAN_DATE	")
                    .AppendLine("       AND		A.INPLAN_NO	    =	B.INPLAN_NO	")
                    '.AppendLine("   LEFT JOIN")
                    '.AppendLine("        M_CODE	M ")
                    '.AppendLine("     ON		A.SYS_CD	=	M.SYS_CD")
                    '.AppendLine("       AND		A.INOUT_KB	=	M.CODE	")
                    '.AppendLine("       AND		M.CODE_KEY	=	'IN_KB'	")
                    .AppendLine("   WHERE ")
                    .AppendLine("               A.SYS_CD	=	:SYS_CD	")
                    .AppendLine("       AND     A.CENTER_CD	=	:CENTER_CD	")
                    .AppendLine("       AND     A.WORK_STS <> 9	")                  'ステータス 9以外であること
                    .AppendLine("       AND     A.INPLAN_DATE	=	:SHIP_DATE	")              '入荷予定日
                    If Not String.IsNullOrEmpty(pParam.NyuYotNo) Then
                        .AppendLine("   AND A.INPLAN_NO LIKE :NYUYOTNO || '%'")                 '入荷予定NO
                    End If
                    If Not String.IsNullOrEmpty(pParam.Bls_Item_Cd) Then
                        .AppendLine("   AND A.BLS_ITEM_CD LIKE :BLS_ITEM_CD || '%'")            '商品BLSコード
                    End If
                    If Not String.IsNullOrEmpty(pParam.Status) Then
                        .AppendLine("   AND A.WORK_STS			=	:STATUS	")                  'ステータス
                    End If
                    If Not String.IsNullOrEmpty(pParam.Bls_Item_Nm) Then
                        .AppendLine("   AND  A.BLS_ITEM_NM LIKE '%' || :BLS_ITEM_NM || '%'")    '商品名称
                    End If
                    If Not String.IsNullOrEmpty(pParam.Nyuka_Kb) Then
                        .AppendLine("   AND A.INOUT_KB			=	:NYUKBN	")                  '入荷区分
                    End If
                    If Not String.IsNullOrEmpty(pParam.Location) Then
                        .AppendLine("   AND A.LOC_CD LIKE :LOC_CD || '%'")                      'ロケーション
                    End If
                    If Not String.IsNullOrEmpty(pParam.VendorCd) Then
                        .AppendLine("   AND A.VENDOR_CD LIKE :VENDOR_CD || '%'")                '発地コード
                    End If
                    If Not String.IsNullOrEmpty(pParam.VendorNm) Then
                        .AppendLine("   AND  A.VENDOR_NM LIKE '%' || :VENDOR_NM || '%'")        '発地名称
                    End If
                    If Not String.IsNullOrEmpty(pParam.WrkUserNm) Then
                        .AppendLine("   AND  B.WORK_USER_NM LIKE '%' || :WORK_USER_NM || '%'")  '作業者名称
                    End If
                    If Not String.IsNullOrEmpty(pParam.RejectKb) Then
                        '.AppendLine("   AND A.REJECT_KB  <>	:REJECT_KB	")                  '不良品区分
                        .AppendLine("   AND TRIM(A.REJECT_KB) IS NOT NULL") '不良品を出す
                        ' oracle "IS NULL" match ""(empty string). TRIM() change " " to ""
                        ' REJECT_KB: (NULL, "", " ") == 良品。otherwise 不良品
                    End If

                    .AppendLine("   GROUP BY")
                    .AppendLine("        A.SYS_CD, A.FILE_ID, A.FILE_LINE_NO, A.CENTER_CD")
                    .AppendLine("        , A.WORK_STS")
                    .AppendLine("        , A.INOUT_KB")
                    '.AppendLine("        , M.CODE_NM")
                    '.AppendLine("        , A.INPLAN_DATE")
                    .AppendLine("        , A.INPLAN_NO")
                    '.AppendLine("       , B.SEND_FLG     ")
                    '.AppendLine("       , B.WORK_USER_NM")
                    '.AppendLine("       , B.INS_YB      ")
                    .AppendLine("       , A.VENDOR_NM")
                    .AppendLine("       , A.VENDOR_CD")
                    .AppendLine("       , A.ITF_CD")
                    .AppendLine("       , A.BLS_ITEM_CD")
                    .AppendLine("       , A.BLS_ITEM_NM")
                    .AppendLine("       , A.LOC_CD")
                    '.AppendLine("       , A.EXP_CS_QTY   , A.EXP_PL_QTY  , A.EXP_SPL_QTY")
                    .AppendLine("       , A.ITEM_MNG_DATE")
                    .AppendLine("       , A.REJECT_KB")
                    .AppendLine("       , A.JAN_CD")
                    .AppendLine("       , A.CS_JAN_CD")
                    .AppendLine("       , A.NEW_INV_DATE")
                    .AppendLine("       , A.CS_CARTON")
                    '.AppendLine("       , A.DATE_MNG_FLG ")

                    .AppendLine("ORDER BY	")
                    .AppendLine("	A.VENDOR_CD")
                    .AppendLine(",	A.BLS_ITEM_CD")
                    .AppendLine(",	A.REJECT_KB")
                    .AppendLine(",	A.ITEM_MNG_DATE")
                    .AppendLine(",  A.INPLAN_NO")
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

#Region " CreateWarningSql "
        ''' <summary>
        ''' 入荷指示照会用WarningチェックSQL文を生成します。
        ''' </summary>
        ''' <param name="pParam">検索条件</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info. 2019/10/28 Created</history>
        Private Function CreateWarningSql(ByVal pParam As PicProgressParam) As String
            Dim strSql As New StringBuilder

            Try
                'SQL発行
                With strSql
                    .AppendLine("SELECT WORK_STS,INOUT_KB,VENDOR_CD,VENDOR_NM,BLS_ITEM_CD,BLS_ITEM_NM,ITEM_MNG_DATE,CS_CARTON,EXP_CS_QTY,EXP_PL_QTY,EXP_SPL_QTY ")
                    .AppendLine(" , ACT_CS_QTY,ACT_PS_QTY,ACT_SPS_QTY,NEW_INV_DATE,REJECT_KB,INPLAN_NO,LOC_CD,JAN_CD,CS_JAN_CD,ITF_CD,FILE_ID,FILE_LINE_NO ")
                    .AppendLine("FROM (")

                    '１．予定に商品管理日が入っているとき、予定と実績の商品管理日が１つでも違うもの。

                    .AppendLine("   SELECT  ")
                    .AppendLine("    S1.WORK_STS ,  ")
                    .AppendLine("    S1.INOUT_KB ,  ")
                    .AppendLine("    S1.VENDOR_CD ,  ")
                    .AppendLine("    S1.VENDOR_NM ,  ")
                    .AppendLine("    S1.BLS_ITEM_CD ,  ")
                    .AppendLine("    S1.BLS_ITEM_NM ,  ")
                    .AppendLine("    S1.ITEM_MNG_DATE ,  ")
                    .AppendLine("    S1.CS_CARTON ,  ")
                    .AppendLine("    S1.EXP_CS_QTY ,  ")
                    .AppendLine("    S1.EXP_PL_QTY ,  ")
                    .AppendLine("    S1.EXP_SPL_QTY ,  ")
                    .AppendLine("    S2.ACT_CS_QTY ,  ")
                    .AppendLine("    S2.ACT_PS_QTY ,  ")
                    .AppendLine("    S2.ACT_SPS_QTY ,  ")
                    .AppendLine("    S1.NEW_INV_DATE ,  ")
                    .AppendLine("    S1.REJECT_KB ,  ")
                    .AppendLine("    S1.INPLAN_NO ,  ")
                    .AppendLine("    S1.LOC_CD ,  ")
                    .AppendLine("    S1.JAN_CD ,  ")
                    .AppendLine("    S1.CS_JAN_CD ,  ")
                    .AppendLine("    S1.ITF_CD ,  ")
                    .AppendLine("    S1.FILE_ID ,  ")
                    .AppendLine("    S1.FILE_LINE_NO  ")
                    .AppendLine("  FROM  ")
                    .AppendLine("    (  ")
                    .AppendLine("      SELECT  ")
                    .AppendLine("        A.SYS_CD,  ")
                    .AppendLine("        A.FILE_ID,  ")
                    .AppendLine("        A.FILE_LINE_NO ,  ")
                    .AppendLine("        MAX(A.CENTER_CD) CENTER_CD ,  ")
                    .AppendLine("        MAX(A.INPLAN_DATE) INPLAN_DATE ,  ")
                    .AppendLine("        MAX(A.WORK_STS) WORK_STS ,  ")
                    .AppendLine("        MAX(A.INOUT_KB) INOUT_KB ,  ")
                    .AppendLine("        MAX(A.VENDOR_CD) VENDOR_CD ,  ")
                    .AppendLine("        MAX(A.VENDOR_NM) VENDOR_NM ,  ")
                    .AppendLine("        MAX(A.BLS_ITEM_CD) BLS_ITEM_CD ,  ")
                    .AppendLine("        MAX(A.BLS_ITEM_NM) BLS_ITEM_NM ,  ")
                    .AppendLine("        MAX(A.ITEM_MNG_DATE) ITEM_MNG_DATE ,  ")
                    .AppendLine("        MAX(A.CS_CARTON) CS_CARTON ,  ")
                    .AppendLine("        MAX(A.EXP_CS_QTY)  AS EXP_CS_QTY ,  ")
                    .AppendLine("        MAX(A.EXP_PL_QTY)  AS EXP_PL_QTY ,  ")
                    .AppendLine("        MAX(A.EXP_SPL_QTY) AS EXP_SPL_QTY ,  ")
                    .AppendLine("        MAX(A.NEW_INV_DATE) NEW_INV_DATE ,  ")
                    .AppendLine("        MAX(A.REJECT_KB) REJECT_KB ,  ")
                    .AppendLine("        MAX(A.INPLAN_NO) INPLAN_NO ,  ")
                    .AppendLine("        MAX(A.LOC_CD) LOC_CD ,  ")
                    .AppendLine("        MAX(A.JAN_CD) JAN_CD ,  ")
                    .AppendLine("        MAX(A.CS_JAN_CD) CS_JAN_CD ,  ")
                    .AppendLine("        MAX(A.ITF_CD) ITF_CD  ")
                    .AppendLine("      FROM  ")
                    .AppendLine("        T_INPLAN A  ")
                    .AppendLine("      INNER JOIN T_INRES B  ")
                    .AppendLine("      ON  ")
                    .AppendLine("        A.SYS_CD         = B.SYS_CD  ")
                    .AppendLine("      AND A.CENTER_CD    = B.CENTER_CD  ")
                    .AppendLine("      AND A.FILE_ID      = B.FILE_ID  ")
                    .AppendLine("      AND A.FILE_LINE_NO = B.FILE_LINE_NO  ")
                    .AppendLine("      AND A.INPLAN_DATE  = B.INPLAN_DATE  ")
                    .AppendLine("      AND A.INPLAN_NO    = B.INPLAN_NO  ")
                    .AppendLine("      WHERE  ")
                    .AppendLine("        A.SYS_CD           = :SYS_CD  ")
                    .AppendLine("      AND A.CENTER_CD      = :CENTER_CD  ")
                    .AppendLine("      AND A.WORK_STS      <> 9  ")
                    .AppendLine("      AND A.INPLAN_DATE    = :SHIP_DATE  ")
                    .AppendLine("      AND A.DATE_MNG_FLG  <> '1'  ")
                    .AppendLine("      AND A.ITEM_MNG_DATE <> ' '  ")
                    ' .AppendLine("    AND to_number( trim(A.ITEM_MNG_DATE || '0') ) <> to_number( trim(B.ITEM_MNG_DATE || '0') )")
                    .AppendLine("      AND A.ITEM_MNG_DATE <> B.ITEM_MNG_DATE  ")
                    .AppendLine("      GROUP BY  ")
                    .AppendLine("        A.SYS_CD,  ")
                    .AppendLine("        A.FILE_ID,  ")
                    .AppendLine("        A.FILE_LINE_NO  ")
                    .AppendLine("    )  ")
                    .AppendLine("    S1  ")
                    .AppendLine("  INNER JOIN  ")
                    .AppendLine("    (  ")
                    .AppendLine("      SELECT  ")
                    .AppendLine("        A.SYS_CD,  ")
                    .AppendLine("        A.FILE_ID,  ")
                    .AppendLine("        A.FILE_LINE_NO ,  ")
                    .AppendLine("        SUM(B.ACT_CS_QTY)  AS ACT_CS_QTY ,  ")
                    .AppendLine("        SUM(B.ACT_PS_QTY)  AS ACT_PS_QTY ,  ")
                    .AppendLine("        SUM(B.ACT_SPS_QTY) AS ACT_SPS_QTY  ")
                    .AppendLine("      FROM  ")
                    .AppendLine("        T_INPLAN A  ")
                    .AppendLine("      INNER JOIN T_INRES B  ")
                    .AppendLine("      ON  ")
                    .AppendLine("        A.SYS_CD         = B.SYS_CD  ")
                    .AppendLine("      AND A.CENTER_CD    = B.CENTER_CD  ")
                    .AppendLine("      AND A.FILE_ID      = B.FILE_ID  ")
                    .AppendLine("      AND A.FILE_LINE_NO = B.FILE_LINE_NO  ")
                    .AppendLine("      AND A.INPLAN_DATE  = B.INPLAN_DATE  ")
                    .AppendLine("      AND A.INPLAN_NO    = B.INPLAN_NO  ")
                    .AppendLine("      WHERE  ")
                    .AppendLine("        A.SYS_CD           = :SYS_CD  ")
                    .AppendLine("      AND A.CENTER_CD      = :CENTER_CD  ")
                    .AppendLine("      AND A.WORK_STS      <> 9  ")
                    .AppendLine("      AND A.INPLAN_DATE    = :SHIP_DATE  ")
                    .AppendLine("      AND A.DATE_MNG_FLG  <> '1'  ")
                    .AppendLine("      AND A.ITEM_MNG_DATE <> ' '  ")
                    .AppendLine("      GROUP BY  ")
                    .AppendLine("        A.SYS_CD,  ")
                    .AppendLine("        A.FILE_ID,  ")
                    .AppendLine("        A.FILE_LINE_NO  ")
                    .AppendLine("    )  ")
                    .AppendLine("    S2 ON S1.SYS_CD   = S2.SYS_CD  ")
                    .AppendLine("  AND S1.FILE_ID      = S2.FILE_ID  ")
                    .AppendLine("  AND S1.FILE_LINE_NO = S2.FILE_LINE_NO  ")

                    .AppendLine("  UNION ")

                    '２．実績の商品管理日（１つでも）＜予定の在庫最新管理日

                    .AppendLine("    SELECT  ")
                    .AppendLine("      S1.WORK_STS ,  ")
                    .AppendLine("      S1.INOUT_KB ,  ")
                    .AppendLine("      S1.VENDOR_CD ,  ")
                    .AppendLine("      S1.VENDOR_NM ,  ")
                    .AppendLine("      S1.BLS_ITEM_CD ,  ")
                    .AppendLine("      S1.BLS_ITEM_NM ,  ")
                    .AppendLine("      S1.ITEM_MNG_DATE ,  ")
                    .AppendLine("      S1.CS_CARTON ,  ")
                    .AppendLine("      S1.EXP_CS_QTY ,  ")
                    .AppendLine("      S1.EXP_PL_QTY ,  ")
                    .AppendLine("      S1.EXP_SPL_QTY ,  ")
                    .AppendLine("      S2.ACT_CS_QTY ,  ")
                    .AppendLine("      S2.ACT_PS_QTY ,  ")
                    .AppendLine("      S2.ACT_SPS_QTY ,  ")
                    .AppendLine("      S1.NEW_INV_DATE ,  ")
                    .AppendLine("      S1.REJECT_KB ,  ")
                    .AppendLine("      S1.INPLAN_NO ,  ")
                    .AppendLine("      S1.LOC_CD ,  ")
                    .AppendLine("      S1.JAN_CD ,  ")
                    .AppendLine("      S1.CS_JAN_CD ,  ")
                    .AppendLine("      S1.ITF_CD ,  ")
                    .AppendLine("      S1.FILE_ID ,  ")
                    .AppendLine("      S1.FILE_LINE_NO  ")
                    .AppendLine("    FROM  ")
                    .AppendLine("      (  ")
                    .AppendLine("        SELECT  ")
                    .AppendLine("          A.SYS_CD,  ")
                    .AppendLine("          A.FILE_ID,  ")
                    .AppendLine("          A.FILE_LINE_NO ,  ")
                    .AppendLine("          MAX(A.CENTER_CD) CENTER_CD ,  ")
                    .AppendLine("          MAX(A.INPLAN_DATE) INPLAN_DATE ,  ")
                    .AppendLine("          MAX(A.WORK_STS) WORK_STS ,  ")
                    .AppendLine("          MAX(A.INOUT_KB) INOUT_KB ,  ")
                    .AppendLine("          MAX(A.VENDOR_CD) VENDOR_CD ,  ")
                    .AppendLine("          MAX(A.VENDOR_NM) VENDOR_NM ,  ")
                    .AppendLine("          MAX(A.BLS_ITEM_CD) BLS_ITEM_CD ,  ")
                    .AppendLine("          MAX(A.BLS_ITEM_NM) BLS_ITEM_NM ,  ")
                    .AppendLine("          MAX(A.ITEM_MNG_DATE) ITEM_MNG_DATE ,  ")
                    .AppendLine("          MAX(A.CS_CARTON) CS_CARTON ,  ")
                    .AppendLine("          MAX(A.EXP_CS_QTY)  AS EXP_CS_QTY ,  ")
                    .AppendLine("          MAX(A.EXP_PL_QTY)  AS EXP_PL_QTY ,  ")
                    .AppendLine("          MAX(A.EXP_SPL_QTY) AS EXP_SPL_QTY ,  ")
                    .AppendLine("          MAX(A.NEW_INV_DATE) NEW_INV_DATE ,  ")
                    .AppendLine("          MAX(A.REJECT_KB) REJECT_KB ,  ")
                    .AppendLine("          MAX(A.INPLAN_NO) INPLAN_NO ,  ")
                    .AppendLine("          MAX(A.LOC_CD) LOC_CD ,  ")
                    .AppendLine("          MAX(A.JAN_CD) JAN_CD ,  ")
                    .AppendLine("          MAX(A.CS_JAN_CD) CS_JAN_CD ,  ")
                    .AppendLine("          MAX(A.ITF_CD) ITF_CD  ")
                    .AppendLine("        FROM  ")
                    .AppendLine("          T_INPLAN A  ")
                    .AppendLine("        INNER JOIN T_INRES B  ")
                    .AppendLine("        ON  ")
                    .AppendLine("          A.SYS_CD         = B.SYS_CD  ")
                    .AppendLine("        AND A.CENTER_CD    = B.CENTER_CD  ")
                    .AppendLine("        AND A.FILE_ID      = B.FILE_ID  ")
                    .AppendLine("        AND A.FILE_LINE_NO = B.FILE_LINE_NO  ")
                    .AppendLine("        AND A.INPLAN_DATE  = B.INPLAN_DATE  ")
                    .AppendLine("        AND A.INPLAN_NO    = B.INPLAN_NO  ")
                    .AppendLine("        WHERE  ")
                    .AppendLine("           A.SYS_CD           = :SYS_CD  ")
                    .AppendLine("        AND A.CENTER_CD      = :CENTER_CD  ")
                    .AppendLine("        AND A.WORK_STS     <> 9  ")
                    .AppendLine("        AND A.INPLAN_DATE    = :SHIP_DATE  ")
                    .AppendLine("        AND A.DATE_MNG_FLG <> '1'  ")
                    .AppendLine("        AND B.ITEM_MNG_DATE < A.New_Inv_Date  ")
                    .AppendLine("        GROUP BY  ")
                    .AppendLine("          A.SYS_CD,  ")
                    .AppendLine("          A.FILE_ID,  ")
                    .AppendLine("          A.FILE_LINE_NO  ")
                    .AppendLine("      )  ")
                    .AppendLine("      S1  ")
                    .AppendLine("    INNER JOIN  ")
                    .AppendLine("      (  ")
                    .AppendLine("        SELECT  ")
                    .AppendLine("          A.SYS_CD,  ")
                    .AppendLine("          A.FILE_ID,  ")
                    .AppendLine("          A.FILE_LINE_NO ,  ")
                    .AppendLine("          SUM(B.ACT_CS_QTY)  AS ACT_CS_QTY ,  ")
                    .AppendLine("          SUM(B.ACT_PS_QTY)  AS ACT_PS_QTY ,  ")
                    .AppendLine("          SUM(B.ACT_SPS_QTY) AS ACT_SPS_QTY  ")
                    .AppendLine("        FROM  ")
                    .AppendLine("          T_INPLAN A  ")
                    .AppendLine("        INNER JOIN T_INRES B  ")
                    .AppendLine("        ON  ")
                    .AppendLine("          A.SYS_CD         = B.SYS_CD  ")
                    .AppendLine("        AND A.CENTER_CD    = B.CENTER_CD  ")
                    .AppendLine("        AND A.FILE_ID      = B.FILE_ID  ")
                    .AppendLine("        AND A.FILE_LINE_NO = B.FILE_LINE_NO  ")
                    .AppendLine("        AND A.INPLAN_DATE  = B.INPLAN_DATE  ")
                    .AppendLine("        AND A.INPLAN_NO    = B.INPLAN_NO  ")
                    .AppendLine("        WHERE  ")
                    .AppendLine("          A.SYS_CD         = B.SYS_CD  ")
                    .AppendLine("        AND A.CENTER_CD    = B.CENTER_CD  ")
                    .AppendLine("        AND A.WORK_STS     <> 9  ")
                    .AppendLine("       AND A.INPLAN_DATE    = :SHIP_DATE  ")
                    .AppendLine("        AND A.DATE_MNG_FLG <> '1'  ")
                    .AppendLine("        GROUP BY  ")
                    .AppendLine("          A.SYS_CD,  ")
                    .AppendLine("          A.FILE_ID,  ")
                    .AppendLine("          A.FILE_LINE_NO  ")
                    .AppendLine("      )  ")
                    .AppendLine("      S2 ON S1.SYS_CD   = S2.SYS_CD  ")
                    .AppendLine("    AND S1.FILE_ID      = S2.FILE_ID  ")
                    .AppendLine("    AND S1.FILE_LINE_NO = S2.FILE_LINE_NO  ")
                    .AppendLine("      ")

                    .AppendLine("  UNION ")

                    '３．商品管理区分＝３の場合、実績の商品管理日≦システム日付

                    .AppendLine("  SELECT  ")
                    .AppendLine("    S1.WORK_STS ,  ")
                    .AppendLine("    S1.INOUT_KB ,  ")
                    .AppendLine("    S1.VENDOR_CD ,  ")
                    .AppendLine("    S1.VENDOR_NM ,  ")
                    .AppendLine("    S1.BLS_ITEM_CD ,  ")
                    .AppendLine("    S1.BLS_ITEM_NM ,  ")
                    .AppendLine("    S1.ITEM_MNG_DATE ,  ")
                    .AppendLine("    S1.CS_CARTON ,  ")
                    .AppendLine("    S1.EXP_CS_QTY ,  ")
                    .AppendLine("    S1.EXP_PL_QTY ,  ")
                    .AppendLine("    S1.EXP_SPL_QTY ,  ")
                    .AppendLine("    S2.ACT_CS_QTY ,  ")
                    .AppendLine("    S2.ACT_PS_QTY ,  ")
                    .AppendLine("    S2.ACT_SPS_QTY ,  ")
                    .AppendLine("    S1.NEW_INV_DATE ,  ")
                    .AppendLine("    S1.REJECT_KB ,  ")
                    .AppendLine("    S1.INPLAN_NO ,  ")
                    .AppendLine("    S1.LOC_CD ,  ")
                    .AppendLine("    S1.JAN_CD ,  ")
                    .AppendLine("    S1.CS_JAN_CD ,  ")
                    .AppendLine("    S1.ITF_CD ,  ")
                    .AppendLine("    S1.FILE_ID ,  ")
                    .AppendLine("    S1.FILE_LINE_NO  ")
                    .AppendLine("    FROM (  ")
                    .AppendLine("      ")
                    .AppendLine("    SELECT  ")
                    .AppendLine("        A.SYS_CD,  ")
                    .AppendLine("        A.FILE_ID,  ")
                    .AppendLine("        A.FILE_LINE_NO ,  ")
                    .AppendLine("        MAX(A.CENTER_CD) CENTER_CD ,  ")
                    .AppendLine("        MAX(A.INPLAN_DATE) INPLAN_DATE ,  ")
                    .AppendLine("        MAX(A.WORK_STS) WORK_STS ,  ")
                    .AppendLine("        MAX(A.INOUT_KB) INOUT_KB ,  ")
                    .AppendLine("        MAX(A.VENDOR_CD) VENDOR_CD ,  ")
                    .AppendLine("        MAX(A.VENDOR_NM) VENDOR_NM ,  ")
                    .AppendLine("        MAX(A.BLS_ITEM_CD) BLS_ITEM_CD ,  ")
                    .AppendLine("        MAX(A.BLS_ITEM_NM) BLS_ITEM_NM ,  ")
                    .AppendLine("        MAX(A.ITEM_MNG_DATE) ITEM_MNG_DATE ,  ")
                    .AppendLine("        MAX(A.CS_CARTON) CS_CARTON ,  ")
                    .AppendLine("        MAX(A.EXP_CS_QTY)  AS EXP_CS_QTY ,  ")
                    .AppendLine("        MAX(A.EXP_PL_QTY)  AS EXP_PL_QTY ,  ")
                    .AppendLine("        MAX(A.EXP_SPL_QTY) AS EXP_SPL_QTY ,  ")
                    .AppendLine("        MAX(A.NEW_INV_DATE) NEW_INV_DATE ,  ")
                    .AppendLine("        MAX(A.REJECT_KB) REJECT_KB ,  ")
                    .AppendLine("        MAX(A.INPLAN_NO) INPLAN_NO ,  ")
                    .AppendLine("        MAX(A.LOC_CD) LOC_CD ,  ")
                    .AppendLine("        MAX(A.JAN_CD) JAN_CD ,  ")
                    .AppendLine("        MAX(A.CS_JAN_CD) CS_JAN_CD ,  ")
                    .AppendLine("        MAX(A.ITF_CD) ITF_CD  ")
                    .AppendLine("      FROM  ")
                    .AppendLine("            T_INPLAN  A  ")
                    .AppendLine("      INNER JOIN  ")
                    .AppendLine("            T_INRES   B  ")
                    .AppendLine("         ON		A.SYS_CD	=	B.SYS_CD  ")
                    .AppendLine("  	    AND		A.CENTER_CD	=	B.CENTER_CD	  ")
                    .AppendLine("   	    AND		A.FILE_ID	=	B.FILE_ID  ")
                    .AppendLine("   	    AND		A.FILE_LINE_NO	=	B.FILE_LINE_NO  ")
                    .AppendLine("   	    AND		A.CENTER_CD     =   B.CENTER_CD  ")
                    .AppendLine("   	    AND		A.INPLAN_DATE	=	B.INPLAN_DATE  ")
                    .AppendLine("         AND		A.INPLAN_NO	    =	B.INPLAN_NO  ")
                    .AppendLine("      WHERE  ")
                    .AppendLine("                   A.SYS_CD	     =	:SYS_CD  ")
                    .AppendLine("          AND	 A.CENTER_CD	 =	:CENTER_CD ")
                    .AppendLine("          AND     A.WORK_STS     <> 9	  ")
                    .AppendLine("          AND     A.INPLAN_DATE	 =	:SHIP_DATE ")
                    .AppendLine("          AND     A.DATE_MNG_FLG = '3'   ")
                    ' .AppendLine("          AND to_number( trim(B.ITEM_MNG_DATE || '0') ) <= to_number(TO_CHAR( sysdate, 'YYYYMMDD') || '0')  ")
                    .AppendLine("          AND B.ITEM_MNG_DATE <=  TO_CHAR( sysdate, 'YYYYMMDD')  ")
                    .AppendLine("      GROUP BY  ")
                    .AppendLine("          A.SYS_CD,  ")
                    .AppendLine("        A.FILE_ID,  ")
                    .AppendLine("        A.FILE_LINE_NO  ")
                    .AppendLine("        ) S1  ")
                    .AppendLine("       inner join  ")
                    .AppendLine("       (SELECT  ")
                    .AppendLine("           A.SYS_CD,  ")
                    .AppendLine("        A.FILE_ID,  ")
                    .AppendLine("        A.FILE_LINE_NO ,  ")
                    .AppendLine("        SUM(B.ACT_CS_QTY)  AS ACT_CS_QTY ,  ")
                    .AppendLine("        SUM(B.ACT_PS_QTY)  AS ACT_PS_QTY ,  ")
                    .AppendLine("        SUM(B.ACT_SPS_QTY) AS ACT_SPS_QTY  ")
                    .AppendLine("      FROM  ")
                    .AppendLine("            T_INPLAN  A  ")
                    .AppendLine("      INNER JOIN  ")
                    .AppendLine("            T_INRES   B  ")
                    .AppendLine("         ON		A.SYS_CD	=	B.SYS_CD  ")
                    .AppendLine("  	    AND		A.CENTER_CD	=	B.CENTER_CD	  ")
                    .AppendLine("   	    AND		A.FILE_ID	=	B.FILE_ID  ")
                    .AppendLine("   	    AND		A.FILE_LINE_NO	=	B.FILE_LINE_NO  ")
                    .AppendLine("   	    AND		A.INPLAN_DATE	=	B.INPLAN_DATE  ")
                    .AppendLine("         AND		A.INPLAN_NO	    =	B.INPLAN_NO  ")
                    .AppendLine("      WHERE  ")
                    .AppendLine("                   A.SYS_CD	     =	:SYS_CD  ")
                    .AppendLine("          AND	 A.CENTER_CD	 =	:CENTER_CD  ")
                    .AppendLine("          AND     A.WORK_STS     <> 9	  ")
                    .AppendLine("          AND     A.INPLAN_DATE	 =	:SHIP_DATE  ")
                    .AppendLine("          AND     A.DATE_MNG_FLG = '3'          ")
                    .AppendLine("      GROUP BY  ")
                    .AppendLine("           A.SYS_CD, A.FILE_ID, A.FILE_LINE_NO ) S2       ")
                    .AppendLine("       ON S1.SYS_CD   = S2.SYS_CD  ")
                    .AppendLine("  AND S1.FILE_ID      = S2.FILE_ID  ")
                    .AppendLine("  AND S1.FILE_LINE_NO = S2.FILE_LINE_NO  ")
                    .AppendLine("         ")
                    .AppendLine("     ")
                    .AppendLine("  UNION ")

                    '４．予定の総バラ数≠実績の総バラ数（合計）
                    .AppendLine("  SELECT * FROM (")
                    .AppendLine("    SELECT")
                    .AppendLine("        A.WORK_STS")
                    .AppendLine("        , A.INOUT_KB")
                    .AppendLine("        , A.VENDOR_CD")
                    .AppendLine("        , A.VENDOR_NM")
                    .AppendLine("        , A.BLS_ITEM_CD")
                    .AppendLine("        , A.BLS_ITEM_NM")
                    .AppendLine("        , A.ITEM_MNG_DATE")
                    .AppendLine("        , A.CS_CARTON")
                    .AppendLine("        , MAX(A.EXP_CS_QTY)  AS EXP_CS_QTY")
                    .AppendLine("        , MAX(A.EXP_PL_QTY)  AS EXP_PL_QTY")
                    .AppendLine("        , MAX(A.EXP_SPL_QTY) AS EXP_SPL_QTY")
                    .AppendLine("        , SUM(B.ACT_CS_QTY)  AS ACT_CS_QTY")
                    .AppendLine("        , SUM(B.ACT_PS_QTY)  AS ACT_PS_QTY")
                    .AppendLine("        , SUM(B.ACT_SPS_QTY) AS ACT_SPS_QTY")
                    .AppendLine("        , A.NEW_INV_DATE")
                    .AppendLine("        , A.REJECT_KB")
                    .AppendLine("        , A.INPLAN_NO")
                    .AppendLine("        , A.LOC_CD")
                    .AppendLine("        , A.JAN_CD")
                    .AppendLine("        , A.CS_JAN_CD")
                    .AppendLine("        , A.ITF_CD")
                    .AppendLine("        , A.FILE_ID")
                    .AppendLine("        , A.FILE_LINE_NO")
                    .AppendLine("    FROM")
                    .AppendLine("          T_INPLAN  A")
                    '.AppendLine("    LEFT JOIN")
                    .AppendLine("    INNER JOIN")    ' update  t.y
                    .AppendLine("          T_INRES   B")
                    .AppendLine("       ON		A.SYS_CD	=	B.SYS_CD")
                    .AppendLine("	    AND		A.CENTER_CD	=	B.CENTER_CD	")
                    .AppendLine(" 	    AND		A.FILE_ID	=	B.FILE_ID")
                    .AppendLine(" 	    AND		A.FILE_LINE_NO	=	B.FILE_LINE_NO")
                    .AppendLine(" 	    AND		A.CENTER_CD     =   B.CENTER_CD")
                    .AppendLine(" 	    AND		A.INPLAN_DATE	=	B.INPLAN_DATE")
                    .AppendLine("       AND		A.INPLAN_NO	    =	B.INPLAN_NO")
                    .AppendLine("    WHERE")
                    .AppendLine("                A.SYS_CD	      =	 :SYS_CD ")
                    .AppendLine("        AND	 A.CENTER_CD	  =	 :CENTER_CD	")
                    .AppendLine("        AND     A.WORK_STS       <> 9 ")                  'ステータス 9以外であること
                    .AppendLine("        AND     A.INPLAN_DATE	  =	 :SHIP_DATE ")
                    .AppendLine("        AND     A.DATE_MNG_FLG   in ('1','2','3') ")
                    '.AppendLine("        AND     A.ITEM_MNG_DATE  =  ' ' ")            'Delete t.y
                    .AppendLine("    GROUP BY")
                    .AppendLine("         A.SYS_CD, A.FILE_ID, A.FILE_LINE_NO, A.CENTER_CD")
                    .AppendLine("         , A.WORK_STS")
                    .AppendLine("         , A.INOUT_KB")
                    .AppendLine("         , A.INPLAN_NO")
                    .AppendLine("        , A.VENDOR_NM")
                    .AppendLine("        , A.VENDOR_CD")
                    .AppendLine("        , A.ITF_CD")
                    .AppendLine("        , A.BLS_ITEM_CD")
                    .AppendLine("        , A.BLS_ITEM_NM")
                    .AppendLine("        , A.LOC_CD")
                    .AppendLine("        , A.ITEM_MNG_DATE")
                    .AppendLine("        , A.REJECT_KB")
                    .AppendLine("        , A.JAN_CD")
                    .AppendLine("        , A.CS_JAN_CD")
                    .AppendLine("        , A.NEW_INV_DATE")
                    .AppendLine("        , A.CS_CARTON")
                    .AppendLine("  ) DD")
                    .AppendLine("  WHERE EXP_SPL_QTY <>  ACT_SPS_QTY")

                  
                    .AppendLine(") ALLDATA ")
                    .AppendLine(" WHERE ")
                    .AppendLine("       WORK_STS <> 9	")                  'ステータス 9以外であること
                    If Not String.IsNullOrEmpty(pParam.NyuYotNo) Then
                        .AppendLine("   AND INPLAN_NO LIKE :NYUYOTNO || '%'") '入荷予定NO
                    End If
                    If Not String.IsNullOrEmpty(pParam.Bls_Item_Cd) Then
                        .AppendLine("   AND BLS_ITEM_CD LIKE :BLS_ITEM_CD || '%'") '商品BLSコード
                    End If
                    If Not String.IsNullOrEmpty(pParam.Status) Then
                        .AppendLine("   AND WORK_STS			=	:STATUS") 'ステータス
                    End If
                    If Not String.IsNullOrEmpty(pParam.Bls_Item_Nm) Then
                        .AppendLine("   AND  BLS_ITEM_NM LIKE '%' || :BLS_ITEM_NM || '%'") '商品名称
                    End If
                    If Not String.IsNullOrEmpty(pParam.Nyuka_Kb) Then
                        .AppendLine("   AND INOUT_KB			=	:NYUKBN") '入荷区分
                    End If
                    If Not String.IsNullOrEmpty(pParam.Location) Then
                        .AppendLine("   AND LOC_CD LIKE :LOC_CD || '%'") 'ロケーション
                    End If
                    If Not String.IsNullOrEmpty(pParam.VendorCd) Then
                        .AppendLine("   AND VENDOR_CD LIKE :VENDOR_CD || '%'") '発地コード
                    End If
                    If Not String.IsNullOrEmpty(pParam.VendorNm) Then
                        .AppendLine("   AND  VENDOR_NM LIKE '%' || :VENDOR_NM || '%'") '発地名称
                    End If

                    If Not String.IsNullOrEmpty(pParam.RejectKb) Then
                        '.AppendLine("   AND REJECT_KB  <>	:REJECT_KB") '不良品区分
                        .AppendLine("   AND TRIM(REJECT_KB) IS NOT NULL")
                        ' oracle "IS NULL" match ""(empty string). TRIM() change " " to ""
                    End If

                    If Not String.IsNullOrEmpty(pParam.Warning) Then
                        .AppendLine("   AND 1  =	:WARNING") 'Warning Flg
                    End If

                    .AppendLine(" ORDER BY")
                    .AppendLine(" VENDOR_CD")
                    .AppendLine(" ,	BLS_ITEM_CD ")
                    .AppendLine(" ,	REJECT_KB ")
                    .AppendLine(" ,	ITEM_MNG_DATE ")
                    .AppendLine(" , INPLAN_NO")
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
                    .AppendLine("AND   CODE     <> :CODE")          'コード
                    '.AppendLine("AND   CODE     <>  'HEADER'")
                    If Not pstrSysCd.Equals(String.Empty) Then
                        .AppendLine("AND   SYS_CD  = :SYS_CD")      'システムコード
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
        ''' 入荷区分取得用SQL文を生成します。
        ''' </summary>
        ''' <param name="Param">sql stored parameter</param>
        ''' <returns>SQL文</returns>
        ''' <remarks></remarks>
        ''' <history>Arche Info. 2019/09/30 Created</history>
        Private Function FindNyukaKbnSQL(ByVal Param As FindNyukaKb) As String
            Dim strSql As New StringBuilder
            Try
                'SQL生成
                With strSql
                    .AppendLine("SELECT DISTINCT")
                    .AppendLine("      CODE_NM")       'コード

                    .AppendLine("    , SYS_CD")    'コード名称
                    .AppendLine("FROM  M_CODE")
                    .AppendLine("WHERE CODE  = :CODE ")      'コードキー

                    .AppendLine("AND   SYS_CD  = :SYS_CD")      'システムコード



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

#Region " FindStatusSQL "
        ''' <summary>
        ''' ロケーション（ゾーン）検索用SQL文を生成します。
        ''' </summary>
        ''' <param name="Param">sql place holder parameters</param>
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
                    .AppendLine("AND   CODE_KEY  = :CODE_KEY")      'システムコード

                    .AppendLine("AND   SYS_CD  = :SYS_CD")      'システムコード



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
