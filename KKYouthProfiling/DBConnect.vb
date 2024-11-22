
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports FontAwesome.Sharp

Module DBConnect
    Public newrecord As Boolean
    Public cmd As New MySqlCommand
    Public MyAdapter As New MySqlDataAdapter
    Public dt As New DataTable
    Public num As Integer
    Public MyCommand As New MySqlCommand
    Public MyCOn As MySqlConnection = New MySqlConnection("server=localhost; database=kkprofiling_db;uid=root;password=Nicolas051002;")
    Public Property AdminID As String




    'GET ADMIN USERNAME AND FIRSTNAME 

    Public Function GetAdminFullName(ByVal adminID As String) As String
        Dim firstName As String = String.Empty
        Dim lastName As String = String.Empty
        Try
            If (MyCOn.State = ConnectionState.Open) Then
                MyCOn.Close()
            End If
            MyCOn.Open()
            MyCommand.Connection = MyCOn
            MyCommand.Parameters.Clear()

            ' Query to get admin's first and last name
            MyCommand.CommandText = "SELECT FIRSTNAME, LASTNAME FROM admin WHERE ADMIN_ID=@adminID"
            MyCommand.Parameters.AddWithValue("@adminID", adminID)

            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader()

            If MySQLData.Read() Then
                firstName = MySQLData("FIRSTNAME").ToString()
                lastName = MySQLData("LASTNAME").ToString()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If MyCOn.State = ConnectionState.Open Then
                MyCOn.Close()
            End If
        End Try

        ' Convert first and last names to proper case (first letter uppercase, rest lowercase)
        firstName = StrConv(firstName, VbStrConv.ProperCase)
        lastName = StrConv(lastName, VbStrConv.ProperCase)
        ' Return concatenated full name
        Return firstName & " " & lastName
    End Function




    'INSERT AND UPDATE BUTTON
    Public Sub ExecInsertButton(ByVal query As String)
        Try
            If (MyCOn.State = ConnectionState.Open) Then
                MyCOn.Close()
            End If
            MyCOn.Open()
            MyCommand.Connection = MyCOn
            MyCommand.CommandText = query
            MyCommand.ExecuteNonQuery()
            MyCOn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'GETTING THE MAX OF NUMBER OF YOUTH

    Public Function getMaxNumberYouth()
        Dim num As Integer = 0
        Try
            ' Ensure connection is closed before opening
            If (MyCOn.State = ConnectionState.Open) Then
                MyCOn.Close()
            End If

            ' Open connection and execute query
            MyCOn.Open()
            MyCommand.Connection = MyCOn
            MyCommand.CommandText = "SELECT COALESCE(MAX(YOUTH_NUM), 0) AS MAX_NUM FROM YOUTH_DETAILS"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader

            ' Read the maximum admin number
            If MySQLData.Read() Then
                num = Convert.ToInt32(MySQLData("MAX_NUM"))
            End If

        Catch ex As Exception
            ' Show error message in case of exception
            MsgBox(ex.Message)

        Finally
            ' Ensure the connection is closed
            If MyCOn.State = ConnectionState.Open Then
                MyCOn.Close()
            End If
        End Try

        ' Return the maximum admin number
        Return num
    End Function
    'GETTING THE MAX OF NUMBER OF ADMIN
    Public Function getMaxNumberAdmin() As Integer
        Dim num As Integer = 0
        Try
            ' Ensure connection is closed before opening
            If (MyCOn.State = ConnectionState.Open) Then
                MyCOn.Close()
            End If

            ' Open connection and execute query
            MyCOn.Open()
            MyCommand.Connection = MyCOn
            MyCommand.CommandText = "SELECT COALESCE(MAX(ADMIN_NUM), 0) AS MAX_NUM FROM ADMIN"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader

            ' Read the maximum admin number
            If MySQLData.Read() Then
                num = Convert.ToInt32(MySQLData("MAX_NUM"))
            End If

        Catch ex As Exception
            ' Show error message in case of exception
            MsgBox(ex.Message)

        Finally
            ' Ensure the connection is closed
            If MyCOn.State = ConnectionState.Open Then
                MyCOn.Close()
            End If
        End Try

        ' Return the maximum admin number
        Return num
    End Function


    Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function 'GetMd5Hash

    ' Key and IV for AES encryption/decryption
    Public ReadOnly aesKey As Byte() = Encoding.UTF8.GetBytes("1234567890123456") ' 16 bytes key
    Public ReadOnly aesIV As Byte() = Encoding.UTF8.GetBytes("1234567890123456") ' 16 bytes IV

    ' Function to encrypt a password using AES
    Public Function EncryptPassword(ByVal plainText As String) As String
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

    ' Function to decrypt a password using AES
    Public Function DecryptPassword(ByVal cipherText As String) As String
        Dim plainText As String = Nothing
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)

        Using aesAlg As Aes = Aes.Create()
            aesAlg.Key = aesKey
            aesAlg.IV = aesIV

            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)

            Using msDecrypt As New MemoryStream(cipherBytes)
                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                    Using srDecrypt As New StreamReader(csDecrypt)
                        plainText = srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using

        Return plainText
    End Function



End Module
