Imports MySql.Data.MySqlClient ' Ensure you have the MySQL Connector for .NET installed

Public Class FrmAnalysis
    ' Define your connection string
    Private connectionString As String = "server=localhost; database=kkprofiling_db;uid=root;password=Nicolas051002;"

    Private Sub FrmAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Establish a connection
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query to count total youth
                Dim queryTotalYouth As String = "SELECT COUNT(*) AS TotalYouth FROM youth_details"
                Using cmdTotalYouth As New MySqlCommand(queryTotalYouth, conn)
                    Dim totalYouth As Integer = Convert.ToInt32(cmdTotalYouth.ExecuteScalar())
                    lblTotalYouth.Text = $"{totalYouth}"
                End Using

                ' Query to count registered voters
                Dim queryRegisteredVoters As String = "SELECT COUNT(*) AS RegisteredVoters FROM demographic_details WHERE VOTER = 'YES'"
                Using cmdRegisteredVoters As New MySqlCommand(queryRegisteredVoters, conn)
                    Dim registeredVoters As Integer = Convert.ToInt32(cmdRegisteredVoters.ExecuteScalar())
                    lblTotalRegisteredVoter.Text = $"{registeredVoters}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        ' Retrieve the admin's first name using the stored admin ID
        Dim adminfullFirstName As String = GetAdminFullName(DBConnect.AdminID)


        LblUser.Text = "Logged in as: " & adminfullFirstName
    End Sub



End Class
