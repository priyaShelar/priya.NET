Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVSMSS310_01
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
            Dim DataGridViewCellStyle67 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle68 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle69 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle70 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle71 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle72 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle73 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle74 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle75 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle76 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Me.btnClear = New System.Windows.Forms.Button
            Me.btnSearch = New System.Windows.Forms.Button
            Me.dgvMsi = New VWS.iSenseOpenLib.VariedDataGridView(Me.components)
            Me.colWorkStsVal = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colPicZone = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colLocCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colBlsItemCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colBlsItemNm = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colItemMngDate = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colCsCartonDtl = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colExpCsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colExpPsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colExpSpsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colItemMngDateRes = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActCsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActPsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colActSpsQty = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colDiffCase = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colDiffBal = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colDiffTotBal = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colDefItem = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colTanaNo = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colJanCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colCsJanCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colItfCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colBlsDeliCd = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colBlsDeliNm = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colStartTime = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colEndTime = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colTotalCnt = New VWS.iSenseOpenLib.NumEditColumn
            Me.colCompCnt = New VWS.iSenseOpenLib.NumEditColumn
            Me.colProcPer = New VWS.iSenseOpenLib.NumEditColumn
            Me.colProc = New VWS.iSenseOpenLib.BarGraphColumn
            Me.colCompSpec = New VWS.iSenseOpenLib.NumEditColumn
            Me.colSpec = New VWS.iSenseOpenLib.NumEditColumn
            Me.lblBlsDeliCd = New System.Windows.Forms.Label
            Me.lblDeliNm = New System.Windows.Forms.Label
            Me.txtTanaOroshiNo = New VWS.iSenseOpenLib.VariedTextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtZone = New VWS.iSenseOpenLib.VariedTextBox
            Me.cmbTanaOroshiKbn = New VWS.iSenseOpenLib.NamedComboBox(Me.components)
            Me.btnResult = New System.Windows.Forms.Button
            Me.btnOutDifList = New System.Windows.Forms.Button
            Me.btnDownload = New System.Windows.Forms.Button
            Me.datShipDate = New VWS.iSenseOpenLib.CutBlankDateFromTo
            Me.lblProcDate = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.lblItemNm = New System.Windows.Forms.Label
            Me.txtItemNm = New VWS.iSenseOpenLib.VariedTextBox
            Me.lblItemMngDate = New System.Windows.Forms.Label
            Me.txtLocation = New VWS.iSenseOpenLib.VariedTextBox
            Me.cmbWorkSts = New VWS.iSenseOpenLib.NamedComboBox(Me.components)
            Me.lblBlsItemCd = New System.Windows.Forms.Label
            Me.txtBlsItemCd = New VWS.iSenseOpenLib.VariedTextBox
            Me.chkDiffren = New System.Windows.Forms.CheckBox
            Me.lblWorkUserNm = New System.Windows.Forms.Label
            Me.txtWorkUserNm = New VWS.iSenseOpenLib.VariedTextBox
            Me.ChkRejectKb = New System.Windows.Forms.CheckBox
            Me.cmbZaikoChk = New VWS.iSenseOpenLib.NamedComboBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label
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
            Me.SuspendLayout()
            '
            'lblTotal_Ken
            '
            Me.lblTotal_Ken.Location = New System.Drawing.Point(954, 465)
            Me.lblTotal_Ken.Visible = False
            '
            'lblTotal
            '
            Me.lblTotal.Location = New System.Drawing.Point(861, 465)
            Me.lblTotal.Visible = False
            '
            'lblTotal_Title
            '
            Me.lblTotal_Title.Location = New System.Drawing.Point(765, 465)
            Me.lblTotal_Title.Visible = False
            '
            'btnReports
            '
            Me.btnReports.Location = New System.Drawing.Point(263, 3)
            Me.btnReports.Size = New System.Drawing.Size(10, 30)
            Me.btnReports.Visible = False
            '
            'btnNext
            '
            Me.btnNext.Location = New System.Drawing.Point(963, 137)
            Me.btnNext.Size = New System.Drawing.Size(10, 30)
            Me.btnNext.Visible = False
            '
            'btnPrev
            '
            Me.btnPrev.Location = New System.Drawing.Point(954, 137)
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
            Me.pnlControl07.Controls.Add(Me.Label7)
            Me.pnlControl07.Controls.Add(Me.cmbZaikoChk)
            Me.pnlControl07.Controls.Add(Me.ChkRejectKb)
            Me.pnlControl07.Controls.Add(Me.txtWorkUserNm)
            Me.pnlControl07.Controls.Add(Me.lblWorkUserNm)
            Me.pnlControl07.Controls.Add(Me.chkDiffren)
            Me.pnlControl07.Controls.Add(Me.txtBlsItemCd)
            Me.pnlControl07.Controls.Add(Me.lblBlsItemCd)
            Me.pnlControl07.Controls.Add(Me.cmbWorkSts)
            Me.pnlControl07.Controls.Add(Me.txtLocation)
            Me.pnlControl07.Controls.Add(Me.lblItemMngDate)
            Me.pnlControl07.Controls.Add(Me.txtItemNm)
            Me.pnlControl07.Controls.Add(Me.lblItemNm)
            Me.pnlControl07.Controls.Add(Me.Label6)
            Me.pnlControl07.Controls.Add(Me.cmbTanaOroshiKbn)
            Me.pnlControl07.Controls.Add(Me.txtZone)
            Me.pnlControl07.Controls.Add(Me.Label1)
            Me.pnlControl07.Controls.Add(Me.txtTanaOroshiNo)
            Me.pnlControl07.Controls.Add(Me.datShipDate)
            Me.pnlControl07.Controls.Add(Me.lblDeliNm)
            Me.pnlControl07.Controls.Add(Me.lblBlsDeliCd)
            Me.pnlControl07.Controls.Add(Me.lblProcDate)
            Me.pnlControl07.Location = New System.Drawing.Point(0, 77)
            Me.pnlControl07.TabIndex = 1
            '
            'pnlControl08
            '
            Me.pnlControl08.Controls.Add(Me.dgvMsi)
            Me.pnlControl08.Location = New System.Drawing.Point(0, 203)
            Me.pnlControl08.Size = New System.Drawing.Size(1016, 510)
            Me.pnlControl08.TabIndex = 3
            Me.pnlControl08.Controls.SetChildIndex(Me.dgvMsi, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnSelect, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnDeSelect, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnAdd, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnDelete, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnPrev, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnNext, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal_Title, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal_Ken, 0)
            '
            'btnDeSelect
            '
            Me.btnDeSelect.Location = New System.Drawing.Point(40, 120)
            Me.btnDeSelect.Size = New System.Drawing.Size(10, 30)
            Me.btnDeSelect.Visible = False
            '
            'btnSelect
            '
            Me.btnSelect.Location = New System.Drawing.Point(24, 120)
            Me.btnSelect.Size = New System.Drawing.Size(10, 30)
            Me.btnSelect.Visible = False
            '
            'btnDelete
            '
            Me.btnDelete.Location = New System.Drawing.Point(72, 120)
            Me.btnDelete.Size = New System.Drawing.Size(10, 30)
            Me.btnDelete.Visible = False
            '
            'btnAdd
            '
            Me.btnAdd.Location = New System.Drawing.Point(56, 120)
            Me.btnAdd.Size = New System.Drawing.Size(10, 30)
            Me.btnAdd.TabIndex = 8
            Me.btnAdd.TabStop = True
            Me.btnAdd.Visible = False
            '
            'pnlControl05
            '
            Me.pnlControl05.Controls.Add(Me.btnDownload)
            Me.pnlControl05.Controls.Add(Me.btnOutDifList)
            Me.pnlControl05.Controls.Add(Me.btnResult)
            Me.pnlControl05.Controls.Add(Me.btnSearch)
            Me.pnlControl05.Controls.Add(Me.btnClear)
            Me.pnlControl05.TabIndex = 0
            Me.pnlControl05.Controls.SetChildIndex(Me.btnClear, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnSearch, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnResult, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnOutDifList, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnReports, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnClose, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnMenu, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnExit, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnDownload, 0)
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.DimGray
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.TabIndex = 2
            Me.btnClose.TabStop = True
            Me.btnClose.Text = "戻る"
            '
            'btnExit
            '
            Me.btnExit.Location = New System.Drawing.Point(247, 2)
            Me.btnExit.Size = New System.Drawing.Size(10, 30)
            Me.btnExit.Visible = False
            '
            'btnMenu
            '
            Me.btnMenu.BackColor = System.Drawing.Color.DimGray
            Me.btnMenu.ForeColor = System.Drawing.Color.White
            Me.btnMenu.TabIndex = 1
            Me.btnMenu.TabStop = True
            Me.btnMenu.Text = "メニュー"
            '
            'lblMenu
            '
            Me.lblMenu.Text = "棚卸実績照会"
            '
            'lblYmd
            '
            Me.lblYmd.Text = "2019/12/05 11:16:57"
            '
            'lblUser
            '
            Me.lblUser.Text = " / "
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.DimGray
            Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.White
            Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnClear.Location = New System.Drawing.Point(707, 2)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(100, 30)
            Me.btnClear.TabIndex = 4
            Me.btnClear.Text = "クリア"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            'btnSearch
            '
            Me.btnSearch.BackColor = System.Drawing.Color.DimGray
            Me.btnSearch.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnSearch.ForeColor = System.Drawing.Color.White
            Me.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnSearch.Location = New System.Drawing.Point(601, 2)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(100, 30)
            Me.btnSearch.TabIndex = 3
            Me.btnSearch.Text = "検索"
            Me.btnSearch.UseVisualStyleBackColor = False
            '
            'dgvMsi
            '
            Me.dgvMsi.AllowUserToAddRows = False
            DataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
            DataGridViewCellStyle67.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle67.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
            DataGridViewCellStyle67.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle67.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
            DataGridViewCellStyle67.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle67.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMsi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle67
            Me.dgvMsi.ColumnHeadersHeight = 30
            Me.dgvMsi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWorkStsVal, Me.colPicZone, Me.colLocCd, Me.colBlsItemCd, Me.colBlsItemNm, Me.colItemMngDate, Me.colCsCartonDtl, Me.colExpCsQty, Me.colExpPsQty, Me.colExpSpsQty, Me.colItemMngDateRes, Me.colActCsQty, Me.colActPsQty, Me.colActSpsQty, Me.colDiffCase, Me.colDiffBal, Me.colDiffTotBal, Me.colDefItem, Me.colTanaNo, Me.colJanCd, Me.colCsJanCd, Me.colItfCd})
            Me.dgvMsi.EnableHeadersVisualStyles = False
            Me.dgvMsi.KeyAction = VWS.iSenseOpenLib.VariedDataGridView.KeyActions.NotSet
            Me.dgvMsi.Location = New System.Drawing.Point(16, 3)
            Me.dgvMsi.MoveEditCell = True
            Me.dgvMsi.Name = "dgvMsi"
            Me.dgvMsi.ReadOnly = True
            Me.dgvMsi.RowHeadersWidth = 60
            Me.dgvMsi.RowTemplate.Height = 21
            Me.dgvMsi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMsi.Size = New System.Drawing.Size(963, 490)
            Me.dgvMsi.TabIndex = 1
            Me.dgvMsi.TabStop = False
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
            Me.colWorkStsVal.ReadOnly = True
            Me.colWorkStsVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colWorkStsVal.Width = 80
            '
            'colPicZone
            '
            Me.colPicZone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colPicZone.EditBackColor = System.Drawing.SystemColors.Window
            Me.colPicZone.HalfWidthCharacters = False
            Me.colPicZone.HeaderText = "ゾーン"
            Me.colPicZone.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colPicZone.InputComma = True
            Me.colPicZone.MaxByteLength = 65535
            Me.colPicZone.MaxMojiLength = 32767
            Me.colPicZone.Name = "colPicZone"
            Me.colPicZone.ReadOnly = True
            Me.colPicZone.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colPicZone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colPicZone.Width = 50
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
            Me.colLocCd.ReadOnly = True
            Me.colLocCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colLocCd.Width = 90
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
            Me.colBlsItemCd.ReadOnly = True
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
            Me.colBlsItemNm.ReadOnly = True
            Me.colBlsItemNm.Width = 180
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
            Me.colItemMngDate.ReadOnly = True
            Me.colItemMngDate.Width = 95
            '
            'colCsCartonDtl
            '
            Me.colCsCartonDtl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colCsCartonDtl.DefaultCellStyle = DataGridViewCellStyle68
            Me.colCsCartonDtl.EditBackColor = System.Drawing.SystemColors.Window
            Me.colCsCartonDtl.HalfWidthCharacters = False
            Me.colCsCartonDtl.HeaderText = "入数"
            Me.colCsCartonDtl.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colCsCartonDtl.InputComma = True
            Me.colCsCartonDtl.MaxByteLength = 65535
            Me.colCsCartonDtl.MaxMojiLength = 32767
            Me.colCsCartonDtl.Name = "colCsCartonDtl"
            Me.colCsCartonDtl.ReadOnly = True
            Me.colCsCartonDtl.Width = 40
            '
            'colExpCsQty
            '
            Me.colExpCsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colExpCsQty.DefaultCellStyle = DataGridViewCellStyle69
            Me.colExpCsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colExpCsQty.HalfWidthCharacters = False
            Me.colExpCsQty.HeaderText = "指示数(ケース)"
            Me.colExpCsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colExpCsQty.InputComma = True
            Me.colExpCsQty.MaxByteLength = 65535
            Me.colExpCsQty.MaxMojiLength = 32767
            Me.colExpCsQty.Name = "colExpCsQty"
            Me.colExpCsQty.ReadOnly = True
            Me.colExpCsQty.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colExpCsQty.Width = 110
            '
            'colExpPsQty
            '
            Me.colExpPsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colExpPsQty.DefaultCellStyle = DataGridViewCellStyle70
            Me.colExpPsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colExpPsQty.HalfWidthCharacters = False
            Me.colExpPsQty.HeaderText = "指示数(バラ)"
            Me.colExpPsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colExpPsQty.InputComma = True
            Me.colExpPsQty.MaxByteLength = 65535
            Me.colExpPsQty.MaxMojiLength = 32767
            Me.colExpPsQty.Name = "colExpPsQty"
            Me.colExpPsQty.ReadOnly = True
            Me.colExpPsQty.Width = 110
            '
            'colExpSpsQty
            '
            Me.colExpSpsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colExpSpsQty.DefaultCellStyle = DataGridViewCellStyle71
            Me.colExpSpsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colExpSpsQty.HalfWidthCharacters = False
            Me.colExpSpsQty.HeaderText = "指示数(総バラ)"
            Me.colExpSpsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colExpSpsQty.InputComma = True
            Me.colExpSpsQty.MaxByteLength = 65535
            Me.colExpSpsQty.MaxMojiLength = 32767
            Me.colExpSpsQty.Name = "colExpSpsQty"
            Me.colExpSpsQty.ReadOnly = True
            Me.colExpSpsQty.Width = 115
            '
            'colItemMngDateRes
            '
            Me.colItemMngDateRes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colItemMngDateRes.EditBackColor = System.Drawing.SystemColors.Window
            Me.colItemMngDateRes.HalfWidthCharacters = False
            Me.colItemMngDateRes.HeaderText = "実績商品管理日"
            Me.colItemMngDateRes.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colItemMngDateRes.InputComma = True
            Me.colItemMngDateRes.MaxByteLength = 65535
            Me.colItemMngDateRes.MaxMojiLength = 32767
            Me.colItemMngDateRes.Name = "colItemMngDateRes"
            Me.colItemMngDateRes.ReadOnly = True
            Me.colItemMngDateRes.Width = 105
            '
            'colActCsQty
            '
            Me.colActCsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colActCsQty.DefaultCellStyle = DataGridViewCellStyle72
            Me.colActCsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActCsQty.HalfWidthCharacters = False
            Me.colActCsQty.HeaderText = "実績数(ケース)"
            Me.colActCsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActCsQty.InputComma = True
            Me.colActCsQty.MaxByteLength = 65535
            Me.colActCsQty.MaxMojiLength = 32767
            Me.colActCsQty.Name = "colActCsQty"
            Me.colActCsQty.ReadOnly = True
            Me.colActCsQty.Width = 110
            '
            'colActPsQty
            '
            Me.colActPsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colActPsQty.DefaultCellStyle = DataGridViewCellStyle73
            Me.colActPsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActPsQty.HalfWidthCharacters = False
            Me.colActPsQty.HeaderText = "実績数(バラ)"
            Me.colActPsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActPsQty.InputComma = True
            Me.colActPsQty.MaxByteLength = 65535
            Me.colActPsQty.MaxMojiLength = 32767
            Me.colActPsQty.Name = "colActPsQty"
            Me.colActPsQty.ReadOnly = True
            Me.colActPsQty.Width = 110
            '
            'colActSpsQty
            '
            Me.colActSpsQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colActSpsQty.DefaultCellStyle = DataGridViewCellStyle74
            Me.colActSpsQty.EditBackColor = System.Drawing.SystemColors.Window
            Me.colActSpsQty.HalfWidthCharacters = False
            Me.colActSpsQty.HeaderText = "実績数(総バラ)"
            Me.colActSpsQty.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colActSpsQty.InputComma = True
            Me.colActSpsQty.MaxByteLength = 65535
            Me.colActSpsQty.MaxMojiLength = 32767
            Me.colActSpsQty.Name = "colActSpsQty"
            Me.colActSpsQty.ReadOnly = True
            Me.colActSpsQty.Width = 115
            '
            'colDiffCase
            '
            Me.colDiffCase.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colDiffCase.DefaultCellStyle = DataGridViewCellStyle75
            Me.colDiffCase.EditBackColor = System.Drawing.SystemColors.Window
            Me.colDiffCase.HalfWidthCharacters = False
            Me.colDiffCase.HeaderText = "差異数(ケース)"
            Me.colDiffCase.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colDiffCase.InputComma = True
            Me.colDiffCase.MaxByteLength = 65535
            Me.colDiffCase.MaxMojiLength = 32767
            Me.colDiffCase.Name = "colDiffCase"
            Me.colDiffCase.ReadOnly = True
            Me.colDiffCase.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colDiffCase.Width = 110
            '
            'colDiffBal
            '
            Me.colDiffBal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colDiffBal.DefaultCellStyle = DataGridViewCellStyle76
            Me.colDiffBal.EditBackColor = System.Drawing.SystemColors.Window
            Me.colDiffBal.HalfWidthCharacters = False
            Me.colDiffBal.HeaderText = "差異数(バラ)"
            Me.colDiffBal.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colDiffBal.InputComma = True
            Me.colDiffBal.MaxByteLength = 65535
            Me.colDiffBal.MaxMojiLength = 32767
            Me.colDiffBal.Name = "colDiffBal"
            Me.colDiffBal.ReadOnly = True
            Me.colDiffBal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colDiffBal.Width = 110
            '
            'colDiffTotBal
            '
            Me.colDiffTotBal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            DataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colDiffTotBal.DefaultCellStyle = DataGridViewCellStyle77
            Me.colDiffTotBal.EditBackColor = System.Drawing.SystemColors.Window
            Me.colDiffTotBal.HalfWidthCharacters = False
            Me.colDiffTotBal.HeaderText = "差異数(総バラ)"
            Me.colDiffTotBal.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colDiffTotBal.InputComma = True
            Me.colDiffTotBal.MaxByteLength = 65535
            Me.colDiffTotBal.MaxMojiLength = 32767
            Me.colDiffTotBal.Name = "colDiffTotBal"
            Me.colDiffTotBal.ReadOnly = True
            Me.colDiffTotBal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colDiffTotBal.Width = 110
            '
            'colDefItem
            '
            Me.colDefItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colDefItem.EditBackColor = System.Drawing.SystemColors.Window
            Me.colDefItem.HalfWidthCharacters = False
            Me.colDefItem.HeaderText = "不良品区分"
            Me.colDefItem.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colDefItem.InputComma = True
            Me.colDefItem.MaxByteLength = 65535
            Me.colDefItem.MaxMojiLength = 32767
            Me.colDefItem.Name = "colDefItem"
            Me.colDefItem.ReadOnly = True
            Me.colDefItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.colDefItem.Width = 110
            '
            'colTanaNo
            '
            Me.colTanaNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colTanaNo.EditBackColor = System.Drawing.SystemColors.Window
            Me.colTanaNo.HalfWidthCharacters = False
            Me.colTanaNo.HeaderText = "棚卸NO"
            Me.colTanaNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colTanaNo.InputComma = True
            Me.colTanaNo.MaxByteLength = 65535
            Me.colTanaNo.MaxMojiLength = 32767
            Me.colTanaNo.Name = "colTanaNo"
            Me.colTanaNo.ReadOnly = True
            Me.colTanaNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colTanaNo.Width = 90
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
            Me.colJanCd.ReadOnly = True
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
            Me.colCsJanCd.ReadOnly = True
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
            Me.colItfCd.ReadOnly = True
            Me.colItfCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colItfCd.Width = 120
            '
            'colBlsDeliCd
            '
            Me.colBlsDeliCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colBlsDeliCd.EditBackColor = System.Drawing.SystemColors.Window
            Me.colBlsDeliCd.HalfWidthCharacters = False
            Me.colBlsDeliCd.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colBlsDeliCd.InputComma = True
            Me.colBlsDeliCd.MaxByteLength = 65535
            Me.colBlsDeliCd.MaxMojiLength = 32767
            Me.colBlsDeliCd.Name = "colBlsDeliCd"
            '
            'colBlsDeliNm
            '
            Me.colBlsDeliNm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colBlsDeliNm.EditBackColor = System.Drawing.SystemColors.Window
            Me.colBlsDeliNm.HalfWidthCharacters = False
            Me.colBlsDeliNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colBlsDeliNm.InputComma = True
            Me.colBlsDeliNm.MaxByteLength = 65535
            Me.colBlsDeliNm.MaxMojiLength = 32767
            Me.colBlsDeliNm.Name = "colBlsDeliNm"
            '
            'colStartTime
            '
            Me.colStartTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colStartTime.EditBackColor = System.Drawing.SystemColors.Window
            Me.colStartTime.HalfWidthCharacters = False
            Me.colStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colStartTime.InputComma = True
            Me.colStartTime.MaxByteLength = 65535
            Me.colStartTime.MaxMojiLength = 32767
            Me.colStartTime.Name = "colStartTime"
            '
            'colEndTime
            '
            Me.colEndTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colEndTime.EditBackColor = System.Drawing.SystemColors.Window
            Me.colEndTime.HalfWidthCharacters = False
            Me.colEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colEndTime.InputComma = True
            Me.colEndTime.MaxByteLength = 65535
            Me.colEndTime.MaxMojiLength = 32767
            Me.colEndTime.Name = "colEndTime"
            '
            'colTotalCnt
            '
            Me.colTotalCnt.AllowHeadOfZero = True
            Me.colTotalCnt.Comma = False
            Me.colTotalCnt.DecimalFixed = False
            Me.colTotalCnt.DecimalLength = 0
            Me.colTotalCnt.EditBackColor = System.Drawing.SystemColors.Window
            Me.colTotalCnt.EmptyToZero = True
            Me.colTotalCnt.IntegerLength = 32767
            Me.colTotalCnt.Minus = False
            Me.colTotalCnt.Name = "colTotalCnt"
            Me.colTotalCnt.Units = ""
            '
            'colCompCnt
            '
            Me.colCompCnt.AllowHeadOfZero = True
            Me.colCompCnt.Comma = False
            Me.colCompCnt.DecimalFixed = False
            Me.colCompCnt.DecimalLength = 0
            Me.colCompCnt.EditBackColor = System.Drawing.SystemColors.Window
            Me.colCompCnt.EmptyToZero = True
            Me.colCompCnt.IntegerLength = 32767
            Me.colCompCnt.Minus = False
            Me.colCompCnt.Name = "colCompCnt"
            Me.colCompCnt.Units = ""
            '
            'colProcPer
            '
            Me.colProcPer.AllowHeadOfZero = True
            Me.colProcPer.Comma = False
            Me.colProcPer.DecimalFixed = False
            Me.colProcPer.DecimalLength = 0
            Me.colProcPer.EditBackColor = System.Drawing.SystemColors.Window
            Me.colProcPer.EmptyToZero = True
            Me.colProcPer.IntegerLength = 32767
            Me.colProcPer.Minus = False
            Me.colProcPer.Name = "colProcPer"
            Me.colProcPer.Units = ""
            '
            'colProc
            '
            Me.colProc.ColorCompletion = System.Drawing.Color.Blue
            Me.colProc.ColorIncomplete = System.Drawing.Color.White
            Me.colProc.ColorMissing = System.Drawing.Color.Red
            Me.colProc.Name = "colProc"
            Me.colProc.ReadOnly = True
            Me.colProc.StatusPattern = VWS.iSenseOpenLib.BarGraphColumn.Status.COMPLETION_MISSING_INCOMPLETE
            '
            'colCompSpec
            '
            Me.colCompSpec.AllowHeadOfZero = True
            Me.colCompSpec.Comma = False
            Me.colCompSpec.DecimalFixed = False
            Me.colCompSpec.DecimalLength = 0
            Me.colCompSpec.EditBackColor = System.Drawing.SystemColors.Window
            Me.colCompSpec.EmptyToZero = True
            Me.colCompSpec.IntegerLength = 32767
            Me.colCompSpec.Minus = False
            Me.colCompSpec.Name = "colCompSpec"
            Me.colCompSpec.Units = ""
            '
            'colSpec
            '
            Me.colSpec.AllowHeadOfZero = True
            Me.colSpec.Comma = False
            Me.colSpec.DecimalFixed = False
            Me.colSpec.DecimalLength = 0
            Me.colSpec.EditBackColor = System.Drawing.SystemColors.Window
            Me.colSpec.EmptyToZero = True
            Me.colSpec.IntegerLength = 32767
            Me.colSpec.Minus = False
            Me.colSpec.Name = "colSpec"
            Me.colSpec.Units = ""
            '
            'lblBlsDeliCd
            '
            Me.lblBlsDeliCd.AutoSize = True
            Me.lblBlsDeliCd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblBlsDeliCd.ForeColor = System.Drawing.Color.Blue
            Me.lblBlsDeliCd.Location = New System.Drawing.Point(211, 26)
            Me.lblBlsDeliCd.Name = "lblBlsDeliCd"
            Me.lblBlsDeliCd.Size = New System.Drawing.Size(57, 12)
            Me.lblBlsDeliCd.TabIndex = 3
            Me.lblBlsDeliCd.Text = "棚卸区分"
            '
            'lblDeliNm
            '
            Me.lblDeliNm.AutoSize = True
            Me.lblDeliNm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblDeliNm.ForeColor = System.Drawing.Color.Black
            Me.lblDeliNm.Location = New System.Drawing.Point(765, 60)
            Me.lblDeliNm.Name = "lblDeliNm"
            Me.lblDeliNm.Size = New System.Drawing.Size(49, 12)
            Me.lblDeliNm.TabIndex = 5
            Me.lblDeliNm.Text = "棚卸NO"
            '
            'txtTanaOroshiNo
            '
            Me.txtTanaOroshiNo.HalfWidthCharacters = False
            Me.txtTanaOroshiNo.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtTanaOroshiNo.InputComma = True
            Me.txtTanaOroshiNo.Location = New System.Drawing.Point(823, 58)
            Me.txtTanaOroshiNo.MaxByteLength = 8
            Me.txtTanaOroshiNo.MaxMojiLength = 8
            Me.txtTanaOroshiNo.Name = "txtTanaOroshiNo"
            Me.txtTanaOroshiNo.Size = New System.Drawing.Size(148, 19)
            Me.txtTanaOroshiNo.TabIndex = 18
            Me.txtTanaOroshiNo.Text = "WWWWWWWW"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(14, 96)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(37, 12)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "ゾーン"
            '
            'txtZone
            '
            Me.txtZone.HalfWidthCharacters = False
            Me.txtZone.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtZone.InputComma = True
            Me.txtZone.Location = New System.Drawing.Point(89, 92)
            Me.txtZone.MaxByteLength = 2
            Me.txtZone.MaxMojiLength = 2
            Me.txtZone.Name = "txtZone"
            Me.txtZone.Size = New System.Drawing.Size(49, 19)
            Me.txtZone.TabIndex = 19
            Me.txtZone.Text = "12"
            '
            'cmbTanaOroshiKbn
            '
            Me.cmbTanaOroshiKbn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cmbTanaOroshiKbn.FormattingEnabled = True
            Me.cmbTanaOroshiKbn.Item1Width = 0
            Me.cmbTanaOroshiKbn.Item2Width = 0
            Me.cmbTanaOroshiKbn.Location = New System.Drawing.Point(274, 21)
            Me.cmbTanaOroshiKbn.Name = "cmbTanaOroshiKbn"
            Me.cmbTanaOroshiKbn.ReadOnlyColor = System.Drawing.Color.Silver
            Me.cmbTanaOroshiKbn.Size = New System.Drawing.Size(125, 20)
            Me.cmbTanaOroshiKbn.TabIndex = 11
            '
            'btnResult
            '
            Me.btnResult.BackColor = System.Drawing.Color.DimGray
            Me.btnResult.Enabled = False
            Me.btnResult.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnResult.ForeColor = System.Drawing.Color.White
            Me.btnResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnResult.Location = New System.Drawing.Point(210, 2)
            Me.btnResult.Name = "btnResult"
            Me.btnResult.Size = New System.Drawing.Size(31, 30)
            Me.btnResult.TabIndex = 0
            Me.btnResult.TabStop = False
            Me.btnResult.Text = "Result"
            Me.btnResult.UseVisualStyleBackColor = False
            Me.btnResult.Visible = False
            '
            'btnOutDifList
            '
            Me.btnOutDifList.BackColor = System.Drawing.Color.DimGray
            Me.btnOutDifList.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnOutDifList.ForeColor = System.Drawing.Color.White
            Me.btnOutDifList.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnOutDifList.Location = New System.Drawing.Point(813, 2)
            Me.btnOutDifList.Name = "btnOutDifList"
            Me.btnOutDifList.Size = New System.Drawing.Size(100, 30)
            Me.btnOutDifList.TabIndex = 5
            Me.btnOutDifList.Text = "差異リスト"
            Me.btnOutDifList.UseVisualStyleBackColor = False
            '
            'btnDownload
            '
            Me.btnDownload.BackColor = System.Drawing.Color.DimGray
            Me.btnDownload.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnDownload.ForeColor = System.Drawing.Color.White
            Me.btnDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnDownload.Location = New System.Drawing.Point(915, 2)
            Me.btnDownload.Name = "btnDownload"
            Me.btnDownload.Size = New System.Drawing.Size(100, 30)
            Me.btnDownload.TabIndex = 6
            Me.btnDownload.Text = "ダウンロード"
            Me.btnDownload.UseVisualStyleBackColor = False
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
            Me.datShipDate.Location = New System.Drawing.Point(89, 22)
            Me.datShipDate.Name = "datShipDate"
            Me.datShipDate.Size = New System.Drawing.Size(92, 21)
            Me.datShipDate.TabIndex = 10
            Me.datShipDate.ToBackColor = System.Drawing.Color.White
            Me.datShipDate.ToText = "2009/05/07"
            Me.datShipDate.ToValue = New Date(2009, 5, 7, 15, 51, 21, 250)
            '
            'lblProcDate
            '
            Me.lblProcDate.AutoSize = True
            Me.lblProcDate.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblProcDate.ForeColor = System.Drawing.Color.Blue
            Me.lblProcDate.Location = New System.Drawing.Point(11, 26)
            Me.lblProcDate.Name = "lblProcDate"
            Me.lblProcDate.Size = New System.Drawing.Size(70, 12)
            Me.lblProcDate.TabIndex = 1
            Me.lblProcDate.Text = "棚卸実施日"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Location = New System.Drawing.Point(428, 26)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(55, 12)
            Me.Label6.TabIndex = 66
            Me.Label6.Text = "ステータス"
            '
            'lblItemNm
            '
            Me.lblItemNm.AutoSize = True
            Me.lblItemNm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblItemNm.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblItemNm.Location = New System.Drawing.Point(14, 60)
            Me.lblItemNm.Name = "lblItemNm"
            Me.lblItemNm.Size = New System.Drawing.Size(57, 12)
            Me.lblItemNm.TabIndex = 67
            Me.lblItemNm.Text = "商品名称"
            '
            'txtItemNm
            '
            Me.txtItemNm.HalfWidthCharacters = False
            Me.txtItemNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.txtItemNm.InputComma = True
            Me.txtItemNm.Location = New System.Drawing.Point(89, 58)
            Me.txtItemNm.MaxByteLength = 120
            Me.txtItemNm.MaxMojiLength = 60
            Me.txtItemNm.Name = "txtItemNm"
            Me.txtItemNm.Size = New System.Drawing.Size(271, 19)
            Me.txtItemNm.TabIndex = 15
            Me.txtItemNm.Text = "WWWWWWWWWWWWWWWWWWWW"
            '
            'lblItemMngDate
            '
            Me.lblItemMngDate.AutoSize = True
            Me.lblItemMngDate.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblItemMngDate.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblItemMngDate.Location = New System.Drawing.Point(211, 96)
            Me.lblItemMngDate.Name = "lblItemMngDate"
            Me.lblItemMngDate.Size = New System.Drawing.Size(64, 12)
            Me.lblItemMngDate.TabIndex = 69
            Me.lblItemMngDate.Text = "ロケーション"
            '
            'txtLocation
            '
            Me.txtLocation.HalfWidthCharacters = False
            Me.txtLocation.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtLocation.InputComma = True
            Me.txtLocation.Location = New System.Drawing.Point(274, 92)
            Me.txtLocation.MaxByteLength = 7
            Me.txtLocation.MaxMojiLength = 7
            Me.txtLocation.Name = "txtLocation"
            Me.txtLocation.Size = New System.Drawing.Size(92, 19)
            Me.txtLocation.TabIndex = 20
            Me.txtLocation.Text = "1234567"
            '
            'cmbWorkSts
            '
            Me.cmbWorkSts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cmbWorkSts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbWorkSts.FormattingEnabled = True
            Me.cmbWorkSts.Item1Width = 0
            Me.cmbWorkSts.Item2Width = 0
            Me.cmbWorkSts.Location = New System.Drawing.Point(504, 21)
            Me.cmbWorkSts.Name = "cmbWorkSts"
            Me.cmbWorkSts.ReadOnlyColor = System.Drawing.Color.Silver
            Me.cmbWorkSts.Size = New System.Drawing.Size(96, 20)
            Me.cmbWorkSts.TabIndex = 12
            '
            'lblBlsItemCd
            '
            Me.lblBlsItemCd.AutoSize = True
            Me.lblBlsItemCd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblBlsItemCd.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblBlsItemCd.Location = New System.Drawing.Point(398, 60)
            Me.lblBlsItemCd.Name = "lblBlsItemCd"
            Me.lblBlsItemCd.Size = New System.Drawing.Size(85, 12)
            Me.lblBlsItemCd.TabIndex = 72
            Me.lblBlsItemCd.Text = "商品BLSコード"
            '
            'txtBlsItemCd
            '
            Me.txtBlsItemCd.HalfWidthCharacters = False
            Me.txtBlsItemCd.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtBlsItemCd.InputComma = True
            Me.txtBlsItemCd.Location = New System.Drawing.Point(504, 58)
            Me.txtBlsItemCd.MaxByteLength = 8
            Me.txtBlsItemCd.MaxMojiLength = 8
            Me.txtBlsItemCd.Name = "txtBlsItemCd"
            Me.txtBlsItemCd.Size = New System.Drawing.Size(65, 19)
            Me.txtBlsItemCd.TabIndex = 16
            Me.txtBlsItemCd.Text = "12345678"
            '
            'chkDiffren
            '
            Me.chkDiffren.AutoSize = True
            Me.chkDiffren.Location = New System.Drawing.Point(655, 25)
            Me.chkDiffren.Name = "chkDiffren"
            Me.chkDiffren.Size = New System.Drawing.Size(66, 16)
            Me.chkDiffren.TabIndex = 13
            Me.chkDiffren.Text = "差異あり"
            Me.chkDiffren.UseVisualStyleBackColor = True
            '
            'lblWorkUserNm
            '
            Me.lblWorkUserNm.AutoSize = True
            Me.lblWorkUserNm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblWorkUserNm.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblWorkUserNm.Location = New System.Drawing.Point(587, 60)
            Me.lblWorkUserNm.Name = "lblWorkUserNm"
            Me.lblWorkUserNm.Size = New System.Drawing.Size(44, 12)
            Me.lblWorkUserNm.TabIndex = 78
            Me.lblWorkUserNm.Text = "作業者"
            '
            'txtWorkUserNm
            '
            Me.txtWorkUserNm.HalfWidthCharacters = False
            Me.txtWorkUserNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.txtWorkUserNm.InputComma = True
            Me.txtWorkUserNm.Location = New System.Drawing.Point(637, 58)
            Me.txtWorkUserNm.MaxByteLength = 200
            Me.txtWorkUserNm.MaxMojiLength = 100
            Me.txtWorkUserNm.Name = "txtWorkUserNm"
            Me.txtWorkUserNm.Size = New System.Drawing.Size(101, 19)
            Me.txtWorkUserNm.TabIndex = 17
            Me.txtWorkUserNm.Text = "WWWWWWWWWWWWWWWWWWWW"
            '
            'ChkRejectKb
            '
            Me.ChkRejectKb.AutoSize = True
            Me.ChkRejectKb.Location = New System.Drawing.Point(430, 94)
            Me.ChkRejectKb.Name = "ChkRejectKb"
            Me.ChkRejectKb.Size = New System.Drawing.Size(60, 16)
            Me.ChkRejectKb.TabIndex = 21
            Me.ChkRejectKb.Text = "不良品"
            Me.ChkRejectKb.UseVisualStyleBackColor = True
            '
            'cmbZaikoChk
            '
            Me.cmbZaikoChk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cmbZaikoChk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbZaikoChk.FormattingEnabled = True
            Me.cmbZaikoChk.Item1Width = 0
            Me.cmbZaikoChk.Item2Width = 0
            Me.cmbZaikoChk.Location = New System.Drawing.Point(823, 18)
            Me.cmbZaikoChk.Name = "cmbZaikoChk"
            Me.cmbZaikoChk.ReadOnlyColor = System.Drawing.Color.Silver
            Me.cmbZaikoChk.Size = New System.Drawing.Size(125, 20)
            Me.cmbZaikoChk.TabIndex = 14
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.Label7.ForeColor = System.Drawing.Color.Black
            Me.Label7.Location = New System.Drawing.Point(765, 24)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(52, 12)
            Me.Label7.TabIndex = 82
            Me.Label7.Text = "在庫ゼロ"
            '
            'frmVSMSS310_01
            '
            Me.ClientSize = New System.Drawing.Size(1016, 703)
            Me.Name = "frmVSMSS310_01"
            Me.Text = "frmVSMSS310_01 [  ]"
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
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents btnSearch As System.Windows.Forms.Button
        Public WithEvents btnClear As System.Windows.Forms.Button
        Friend WithEvents dgvMsi As VWS.iSenseOpenLib.VariedDataGridView
        Friend WithEvents lblBlsDeliCd As System.Windows.Forms.Label
        Friend WithEvents lblDeliNm As System.Windows.Forms.Label
        Friend WithEvents txtTanaOroshiNo As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents colBlsDeliCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colBlsDeliNm As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colStartTime As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colEndTime As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colTotalCnt As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colCompCnt As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colCompSpec As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colSpec As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colProcPer As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colProc As VWS.iSenseOpenLib.BarGraphColumn
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtZone As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents cmbTanaOroshiKbn As VWS.iSenseOpenLib.NamedComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Public WithEvents btnResult As System.Windows.Forms.Button
        Public WithEvents btnOutDifList As System.Windows.Forms.Button
        Public WithEvents btnDownload As System.Windows.Forms.Button
        Friend WithEvents datShipDate As VWS.iSenseOpenLib.CutBlankDateFromTo
        Friend WithEvents lblProcDate As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblItemNm As System.Windows.Forms.Label
        Friend WithEvents txtItemNm As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblItemMngDate As System.Windows.Forms.Label
        Friend WithEvents txtLocation As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents cmbWorkSts As VWS.iSenseOpenLib.NamedComboBox
        Friend WithEvents lblBlsItemCd As System.Windows.Forms.Label
        Friend WithEvents txtBlsItemCd As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents chkDiffren As System.Windows.Forms.CheckBox
        Friend WithEvents lblWorkUserNm As System.Windows.Forms.Label
        Friend WithEvents txtWorkUserNm As VWS.iSenseOpenLib.VariedTextBox

        Friend WithEvents ChkRejectKb As System.Windows.Forms.CheckBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents cmbZaikoChk As VWS.iSenseOpenLib.NamedComboBox
        Friend WithEvents colWorkStsVal As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colPicZone As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colLocCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colBlsItemCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colBlsItemNm As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colItemMngDate As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colCsCartonDtl As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colExpCsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colExpPsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colExpSpsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colItemMngDateRes As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActCsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActPsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colActSpsQty As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colDiffCase As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colDiffBal As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colDiffTotBal As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colDefItem As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colTanaNo As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colJanCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colCsJanCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colItfCd As VWS.iSenseOpenLib.VariedTextBoxColumn


    End Class

End Namespace
