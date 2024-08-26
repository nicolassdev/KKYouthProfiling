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
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lblFormTitle = New Label()
        IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        PanelDesktop = New Panel()
        Timer1 = New Timer(components)
        PanelDash.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelDash.Size = New Size(200, 568)
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
        btnLogout.Location = New Point(0, 508)
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
        Panel1.Controls.Add(PictureBox1)
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
        Label2.Location = New Point(85, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 14)
        Label2.TabIndex = 1
        Label2.Text = "Profiling"
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
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.skb
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(121, 105)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        Panel2.Controls.Add(lblFormTitle)
        Panel2.Controls.Add(IconCurrentForm)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(200, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 50)
        Panel2.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.ForeColor = Color.Gainsboro
        lblFormTitle.Location = New Point(73, 18)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(40, 15)
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
        ' PanelDesktop
        ' 
        PanelDesktop.BackColor = SystemColors.ControlLightLight
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(200, 50)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(600, 518)
        PanelDesktop.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 150000
        ' 
        ' FrmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 568)
        Controls.Add(PanelDesktop)
        Controls.Add(Panel2)
        Controls.Add(PanelDash)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmDashboard"
        Text = "DASHBOARD"
        PanelDash.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconCurrentForm, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelDash As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents Timer1 As Timer

End Class
