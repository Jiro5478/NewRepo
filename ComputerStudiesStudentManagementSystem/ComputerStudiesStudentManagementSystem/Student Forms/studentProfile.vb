Public Class studentProfile

    ' Handles the Back button click — closes this profile and returns to the owner (if any).
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim back As New StudentDashboard
        back.Show()
        Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub studentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblEnrolledCourses_Click(sender As Object, e As EventArgs) Handles lblEnrolledCourses.Click

    End Sub

    Private Sub lblStudentIdValue_Click(sender As Object, e As EventArgs) Handles lblStudentIdValue.Click

    End Sub

    Private Sub lblContactNum_Click(sender As Object, e As EventArgs) Handles lblContactNum.Click

    End Sub
End Class