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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        btnStudentProfile = New Guna.UI2.WinForms.Guna2Button()
        btnlogout = New Guna.UI2.WinForms.Guna2Button()
        lblFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lvlStudentIDValue = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblStudentID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblYearSection = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblAttendance = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        cmbCourse = New Guna.UI2.WinForms.Guna2ComboBox()
        btnPresent = New Guna.UI2.WinForms.Guna2Button()
        Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAttendanceHistory = New Guna.UI2.WinForms.Guna2Button()
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
        btnStudentProfile.Font = New Font("Segoe UI Variable Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudentProfile.ForeColor = Color.White
        btnStudentProfile.Location = New Point(12, 205)
        btnStudentProfile.Name = "btnStudentProfile"
        btnStudentProfile.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnStudentProfile.Size = New Size(129, 40)
        btnStudentProfile.TabIndex = 3
        btnStudentProfile.Text = "Profile"
        ' 
        ' btnlogout
        ' 
        btnlogout.BorderRadius = 3
        btnlogout.BorderStyle = Drawing2D.DashStyle.Dot
        btnlogout.CustomizableEdges = CustomizableEdges3
        btnlogout.DisabledState.BorderColor = Color.DarkGray
        btnlogout.DisabledState.CustomBorderColor = Color.DarkGray
        btnlogout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnlogout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnlogout.FillColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnlogout.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Bold)
        btnlogout.ForeColor = Color.White
        btnlogout.Location = New Point(638, 33)
        btnlogout.Name = "btnlogout"
        btnlogout.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnlogout.Size = New Size(150, 34)
        btnlogout.TabIndex = 4
        btnlogout.Text = "Log Out"
        ' 
        ' lblFullName
        ' 
        lblFullName.BackColor = Color.Transparent
        lblFullName.Font = New Font("Arial", 15.75F)
        lblFullName.Location = New Point(110, 132)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(86, 26)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Fullname"
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Arial", 15.75F)
        Guna2HtmlLabel3.Location = New Point(12, 164)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(151, 26)
        Guna2HtmlLabel3.TabIndex = 7
        Guna2HtmlLabel3.Text = "Year & Section:"
        ' 
        ' lvlStudentIDValue
        ' 
        lvlStudentIDValue.BackColor = Color.Transparent
        lvlStudentIDValue.Font = New Font("Arial", 15.75F)
        lvlStudentIDValue.Location = New Point(122, 100)
        lvlStudentIDValue.Name = "lvlStudentIDValue"
        lvlStudentIDValue.Size = New Size(104, 26)
        lvlStudentIDValue.TabIndex = 1
        lvlStudentIDValue.Text = "Student-Id:"
        ' 
        ' lblStudentID
        ' 
        lblStudentID.BackColor = Color.Transparent
        lblStudentID.Font = New Font("Arial", 15.75F)
        lblStudentID.Location = New Point(12, 100)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New Size(104, 26)
        lblStudentID.TabIndex = 6
        lblStudentID.Text = "Student-Id:"
        ' 
        ' lblYearSection
        ' 
        lblYearSection.BackColor = Color.Transparent
        lblYearSection.Font = New Font("Arial", 15.75F)
        lblYearSection.Location = New Point(169, 164)
        lblYearSection.Name = "lblYearSection"
        lblYearSection.Size = New Size(166, 26)
        lblYearSection.TabIndex = 3
        lblYearSection.Text = "Year And Section"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Arial", 15.75F)
        Guna2HtmlLabel1.Location = New Point(12, 132)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(92, 26)
        Guna2HtmlLabel1.TabIndex = 5
        Guna2HtmlLabel1.Text = "Fullname:"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.BackColor = Color.Transparent
        lblAttendance.Font = New Font("Segoe UI Variable Display", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAttendance.ForeColor = Color.White
        lblAttendance.Location = New Point(23, 12)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(213, 45)
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
        pnlHeader.Controls.Add(btnlogout)
        pnlHeader.Controls.Add(lblAttendance)
        pnlHeader.CustomizableEdges = CustomizableEdges5
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.FillColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlHeader.Size = New Size(801, 80)
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
        cmbCourse.Location = New Point(246, 271)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        cmbCourse.Size = New Size(332, 36)
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
        btnPresent.Font = New Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPresent.ForeColor = Color.White
        btnPresent.Location = New Point(319, 342)
        btnPresent.Name = "btnPresent"
        btnPresent.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnPresent.Size = New Size(191, 46)
        btnPresent.TabIndex = 2
        btnPresent.Text = "Present"
        ' 
        ' Guna2HtmlLabel4
        ' 
        Guna2HtmlLabel4.BackColor = Color.Transparent
        Guna2HtmlLabel4.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel4.Location = New Point(212, 45)
        Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Guna2HtmlLabel4.Size = New Size(150, 23)
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
        btnAttendanceHistory.Font = New Font("Segoe UI Variable Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAttendanceHistory.ForeColor = Color.White
        btnAttendanceHistory.Location = New Point(301, 404)
        btnAttendanceHistory.Name = "btnAttendanceHistory"
        btnAttendanceHistory.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAttendanceHistory.Size = New Size(236, 40)
        btnAttendanceHistory.TabIndex = 4
        btnAttendanceHistory.Text = "Attendance History"
        ' 
        ' StudentDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(801, 509)
        Controls.Add(lblFullName)
        Controls.Add(lvlStudentIDValue)
        Controls.Add(btnAttendanceHistory)
        Controls.Add(Guna2HtmlLabel3)
        Controls.Add(pnlHeader)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(btnStudentProfile)
        Controls.Add(lblYearSection)
        Controls.Add(btnPresent)
        Controls.Add(lblStudentID)
        Controls.Add(cmbCourse)
        FormBorderStyle = FormBorderStyle.None
        Name = "StudentDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentAttendance"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lvlStudentIDValue As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAttendance As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblYearSection As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnStudentProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStudentID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPresent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbCourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnAttendanceHistory As Guna.UI2.WinForms.Guna2Button
End Class
