Imports MySql.Data.MySqlClient

Public Module SharedData
    Private ReadOnly connectionString As String = "server=localhost;database=dbComputerStudies;user=root;password=;"
    Public CurrentStudent As New Dictionary(Of String, String)

    ' 🧩 Function 1 — Load Student Personal Info
    Public Sub LoadStudentInfo(studentId As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim queryInfo As String = "SELECT studentId, FullName, YearSec, Program, Address, ContactNo, Email FROM tbl_Users WHERE studentId = @studentId LIMIT 1"
                Using cmdInfo As New MySqlCommand(queryInfo, conn)
                    cmdInfo.Parameters.AddWithValue("@studentId", studentId)
                    Using reader As MySqlDataReader = cmdInfo.ExecuteReader()
                        If reader.Read() Then
                            CurrentStudent.Clear()
                            CurrentStudent("studentId") = reader("studentId").ToString()
                            CurrentStudent("FullName") = reader("FullName").ToString()
                            CurrentStudent("YearSec") = reader("YearSec").ToString()
                            CurrentStudent("Program") = reader("Program").ToString()
                            CurrentStudent("Address") = reader("Address").ToString()
                            CurrentStudent("ContactNo") = reader("ContactNo").ToString()
                            CurrentStudent("Email") = reader("Email").ToString()
                        Else
                            MessageBox.Show("Student not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student info: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' 🧩 Function 2 — Load Student Courses
    Public Sub LoadStudentCourses(studentId As String, dgv As DataGridView)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim queryCourses As String = "SELECT course_code, course_name, time FROM tbl_Courses WHERE studentId = @studentId"
                Using cmdCourses As New MySqlCommand(queryCourses, conn)
                    cmdCourses.Parameters.AddWithValue("@studentId", studentId)
                    Using reader As MySqlDataReader = cmdCourses.ExecuteReader()
                        ' Clear DataGridView before loading
                        dgv.Rows.Clear()
                        dgv.Columns.Clear()

                        ' Set up columns if not already done
                        dgv.Columns.Add("course_code", "Course Code")
                        dgv.Columns.Add("course_name", "Course Name")
                        dgv.Columns.Add("time", "Time")

                        ' Store courses in a list
                        Dim courseList As New List(Of String)

                        ' Load all courses
                        While reader.Read()
                            Dim code = reader("course_code").ToString()
                            Dim name = reader("course_name").ToString()
                            Dim time = reader("time").ToString()

                            dgv.Rows.Add(code, name, time)
                            courseList.Add(code)
                        End While

                        ' Save courses in CurrentStudent dictionary
                        If courseList.Count > 0 Then
                            CurrentStudent("courses") = String.Join(",", courseList)
                        Else
                            CurrentStudent("courses") = "No courses enrolled."
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student courses: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetStudentInfo() As (StudentID As String, FullName As String, YearSection As String)
        If CurrentStudent IsNot Nothing Then
            Dim studentID As String = CurrentStudent.GetValueOrDefault("studentId", "N/A")
            Dim fullName As String = CurrentStudent.GetValueOrDefault("FullName", "N/A")
            Dim yearSec As String = CurrentStudent.GetValueOrDefault("YearSec", "N/A")

            Return (studentID, fullName, yearSec)
        Else
            Return ("N/A", "N/A", "N/A")
        End If
    End Function


End Module
