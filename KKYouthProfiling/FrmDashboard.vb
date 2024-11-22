Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class FrmDashboard
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(4, 60)
        PanelDash.Controls.Add(leftBorderBtn)

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea


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

            ''current level title
            lblFormTitle.Text = currentBtn.Text
        End If
    End Sub

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
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub


    Public Sub ActiveButton(senderBtn As Object, customColor As Color)
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


        End If
    End Sub

    Public Sub OpenChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        'END
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
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

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Tomato
        lblFormTitle.Text = "Home"
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New FrmAnalysis)
    End Sub

    Private Sub btnYouth_Click(sender As Object, e As EventArgs) Handles btnYouth.Click
        ActiveButton(sender, RGBColors.color2)
        OpenChildForm(New FrmYouth)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ActiveButton(sender, RGBColors.color3)
        OpenChildForm(New FrmYouthProfile)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ActiveButton(sender, RGBColors.color4)
        OpenChildForm(New FrmReport)
    End Sub
    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        ActiveButton(sender, RGBColors.color4)
        OpenChildForm(New FrmSecurityAdmin)

    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Activelogout(sender, RGBColors.color5)
        DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = DialogResult.Yes Then
            FrmLogin.Show()
            FrmAdminProfile.Close()
            Me.Close()
        Else
            DisableButton()
            'current Form icon
            'Reset()
            Me.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        ' Implement your logout logic here
        ' MessageBox.Show("Session timed out. You will be logged out.")
        MessageBox.Show("Session timed out. You will be logged out.", "Session time out", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ' Redirect to the login form or close the application
        DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = DialogResult.Yes Or DialogResult.No Then
            FrmLogin.Show()
            FrmAdminProfile.Close()
            FrmSecurityAdmin.Close()

            Me.Close() ' Or redirect to the login form

        End If
    End Sub

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Retrieve the admin's first name using the stored admin ID
        Dim adminfullFirstName As String = GetAdminFullName(DBConnect.AdminID)
        LblUser.Text = "Logged in as: " & adminfullFirstName



        'Date and Time Activation
        DateAndTime.Enabled = True
        'Automatic logout session 
        Timer1.Stop()
        Timer1.Start()

        'hide hover admin 
        PanelAdminProfile.Visible = False
    End Sub



    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub


    Private Sub DateAndTime_Tick(sender As Object, e As EventArgs) Handles DateAndTime.Tick
        lblDate.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub



    Private Sub btnSetting_MouseHover(sender As Object, e As EventArgs) Handles btnSetting.MouseHover
        PanelAdminProfile.Visible = True
    End Sub

    Private Sub btnSetting_MouseLeave(sender As Object, e As EventArgs) Handles btnSetting.MouseLeave
        PanelAdminProfile.Visible = False
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal iParam As Integer)
    End Sub

    Private Sub PanelNavbar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelNavbar.MouseDown
        ReleaseCapture()
        SendMessage(Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FrmDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub IconBtnMaximize_Click(sender As Object, e As EventArgs) Handles IconBtnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub IconBtnMinimize_Click(sender As Object, e As EventArgs) Handles IconBtnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub


End Class
