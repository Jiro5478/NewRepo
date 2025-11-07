
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint

    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "server=localhost;database=dbComputerStudies;user=root;password=;"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query to check credentials
                Dim query As String = "SELECT * FROM tbl_Users WHERE studentId = @username AND password = @password LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Me.Hide()

                            ' Determine role based on username format
                            Dim role As String
                            If Regex.IsMatch(username, "^\d{3}$") Then
                                ' 3-digit number → faculty
                                role = "faculty"
                            ElseIf Regex.IsMatch(username, "^\d{8}-[NCMSE]$") Then
                                ' 8 digits + dash + letter → student
                                role = "student"
                            Else
                                MessageBox.Show("Invalid username format.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If

                            ' Open the correct dashboard
                            If role = "faculty" Then
                                Dim facultyForm As New DashboardForm()
                                facultyForm.Show()
                            Else
                                Dim studentForm As New StudentDashboard()
                                studentForm.Show()
                            End If
                        Else
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If False Then
                Return
            End If
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub
End Class
