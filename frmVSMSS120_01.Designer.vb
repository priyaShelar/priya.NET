Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVSMSS120_01
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
            Me.btnResult = New System.Windows.Forms.Button
            Me.btnClear = New System.Windows.Forms.Button
            Me.btnSearch = New System.Windows.Forms.Button
            Me.lblProcDate = New System.Windows.Forms.Label
            Me.lblUnfinSts = New System.Windows.Forms.Label
            Me.lbl100per = New System.Windows.Forms.Label
            Me.lbl50per = New System.Windows.Forms.Label
            Me.lbl0per = New System.Windows.Forms.Label
            Me.lblFinSts = New System.Windows.Forms.Label
            Me.lblWhite = New System.Windows.Forms.Label
            Me.lblBlue = New System.Windows.Forms.Label
            Me.lblPorc = New System.Windows.Forms.Label
            Me.lblStart = New System.Windows.Forms.Label
            Me.lblEnd = New System.Windows.Forms.Label
            Me.dgvMsi = New VWS.iSenseOpenLib.VariedDataGridView(Me.components)
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
            Me.lblSpl = New System.Windows.Forms.Label
            Me.lblAct = New System.Windows.Forms.Label
            Me.lblBlsDeliCd = New System.Windows.Forms.Label
            Me.lblDeliNm = New System.Windows.Forms.Label
            Me.datArrivalDate = New VWS.iSenseOpenLib.CutBlankDateFromTo
            Me.txtVendorNm = New VWS.iSenseOpenLib.VariedTextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtVendorCD = New VWS.iSenseOpenLib.VariedTextBox
            Me.NyuKaKb = New VWS.iSenseOpenLib.NamedComboBox(Me.components)
            Me.lblStartTime = New System.Windows.Forms.Label
            Me.lblEndTime = New System.Windows.Forms.Label
            Me.lblSplVal = New System.Windows.Forms.Label
            Me.lblActVal = New System.Windows.Forms.Label
            Me.lblProcVal = New System.Windows.Forms.Label
            Me.picGraph = New VWS.iSenseOpenLib.BarGraph
            Me.picGraph1 = New VWS.iSenseOpenLib.BarGraph
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.lblSplVal1 = New System.Windows.Forms.Label
            Me.lblActVal1 = New System.Windows.Forms.Label
            Me.lblProcVal1 = New System.Windows.Forms.Label
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
            CType(Me.picGraph, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picGraph1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblTotal_Ken
            '
            Me.lblTotal_Ken.Location = New System.Drawing.Point(954, 465)
            Me.lblTotal_Ken.Visible = False
            '
            'lblTotal
            '
            Me.lblTotal.Location = New System.Drawing.Point(849, 534)
            Me.lblTotal.Visible = False
            '
            'lblTotal_Title
            '
            Me.lblTotal_Title.Location = New System.Drawing.Point(747, 534)
            Me.lblTotal_Title.Visible = False
            '
            'btnReports
            '
            Me.btnReports.Location = New System.Drawing.Point(181, 2)
            Me.btnReports.Size = New System.Drawing.Size(10, 30)
            Me.btnReports.Visible = False
            '
            'btnNext
            '
            Me.btnNext.Location = New System.Drawing.Point(1005, 123)
            Me.btnNext.Size = New System.Drawing.Size(10, 30)
            Me.btnNext.Visible = False
            '
            'btnPrev
            '
            Me.btnPrev.Location = New System.Drawing.Point(993, 125)
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
            Me.pnlControl07.Controls.Add(Me.NyuKaKb)
            Me.pnlControl07.Controls.Add(Me.txtVendorCD)
            Me.pnlControl07.Controls.Add(Me.Label1)
            Me.pnlControl07.Controls.Add(Me.txtVendorNm)
            Me.pnlControl07.Controls.Add(Me.datArrivalDate)
            Me.pnlControl07.Controls.Add(Me.lblDeliNm)
            Me.pnlControl07.Controls.Add(Me.lblBlsDeliCd)
            Me.pnlControl07.Controls.Add(Me.lblProcDate)
            Me.pnlControl07.Location = New System.Drawing.Point(0, 77)
            Me.pnlControl07.Size = New System.Drawing.Size(1016, 67)
            Me.pnlControl07.TabIndex = 1
            '
            'pnlControl08
            '
            Me.pnlControl08.Controls.Add(Me.lblProcVal1)
            Me.pnlControl08.Controls.Add(Me.lblActVal1)
            Me.pnlControl08.Controls.Add(Me.lblSplVal1)
            Me.pnlControl08.Controls.Add(Me.Label8)
            Me.pnlControl08.Controls.Add(Me.Label7)
            Me.pnlControl08.Controls.Add(Me.Label6)
            Me.pnlControl08.Controls.Add(Me.picGraph1)
            Me.pnlControl08.Controls.Add(Me.lblProcVal)
            Me.pnlControl08.Controls.Add(Me.lblActVal)
            Me.pnlControl08.Controls.Add(Me.lblSplVal)
            Me.pnlControl08.Controls.Add(Me.lblEndTime)
            Me.pnlControl08.Controls.Add(Me.lblStartTime)
            Me.pnlControl08.Controls.Add(Me.lblUnfinSts)
            Me.pnlControl08.Controls.Add(Me.picGraph)
            Me.pnlControl08.Controls.Add(Me.lbl100per)
            Me.pnlControl08.Controls.Add(Me.lbl50per)
            Me.pnlControl08.Controls.Add(Me.lbl0per)
            Me.pnlControl08.Controls.Add(Me.lblFinSts)
            Me.pnlControl08.Controls.Add(Me.lblWhite)
            Me.pnlControl08.Controls.Add(Me.lblBlue)
            Me.pnlControl08.Controls.Add(Me.dgvMsi)
            Me.pnlControl08.Controls.Add(Me.lblPorc)
            Me.pnlControl08.Controls.Add(Me.lblStart)
            Me.pnlControl08.Controls.Add(Me.lblEnd)
            Me.pnlControl08.Controls.Add(Me.lblSpl)
            Me.pnlControl08.Controls.Add(Me.lblAct)
            Me.pnlControl08.Location = New System.Drawing.Point(0, 144)
            Me.pnlControl08.Size = New System.Drawing.Size(1016, 569)
            Me.pnlControl08.TabIndex = 3
            Me.pnlControl08.Controls.SetChildIndex(Me.lblAct, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblSpl, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblEnd, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblStart, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblPorc, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.dgvMsi, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblBlue, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblWhite, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblFinSts, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lbl0per, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lbl50per, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lbl100per, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.picGraph, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblUnfinSts, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblStartTime, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblEndTime, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblSplVal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblActVal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblProcVal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnSelect, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnDeSelect, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnAdd, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnDelete, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnPrev, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnNext, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal_Title, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal_Ken, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.picGraph1, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.Label6, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.Label7, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.Label8, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblSplVal1, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblActVal1, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblProcVal1, 0)
            '
            'btnDeSelect
            '
            Me.btnDeSelect.Location = New System.Drawing.Point(40, 101)
            Me.btnDeSelect.Size = New System.Drawing.Size(10, 30)
            Me.btnDeSelect.Visible = False
            '
            'btnSelect
            '
            Me.btnSelect.Location = New System.Drawing.Point(24, 101)
            Me.btnSelect.Size = New System.Drawing.Size(10, 30)
            Me.btnSelect.Visible = False
            '
            'btnDelete
            '
            Me.btnDelete.Location = New System.Drawing.Point(72, 101)
            Me.btnDelete.Size = New System.Drawing.Size(10, 30)
            Me.btnDelete.Visible = False
            '
            'btnAdd
            '
            Me.btnAdd.Location = New System.Drawing.Point(56, 101)
            Me.btnAdd.Size = New System.Drawing.Size(10, 30)
            Me.btnAdd.TabIndex = 8
            Me.btnAdd.TabStop = True
            Me.btnAdd.Visible = False
            '
            'pnlControl05
            '
            Me.pnlControl05.Controls.Add(Me.btnSearch)
            Me.pnlControl05.Controls.Add(Me.btnClear)
            Me.pnlControl05.Controls.Add(Me.btnResult)
            Me.pnlControl05.TabIndex = 0
            Me.pnlControl05.Controls.SetChildIndex(Me.btnReports, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnClose, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnMenu, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnExit, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnResult, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnClear, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnSearch, 0)
            '
            'btnClose
            '
            Me.btnClose.Enabled = False
            Me.btnClose.Location = New System.Drawing.Point(269, 2)
            Me.btnClose.Size = New System.Drawing.Size(31, 30)
            Me.btnClose.TabIndex = 0
            Me.btnClose.Text = "close"
            Me.btnClose.Visible = False
            '
            'btnExit
            '
            Me.btnExit.Location = New System.Drawing.Point(180, 3)
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
            Me.lblMenu.Text = "入荷進捗照会"
            '
            'lblYmd
            '
            Me.lblYmd.Text = "2019/12/04 10:54:26"
            '
            'lblUser
            '
            Me.lblUser.Text = " / "
            '
            'btnResult
            '
            Me.btnResult.BackColor = System.Drawing.Color.DimGray
            Me.btnResult.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnResult.ForeColor = System.Drawing.Color.White
            Me.btnResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnResult.Location = New System.Drawing.Point(100, 2)
            Me.btnResult.Name = "btnResult"
            Me.btnResult.Size = New System.Drawing.Size(100, 30)
            Me.btnResult.TabIndex = 2
            Me.btnResult.Text = "実績照会"
            Me.btnResult.UseVisualStyleBackColor = False
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.DimGray
            Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.White
            Me.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.btnClear.Location = New System.Drawing.Point(913, 2)
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
            Me.btnSearch.Location = New System.Drawing.Point(813, 2)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(100, 30)
            Me.btnSearch.TabIndex = 3
            Me.btnSearch.Text = "検索"
            Me.btnSearch.UseVisualStyleBackColor = False
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
            Me.lblProcDate.Text = "入荷予定日"
            '
            'lblUnfinSts
            '
            Me.lblUnfinSts.AutoSize = True
            Me.lblUnfinSts.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblUnfinSts.Location = New System.Drawing.Point(945, 12)
            Me.lblUnfinSts.Name = "lblUnfinSts"
            Me.lblUnfinSts.Size = New System.Drawing.Size(44, 12)
            Me.lblUnfinSts.TabIndex = 121
            Me.lblUnfinSts.Text = "未完了"
            '
            'lbl100per
            '
            Me.lbl100per.AutoSize = True
            Me.lbl100per.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lbl100per.Location = New System.Drawing.Point(941, 40)
            Me.lbl100per.Name = "lbl100per"
            Me.lbl100per.Size = New System.Drawing.Size(29, 12)
            Me.lbl100per.TabIndex = 116
            Me.lbl100per.Text = "100%"
            '
            'lbl50per
            '
            Me.lbl50per.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lbl50per.Location = New System.Drawing.Point(797, 40)
            Me.lbl50per.Name = "lbl50per"
            Me.lbl50per.Size = New System.Drawing.Size(40, 12)
            Me.lbl50per.TabIndex = 115
            Me.lbl50per.Text = "50%"
            Me.lbl50per.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl0per
            '
            Me.lbl0per.AutoSize = True
            Me.lbl0per.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lbl0per.Location = New System.Drawing.Point(661, 40)
            Me.lbl0per.Name = "lbl0per"
            Me.lbl0per.Size = New System.Drawing.Size(17, 12)
            Me.lbl0per.TabIndex = 114
            Me.lbl0per.Text = "0%"
            '
            'lblFinSts
            '
            Me.lblFinSts.AutoSize = True
            Me.lblFinSts.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblFinSts.Location = New System.Drawing.Point(841, 12)
            Me.lblFinSts.Name = "lblFinSts"
            Me.lblFinSts.Size = New System.Drawing.Size(31, 12)
            Me.lblFinSts.TabIndex = 119
            Me.lblFinSts.Text = "完了"
            '
            'lblWhite
            '
            Me.lblWhite.BackColor = System.Drawing.Color.White
            Me.lblWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblWhite.Location = New System.Drawing.Point(890, 7)
            Me.lblWhite.Name = "lblWhite"
            Me.lblWhite.Size = New System.Drawing.Size(52, 21)
            Me.lblWhite.TabIndex = 120
            Me.lblWhite.Text = " "
            '
            'lblBlue
            '
            Me.lblBlue.BackColor = System.Drawing.Color.Blue
            Me.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblBlue.Location = New System.Drawing.Point(785, 7)
            Me.lblBlue.Name = "lblBlue"
            Me.lblBlue.Size = New System.Drawing.Size(52, 21)
            Me.lblBlue.TabIndex = 118
            Me.lblBlue.Text = " "
            '
            'lblPorc
            '
            Me.lblPorc.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblPorc.Location = New System.Drawing.Point(610, 101)
            Me.lblPorc.Name = "lblPorc"
            Me.lblPorc.Size = New System.Drawing.Size(45, 12)
            Me.lblPorc.TabIndex = 112
            Me.lblPorc.Text = "進捗率"
            Me.lblPorc.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblStart
            '
            Me.lblStart.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblStart.Location = New System.Drawing.Point(305, 101)
            Me.lblStart.Name = "lblStart"
            Me.lblStart.Size = New System.Drawing.Size(65, 12)
            Me.lblStart.TabIndex = 104
            Me.lblStart.Text = "開始時間"
            '
            'lblEnd
            '
            Me.lblEnd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblEnd.Location = New System.Drawing.Point(375, 101)
            Me.lblEnd.Name = "lblEnd"
            Me.lblEnd.Size = New System.Drawing.Size(65, 12)
            Me.lblEnd.TabIndex = 106
            Me.lblEnd.Text = "最終時間"
            '
            'dgvMsi
            '
            Me.dgvMsi.AllowUserToAddRows = False
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMsi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvMsi.ColumnHeadersHeight = 30
            Me.dgvMsi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBlsDeliCd, Me.colBlsDeliNm, Me.colStartTime, Me.colEndTime, Me.colTotalCnt, Me.colCompCnt, Me.colProcPer, Me.colProc})
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle5.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvMsi.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvMsi.EnableHeadersVisualStyles = False
            Me.dgvMsi.KeyAction = VWS.iSenseOpenLib.VariedDataGridView.KeyActions.NotSet
            Me.dgvMsi.Location = New System.Drawing.Point(21, 137)
            Me.dgvMsi.MoveEditCell = True
            Me.dgvMsi.Name = "dgvMsi"
            Me.dgvMsi.ReadOnly = True
            Me.dgvMsi.RowHeadersWidth = 45
            Me.dgvMsi.RowTemplate.Height = 45
            Me.dgvMsi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMsi.Size = New System.Drawing.Size(982, 392)
            Me.dgvMsi.TabIndex = 1
            Me.dgvMsi.TabStop = False
            '
            'colBlsDeliCd
            '
            Me.colBlsDeliCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colBlsDeliCd.EditBackColor = System.Drawing.SystemColors.Window
            Me.colBlsDeliCd.HalfWidthCharacters = False
            Me.colBlsDeliCd.HeaderText = "発地"
            Me.colBlsDeliCd.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colBlsDeliCd.InputComma = True
            Me.colBlsDeliCd.MaxByteLength = 65535
            Me.colBlsDeliCd.MaxMojiLength = 32767
            Me.colBlsDeliCd.Name = "colBlsDeliCd"
            Me.colBlsDeliCd.ReadOnly = True
            Me.colBlsDeliCd.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colBlsDeliCd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colBlsDeliCd.Width = 165
            '
            'colBlsDeliNm
            '
            Me.colBlsDeliNm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colBlsDeliNm.EditBackColor = System.Drawing.SystemColors.Window
            Me.colBlsDeliNm.HalfWidthCharacters = False
            Me.colBlsDeliNm.HeaderText = "入荷区分"
            Me.colBlsDeliNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colBlsDeliNm.InputComma = True
            Me.colBlsDeliNm.MaxByteLength = 65535
            Me.colBlsDeliNm.MaxMojiLength = 32767
            Me.colBlsDeliNm.Name = "colBlsDeliNm"
            Me.colBlsDeliNm.ReadOnly = True
            Me.colBlsDeliNm.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colBlsDeliNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colBlsDeliNm.Width = 70
            '
            'colStartTime
            '
            Me.colStartTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colStartTime.EditBackColor = System.Drawing.SystemColors.Window
            Me.colStartTime.HalfWidthCharacters = False
            Me.colStartTime.HeaderText = "開始時間"
            Me.colStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colStartTime.InputComma = True
            Me.colStartTime.MaxByteLength = 65535
            Me.colStartTime.MaxMojiLength = 32767
            Me.colStartTime.Name = "colStartTime"
            Me.colStartTime.ReadOnly = True
            Me.colStartTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colStartTime.Width = 70
            '
            'colEndTime
            '
            Me.colEndTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colEndTime.EditBackColor = System.Drawing.SystemColors.Window
            Me.colEndTime.HalfWidthCharacters = False
            Me.colEndTime.HeaderText = "最終時間"
            Me.colEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colEndTime.InputComma = True
            Me.colEndTime.MaxByteLength = 65535
            Me.colEndTime.MaxMojiLength = 32767
            Me.colEndTime.Name = "colEndTime"
            Me.colEndTime.ReadOnly = True
            Me.colEndTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colEndTime.Width = 70
            '
            'colTotalCnt
            '
            Me.colTotalCnt.AllowHeadOfZero = True
            Me.colTotalCnt.Comma = False
            Me.colTotalCnt.DecimalFixed = False
            Me.colTotalCnt.DecimalLength = 0
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colTotalCnt.DefaultCellStyle = DataGridViewCellStyle2
            Me.colTotalCnt.EditBackColor = System.Drawing.SystemColors.Window
            Me.colTotalCnt.EmptyToZero = True
            Me.colTotalCnt.HeaderText = "予定明細数"
            Me.colTotalCnt.IntegerLength = 32767
            Me.colTotalCnt.Minus = False
            Me.colTotalCnt.Name = "colTotalCnt"
            Me.colTotalCnt.ReadOnly = True
            Me.colTotalCnt.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colTotalCnt.Units = ""
            Me.colTotalCnt.Width = 80
            '
            'colCompCnt
            '
            Me.colCompCnt.AllowHeadOfZero = True
            Me.colCompCnt.Comma = False
            Me.colCompCnt.DecimalFixed = False
            Me.colCompCnt.DecimalLength = 0
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colCompCnt.DefaultCellStyle = DataGridViewCellStyle3
            Me.colCompCnt.EditBackColor = System.Drawing.SystemColors.Window
            Me.colCompCnt.EmptyToZero = True
            Me.colCompCnt.HeaderText = "完了明細数"
            Me.colCompCnt.IntegerLength = 32767
            Me.colCompCnt.Minus = False
            Me.colCompCnt.Name = "colCompCnt"
            Me.colCompCnt.ReadOnly = True
            Me.colCompCnt.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colCompCnt.Units = ""
            Me.colCompCnt.Width = 80
            '
            'colProcPer
            '
            Me.colProcPer.AllowHeadOfZero = True
            Me.colProcPer.Comma = False
            Me.colProcPer.DecimalFixed = False
            Me.colProcPer.DecimalLength = 0
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.colProcPer.DefaultCellStyle = DataGridViewCellStyle4
            Me.colProcPer.EditBackColor = System.Drawing.SystemColors.Window
            Me.colProcPer.EmptyToZero = True
            Me.colProcPer.HeaderText = "進捗率"
            Me.colProcPer.IntegerLength = 32767
            Me.colProcPer.Minus = False
            Me.colProcPer.Name = "colProcPer"
            Me.colProcPer.ReadOnly = True
            Me.colProcPer.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colProcPer.Units = ""
            Me.colProcPer.Width = 55
            '
            'colProc
            '
            Me.colProc.ColorCompletion = System.Drawing.Color.Blue
            Me.colProc.ColorIncomplete = System.Drawing.Color.White
            Me.colProc.ColorMissing = System.Drawing.Color.Red
            Me.colProc.HeaderText = "0%                                  50%                             100%"
            Me.colProc.Name = "colProc"
            Me.colProc.ReadOnly = True
            Me.colProc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colProc.StatusPattern = VWS.iSenseOpenLib.BarGraphColumn.Status.COMPLETION_INCOMPLETE
            Me.colProc.Width = 320
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
            'lblSpl
            '
            Me.lblSpl.AutoSize = True
            Me.lblSpl.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblSpl.Location = New System.Drawing.Point(450, 101)
            Me.lblSpl.Name = "lblSpl"
            Me.lblSpl.Size = New System.Drawing.Size(70, 12)
            Me.lblSpl.TabIndex = 108
            Me.lblSpl.Text = "予定明細数"
            Me.lblSpl.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblAct
            '
            Me.lblAct.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblAct.Location = New System.Drawing.Point(530, 101)
            Me.lblAct.Name = "lblAct"
            Me.lblAct.Size = New System.Drawing.Size(70, 12)
            Me.lblAct.TabIndex = 110
            Me.lblAct.Text = "完了明細数"
            Me.lblAct.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblBlsDeliCd
            '
            Me.lblBlsDeliCd.AutoSize = True
            Me.lblBlsDeliCd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblBlsDeliCd.ForeColor = System.Drawing.Color.Black
            Me.lblBlsDeliCd.Location = New System.Drawing.Point(722, 29)
            Me.lblBlsDeliCd.Name = "lblBlsDeliCd"
            Me.lblBlsDeliCd.Size = New System.Drawing.Size(57, 12)
            Me.lblBlsDeliCd.TabIndex = 3
            Me.lblBlsDeliCd.Text = "入荷区分"
            '
            'lblDeliNm
            '
            Me.lblDeliNm.AutoSize = True
            Me.lblDeliNm.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblDeliNm.ForeColor = System.Drawing.Color.Black
            Me.lblDeliNm.Location = New System.Drawing.Point(426, 29)
            Me.lblDeliNm.Name = "lblDeliNm"
            Me.lblDeliNm.Size = New System.Drawing.Size(57, 12)
            Me.lblDeliNm.TabIndex = 5
            Me.lblDeliNm.Text = "発地名称"
            '
            'datArrivalDate
            '
            Me.datArrivalDate.EditColor = System.Drawing.Color.White
            Me.datArrivalDate.ErrorBackColor = System.Drawing.Color.Red
            Me.datArrivalDate.Format = VWS.iSenseOpenLib.CutBlankDateFromTo.Formats.FormatShort
            Me.datArrivalDate.FromBackColor = System.Drawing.Color.White
            Me.datArrivalDate.FromOnly = True
            Me.datArrivalDate.FromSize = 90
            Me.datArrivalDate.FromText = "2009/05/07"
            Me.datArrivalDate.FromValue = New Date(2009, 5, 7, 15, 50, 52, 453)
            Me.datArrivalDate.Location = New System.Drawing.Point(89, 22)
            Me.datArrivalDate.Name = "datArrivalDate"
            Me.datArrivalDate.Size = New System.Drawing.Size(92, 21)
            Me.datArrivalDate.TabIndex = 10
            Me.datArrivalDate.ToBackColor = System.Drawing.Color.White
            Me.datArrivalDate.ToText = "2009/05/07"
            Me.datArrivalDate.ToValue = New Date(2009, 5, 7, 15, 51, 21, 250)
            '
            'txtVendorNm
            '
            Me.txtVendorNm.HalfWidthCharacters = False
            Me.txtVendorNm.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.txtVendorNm.InputComma = True
            Me.txtVendorNm.Location = New System.Drawing.Point(517, 26)
            Me.txtVendorNm.MaxByteLength = 180
            Me.txtVendorNm.MaxMojiLength = 60
            Me.txtVendorNm.Name = "txtVendorNm"
            Me.txtVendorNm.Size = New System.Drawing.Size(148, 19)
            Me.txtVendorNm.TabIndex = 12
            Me.txtVendorNm.Text = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(215, 29)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(61, 12)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "発地コード"
            '
            'txtVendorCD
            '
            Me.txtVendorCD.HalfWidthCharacters = False
            Me.txtVendorCD.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtVendorCD.InputComma = True
            Me.txtVendorCD.Location = New System.Drawing.Point(315, 24)
            Me.txtVendorCD.MaxByteLength = 5
            Me.txtVendorCD.MaxMojiLength = 5
            Me.txtVendorCD.Name = "txtVendorCD"
            Me.txtVendorCD.Size = New System.Drawing.Size(85, 19)
            Me.txtVendorCD.TabIndex = 11
            Me.txtVendorCD.Text = "12345"
            '
            'NyuKaKb
            '
            Me.NyuKaKb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.NyuKaKb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.NyuKaKb.FormattingEnabled = True
            Me.NyuKaKb.Item1Width = 0
            Me.NyuKaKb.Item2Width = 0
            Me.NyuKaKb.Location = New System.Drawing.Point(799, 24)
            Me.NyuKaKb.Name = "NyuKaKb"
            Me.NyuKaKb.ReadOnlyColor = System.Drawing.Color.Silver
            Me.NyuKaKb.Size = New System.Drawing.Size(125, 20)
            Me.NyuKaKb.TabIndex = 13
            '
            'lblStartTime
            '
            Me.lblStartTime.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblStartTime.Location = New System.Drawing.Point(305, 121)
            Me.lblStartTime.Name = "lblStartTime"
            Me.lblStartTime.Size = New System.Drawing.Size(65, 12)
            Me.lblStartTime.TabIndex = 290
            Me.lblStartTime.Text = "-   "
            '
            'lblEndTime
            '
            Me.lblEndTime.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblEndTime.Location = New System.Drawing.Point(375, 121)
            Me.lblEndTime.Name = "lblEndTime"
            Me.lblEndTime.Size = New System.Drawing.Size(65, 12)
            Me.lblEndTime.TabIndex = 289
            Me.lblEndTime.Text = "-"
            '
            'lblSplVal
            '
            Me.lblSplVal.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblSplVal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblSplVal.Location = New System.Drawing.Point(450, 121)
            Me.lblSplVal.Name = "lblSplVal"
            Me.lblSplVal.Size = New System.Drawing.Size(70, 12)
            Me.lblSplVal.TabIndex = 291
            Me.lblSplVal.Text = "-"
            Me.lblSplVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblActVal
            '
            Me.lblActVal.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblActVal.Location = New System.Drawing.Point(530, 121)
            Me.lblActVal.Name = "lblActVal"
            Me.lblActVal.Size = New System.Drawing.Size(70, 12)
            Me.lblActVal.TabIndex = 292
            Me.lblActVal.Text = "-"
            Me.lblActVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblProcVal
            '
            Me.lblProcVal.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblProcVal.Location = New System.Drawing.Point(605, 121)
            Me.lblProcVal.Name = "lblProcVal"
            Me.lblProcVal.Size = New System.Drawing.Size(50, 12)
            Me.lblProcVal.TabIndex = 293
            Me.lblProcVal.Text = "-"
            Me.lblProcVal.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'picGraph
            '
            Me.picGraph.BackColor = System.Drawing.SystemColors.Window
            Me.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picGraph.ColorCompletion = System.Drawing.Color.Blue
            Me.picGraph.ColorIncomplete = System.Drawing.Color.White
            Me.picGraph.ColorMissing = System.Drawing.Color.Red
            Me.picGraph.GraphValue = "0"
            Me.picGraph.Location = New System.Drawing.Point(663, 99)
            Me.picGraph.Name = "picGraph"
            Me.picGraph.Size = New System.Drawing.Size(307, 35)
            Me.picGraph.StatusPattern = VWS.iSenseOpenLib.BarGraph.Status.COMPLETION_INCOMPLETE
            Me.picGraph.TabIndex = 286
            Me.picGraph.TabStop = False
            '
            'picGraph1
            '
            Me.picGraph1.BackColor = System.Drawing.SystemColors.Window
            Me.picGraph1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picGraph1.ColorCompletion = System.Drawing.Color.Blue
            Me.picGraph1.ColorIncomplete = System.Drawing.Color.White
            Me.picGraph1.ColorMissing = System.Drawing.Color.Red
            Me.picGraph1.GraphValue = "0"
            Me.picGraph1.Location = New System.Drawing.Point(663, 55)
            Me.picGraph1.Name = "picGraph1"
            Me.picGraph1.Size = New System.Drawing.Size(307, 35)
            Me.picGraph1.StatusPattern = VWS.iSenseOpenLib.BarGraph.Status.COMPLETION_INCOMPLETE
            Me.picGraph1.TabIndex = 294
            Me.picGraph1.TabStop = False
            '
            'Label6
            '
            Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.Label6.Location = New System.Drawing.Point(450, 55)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(70, 12)
            Me.Label6.TabIndex = 295
            Me.Label6.Text = "予定ﾛｯﾄ数"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label7
            '
            Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.Label7.Location = New System.Drawing.Point(530, 55)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(70, 12)
            Me.Label7.TabIndex = 296
            Me.Label7.Text = "完了ﾛｯﾄ数"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label8
            '
            Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.Label8.Location = New System.Drawing.Point(610, 55)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(45, 12)
            Me.Label8.TabIndex = 297
            Me.Label8.Text = "進捗率"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblSplVal1
            '
            Me.lblSplVal1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSplVal1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lblSplVal1.Location = New System.Drawing.Point(450, 74)
            Me.lblSplVal1.Name = "lblSplVal1"
            Me.lblSplVal1.Size = New System.Drawing.Size(70, 12)
            Me.lblSplVal1.TabIndex = 298
            Me.lblSplVal1.Text = "-"
            Me.lblSplVal1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblActVal1
            '
            Me.lblActVal1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblActVal1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblActVal1.Location = New System.Drawing.Point(530, 74)
            Me.lblActVal1.Name = "lblActVal1"
            Me.lblActVal1.Size = New System.Drawing.Size(70, 12)
            Me.lblActVal1.TabIndex = 299
            Me.lblActVal1.Text = "-"
            Me.lblActVal1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblProcVal1
            '
            Me.lblProcVal1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblProcVal1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblProcVal1.Location = New System.Drawing.Point(605, 74)
            Me.lblProcVal1.Name = "lblProcVal1"
            Me.lblProcVal1.Size = New System.Drawing.Size(50, 12)
            Me.lblProcVal1.TabIndex = 300
            Me.lblProcVal1.Text = "-"
            Me.lblProcVal1.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'frmVSMSS120_01
            '
            Me.ClientSize = New System.Drawing.Size(1016, 703)
            Me.Name = "frmVSMSS120_01"
            Me.Text = "frmVSMSS320_01 [  ]"
            Me.pnlControl06.ResumeLayout(False)
            Me.pnlControl07.ResumeLayout(False)
            Me.pnlControl07.PerformLayout()
            Me.pnlControl08.ResumeLayout(False)
            Me.pnlControl08.PerformLayout()
            Me.pnlControl05.ResumeLayout(False)
            Me.pnlControl04.ResumeLayout(False)
            Me.pnlControl03.ResumeLayout(False)
            Me.pnlControl02.ResumeLayout(False)
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBase.ResumeLayout(False)
            CType(Me.dgvMsi, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picGraph, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picGraph1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents btnSearch As System.Windows.Forms.Button
        Public WithEvents btnClear As System.Windows.Forms.Button
        Public WithEvents btnResult As System.Windows.Forms.Button
        Friend WithEvents lblProcDate As System.Windows.Forms.Label
        Friend WithEvents lblUnfinSts As System.Windows.Forms.Label
        Friend WithEvents lbl100per As System.Windows.Forms.Label
        Friend WithEvents lbl50per As System.Windows.Forms.Label
        Friend WithEvents lbl0per As System.Windows.Forms.Label
        Friend WithEvents lblFinSts As System.Windows.Forms.Label
        Friend WithEvents lblWhite As System.Windows.Forms.Label
        Friend WithEvents lblBlue As System.Windows.Forms.Label
        Friend WithEvents lblPorc As System.Windows.Forms.Label
        Friend WithEvents lblStart As System.Windows.Forms.Label
        Friend WithEvents lblEnd As System.Windows.Forms.Label
        Friend WithEvents dgvMsi As VWS.iSenseOpenLib.VariedDataGridView
        Friend WithEvents lblAct As System.Windows.Forms.Label
        Friend WithEvents lblSpl As System.Windows.Forms.Label
        Friend WithEvents lblBlsDeliCd As System.Windows.Forms.Label
        Friend WithEvents lblDeliNm As System.Windows.Forms.Label
        Friend WithEvents datArrivalDate As VWS.iSenseOpenLib.CutBlankDateFromTo
        Friend WithEvents txtVendorNm As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents colCompSpec As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colSpec As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtVendorCD As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents NyuKaKb As VWS.iSenseOpenLib.NamedComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblStartTime As System.Windows.Forms.Label
        Friend WithEvents lblEndTime As System.Windows.Forms.Label
        Friend WithEvents lblSplVal As System.Windows.Forms.Label
        Friend WithEvents lblActVal As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblProcVal As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents picGraph1 As VWS.iSenseOpenLib.BarGraph
        Friend WithEvents picGraph As VWS.iSenseOpenLib.BarGraph
        Friend WithEvents lblProcVal1 As System.Windows.Forms.Label
        Friend WithEvents lblActVal1 As System.Windows.Forms.Label
        Friend WithEvents lblSplVal1 As System.Windows.Forms.Label
        Friend WithEvents colBlsDeliCd As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colBlsDeliNm As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colStartTime As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colEndTime As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colTotalCnt As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colCompCnt As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colProcPer As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colProc As VWS.iSenseOpenLib.BarGraphColumn

    End Class

End Namespace
