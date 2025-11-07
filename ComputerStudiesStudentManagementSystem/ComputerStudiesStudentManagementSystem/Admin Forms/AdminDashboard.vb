Imports Guna.UI2.WinForms

Public Class AdminDashboard

    'validation: panel loading method
    Private Sub LoadFormIntoPanel(targetForm As Form)
        Try
            ' Validation: Ensure panel exists
            If SApnlMain Is Nothing Then
                MessageBox.Show("Main panel not found. Please check the form design.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Validation: Prevent duplicate loading
            If SApnlMain.Controls.Count > 0 Then
                SApnlMain.Controls.Clear()
            End If

            ' Prepare form
            targetForm.TopLevel = False
            targetForm.FormBorderStyle = FormBorderStyle.None
            targetForm.Dock = DockStyle.Fill

            ' Add to panel
            SApnlMain.Controls.Add(targetForm)
            SApnlMain.Tag = targetForm
            targetForm.Show()

        Catch ex As Exception
            MessageBox.Show("Error loading form: " & ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Button events
#Region "Button Events"

    'Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
    'Try
    'If Not IsConnectionReady() Then
    ''           MessageBox.Show("Connection is not ready. Please check your system connection.", "Connection Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    'Return
    'End If

    'Dim frm As New DashboardForm()
    '       LoadFormIntoPanel(frm)
    'Catch ex As Exception
    '       MessageBox.Show("Error loading Dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'End Sub

    'Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
    'Try
    'If Not IsConnectionReady() Then
    '           MessageBox.Show("Connection not ready. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    'Return
    'End If
    '
    'Dim frm As New FacultyManagementForm()
    '       LoadFormIntoPanel(frm)
    'Catch ex As Exception
    '       MessageBox.Show("Error loading Faculty Management: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'End Sub

    'Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
    'Try
    'If Not IsConnectionReady() Then
    '           MessageBox.Show("Connection not ready. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    'Return
    'End If
    '
    'Dim frm As New UserManagementForm()
    '       LoadFormIntoPanel(frm)
    'Catch ex As Exception
    '       MessageBox.Show("Error loading Users: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'End Sub

    'Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
    'Try
    'If Not IsConnectionReady() Then
    '           MessageBox.Show("Connection not ready. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    'Return
    'End If
    '
    'Dim frm As New SettingsForm()
    '       LoadFormIntoPanel(frm)
    'Catch ex As Exception
    '       MessageBox.Show("Error loading Settings: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'End Sub

#End Region

    'validation : check connection readiness
    Private Function IsConnectionReady() As Boolean
        ' You can replace this with your actual database connection test
        ' Example: Return Database.IsConnected
        Return True
    End Function

    'panel
    Private Sub SApnlMain_Paint(sender As Object, e As PaintEventArgs) Handles SApnlMain.Paint
        ' Validate that the panel can render properly
        If SApnlMain Is Nothing Then
            MessageBox.Show("Panel not initialized properly.", "Panel Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

End Class
