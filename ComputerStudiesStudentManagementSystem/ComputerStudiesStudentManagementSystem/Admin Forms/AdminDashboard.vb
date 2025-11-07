Imports Guna.UI2.WinForms

Public Class AdminDashboard

    ' === LOAD FORM INTO PANEL ===
    Private Sub LoadFormIntoPanel(targetForm As Form, pageTitle As String)
        Try
            ' Validation: Ensure panel exists
            If SApnlContent Is Nothing Then
                MessageBox.Show("Main panel not found. Please check the form design.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Clear previous controls
            If SApnlMain.Controls.Count > 0 Then
                SApnlMain.Controls.Clear()
            End If

            ' Prepare the form
            targetForm.TopLevel = False
            targetForm.FormBorderStyle = FormBorderStyle.None
            targetForm.Dock = DockStyle.Fill

            ' Add form to panel
            SApnlMain.Controls.Add(targetForm)
            SApnlMain.Tag = targetForm
            targetForm.Show()

            ' === Set the page title ===
            lblPageTitle.Text = pageTitle.ToUpper()

        Catch ex As Exception
            MessageBox.Show("Error loading form: " & ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


#Region "Button Events"

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Try
            If Not IsConnectionReady() Then
                MessageBox.Show("Connection not ready. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim frm As New SAFacultyList()
            LoadFormIntoPanel(frm, "Faculty") ' <-- This sets the title
        Catch ex As Exception
            MessageBox.Show("Error loading Faculty Management: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Example if you add more buttons later:
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim frm As New DashboardForm()
        LoadFormIntoPanel(frm, "Dashboard")
    End Sub

    'Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
    'Dim frm As New UserManagementForm()
    '   LoadFormIntoPanel(frm, "Users")
    'End Sub

#End Region


    ' === CONNECTION CHECK ===
    Private Function IsConnectionReady() As Boolean
        Return True
    End Function

    ' === LOGOUT ===
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub
    'window control buttons
#Region "Window Control Buttons"
    Private Sub winClose_Click(sender As Object, e As EventArgs) Handles winClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub winMin_Click(sender As Object, e As EventArgs) Handles winMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub winMax_Click(sender As Object, e As EventArgs) Handles winMax.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
#End Region

    'window control: hover effects
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' === Guna2 Close Button Hover Effect ===
        With winClose
            .FillColor = Color.Transparent ' default background
            .IconColor = Color.Black ' default icon color
            .HoverState.FillColor = Color.Red ' red when hovered
            .HoverState.IconColor = Color.White ' white "X" when hovered
        End With

        ' === Guna2 Minimize Button (optional style) ===
        With winMin
            .FillColor = Color.Transparent
            .IconColor = Color.Black
            .HoverState.FillColor = Color.FromArgb(229, 229, 229) ' light gray hover
            .HoverState.IconColor = Color.Black
        End With

        ' === Guna2 Maximize Button (optional style) ===
        With winMax
            .FillColor = Color.Transparent
            .IconColor = Color.Black
            .HoverState.FillColor = Color.FromArgb(229, 229, 229)
            .HoverState.IconColor = Color.Black
        End With
    End Sub

End Class
