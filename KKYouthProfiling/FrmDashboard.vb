Imports FontAwesome.Sharp
Public Class FrmDashboard
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(4, 60)
        PanelDash.Controls.Add(leftBorderBtn)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Activelogout(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(33, 37, 41)
            currentBtn.FlatAppearance.BorderColor = Color.FromArgb(33, 37, 41)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)

            'current Form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor


            'current level title
            lblFormTitle.Text = currentBtn.Text

        End If
    End Sub


    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(33, 37, 41)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'left border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.BringToFront()
            'current Form icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

            'current level title
            lblFormTitle.Text = currentBtn.Text

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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActiveButton(sender, RGBColors.color1)
    End Sub

    Private Sub btnYouth_Click(sender As Object, e As EventArgs) Handles btnYouth.Click
        ActiveButton(sender, RGBColors.color2)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ActiveButton(sender, RGBColors.color3)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ActiveButton(sender, RGBColors.color4)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Activelogout(sender, RGBColors.color5)
        DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = DialogResult.Yes Then

            FrmLogin.Show()
            Me.Close()
        Else
            DisableButton()
            Me.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        ' Implement your logout logic here
        MessageBox.Show("Session timed out. You will be logged out.")
        ' Redirect to the login form or close the application
        DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = DialogResult.Yes Or DialogResult.No Then
            FrmLogin.Show()
            Me.Close() ' Or redirect to the login form

        End If
    End Sub

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Automatic logout session 
        Timer1.Stop()
        Timer1.Start()
    End Sub
End Class
