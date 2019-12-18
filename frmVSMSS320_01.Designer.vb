Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVSMSS320_01
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
            Me.picGraph = New VWS.iSenseOpenLib.BarGraph
            Me.lblStart = New System.Windows.Forms.Label
            Me.lblEnd = New System.Windows.Forms.Label
            Me.dgvMsi = New VWS.iSenseOpenLib.VariedDataGridView(Me.components)
            Me.colTanaOroshiNo = New VWS.iSenseOpenLib.VariedTextBoxColumn
            Me.colZone = New VWS.iSenseOpenLib.VariedTextBoxColumn
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
            Me.datShipDate = New VWS.iSenseOpenLib.CutBlankDateFromTo
            Me.txtTanaOroshiNo = New VWS.iSenseOpenLib.VariedTextBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.txtZone = New VWS.iSenseOpenLib.VariedTextBox
            Me.cmbTanaOroshiKbn = New VWS.iSenseOpenLib.NamedComboBox(Me.components)
            Me.lblStartTime = New System.Windows.Forms.Label
            Me.lblEndTime = New System.Windows.Forms.Label
            Me.lblSplVal = New System.Windows.Forms.Label
            Me.lblActVal = New System.Windows.Forms.Label
            Me.lblProcVal = New System.Windows.Forms.Label
            Me.pnlControl06.SuspendLayout()
            Me.pnlControl07.SuspendLayout()
            Me.pnlControl08.SuspendLayout()
            Me.pnlControl05.SuspendLayout()
            Me.pnlControl04.SuspendLayout()
            Me.pnlControl03.SuspendLayout()
            Me.pnlControl02.SuspendLayout()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBase.SuspendLayout()
            CType(Me.picGraph, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvMsi, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblTotal_Ken
            '
            Me.lblTotal_Ken.Location = New System.Drawing.Point(911, 534)
            Me.lblTotal_Ken.Visible = False
            '
            'lblTotal
            '
            Me.lblTotal.Location = New System.Drawing.Point(785, 534)
            Me.lblTotal.Visible = False
            '
            'lblTotal_Title
            '
            Me.lblTotal_Title.Location = New System.Drawing.Point(724, 534)
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
            Me.btnNext.Location = New System.Drawing.Point(210, 49)
            Me.btnNext.Size = New System.Drawing.Size(10, 30)
            Me.btnNext.Visible = False
            '
            'btnPrev
            '
            Me.btnPrev.Location = New System.Drawing.Point(194, 49)
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
            Me.pnlControl07.Controls.Add(Me.cmbTanaOroshiKbn)
            Me.pnlControl07.Controls.Add(Me.txtZone)
            Me.pnlControl07.Controls.Add(Me.Label1)
            Me.pnlControl07.Controls.Add(Me.txtTanaOroshiNo)
            Me.pnlControl07.Controls.Add(Me.datShipDate)
            Me.pnlControl07.Controls.Add(Me.lblDeliNm)
            Me.pnlControl07.Controls.Add(Me.lblBlsDeliCd)
            Me.pnlControl07.Controls.Add(Me.lblProcDate)
            Me.pnlControl07.Location = New System.Drawing.Point(0, 77)
            Me.pnlControl07.Size = New System.Drawing.Size(1016, 67)
            Me.pnlControl07.TabIndex = 1
            '
            'pnlControl08
            '
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
            Me.pnlControl08.Controls.SetChildIndex(Me.btnSelect, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnDeSelect, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnAdd, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnDelete, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnPrev, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.btnNext, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal_Title, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblTotal_Ken, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblStartTime, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblEndTime, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblSplVal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblActVal, 0)
            Me.pnlControl08.Controls.SetChildIndex(Me.lblProcVal, 0)
            '
            'btnDeSelect
            '
            Me.btnDeSelect.Location = New System.Drawing.Point(58, 49)
            Me.btnDeSelect.Size = New System.Drawing.Size(10, 30)
            Me.btnDeSelect.Visible = False
            '
            'btnSelect
            '
            Me.btnSelect.Location = New System.Drawing.Point(42, 49)
            Me.btnSelect.Size = New System.Drawing.Size(10, 30)
            Me.btnSelect.Visible = False
            '
            'btnDelete
            '
            Me.btnDelete.Location = New System.Drawing.Point(90, 49)
            Me.btnDelete.Size = New System.Drawing.Size(10, 30)
            Me.btnDelete.Visible = False
            '
            'btnAdd
            '
            Me.btnAdd.Location = New System.Drawing.Point(74, 49)
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
            Me.btnClose.Location = New System.Drawing.Point(250, 2)
            Me.btnClose.Size = New System.Drawing.Size(18, 30)
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
            Me.lblMenu.Text = "棚卸進捗照会"
            '
            'lblYmd
            '
            Me.lblYmd.Text = "2019/12/05 12:12:07"
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
            Me.lblProcDate.Location = New System.Drawing.Point(29, 26)
            Me.lblProcDate.Name = "lblProcDate"
            Me.lblProcDate.Size = New System.Drawing.Size(44, 12)
            Me.lblProcDate.TabIndex = 1
            Me.lblProcDate.Text = "作業日"
            '
            'lblUnfinSts
            '
            Me.lblUnfinSts.AutoSize = True
            Me.lblUnfinSts.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblUnfinSts.Location = New System.Drawing.Point(945, 18)
            Me.lblUnfinSts.Name = "lblUnfinSts"
            Me.lblUnfinSts.Size = New System.Drawing.Size(44, 12)
            Me.lblUnfinSts.TabIndex = 121
            Me.lblUnfinSts.Text = "未完了"
            '
            'lbl100per
            '
            Me.lbl100per.AutoSize = True
            Me.lbl100per.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lbl100per.Location = New System.Drawing.Point(952, 76)
            Me.lbl100per.Name = "lbl100per"
            Me.lbl100per.Size = New System.Drawing.Size(29, 12)
            Me.lbl100per.TabIndex = 116
            Me.lbl100per.Text = "100%"
            '
            'lbl50per
            '
            Me.lbl50per.AutoSize = True
            Me.lbl50per.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lbl50per.Location = New System.Drawing.Point(761, 76)
            Me.lbl50per.Name = "lbl50per"
            Me.lbl50per.Size = New System.Drawing.Size(23, 12)
            Me.lbl50per.TabIndex = 115
            Me.lbl50per.Text = "50%"
            '
            'lbl0per
            '
            Me.lbl0per.AutoSize = True
            Me.lbl0per.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lbl0per.Location = New System.Drawing.Point(589, 76)
            Me.lbl0per.Name = "lbl0per"
            Me.lbl0per.Size = New System.Drawing.Size(17, 12)
            Me.lbl0per.TabIndex = 114
            Me.lbl0per.Text = "0%"
            '
            'lblFinSts
            '
            Me.lblFinSts.AutoSize = True
            Me.lblFinSts.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblFinSts.Location = New System.Drawing.Point(841, 18)
            Me.lblFinSts.Name = "lblFinSts"
            Me.lblFinSts.Size = New System.Drawing.Size(31, 12)
            Me.lblFinSts.TabIndex = 119
            Me.lblFinSts.Text = "完了"
            '
            'lblWhite
            '
            Me.lblWhite.BackColor = System.Drawing.Color.White
            Me.lblWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblWhite.Location = New System.Drawing.Point(890, 13)
            Me.lblWhite.Name = "lblWhite"
            Me.lblWhite.Size = New System.Drawing.Size(52, 21)
            Me.lblWhite.TabIndex = 120
            Me.lblWhite.Text = " "
            '
            'lblBlue
            '
            Me.lblBlue.BackColor = System.Drawing.Color.Blue
            Me.lblBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblBlue.Location = New System.Drawing.Point(785, 13)
            Me.lblBlue.Name = "lblBlue"
            Me.lblBlue.Size = New System.Drawing.Size(52, 21)
            Me.lblBlue.TabIndex = 118
            Me.lblBlue.Text = " "
            '
            'lblPorc
            '
            Me.lblPorc.AutoSize = True
            Me.lblPorc.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblPorc.Location = New System.Drawing.Point(541, 89)
            Me.lblPorc.Name = "lblPorc"
            Me.lblPorc.Size = New System.Drawing.Size(44, 12)
            Me.lblPorc.TabIndex = 112
            Me.lblPorc.Text = "進捗率"
            '
            'picGraph
            '
            Me.picGraph.BackColor = System.Drawing.SystemColors.Window
            Me.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picGraph.ColorCompletion = System.Drawing.Color.Blue
            Me.picGraph.ColorIncomplete = System.Drawing.Color.White
            Me.picGraph.ColorMissing = System.Drawing.Color.Red
            Me.picGraph.GraphValue = "0"
            Me.picGraph.Location = New System.Drawing.Point(591, 91)
            Me.picGraph.Name = "picGraph"
            Me.picGraph.Size = New System.Drawing.Size(390, 35)
            Me.picGraph.StatusPattern = VWS.iSenseOpenLib.BarGraph.Status.COMPLETION_INCOMPLETE
            Me.picGraph.TabIndex = 286
            Me.picGraph.TabStop = False
            '
            'lblStart
            '
            Me.lblStart.AutoSize = True
            Me.lblStart.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblStart.Location = New System.Drawing.Point(239, 89)
            Me.lblStart.Name = "lblStart"
            Me.lblStart.Size = New System.Drawing.Size(57, 12)
            Me.lblStart.TabIndex = 104
            Me.lblStart.Text = "開始時間"
            '
            'lblEnd
            '
            Me.lblEnd.AutoSize = True
            Me.lblEnd.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblEnd.Location = New System.Drawing.Point(313, 89)
            Me.lblEnd.Name = "lblEnd"
            Me.lblEnd.Size = New System.Drawing.Size(57, 12)
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
            Me.dgvMsi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTanaOroshiNo, Me.colZone, Me.colStartTime, Me.colEndTime, Me.colTotalCnt, Me.colCompCnt, Me.colProcPer, Me.colProc})
            Me.dgvMsi.EnableHeadersVisualStyles = False
            Me.dgvMsi.KeyAction = VWS.iSenseOpenLib.VariedDataGridView.KeyActions.NotSet
            Me.dgvMsi.Location = New System.Drawing.Point(26, 130)
            Me.dgvMsi.MoveEditCell = True
            Me.dgvMsi.Name = "dgvMsi"
            Me.dgvMsi.ReadOnly = True
            Me.dgvMsi.RowHeadersWidth = 50
            Me.dgvMsi.RowTemplate.Height = 21
            Me.dgvMsi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvMsi.Size = New System.Drawing.Size(963, 416)
            Me.dgvMsi.TabIndex = 1
            Me.dgvMsi.TabStop = False
            '
            'colTanaOroshiNo
            '
            Me.colTanaOroshiNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colTanaOroshiNo.EditBackColor = System.Drawing.SystemColors.Window
            Me.colTanaOroshiNo.HalfWidthCharacters = False
            Me.colTanaOroshiNo.HeaderText = "棚卸NO"
            Me.colTanaOroshiNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colTanaOroshiNo.InputComma = True
            Me.colTanaOroshiNo.MaxByteLength = 65535
            Me.colTanaOroshiNo.MaxMojiLength = 32767
            Me.colTanaOroshiNo.Name = "colTanaOroshiNo"
            Me.colTanaOroshiNo.ReadOnly = True
            Me.colTanaOroshiNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colTanaOroshiNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colTanaOroshiNo.Width = 90
            '
            'colZone
            '
            Me.colZone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            Me.colZone.EditBackColor = System.Drawing.SystemColors.Window
            Me.colZone.HalfWidthCharacters = False
            Me.colZone.HeaderText = "ゾーン"
            Me.colZone.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.colZone.InputComma = True
            Me.colZone.MaxByteLength = 65535
            Me.colZone.MaxMojiLength = 32767
            Me.colZone.Name = "colZone"
            Me.colZone.ReadOnly = True
            Me.colZone.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colZone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.colZone.Width = 70
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
            Me.colTotalCnt.HeaderText = "指示明細数"
            Me.colTotalCnt.IntegerLength = 32767
            Me.colTotalCnt.Minus = False
            Me.colTotalCnt.Name = "colTotalCnt"
            Me.colTotalCnt.ReadOnly = True
            Me.colTotalCnt.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colTotalCnt.Units = ""
            Me.colTotalCnt.Width = 78
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
            Me.colCompCnt.Width = 78
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
            Me.colProcPer.Width = 50
            '
            'colProc
            '
            Me.colProc.ColorCompletion = System.Drawing.Color.Blue
            Me.colProc.ColorIncomplete = System.Drawing.Color.White
            Me.colProc.ColorMissing = System.Drawing.Color.Red
            Me.colProc.HeaderText = "0%                                         50%                                   " & _
                "        100%"
            Me.colProc.Name = "colProc"
            Me.colProc.ReadOnly = True
            Me.colProc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.colProc.StatusPattern = VWS.iSenseOpenLib.BarGraphColumn.Status.COMPLETION_INCOMPLETE
            Me.colProc.Width = 405
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
            Me.lblSpl.Location = New System.Drawing.Point(387, 89)
            Me.lblSpl.Name = "lblSpl"
            Me.lblSpl.Size = New System.Drawing.Size(70, 12)
            Me.lblSpl.TabIndex = 108
            Me.lblSpl.Text = "指示明細数"
            '
            'lblAct
            '
            Me.lblAct.AutoSize = True
            Me.lblAct.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblAct.Location = New System.Drawing.Point(463, 89)
            Me.lblAct.Name = "lblAct"
            Me.lblAct.Size = New System.Drawing.Size(70, 12)
            Me.lblAct.TabIndex = 110
            Me.lblAct.Text = "完了明細数"
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
            Me.lblDeliNm.Location = New System.Drawing.Point(549, 26)
            Me.lblDeliNm.Name = "lblDeliNm"
            Me.lblDeliNm.Size = New System.Drawing.Size(49, 12)
            Me.lblDeliNm.TabIndex = 5
            Me.lblDeliNm.Text = "棚卸NO"
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
            'txtTanaOroshiNo
            '
            Me.txtTanaOroshiNo.HalfWidthCharacters = False
            Me.txtTanaOroshiNo.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtTanaOroshiNo.InputComma = False
            Me.txtTanaOroshiNo.Location = New System.Drawing.Point(619, 22)
            Me.txtTanaOroshiNo.MaxByteLength = 180
            Me.txtTanaOroshiNo.MaxMojiLength = 8
            Me.txtTanaOroshiNo.Name = "txtTanaOroshiNo"
            Me.txtTanaOroshiNo.Size = New System.Drawing.Size(108, 19)
            Me.txtTanaOroshiNo.TabIndex = 13
            Me.txtTanaOroshiNo.Text = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(417, 26)
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
            Me.txtZone.Location = New System.Drawing.Point(473, 22)
            Me.txtZone.MaxByteLength = 5
            Me.txtZone.MaxMojiLength = 2
            Me.txtZone.Name = "txtZone"
            Me.txtZone.Size = New System.Drawing.Size(49, 19)
            Me.txtZone.TabIndex = 12
            Me.txtZone.Text = "12345"
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
            'lblStartTime
            '
            Me.lblStartTime.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblStartTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lblStartTime.Location = New System.Drawing.Point(239, 113)
            Me.lblStartTime.Name = "lblStartTime"
            Me.lblStartTime.Size = New System.Drawing.Size(55, 14)
            Me.lblStartTime.TabIndex = 290
            Me.lblStartTime.Text = "-"
            '
            'lblEndTime
            '
            Me.lblEndTime.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblEndTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft
            Me.lblEndTime.Location = New System.Drawing.Point(313, 113)
            Me.lblEndTime.Name = "lblEndTime"
            Me.lblEndTime.Size = New System.Drawing.Size(55, 12)
            Me.lblEndTime.TabIndex = 289
            Me.lblEndTime.Text = "-"
            '
            'lblSplVal
            '
            Me.lblSplVal.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblSplVal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblSplVal.Location = New System.Drawing.Point(396, 110)
            Me.lblSplVal.Name = "lblSplVal"
            Me.lblSplVal.Size = New System.Drawing.Size(58, 14)
            Me.lblSplVal.TabIndex = 291
            Me.lblSplVal.Text = "-"
            Me.lblSplVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblActVal
            '
            Me.lblActVal.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblActVal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblActVal.Location = New System.Drawing.Point(471, 108)
            Me.lblActVal.Name = "lblActVal"
            Me.lblActVal.Size = New System.Drawing.Size(59, 16)
            Me.lblActVal.TabIndex = 292
            Me.lblActVal.Text = "-"
            Me.lblActVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblProcVal
            '
            Me.lblProcVal.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblProcVal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblProcVal.Location = New System.Drawing.Point(537, 110)
            Me.lblProcVal.Name = "lblProcVal"
            Me.lblProcVal.Size = New System.Drawing.Size(48, 16)
            Me.lblProcVal.TabIndex = 293
            Me.lblProcVal.Text = "-"
            Me.lblProcVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'frmVSMSS320_01
            '
            Me.ClientSize = New System.Drawing.Size(1016, 703)
            Me.Name = "frmVSMSS320_01"
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
            CType(Me.picGraph, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvMsi, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents picGraph As VWS.iSenseOpenLib.BarGraph
        Friend WithEvents lblStart As System.Windows.Forms.Label
        Friend WithEvents lblEnd As System.Windows.Forms.Label
        Friend WithEvents dgvMsi As VWS.iSenseOpenLib.VariedDataGridView
        Friend WithEvents lblAct As System.Windows.Forms.Label
        Friend WithEvents lblSpl As System.Windows.Forms.Label
        Friend WithEvents lblBlsDeliCd As System.Windows.Forms.Label
        Friend WithEvents lblDeliNm As System.Windows.Forms.Label
        Friend WithEvents datShipDate As VWS.iSenseOpenLib.CutBlankDateFromTo
        Friend WithEvents txtTanaOroshiNo As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents colCompSpec As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colSpec As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtZone As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents cmbTanaOroshiKbn As VWS.iSenseOpenLib.NamedComboBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents lblStartTime As System.Windows.Forms.Label
        Friend WithEvents lblEndTime As System.Windows.Forms.Label
        Friend WithEvents lblSplVal As System.Windows.Forms.Label
        Friend WithEvents lblActVal As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents lblProcVal As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents colTanaOroshiNo As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colZone As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colStartTime As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colEndTime As VWS.iSenseOpenLib.VariedTextBoxColumn
        Friend WithEvents colTotalCnt As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colCompCnt As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colProcPer As VWS.iSenseOpenLib.NumEditColumn
        Friend WithEvents colProc As VWS.iSenseOpenLib.BarGraphColumn

    End Class

End Namespace
