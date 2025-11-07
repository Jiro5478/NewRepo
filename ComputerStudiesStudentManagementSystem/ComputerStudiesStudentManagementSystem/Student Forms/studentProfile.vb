Public Class studentProfile

    ' Handles the Back button click — closes this profile and returns to the owner (if any).
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim back As New StudentDashboard()
        back.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub studentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class