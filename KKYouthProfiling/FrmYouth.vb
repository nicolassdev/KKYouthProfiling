Imports System.Text.RegularExpressions
Imports System.Runtime.Versioning
Imports System.Xml
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Tracing
Imports System.Drawing
Imports Microsoft.Win32
Imports Org.BouncyCastle.Crypto.Agreement
Imports System.Runtime.CompilerServices
Public Class FrmYouth

    Public maxNumber As Integer
    Private idnum As String

    Sub getYouthID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim YouthID As String
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxNumber = Convert.ToInt32(getMaxNumberYouth()) '3
        idnum = maxNumber + 1 '1 + 1 idnum=4
        YouthID = "SKB-" & Year & "-" & idnum 'EMP-2023-4
        txtYouthID.Text = YouthID
    End Sub


    'Custom form load design
    Private Sub CustomizeDataGridView()
        ' Set DataGridView background color
        dgYouth.BackgroundColor = System.Drawing.Color.FromArgb(33, 37, 41)

        ' Set alternating row background colors
        dgYouth.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 48, 52)
        dgYouth.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 55, 60)

        ' Set font and foreground color (text color)
        dgYouth.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgYouth.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White

        ' Remove gridlines for a cleaner look
        dgYouth.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgYouth.GridColor = System.Drawing.Color.FromArgb(44, 48, 52)

        ' Header styling
        dgYouth.EnableHeadersVisualStyles = False
        dgYouth.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(77, 82, 87)
        dgYouth.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgYouth.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgYouth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgYouth.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Row height and border styling
        dgYouth.RowTemplate.Height = 20
        dgYouth.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(90, 90, 90)
        dgYouth.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White

        ' Border style and padding
        dgYouth.BorderStyle = BorderStyle.None
        dgYouth.DefaultCellStyle.Padding = New Padding(2)

        ' Make sure the DataGridView fits well into the form
        dgYouth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    'SHOW DATA OF YOUTH AND RELOAD
    Sub LoadgridYouthInfo()

        Try
            If (MyCOn.State = ConnectionState.Open) Then MyCOn.Close()
            MyCOn.Open()
            dt = New DataTable

            With MyCommand
                .Connection = MyCOn
                .CommandText = "SELECT 
                youth_details.YOUTH_ID,
                youth_details.FIRSTNAME AS 'FIRST NAME',
                youth_details.MIDDLENAME,
                youth_details.LASTNAME AS 'LAST NAME',
                youth_details.AGE AS 'AGE',
                youth_details.DOB AS 'DATE OF BIRTH',
                youth_details.GENDER AS 'GENDER',
                youth_details.CONTACT AS 'CONTACT',
                youth_details.EMAIL AS 'EMAIL',
                youth_details.PUROK AS 'PUROK',
                youth_details.BARANGAY,
                youth_details.MUNICIPALITY,
                youth_details.PROVINCE,
                youth_details.REGION,
                demographic_details.CIVIL_STATUS,
                demographic_details.AGE_GROUP,
                demographic_details.CLASSIFICATION,
                demographic_details.EDUC_ATTAINMENT AS 'EDUCATION',
                demographic_details.WORK_STATUS,
                demographic_details.VOTER AS 'VOTER',
                demographic_details.ATTEND_KK_ASSEMBLY,
                demographic_details.IS_ATTENDED,
                demographic_details.NOT_ATTENDED,
                demographic_details.PICTURE
            FROM 
                youth_details
            INNER JOIN 
                demographic_details
            ON 
                youth_details.YOUTH_ID = demographic_details.YOUTH_ID"


            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            dgYouth.DataSource = dt
            dgYouth.RowHeadersVisible = False
            MyCOn.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub DisableBtn()
        IconBtnSave.Enabled = False
        IconBtnClear.Enabled = False
        IconBtnUpload.Enabled = False
    End Sub


    Private Sub ClearText()
        txtYouthID.Text = ""
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtAge.Text = ""
        dtpDob.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        dtpDob.CustomFormat = " "

        txtPath.Text = Nothing
        IconPicBox.Image = Nothing
        IconPicBox.ImageLocation = "D:\YouthProfiling\KKYouthProfiling\KKYouthProfiling\Resources\Default.png"


        'Hide Combo Box 
        cboIsAttend.Visible = False
        cboNotAttend.Visible = False
        lblHowManyTimes.Visible = False
        lblWhy.Visible = False

        'Lock GroupBox 
        gbDemographic.Enabled = False
        gbProfile.Enabled = False

        'Text Button
        'IconBtnClear.Text = "Disabled"
        'IconBtnSave.Text = "Disabled"


        ' Define the ComboBox fields array
        Dim fields As ComboBox() = {cboPurok, cboGender, cboRegion, cboProvince, cboMunicipality, cboCivilStat, cboAgeGroup, cboClassification, cboEducationAttain, cboWorkStat, cboVoter, cboAttend, cboIsAttend, cboNotAttend}

        ' Loop through each field to clear selection and reset color
        For Each field In fields
            field.SelectedIndex = -1 ' Clear the selection (reset to no selection)
            field.BackColor = SystemColors.Window ' Reset the background color to default
        Next


        'VALIDATION FOR TEXT INPUT
        Dim txtfields As TextBox() = {txtYouthID, txtFname, txtMname, txtLname, txtAge, txtContact, txtEmail, txtBarangay}
        ' Loop through each field to clear text and reset color
        For Each txtfield In txtfields
            txtfield.Text = "" ' Clear the text
            txtfield.BackColor = SystemColors.Window ' Reset the background color to default
        Next
    End Sub

    Private Sub SelectMunicipalitiesAlbay()
        cboMunicipality.Items.Add("Legazpi")
        cboMunicipality.Items.Add("Ligao ")
        cboMunicipality.Items.Add("Tabaco ")
        cboMunicipality.Items.Add("Bacacay")
        cboMunicipality.Items.Add("Camalig")
        cboMunicipality.Items.Add("Daraga ")
        cboMunicipality.Items.Add("Guinobatan")
        cboMunicipality.Items.Add("Jovellar")
        cboMunicipality.Items.Add("Libon")
        cboMunicipality.Items.Add("Malilipot")
        cboMunicipality.Items.Add("Malinao")
        cboMunicipality.Items.Add("Manito")
        cboMunicipality.Items.Add("Oas")
        cboMunicipality.Items.Add("Pio Duran")
        cboMunicipality.Items.Add("Rapu-Rapu")
        cboMunicipality.Items.Add("Santo Domingo")
        cboMunicipality.Items.Add("Tiwi")

    End Sub

    Private Sub SelectMunicipalitiesCamarinesNorte()
        cboMunicipality.Items.Add("Basud")
        cboMunicipality.Items.Add("Capalonga")
        cboMunicipality.Items.Add("Daet")
        cboMunicipality.Items.Add("Jose Panganiban")
        cboMunicipality.Items.Add("Labo")
        cboMunicipality.Items.Add("Mercedes")
        cboMunicipality.Items.Add("Paracale")
        cboMunicipality.Items.Add("San Lorenzo Ruiz")
        cboMunicipality.Items.Add("San Vicente")
        cboMunicipality.Items.Add("Santa Elena")
        cboMunicipality.Items.Add("Talisay")
        cboMunicipality.Items.Add("Vinzons")
    End Sub
    Private Sub SelectMunicipalitiesCamarinesSur()
        cboMunicipality.Items.Add("Iriga")
        cboMunicipality.Items.Add("Naga")
        cboMunicipality.Items.Add("Baao")
        cboMunicipality.Items.Add("Balatan")
        cboMunicipality.Items.Add("Bato")
        cboMunicipality.Items.Add("Bombon")
        cboMunicipality.Items.Add("Buhi")
        cboMunicipality.Items.Add("Bula")
        cboMunicipality.Items.Add("Cabusao")
        cboMunicipality.Items.Add("Calabanga")
        cboMunicipality.Items.Add("Camaligan")
        cboMunicipality.Items.Add("Canaman")
        cboMunicipality.Items.Add("Caramoan")
        cboMunicipality.Items.Add("Gainza")
        cboMunicipality.Items.Add("Garchitorena")
        cboMunicipality.Items.Add("Goa")
        cboMunicipality.Items.Add("Lagonoy")
        cboMunicipality.Items.Add("Libmanan")
        cboMunicipality.Items.Add("Lupi")
        cboMunicipality.Items.Add("Magarao")
        cboMunicipality.Items.Add("Ocampo")
        cboMunicipality.Items.Add("Nabua")
    End Sub

    Private Sub SelectMunicipalitiesCatanduanes()
        cboMunicipality.Items.Add("Bagamanoc")
        cboMunicipality.Items.Add("Baras")
        cboMunicipality.Items.Add("Bato")
        cboMunicipality.Items.Add("Caramoran")
        cboMunicipality.Items.Add("Gigmoto")
        cboMunicipality.Items.Add("Pandan")
        cboMunicipality.Items.Add("Panganiban")
        cboMunicipality.Items.Add("San Andres")
        cboMunicipality.Items.Add("San Miguel")
        cboMunicipality.Items.Add("Viga")
        cboMunicipality.Items.Add("Virac")
    End Sub

    Private Sub SelectMunicipalitiesMasbate()
        cboMunicipality.Items.Add("Aroroy")
        cboMunicipality.Items.Add("Baleno")
        cboMunicipality.Items.Add("Balud")
        cboMunicipality.Items.Add("Batuan")
        cboMunicipality.Items.Add("Cataingan")
        cboMunicipality.Items.Add("Cawayan")
        cboMunicipality.Items.Add("Claveria")
        cboMunicipality.Items.Add("Dimasalang")
        cboMunicipality.Items.Add("Esperanza")
        cboMunicipality.Items.Add("Mandaon")
        cboMunicipality.Items.Add("Milagros")
        cboMunicipality.Items.Add("Mobo")
        cboMunicipality.Items.Add("Monreal")
        cboMunicipality.Items.Add("Palanas")
        cboMunicipality.Items.Add("Placer")
        cboMunicipality.Items.Add("San Fernando")
        cboMunicipality.Items.Add("Uson")
    End Sub
    Private Sub SelectMunicipalitiesSorsogon()
        cboMunicipality.Items.Add("Bulan")
        cboMunicipality.Items.Add("Bulusan")
        cboMunicipality.Items.Add("Casiguran")
        cboMunicipality.Items.Add("Castilla")
        cboMunicipality.Items.Add("Donsol")
        cboMunicipality.Items.Add("Gubat")
        cboMunicipality.Items.Add("Irosin")
        cboMunicipality.Items.Add("Juban")
        cboMunicipality.Items.Add("Magallanes")
        cboMunicipality.Items.Add("Matnog")
        cboMunicipality.Items.Add("Pilar")
        cboMunicipality.Items.Add("Prieto Diaz")
        cboMunicipality.Items.Add("Santa Magdalena")
        cboMunicipality.Items.Add("Barcelona")

    End Sub
    Private Sub PopulateMunicipalities(province As String)
        ' Clear the previous municipality list
        'cboMunicipality.Items.Clear()

        Select Case province
            Case "Albay"
                SelectMunicipalitiesAlbay()
            Case "Camarines Norte"
                SelectMunicipalitiesCamarinesNorte()
            Case "Camarines Sur"
                SelectMunicipalitiesCamarinesSur()
            Case "Catanduanes"
                SelectMunicipalitiesCatanduanes()
            Case "Masbate"
                SelectMunicipalitiesMasbate()
            Case "Sorsogon"
                SelectMunicipalitiesSorsogon()
        End Select
    End Sub
    Private Sub FrmYouth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply custom styles to the DataGridView
        CustomizeDataGridView()
        'LOAD YOUTH DEITALS
        LoadgridYouthInfo()

        'HIDE ROW IN TABLE 
        Me.dgYouth.Columns(0).Visible = False
        Me.dgYouth.Columns(2).Visible = False
        Me.dgYouth.Columns(8).Visible = False

        'Me.dgYouth.Columns(9).Visible = False

        Me.dgYouth.Columns(10).Visible = False
        Me.dgYouth.Columns(11).Visible = False
        Me.dgYouth.Columns(12).Visible = False
        Me.dgYouth.Columns(13).Visible = False
        Me.dgYouth.Columns(14).Visible = False

        Me.dgYouth.Columns(15).Visible = False
        Me.dgYouth.Columns(16).Visible = False
        Me.dgYouth.Columns(18).Visible = False

        Me.dgYouth.Columns(20).Visible = False
        Me.dgYouth.Columns(21).Visible = False
        Me.dgYouth.Columns(22).Visible = False
        Me.dgYouth.Columns(23).Visible = False




        'Disable YOUTH ID
        txtYouthID.Enabled = False
        txtAge.Enabled = False
        'Disable group box
        gbProfile.Enabled = False
        gbDemographic.Enabled = False

        'ComboBox Gender
        cboGender.Items.Add("Male")
        cboGender.Items.Add("Female")

        'ComboBox Civil Status
        cboCivilStat.Items.Add("Single")
        cboCivilStat.Items.Add("Married")
        cboCivilStat.Items.Add("Widowed")
        cboCivilStat.Items.Add("Divorced")
        cboCivilStat.Items.Add("Separated")
        cboCivilStat.Items.Add("Annulled")
        cboCivilStat.Items.Add("Unkown")
        cboCivilStat.Items.Add("Live-in")

        'ComboBox Youth Age Group
        cboAgeGroup.Items.Add("Child Youth(15-17 y/o)")
        cboAgeGroup.Items.Add("Core Youth(18-24 y/o)")
        cboAgeGroup.Items.Add("Young Adult(25-30 y/o)")

        'ComboBox Youth Classfication
        cboClassification.Items.Add("ISY")
        cboClassification.Items.Add("OSY")
        cboClassification.Items.Add("YSN(PWD/IP)")
        cboClassification.Items.Add("N/A")

        'ComboBox Educational Background
        cboEducationAttain.Items.Add("Elemetary Level")
        cboEducationAttain.Items.Add("Elemetary Grad")
        cboEducationAttain.Items.Add("High School level")
        cboEducationAttain.Items.Add("High School Grad")
        cboEducationAttain.Items.Add("Vocational Grad")
        cboEducationAttain.Items.Add("College Level")
        cboEducationAttain.Items.Add("College Grad")
        cboEducationAttain.Items.Add("Master Level")
        cboEducationAttain.Items.Add("Master Grad")
        cboEducationAttain.Items.Add("Doctorate Level")
        cboEducationAttain.Items.Add("Doctorate Graduate")

        'ComboBox Work Status
        cboWorkStat.Items.Add("Employed")
        cboWorkStat.Items.Add("Unemployed")
        cboWorkStat.Items.Add("Self-Employed")
        cboWorkStat.Items.Add("Currently looking for a job")
        cboWorkStat.Items.Add("N/A")

        'ComboBox Registered SK & National Voter
        cboVoter.Items.Add("YES")
        cboVoter.Items.Add("NO")


        'ComboBox if attended kk assembly
        cboAttend.Items.Add("YES")
        cboAttend.Items.Add("NO")

        'ComboBox if yes then answer are ..
        cboIsAttend.Items.Add("1-2 Times")
        cboIsAttend.Items.Add("3-4 Times")
        cboIsAttend.Items.Add("5 and above")

        'ComboBox if no then answer are ..
        cboNotAttend.Items.Add("There was no KK Aseembly Meeting")
        cboNotAttend.Items.Add("Not interested to Attend")
        cboNotAttend.Items.Add("N/A")



        'ComboBox Purok
        ' Populate cboPurok with items formatted as "PUROK-1" to "PUROK-9"
        For i As Integer = 1 To 9
            cboPurok.Items.Add("PUROK-" & i.ToString())
        Next


        'Hide cboIsAttended and cboNotAttended selection
        cboIsAttend.Visible = False
        cboNotAttend.Visible = False
        lblHowManyTimes.Visible = False
        lblWhy.Visible = False
        txtPath.Visible = False

        'Enable button Save and Clear
        IconBtnAdd.Enabled = True
        IconBtnEdit.Enabled = True

        IconBtnSave.Enabled = False
        IconBtnSave.Visible = False

        IconBtnClear.Enabled = False
        IconBtnClear.Visible = False

        IconBtnUpload.Enabled = False

        'USER CAN ONLY SELECT IN COMBO BOX 
        cboPurok.DropDownStyle = ComboBoxStyle.DropDownList
        cboGender.DropDownStyle = ComboBoxStyle.DropDownList

        cboRegion.DropDownStyle = ComboBoxStyle.DropDownList
        cboProvince.DropDownStyle = ComboBoxStyle.DropDownList
        cboMunicipality.DropDownStyle = ComboBoxStyle.DropDownList
        cboCivilStat.DropDownStyle = ComboBoxStyle.DropDownList
        cboAgeGroup.DropDownStyle = ComboBoxStyle.DropDownList
        cboClassification.DropDownStyle = ComboBoxStyle.DropDownList
        cboEducationAttain.DropDownStyle = ComboBoxStyle.DropDownList
        cboWorkStat.DropDownStyle = ComboBoxStyle.DropDownList
        cboVoter.DropDownStyle = ComboBoxStyle.DropDownList
        cboAttend.DropDownStyle = ComboBoxStyle.DropDownList


        'DATE TIME PICKER CUSTOMER FORMAT SET NULL
        dtpDob.CustomFormat = " "

        'DEFUALT IMAGE 
        IconPicBox.ImageLocation = "D:\YouthProfiling\KKYouthProfiling\KKYouthProfiling\Resources\Default.png"
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub



    Private Sub IconBtnAdd_Click(sender As Object, e As EventArgs) Handles IconBtnAdd.Click
        'GET RANDOM ID GENERATED
        getYouthID()

        'Enable groupbox
        gbDemographic.Enabled = True
        gbProfile.Enabled = True

        'Disable button 
        IconBtnAdd.Enabled = False
        IconBtnAdd.Visible = False

        IconBtnEdit.Enabled = False
        IconBtnEdit.Visible = False
        IconBtnEdit.Text = "Disabled"


        'Enable Button
        IconBtnUpload.Enabled = True

        IconBtnSave.Enabled = True
        IconBtnSave.Visible = True
        IconBtnSave.Text = "Save"
        IconBtnClear.Enabled = True
        IconBtnClear.Visible = True
        IconBtnClear.Text = "Clear"

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        ' Remove all spaces and reformat the text
        Dim contactNumber As String = txtContact.Text.Replace(" ", "").Replace("+63", "")

        ' Check if the first digit is not '9'
        If contactNumber.Length > 0 AndAlso contactNumber.Substring(0, 1) <> "9" Then
            MsgBox("Contact number must start with '9'", MsgBoxStyle.Exclamation, "Invalid Input")
            txtContact.Text = "+63 " ' Reset the text if invalid
            txtContact.SelectionStart = txtContact.Text.Length
            Exit Sub
        End If

        ' Limit the contact number to 10 digits
        If contactNumber.Length > 10 Then
            contactNumber = contactNumber.Substring(0, 10)
        End If

        ' Apply the format +63 000 0000 000
        If contactNumber.Length > 6 Then
            txtContact.Text = $"+63 {contactNumber.Substring(0, 3)} {contactNumber.Substring(3, 4)} {contactNumber.Substring(7)}"
        ElseIf contactNumber.Length > 3 Then
            txtContact.Text = $"+63 {contactNumber.Substring(0, 3)} {contactNumber.Substring(3)}"
        ElseIf contactNumber.Length > 0 Then
            txtContact.Text = $"+63 {contactNumber}"
        Else
            txtContact.Text = "+63 "
        End If

        ' Set cursor position to the end
        txtContact.SelectionStart = txtContact.Text.Length
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

        End If
        If txtContact.Text.Length >= 16 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub cboAttend_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAttend.SelectedIndexChanged
        If cboAttend.Text = "YES" Then
            lblHowManyTimes.Visible = True
            cboIsAttend.Visible = True
            lblWhy.Visible = False
            cboNotAttend.Visible = False
        ElseIf cboAttend.Text = "NO" Then
            cboIsAttend.Visible = False
            lblHowManyTimes.Visible = False
            cboNotAttend.Visible = True
            lblWhy.Visible = True
        End If

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ' Define the pattern for a basic email validation
        Dim emailPattern As String = "^[\w\.-]+@[\w\.-]+\.\w+$"

        ' Check if the current text in txtEmail matches the email pattern
        Dim isValidEmail As Boolean = Regex.IsMatch(txtEmail.Text, emailPattern)

        ' Provide feedback based on validation
        If isValidEmail Then
            txtEmail.BackColor = Color.White  ' Valid email - set background to white
        Else
            txtEmail.BackColor = Color.LightCoral  ' Invalid email - set background to light coral
        End If
    End Sub

    Private Sub IconBtnClear_Click(sender As Object, e As EventArgs) Handles IconBtnClear.Click
        ' Enable the Add button
        IconBtnAdd.Enabled = True
        IconBtnAdd.Visible = True
        IconBtnEdit.Enabled = True
        IconBtnEdit.Visible = True

        IconBtnEdit.Text = "Edit"

        ' Disable certain buttons and controls
        DisableBtn()

        ' Clear text fields
        ClearText()


        'Reset txt UPDATE to Save
        IconBtnSave.Text = "Save"

        'Disable Group Box
        gbProfile.Enabled = False
        gbDemographic.Enabled = False

        'Hide button
        IconBtnClear.Visible = False
        IconBtnSave.Visible = False

    End Sub

    Private Sub IconBtnSave_Click(sender As Object, e As EventArgs) Handles IconBtnSave.Click
        'Validation FOR COMBO BOX INPUT
        Dim fields As ComboBox() = {cboPurok, cboGender, cboRegion, cboProvince, cboMunicipality, cboCivilStat, cboAgeGroup, cboClassification, cboEducationAttain, cboWorkStat, cboVoter, cboAttend}
        For Each field In fields
            If field.Text = "" Then
                MsgBox(field.Name.Replace("cbo", "") & " is required!", MsgBoxStyle.Exclamation, "Required")
                field.BackColor = Color.LightCoral
                field.Focus()
                Exit Sub
            End If
        Next
        'VALIDATION FOR TEXT INPUT
        Dim txtfields As TextBox() = {txtYouthID, txtFname, txtLname, txtAge, txtEmail, txtBarangay}
        For Each txtfield In txtfields
            If txtfield.Text = "" Then
                MsgBox(txtfield.Name.Replace("txt", "") & " is required!", MsgBoxStyle.Exclamation, "Required")
                txtfield.BackColor = Color.LightCoral
                txtfield.Focus()
                Exit Sub
            End If
        Next
        'VALIDATION FOR DATE OF BIRTH
        If dtpDob.Text = "" Then
            MsgBox("Date of Birth is required!", MsgBoxStyle.Exclamation, "Required")
            dtpDob.BackColor = Color.LightCoral
            dtpDob.Focus()
            Exit Sub
        End If



        Try
            'THIS IS UPDATE YOUTH DETAILS

            If IconBtnSave.Text = "Update" Then

                ' Open connection
                If MyCOn.State = ConnectionState.Closed Then MyCOn.Open()

                ' Update youth_details
                Dim updateYouthDetails As String = "UPDATE youth_details SET FIRSTNAME = @FirstName, MIDDLENAME = @MiddleName, LASTNAME = @LastName, AGE = @Age, DOB = @Dob, GENDER = @Gender, 
                                                CONTACT = @Contact, EMAIL = @Email, PUROK = @Purok, BARANGAY = @Barangay, MUNICIPALITY = @Municipality, PROVINCE = @Province, REGION = @Region 
                                                WHERE YOUTH_ID = @YouthID"

                Using cmd As New MySqlCommand(updateYouthDetails, MyCOn)
                    cmd.Parameters.AddWithValue("@FirstName", txtFname.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@MiddleName", txtMname.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@LastName", txtLname.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Dob", Convert.ToDateTime(dtpDob.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Gender", cboGender.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim().ToLower())
                    cmd.Parameters.AddWithValue("@Purok", cboPurok.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@Barangay", txtBarangay.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@Municipality", cboMunicipality.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@Province", cboProvince.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@Region", cboRegion.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@YouthID", txtYouthID.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                ' Update demographic_details
                Dim updateDemographicDetails As String = "UPDATE demographic_details SET CIVIL_STATUS = @CivilStat, AGE_GROUP = @AgeGroup, CLASSIFICATION = @Classification, EDUC_ATTAINMENT = @EducationBackground,
                                                      WORK_STATUS = @WorkStat, VOTER = @Voter, ATTEND_KK_ASSEMBLY = @KkAssembly, IS_ATTENDED = @IsAttended, NOT_ATTENDED = @NotAttended, PICTURE = @Picture 
                                                      WHERE YOUTH_ID = @YouthID"

                Using cmd As New MySqlCommand(updateDemographicDetails, MyCOn)
                    cmd.Parameters.AddWithValue("@CivilStat", cboCivilStat.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@AgeGroup", cboAgeGroup.Text.Trim())
                    cmd.Parameters.AddWithValue("@Classification", cboClassification.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@EducationBackground", cboEducationAttain.Text.Trim())
                    cmd.Parameters.AddWithValue("@WorkStat", cboWorkStat.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@Voter", cboVoter.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("@KkAssembly", cboAttend.Text.Trim())
                    cmd.Parameters.AddWithValue("@IsAttended", cboIsAttend.Text.Trim())
                    cmd.Parameters.AddWithValue("@NotAttended", cboNotAttend.Text.Trim())
                    cmd.Parameters.AddWithValue("@Picture", txtPath.Text.Trim())
                    cmd.Parameters.AddWithValue("@YouthID", txtYouthID.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                ' Success message and UI updates
                MessageBox.Show("Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearText()
                IconBtnAdd.Enabled = True
                IconBtnAdd.Visible = True
                IconBtnEdit.Enabled = True
                IconBtnEdit.Visible = True
                IconBtnSave.Visible = False
                IconBtnClear.Visible = False
                IconBtnEdit.Text = "Edit"
                LoadgridYouthInfo()
                DisableBtn()


            Else

                'THIS IS INSERT YOUTH DETAILS

                ' Check if FirstName, LastName already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM YOUTH_DETAILS WHERE FIRSTNAME = @FirstName AND LASTNAME = @LastName"
                Dim exists As Integer = 0

                ' Format contact with country code
                If Not txtContact.Text.StartsWith("+63") Then
                    txtContact.Text = "+63" & txtContact.Text
                End If
                ' Open connection
                If MyCOn.State = ConnectionState.Closed Then MyCOn.Open()
                ' Check for duplicate entries
                Using checkCmd As New MySqlCommand(checkQuery, MyCOn)
                    checkCmd.Parameters.AddWithValue("@FirstName", txtFname.Text.ToUpper)
                    checkCmd.Parameters.AddWithValue("@LastName", txtLname.Text.ToUpper)
                    exists = Convert.ToInt32(checkCmd.ExecuteScalar())
                End Using

                ' If a duplicate exists, show a message and exit
                If exists > 0 Then
                    MsgBox("First Name and Last Name combination is already taken!", MsgBoxStyle.Exclamation, "Duplicate Entry")
                    Exit Sub
                End If

                ' Open connection
                If MyCOn.State = ConnectionState.Closed Then MyCOn.Open()

                ' Insert into YOUTH_DETAILS
                Dim queryInsertYouthDetails As String = "INSERT INTO YOUTH_DETAILS(YOUTH_ID, FIRSTNAME, MIDDLENAME, LASTNAME, AGE, DOB, GENDER, CONTACT, EMAIL, PUROK, BARANGAY, MUNICIPALITY, PROVINCE, REGION, DATE_ADDED) " &
                                                        "VALUES(@YouthID, @FirstName, @MiddleName, @LastName, @Age, @Dob, @Gender, @Contact, @Email, @Purok, @Barangay, @Municipality, @Province, @Region, NOW());"

                Using cmd As New MySqlCommand(queryInsertYouthDetails, MyCOn)
                    cmd.Parameters.AddWithValue("@YouthID", txtYouthID.Text)
                    cmd.Parameters.AddWithValue("@FirstName", txtFname.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMname.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@LastName", txtLname.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Dob", Convert.ToDateTime(dtpDob.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Gender", cboGender.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim().ToLower)
                    cmd.Parameters.AddWithValue("@Purok", cboPurok.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@Barangay", txtBarangay.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@Municipality", cboMunicipality.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@Province", cboProvince.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@Region", cboRegion.Text.Trim().ToUpper)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert into DEMOGRAPHIC_DETAILS
                Dim queryInsertDemographicDetails As String = "INSERT INTO DEMOGRAPHIC_DETAILS(YOUTH_ID, CIVIL_STATUS, AGE_GROUP, CLASSIFICATION, EDUC_ATTAINMENT, WORK_STATUS, VOTER, ATTEND_KK_ASSEMBLY, IS_ATTENDED, NOT_ATTENDED, PICTURE) " &
                                                       "VALUES(@YouthID, @CivilStat, @AgeGroup, @Classification, @EducationBackground, @WorkStat, @Voter, @KkAssembly, @IsAttended, @NotAttended, @Picture);"

                Using cmd As New MySqlCommand(queryInsertDemographicDetails, MyCOn)
                    cmd.Parameters.AddWithValue("@YouthID", txtYouthID.Text)
                    cmd.Parameters.AddWithValue("@CivilStat", cboCivilStat.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@AgeGroup", cboAgeGroup.Text.Trim())
                    cmd.Parameters.AddWithValue("@Classification", cboClassification.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@EducationBackground", cboEducationAttain.Text.Trim())
                    cmd.Parameters.AddWithValue("@WorkStat", cboWorkStat.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@Voter", cboVoter.Text.Trim().ToUpper)
                    cmd.Parameters.AddWithValue("@KkAssembly", cboAttend.Text.Trim())
                    cmd.Parameters.AddWithValue("@IsAttended", cboIsAttend.Text.Trim())
                    cmd.Parameters.AddWithValue("@NotAttended", cboNotAttend.Text.Trim())
                    cmd.Parameters.AddWithValue("@Picture", txtPath.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearText()
                IconBtnAdd.Enabled = True
                IconBtnAdd.Visible = True
                IconBtnEdit.Enabled = True
                IconBtnEdit.Visible = True
                IconBtnSave.Visible = False
                IconBtnClear.Visible = False
                IconBtnEdit.Text = "Edit"
                LoadgridYouthInfo()
                DisableBtn()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure connection is closed in finally block
            If MyCOn.State = ConnectionState.Open Then MyCOn.Close()
        End Try

    End Sub

    Private Sub dtpDob_ValueChanged(sender As Object, e As EventArgs) Handles dtpDob.ValueChanged
        ' Set custom format for DateTimePicker
        dtpDob.CustomFormat = "   dd-MM-yyyy"

        ' Get the selected date of birth from the DateTimePicker
        Dim dob As Date = dtpDob.Value

        ' Calculate the age based on the current date
        Dim today As Date = Date.Today
        Dim years As Integer = today.Year - dob.Year
        Dim months As Integer = today.Month - dob.Month

        ' Adjust if the birthdate has not occurred this year yet
        If today.Day < dob.Day Then
            months -= 1
        End If
        If months < 0 Then
            years -= 1
            months += 12
        End If

        ' Display the age in the text box
        txtAge.Text = $"{years}" 'will leave it comment the month of youth {months}
    End Sub

    Private Sub IconBtnUpload_Click(sender As Object, e As EventArgs) Handles IconBtnUpload.Click
        Try
            ' Show the OpenFileDialog once and capture the result
            Dim img = OpenFileDialog1.ShowDialog()

            ' Check if the user selected a file (DialogResult.OK)
            If img = DialogResult.OK Then
                ' Set the file filter
                OpenFileDialog1.Filter = "Jpeg|*.JPG|Bitmap|*.BMP|Gif|*.GIF"
                OpenFileDialog1.RestoreDirectory = True

                ' Ensure the filename is not empty before proceeding
                If OpenFileDialog1.FileName <> "" Then
                    ' Set the image location and update the text box with the file path
                    IconPicBox.ImageLocation = OpenFileDialog1.FileName
                    txtPath.Text = Replace(OpenFileDialog1.FileName, "\", ";")
                End If
            End If
        Catch ex As Exception
            ' Handle any exceptions that occur
            MessageBox.Show("An error occurred while selecting the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            ' Close the connection if it is already open
            If MyCOn.State = ConnectionState.Open Then
                MyCOn.Close()
            End If

            ' Refresh the DataGridView
            dgYouth.Refresh()

            ' Open the database connection
            MyCOn.Open()

            ' Set the SQL query to search for specific fields and filter by YOUTH_ID
            MyCommand.Connection = MyCOn
            MyCommand.CommandText = "SELECT 
        youth_details.YOUTH_ID,
        youth_details.FIRSTNAME AS 'FIRST NAME',
        youth_details.MIDDLENAME,
        youth_details.LASTNAME AS 'LAST NAME',
        youth_details.AGE AS 'AGE',
        youth_details.DOB AS 'DATE OF BIRTH',
        youth_details.GENDER AS 'GENDER',
        youth_details.CONTACT AS 'CONTACT',
        youth_details.EMAIL,
        youth_details.PUROK AS 'PUROK',
        youth_details.BARANGAY,
        youth_details.MUNICIPALITY ,
        youth_details.PROVINCE,
        youth_details.REGION,
        demographic_details.CIVIL_STATUS ,
        demographic_details.AGE_GROUP,
        demographic_details.CLASSIFICATION,
        demographic_details.EDUC_ATTAINMENT AS 'EDUCATION',
        demographic_details.WORK_STATUS,
        demographic_details.VOTER AS 'VOTER',
        demographic_details.ATTEND_KK_ASSEMBLY,
        demographic_details.IS_ATTENDED,
        demographic_details.NOT_ATTENDED,
        demographic_details.PICTURE
    FROM 
        youth_details
    INNER JOIN 
        demographic_details
    ON 
        youth_details.YOUTH_ID = demographic_details.YOUTH_ID
    WHERE 
        youth_details.YOUTH_ID LIKE @search OR
        youth_details.FIRSTNAME LIKE @search OR
        youth_details.LASTNAME LIKE @search OR
        youth_details.AGE LIKE @search OR
        youth_details.DOB LIKE @search OR
        youth_details.GENDER LIKE @search OR
        youth_details.CONTACT LIKE @search OR
        youth_details.PUROK LIKE @search OR
        demographic_details.EDUC_ATTAINMENT LIKE @search OR
        demographic_details.VOTER LIKE @search"

            ' Use a parameterized query to prevent SQL injection
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")

            ' Fill the DataTable with the results
            MyAdapter.SelectCommand = MyCommand
            dt = New DataTable()
            dt.Clear()
            MyAdapter.Fill(dt)

            ' Bind the results to the DataGridView
            dgYouth.DataSource = dt

            ' Close the connection
            MyCOn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgYouth_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgYouth.CellClick
        IconBtnAdd.Visible = False
        IconBtnClear.Visible = True
        Try
            Dim i As Integer = dgYouth.CurrentRow.Index

            ' Basic Information
            Me.txtYouthID.Text = dgYouth.Item(0, i).Value?.ToString()

            ' Name Fields
            Me.txtFname.Text = dgYouth.Item(1, i).Value?.ToString()
            Me.txtMname.Text = dgYouth.Item(2, i).Value?.ToString()
            Me.txtLname.Text = dgYouth.Item(3, i).Value?.ToString()
            Me.txtAge.Text = dgYouth.Item(4, i).Value?.ToString()

            ' Date of Birth Handling
            If dgYouth.Item(5, i).Value IsNot Nothing AndAlso Not IsDBNull(dgYouth.Item(5, i).Value) Then
                Try
                    Me.dtpDob.Text = Convert.ToDateTime(dgYouth.Item(5, i).Value).ToString("yyyy-MM-dd")
                Catch ex As InvalidCastException
                    MessageBox.Show("Invalid Date of Birth format. Please verify the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Else
                Me.dtpDob.Text = ""
            End If

            Me.cboGender.Text = dgYouth.Item(6, i).Value?.ToString()

            ' Contact Number Handling
            Dim contactNumber As String = dgYouth.Item(7, i).Value?.ToString()
            If Not String.IsNullOrEmpty(contactNumber) AndAlso Not contactNumber.StartsWith("+63") Then
                Me.txtContact.Text = "+63" & contactNumber
            Else
                Me.txtContact.Text = contactNumber
            End If
            Me.txtEmail.Text = dgYouth.Item(8, i).Value?.ToString()
            Me.cboPurok.Text = dgYouth.Item(9, i).Value?.ToString()

            ' Barangay and Municipality
            Me.txtBarangay.Text = dgYouth.Item(10, i).Value?.ToString()
            Dim municipality As String = dgYouth.Item(11, i).Value?.ToString()
            Dim province As String = dgYouth.Item(12, i).Value?.ToString()

            ' Re-populate the municipality based on the selected province
            If Not String.IsNullOrEmpty(province) Then
                cboProvince.SelectedItem = province
                ' After setting the province, populate the municipalities
                PopulateMunicipalities(province)
            End If

            ' Select the municipality from the populated list
            Me.cboMunicipality.Text = dgYouth.Item(11, i).Value?.ToString()

            Me.cboProvince.Text = dgYouth.Item(12, i).Value?.ToString()
            Me.cboRegion.Text = dgYouth.Item(13, i).Value?.ToString()

            ' Other Demographic Details
            Me.cboCivilStat.Text = dgYouth.Item(14, i).Value?.ToString()
            Me.cboAgeGroup.Text = dgYouth.Item(15, i).Value?.ToString()
            Me.cboClassification.Text = dgYouth.Item(16, i).Value?.ToString()
            Me.cboEducationAttain.Text = dgYouth.Item(17, i).Value?.ToString()
            Me.cboWorkStat.Text = dgYouth.Item(18, i).Value?.ToString()
            Me.cboVoter.Text = dgYouth.Item(19, i).Value?.ToString()
            Me.cboAttend.Text = dgYouth.Item(20, i).Value?.ToString()
            Me.cboIsAttend.Text = dgYouth.Item(21, i).Value?.ToString()
            Me.cboNotAttend.Text = dgYouth.Item(22, i).Value?.ToString()

            ' Image Path
            Me.txtPath.Text = dgYouth.Item(23, i).Value?.ToString()
            If Not String.IsNullOrEmpty(Me.txtPath.Text) Then
                IconPicBox.ImageLocation = Replace(Me.txtPath.Text, ";", "/")
            Else
                IconPicBox.ImageLocation = "D:\YouthProfiling\KKYouthProfiling\KKYouthProfiling\Resources\Default.png"
            End If

            ' Enable/Disable Buttons
            IconBtnAdd.Enabled = False
            IconBtnEdit.Enabled = True
            IconBtnClear.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub IconBtnEdit_Click(sender As Object, e As EventArgs) Handles IconBtnEdit.Click
        If txtYouthID.Text = "" Then
            MsgBox("Select Employee in table row!", MsgBoxStyle.Critical, "Required")
            gbDemographic.Enabled = False
            gbProfile.Enabled = False
            IconBtnSave.Enabled = False
            IconBtnSave.Visible = False

            IconBtnUpload.Enabled = False
            IconBtnClear.Enabled = False
            IconBtnClear.Visible = False
        Else

            gbDemographic.Enabled = True
            gbProfile.Enabled = True

            IconBtnEdit.Enabled = False
            IconBtnEdit.Visible = False
            IconBtnAdd.Visible = False

            IconBtnSave.Text = "Update"
            IconBtnSave.Enabled = True
            IconBtnSave.Visible = True
            IconBtnUpload.Enabled = True

            IconBtnClear.Enabled = True
            IconBtnClear.Visible = True


        End If
    End Sub

    Private Sub cboProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvince.SelectedIndexChanged
        Try
            ' Clear the previous municipality list
            cboMunicipality.Items.Clear()

            Select Case cboProvince.SelectedItem
                Case "Albay"
                    SelectMunicipalitiesAlbay()
                Case "Camarines Norte"
                    SelectMunicipalitiesCamarinesNorte()
                Case "Camarines Sur"
                    SelectMunicipalitiesCamarinesSur()
                Case "Catanduanes"
                    SelectMunicipalitiesCatanduanes()
                Case "Masbate"
                    SelectMunicipalitiesMasbate()
                Case "Sorsogon"
                    SelectMunicipalitiesSorsogon()

            End Select
        Catch ex As Exception
            ' Handle any error that occurs during the method execution
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub

    Private Sub cboPurok_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPurok.SelectedIndexChanged

    End Sub
End Class