Imports MySql.Data.MySqlClient

Public Class DatabaseFunctions
    Private ReadOnly connectionString As String = "server=localhost;database=dbComputerStudies;user=root;password=;"

    ' Function to get a reusable MySQL connection
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    ' Function to test the database connection
    Public Sub TestConnection()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                MessageBox.Show("✅ Connection to dbComputerStudies successful!", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
