Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVSMSS110_01
        Inherits VWS.VSMS.VSMSLib.Base.Form.frmVSMSBase004

        'Form は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Windows フォーム デザイナで必要です。
        Private components As System.ComponentModel.IContainer

        'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
        'Windows フォーム デザイナを使用して変更できます。  
        'コード エディタを使って変更しないでください。
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Me.btnDownload = New System.Windows.Forms.Button
            Me.btnSearch = New System.Windows.Forms.Button
            Me.btnClear = New System.Windows.Forms.Button
            Me.dgvMsi = New VWS.iSenseOpenLib.VariedDataGridView(Me.components)
            Me.colDetail = New System.Windows.Forms.DataGridViewButtonColumn
            Me.colWorkStsVal = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colArrivalKbn = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colVendorCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colVendorNm = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colBlsItemCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colBlsItemNm = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colItemMngDate = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colCsCarton = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colExpCsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colExpPsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colExpSpsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActCsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActPsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActSpsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colWarMngDate = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colRejKb = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colInplanNo = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colLocCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colJanCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colCsJanCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colItfCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colFILE_ID = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colFILE_LINE_NO = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colPicZone = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colPreUpdYb = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colWorkSts2 = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colWorkStsHidden = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colWrokSts = New System.Windows.Forms.DataGridViewCheckBoxColumn
            Me.dgvMsiDtl = New VWS.iSenseOpenLib.VariedDataGridView(Me.components)
            Me.colItemMngDateDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colBlsItemNmDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colCsCartonDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActCsQtyDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActPsQtyDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActSpsQtyDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colWorkUserNmDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colPicDateTimeDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActuSend = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.lblArrivalDate = New System.Windows.Forms.Label
            Me.datShipDate = New VWS.iSenseOpenLib.CutBlankDateFromTo
            Me.lblBlsDeliCd = New System.Windows.Forms.Label
            Me.lblJanCd = New System.Windows.Forms.Label
            Me.txtVendorCD = New VWS.iSenseOpenLib.VariedTextBox
            Me.lblBlsDeliNm = New System.Windows.Forms.Label
            Me.txtVendorNm = New VWS.iSenseOpenLib.VariedTextBox
            Me.lblItemNm = New System.Windows.Forms.Label
            Me.txtItemNm = New VWS.iSenseOpenLib.VariedTextBox
            Me.lblItfCd = New System.Windows.Forms.Label
            Me.txtInplanNo = New VWS.iSenseOpenLib.VariedTextBox
            Me.lblWorkSts = New System.Windows.Forms.Label
            Me.cmbWorkSts = New VWS.iSenseOpenLib.NamedComboBox(Me.components)
            Me.lblBlsItemCd = New System.Windows.Forms.Label
            Me.txtBlsItemCd = New VWS.iSenseOpenLib.VariedTextBox
            Me.lblWorkUserNm = New System.Windows.Forms.Label
            Me.txtWorkUserNm = New VWS.iSenseOpenLib.VariedTextBox
            Me.lblLocCd = New System.Windows.Forms.Label
            Me.txtLocCd = New VWS.iSenseOpenLib.VariedTextBox
            Me.cmbInOutKb = New VWS.iSenseOpenLib.NamedComboBox(Me.components)
            Me.ChkWarning = New System.Windows.Forms.CheckBox
            Me.ChkRejectKb = New System.Windows.Forms.CheckBox
            Me.pnlControl06.SuspendLayout()
            Me.pnlControl07.SuspendLayout()
            Me.pnlControl08.SuspendLayout()
            Me.pnlControl05.SuspendLayout()
            Me.pnlControl04.SuspendLayout()
            Me.pnlControl03.SuspendLayout()
            Me.pnlControl02.SuspendLayout()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBase.SuspendLayout()
            CType(Me.dgvMsi, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMsiDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblTotal_Ken
            '
            Me.lblTotal_Ken.Location = New System.Drawing.Point(821, 496)
            Me.lblTotal_Ken.Visible = False
            '
            'lblTotal
            '
            Me.lblTotal.Location = New System.Drawing.Point(728, 496)
            Me.lblTotal.Visible = False
            '
            'lblTotal_Title
            '
            Me.lblTotal_Title.Location = New System.Drawing.Point(679, 496)
            Me.lblTotal_Title.Visible = False
            '
            'btnReports
            '
            Me.btnReports.BackColor = System.Drawing.Color.DimGray
            Me.btnReports.ForeColor = System.Drawing.Color.White
            Me.btnReports.Location = New System.Drawing.Point(30, 2)
            Me.btnReports.Size = New System.Drawing.Size(10, 30)
            Me.btnReports.Visible = False
            '
            'btnNext
            '
            Me.btnNext.Location = New System.Drawing.Point(671, 98)
            Me.btnNext.Size = New System.Drawing.Size(10, 30)
            Me.btnNext.Visible = False
            '
            'btnPrev
            '
            Me.btnPrev.Location = New System.Drawing.Point(610, 98)
            Me.btnPrev.Size = New System.Drawing.Size(10, 30)
            Me.btnPrev.Visible = False
            '
            'lblMessage
            '
            Me.lblMessage.Visible = False
            '
            'pnlControl06
            '
            Me.pnlControl06.Location = New System.Drawing.Point(0, 45)
            Me.pnlControl06.Visible = False
            '
            'pnlControl07
            '
            Me.pnlControl07.Controls.Add(Me.ChkRejectKb)
            Me.pnlControl07.Controls.Add(Me.ChkWarning)
            Me.pnlControl07.Controls.Add(Me.cmbInOutKb)
            Me.pnlControl07.Controls.Add(Me.lblItemNm)
            Me.pnlControl07.Controls.Add(Me.txtLocCd)
            Me.pnlControl07.Controls.Add(Me.lblArrivalDate)
            Me.pnlControl07.Controls.Add(Me.lblLocCd)
            Me.pnlControl07.Controls.Add(Me.datShipDate)
            Me.pnlControl07.Controls.Add(Me.txtWorkUserNm)
            Me.pnlControl07.Controls.Add(Me.txtVendorCD)
            Me.pnlControl07.Controls.Add(Me.lblBlsDeliCd)
            Me.pnlControl07.Controls.Add(Me.lblWorkUserNm)
            Me.pnlControl07.Controls.Add(Me.lblJanCd)
            Me.pnlControl07.Controls.Add(Me.txtBlsItemCd)
            Me.pnlControl07.Controls.Add(Me.lblBlsItemCd)
            Me.pnlControl07.Controls.Add(Me.cmbWorkSts)
            Me.pnlControl07.Controls.Add(Me.lblWorkSts)
            Me.pnlControl07.Controls.Add(Me.lblBlsDeliNm)
            Me.pnlControl07.Controls.Add(Me.txtInplanNo)
            Me.pnlControl07.Controls.Add(Me.txtVendorNm)
            Me.pnlControl07.Controls.Add(Me.lblItfCd)
            Me.pnlControl07.Controls.Add(Me.txtItemNm)
            Me.pnlControl07.Location = New System.Drawing.Point(0, 77)
            Me.pnlControl07.Size = New System.Drawing.Size(1016, 94)
            '
            'pnlControl08
            '
            Me.pnlControl08.Controls.Add(Me.dgvMsi)
            Me.pnlControl08.Controls.Add(Me.dgvMsiDtl)
            Me.pnlControl08.Location = New System.Drawing.Point(0, 171)
            Me.pnlControl08.Size = New System.Drawing.Size(1016, 532)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnDeSelect, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnSelect, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnDelete, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnAdd, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.dgvMsiDtl, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal_Title, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.dgvMsi, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnPrev, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal_Ken, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnNext, 0)
            '
            'btnDeSelect
            '
            Me.btnDeSelect.Location = New System.Drawing.Point(154, 98)
            Me.btnDeSelect.Size = New System.Drawing.Size(10, 30)
            Me.btnDeSelect.Visible = False
            '
            'btnSelect
            '
            Me.btnSelect.Location = New System.Drawing.Point(30, 98)
            Me.btnSelect.Size = New System.Drawing.Size(10, 30)
            Me.btnSelect.Visible = False
            '
            'btnDelete
            '
            Me.btnDelete.Location = New System.Drawing.Point(497, 86)
            Me.btnDelete.Size = New System.Drawing.Size(10, 30)
            Me.btnDelete.Visible = False
            '
            'btnAdd
            '
            Me.btnAdd.Location = New System.Drawing.Point(805, 111)
            Me.btnAdd.Size = New System.Drawing.Size(10, 30)
            Me.btnAdd.TabIndex = 5
            Me.btnAdd.Visible = False
            '
            'pnlControl05
            '
            Me.pnlControl05.Controls.Add(Me.btnDownload)
            Me.pnlControl05.Controls.Add(Me.btnClear)
            Me.pnlControl05.Controls.Add(Me.btnSearch)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnSearch, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnClear, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnDownload, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnExit, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnReports, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnClose, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnMenu, 0)
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.DimGray
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.TabStop = True
            Me.btnClose.Text = "戻る"
            '
            'btnExit
            '
            Me.btnExit.BackColor = System.Drawing.Color.DimGray
            Me.btnExit.ForeColor = System.Drawing.Color.White
            Me.btnExit.Location = New System.Drawing.Point(20, 2)
            Me.btnExit.Size = New System.Drawing.Size(10, 30)
            Me.btnExit.Visible = False
            '
            'btnMenu
            '
            Me.btnMenu.BackColor = System.Drawing.Color.DimGray
            Me.btnMenu.ForeColor = System.Drawing.Color.White
            Me.btnMenu.TabStop = True
            Me.btnMenu.Text = "メニュー"
            '
            'lblMenu
            '
            Me.lblMenu.Text = "入荷実績照会"
            '
            'lblYmd
            '
            Me.lblYmd.Text = "2019/12/04 10:55:16"
            '
            'lblUser
            '
            Me.lblUser.Text = " / "
            '
            'pnlBase
            '
            Me.pnlBase.Size = New System.Drawing.Size(1016, 860)
            '
            'btnDownload
            '
            Me.btnDownload.BackColor = System.Drawing.Color.DimGray
            Me.btnDownload.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnDownload.ForeColor = System.Drawing.Color.White
            Me.btnDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnDownload.Location = New System.Drawing.Point(913, 3)
            Me.btnDownload.Name = "btnDownload"
            Me.btnDownload.Size = New System.Drawing.Size(100, 30)
            Me.btnDownload.TabIndex = 4
            Me.btnDownload.Text = "ダウンロード"
            Me.btnDownload.UseVisualStyleBackColor = False
            '
            'btnSearch
            '
            Me.btnSearch.BackColor = System.Drawing.Color.DimGray
            Me.btnSearch.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnSearch.ForeColor = System.Drawing.Color.White
            Me.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnSearch.Location = New System.Drawing.Point(704, 3)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(100, 30)
            Me.btnSearch.TabIndex = 2
            Me.btnSearch.Text = "検索"
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.DimGray
            Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.White
            Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnClear.Location = New System.Drawing.Point(810, 3)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(100, 30)
            Me.btnClear.TabIndex = 3
            Me.btnClear.Text = "クリア"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            'dgvMsi
            '
            Me.dgvMsi.ColumnHeadersHeight = 30
            Me.dgvMsi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDetail, Me.colWorkStsVal, Me.colArrivalKbn, Me.colVendorCd, Me.colVendorNm, Me.colBlsItemCd, Me.colBlsItemNm, Me.colItemMngDate, Me.colCsCarton, Me.colExpCsQty, Me.colExpPsQty, Me.colExpSpsQty, Me.colActCsQty, Me.colActPsQty, Me.colActSpsQty, Me.colWarMngDate, Me.colRejKb, Me.colInplanNo, Me.colLocCd, Me.colJanCd, Me.colCsJanCd, Me.colItfCd, Me.colFILE_ID, Me.colFILE_LINE_NO})
            Me.dgvMsi.EnableHeadersVisualStyles = False
            Me.dgvMsi.KeyAction = VWS.iSenseOpenLib.VariedDataGridView.KeyActions.NotSet
            Me.dgvMsi.Location = New System.Drawing.Point(20, 21)
            Me.dgvMsi.MoveEditCell = True
            Me.dgvMsi.Name = "dgvMsi"
            Me.dgvMsi.RowHeadersWidth = 40
            Me.dgvMsi.RowTemplate.Height = 21
            Me.dgvMsi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMsi.Size = New System.Drawing.Size(964, 263)
            Me.dgvMsi.TabIndex = 30
            Me.dgvMsi.TabStop = False
            '
            'colDetail
            '
            Me.colDetail.Frozen = True
            Me.colDetail.HeaderText = ""
            Me.colDetail.Name = "colDetail"
            Me.colDetail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colDetail.Text = "詳細"
            Me.colDetail.Width = 60
            '
            'colWorkStsVal
            '
            Me.colWorkStsVal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colWorkStsVal.EditBackColor = System.Drawing.SystemColors.Window
            Me.colWorkStsVal.Frozen = True
            Me.colWorkStsVal.HalfWidthCharacters = False
            Me.colWorkStsVal.HeaderText = "ステータス"
            Me.colWorkStsVal.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colWorkStsVal.InputComma = True
            Me.colWorkStsVal.MaxByteLength = 65535
            Me.colWorkStsVal.MaxMojiLength = 32767
            Me.colWorkStsVal.Name = "colWorkStsVal"
            Me.colWorkStsVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colWorkStsVal.Width = 80
            '
            'colArrivalKbn
            '
            Me.colArrivalKbn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colArrivalKbn.EditBackColor = System.Drawing.SystemColors.Window
            Me.colArrivalKbn.HalfWidthCharacters = False
            Me.colArrivalKbn.HeaderText = "入荷区分"
            Me.colArrivalKbn.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colArrivalKbn.InputComma = True
            Me.colArrivalKbn.MaxByteLength = 65535
            Me.colArrivalKbn.MaxMojiLength = 32767
            Me.colArrivalKbn.Name = "colArrivalKbn"
            Me.colArrivalKbn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colArrivalKbn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colArrivalKbn.Width = 85
            '
            'colVendorCd
            '
            Me.colVendorCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colVendorCd.EditBackColor = System.Drawing.SystemColors.Window
            Me.colVendorCd.HalfWidthCharacters = False
            Me.colVendorCd.HeaderText = "発地コード"
            Me.colVendorCd.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colVendorCd.InputComma = True
            Me.colVendorCd.MaxByteLength = 65535
            Me.colVendorCd.MaxMojiLength = 32767
            Me.colVendorCd.Name = "colVendorCd"
            Me.colVendorCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colVendorCd.Width = 90
            '
            'colVendorNm
            '
            Me.colVendorNm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colVendorNm.EditBackColor = System.Drawing.SystemColors.Window
            Me.colVendorNm.HalfWidthCharacters = False
            Me.colVendorNm.HeaderText = "発地名称"
            Me.colVendorNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colVendorNm.InputComma = True
            Me.colVendorNm.MaxByteLength = 65535
            Me.colVendorNm.MaxMojiLength = 32767
            Me.colVendorNm.Name = "colVendorNm"
            Me.colVendorNm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colVendorNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colVendorNm.Width = 90
            '
            'colBlsItemCd
            '
            Me.colBlsItemCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colBlsItemCd.EditBackColor = System.Drawing.SystemColors.Window
            Me.colBlsItemCd.HalfWidthCharacters = False
            Me.colBlsItemCd.HeaderText = "商品BLSコード"
            Me.colBlsItemCd.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colBlsItemCd.InputComma = True
            Me.colBlsItemCd.MaxByteLength = 65535
            Me.colBlsItemCd.MaxMojiLength = 32767
            Me.colBlsItemCd.Name = "colBlsItemCd"
            Me.colBlsItemCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colBlsItemCd.Width = 115
            '
            'colBlsItemNm
            '
            Me.colBlsItemNm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colBlsItemNm.EditBackColor = System.Drawing.SystemColors.Window
            Me.colBlsItemNm.HalfWidthCharacters = False
            Me.colBlsItemNm.HeaderText = "商品名称"
            Me.colBlsItemNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colBlsItemNm.InputComma = True
            Me.colBlsItemNm.MaxByteLength = 65535
            Me.colBlsItemNm.MaxMojiLength = 32767
            Me.colBlsItemNm.Name = "colBlsItemNm"
            Me.colBlsItemNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            '
            'colItemMngDate
            '
            Me.colItemMngDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colItemMngDate.EditBackColor = System.Drawing.SystemColors.Window
            Me.colItemMngDate.HalfWidthCharacters = False
            Me.colItemMngDate.HeaderText = "商品管理日"
            Me.colItemMngDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colItemMngDate.InputComma = True
            Me.colItemMngDate.MaxByteLength = 65535
            Me.colItemMngDate.MaxMojiLength = 32767
            Me.colItemMngDate.Name = "colItemMngDate"
            Me.colItemMngDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colItemMngDate.Width = 95
            '
            'colCsCarton
            '
            Me.colCsCarton.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colCsCarton.DefaultCellStyle = DataGridViewCellStyle1
            Me.colCsCarton.EditBackColor = System.Drawing.SystemColors.Window
            Me.colCsCarton.HalfWidthCharacters = False
            Me.colCsCarton.HeaderText = "入数"
            Me.colCsCarton.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colCsCarton.InputComma = True
            Me.colCsCarton.MaxByteLength = 65535
            Me.colCsCarton.MaxMojiLength = 32767
            Me.colCsCarton.Name = "colCsCarton"
            Me.colCsCarton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colCsCarton.Width = 40
            '
            'colExpCsQty
            '
            Me.colExpCsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colExpCsQty.DefaultCellStyle = DataGridViewCellStyle2
            Me.colExpCsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colExpCsQty.HalfWidthCharacters = False
            Me.colExpCsQty.HeaderText = "指示数(ケース)"
            Me.colExpCsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colExpCsQty.InputComma = True
            Me.colExpCsQty.MaxByteLength = 65535
            Me.colExpCsQty.MaxMojiLength = 32767
            Me.colExpCsQty.Name = "colExpCsQty"
            Me.colExpCsQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colExpCsQty.Width = 130
            '
            'colExpPsQty
            '
            Me.colExpPsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colExpPsQty.DefaultCellStyle = DataGridViewCellStyle3
            Me.colExpPsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colExpPsQty.HalfWidthCharacters = False
            Me.colExpPsQty.HeaderText = "指示数(バラ)"
            Me.colExpPsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colExpPsQty.InputComma = True
            Me.colExpPsQty.MaxByteLength = 65535
            Me.colExpPsQty.MaxMojiLength = 32767
            Me.colExpPsQty.Name = "colExpPsQty"
            Me.colExpPsQty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colExpPsQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colExpPsQty.Width = 130
            '
            'colExpSpsQty
            '
            Me.colExpSpsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colExpSpsQty.DefaultCellStyle = DataGridViewCellStyle4
            Me.colExpSpsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colExpSpsQty.HalfWidthCharacters = False
            Me.colExpSpsQty.HeaderText = "指示数(総バラ)"
            Me.colExpSpsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colExpSpsQty.InputComma = True
            Me.colExpSpsQty.MaxByteLength = 65535
            Me.colExpSpsQty.MaxMojiLength = 32767
            Me.colExpSpsQty.Name = "colExpSpsQty"
            Me.colExpSpsQty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colExpSpsQty.Width = 130
            '
            'colActCsQty
            '
            Me.colActCsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.Format = "N0"
            DataGridViewCellStyle5.NullValue = Nothing
            Me.colActCsQty.DefaultCellStyle = DataGridViewCellStyle5
            Me.colActCsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActCsQty.HalfWidthCharacters = False
            Me.colActCsQty.HeaderText = "実績数(ケース)"
            Me.colActCsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActCsQty.InputComma = True
            Me.colActCsQty.MaxByteLength = 65535
            Me.colActCsQty.MaxMojiLength = 32767
            Me.colActCsQty.Name = "colActCsQty"
            Me.colActCsQty.Width = 130
            '
            'colActPsQty
            '
            Me.colActPsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.Format = "N0"
            DataGridViewCellStyle6.NullValue = Nothing
            Me.colActPsQty.DefaultCellStyle = DataGridViewCellStyle6
            Me.colActPsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActPsQty.HalfWidthCharacters = False
            Me.colActPsQty.HeaderText = "実績数(バラ)"
            Me.colActPsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActPsQty.InputComma = True
            Me.colActPsQty.MaxByteLength = 65535
            Me.colActPsQty.MaxMojiLength = 32767
            Me.colActPsQty.Name = "colActPsQty"
            Me.colActPsQty.Width = 130
            '
            'colActSpsQty
            '
            Me.colActSpsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle7.Format = "N0"
            DataGridViewCellStyle7.NullValue = Nothing
            Me.colActSpsQty.DefaultCellStyle = DataGridViewCellStyle7
            Me.colActSpsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActSpsQty.HalfWidthCharacters = False
            Me.colActSpsQty.HeaderText = "実績数(総バラ)"
            Me.colActSpsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActSpsQty.InputComma = True
            Me.colActSpsQty.MaxByteLength = 65535
            Me.colActSpsQty.MaxMojiLength = 32767
            Me.colActSpsQty.Name = "colActSpsQty"
            Me.colActSpsQty.Width = 130
            '
            'colWarMngDate
            '
            Me.colWarMngDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colWarMngDate.EditBackColor = System.Drawing.SystemColors.Window
            Me.colWarMngDate.HalfWidthCharacters = False
            Me.colWarMngDate.HeaderText = "在庫最新管理日"
            Me.colWarMngDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colWarMngDate.InputComma = True
            Me.colWarMngDate.MaxByteLength = 65535
            Me.colWarMngDate.MaxMojiLength = 32767
            Me.colWarMngDate.Name = "colWarMngDate"
            Me.colWarMngDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colWarMngDate.Width = 150
            '
            'colRejKb
            '
            Me.colRejKb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colRejKb.EditBackColor = System.Drawing.SystemColors.Window
            Me.colRejKb.HalfWidthCharacters = False
            Me.colRejKb.HeaderText = "不良品区分"
            Me.colRejKb.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colRejKb.InputComma = True
            Me.colRejKb.MaxByteLength = 65535
            Me.colRejKb.MaxMojiLength = 32767
            Me.colRejKb.Name = "colRejKb"
            Me.colRejKb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colRejKb.Width = 120
            '
            'colInplanNo
            '
            Me.colInplanNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colInplanNo.EditBackColor = System.Drawing.SystemColors.Window
            Me.colInplanNo.HalfWidthCharacters = False
            Me.colInplanNo.HeaderText = "入荷予定No"
            Me.colInplanNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colInplanNo.InputComma = True
            Me.colInplanNo.MaxByteLength = 65535
            Me.colInplanNo.MaxMojiLength = 32767
            Me.colInplanNo.Name = "colInplanNo"
            Me.colInplanNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colInplanNo.Width = 120
            '
            'colLocCd
            '
            Me.colLocCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colLocCd.EditBackColor = System.Drawing.SystemColors.Window
            Me.colLocCd.HalfWidthCharacters = False
            Me.colLocCd.HeaderText = "ロケーション"
            Me.colLocCd.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colLocCd.InputComma = True
            Me.colLocCd.MaxByteLength = 65535
            Me.colLocCd.MaxMojiLength = 32767
            Me.colLocCd.Name = "colLocCd"
            Me.colLocCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colLocCd.Width = 90
            '
            'colJanCd
            '
            Me.colJanCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colJanCd.EditBackColor = System.Drawing.SystemColors.Window
            Me.colJanCd.HalfWidthCharacters = False
            Me.colJanCd.HeaderText = "単品JAN"
            Me.colJanCd.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colJanCd.InputComma = True
            Me.colJanCd.MaxByteLength = 65535
            Me.colJanCd.MaxMojiLength = 32767
            Me.colJanCd.Name = "colJanCd"
            Me.colJanCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            '
            'colCsJanCd
            '
            Me.colCsJanCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colCsJanCd.EditBackColor = System.Drawing.SystemColors.Window
            Me.colCsJanCd.HalfWidthCharacters = False
            Me.colCsJanCd.HeaderText = "ケースJAN"
            Me.colCsJanCd.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colCsJanCd.InputComma = True
            Me.colCsJanCd.MaxByteLength = 65535
            Me.colCsJanCd.MaxMojiLength = 32767
            Me.colCsJanCd.Name = "colCsJanCd"
            Me.colCsJanCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colCsJanCd.Width = 120
            '
            'colItfCd
            '
            Me.colItfCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colItfCd.EditBackColor = System.Drawing.SystemColors.Window
            Me.colItfCd.HalfWidthCharacters = False
            Me.colItfCd.HeaderText = "ITFコード"
            Me.colItfCd.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colItfCd.InputComma = True
            Me.colItfCd.MaxByteLength = 65535
            Me.colItfCd.MaxMojiLength = 32767
            Me.colItfCd.Name = "colItfCd"
            Me.colItfCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colItfCd.Width = 120
            '
            'colFILE_ID
            '
            Me.colFILE_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colFILE_ID.EditBackColor = System.Drawing.SystemColors.Window
            Me.colFILE_ID.HalfWidthCharacters = False
            Me.colFILE_ID.HeaderText = "FILE_ID"
            Me.colFILE_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colFILE_ID.InputComma = True
            Me.colFILE_ID.MaxByteLength = 65535
            Me.colFILE_ID.MaxMojiLength = 32767
            Me.colFILE_ID.Name = "colFILE_ID"
            Me.colFILE_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colFILE_ID.Visible = False
            Me.colFILE_ID.Width = 120
            '
            'colFILE_LINE_NO
            '
            Me.colFILE_LINE_NO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colFILE_LINE_NO.EditBackColor = System.Drawing.SystemColors.Window
            Me.colFILE_LINE_NO.HalfWidthCharacters = False
            Me.colFILE_LINE_NO.HeaderText = "FILE_LINE_NO"
            Me.colFILE_LINE_NO.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colFILE_LINE_NO.InputComma = True
            Me.colFILE_LINE_NO.MaxByteLength = 65535
            Me.colFILE_LINE_NO.MaxMojiLength = 32767
            Me.colFILE_LINE_NO.Name = "colFILE_LINE_NO"
            Me.colFILE_LINE_NO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colFILE_LINE_NO.Visible = False
            Me.colFILE_LINE_NO.Width = 120
            '
            'colPicZone
            '
            Me.colPicZone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colPicZone.EditBackColor = System.Drawing.SystemColors.Window
            Me.colPicZone.HalfWidthCharacters = False
            Me.colPicZone.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colPicZone.InputComma = True
            Me.colPicZone.MaxByteLength = 65535
            Me.colPicZone.MaxMojiLength = 32767
            Me.colPicZone.Name = "colPicZone"
            '
            'colPreUpdYb
            '
            Me.colPreUpdYb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colPreUpdYb.EditBackColor = System.Drawing.SystemColors.Window
            Me.colPreUpdYb.HalfWidthCharacters = False
            Me.colPreUpdYb.HeaderText = "PRE_UPD_YB"
            Me.colPreUpdYb.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colPreUpdYb.InputComma = True
            Me.colPreUpdYb.MaxByteLength = 65535
            Me.colPreUpdYb.MaxMojiLength = 32767
            Me.colPreUpdYb.Name = "colPreUpdYb"
            Me.colPreUpdYb.Visible = False
            '
            'colWorkSts2
            '
            Me.colWorkSts2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colWorkSts2.EditBackColor = System.Drawing.SystemColors.Window
            Me.colWorkSts2.HalfWidthCharacters = False
            Me.colWorkSts2.HeaderText = "WORK_STS"
            Me.colWorkSts2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colWorkSts2.InputComma = True
            Me.colWorkSts2.MaxByteLength = 65535
            Me.colWorkSts2.MaxMojiLength = 32767
            Me.colWorkSts2.Name = "colWorkSts2"
            Me.colWorkSts2.Visible = False
            '
            'colWorkStsHidden
            '
            Me.colWorkStsHidden.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colWorkStsHidden.EditBackColor = System.Drawing.SystemColors.Window
            Me.colWorkStsHidden.HalfWidthCharacters = False
            Me.colWorkStsHidden.HeaderText = "WORK_STS_HID"
            Me.colWorkStsHidden.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colWorkStsHidden.InputComma = True
            Me.colWorkStsHidden.MaxByteLength = 65535
            Me.colWorkStsHidden.MaxMojiLength = 32767
            Me.colWorkStsHidden.Name = "colWorkStsHidden"
            Me.colWorkStsHidden.Visible = False
            '
            'colWrokSts
            '
            Me.colWrokSts.Frozen = True
            Me.colWrokSts.HeaderText = "欠品"
            Me.colWrokSts.Name = "colWrokSts"
            Me.colWrokSts.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colWrokSts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colWrokSts.Width = 40
            '
            'dgvMsiDtl
            '
            Me.dgvMsiDtl.ColumnHeadersHeight = 30
            Me.dgvMsiDtl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemMngDateDtl, Me.colBlsItemNmDtl, Me.colCsCartonDtl, Me.colActCsQtyDtl, Me.colActPsQtyDtl, Me.colActSpsQtyDtl, Me.colWorkUserNmDtl, Me.colPicDateTimeDtl, Me.colActuSend})
            Me.dgvMsiDtl.EnableHeadersVisualStyles = False
            Me.dgvMsiDtl.KeyAction = VWS.iSenseOpenLib.VariedDataGridView.KeyActions.NotSet
            Me.dgvMsiDtl.Location = New System.Drawing.Point(20, 303)
            Me.dgvMsiDtl.MoveEditCell = True
            Me.dgvMsiDtl.Name = "dgvMsiDtl"
            Me.dgvMsiDtl.RowHeadersWidth = 40
            Me.dgvMsiDtl.RowTemplate.Height = 21
            Me.dgvMsiDtl.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMsiDtl.Size = New System.Drawing.Size(964, 158)
            Me.dgvMsiDtl.TabIndex = 31
            Me.dgvMsiDtl.TabStop = False
            '
            'colItemMngDateDtl
            '
            Me.colItemMngDateDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colItemMngDateDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colItemMngDateDtl.HalfWidthCharacters = False
            Me.colItemMngDateDtl.HeaderText = "商品管理日"
            Me.colItemMngDateDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colItemMngDateDtl.InputComma = True
            Me.colItemMngDateDtl.MaxByteLength = 65535
            Me.colItemMngDateDtl.MaxMojiLength = 32767
            Me.colItemMngDateDtl.Name = "colItemMngDateDtl"
            Me.colItemMngDateDtl.ReadOnly = True
            Me.colItemMngDateDtl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colItemMngDateDtl.Width = 95
            '
            'colBlsItemNmDtl
            '
            Me.colBlsItemNmDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colBlsItemNmDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colBlsItemNmDtl.HalfWidthCharacters = False
            Me.colBlsItemNmDtl.HeaderText = "商品名称"
            Me.colBlsItemNmDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colBlsItemNmDtl.InputComma = True
            Me.colBlsItemNmDtl.MaxByteLength = 65535
            Me.colBlsItemNmDtl.MaxMojiLength = 32767
            Me.colBlsItemNmDtl.Name = "colBlsItemNmDtl"
            Me.colBlsItemNmDtl.ReadOnly = True
            Me.colBlsItemNmDtl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colBlsItemNmDtl.Width = 180
            '
            'colCsCartonDtl
            '
            Me.colCsCartonDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle8.Format = "N0"
            DataGridViewCellStyle8.NullValue = Nothing
            Me.colCsCartonDtl.DefaultCellStyle = DataGridViewCellStyle8
            Me.colCsCartonDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colCsCartonDtl.HalfWidthCharacters = False
            Me.colCsCartonDtl.HeaderText = "入数"
            Me.colCsCartonDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colCsCartonDtl.InputComma = True
            Me.colCsCartonDtl.MaxByteLength = 65535
            Me.colCsCartonDtl.MaxMojiLength = 32767
            Me.colCsCartonDtl.Name = "colCsCartonDtl"
            Me.colCsCartonDtl.ReadOnly = True
            Me.colCsCartonDtl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colCsCartonDtl.Width = 40
            '
            'colActCsQtyDtl
            '
            Me.colActCsQtyDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.Format = "N0"
            DataGridViewCellStyle9.NullValue = Nothing
            Me.colActCsQtyDtl.DefaultCellStyle = DataGridViewCellStyle9
            Me.colActCsQtyDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActCsQtyDtl.HalfWidthCharacters = False
            Me.colActCsQtyDtl.HeaderText = "実績数(ケース)"
            Me.colActCsQtyDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActCsQtyDtl.InputComma = True
            Me.colActCsQtyDtl.MaxByteLength = 65535
            Me.colActCsQtyDtl.MaxMojiLength = 32767
            Me.colActCsQtyDtl.Name = "colActCsQtyDtl"
            Me.colActCsQtyDtl.ReadOnly = True
            Me.colActCsQtyDtl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colActCsQtyDtl.Width = 110
            '
            'colActPsQtyDtl
            '
            Me.colActPsQtyDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle10.Format = "N0"
            DataGridViewCellStyle10.NullValue = Nothing
            Me.colActPsQtyDtl.DefaultCellStyle = DataGridViewCellStyle10
            Me.colActPsQtyDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActPsQtyDtl.HalfWidthCharacters = False
            Me.colActPsQtyDtl.HeaderText = "実績数(バラ)"
            Me.colActPsQtyDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActPsQtyDtl.InputComma = True
            Me.colActPsQtyDtl.MaxByteLength = 65535
            Me.colActPsQtyDtl.MaxMojiLength = 32767
            Me.colActPsQtyDtl.Name = "colActPsQtyDtl"
            Me.colActPsQtyDtl.ReadOnly = True
            Me.colActPsQtyDtl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colActPsQtyDtl.Width = 110
            '
            'colActSpsQtyDtl
            '
            Me.colActSpsQtyDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle11.Format = "N0"
            DataGridViewCellStyle11.NullValue = Nothing
            Me.colActSpsQtyDtl.DefaultCellStyle = DataGridViewCellStyle11
            Me.colActSpsQtyDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActSpsQtyDtl.HalfWidthCharacters = False
            Me.colActSpsQtyDtl.HeaderText = "実績数(総バラ)"
            Me.colActSpsQtyDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActSpsQtyDtl.InputComma = True
            Me.colActSpsQtyDtl.MaxByteLength = 65535
            Me.colActSpsQtyDtl.MaxMojiLength = 32767
            Me.colActSpsQtyDtl.Name = "colActSpsQtyDtl"
            Me.colActSpsQtyDtl.ReadOnly = True
            Me.colActSpsQtyDtl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colActSpsQtyDtl.Width = 120
            '
            'colWorkUserNmDtl
            '
            Me.colWorkUserNmDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colWorkUserNmDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colWorkUserNmDtl.HalfWidthCharacters = False
            Me.colWorkUserNmDtl.HeaderText = "作業者"
            Me.colWorkUserNmDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colWorkUserNmDtl.InputComma = True
            Me.colWorkUserNmDtl.MaxByteLength = 65535
            Me.colWorkUserNmDtl.MaxMojiLength = 32767
            Me.colWorkUserNmDtl.Name = "colWorkUserNmDtl"
            Me.colWorkUserNmDtl.ReadOnly = True
            Me.colWorkUserNmDtl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colWorkUserNmDtl.Width = 90
            '
            'colPicDateTimeDtl
            '
            Me.colPicDateTimeDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colPicDateTimeDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colPicDateTimeDtl.HalfWidthCharacters = False
            Me.colPicDateTimeDtl.HeaderText = "作業時間"
            Me.colPicDateTimeDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colPicDateTimeDtl.InputComma = True
            Me.colPicDateTimeDtl.MaxByteLength = 65535
            Me.colPicDateTimeDtl.MaxMojiLength = 32767
            Me.colPicDateTimeDtl.Name = "colPicDateTimeDtl"
            Me.colPicDateTimeDtl.ReadOnly = True
            Me.colPicDateTimeDtl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colPicDateTimeDtl.Width = 140
            '
            'colActuSend
            '
            Me.colActuSend.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colActuSend.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActuSend.HalfWidthCharacters = False
            Me.colActuSend.HeaderText = "実績送信"
            Me.colActuSend.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActuSend.InputComma = True
            Me.colActuSend.MaxByteLength = 65535
            Me.colActuSend.MaxMojiLength = 32767
            Me.colActuSend.Name = "colActuSend"
            Me.colActuSend.ReadOnly = True
            Me.colActuSend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colActuSend.Width = 140
            '
            'lblArrivalDate
            '
            Me.lblArrivalDate.AutoSize = True
            Me.lblArrivalDate.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblArrivalDate.ForeColor = System.Drawing.Color.Blue
            Me.lblArrivalDate.Location = New System.Drawing.Point(11, 14)
            Me.lblArrivalDate.Name = "lblArrivalDate"
            Me.lblArrivalDate.Size = New System.Drawing.Size(70, 12)
            Me.lblArrivalDate.TabIndex = 47
            Me.lblArrivalDate.Text = "入荷予定日"
            '
            'datShipDate
            '
            Me.datShipDate.EditColor = System.Drawing.Color.White
            Me.datShipDate.ErrorBackColor = System.Drawing.Color.Red
            Me.datShipDate.Format = VWS.iSenseOpenLib.CutBlankDateFromTo.Formats.FormatShort
            Me.datShipDate.FromBackColor = System.Drawing.Color.White
            Me.datShipDate.FromOnly = True
            Me.datShipDate.FromSize = 90
            Me.datShipDate.FromText = "2009/05/07"
            Me.datShipDate.FromValue = New Date(2009, 5, 7, 15, 50, 52, 453)
            Me.datShipDate.Location = New System.Drawing.Point(87, 9)
            Me.datShipDate.Name = "datShipDate"
            Me.datShipDate.Size = New System.Drawing.Size(92, 21)
            Me.datShipDate.TabIndex = 10
            Me.datShipDate.ToBackColor = System.Drawing.Color.White
            Me.datShipDate.ToText = "2009/05/07"
            Me.datShipDate.ToValue = New Date(2009, 5, 7, 15, 51, 21, 250)
            '
            'lblBlsDeliCd
            '
            Me.lblBlsDeliCd.AutoSize = True
            Me.lblBlsDeliCd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblBlsDeliCd.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblBlsDeliCd.Location = New System.Drawing.Point(185, 13)
            Me.lblBlsDeliCd.Name = "lblBlsDeliCd"
            Me.lblBlsDeliCd.Size = New System.Drawing.Size(57, 12)
            Me.lblBlsDeliCd.TabIndex = 47
            Me.lblBlsDeliCd.Text = "発地名称"
            '
            'lblJanCd
            '
            Me.lblJanCd.AutoSize = True
            Me.lblJanCd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblJanCd.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblJanCd.Location = New System.Drawing.Point(826, 13)
            Me.lblJanCd.Name = "lblJanCd"
            Me.lblJanCd.Size = New System.Drawing.Size(57, 12)
            Me.lblJanCd.TabIndex = 48
            Me.lblJanCd.Text = "入荷区分"
            '
            'txtVendorCD
            '
            Me.txtVendorCD.HalfWidthCharacters = False
            Me.txtVendorCD.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtVendorCD.InputComma = True
            Me.txtVendorCD.Location = New System.Drawing.Point(530, 9)
            Me.txtVendorCD.MaxByteLength = 5
            Me.txtVendorCD.MaxMojiLength = 5
            Me.txtVendorCD.Name = "txtVendorCD"
            Me.txtVendorCD.Size = New System.Drawing.Size(79, 19)
            Me.txtVendorCD.TabIndex = 12
            Me.txtVendorCD.Text = "12345"
            '
            'lblBlsDeliNm
            '
            Me.lblBlsDeliNm.AutoSize = True
            Me.lblBlsDeliNm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblBlsDeliNm.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblBlsDeliNm.Location = New System.Drawing.Point(463, 12)
            Me.lblBlsDeliNm.Name = "lblBlsDeliNm"
            Me.lblBlsDeliNm.Size = New System.Drawing.Size(61, 12)
            Me.lblBlsDeliNm.TabIndex = 52
            Me.lblBlsDeliNm.Text = "発地コード"
            '
            'txtVendorNm
            '
            Me.txtVendorNm.HalfWidthCharacters = False
            Me.txtVendorNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.txtVendorNm.InputComma = True
            Me.txtVendorNm.Location = New System.Drawing.Point(248, 10)
            Me.txtVendorNm.MaxByteLength = 120
            Me.txtVendorNm.MaxMojiLength = 60
            Me.txtVendorNm.Name = "txtVendorNm"
            Me.txtVendorNm.Size = New System.Drawing.Size(209, 19)
            Me.txtVendorNm.TabIndex = 11
            Me.txtVendorNm.Text = "WWWWWWWWWWWWWWWWWWWW"
            '
            'lblItemNm
            '
            Me.lblItemNm.AutoSize = True
            Me.lblItemNm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblItemNm.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblItemNm.Location = New System.Drawing.Point(11, 42)
            Me.lblItemNm.Name = "lblItemNm"
            Me.lblItemNm.Size = New System.Drawing.Size(57, 12)
            Me.lblItemNm.TabIndex = 55
            Me.lblItemNm.Text = "商品名称"
            '
            'txtItemNm
            '
            Me.txtItemNm.HalfWidthCharacters = False
            Me.txtItemNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.txtItemNm.InputComma = True
            Me.txtItemNm.Location = New System.Drawing.Point(87, 39)
            Me.txtItemNm.MaxByteLength = 120
            Me.txtItemNm.MaxMojiLength = 60
            Me.txtItemNm.Name = "txtItemNm"
            Me.txtItemNm.Size = New System.Drawing.Size(264, 19)
            Me.txtItemNm.TabIndex = 15
            Me.txtItemNm.Text = "WWWWWWWWWWWWWWWWWWWW"
            '
            'lblItfCd
            '
            Me.lblItfCd.AutoSize = True
            Me.lblItfCd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblItfCd.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblItfCd.Location = New System.Drawing.Point(616, 42)
            Me.lblItfCd.Name = "lblItfCd"
            Me.lblItfCd.Size = New System.Drawing.Size(75, 12)
            Me.lblItfCd.TabIndex = 57
            Me.lblItfCd.Text = "入荷予定NO"
            '
            'txtInplanNo
            '
            Me.txtInplanNo.HalfWidthCharacters = False
            Me.txtInplanNo.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtInplanNo.InputComma = True
            Me.txtInplanNo.Location = New System.Drawing.Point(697, 39)
            Me.txtInplanNo.MaxByteLength = 16
            Me.txtInplanNo.MaxMojiLength = 16
            Me.txtInplanNo.Name = "txtInplanNo"
            Me.txtInplanNo.Size = New System.Drawing.Size(113, 19)
            Me.txtInplanNo.TabIndex = 17
            Me.txtInplanNo.Text = "1234567890123456"
            '
            'lblWorkSts
            '
            Me.lblWorkSts.AutoSize = True
            Me.lblWorkSts.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblWorkSts.Location = New System.Drawing.Point(636, 12)
            Me.lblWorkSts.Name = "lblWorkSts"
            Me.lblWorkSts.Size = New System.Drawing.Size(55, 12)
            Me.lblWorkSts.TabIndex = 47
            Me.lblWorkSts.Text = "ステータス"
            '
            'cmbWorkSts
            '
            Me.cmbWorkSts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cmbWorkSts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbWorkSts.FormattingEnabled = True
            Me.cmbWorkSts.Item1Width = 0
            Me.cmbWorkSts.Item2Width = 0
            Me.cmbWorkSts.Location = New System.Drawing.Point(697, 8)
            Me.cmbWorkSts.Name = "cmbWorkSts"
            Me.cmbWorkSts.ReadOnlyColor = System.Drawing.Color.Silver
            Me.cmbWorkSts.Size = New System.Drawing.Size(113, 20)
            Me.cmbWorkSts.TabIndex = 13
            '
            'lblBlsItemCd
            '
            Me.lblBlsItemCd.AutoSize = True
            Me.lblBlsItemCd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblBlsItemCd.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblBlsItemCd.Location = New System.Drawing.Point(410, 43)
            Me.lblBlsItemCd.Name = "lblBlsItemCd"
            Me.lblBlsItemCd.Size = New System.Drawing.Size(85, 12)
            Me.lblBlsItemCd.TabIndex = 59
            Me.lblBlsItemCd.Text = "商品BLSコード"
            '
            'txtBlsItemCd
            '
            Me.txtBlsItemCd.HalfWidthCharacters = False
            Me.txtBlsItemCd.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtBlsItemCd.InputComma = True
            Me.txtBlsItemCd.Location = New System.Drawing.Point(509, 39)
            Me.txtBlsItemCd.MaxByteLength = 8
            Me.txtBlsItemCd.MaxMojiLength = 8
            Me.txtBlsItemCd.Name = "txtBlsItemCd"
            Me.txtBlsItemCd.Size = New System.Drawing.Size(100, 19)
            Me.txtBlsItemCd.TabIndex = 16
            Me.txtBlsItemCd.Text = "12345678"
            '
            'lblWorkUserNm
            '
            Me.lblWorkUserNm.AutoSize = True
            Me.lblWorkUserNm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblWorkUserNm.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblWorkUserNm.Location = New System.Drawing.Point(194, 69)
            Me.lblWorkUserNm.Name = "lblWorkUserNm"
            Me.lblWorkUserNm.Size = New System.Drawing.Size(44, 12)
            Me.lblWorkUserNm.TabIndex = 61
            Me.lblWorkUserNm.Text = "作業者"
            '
            'txtWorkUserNm
            '
            Me.txtWorkUserNm.HalfWidthCharacters = False
            Me.txtWorkUserNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.txtWorkUserNm.InputComma = True
            Me.txtWorkUserNm.Location = New System.Drawing.Point(250, 67)
            Me.txtWorkUserNm.MaxByteLength = 200
            Me.txtWorkUserNm.MaxMojiLength = 100
            Me.txtWorkUserNm.Name = "txtWorkUserNm"
            Me.txtWorkUserNm.Size = New System.Drawing.Size(101, 19)
            Me.txtWorkUserNm.TabIndex = 20
            Me.txtWorkUserNm.Text = "WWWWWWWWWWWWWWWWWWWW"
            '
            'lblLocCd
            '
            Me.lblLocCd.AutoSize = True
            Me.lblLocCd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblLocCd.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblLocCd.Location = New System.Drawing.Point(821, 42)
            Me.lblLocCd.Name = "lblLocCd"
            Me.lblLocCd.Size = New System.Drawing.Size(64, 12)
            Me.lblLocCd.TabIndex = 63
            Me.lblLocCd.Text = "ロケーション"
            '
            'txtLocCd
            '
            Me.txtLocCd.HalfWidthCharacters = False
            Me.txtLocCd.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtLocCd.InputComma = True
            Me.txtLocCd.Location = New System.Drawing.Point(889, 39)
            Me.txtLocCd.MaxByteLength = 7
            Me.txtLocCd.MaxMojiLength = 7
            Me.txtLocCd.Name = "txtLocCd"
            Me.txtLocCd.Size = New System.Drawing.Size(113, 19)
            Me.txtLocCd.TabIndex = 18
            Me.txtLocCd.Text = "1234567"
            '
            'cmbInOutKb
            '
            Me.cmbInOutKb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cmbInOutKb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbInOutKb.FormattingEnabled = True
            Me.cmbInOutKb.Item1Width = 0
            Me.cmbInOutKb.Item2Width = 0
            Me.cmbInOutKb.Location = New System.Drawing.Point(889, 8)
            Me.cmbInOutKb.Name = "cmbInOutKb"
            Me.cmbInOutKb.ReadOnlyColor = System.Drawing.Color.Silver
            Me.cmbInOutKb.Size = New System.Drawing.Size(113, 20)
            Me.cmbInOutKb.TabIndex = 14
            '
            'ChkWarning
            '
            Me.ChkWarning.AutoSize = True
            Me.ChkWarning.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkWarning.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.ChkWarning.Location = New System.Drawing.Point(12, 67)
            Me.ChkWarning.Name = "ChkWarning"
            Me.ChkWarning.Size = New System.Drawing.Size(88, 16)
            Me.ChkWarning.TabIndex = 19
            Me.ChkWarning.Text = "ワーニングあり"
            Me.ChkWarning.UseVisualStyleBackColor = True
            '
            'ChkRejectKb
            '
            Me.ChkRejectKb.AutoSize = True
            Me.ChkRejectKb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ChkRejectKb.Location = New System.Drawing.Point(461, 68)
            Me.ChkRejectKb.Name = "ChkRejectKb"
            Me.ChkRejectKb.Size = New System.Drawing.Size(60, 16)
            Me.ChkRejectKb.TabIndex = 21
            Me.ChkRejectKb.Text = "不良品"
            Me.ChkRejectKb.UseVisualStyleBackColor = True
            '
            'frmVSMSS110_01
            '
            Me.ClientSize = New System.Drawing.Size(1016, 703)
            Me.Location = New System.Drawing.Point(0, 167)
            Me.Name = "frmVSMSS110_01"
            Me.Text = "frmVSMSS110_01 [  ]"
            Me.pnlControl06.ResumeLayout(False)
            Me.pnlControl07.ResumeLayout(False)
            Me.pnlControl07.PerformLayout()
            Me.pnlControl08.ResumeLayout(False)
            Me.pnlControl05.ResumeLayout(False)
            Me.pnlControl04.ResumeLayout(False)
            Me.pnlControl03.ResumeLayout(False)
            Me.pnlControl02.ResumeLayout(False)
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBase.ResumeLayout(False)
            CType(Me.dgvMsi, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMsiDtl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents btnClear As System.Windows.Forms.Button
        Public WithEvents btnSearch As System.Windows.Forms.Button
        Public WithEvents btnDownload As System.Windows.Forms.Button
        Friend WithEvents dgvMsi As VWS.iSenseOpenLib.VariedDataGridView
        Friend WithEvents dgvMsiDtl As VWS.iSenseOpenLib.VariedDataGridView
        Friend WithEvents txtLocCd As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblLocCd As System.Windows.Forms.Label
        Friend WithEvents txtWorkUserNm As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblWorkUserNm As System.Windows.Forms.Label
        Friend WithEvents txtBlsItemCd As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblBlsItemCd As System.Windows.Forms.Label
        Friend WithEvents cmbWorkSts As VWS.iSenseOpenLib.NamedComboBox
        Friend WithEvents lblWorkSts As System.Windows.Forms.Label
        Friend WithEvents txtInplanNo As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblItfCd As System.Windows.Forms.Label
        Friend WithEvents txtItemNm As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblItemNm As System.Windows.Forms.Label
        Friend WithEvents txtVendorNm As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblBlsDeliNm As System.Windows.Forms.Label
        Friend WithEvents txtVendorCD As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblJanCd As System.Windows.Forms.Label
        Friend WithEvents lblBlsDeliCd As System.Windows.Forms.Label
        Friend WithEvents datShipDate As VWS.iSenseOpenLib.CutBlankDateFromTo
        Friend WithEvents lblArrivalDate As System.Windows.Forms.Label
        Friend WithEvents colWrokSts As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents colPicZone As VWS.iSenseOpenLib.VariedTextBoxColumn


        Friend WithEvents colPreUpdYb As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colWorkSts2 As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colWorkStsHidden As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents cmbInOutKb As VWS.iSenseOpenLib.NamedComboBox
        Friend WithEvents ChkWarning As System.Windows.Forms.CheckBox
        Friend WithEvents ChkRejectKb As System.Windows.Forms.CheckBox
        Friend WithEvents colItemMngDateDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colBlsItemNmDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colCsCartonDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActCsQtyDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActPsQtyDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActSpsQtyDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colWorkUserNmDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colPicDateTimeDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActuSend As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colDetail As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents colWorkStsVal As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colArrivalKbn As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colVendorCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colVendorNm As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colBlsItemCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colBlsItemNm As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colItemMngDate As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colCsCarton As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colExpCsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colExpPsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colExpSpsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActCsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActPsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActSpsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colWarMngDate As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colRejKb As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colInplanNo As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colLocCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colJanCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colCsJanCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colItfCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colFILE_ID As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colFILE_LINE_NO As VWS.iSenseOpenLib.VariedTextBoxColumn

    End Class

End Namespace
