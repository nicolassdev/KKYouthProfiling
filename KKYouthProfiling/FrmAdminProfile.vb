Imports System.Runtime.Versioning
Imports System.Xml
Imports FontAwesome.Sharp
Imports KKYouthProfiling.My.Resources
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Tracing
Imports System.Drawing
Imports System.Windows.Media
Public Class FrmAdminProfile


    Public maxNumber As Integer
    Private EmailValid As Boolean
    Private idnum As String
    Sub getAdminID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim AdminID As String
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxNumber = Convert.ToInt32(getMaxNumberAdmin()) '3
        idnum = maxNumber + 1 '1 + 1 idnum=4
        AdminID = "ADMIN-" & Year & "-" & idnum 'EMP-2023-4
        txtID.Text = AdminID
    End Sub


    'Custom form load design
    Private Sub CustomizeDataGridView()
        ' Set DataGridView background color
        dgAdmin.BackgroundColor = System.Drawing.Color.FromArgb(33, 37, 41)

        ' Set alternating row background colors
        dgAdmin.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 48, 52)
        dgAdmin.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 55, 60)

        ' Set font and foreground color (text color)
        dgAdmin.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgAdmin.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.White

        ' Remove gridlines for a cleaner look
        dgAdmin.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgAdmin.GridColor = System.Drawing.Color.FromArgb(44, 48, 52)

        ' Header styling
        dgAdmin.EnableHeadersVisualStyles = False
        dgAdmin.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(77, 82, 87)
        dgAdmin.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgAdmin.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgAdmin.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Row height and border styling
        dgAdmin.RowTemplate.Height = 30
        dgAdmin.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(90, 90, 90)
        dgAdmin.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White

        ' Border style and padding
        dgAdmin.BorderStyle = BorderStyle.None
        dgAdmin.DefaultCellStyle.Padding = New Padding(5)

        ' Make sure the DataGridView fits well into the form
        dgAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub





    'SHOW DATA OF ADMIN AND RELOAD
    Sub LoadgridAdminInfo()

        Try
            If (MyCOn.State = ConnectionState.Open) Then MyCOn.Close()
            MyCOn.Open()
            dt = New DataTable

            With MyCommand
                .Connection = MyCOn
                .CommandText = "Select ADMIN_ID as 'ADMIN ID',FIRSTNAME as 'FIRST NAME', LASTNAME as 'LAST NAME',ADDRESS as 'ADDRESS', CONTACT as 'CONTACT',ROLE as'ROLE', USERNAME , PASSWORD, PICTURE FROM admin  "
            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            dgAdmin.DataSource = dt
            dgAdmin.RowHeadersVisible = False
            MyCOn.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DisableBtn()
        gbFrmAdmin.Enabled = False
        IconBtnSave.Enabled = False
        IconBtnClear.Enabled = False
        IconBtnUpload.Enabled = False
        'IconBtnEdit.Enabled = False
    End Sub



    Private Sub FrmAdminProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IconPicBx.ImageLocation = "D:\YouthProfiling\KKYouthProfiling\KKYouthProfiling\Resources\Default.png"

        LoadgridAdminInfo()
        DisableBtn()

        'ComboBox
        cboRole.Items.Add("SK KAGAWAD")
        cboRole.Items.Add("SK CHAIRPERSON")
        cboRole.Items.Add("BHW")

        'true   
        IconBtnAdd.Enabled = True
        IconBtnEdit.Enabled = True

        Me.dgAdmin.Columns(6).Visible = False
        Me.dgAdmin.Columns(7).Visible = False
        Me.dgAdmin.Columns(8).Visible = False

        'hide label
        LblBack.Visible = False

        ' Apply custom styles to the DataGridView
        CustomizeDataGridView()

        txtPath.Visible = False
        IconBtnChangePass.Visible = False

    End Sub

    Private Sub IconBtnAdd_Click(sender As Object, e As EventArgs) Handles IconBtnAdd.Click
        'GETTING THE ID
        getAdminID()

        IconBtnAdd.Enabled = False
        IconBtnEdit.Enabled = False
        IconBtnChangePass.Enabled = False

        gbFrmAdmin.Enabled = True
        IconBtnSave.Enabled = True
        IconBtnClear.Enabled = True
        IconBtnUpload.Enabled = True
        txtPassword.Enabled = True
        'unable click row table
        dgAdmin.Enabled = False

    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles BtnClose.MouseHover
        LblBack.Visible = True
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        LblBack.Visible = False
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
                    IconPicBx.ImageLocation = OpenFileDialog1.FileName
                    txtPath.Text = Replace(OpenFileDialog1.FileName, "\", ";")
                End If
            End If
        Catch ex As Exception
            ' Handle any exceptions that occur
            MessageBox.Show("An error occurred while selecting the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub IconBtnClear_Click(sender As Object, e As EventArgs) Handles IconBtnClear.Click
        ' Clear text fields
        ClearText()

        ' Disable certain buttons and controls
        DisableBtn()



        ' Enable the Add button
        IconBtnAdd.Enabled = True
        IconBtnEdit.Enabled = True
        dgAdmin.Enabled = True


        'Reset txt
        IconBtnSave.Text = "Save"

        ' Reset the background color of input fields
        txtFname.BackColor = SystemColors.Window
        txtLname.BackColor = SystemColors.Window
        txtContact.BackColor = SystemColors.Window
        txtUsername.BackColor = SystemColors.Window
        txtPassword.BackColor = SystemColors.Window
        richtxtboxAddress.BackColor = SystemColors.Window
        cboRole.BackColor = SystemColors.Window

    End Sub
    'INSERT and UPDATE ADMIN
    Private Sub IconBtnSave_Click(sender As Object, e As EventArgs) Handles IconBtnSave.Click
        ' Validate input fields in a loop to minimize repetitive code
        Dim fields As TextBox() = {txtFname, txtLname, txtContact, txtUsername, txtPassword, txtPath}
        For Each field In fields
            If field.Text = "" Then
                MsgBox(field.Name.Replace("txt", "") & " is required!", MsgBoxStyle.Exclamation, "Required")
                field.BackColor = System.Drawing.Color.FromArgb(240, 240, 20)
                field.Focus()
                Exit Sub
            End If
        Next

        If richtxtboxAddress.Text = "" Then
            MsgBox("Address is required!", MsgBoxStyle.Exclamation, "Required")
            richtxtboxAddress.BackColor = System.Drawing.Color.FromArgb(240, 240, 20)
            richtxtboxAddress.Focus()
            Exit Sub
        End If

        If cboRole.Text = "" Then
            MsgBox("Role is required!", MsgBoxStyle.Exclamation, "Required")
            cboRole.BackColor = System.Drawing.Color.FromArgb(240, 240, 20)
            cboRole.Focus()
            Exit Sub
        End If

        ' Validate the path and image location
        If txtPath.Text = "" Or IconPicBx.ImageLocation = Nothing Then
            MsgBox("Image is required!", MsgBoxStyle.Exclamation, "Required")
            txtPath.Focus()
            Exit Sub
        End If
        ' If the image is valid, proceed with further actions
        Try

            If MyCOn.State = ConnectionState.Closed Then MyCOn.Open()

            ' Insert or update the Admin record
            If IconBtnSave.Text = "Update" Then
                ' Update the admin record
                Dim getPasswordQuery As String = "SELECT PASSWORD FROM ADMIN WHERE ADMIN_ID = @AdminID"
                Dim existingEncryptedPassword As String = ""

                Using getPwdCmd As New MySqlCommand(getPasswordQuery, MyCOn)
                    getPwdCmd.Parameters.AddWithValue("@AdminID", txtID.Text)
                    existingEncryptedPassword = Convert.ToString(getPwdCmd.ExecuteScalar())
                End Using

                Dim existingDecryptedPassword As String = DecryptPassword(existingEncryptedPassword)
                Dim updateQuery As String = "UPDATE ADMIN SET FIRSTNAME = @FirstName, LASTNAME = @LastName, ADDRESS = @Address, CONTACT = @Contact, ROLE = @Role, USERNAME = @Username"

                If Not String.IsNullOrEmpty(txtPassword.Text) AndAlso txtPassword.Text <> existingDecryptedPassword Then
                    updateQuery &= ", PASSWORD = @Password"
                End If

                updateQuery &= ", PICTURE = @Picture WHERE ADMIN_ID = @AdminID"

                Using cmd As New MySqlCommand(updateQuery, MyCOn)
                    cmd.Parameters.AddWithValue("@FirstName", txtFname.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@LastName", txtLname.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Address", richtxtboxAddress.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Role", cboRole.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Picture", txtPath.Text)
                    cmd.Parameters.AddWithValue("@AdminID", txtID.Text)

                    If Not String.IsNullOrEmpty(txtPassword.Text) AndAlso txtPassword.Text <> existingDecryptedPassword Then
                        cmd.Parameters.AddWithValue("@Password", EncryptPassword(txtPassword.Text))
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearText()
                IconBtnAdd.Enabled = True
                DisableBtn()
                LoadgridAdminInfo()
                IconBtnSave.Text = "Save"
                dgAdmin.Enabled = True

            Else
                'INSERT QUERY

                ' Check if FirstName, LastName, or Username already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM ADMIN WHERE FIRSTNAME = @FirstName AND LASTNAME = @LastName OR USERNAME = @Username"
                Dim exists As Integer = 0

                If Not txtContact.Text.StartsWith("+63") Then
                    txtContact.Text = "+63" & txtContact.Text
                End If

                ' Check for duplicate entries
                Using checkCmd As New MySqlCommand(checkQuery, MyCOn)
                    checkCmd.Parameters.AddWithValue("@FirstName", txtFname.Text.ToUpper)
                    checkCmd.Parameters.AddWithValue("@LastName", txtLname.Text.ToUpper)
                    checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text.ToUpper)
                    exists = Convert.ToInt32(checkCmd.ExecuteScalar())
                End Using

                ' If a duplicate exists, show a message and exit
                If exists > 0 Then
                    MsgBox("First Name and Last Name combination or Username is already taken!", MsgBoxStyle.Exclamation, "Duplicate Entry")
                    Exit Sub
                End If

                ' Insert a new admin record
                Dim query As String = "INSERT INTO ADMIN(ADMIN_ID, FIRSTNAME, LASTNAME, ADDRESS, CONTACT, ROLE, USERNAME, PASSWORD, PICTURE, CREATED_DATE) " &
                                          "VALUES(@AdminID, @FirstName, @LastName, @Address, @Contact, @Role, @Username, @Password, @Picture, NOW());"

                Using cmd As New MySqlCommand(query, MyCOn)
                    cmd.Parameters.AddWithValue("@AdminID", txtID.Text)
                    cmd.Parameters.AddWithValue("@FirstName", txtFname.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@LastName", txtLname.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Address", richtxtboxAddress.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Role", cboRole.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", EncryptPassword(txtPassword.Text)) ' Encrypt password
                    cmd.Parameters.AddWithValue("@Picture", txtPath.Text)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearText()
                    IconBtnAdd.Enabled = True
                    DisableBtn()
                    LoadgridAdminInfo()
                    dgAdmin.Enabled = True
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If MyCOn.State = ConnectionState.Open Then MyCOn.Close()
            End Try

    End Sub


    Private Sub ClearText()
        txtID.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        richtxtboxAddress.Text = ""
        cboRole.Text = ""
        txtContact.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtPath.Text = Nothing
        IconPicBx.Image = Nothing
        IconPicBx.ImageLocation = "D:\YouthProfiling\KKYouthProfiling\KKYouthProfiling\Resources\Default.png"

        'Hide change pass button
        IconBtnChangePass.Visible = False

    End Sub

    Private Sub dgAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAdmin.CellClick
        Try
            Dim i As Integer
            i = dgAdmin.CurrentRow.Index
            Me.txtID.Text = dgAdmin.Item(0, i).Value
            Me.txtFname.Text = dgAdmin.Item(1, i).Value
            Me.txtLname.Text = dgAdmin.Item(2, i).Value
            Me.richtxtboxAddress.Text = dgAdmin.Item(3, i).Value

            ' Add +63 prefix to contact number
            Dim contactNumber As String = dgAdmin.Item(4, i).Value.ToString()
            If Not contactNumber.StartsWith("+63") Then
                Me.txtContact.Text = "+63" & contactNumber
            Else
                Me.txtContact.Text = contactNumber
            End If

            Me.cboRole.Text = dgAdmin.Item(5, i).Value
            Me.txtUsername.Text = dgAdmin.Item(6, i).Value
            ' Retrieve and decrypt the password
            Dim encryptedPassword As String = dgAdmin.Item(7, i).Value.ToString()
            Me.txtPassword.Text = DecryptPassword(encryptedPassword)  ' Decrypting the password

            Me.txtPath.Text = dgAdmin.Item(8, i).Value

            IconPicBx.ImageLocation = Replace(txtPath.Text, ";", "/")
            IconBtnAdd.Enabled = False
            IconBtnEdit.Enabled = True
            IconBtnClear.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPath_TextChanged(sender As Object, e As EventArgs) Handles txtPath.TextChanged
        txtPath.Text = (Replace(txtPath.Text, "\", ";"))
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If (MyCOn.State = ConnectionState.Open) Then
                MyCOn.Close()
            End If
            dgAdmin.Refresh()
            MyCOn.Open()
            MyCommand.Connection = MyCOn
            MyCommand.CommandText = "Select ADMIN_ID as 'ADMIN ID',FIRSTNAME as 'FIRST NAME', LASTNAME as 'LAST NAME',ADDRESS as 'ADDRESS', CONTACT as 'CONTACT',ROLE as'ROLE', USERNAME , PASSWORD, PICTURE FROM admin WHERE ADMIN_ID LIKE '" & txtSearch.Text & "%' OR  FIRSTNAME LIKE '" & txtSearch.Text & "%' OR LASTNAME LIKE '" & txtSearch.Text & "%' OR ADDRESS LIKE '" & txtSearch.Text & "%' OR CONTACT LIKE '" & txtSearch.Text & "%' OR ROLE LIKE '" & txtSearch.Text & "%' "
            MyAdapter.SelectCommand = MyCommand
            dt = New DataTable
            dt.Clear()
            MyAdapter.Fill(dt)
            dgAdmin.DataSource = dt

            MyCOn.Close()
        Catch ex As Exception

        End Try
    End Sub

    'VALIDATION
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

    Private Sub IconBtnEdit_Click(sender As Object, e As EventArgs) Handles IconBtnEdit.Click

        If txtID.Text = "" Then
            MsgBox("Select Employee in table row!", MsgBoxStyle.Critical, "Required")
            gbFrmAdmin.Enabled = False
            IconBtnSave.Enabled = False
            IconBtnUpload.Enabled = False
            IconBtnClear.Enabled = False
        Else
            IconBtnChangePass.Enabled = True
            IconBtnSave.Enabled = True
            IconBtnUpload.Enabled = True
            gbFrmAdmin.Enabled = True
            IconBtnClear.Enabled = True
            IconBtnEdit.Enabled = False
            'dgAdmin.Enabled = False
            IconBtnSave.Text = "Update"
            txtPassword.Enabled = False
            IconBtnChangePass.Visible = True

            'lockID()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        DialogResult = MessageBox.Show("Are you sure you want to go back in Dashboard?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = DialogResult.Yes Then
            Me.Close()
            'FrmDashboard.Show()
        End If
    End Sub

    Private Sub IconBtnChangePass_Click(sender As Object, e As EventArgs) Handles IconBtnChangePass.Click
        txtPassword.Enabled = True
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
End Class