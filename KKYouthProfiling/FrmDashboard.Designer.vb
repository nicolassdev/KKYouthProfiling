<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        PanelDash = New Panel()
        btnLogout = New FontAwesome.Sharp.IconButton()
        btnReports = New FontAwesome.Sharp.IconButton()
        btnProfile = New FontAwesome.Sharp.IconButton()
        btnYouth = New FontAwesome.Sharp.IconButton()
        btnDashboard = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        imgHome = New PictureBox()
        PanelNavbar = New Panel()
        IconBtnMinimize = New FontAwesome.Sharp.IconButton()
        IconBtnMaximize = New FontAwesome.Sharp.IconButton()
        btnSetting = New FontAwesome.Sharp.IconButton()
        lblFormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelAdminProfile = New Panel()
        IconHoverAdmin = New FontAwesome.Sharp.IconButton()
        PanelDesktop = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        LblUser = New Label()
        Label7 = New Label()
        lblTime = New Label()
        Label6 = New Label()
        lblDate = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Timer1 = New Timer(components)
        DateAndTime = New Timer(components)
        PanelDash.SuspendLayout()
        Panel1.SuspendLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).BeginInit()
        PanelNavbar.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
        PanelAdminProfile.SuspendLayout()
        PanelDesktop.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelDash
        ' 
        PanelDash.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        PanelDash.Controls.Add(btnLogout)
        PanelDash.Controls.Add(btnReports)
        PanelDash.Controls.Add(btnProfile)
        PanelDash.Controls.Add(btnYouth)
        PanelDash.Controls.Add(btnDashboard)
        PanelDash.Controls.Add(Panel1)
        PanelDash.Dock = DockStyle.Left
        PanelDash.Location = New Point(0, 0)
        PanelDash.Name = "PanelDash"
        PanelDash.Size = New Size(200, 512)
        PanelDash.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Gainsboro
        btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut
        btnLogout.IconColor = Color.White
        btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLogout.IconSize = 40
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 452)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(10, 0, 20, 0)
        btnLogout.Size = New Size(200, 60)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Dock = DockStyle.Top
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReports.ForeColor = Color.Gainsboro
        btnReports.IconChar = FontAwesome.Sharp.IconChar.File
        btnReports.IconColor = Color.White
        btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnReports.IconSize = 40
        btnReports.ImageAlign = ContentAlignment.MiddleLeft
        btnReports.Location = New Point(0, 307)
        btnReports.Name = "btnReports"
        btnReports.Padding = New Padding(10, 0, 20, 0)
        btnReports.Size = New Size(200, 60)
        btnReports.TabIndex = 5
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.TextImageRelation = TextImageRelation.ImageBeforeText
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnProfile
        ' 
        btnProfile.Dock = DockStyle.Top
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProfile.ForeColor = Color.Gainsboro
        btnProfile.IconChar = FontAwesome.Sharp.IconChar.Vcard
        btnProfile.IconColor = Color.White
        btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnProfile.IconSize = 40
        btnProfile.ImageAlign = ContentAlignment.MiddleLeft
        btnProfile.Location = New Point(0, 247)
        btnProfile.Name = "btnProfile"
        btnProfile.Padding = New Padding(10, 0, 20, 0)
        btnProfile.Size = New Size(200, 60)
        btnProfile.TabIndex = 3
        btnProfile.Text = "Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        btnProfile.TextImageRelation = TextImageRelation.ImageBeforeText
        btnProfile.UseVisualStyleBackColor = True
        ' 
        ' btnYouth
        ' 
        btnYouth.Dock = DockStyle.Top
        btnYouth.FlatAppearance.BorderSize = 0
        btnYouth.FlatStyle = FlatStyle.Flat
        btnYouth.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnYouth.ForeColor = Color.Gainsboro
        btnYouth.IconChar = FontAwesome.Sharp.IconChar.Users
        btnYouth.IconColor = Color.White
        btnYouth.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnYouth.IconSize = 40
        btnYouth.ImageAlign = ContentAlignment.MiddleLeft
        btnYouth.Location = New Point(0, 187)
        btnYouth.Name = "btnYouth"
        btnYouth.Padding = New Padding(10, 0, 20, 0)
        btnYouth.Size = New Size(200, 60)
        btnYouth.TabIndex = 2
        btnYouth.Text = "Youth"
        btnYouth.TextAlign = ContentAlignment.MiddleLeft
        btnYouth.TextImageRelation = TextImageRelation.ImageBeforeText
        btnYouth.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.Gainsboro
        btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        btnDashboard.IconColor = Color.White
        btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDashboard.IconSize = 40
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 127)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(10, 0, 20, 0)
        btnDashboard.Size = New Size(200, 60)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(imgHome)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 127)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Decaydence", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(97, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 14)
        Label2.TabIndex = 1
        Label2.Text = "Profile"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Decaydence", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Tomato
        Label1.Location = New Point(82, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 14)
        Label1.TabIndex = 1
        Label1.Text = "KK Youth "
        ' 
        ' imgHome
        ' 
        imgHome.Image = My.Resources.Resources.skb
        imgHome.Location = New Point(0, 0)
        imgHome.Name = "imgHome"
        imgHome.Size = New Size(121, 105)
        imgHome.SizeMode = PictureBoxSizeMode.Zoom
        imgHome.TabIndex = 0
        imgHome.TabStop = False
        ' 
        ' PanelNavbar
        ' 
        PanelNavbar.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        PanelNavbar.Controls.Add(IconBtnMinimize)
        PanelNavbar.Controls.Add(IconBtnMaximize)
        PanelNavbar.Controls.Add(btnSetting)
        PanelNavbar.Controls.Add(lblFormTitle)
        PanelNavbar.Controls.Add(IconCurrentForm)
        PanelNavbar.Controls.Add(PanelAdminProfile)
        PanelNavbar.Dock = DockStyle.Top
        PanelNavbar.Location = New Point(200, 0)
        PanelNavbar.Name = "PanelNavbar"
        PanelNavbar.Size = New Size(920, 50)
        PanelNavbar.TabIndex = 1
        ' 
        ' IconBtnMinimize
        ' 
        IconBtnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IconBtnMinimize.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnMinimize.FlatAppearance.BorderSize = 0
        IconBtnMinimize.FlatStyle = FlatStyle.Flat
        IconBtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        IconBtnMinimize.IconColor = Color.White
        IconBtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnMinimize.IconSize = 25
        IconBtnMinimize.Location = New Point(815, 13)
        IconBtnMinimize.Name = "IconBtnMinimize"
        IconBtnMinimize.Size = New Size(32, 22)
        IconBtnMinimize.TabIndex = 3
        IconBtnMinimize.UseVisualStyleBackColor = False
        ' 
        ' IconBtnMaximize
        ' 
        IconBtnMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IconBtnMaximize.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnMaximize.FlatAppearance.BorderSize = 0
        IconBtnMaximize.FlatStyle = FlatStyle.Flat
        IconBtnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand
        IconBtnMaximize.IconColor = Color.White
        IconBtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnMaximize.IconSize = 25
        IconBtnMaximize.Location = New Point(846, 11)
        IconBtnMaximize.Name = "IconBtnMaximize"
        IconBtnMaximize.Size = New Size(27, 26)
        IconBtnMaximize.TabIndex = 3
        IconBtnMaximize.UseVisualStyleBackColor = False
        ' 
        ' btnSetting
        ' 
        btnSetting.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSetting.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        btnSetting.FlatAppearance.BorderSize = 0
        btnSetting.FlatStyle = FlatStyle.Flat
        btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog
        btnSetting.IconColor = Color.White
        btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSetting.IconSize = 30
        btnSetting.Location = New Point(876, 9)
        btnSetting.Name = "btnSetting"
        btnSetting.Size = New Size(32, 32)
        btnSetting.TabIndex = 2
        btnSetting.UseVisualStyleBackColor = False
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFormTitle.ForeColor = Color.Gainsboro
        lblFormTitle.Location = New Point(70, 16)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(50, 20)
        lblFormTitle.TabIndex = 1
        lblFormTitle.Text = "Home"
        ' 
        ' IconCurrentForm
        ' 
        IconCurrentForm.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconCurrentForm.ForeColor = Color.Tomato
        IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        IconCurrentForm.IconColor = Color.Tomato
        IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconCurrentForm.Location = New Point(36, 9)
        IconCurrentForm.Name = "IconCurrentForm"
        IconCurrentForm.Size = New Size(32, 32)
        IconCurrentForm.TabIndex = 0
        IconCurrentForm.TabStop = False
        ' 
        ' PanelAdminProfile
        ' 
        PanelAdminProfile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PanelAdminProfile.Controls.Add(IconHoverAdmin)
        PanelAdminProfile.Location = New Point(661, 9)
        PanelAdminProfile.Name = "PanelAdminProfile"
        PanelAdminProfile.Size = New Size(128, 32)
        PanelAdminProfile.TabIndex = 2
        ' 
        ' IconHoverAdmin
        ' 
        IconHoverAdmin.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconHoverAdmin.Dock = DockStyle.Fill
        IconHoverAdmin.FlatAppearance.BorderSize = 0
        IconHoverAdmin.FlatStyle = FlatStyle.Flat
        IconHoverAdmin.ForeColor = Color.Gainsboro
        IconHoverAdmin.IconChar = FontAwesome.Sharp.IconChar.User
        IconHoverAdmin.IconColor = Color.Violet
        IconHoverAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconHoverAdmin.IconSize = 29
        IconHoverAdmin.ImageAlign = ContentAlignment.MiddleLeft
        IconHoverAdmin.Location = New Point(0, 0)
        IconHoverAdmin.Name = "IconHoverAdmin"
        IconHoverAdmin.Size = New Size(128, 32)
        IconHoverAdmin.TabIndex = 0
        IconHoverAdmin.Text = "Admin Setting"
        IconHoverAdmin.TextAlign = ContentAlignment.MiddleLeft
        IconHoverAdmin.TextImageRelation = TextImageRelation.ImageBeforeText
        IconHoverAdmin.UseVisualStyleBackColor = False
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        PanelDesktop.Controls.Add(PictureBox2)
        PanelDesktop.Controls.Add(PictureBox1)
        PanelDesktop.Controls.Add(LblUser)
        PanelDesktop.Controls.Add(Label7)
        PanelDesktop.Controls.Add(lblTime)
        PanelDesktop.Controls.Add(Label6)
        PanelDesktop.Controls.Add(lblDate)
        PanelDesktop.Controls.Add(Label5)
        PanelDesktop.Controls.Add(Label4)
        PanelDesktop.Controls.Add(Label3)
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(200, 50)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(920, 462)
        PanelDesktop.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 200)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(343, 309)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(595, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(325, 299)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' LblUser
        ' 
        LblUser.AutoSize = True
        LblUser.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LblUser.ForeColor = Color.White
        LblUser.Location = New Point(36, 176)
        LblUser.Name = "LblUser"
        LblUser.Size = New Size(48, 21)
        LblUser.TabIndex = 5
        LblUser.Text = "USER"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(38, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 21)
        Label7.TabIndex = 4
        Label7.Text = "Time:"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(90, 147)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(46, 21)
        lblTime.TabIndex = 4
        lblTime.Text = "Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(36, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 21)
        Label6.TabIndex = 4
        Label6.Text = "Date :"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.White
        lblDate.Location = New Point(90, 116)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(48, 21)
        lblDate.TabIndex = 4
        lblDate.Text = "DATE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Conthrax Sb", 25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(6, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(388, 40)
        Label5.TabIndex = 3
        Label5.Text = "WELCOME BACK!"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Decaydence", 48F)
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(321, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(462, 76)
        Label4.TabIndex = 1
        Label4.Text = "Profile"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Decaydence", 48F)
        Label3.ForeColor = Color.Tomato
        Label3.Location = New Point(201, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(544, 76)
        Label3.TabIndex = 1
        Label3.Text = "KK Youth "
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 550000
        ' 
        ' DateAndTime
        ' 
        DateAndTime.Interval = 1000
        ' 
        ' FrmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1120, 512)
        Controls.Add(PanelDesktop)
        Controls.Add(PanelNavbar)
        Controls.Add(PanelDash)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "FrmDashboard"
        Text = "DASHBOARD"
        WindowState = FormWindowState.Maximized
        PanelDash.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(imgHome, ComponentModel.ISupportInitialize).EndInit()
        PanelNavbar.ResumeLayout(False)
        PanelNavbar.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        PanelAdminProfile.ResumeLayout(False)
        PanelDesktop.ResumeLayout(False)
        PanelDesktop.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelDash As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents PanelNavbar As Panel
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReports As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents btnYouth As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelAdminProfile As Panel
    Friend WithEvents IconHoverAdmin As FontAwesome.Sharp.IconButton
    Friend WithEvents DateAndTime As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSetting As FontAwesome.Sharp.IconButton
    Public WithEvents Timer1 As Timer
    Friend WithEvents LblUser As Label
    Friend WithEvents IconBtnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
