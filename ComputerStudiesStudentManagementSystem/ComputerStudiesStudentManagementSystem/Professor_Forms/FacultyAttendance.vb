Public Class FacultyAttendance
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        Dim dashboard As New DashboardForm()
        dashboard.Show()

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        Dim facultyProfile As New FacultyProfile()
        facultyProfile.Show()
    End Sub

    Private Sub btnFacultyLoad_Click(sender As Object, e As EventArgs) Handles btnFacultyLoad.Click
        Me.Hide()
        Dim facultyLoad As New FacultyLoad()
        facultyLoad.Show()
    End Sub
End Class