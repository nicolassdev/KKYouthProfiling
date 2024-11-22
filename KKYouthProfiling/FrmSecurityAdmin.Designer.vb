<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSecurityAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        IconValidation = New FontAwesome.Sharp.IconPictureBox()
        lblFormTitle = New Label()
        txtSecUsername = New TextBox()
        txtSecPassword = New TextBox()
        IconBtnSecLogin = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        Label2 = New Label()
        CType(IconValidation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IconValidation
        ' 
        IconValidation.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconValidation.ForeColor = Color.FromArgb(CByte(240), CByte(56), CByte(56))
        IconValidation.IconChar = FontAwesome.Sharp.IconChar.Warning
        IconValidation.IconColor = Color.FromArgb(CByte(240), CByte(56), CByte(56))
        IconValidation.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconValidation.IconSize = 526
        IconValidation.Location = New Point(33, -34)
        IconValidation.Name = "IconValidation"
        IconValidation.Size = New Size(526, 532)
        IconValidation.SizeMode = PictureBoxSizeMode.StretchImage
        IconValidation.TabIndex = 1
        IconValidation.TabStop = False
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.BackColor = Color.Transparent
        lblFormTitle.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFormTitle.ForeColor = Color.White
        lblFormTitle.Location = New Point(433, 216)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(220, 28)
        lblFormTitle.TabIndex = 5
        lblFormTitle.Text = "SECURITY VALIDATION"
        ' 
        ' txtSecUsername
        ' 
        txtSecUsername.Font = New Font("Segoe UI", 12F)
        txtSecUsername.Location = New Point(402, 286)
        txtSecUsername.Name = "txtSecUsername"
        txtSecUsername.PlaceholderText = "   Username"
        txtSecUsername.Size = New Size(285, 29)
        txtSecUsername.TabIndex = 6
        ' 
        ' txtSecPassword
        ' 
        txtSecPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSecPassword.Location = New Point(402, 331)
        txtSecPassword.Multiline = True
        txtSecPassword.Name = "txtSecPassword"
        txtSecPassword.PasswordChar = "*"c
        txtSecPassword.PlaceholderText = "   Password"
        txtSecPassword.Size = New Size(285, 30)
        txtSecPassword.TabIndex = 7
        ' 
        ' IconBtnSecLogin
        ' 
        IconBtnSecLogin.BackColor = Color.DodgerBlue
        IconBtnSecLogin.FlatAppearance.BorderColor = Color.DodgerBlue
        IconBtnSecLogin.FlatAppearance.BorderSize = 2
        IconBtnSecLogin.FlatStyle = FlatStyle.Flat
        IconBtnSecLogin.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconBtnSecLogin.ForeColor = Color.White
        IconBtnSecLogin.IconChar = FontAwesome.Sharp.IconChar.None
        IconBtnSecLogin.IconColor = Color.Black
        IconBtnSecLogin.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnSecLogin.Location = New Point(402, 393)
        IconBtnSecLogin.Name = "IconBtnSecLogin"
        IconBtnSecLogin.Size = New Size(285, 37)
        IconBtnSecLogin.TabIndex = 8
        IconBtnSecLogin.Text = "Login"
        IconBtnSecLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(411, 451)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 19)
        Label1.TabIndex = 10
        Label1.Text = "Only the admin has full access to this form."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(249), CByte(36), CByte(36))
        Label2.Location = New Point(370, 451)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 19)
        Label2.TabIndex = 10
        Label2.Text = "Note:"
        ' 
        ' FrmSecurityAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        ClientSize = New Size(946, 659)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(IconBtnSecLogin)
        Controls.Add(txtSecPassword)
        Controls.Add(txtSecUsername)
        Controls.Add(lblFormTitle)
        Controls.Add(IconValidation)
        Name = "FrmSecurityAdmin"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Security"
        CType(IconValidation, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IconValidation As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents txtSecUsername As TextBox
    Friend WithEvents txtSecPassword As TextBox
    Friend WithEvents IconBtnSecLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
