Imports System.Security.Cryptography
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices


Public Class FrmSecurityAdmin
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Private Sub ActiveProfileAdmin(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(33, 37, 41)
            currentBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 37, 41)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor

            leftBorderBtn.BackColor = customColor

            'current Form icon
            'IconCurrentForm.IconChar = currentBtn.IconChar
            'IconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(33, 37, 41)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub


    Private Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        'END
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        FrmAdminProfile.Controls.Add(childForm)
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub








    Private Sub cleartxt()
        txtSecUsername.Clear()
        txtSecPassword.Clear()

    End Sub

    Private Sub IconBtnSecLogin_Click(sender As Object, e As EventArgs) Handles IconBtnSecLogin.Click

        Try
            Static Dim counter As Integer
            If (txtSecUsername.Text = "") Then
                MsgBox("Enter username.", MsgBoxStyle.Critical, "Required")
                txtSecUsername.BackColor = Color.FromArgb(240, 240, 20)
                txtSecUsername.Select()
                Exit Sub
                txtSecUsername.BackColor = SystemColors.Window
                txtSecPassword.BackColor = SystemColors.Window
            ElseIf (txtSecPassword.Text = "") Then
                MsgBox("Enter password.", MsgBoxStyle.Critical, "Required")
                txtSecPassword.BackColor = Color.FromArgb(240, 240, 20)
                txtSecPassword.Select()
                Exit Sub
            Else
                counter = counter + 1 '3

                MyCOn.Open()
                MyCommand.Connection = MyCOn
                MyCommand.CommandText = "SELECT * FROM security WHERE security_username='" & txtSecUsername.Text & "' AND security_password='" & txtSecPassword.Text & "'"
                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows = 0 Then '1

                    If counter = 5 Then
                        MessageBox.Show("You have reached your maximum login attempts.The program will now end.", "Error Login!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Application.Exit()
                    End If
                    MessageBox.Show("Invalid Username or Password!", "Error message.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSecUsername.Text = ""
                    txtSecPassword.Text = ""
                    MyCOn.Close()
                    Exit Sub


                Else
                    ' Successful login
                    MsgBox("You have successfully logged in admin control.", MsgBoxStyle.Information, "Success")

                    ' Hide the current form

                    FrmDashboard.Hide()
                    'OpenChildForm(New FrmAdminProfile)
                    'Show the admin profile form
                    FrmAdminProfile.Show()
                    cleartxt()
                    MyCOn.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If MyCOn.State = ConnectionState.Open Then
                MyCOn.Close()
            End If
        End Try
    End Sub
End Class