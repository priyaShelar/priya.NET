Namespace Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVSMSA010_01
        Inherits VWS.VSMS.VSMSLib.Base.Form.frmVSMSBase002

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
            Me.lblSysNmMain = New System.Windows.Forms.Label
            Me.lblSysNmSub = New System.Windows.Forms.Label
            Me.grpLogIn = New System.Windows.Forms.GroupBox
            Me.txtPassword = New VWS.iSenseOpenLib.VariedTextBox
            Me.txtUserId = New VWS.iSenseOpenLib.VariedTextBox
            Me.lblPassword = New System.Windows.Forms.Label
            Me.lblUserId = New System.Windows.Forms.Label
            Me.btnLogIn = New System.Windows.Forms.Button
            Me.btnQuit = New System.Windows.Forms.Button
            Me.pnlControl06.SuspendLayout()
            Me.pnlControl05.SuspendLayout()
            Me.pnlControl04.SuspendLayout()
            Me.pnlControl03.SuspendLayout()
            Me.pnlControl02.SuspendLayout()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBase.SuspendLayout()
            Me.grpLogIn.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnReports
            '
            Me.btnReports.Location = New System.Drawing.Point(1001, 2)
            Me.btnReports.Size = New System.Drawing.Size(10, 30)
            Me.btnReports.Visible = False
            '
            'pnlControl06
            '
            Me.pnlControl06.Controls.Add(Me.btnQuit)
            Me.pnlControl06.Controls.Add(Me.btnLogIn)
            Me.pnlControl06.Controls.Add(Me.grpLogIn)
            Me.pnlControl06.Location = New System.Drawing.Point(0, 91)
            Me.pnlControl06.Size = New System.Drawing.Size(1016, 612)
            Me.pnlControl06.Controls.SetChildIndex(Me.grpLogIn, 0)
            Me.pnlControl06.Controls.SetChildIndex(Me.btnLogIn, 0)
            Me.pnlControl06.Controls.SetChildIndex(Me.lblMessage, 0)
            Me.pnlControl06.Controls.SetChildIndex(Me.btnQuit, 0)
            '
            'lblMessage
            '
            Me.lblMessage.Text = ""
            '
            'pnlControl05
            '
            Me.pnlControl05.BackColor = System.Drawing.Color.Blue
            Me.pnlControl05.Controls.Add(Me.lblSysNmSub)
            Me.pnlControl05.Controls.Add(Me.lblSysNmMain)
            Me.pnlControl05.Location = New System.Drawing.Point(0, 0)
            Me.pnlControl05.Size = New System.Drawing.Size(1016, 91)
            Me.pnlControl05.Controls.SetChildIndex(Me.lblSysNmMain, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnClose, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnMenu, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnExit, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.btnReports, 0)
            Me.pnlControl05.Controls.SetChildIndex(Me.lblSysNmSub, 0)
            '
            'btnClose
            '
            Me.btnClose.Location = New System.Drawing.Point(1001, 2)
            Me.btnClose.Size = New System.Drawing.Size(10, 30)
            Me.btnClose.Visible = False
            '
            'btnExit
            '
            Me.btnExit.Location = New System.Drawing.Point(1001, 2)
            Me.btnExit.Size = New System.Drawing.Size(10, 30)
            Me.btnExit.Visible = False
            '
            'btnMenu
            '
            Me.btnMenu.Location = New System.Drawing.Point(1002, 2)
            Me.btnMenu.Size = New System.Drawing.Size(10, 30)
            Me.btnMenu.Visible = False
            '
            'pnlControl04
            '
            Me.pnlControl04.Location = New System.Drawing.Point(316, -42)
            Me.pnlControl04.Visible = False
            '
            'lblMenu
            '
            Me.lblMenu.Text = ""
            Me.lblMenu.Visible = False
            '
            'pnlControl03
            '
            Me.pnlControl03.Visible = False
            '
            'lblYmd
            '
            Me.lblYmd.Text = "2016/01/08 16:43:11"
            Me.lblYmd.Visible = False
            '
            'lblUser
            '
            Me.lblUser.Text = " / "
            Me.lblUser.Visible = False
            '
            'lblSysNmMain
            '
            Me.lblSysNmMain.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblSysNmMain.ForeColor = System.Drawing.Color.White
            Me.lblSysNmMain.Location = New System.Drawing.Point(3, 14)
            Me.lblSysNmMain.Name = "lblSysNmMain"
            Me.lblSysNmMain.Size = New System.Drawing.Size(1008, 60)
            Me.lblSysNmMain.TabIndex = 6
            Me.lblSysNmMain.Text = "音声物流システム"
            Me.lblSysNmMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblSysNmSub
            '
            Me.lblSysNmSub.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblSysNmSub.ForeColor = System.Drawing.Color.White
            Me.lblSysNmSub.Location = New System.Drawing.Point(760, 70)
            Me.lblSysNmSub.Name = "lblSysNmSub"
            Me.lblSysNmSub.Size = New System.Drawing.Size(250, 16)
            Me.lblSysNmSub.TabIndex = 7
            Me.lblSysNmSub.Text = "～ Voice Warehouse System ～"
            '
            'grpLogIn
            '
            Me.grpLogIn.BackColor = System.Drawing.Color.Transparent
            Me.grpLogIn.Controls.Add(Me.txtPassword)
            Me.grpLogIn.Controls.Add(Me.txtUserId)
            Me.grpLogIn.Controls.Add(Me.lblPassword)
            Me.grpLogIn.Controls.Add(Me.lblUserId)
            Me.grpLogIn.ForeColor = System.Drawing.SystemColors.ControlText
            Me.grpLogIn.Location = New System.Drawing.Point(260, 100)
            Me.grpLogIn.Name = "grpLogIn"
            Me.grpLogIn.Size = New System.Drawing.Size(488, 222)
            Me.grpLogIn.TabIndex = 15
            Me.grpLogIn.TabStop = False
            '
            'txtPassword
            '
            Me.txtPassword.HalfWidthCharacters = False
            Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtPassword.InputComma = True
            Me.txtPassword.Location = New System.Drawing.Point(200, 130)
            Me.txtPassword.MaxByteLength = 8
            Me.txtPassword.MaxMojiLength = 8
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(200, 19)
            Me.txtPassword.TabIndex = 1
            Me.txtPassword.Text = "1234567890"
            '
            'txtUserId
            '
            Me.txtUserId.HalfWidthCharacters = False
            Me.txtUserId.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtUserId.InputComma = True
            Me.txtUserId.Location = New System.Drawing.Point(200, 86)
            Me.txtUserId.MaxByteLength = 10
            Me.txtUserId.MaxMojiLength = 10
            Me.txtUserId.Name = "txtUserId"
            Me.txtUserId.Size = New System.Drawing.Size(200, 19)
            Me.txtUserId.TabIndex = 0
            Me.txtUserId.Text = "1234567890"
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblPassword.Location = New System.Drawing.Point(82, 130)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(75, 16)
            Me.lblPassword.TabIndex = 1
            Me.lblPassword.Text = "パスワード"
            '
            'lblUserId
            '
            Me.lblUserId.AutoSize = True
            Me.lblUserId.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.lblUserId.Location = New System.Drawing.Point(82, 86)
            Me.lblUserId.Name = "lblUserId"
            Me.lblUserId.Size = New System.Drawing.Size(24, 16)
            Me.lblUserId.TabIndex = 0
            Me.lblUserId.Text = "ID"
            '
            'btnLogIn
            '
            Me.btnLogIn.BackColor = System.Drawing.Color.Blue
            Me.btnLogIn.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.btnLogIn.ForeColor = System.Drawing.Color.White
            Me.btnLogIn.Location = New System.Drawing.Point(670, 500)
            Me.btnLogIn.Name = "btnLogIn"
            Me.btnLogIn.Size = New System.Drawing.Size(130, 50)
            Me.btnLogIn.TabIndex = 16
            Me.btnLogIn.Text = "ログイン"
            Me.btnLogIn.UseVisualStyleBackColor = False
            '
            'btnQuit
            '
            Me.btnQuit.BackColor = System.Drawing.Color.Red
            Me.btnQuit.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
            Me.btnQuit.ForeColor = System.Drawing.Color.White
            Me.btnQuit.Location = New System.Drawing.Point(828, 500)
            Me.btnQuit.Name = "btnQuit"
            Me.btnQuit.Size = New System.Drawing.Size(130, 50)
            Me.btnQuit.TabIndex = 17
            Me.btnQuit.Text = "終了"
            Me.btnQuit.UseVisualStyleBackColor = False
            '
            'frmVSMSA010_01
            '
            Me.AcceptButton = Me.btnLogIn
            Me.ClientSize = New System.Drawing.Size(1016, 703)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Name = "frmVSMSA010_01"
            Me.Text = "frmVSMSA010_01 [  ]"
            Me.pnlControl06.ResumeLayout(False)
            Me.pnlControl05.ResumeLayout(False)
            Me.pnlControl04.ResumeLayout(False)
            Me.pnlControl03.ResumeLayout(False)
            Me.pnlControl02.ResumeLayout(False)
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBase.ResumeLayout(False)
            Me.grpLogIn.ResumeLayout(False)
            Me.grpLogIn.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblSysNmSub As System.Windows.Forms.Label
        Friend WithEvents lblSysNmMain As System.Windows.Forms.Label
        Friend WithEvents grpLogIn As System.Windows.Forms.GroupBox
        Friend WithEvents lblUserId As System.Windows.Forms.Label
        Friend WithEvents btnLogIn As System.Windows.Forms.Button
        Friend WithEvents txtPassword As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents txtUserId As VWS.iSenseOpenLib.VariedTextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents btnQuit As System.Windows.Forms.Button

    End Class

End Namespace

