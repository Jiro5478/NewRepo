Public Class studentProfile
    Public dgv As New DataGridView
    ' Handles the Back button click — closes this profile and returns to the owner (if any).
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim back As New StudentDashboard()
        back.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub studentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            lblFullName.Text = SharedData.CurrentStudent("FullName")
            lblStudentIdValue.Text = SharedData.CurrentStudent("studentId")
            lblYearSec.Text = SharedData.CurrentStudent("YearSec")
            lblProgram.Text = SharedData.CurrentStudent("Program")
            lblAddress.Text = SharedData.CurrentStudent("Address")
            lblContactNum.Text = SharedData.CurrentStudent("ContactNo")
            lblEmailAddress.Text = SharedData.CurrentStudent("Email")
            ' Load enrolled courses
            SharedData.LoadStudentCourses(SharedData.CurrentStudent("studentId"), dgv)
        Catch ex As Exception
            MessageBox.Show("Error loading student profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblEnrolledCourses_Click(sender As Object, e As EventArgs) Handles lblEnrolledCourses.Click

    End Sub

    Private Sub lblEmailAddress_Click(sender As Object, e As EventArgs) Handles lblEmailAddress.Click

    End Sub
End Class