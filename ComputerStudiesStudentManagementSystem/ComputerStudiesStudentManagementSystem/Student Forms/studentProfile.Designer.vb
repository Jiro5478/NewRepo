' ==========================================
' FILENAME: /Forms/StudentPortalForm.Designer.vb
' PURPOSE: Designer file for Student Portal Form - COMPLETE FILE
' AUTHOR: System
' DATE: 2025-10-20
' ==========================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentProfile

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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        lblAddress = New Label()
        lblCourse = New Label()
        lblProgram = New Label()
        lblPhone = New Label()
        lblYearSec = New Label()
        lblEmail = New Label()
        lblFullName = New Label()
        lblName = New Label()
        lblStudentIdValue = New Label()
        lblStudentId = New Label()
        Label1 = New Label()
        lblEnrolledCourses = New Label()
        Label3 = New Label()
        Label14 = New Label()
        Label16 = New Label()
        lblContactNum = New Label()
        lblEmailAddress = New Label()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        Label6 = New Label()
        Label9 = New Label()
        Label12 = New Label()
        dvgCourse = New Guna.UI2.WinForms.Guna2DataGridView()
        Label2 = New Label()
        CType(dvgCourse, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 15
        Guna2Elipse1.TargetControl = Me
        ' 
        ' lblAddress
        ' 
        lblAddress.Anchor = AnchorStyles.None
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblAddress.Location = New Point(200, 337)
        lblAddress.Margin = New Padding(4, 0, 4, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(63, 19)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address"
        ' 
        ' lblCourse
        ' 
        lblCourse.Anchor = AnchorStyles.None
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 10F)
        lblCourse.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblCourse.Location = New Point(113, 273)
        lblCourse.Margin = New Padding(4, 0, 4, 0)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(63, 19)
        lblCourse.TabIndex = 9
        lblCourse.Text = "Year/Sec:"
        ' 
        ' lblProgram
        ' 
        lblProgram.Anchor = AnchorStyles.None
        lblProgram.AutoSize = True
        lblProgram.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblProgram.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblProgram.Location = New Point(200, 306)
        lblProgram.Margin = New Padding(4, 0, 4, 0)
        lblProgram.Name = "lblProgram"
        lblProgram.Size = New Size(69, 19)
        lblProgram.TabIndex = 8
        lblProgram.Text = "Program"
        ' 
        ' lblPhone
        ' 
        lblPhone.Anchor = AnchorStyles.None
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 10F)
        lblPhone.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblPhone.Location = New Point(62, 366)
        lblPhone.Margin = New Padding(4, 0, 4, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(114, 19)
        lblPhone.TabIndex = 7
        lblPhone.Text = "Contact Number:"
        ' 
        ' lblYearSec
        ' 
        lblYearSec.Anchor = AnchorStyles.None
        lblYearSec.AutoSize = True
        lblYearSec.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblYearSec.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblYearSec.Location = New Point(200, 273)
        lblYearSec.Margin = New Padding(4, 0, 4, 0)
        lblYearSec.Name = "lblYearSec"
        lblYearSec.Size = New Size(66, 19)
        lblYearSec.TabIndex = 6
        lblYearSec.Text = "Year Sec"
        ' 
        ' lblEmail
        ' 
        lblEmail.Anchor = AnchorStyles.None
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10F)
        lblEmail.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblEmail.Location = New Point(74, 402)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(97, 19)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email Address:"
        ' 
        ' lblFullName
        ' 
        lblFullName.Anchor = AnchorStyles.None
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFullName.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblFullName.Location = New Point(200, 244)
        lblFullName.Margin = New Padding(4, 0, 4, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(88, 21)
        lblFullName.TabIndex = 4
        lblFullName.Text = "Full Name"
        ' 
        ' lblName
        ' 
        lblName.Anchor = AnchorStyles.None
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 10F)
        lblName.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblName.Location = New Point(103, 244)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(73, 19)
        lblName.TabIndex = 3
        lblName.Text = "Full Name:"
        ' 
        ' lblStudentIdValue
        ' 
        lblStudentIdValue.Anchor = AnchorStyles.None
        lblStudentIdValue.AutoSize = True
        lblStudentIdValue.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblStudentIdValue.ForeColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        lblStudentIdValue.Location = New Point(200, 211)
        lblStudentIdValue.Margin = New Padding(4, 0, 4, 0)
        lblStudentIdValue.Name = "lblStudentIdValue"
        lblStudentIdValue.Size = New Size(88, 21)
        lblStudentIdValue.TabIndex = 2
        lblStudentIdValue.Text = "0000-0000"
        ' 
        ' lblStudentId
        ' 
        lblStudentId.Anchor = AnchorStyles.None
        lblStudentId.AutoSize = True
        lblStudentId.Font = New Font("Segoe UI", 10F)
        lblStudentId.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudentId.Location = New Point(98, 211)
        lblStudentId.Margin = New Padding(4, 0, 4, 0)
        lblStudentId.Name = "lblStudentId"
        lblStudentId.Size = New Size(78, 19)
        lblStudentId.TabIndex = 1
        lblStudentId.Text = "Student ID:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(74, 79)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 58)
        Label1.TabIndex = 0
        Label1.Text = "📋 Personal Information"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEnrolledCourses
        ' 
        lblEnrolledCourses.Anchor = AnchorStyles.None
        lblEnrolledCourses.AutoSize = True
        lblEnrolledCourses.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblEnrolledCourses.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblEnrolledCourses.Location = New Point(82, 487)
        lblEnrolledCourses.Margin = New Padding(4, 0, 4, 0)
        lblEnrolledCourses.Name = "lblEnrolledCourses"
        lblEnrolledCourses.Size = New Size(136, 19)
        lblEnrolledCourses.TabIndex = 1
        lblEnrolledCourses.Text = "Enrolled Courses: 0"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label3.Location = New Point(82, 458)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(233, 29)
        Label3.TabIndex = 0
        Label3.Text = "📚 Your Enrolled Courses:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10F)
        Label14.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label14.Location = New Point(111, 306)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(65, 19)
        Label14.TabIndex = 18
        Label14.Text = "Program:"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.None
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10F)
        Label16.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label16.Location = New Point(110, 337)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(61, 19)
        Label16.TabIndex = 19
        Label16.Text = "Address:"
        ' 
        ' lblContactNum
        ' 
        lblContactNum.Anchor = AnchorStyles.None
        lblContactNum.AutoSize = True
        lblContactNum.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblContactNum.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblContactNum.Location = New Point(200, 366)
        lblContactNum.Margin = New Padding(4, 0, 4, 0)
        lblContactNum.Name = "lblContactNum"
        lblContactNum.Size = New Size(96, 19)
        lblContactNum.TabIndex = 20
        lblContactNum.Text = "Contact Num"
        ' 
        ' lblEmailAddress
        ' 
        lblEmailAddress.Anchor = AnchorStyles.None
        lblEmailAddress.AutoSize = True
        lblEmailAddress.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblEmailAddress.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblEmailAddress.Location = New Point(200, 402)
        lblEmailAddress.Margin = New Padding(4, 0, 4, 0)
        lblEmailAddress.Name = "lblEmailAddress"
        lblEmailAddress.Size = New Size(103, 19)
        lblEmailAddress.TabIndex = 21
        lblEmailAddress.Text = "EMail Address"
        ' 
        ' btnBack
        ' 
        btnBack.BorderRadius = 3
        btnBack.BorderStyle = Drawing2D.DashStyle.Dot
        btnBack.CustomizableEdges = CustomizableEdges3
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnBack.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(1141, 23)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnBack.Size = New Size(150, 34)
        btnBack.TabIndex = 22
        btnBack.Text = "Back"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label6.Location = New Point(639, 627)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 19)
        Label6.TabIndex = 33
        Label6.Text = "Course Description:"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F)
        Label9.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label9.Location = New Point(672, 587)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 19)
        Label9.TabIndex = 25
        Label9.Text = "Course Name:"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F)
        Label12.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label12.Location = New Point(659, 556)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(91, 19)
        Label12.TabIndex = 31
        Label12.Text = "Course Code:"
        ' 
        ' dvgCourse
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dvgCourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dvgCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dvgCourse.ColumnHeadersHeight = 4
        dvgCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dvgCourse.DefaultCellStyle = DataGridViewCellStyle6
        dvgCourse.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgCourse.Location = New Point(74, 556)
        dvgCourse.Name = "dvgCourse"
        dvgCourse.RowHeadersVisible = False
        dvgCourse.Size = New Size(275, 211)
        dvgCourse.TabIndex = 34
        dvgCourse.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dvgCourse.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dvgCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dvgCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dvgCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dvgCourse.ThemeStyle.BackColor = Color.White
        dvgCourse.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgCourse.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dvgCourse.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dvgCourse.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dvgCourse.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dvgCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dvgCourse.ThemeStyle.HeaderStyle.Height = 4
        dvgCourse.ThemeStyle.ReadOnly = False
        dvgCourse.ThemeStyle.RowsStyle.BackColor = Color.White
        dvgCourse.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dvgCourse.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dvgCourse.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dvgCourse.ThemeStyle.RowsStyle.Height = 25
        dvgCourse.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgCourse.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label2.Location = New Point(659, 525)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 19)
        Label2.TabIndex = 35
        Label2.Text = "Ito mga columns inside sa datagrid:"
        ' 
        ' studentProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1313, 825)
        Controls.Add(Label2)
        Controls.Add(dvgCourse)
        Controls.Add(Label6)
        Controls.Add(Label9)
        Controls.Add(Label12)
        Controls.Add(btnBack)
        Controls.Add(lblEnrolledCourses)
        Controls.Add(Label3)
        Controls.Add(lblEmailAddress)
        Controls.Add(lblContactNum)
        Controls.Add(Label16)
        Controls.Add(Label14)
        Controls.Add(Label1)
        Controls.Add(lblStudentIdValue)
        Controls.Add(lblStudentId)
        Controls.Add(lblName)
        Controls.Add(lblAddress)
        Controls.Add(lblFullName)
        Controls.Add(lblCourse)
        Controls.Add(lblEmail)
        Controls.Add(lblProgram)
        Controls.Add(lblYearSec)
        Controls.Add(lblPhone)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "studentProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Portal"
        CType(dvgCourse, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStudentId As Label
    Friend WithEvents lblStudentIdValue As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblYearSec As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblProgram As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblEnrolledCourses As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblContactNum As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dvgCourse As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label18 As Label

End Class