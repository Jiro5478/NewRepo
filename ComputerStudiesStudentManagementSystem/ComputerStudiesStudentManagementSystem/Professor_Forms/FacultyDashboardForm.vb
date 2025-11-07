' ==========================================
' FILENAME: /Forms/DashboardForm.vb
' PURPOSE: Main dashboard form with role-based navigation - MERGED VERSION
' AUTHOR: System
' DATE: 2025-10-17
' LAST UPDATED: 2025-10-25 - Merged student portal functionality
' Edited By Rovic
' For Future users please do not remove this header
' ==========================================

Imports System.Data

Public Class DashboardForm
    Private Sub dasboardform_load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & LoginForm.txtUsername.Text
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim facultyProfileForm As New FacultyProfile()
    End Sub

    Private Sub btnFacultyLoad_Click(sender As Object, e As EventArgs) Handles btnFacultyLoad.Click

    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click

    End Sub

    Private Sub btnClassList_Click(sender As Object, e As EventArgs) Handles btnClassList.Click

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Try
            MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If False Then
                Return
            End If
            Me.Hide()
            Dim loginform As New LoginForm()
            loginform.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If False Then
                Return
            End If
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblRole_Click(sender As Object, e As EventArgs) Handles lblRole.Click

    End Sub

    Private Sub pnlContent_Paint(sender As Object, e As PaintEventArgs) Handles pnlContent.Paint

    End Sub
End Class