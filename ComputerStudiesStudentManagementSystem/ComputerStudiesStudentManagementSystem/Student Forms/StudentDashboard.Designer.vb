<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        btnStudentProfile = New Guna.UI2.WinForms.Guna2Button()
        lblFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblStudentID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblYearSection = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblAttendance = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        cmbCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        btnPresent = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAttendanceHistory = New Guna.UI2.WinForms.Guna2Button()
        btnLogout = New Guna.UI2.WinForms.Guna2Button()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' btnStudentProfile
        ' 
        btnStudentProfile.BorderRadius = 3
        btnStudentProfile.BorderStyle = Drawing2D.DashStyle.Dot
        btnStudentProfile.CustomizableEdges = CustomizableEdges7
        btnStudentProfile.DisabledState.BorderColor = Color.DarkGray
        btnStudentProfile.DisabledState.CustomBorderColor = Color.DarkGray
        btnStudentProfile.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnStudentProfile.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnStudentProfile.FillColor = Color.SeaGreen
        btnStudentProfile.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Bold)
        btnStudentProfile.ForeColor = Color.White
        btnStudentProfile.Location = New Point(12, 94)
        btnStudentProfile.Margin = New Padding(3, 4, 3, 4)
        btnStudentProfile.Name = "btnStudentProfile"
        btnStudentProfile.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnStudentProfile.Size = New Size(231, 36)
        btnStudentProfile.TabIndex = 3
        btnStudentProfile.Text = "Student Profile"
        ' 
        ' lblFullName
        ' 
        lblFullName.BackColor = Color.Transparent
        lblFullName.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold)
        lblFullName.Location = New Point(111, 172)
        lblFullName.Margin = New Padding(3, 4, 3, 4)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(86, 29)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Fullname"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold)
        Guna2HtmlLabel3.Location = New Point(14, 213)
        Guna2HtmlLabel3.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(139, 29)
        Guna2HtmlLabel3.TabIndex = 7
        Guna2HtmlLabel3.Text = "Year & Section:"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.BackColor = Color.Transparent
        lblStudentID.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold)
        lblStudentID.Location = New Point(138, 135)
        lblStudentID.Margin = New Padding(3, 4, 3, 4)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(106, 29)
        lblStudentID.TabIndex = 1
        lblStudentID.Text = "Student-Id:"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold)
        Guna2HtmlLabel2.Location = New Point(14, 135)
        Guna2HtmlLabel2.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(106, 29)
        Guna2HtmlLabel2.TabIndex = 6
        Guna2HtmlLabel2.Text = "Student-Id:"
        ' 
        ' lblYearSection
        ' 
        lblYearSection.BackColor = Color.Transparent
        lblYearSection.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold)
        lblYearSection.Location = New Point(159, 213)
        lblYearSection.Margin = New Padding(3, 4, 3, 4)
        lblYearSection.Name = "lblYearSection"
        lblYearSection.Size = New Size(157, 29)
        lblYearSection.TabIndex = 3
        lblYearSection.Text = "Year And Section"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold)
        Guna2HtmlLabel1.Location = New Point(14, 172)
        Guna2HtmlLabel1.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(91, 29)
        Guna2HtmlLabel1.TabIndex = 5
        Guna2HtmlLabel1.Text = "Fullname:"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.BackColor = Color.Transparent
        lblAttendance.Font = New Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAttendance.ForeColor = Color.White
        lblAttendance.Location = New Point(14, 12)
        lblAttendance.Margin = New Padding(3, 4, 3, 4)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(230, 48)
        lblAttendance.TabIndex = 0
        lblAttendance.Text = "ATTENDANCE"
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = pnlHeader
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(btnLogout)
        pnlHeader.Controls.Add(lblAttendance)
        pnlHeader.CustomizableEdges = CustomizableEdges5
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.FillColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlHeader.Size = New Size(915, 81)
        pnlHeader.TabIndex = 0
        ' 
        ' cmbCourse
        ' 
        cmbCourse.BackColor = Color.Transparent
        cmbCourse.CustomizableEdges = CustomizableEdges11
        cmbCourse.DrawMode = DrawMode.OwnerDrawFixed
        cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourse.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbCourse.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbCourse.Font = New Font("Segoe UI", 10F)
        cmbCourse.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbCourse.ItemHeight = 30
        cmbCourse.Location = New Point(265, 256)
        cmbCourse.Margin = New Padding(3, 4, 3, 4)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        cmbCourse.Size = New Size(379, 36)
        cmbCourse.TabIndex = 0
        ' 
        ' btnPresent
        ' 
        btnPresent.BorderRadius = 3
        btnPresent.BorderStyle = Drawing2D.DashStyle.Dash
        btnPresent.CustomizableEdges = CustomizableEdges9
        btnPresent.DisabledState.BorderColor = Color.DarkGray
        btnPresent.DisabledState.CustomBorderColor = Color.DarkGray
        btnPresent.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPresent.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPresent.FillColor = Color.SeaGreen
        btnPresent.Font = New Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold)
        btnPresent.ForeColor = Color.White
        btnPresent.Location = New Point(353, 320)
        btnPresent.Margin = New Padding(3, 4, 3, 4)
        btnPresent.Name = "btnPresent"
        btnPresent.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnPresent.Size = New Size(206, 60)
        btnPresent.TabIndex = 2
        btnPresent.Text = "Present"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel4.Location = New Point(212, 45)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(189, 29)
        Guna2HtmlLabel4.TabIndex = 1
        Guna2HtmlLabel4.Text = "Subject Description:"
        ' 
        ' btnAttendanceHistory
        ' 
        btnAttendanceHistory.BorderRadius = 3
        btnAttendanceHistory.BorderStyle = Drawing2D.DashStyle.Dot
        btnAttendanceHistory.CustomizableEdges = CustomizableEdges1
        btnAttendanceHistory.DisabledState.BorderColor = Color.DarkGray
        btnAttendanceHistory.DisabledState.CustomBorderColor = Color.DarkGray
        btnAttendanceHistory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAttendanceHistory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAttendanceHistory.FillColor = Color.SeaGreen
        btnAttendanceHistory.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Bold)
        btnAttendanceHistory.ForeColor = Color.White
        btnAttendanceHistory.Location = New Point(304, 396)
        btnAttendanceHistory.Margin = New Padding(3, 4, 3, 4)
        btnAttendanceHistory.Name = "btnAttendanceHistory"
        btnAttendanceHistory.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAttendanceHistory.Size = New Size(302, 45)
        btnAttendanceHistory.TabIndex = 4
        btnAttendanceHistory.Text = "Attendance History"
        ' 
        ' btnLogout
        ' 
        btnLogout.BorderRadius = 3
        btnLogout.BorderStyle = Drawing2D.DashStyle.Dot
        btnLogout.CustomizableEdges = CustomizableEdges3
        btnLogout.DisabledState.BorderColor = Color.DarkGray
        btnLogout.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogout.FillColor = Color.Red
        btnLogout.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(732, 15)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnLogout.Size = New Size(171, 45)
        btnLogout.TabIndex = 23
        btnLogout.Text = "Logout"
        ' 
        ' StudentDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 495)
        Controls.Add(btnAttendanceHistory)
        Controls.Add(lblFullName)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(lblStudentID)
        Controls.Add(pnlHeader)
        Controls.Add(btnStudentProfile)
        Controls.Add(btnPresent)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(lblYearSection)
        Controls.Add(cmbCourse)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "StudentDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentAttendance"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lblStudentID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAttendance As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblYearSection As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnStudentProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPresent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAttendanceHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
End Class
