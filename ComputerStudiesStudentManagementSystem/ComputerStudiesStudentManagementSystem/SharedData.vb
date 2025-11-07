Imports MySql.Data.MySqlClient

Public Module SharedData
    Private ReadOnly connectionString As String = "server=localhost;database=dbComputerStudies;user=root;password=;"

    ' Dictionary to hold current student info
    Public CurrentStudent As New Dictionary(Of String, String)

    ''' <summary>
    ''' Load student personal info and courses into CurrentStudent dictionary
    ''' </summary>
    ''' <param name="studentId">Student ID to load</param>
    ''' <param name="dgv">DataGridView to display courses</param>
    Public Sub LoadStudentDataAndCourses(studentId As String, dgv As DataGridView)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' --- Load student personal info ---
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
                            Return
                        End If
                    End Using
                End Using

                ' --- Load student courses ---
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

                        ' Store courses in a list to save in dictionary
                        Dim courseList As New List(Of String)

                        ' Read all courses
                        While reader.Read()
                            Dim code = reader("course_code").ToString()
                            Dim name = reader("course_name").ToString()
                            Dim time = reader("time").ToString()

                            dgv.Rows.Add(code, name, time)
                            courseList.Add(code)
                        End While

                        ' Save comma-separated list of course codes in dictionary
                        If courseList.Count > 0 Then
                            CurrentStudent("courses") = String.Join(",", courseList)
                        Else
                            CurrentStudent("courses") = "No courses enrolled."
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
