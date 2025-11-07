Public Class attendanceHistory

    Private Sub attendanceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadattendanceHistory()
    End Sub

    Private Sub LoadattendanceHistory()
        ' 1️⃣ Retrieve data (replace this with your actual data source, e.g., database)
        Dim dt As New DataTable()

        ' Example sample data for testing
        dt.Columns.Add("student_id")
        dt.Columns.Add("student_name")
        dt.Columns.Add("course_name")
        dt.Columns.Add("status")
        dt.Columns.Add("time_in")
        dt.Columns.Add("recorded_by")

        dt.Rows.Add("2023001", "Juan Dela Cruz", "CS101", "Present", "8:02 AM", "Prof. Reyes")
        dt.Rows.Add("2023002", "Maria Santos", "CS101", "Late", "8:25 AM", "Prof. Reyes")
        dt.Rows.Add("2023003", "Jose Dela Peña", "CS101", "Absent", "", "Prof. Reyes")
        dt.Rows.Add("2023004", "Ana Cruz", "CS101", "Excused", "", "Prof. Reyes")

        ' 2️⃣ Bind data to DataGridView
        dvgAttendanceHistory.DataSource = dt

        ' 3️⃣ Format DataGridView columns
        If dvgAttendanceHistory.Columns.Count > 0 Then
            dvgAttendanceHistory.Columns("student_id").HeaderText = "Student ID"
            dvgAttendanceHistory.Columns("student_id").Width = 120

            dvgAttendanceHistory.Columns("student_name").HeaderText = "Student Name"
            dvgAttendanceHistory.Columns("student_name").Width = 200

            dvgAttendanceHistory.Columns("course_name").HeaderText = "Course"
            dvgAttendanceHistory.Columns("course_name").Width = 180

            dvgAttendanceHistory.Columns("status").HeaderText = "Status"
            dvgAttendanceHistory.Columns("status").Width = 100

            dvgAttendanceHistory.Columns("time_in").HeaderText = "Time In"
            dvgAttendanceHistory.Columns("time_in").Width = 120

            dvgAttendanceHistory.Columns("recorded_by").HeaderText = "Recorded By"
            dvgAttendanceHistory.Columns("recorded_by").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If

        ' 4️⃣ Apply color coding for "status"
        For Each row As DataGridViewRow In dvgAttendanceHistory.Rows
            If row.Cells("status").Value IsNot Nothing Then
                Dim status As String = row.Cells("status").Value.ToString().ToLower()
                Select Case status
                    Case "present"
                        row.Cells("status").Style.ForeColor = Color.FromArgb(46, 139, 87)
                    Case "absent"
                        row.Cells("status").Style.ForeColor = Color.FromArgb(231, 76, 60)
                    Case "late"
                        row.Cells("status").Style.ForeColor = Color.FromArgb(243, 156, 18)
                    Case "excused"
                        row.Cells("status").Style.ForeColor = Color.FromArgb(155, 89, 182)
                End Select
                row.Cells("status").Style.Font = New Font(dvgAttendanceHistory.Font, FontStyle.Bold)
            End If
        Next

        ' 5️⃣ Update record count label
        lblTodayCount.Text = $"Total Records: {dt.Rows.Count}"
    End Sub

    Private Sub dvgAttendanceHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgAttendanceHistory.CellContentClick
        ' Optional: add event logic here
    End Sub

    Private Sub lblStudentFullN_Click(sender As Object, e As EventArgs) Handles lblStudentFullN.Click

    End Sub

    Private Sub lblStudentFullName_Click(sender As Object, e As EventArgs) Handles lblStudentFullName.Click

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs)

    End Sub
End Class
