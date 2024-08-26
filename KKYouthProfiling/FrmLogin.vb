Public Class FrmLogin
    Private Sub IconSeePass_Click(sender As Object, e As EventArgs) Handles IconSeePass.Click
        If txtPassword.UseSystemPasswordChar Then
            ' Set the password to be visible
            txtPassword.UseSystemPasswordChar = False

        Else
            ' Set the password to be hidden
            txtPassword.UseSystemPasswordChar = True

        End If
    End Sub
End Class