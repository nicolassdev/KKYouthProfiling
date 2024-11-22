<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdminProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdminProfile))
        lblFormTitle = New Label()
        IconPicBx = New FontAwesome.Sharp.IconPictureBox()
        gbFrmAdmin = New GroupBox()
        cboRole = New ComboBox()
        Label11 = New Label()
        txtPassword = New TextBox()
        IconBtnChangePass = New FontAwesome.Sharp.IconButton()
        txtUsername = New TextBox()
        txtContact = New TextBox()
        richtxtboxAddress = New RichTextBox()
        txtLname = New TextBox()
        txtFname = New TextBox()
        txtID = New TextBox()
        Label10 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label13 = New Label()
        LblContact = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dgAdmin = New DataGridView()
        txtSearch = New TextBox()
        Label1 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        IconBtnAdd = New FontAwesome.Sharp.IconButton()
        IconBtnSave = New FontAwesome.Sharp.IconButton()
        IconBtnClear = New FontAwesome.Sharp.IconButton()
        BtnClose = New FontAwesome.Sharp.IconPictureBox()
        LblBack = New Label()
        txtPath = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        IconBtnUpload = New FontAwesome.Sharp.IconButton()
        IconSearch = New FontAwesome.Sharp.IconPictureBox()
        IconBtnEdit = New FontAwesome.Sharp.IconButton()
        CType(IconPicBx, ComponentModel.ISupportInitialize).BeginInit()
        gbFrmAdmin.SuspendLayout()
        CType(dgAdmin, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconSearch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFormTitle.ForeColor = Color.White
        lblFormTitle.Location = New Point(33, 26)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(217, 37)
        lblFormTitle.TabIndex = 6
        lblFormTitle.Text = "ADMIN PROFILE"
        ' 
        ' IconPicBx
        ' 
        IconPicBx.BackColor = Color.White
        IconPicBx.ForeColor = Color.Tomato
        IconPicBx.IconChar = FontAwesome.Sharp.IconChar.User
        IconPicBx.IconColor = Color.Tomato
        IconPicBx.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconPicBx.IconSize = 254
        IconPicBx.Location = New Point(572, 76)
        IconPicBx.Name = "IconPicBx"
        IconPicBx.Size = New Size(260, 254)
        IconPicBx.SizeMode = PictureBoxSizeMode.StretchImage
        IconPicBx.TabIndex = 7
        IconPicBx.TabStop = False
        ' 
        ' gbFrmAdmin
        ' 
        gbFrmAdmin.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        gbFrmAdmin.Controls.Add(cboRole)
        gbFrmAdmin.Controls.Add(Label11)
        gbFrmAdmin.Controls.Add(txtPassword)
        gbFrmAdmin.Controls.Add(IconBtnChangePass)
        gbFrmAdmin.Controls.Add(txtUsername)
        gbFrmAdmin.Controls.Add(txtContact)
        gbFrmAdmin.Controls.Add(richtxtboxAddress)
        gbFrmAdmin.Controls.Add(txtLname)
        gbFrmAdmin.Controls.Add(txtFname)
        gbFrmAdmin.Controls.Add(txtID)
        gbFrmAdmin.Controls.Add(Label10)
        gbFrmAdmin.Controls.Add(Label8)
        gbFrmAdmin.Controls.Add(Label9)
        gbFrmAdmin.Controls.Add(Label7)
        gbFrmAdmin.Controls.Add(Label13)
        gbFrmAdmin.Controls.Add(LblContact)
        gbFrmAdmin.Controls.Add(Label5)
        gbFrmAdmin.Controls.Add(Label4)
        gbFrmAdmin.Controls.Add(Label3)
        gbFrmAdmin.Controls.Add(Label2)
        gbFrmAdmin.Location = New Point(43, 76)
        gbFrmAdmin.Name = "gbFrmAdmin"
        gbFrmAdmin.Size = New Size(464, 339)
        gbFrmAdmin.TabIndex = 8
        gbFrmAdmin.TabStop = False
        ' 
        ' cboRole
        ' 
        cboRole.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        cboRole.FormattingEnabled = True
        cboRole.Location = New Point(262, 107)
        cboRole.Name = "cboRole"
        cboRole.Size = New Size(176, 28)
        cboRole.TabIndex = 5
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Red
        Label11.Location = New Point(328, 243)
        Label11.Name = "Label11"
        Label11.Size = New Size(16, 20)
        Label11.TabIndex = 7
        Label11.Text = "*"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        txtPassword.Location = New Point(257, 266)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Enter password"
        txtPassword.Size = New Size(176, 27)
        txtPassword.TabIndex = 7
        ' 
        ' IconBtnChangePass
        ' 
        IconBtnChangePass.BackColor = Color.White
        IconBtnChangePass.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        IconBtnChangePass.ForeColor = Color.Black
        IconBtnChangePass.IconChar = FontAwesome.Sharp.IconChar.Edit
        IconBtnChangePass.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnChangePass.IconSize = 20
        IconBtnChangePass.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnChangePass.Location = New Point(308, 302)
        IconBtnChangePass.Name = "IconBtnChangePass"
        IconBtnChangePass.Size = New Size(125, 31)
        IconBtnChangePass.TabIndex = 12
        IconBtnChangePass.TabStop = False
        IconBtnChangePass.Text = "Change Password"
        IconBtnChangePass.TextAlign = ContentAlignment.MiddleLeft
        IconBtnChangePass.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnChangePass.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        txtUsername.Location = New Point(257, 206)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Enter username"
        txtUsername.Size = New Size(176, 27)
        txtUsername.TabIndex = 6
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        txtContact.Location = New Point(262, 43)
        txtContact.Name = "txtContact"
        txtContact.PlaceholderText = "+63"
        txtContact.Size = New Size(176, 27)
        txtContact.TabIndex = 4
        ' 
        ' richtxtboxAddress
        ' 
        richtxtboxAddress.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        richtxtboxAddress.Location = New Point(37, 233)
        richtxtboxAddress.Name = "richtxtboxAddress"
        richtxtboxAddress.Size = New Size(180, 74)
        richtxtboxAddress.TabIndex = 3
        richtxtboxAddress.Text = ""
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        txtLname.Location = New Point(37, 169)
        txtLname.Name = "txtLname"
        txtLname.PlaceholderText = "Surname"
        txtLname.Size = New Size(191, 27)
        txtLname.TabIndex = 2
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        txtFname.Location = New Point(37, 107)
        txtFname.Name = "txtFname"
        txtFname.PlaceholderText = "Name"
        txtFname.Size = New Size(191, 27)
        txtFname.TabIndex = 1
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        txtID.Location = New Point(37, 43)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID"
        txtID.Size = New Size(158, 27)
        txtID.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(331, 184)
        Label10.Name = "Label10"
        Label10.Size = New Size(16, 20)
        Label10.TabIndex = 6
        Label10.Text = "*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        Label8.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(257, 243)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 20)
        Label8.TabIndex = 6
        Label8.Text = "Password"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(0), CByte(102), CByte(255))
        Label9.Location = New Point(257, 152)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 25)
        Label9.TabIndex = 6
        Label9.Text = "ACCOUNT"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(257, 183)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 20)
        Label7.TabIndex = 6
        Label7.Text = "Username "
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        Label13.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(259, 84)
        Label13.Name = "Label13"
        Label13.Size = New Size(39, 20)
        Label13.TabIndex = 6
        Label13.Text = "Role"
        ' 
        ' LblContact
        ' 
        LblContact.AutoSize = True
        LblContact.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        LblContact.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblContact.ForeColor = Color.White
        LblContact.Location = New Point(258, 19)
        LblContact.Name = "LblContact"
        LblContact.Size = New Size(61, 20)
        LblContact.TabIndex = 6
        LblContact.Text = "Contact"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        Label5.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(37, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 20)
        Label5.TabIndex = 6
        Label5.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        Label4.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(33, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 6
        Label4.Text = "Last name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        Label3.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(33, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 6
        Label3.Text = "First name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        Label2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(33, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 6
        Label2.Text = "Admin ID"
        ' 
        ' dgAdmin
        ' 
        dgAdmin.Anchor = AnchorStyles.Bottom
        dgAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgAdmin.BackgroundColor = Color.White
        dgAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgAdmin.GridColor = Color.White
        dgAdmin.Location = New Point(12, 479)
        dgAdmin.Name = "dgAdmin"
        dgAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgAdmin.Size = New Size(867, 264)
        dgAdmin.TabIndex = 10
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(655, 447)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(224, 23)
        txtSearch.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(575, 447)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 6
        Label1.Text = "Search"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' IconBtnAdd
        ' 
        IconBtnAdd.BackColor = Color.White
        IconBtnAdd.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        IconBtnAdd.ForeColor = Color.Black
        IconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        IconBtnAdd.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnAdd.IconSize = 35
        IconBtnAdd.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnAdd.Location = New Point(58, 421)
        IconBtnAdd.Name = "IconBtnAdd"
        IconBtnAdd.Size = New Size(100, 41)
        IconBtnAdd.TabIndex = 12
        IconBtnAdd.Text = "Add "
        IconBtnAdd.TextAlign = ContentAlignment.MiddleLeft
        IconBtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnAdd.UseVisualStyleBackColor = False
        ' 
        ' IconBtnSave
        ' 
        IconBtnSave.BackColor = Color.White
        IconBtnSave.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        IconBtnSave.ForeColor = Color.Black
        IconBtnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        IconBtnSave.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnSave.IconSize = 33
        IconBtnSave.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnSave.Location = New Point(172, 421)
        IconBtnSave.Name = "IconBtnSave"
        IconBtnSave.Size = New Size(103, 41)
        IconBtnSave.TabIndex = 12
        IconBtnSave.Text = "Save"
        IconBtnSave.TextAlign = ContentAlignment.MiddleLeft
        IconBtnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnSave.UseVisualStyleBackColor = False
        ' 
        ' IconBtnClear
        ' 
        IconBtnClear.BackColor = Color.White
        IconBtnClear.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        IconBtnClear.ForeColor = Color.Black
        IconBtnClear.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateLeft
        IconBtnClear.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnClear.IconSize = 30
        IconBtnClear.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnClear.Location = New Point(408, 421)
        IconBtnClear.Name = "IconBtnClear"
        IconBtnClear.Size = New Size(100, 41)
        IconBtnClear.TabIndex = 12
        IconBtnClear.Text = "Clear"
        IconBtnClear.TextAlign = ContentAlignment.MiddleLeft
        IconBtnClear.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnClear.UseVisualStyleBackColor = False
        ' 
        ' BtnClose
        ' 
        BtnClose.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        BtnClose.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft
        BtnClose.IconColor = Color.White
        BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnClose.Location = New Point(846, 12)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(32, 32)
        BtnClose.TabIndex = 13
        BtnClose.TabStop = False
        ' 
        ' LblBack
        ' 
        LblBack.AutoSize = True
        LblBack.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblBack.ForeColor = Color.White
        LblBack.Location = New Point(695, 19)
        LblBack.Name = "LblBack"
        LblBack.Size = New Size(148, 19)
        LblBack.TabIndex = 6
        LblBack.Text = "Go Back to Dashboard"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(525, 410)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(222, 23)
        txtPath.TabIndex = 11
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' IconBtnUpload
        ' 
        IconBtnUpload.BackColor = Color.DodgerBlue
        IconBtnUpload.FlatAppearance.BorderColor = Color.DodgerBlue
        IconBtnUpload.FlatAppearance.BorderSize = 2
        IconBtnUpload.FlatStyle = FlatStyle.Flat
        IconBtnUpload.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        IconBtnUpload.ForeColor = Color.White
        IconBtnUpload.IconChar = FontAwesome.Sharp.IconChar.None
        IconBtnUpload.IconColor = Color.Black
        IconBtnUpload.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnUpload.Location = New Point(627, 344)
        IconBtnUpload.Name = "IconBtnUpload"
        IconBtnUpload.Size = New Size(161, 45)
        IconBtnUpload.TabIndex = 9
        IconBtnUpload.Text = "Upload photo"
        IconBtnUpload.UseVisualStyleBackColor = False
        ' 
        ' IconSearch
        ' 
        IconSearch.BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        IconSearch.IconColor = Color.White
        IconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconSearch.IconSize = 30
        IconSearch.Location = New Point(627, 444)
        IconSearch.Name = "IconSearch"
        IconSearch.Size = New Size(30, 30)
        IconSearch.TabIndex = 14
        IconSearch.TabStop = False
        ' 
        ' IconBtnEdit
        ' 
        IconBtnEdit.BackColor = Color.White
        IconBtnEdit.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        IconBtnEdit.ForeColor = Color.Black
        IconBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit
        IconBtnEdit.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnEdit.IconSize = 33
        IconBtnEdit.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnEdit.Location = New Point(291, 421)
        IconBtnEdit.Name = "IconBtnEdit"
        IconBtnEdit.Size = New Size(103, 41)
        IconBtnEdit.TabIndex = 12
        IconBtnEdit.Text = "Edit"
        IconBtnEdit.TextAlign = ContentAlignment.MiddleLeft
        IconBtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnEdit.UseVisualStyleBackColor = False
        ' 
        ' FrmAdminProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        ClientSize = New Size(890, 743)
        ControlBox = False
        Controls.Add(IconSearch)
        Controls.Add(BtnClose)
        Controls.Add(IconBtnClear)
        Controls.Add(IconBtnEdit)
        Controls.Add(IconBtnSave)
        Controls.Add(IconBtnAdd)
        Controls.Add(txtPath)
        Controls.Add(txtSearch)
        Controls.Add(dgAdmin)
        Controls.Add(IconBtnUpload)
        Controls.Add(gbFrmAdmin)
        Controls.Add(IconPicBx)
        Controls.Add(Label1)
        Controls.Add(lblFormTitle)
        Controls.Add(LblBack)
        ForeColor = Color.White
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmAdminProfile"
        StartPosition = FormStartPosition.CenterScreen
        CType(IconPicBx, ComponentModel.ISupportInitialize).EndInit()
        gbFrmAdmin.ResumeLayout(False)
        gbFrmAdmin.PerformLayout()
        CType(dgAdmin, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnClose, ComponentModel.ISupportInitialize).EndInit()
        CType(IconSearch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconPicBx As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents gbFrmAdmin As GroupBox
    Friend WithEvents dgAdmin As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblContact As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents richtxtboxAddress As RichTextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents IconBtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LblBack As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents IconBtnUpload As FontAwesome.Sharp.IconButton
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconBtnEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnChangePass As FontAwesome.Sharp.IconButton
End Class
