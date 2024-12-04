
Imports System.Drawing.Printing
Public Class FrmYouthProfile
    Private Sub FrmYouthProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load youth data for each Purok dynamically
        For i As Integer = 1 To 9
            LoadYouthPurok(i)
        Next

        ' Set tab names dynamically
        For i As Integer = 1 To 9
            TabControl1.TabPages("TabPage" & i).Text = "Purok " & i
        Next


        ' Apply styles to the TabControl
        StyleTabControl(TabControl1)
        StyleDownloadButton(btnDownload)
        StyleDownloadButton(btnDownload2)
        'StyleDownloadButton(btnDownload3)
        'StyleDownloadButton(btnDownload4)
        'StyleDownloadButton(btnDownload5)
        'StyleDownloadButton(btnDownload6)

        'StyleDownloadButton(btnDownload7)
    End Sub


    Private Sub StyleTabControl(tabControl As TabControl)
        ' Set background color
        tabControl.BackColor = Color.FromArgb(240, 240, 240) ' Light gray

        ' Set font styles
        tabControl.Font = New Font("Segoe UI", 8, FontStyle.Regular)

        ' Add tab tooltips
        For i As Integer = 1 To tabControl.TabPages.Count
            tabControl.TabPages(i - 1).ToolTipText = "View data for Purok " & i
        Next

        ' Set tab appearance
        tabControl.DrawMode = TabDrawMode.OwnerDrawFixed
        AddHandler tabControl.DrawItem, AddressOf TabControl_DrawItem
    End Sub
    Private Sub TabControl_DrawItem(sender As Object, e As DrawItemEventArgs)
        Dim tabControl As TabControl = CType(sender, TabControl)
        Dim g As Graphics = e.Graphics
        Dim tabRect As Rectangle = tabControl.GetTabRect(e.Index)

        ' Set colors for active and inactive tabs
        Dim activeColor As Color = Color.FromArgb(102, 153, 255) ' Light blue
        Dim inactiveColor As Color = Color.FromArgb(200, 200, 200) ' Gray
        Dim textColor As Color = Color.Black

        ' Determine if the tab is active
        If tabControl.SelectedIndex = e.Index Then
            g.FillRectangle(New SolidBrush(activeColor), tabRect)
        Else
            g.FillRectangle(New SolidBrush(inactiveColor), tabRect)
        End If

        ' Draw tab text
        Dim tabText As String = tabControl.TabPages(e.Index).Text
        Dim textFont As Font = New Font("Segoe UI", 8, FontStyle.Bold)
        Dim textBrush As New SolidBrush(textColor)

        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        g.DrawString(tabText, textFont, textBrush, tabRect, stringFormat)
    End Sub



    ' Generic method to load youth data based on Purok number
    Private Sub LoadYouthPurok(purokNumber As Integer)
        Try
            If MyCOn.State = ConnectionState.Open Then MyCOn.Close()
            MyCOn.Open()

            dt = New DataTable
            Dim query As String = $"SELECT 
                      yd.REGION, 
                      yd.PROVINCE, 
                      yd.MUNICIPALITY, 
                      yd.BARANGAY, 
                      CONCAT(yd.LASTNAME, '  ', 
                      UPPER(SUBSTRING(yd.FIRSTNAME, 1, 1)), LOWER(SUBSTRING(yd.FIRSTNAME, 2)), '  ', 
                      UPPER(SUBSTRING(yd.MIDDLENAME, 1, 1)), LOWER(SUBSTRING(yd.MIDDLENAME, 2))) AS 'FULL NAME',
                      yd.AGE, 
                      yd.DOB AS 'BIRTHDAY', 
                      yd.GENDER AS 'SEX',
                      dd.CIVIL_STATUS AS 'CIVIL STATUS', 
                      dd.CLASSIFICATION AS 'YOUTH CLASSIFICATION', 
                      dd.AGE_GROUP AS 'YOUTH AGE GROUP', 
                      yd.EMAIL, 
                      yd.CONTACT, 
                      dd.EDUC_ATTAINMENT AS 'HIGHEST EDUCATIONAL ATTAINMENT', 
                      dd.WORK_STATUS AS 'WORK STATUS', 
                      dd.VOTER AS 'REGISTER VOTER?', 
                      dd.ATTEND_KK_ASSEMBLY AS 'ATTENDED A KK ASSEMBLY MEETING?', 
                      dd.IS_ATTENDED AS 'HOW MANY TIMES?', 
                      dd.NOT_ATTENDED AS 'WHY?'
                  FROM 
                      youth_details yd
                  INNER JOIN 
                      demographic_details dd 
                      ON yd.YOUTH_ID = dd.YOUTH_ID
                  WHERE 
                      yd.PUROK = 'PUROK-{purokNumber}';"

            With MyCommand
                .Connection = MyCOn
                .CommandText = query
            End With

            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)

            ' Dynamically set the DataGridView based on Purok number
            Dim dgv As DataGridView = CType(Me.Controls.Find("dgYouthP" & purokNumber, True).FirstOrDefault(), DataGridView)
            If dgv IsNot Nothing Then
                dgv.DataSource = dt
                dgv.RowHeadersVisible = False
            End If

            MyCOn.Close()
            MyCommand.Dispose()
        Catch ex As Exception
            MsgBox($"Error loading data for Purok {purokNumber}: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Try
            ' Initialize SaveFileDialog
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv"
            saveFileDialog.Title = "Save DataGridView as CSV"
            saveFileDialog.FileName = "SKBYouthProfile_PUROK1.csv"

            ' Check if the user selects a file
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New System.IO.StreamWriter(saveFileDialog.FileName)
                    ' Write headers
                    Dim headers = dgYouthP1.Columns.Cast(Of DataGridViewColumn)().[Select](Function(c) c.HeaderText)
                    writer.WriteLine(String.Join(",", headers))

                    ' Write rows
                    For Each row As DataGridViewRow In dgYouthP1.Rows
                        If Not row.IsNewRow Then
                            Dim cells = row.Cells.Cast(Of DataGridViewCell)().[Select](Function(c) c.Value?.ToString())
                            writer.WriteLine(String.Join(",", cells))
                        End If
                    Next
                End Using
                MessageBox.Show("Data successfully exported to CSV.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StyleDownloadButton(button As Button)
        ' Set basic properties for the button
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = Color.FromArgb(102, 153, 255) ' Light blue background
        button.ForeColor = Color.White ' White text
        button.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        button.Text = "Download Data"
        button.TextAlign = ContentAlignment.MiddleCenter
        button.Cursor = Cursors.Hand

        ' Add hover effect
        AddHandler button.MouseEnter, Sub(sender, e)
                                          button.BackColor = Color.FromArgb(51, 102, 204) ' Darker blue on hover
                                      End Sub
        AddHandler button.MouseLeave, Sub(sender, e)
                                          button.BackColor = Color.FromArgb(102, 153, 255) ' Revert to original color
                                      End Sub

        ' Add click animation (optional)
        AddHandler button.MouseDown, Sub(sender, e)
                                         button.BackColor = Color.FromArgb(0, 102, 204) ' Even darker blue on click
                                     End Sub
        AddHandler button.MouseUp, Sub(sender, e)
                                       button.BackColor = Color.FromArgb(51, 102, 204) ' Revert to hover color
                                   End Sub
    End Sub

End Class
