
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class FrmLogin
    ' Key and IV for AES encryption/decryption
    Private ReadOnly aesKey As Byte() = Encoding.UTF8.GetBytes("1234567890123456") ' 16 bytes key
    Private ReadOnly aesIV As Byte() = Encoding.UTF8.GetBytes("1234567890123456") ' 16 bytes IV

    ' Function to encrypt a password using AES
    Private Function EncryptPassword(ByVal plainText As String) As String
        Dim encrypted As Byte()

        Using aesAlg As Aes = Aes.Create()
            aesAlg.Key = aesKey
            aesAlg.IV = aesIV

            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)

            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As New StreamWriter(csEncrypt)
                        swEncrypt.Write(plainText)
                    End Using
                    encrypted = msEncrypt.ToArray()
                End Using
            End Using
        End Using

        Return Convert.ToBase64String(encrypted)
    End Function


    Private Sub IconSeePass_Click(sender As Object, e As EventArgs) Handles IconSeePass.Click
        If txtPassword.UseSystemPasswordChar Then
            ' Set the password to be visible
            txtPassword.UseSystemPasswordChar = False

        Else
            ' Set the password to be hidden
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub IconBtnLogin_Click(sender As Object, e As EventArgs) Handles IconBtnLogin.Click
        Try
            Static Dim counter As Integer

            If txtUsername.Text = "" Then
                MsgBox("Enter username.", MsgBoxStyle.Critical, "Required")
                txtUsername.BackColor = Color.LightCoral
                txtUsername.Select()

                Exit Sub

                txtUsername.BackColor = SystemColors.Window
                txtPassword.BackColor = SystemColors.Window
            ElseIf txtPassword.Text = "" Then
                MsgBox("Enter password.", MsgBoxStyle.Critical, "Required")
                txtPassword.BackColor = Color.LightCoral
                txtPassword.Select()
                Exit Sub

            Else
                counter += 1

                ' Encrypt the entered password
                Dim encryptedPassword As String = EncryptPassword(txtPassword.Text)

                MyCOn.Open()
                MyCommand.Connection = MyCOn
                MyCommand.Parameters.Clear()

                ' Query to check username and encrypted password with case sensitivity
                'Binary will check if the username is CAPSLOCK and your username is lower then it will 
                MyCommand.CommandText = "SELECT ADMIN_ID, USERNAME FROM admin WHERE BINARY USERNAME=@username AND BINARY PASSWORD=@password"
                MyCommand.Parameters.AddWithValue("@username", txtUsername.Text)
                MyCommand.Parameters.AddWithValue("@password", encryptedPassword)

                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader()

                If Not MySQLData.HasRows Then
                    If counter = 5 Then
                        MessageBox.Show("You have reached your maximum login attempts. The program will now end.", "Error Login!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Application.Exit()
                    End If
                    MessageBox.Show("Invalid Username or Password!", "Error message.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtUsername.Select()
                    MyCOn.Close()
                    Exit Sub
                Else
                    ' Successful login
                    MySQLData.Read()
                    DBConnect.AdminID = MySQLData("ADMIN_ID").ToString() ' Set the global AdminID

                    MsgBox("You have successfully logged in.", MsgBoxStyle.Information, "Success")
                    Dim frm = New FrmDashboard()
                    frm.Show()
                    Me.Close()
                End If

                MyCOn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If MyCOn.State = ConnectionState.Open Then
                MyCOn.Close()
            End If
        End Try

    End Sub

    Private Sub IconButtonExit_Click(sender As Object, e As EventArgs) Handles IconButtonExit.Click
        'Once the button click program will exit
        Application.Exit()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        txtUsername.BackColor = Color.White
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.BackColor = Color.White
    End Sub
End Class