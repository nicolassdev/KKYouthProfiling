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
End Class
