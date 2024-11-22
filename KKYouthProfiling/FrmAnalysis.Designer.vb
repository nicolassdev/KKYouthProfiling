<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnalysis))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        lblTotalYouth = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        lblTotalRegisteredVoter = New Label()
        Label4 = New Label()
        LblUser = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(lblTotalYouth)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(35, 35)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(526, 290)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 17)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(212, 205)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' lblTotalYouth
        ' 
        lblTotalYouth.AutoSize = True
        lblTotalYouth.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalYouth.ForeColor = Color.Gold
        lblTotalYouth.Location = New Point(386, 73)
        lblTotalYouth.Name = "lblTotalYouth"
        lblTotalYouth.Size = New Size(109, 128)
        lblTotalYouth.TabIndex = 0
        lblTotalYouth.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(293, 244)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 25)
        Label1.TabIndex = 0
        Label1.Text = "Total number of youth."
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(33), CByte(37), CByte(41))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(lblTotalRegisteredVoter)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(599, 35)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(527, 290)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(32, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(199, 205)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblTotalRegisteredVoter
        ' 
        lblTotalRegisteredVoter.AutoSize = True
        lblTotalRegisteredVoter.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalRegisteredVoter.ForeColor = Color.Gold
        lblTotalRegisteredVoter.Location = New Point(390, 73)
        lblTotalRegisteredVoter.Name = "lblTotalRegisteredVoter"
        lblTotalRegisteredVoter.Size = New Size(109, 128)
        lblTotalRegisteredVoter.TabIndex = 0
        lblTotalRegisteredVoter.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(169, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(348, 25)
        Label4.TabIndex = 0
        Label4.Text = "Total number of registered youth voters."
        ' 
        ' LblUser
        ' 
        LblUser.AutoSize = True
        LblUser.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        LblUser.ForeColor = SystemColors.ButtonShadow
        LblUser.Location = New Point(35, 636)
        LblUser.Name = "LblUser"
        LblUser.Size = New Size(53, 20)
        LblUser.TabIndex = 1
        LblUser.Text = "Label2"
        ' 
        ' FrmAnalysis
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1150, 692)
        Controls.Add(LblUser)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FrmAnalysis"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalYouth As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalRegisteredVoter As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblUser As Label
End Class
