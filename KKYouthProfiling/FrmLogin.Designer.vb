<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        IconSeePass = New FontAwesome.Sharp.IconButton()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        IconAdmin = New FontAwesome.Sharp.IconPictureBox()
        IconLock = New FontAwesome.Sharp.IconPictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(IconAdmin, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconLock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.skb1
        PictureBox1.Location = New Point(31, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(421, 398)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(232, 494)
        Label1.Name = "Label1"
        Label1.Size = New Size(387, 20)
        Label1.TabIndex = 1
        Label1.Text = "© 2024 : KK Youth Profiling System. All Rights Reserved"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(IconSeePass)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(IconButton1)
        GroupBox1.Controls.Add(IconAdmin)
        GroupBox1.Controls.Add(IconLock)
        GroupBox1.Font = New Font("Conthrax Sb", 14.0F, FontStyle.Bold)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(481, 81)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(335, 354)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "ADMIN LOGIN"
        ' 
        ' IconSeePass
        ' 
        IconSeePass.FlatAppearance.BorderColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconSeePass.FlatAppearance.BorderSize = 0
        IconSeePass.FlatStyle = FlatStyle.Flat
        IconSeePass.IconChar = FontAwesome.Sharp.IconChar.Eye
        IconSeePass.IconColor = Color.White
        IconSeePass.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconSeePass.IconSize = 30
        IconSeePass.Location = New Point(297, 184)
        IconSeePass.Name = "IconSeePass"
        IconSeePass.Size = New Size(28, 29)
        IconSeePass.TabIndex = 3
        IconSeePass.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(80, 183)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "   Password"
        txtPassword.Size = New Size(211, 30)
        txtPassword.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12.0F)
        txtUsername.Location = New Point(80, 114)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "   Username"
        txtUsername.Size = New Size(211, 29)
        txtUsername.TabIndex = 2
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.DodgerBlue
        IconButton1.FlatAppearance.BorderColor = Color.DodgerBlue
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(80, 248)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(211, 47)
        IconButton1.TabIndex = 4
        IconButton1.Text = "Login"
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' IconAdmin
        ' 
        IconAdmin.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconAdmin.IconChar = FontAwesome.Sharp.IconChar.User
        IconAdmin.IconColor = Color.White
        IconAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconAdmin.IconSize = 40
        IconAdmin.Location = New Point(24, 107)
        IconAdmin.Name = "IconAdmin"
        IconAdmin.Size = New Size(50, 40)
        IconAdmin.SizeMode = PictureBoxSizeMode.Zoom
        IconAdmin.TabIndex = 0
        IconAdmin.TabStop = False
        ' 
        ' IconLock
        ' 
        IconLock.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconLock.IconChar = FontAwesome.Sharp.IconChar.Lock
        IconLock.IconColor = Color.White
        IconLock.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconLock.IconSize = 40
        IconLock.Location = New Point(24, 173)
        IconLock.Name = "IconLock"
        IconLock.Size = New Size(50, 40)
        IconLock.SizeMode = PictureBoxSizeMode.Zoom
        IconLock.TabIndex = 0
        IconLock.TabStop = False
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        ClientSize = New Size(867, 523)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(IconAdmin, ComponentModel.ISupportInitialize).EndInit()
        CType(IconLock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IconLock As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconAdmin As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents IconSeePass As FontAwesome.Sharp.IconButton
End Class
