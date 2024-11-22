<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYouth
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
        IconBtnAdd = New FontAwesome.Sharp.IconButton()
        gbProfile = New GroupBox()
        txtBarangay = New TextBox()
        Label39 = New Label()
        Label32 = New Label()
        Label31 = New Label()
        Label30 = New Label()
        Label29 = New Label()
        Label28 = New Label()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        txtAge = New TextBox()
        txtLname = New TextBox()
        txtMname = New TextBox()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        txtFname = New TextBox()
        txtYouthID = New TextBox()
        cboPurok = New ComboBox()
        cboMunicipality = New ComboBox()
        cboProvince = New ComboBox()
        cboRegion = New ComboBox()
        cboGender = New ComboBox()
        dtpDob = New DateTimePicker()
        Label14 = New Label()
        Label13 = New Label()
        Label40 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label5 = New Label()
        Label21 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        gbDemographic = New GroupBox()
        Label38 = New Label()
        Label37 = New Label()
        Label36 = New Label()
        Label35 = New Label()
        Label34 = New Label()
        Label33 = New Label()
        cboNotAttend = New ComboBox()
        cboIsAttend = New ComboBox()
        cboAttend = New ComboBox()
        cboVoter = New ComboBox()
        cboWorkStat = New ComboBox()
        cboEducationAttain = New ComboBox()
        cboClassification = New ComboBox()
        cboAgeGroup = New ComboBox()
        cboCivilStat = New ComboBox()
        Label17 = New Label()
        lblWhy = New Label()
        lblHowManyTimes = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        IconBtnSave = New FontAwesome.Sharp.IconButton()
        IconBtnEdit = New FontAwesome.Sharp.IconButton()
        IconBtnClear = New FontAwesome.Sharp.IconButton()
        IconPicBox = New FontAwesome.Sharp.IconPictureBox()
        IconBtnUpload = New FontAwesome.Sharp.IconButton()
        txtPath = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        dgYouth = New DataGridView()
        txtSearch = New TextBox()
        IconSearch = New FontAwesome.Sharp.IconPictureBox()
        Label41 = New Label()
        gbProfile.SuspendLayout()
        gbDemographic.SuspendLayout()
        CType(IconPicBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgYouth, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconSearch, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' IconBtnAdd
        ' 
        IconBtnAdd.BackColor = Color.DodgerBlue
        IconBtnAdd.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        IconBtnAdd.ForeColor = Color.White
        IconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        IconBtnAdd.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnAdd.IconSize = 35
        IconBtnAdd.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnAdd.Location = New Point(795, 286)
        IconBtnAdd.Name = "IconBtnAdd"
        IconBtnAdd.Size = New Size(130, 41)
        IconBtnAdd.TabIndex = 29
        IconBtnAdd.Text = "Add Youth"
        IconBtnAdd.TextAlign = ContentAlignment.MiddleLeft
        IconBtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnAdd.UseVisualStyleBackColor = False
        ' 
        ' gbProfile
        ' 
        gbProfile.Controls.Add(txtBarangay)
        gbProfile.Controls.Add(Label39)
        gbProfile.Controls.Add(Label32)
        gbProfile.Controls.Add(Label31)
        gbProfile.Controls.Add(Label30)
        gbProfile.Controls.Add(Label29)
        gbProfile.Controls.Add(Label28)
        gbProfile.Controls.Add(Label27)
        gbProfile.Controls.Add(Label26)
        gbProfile.Controls.Add(Label25)
        gbProfile.Controls.Add(Label24)
        gbProfile.Controls.Add(Label22)
        gbProfile.Controls.Add(Label23)
        gbProfile.Controls.Add(txtAge)
        gbProfile.Controls.Add(txtLname)
        gbProfile.Controls.Add(txtMname)
        gbProfile.Controls.Add(txtEmail)
        gbProfile.Controls.Add(txtContact)
        gbProfile.Controls.Add(txtFname)
        gbProfile.Controls.Add(txtYouthID)
        gbProfile.Controls.Add(cboPurok)
        gbProfile.Controls.Add(cboMunicipality)
        gbProfile.Controls.Add(cboProvince)
        gbProfile.Controls.Add(cboRegion)
        gbProfile.Controls.Add(cboGender)
        gbProfile.Controls.Add(dtpDob)
        gbProfile.Controls.Add(Label14)
        gbProfile.Controls.Add(Label13)
        gbProfile.Controls.Add(Label40)
        gbProfile.Controls.Add(Label12)
        gbProfile.Controls.Add(Label11)
        gbProfile.Controls.Add(Label9)
        gbProfile.Controls.Add(Label7)
        gbProfile.Controls.Add(Label6)
        gbProfile.Controls.Add(Label8)
        gbProfile.Controls.Add(Label10)
        gbProfile.Controls.Add(Label5)
        gbProfile.Controls.Add(Label21)
        gbProfile.Controls.Add(Label4)
        gbProfile.Controls.Add(Label1)
        gbProfile.Controls.Add(Label2)
        gbProfile.Font = New Font("Cascadia Code", 9F)
        gbProfile.ForeColor = SystemColors.ControlText
        gbProfile.Location = New Point(22, 19)
        gbProfile.Name = "gbProfile"
        gbProfile.Size = New Size(683, 304)
        gbProfile.TabIndex = 14
        gbProfile.TabStop = False
        gbProfile.Text = "I. PROFILE"
        ' 
        ' txtBarangay
        ' 
        txtBarangay.Font = New Font("Cascadia Code", 10F)
        txtBarangay.Location = New Point(477, 260)
        txtBarangay.Name = "txtBarangay"
        txtBarangay.Size = New Size(200, 23)
        txtBarangay.TabIndex = 13
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label39.ForeColor = Color.Red
        Label39.Location = New Point(286, 32)
        Label39.Name = "Label39"
        Label39.Size = New Size(14, 17)
        Label39.TabIndex = 25
        Label39.Text = "*"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label32.ForeColor = Color.Red
        Label32.Location = New Point(551, 239)
        Label32.Name = "Label32"
        Label32.Size = New Size(14, 17)
        Label32.TabIndex = 19
        Label32.Text = "*"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label31.ForeColor = Color.Red
        Label31.Location = New Point(382, 238)
        Label31.Name = "Label31"
        Label31.Size = New Size(14, 17)
        Label31.TabIndex = 19
        Label31.Text = "*"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.ForeColor = Color.Red
        Label30.Location = New Point(203, 237)
        Label30.Name = "Label30"
        Label30.Size = New Size(14, 17)
        Label30.TabIndex = 24
        Label30.Text = "*"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.ForeColor = Color.Red
        Label29.Location = New Point(75, 238)
        Label29.Name = "Label29"
        Label29.Size = New Size(14, 17)
        Label29.TabIndex = 23
        Label29.Text = "*"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.Red
        Label28.Location = New Point(473, 148)
        Label28.Name = "Label28"
        Label28.Size = New Size(14, 17)
        Label28.TabIndex = 22
        Label28.Text = "*"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.Red
        Label27.Location = New Point(266, 149)
        Label27.Name = "Label27"
        Label27.Size = New Size(14, 17)
        Label27.TabIndex = 21
        Label27.Text = "*"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.Red
        Label26.Location = New Point(551, 89)
        Label26.Name = "Label26"
        Label26.Size = New Size(14, 17)
        Label26.TabIndex = 20
        Label26.Text = "*"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = Color.Red
        Label25.Location = New Point(641, 89)
        Label25.Name = "Label25"
        Label25.Size = New Size(14, 17)
        Label25.TabIndex = 19
        Label25.Text = "*"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.Red
        Label24.Location = New Point(122, 151)
        Label24.Name = "Label24"
        Label24.Size = New Size(14, 17)
        Label24.TabIndex = 18
        Label24.Text = "*"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.Red
        Label22.Location = New Point(421, 90)
        Label22.Name = "Label22"
        Label22.Size = New Size(14, 17)
        Label22.TabIndex = 18
        Label22.Text = "*"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.Red
        Label23.Location = New Point(97, 91)
        Label23.Name = "Label23"
        Label23.Size = New Size(14, 17)
        Label23.TabIndex = 18
        Label23.Text = "*"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Cascadia Code", 10F)
        txtAge.Location = New Point(516, 111)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(63, 23)
        txtAge.TabIndex = 5
        ' 
        ' txtLname
        ' 
        txtLname.Font = New Font("Cascadia Code", 10F)
        txtLname.Location = New Point(348, 111)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(158, 23)
        txtLname.TabIndex = 4
        ' 
        ' txtMname
        ' 
        txtMname.Font = New Font("Cascadia Code", 10F)
        txtMname.Location = New Point(184, 111)
        txtMname.Name = "txtMname"
        txtMname.Size = New Size(158, 23)
        txtMname.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Cascadia Code", 10F)
        txtEmail.Location = New Point(428, 169)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(242, 23)
        txtEmail.TabIndex = 9
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Cascadia Code", 11F)
        txtContact.Location = New Point(205, 170)
        txtContact.Name = "txtContact"
        txtContact.PlaceholderText = "+63"
        txtContact.Size = New Size(204, 25)
        txtContact.TabIndex = 8
        ' 
        ' txtFname
        ' 
        txtFname.Font = New Font("Cascadia Code", 10F)
        txtFname.Location = New Point(20, 111)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(158, 23)
        txtFname.TabIndex = 2
        ' 
        ' txtYouthID
        ' 
        txtYouthID.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        txtYouthID.ForeColor = Color.LightCoral
        txtYouthID.Location = New Point(20, 54)
        txtYouthID.Name = "txtYouthID"
        txtYouthID.Size = New Size(215, 27)
        txtYouthID.TabIndex = 0
        ' 
        ' cboPurok
        ' 
        cboPurok.Font = New Font("Cascadia Code", 10F)
        cboPurok.FormattingEnabled = True
        cboPurok.Location = New Point(241, 54)
        cboPurok.Name = "cboPurok"
        cboPurok.Size = New Size(234, 25)
        cboPurok.TabIndex = 1
        ' 
        ' cboMunicipality
        ' 
        cboMunicipality.Font = New Font("Cascadia Code", 10F)
        cboMunicipality.FormattingEnabled = True
        cboMunicipality.Location = New Point(293, 258)
        cboMunicipality.Name = "cboMunicipality"
        cboMunicipality.Size = New Size(174, 25)
        cboMunicipality.TabIndex = 12
        ' 
        ' cboProvince
        ' 
        cboProvince.Font = New Font("Cascadia Code", 10F)
        cboProvince.FormattingEnabled = True
        cboProvince.Items.AddRange(New Object() {"Albay", "Camarines Norte", "Camarines Sur", "Catanduanes", "Masbate", "Sorsogon"})
        cboProvince.Location = New Point(137, 258)
        cboProvince.Name = "cboProvince"
        cboProvince.Size = New Size(145, 25)
        cboProvince.TabIndex = 11
        ' 
        ' cboRegion
        ' 
        cboRegion.Font = New Font("Cascadia Code", 10F)
        cboRegion.FormattingEnabled = True
        cboRegion.Items.AddRange(New Object() {"V"})
        cboRegion.Location = New Point(21, 258)
        cboRegion.Name = "cboRegion"
        cboRegion.Size = New Size(102, 25)
        cboRegion.TabIndex = 10
        ' 
        ' cboGender
        ' 
        cboGender.Font = New Font("Cascadia Code", 10F)
        cboGender.FormattingEnabled = True
        cboGender.Location = New Point(588, 111)
        cboGender.Name = "cboGender"
        cboGender.Size = New Size(82, 25)
        cboGender.TabIndex = 6
        ' 
        ' dtpDob
        ' 
        dtpDob.CustomFormat = ""
        dtpDob.Font = New Font("Cascadia Code", 10F)
        dtpDob.Format = DateTimePickerFormat.Custom
        dtpDob.Location = New Point(21, 172)
        dtpDob.Name = "dtpDob"
        dtpDob.Size = New Size(173, 23)
        dtpDob.TabIndex = 7
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Cascadia Code", 9F)
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(488, 237)
        Label14.Name = "Label14"
        Label14.Size = New Size(63, 16)
        Label14.TabIndex = 7
        Label14.Text = "Barangay"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Cascadia Code", 9F)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(296, 236)
        Label13.Name = "Label13"
        Label13.Size = New Size(91, 16)
        Label13.TabIndex = 7
        Label13.Text = "Municipality"
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.BackColor = Color.Transparent
        Label40.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label40.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Label40.Location = New Point(23, 211)
        Label40.Name = "Label40"
        Label40.Size = New Size(81, 21)
        Label40.TabIndex = 7
        Label40.Text = "Location :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Cascadia Code", 9F)
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(141, 236)
        Label12.Name = "Label12"
        Label12.Size = New Size(63, 16)
        Label12.TabIndex = 7
        Label12.Text = "Province"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Cascadia Code", 9F)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(24, 236)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 16)
        Label11.TabIndex = 7
        Label11.Text = "Region"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Cascadia Code", 9F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(208, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 16)
        Label9.TabIndex = 7
        Label9.Text = "Contact"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Cascadia Code", 9F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(432, 148)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 16)
        Label7.TabIndex = 7
        Label7.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Cascadia Code", 9F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(591, 88)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 16)
        Label6.TabIndex = 7
        Label6.Text = "Gender"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Cascadia Code", 9F)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(24, 150)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 16)
        Label8.TabIndex = 7
        Label8.Text = "Date of Birth"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Cascadia Code", 9F)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(244, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 16)
        Label10.TabIndex = 7
        Label10.Text = "Purok"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Cascadia Code", 9F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(519, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 16)
        Label5.TabIndex = 7
        Label5.Text = "Age"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.Transparent
        Label21.Font = New Font("Cascadia Code", 9F)
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(352, 88)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 16)
        Label21.TabIndex = 7
        Label21.Text = "Last name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Cascadia Code", 9F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(187, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 16)
        Label4.TabIndex = 7
        Label4.Text = "Middle name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cascadia Code", 9F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(24, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 16)
        Label1.TabIndex = 7
        Label1.Text = "First name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Cascadia Code", 9F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(24, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 16)
        Label2.TabIndex = 7
        Label2.Text = "Youth ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Cascadia Code", 9F)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(22, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 16)
        Label3.TabIndex = 7
        Label3.Text = "Civil Status"
        ' 
        ' gbDemographic
        ' 
        gbDemographic.Controls.Add(Label38)
        gbDemographic.Controls.Add(Label37)
        gbDemographic.Controls.Add(Label36)
        gbDemographic.Controls.Add(Label35)
        gbDemographic.Controls.Add(Label34)
        gbDemographic.Controls.Add(Label33)
        gbDemographic.Controls.Add(cboNotAttend)
        gbDemographic.Controls.Add(cboIsAttend)
        gbDemographic.Controls.Add(cboAttend)
        gbDemographic.Controls.Add(cboVoter)
        gbDemographic.Controls.Add(cboWorkStat)
        gbDemographic.Controls.Add(cboEducationAttain)
        gbDemographic.Controls.Add(cboClassification)
        gbDemographic.Controls.Add(cboAgeGroup)
        gbDemographic.Controls.Add(cboCivilStat)
        gbDemographic.Controls.Add(Label17)
        gbDemographic.Controls.Add(lblWhy)
        gbDemographic.Controls.Add(lblHowManyTimes)
        gbDemographic.Controls.Add(Label20)
        gbDemographic.Controls.Add(Label19)
        gbDemographic.Controls.Add(Label18)
        gbDemographic.Controls.Add(Label16)
        gbDemographic.Controls.Add(Label15)
        gbDemographic.Controls.Add(Label3)
        gbDemographic.Font = New Font("Cascadia Code", 9F)
        gbDemographic.Location = New Point(22, 326)
        gbDemographic.Name = "gbDemographic"
        gbDemographic.Size = New Size(984, 143)
        gbDemographic.TabIndex = 14
        gbDemographic.TabStop = False
        gbDemographic.Text = "II. DEMOGRAPHIC CHARACTERISTICS"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label38.ForeColor = Color.Red
        Label38.Location = New Point(202, 80)
        Label38.Name = "Label38"
        Label38.Size = New Size(14, 17)
        Label38.TabIndex = 24
        Label38.Text = "*"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label37.ForeColor = Color.Red
        Label37.Location = New Point(832, 20)
        Label37.Name = "Label37"
        Label37.Size = New Size(14, 17)
        Label37.TabIndex = 23
        Label37.Text = "*"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label36.ForeColor = Color.Red
        Label36.Location = New Point(716, 20)
        Label36.Name = "Label36"
        Label36.Size = New Size(14, 17)
        Label36.TabIndex = 22
        Label36.Text = "*"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label35.ForeColor = Color.Red
        Label35.Location = New Point(531, 22)
        Label35.Name = "Label35"
        Label35.Size = New Size(14, 17)
        Label35.TabIndex = 21
        Label35.Text = "*"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label34.ForeColor = Color.Red
        Label34.Location = New Point(287, 22)
        Label34.Name = "Label34"
        Label34.Size = New Size(14, 17)
        Label34.TabIndex = 20
        Label34.Text = "*"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.ForeColor = Color.Red
        Label33.Location = New Point(111, 23)
        Label33.Name = "Label33"
        Label33.Size = New Size(14, 17)
        Label33.TabIndex = 19
        Label33.Text = "*"
        ' 
        ' cboNotAttend
        ' 
        cboNotAttend.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        cboNotAttend.FormattingEnabled = True
        cboNotAttend.Location = New Point(503, 105)
        cboNotAttend.Name = "cboNotAttend"
        cboNotAttend.Size = New Size(242, 25)
        cboNotAttend.TabIndex = 21
        ' 
        ' cboIsAttend
        ' 
        cboIsAttend.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        cboIsAttend.FormattingEnabled = True
        cboIsAttend.Location = New Point(517, 105)
        cboIsAttend.Name = "cboIsAttend"
        cboIsAttend.Size = New Size(230, 25)
        cboIsAttend.TabIndex = 21
        ' 
        ' cboAttend
        ' 
        cboAttend.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        cboAttend.FormattingEnabled = True
        cboAttend.Location = New Point(270, 106)
        cboAttend.Name = "cboAttend"
        cboAttend.Size = New Size(197, 25)
        cboAttend.TabIndex = 20
        ' 
        ' cboVoter
        ' 
        cboVoter.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        cboVoter.FormattingEnabled = True
        cboVoter.Location = New Point(17, 106)
        cboVoter.Name = "cboVoter"
        cboVoter.Size = New Size(225, 25)
        cboVoter.TabIndex = 19
        ' 
        ' cboWorkStat
        ' 
        cboWorkStat.Font = New Font("Cascadia Code", 10F)
        cboWorkStat.FormattingEnabled = True
        cboWorkStat.Location = New Point(745, 44)
        cboWorkStat.Name = "cboWorkStat"
        cboWorkStat.Size = New Size(219, 25)
        cboWorkStat.TabIndex = 18
        ' 
        ' cboEducationAttain
        ' 
        cboEducationAttain.Font = New Font("Cascadia Code", 10F)
        cboEducationAttain.FormattingEnabled = True
        cboEducationAttain.Location = New Point(556, 44)
        cboEducationAttain.Name = "cboEducationAttain"
        cboEducationAttain.Size = New Size(173, 25)
        cboEducationAttain.TabIndex = 17
        ' 
        ' cboClassification
        ' 
        cboClassification.Font = New Font("Cascadia Code", 10F)
        cboClassification.FormattingEnabled = True
        cboClassification.Location = New Point(386, 44)
        cboClassification.Name = "cboClassification"
        cboClassification.Size = New Size(156, 25)
        cboClassification.TabIndex = 16
        ' 
        ' cboAgeGroup
        ' 
        cboAgeGroup.Font = New Font("Cascadia Code", 10F)
        cboAgeGroup.FormattingEnabled = True
        cboAgeGroup.Location = New Point(174, 44)
        cboAgeGroup.Name = "cboAgeGroup"
        cboAgeGroup.Size = New Size(199, 25)
        cboAgeGroup.TabIndex = 15
        ' 
        ' cboCivilStat
        ' 
        cboCivilStat.Font = New Font("Cascadia Code", 10F)
        cboCivilStat.FormattingEnabled = True
        cboCivilStat.Location = New Point(21, 46)
        cboCivilStat.Name = "cboCivilStat"
        cboCivilStat.Size = New Size(140, 25)
        cboCivilStat.TabIndex = 14
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Cascadia Code", 9F)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(559, 19)
        Label17.Name = "Label17"
        Label17.Size = New Size(161, 16)
        Label17.TabIndex = 7
        Label17.Text = "Educational Background"
        ' 
        ' lblWhy
        ' 
        lblWhy.AutoSize = True
        lblWhy.BackColor = Color.Transparent
        lblWhy.Font = New Font("Cascadia Code", 9F)
        lblWhy.ForeColor = Color.Black
        lblWhy.Location = New Point(505, 81)
        lblWhy.Name = "lblWhy"
        lblWhy.Size = New Size(35, 16)
        lblWhy.TabIndex = 7
        lblWhy.Text = "Why?"
        ' 
        ' lblHowManyTimes
        ' 
        lblHowManyTimes.AutoSize = True
        lblHowManyTimes.BackColor = Color.Transparent
        lblHowManyTimes.Font = New Font("Cascadia Code", 9F)
        lblHowManyTimes.ForeColor = Color.Black
        lblHowManyTimes.Location = New Point(520, 81)
        lblHowManyTimes.Name = "lblHowManyTimes"
        lblHowManyTimes.Size = New Size(119, 16)
        lblHowManyTimes.TabIndex = 7
        lblHowManyTimes.Text = "How many times ?"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Cascadia Code", 9F)
        Label20.ForeColor = Color.Black
        Label20.Location = New Point(272, 79)
        Label20.Name = "Label20"
        Label20.Size = New Size(210, 16)
        Label20.TabIndex = 7
        Label20.Text = "Attended KK Assembly Meeting?"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Cascadia Code", 9F)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(20, 80)
        Label19.Name = "Label19"
        Label19.Size = New Size(182, 16)
        Label19.TabIndex = 7
        Label19.Text = "Registered National Voter"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Cascadia Code", 9F)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(748, 18)
        Label18.Name = "Label18"
        Label18.Size = New Size(84, 16)
        Label18.TabIndex = 7
        Label18.Text = "Work Status"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Cascadia Code", 9F)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(385, 20)
        Label16.Name = "Label16"
        Label16.Size = New Size(147, 16)
        Label16.TabIndex = 7
        Label16.Text = "Youth Classification"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Cascadia Code", 9F)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(174, 20)
        Label15.Name = "Label15"
        Label15.Size = New Size(112, 16)
        Label15.TabIndex = 7
        Label15.Text = "Youth Age Group"
        ' 
        ' IconBtnSave
        ' 
        IconBtnSave.BackColor = Color.DodgerBlue
        IconBtnSave.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        IconBtnSave.ForeColor = Color.White
        IconBtnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        IconBtnSave.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnSave.IconSize = 33
        IconBtnSave.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnSave.Location = New Point(930, 286)
        IconBtnSave.Name = "IconBtnSave"
        IconBtnSave.Size = New Size(114, 41)
        IconBtnSave.TabIndex = 30
        IconBtnSave.Text = "Save"
        IconBtnSave.TextAlign = ContentAlignment.MiddleLeft
        IconBtnSave.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnSave.UseVisualStyleBackColor = False
        ' 
        ' IconBtnEdit
        ' 
        IconBtnEdit.BackColor = Color.MediumSeaGreen
        IconBtnEdit.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        IconBtnEdit.ForeColor = Color.White
        IconBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit
        IconBtnEdit.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnEdit.IconSize = 33
        IconBtnEdit.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnEdit.Location = New Point(932, 286)
        IconBtnEdit.Name = "IconBtnEdit"
        IconBtnEdit.Size = New Size(112, 41)
        IconBtnEdit.TabIndex = 38
        IconBtnEdit.Text = "Edit"
        IconBtnEdit.TextAlign = ContentAlignment.MiddleLeft
        IconBtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnEdit.UseVisualStyleBackColor = False
        ' 
        ' IconBtnClear
        ' 
        IconBtnClear.BackColor = Color.LightCoral
        IconBtnClear.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        IconBtnClear.ForeColor = Color.DarkRed
        IconBtnClear.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateLeft
        IconBtnClear.IconColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        IconBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnClear.IconSize = 30
        IconBtnClear.ImageAlign = ContentAlignment.MiddleLeft
        IconBtnClear.Location = New Point(809, 286)
        IconBtnClear.Name = "IconBtnClear"
        IconBtnClear.Size = New Size(114, 41)
        IconBtnClear.TabIndex = 25
        IconBtnClear.Text = "Clear"
        IconBtnClear.TextAlign = ContentAlignment.MiddleLeft
        IconBtnClear.TextImageRelation = TextImageRelation.ImageBeforeText
        IconBtnClear.UseVisualStyleBackColor = False
        ' 
        ' IconPicBox
        ' 
        IconPicBox.BackColor = Color.White
        IconPicBox.ForeColor = Color.MediumSpringGreen
        IconPicBox.IconChar = FontAwesome.Sharp.IconChar.User
        IconPicBox.IconColor = Color.MediumSpringGreen
        IconPicBox.IconFont = FontAwesome.Sharp.IconFont.Solid
        IconPicBox.IconSize = 214
        IconPicBox.Location = New Point(819, 15)
        IconPicBox.Name = "IconPicBox"
        IconPicBox.Size = New Size(241, 214)
        IconPicBox.SizeMode = PictureBoxSizeMode.StretchImage
        IconPicBox.TabIndex = 18
        IconPicBox.TabStop = False
        ' 
        ' IconBtnUpload
        ' 
        IconBtnUpload.BackColor = Color.DodgerBlue
        IconBtnUpload.FlatAppearance.BorderColor = Color.DodgerBlue
        IconBtnUpload.FlatAppearance.BorderSize = 2
        IconBtnUpload.FlatStyle = FlatStyle.Flat
        IconBtnUpload.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        IconBtnUpload.ForeColor = Color.White
        IconBtnUpload.IconChar = FontAwesome.Sharp.IconChar.None
        IconBtnUpload.IconColor = Color.Black
        IconBtnUpload.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconBtnUpload.Location = New Point(869, 235)
        IconBtnUpload.Name = "IconBtnUpload"
        IconBtnUpload.Size = New Size(133, 38)
        IconBtnUpload.TabIndex = 24
        IconBtnUpload.Text = "Upload photo"
        IconBtnUpload.UseVisualStyleBackColor = False
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(1024, 430)
        txtPath.Name = "txtPath"
        txtPath.Size = New Size(222, 23)
        txtPath.TabIndex = 20
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' dgYouth
        ' 
        dgYouth.Anchor = AnchorStyles.Bottom
        dgYouth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgYouth.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgYouth.BackgroundColor = Color.White
        dgYouth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgYouth.Location = New Point(8, 533)
        dgYouth.Name = "dgYouth"
        dgYouth.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgYouth.Size = New Size(1155, 164)
        dgYouth.TabIndex = 24
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(877, 476)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(245, 23)
        txtSearch.TabIndex = 24
        ' 
        ' IconSearch
        ' 
        IconSearch.BackColor = Color.Transparent
        IconSearch.ForeColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        IconSearch.IconColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        IconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconSearch.IconSize = 30
        IconSearch.Location = New Point(842, 473)
        IconSearch.Name = "IconSearch"
        IconSearch.Size = New Size(33, 30)
        IconSearch.TabIndex = 25
        IconSearch.TabStop = False
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.BackColor = Color.Transparent
        Label41.Font = New Font("Cascadia Code", 10F)
        Label41.ForeColor = Color.FromArgb(CByte(28), CByte(30), CByte(33))
        Label41.Location = New Point(789, 477)
        Label41.Name = "Label41"
        Label41.Size = New Size(56, 18)
        Label41.TabIndex = 26
        Label41.Text = "Search"
        ' 
        ' FrmYouth
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1173, 700)
        Controls.Add(Label41)
        Controls.Add(IconSearch)
        Controls.Add(txtSearch)
        Controls.Add(dgYouth)
        Controls.Add(txtPath)
        Controls.Add(IconBtnUpload)
        Controls.Add(IconPicBox)
        Controls.Add(IconBtnClear)
        Controls.Add(IconBtnEdit)
        Controls.Add(IconBtnSave)
        Controls.Add(gbDemographic)
        Controls.Add(gbProfile)
        Controls.Add(IconBtnAdd)
        Name = "FrmYouth"
        Text = "Youth"
        gbProfile.ResumeLayout(False)
        gbProfile.PerformLayout()
        gbDemographic.ResumeLayout(False)
        gbDemographic.PerformLayout()
        CType(IconPicBox, ComponentModel.ISupportInitialize).EndInit()
        CType(dgYouth, ComponentModel.ISupportInitialize).EndInit()
        CType(IconSearch, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IconBtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents gbProfile As GroupBox
    Friend WithEvents gbDemographic As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtYouthID As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents cboPurok As ComboBox
    Friend WithEvents cboMunicipality As ComboBox
    Friend WithEvents cboProvince As ComboBox
    Friend WithEvents cboRegion As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboCivilStat As ComboBox
    Friend WithEvents cboAgeGroup As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboEducationAttain As ComboBox
    Friend WithEvents cboClassification As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cboWorkStat As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cboVoter As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cboAttend As ComboBox
    Friend WithEvents cboNotAttend As ComboBox
    Friend WithEvents cboIsAttend As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblHowManyTimes As Label
    Friend WithEvents lblWhy As Label
    Friend WithEvents IconBtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents IconPicBox As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconBtnUpload As FontAwesome.Sharp.IconButton
    Friend WithEvents Label37 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgYouth As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txtBarangay As TextBox
End Class
