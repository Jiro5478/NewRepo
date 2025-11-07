Public Class StudentDashboard

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnStudentProfile_Click(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        Dim studentProfile As New studentProfile
        studentProfile.Show()
        Me.Hide()
    End Sub

    Private Sub btnAttendanceHistory_Click(sender As Object, e As EventArgs) Handles btnAttendanceHistory.Click
        Dim attendanceHistory As New attendanceHistory()
        attendanceHistory.Show()
        Me.Hide()
    End Sub

    Private Sub btnPresent_Click(sender As Object, e As EventArgs) Handles btnPresent.Click

    End Sub

    Private Sub StudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblFullName.Text = SharedData.CurrentStudent("FullName")
            lblStudentID.Text = SharedData.CurrentStudent("studentId")
            lblYearSection.Text = SharedData.CurrentStudent("YearSec")
        Catch ex As Exception
            MessageBox.Show("Error loading student info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim loginform As New LoginForm()
        loginform.Show()
    End Sub
End Class