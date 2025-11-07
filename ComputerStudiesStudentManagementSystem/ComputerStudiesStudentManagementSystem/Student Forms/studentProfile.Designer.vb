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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
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
        lblEnrolledCourses = New Label()
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
        pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        lblAttendance = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Label3 = New Label()
        Panel1 = New Panel()
        CType(dvgCourse, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        Guna2PnlHeader.SuspendLayout()
        Panel1.SuspendLayout()
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
        lblAddress.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))

        lblAddress.Location = New Point(229, 449)
        lblAddress.Margin = New Padding(5, 0, 5, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(74, 23)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address"
        ' 
        ' lblCourse
        ' 
        lblCourse.Anchor = AnchorStyles.None
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblCourse.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblCourse.Location = New Point(129, 364)
        lblCourse.Margin = New Padding(5, 0, 5, 0)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(79, 23)
        lblCourse.TabIndex = 9
        lblCourse.Text = "Year/Sec:"
        ' 
        ' lblProgram
        ' 
        lblProgram.Anchor = AnchorStyles.None
        lblProgram.AutoSize = True
        lblProgram.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblProgram.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblProgram.Location = New Point(229, 408)
        lblProgram.Margin = New Padding(5, 0, 5, 0)
        lblProgram.Name = "lblProgram"
        lblProgram.Size = New Size(80, 23)
        lblProgram.TabIndex = 8
        lblProgram.Text = "Program"
        ' 
        ' lblPhone
        ' 
        lblPhone.Anchor = AnchorStyles.None
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblPhone.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))

        lblPhone.Location = New Point(71, 488)
        lblPhone.Margin = New Padding(5, 0, 5, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(142, 23)
        lblPhone.TabIndex = 7
        lblPhone.Text = "Contact Number:"
        ' 
        ' lblYearSec
        ' 
        lblYearSec.Anchor = AnchorStyles.None
        lblYearSec.AutoSize = True
        lblYearSec.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblYearSec.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblYearSec.Location = New Point(229, 364)
        lblYearSec.Margin = New Padding(5, 0, 5, 0)
        lblYearSec.Name = "lblYearSec"
        lblYearSec.Size = New Size(75, 23)
        lblYearSec.TabIndex = 6
        lblYearSec.Text = "Year Sec"
        ' 
        ' lblEmail
        ' 
        lblEmail.Anchor = AnchorStyles.None
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblEmail.Location = New Point(85, 536)
        lblEmail.Margin = New Padding(5, 0, 5, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(120, 23)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email Address:"
        ' 
        ' lblFullName
        ' 
        lblFullName.Anchor = AnchorStyles.None
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblFullName.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblFullName.Location = New Point(229, 325)
        lblFullName.Margin = New Padding(5, 0, 5, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(108, 28)
        lblFullName.TabIndex = 4
        lblFullName.Text = "Full Name"
        ' 
        ' lblName
        ' 
        lblName.Anchor = AnchorStyles.None
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblName.Location = New Point(118, 325)
        lblName.Margin = New Padding(5, 0, 5, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(91, 23)
        lblName.TabIndex = 3
        lblName.Text = "Full Name:"
        ' 
        ' lblStudentIdValue
        ' 
        lblStudentIdValue.Anchor = AnchorStyles.None
        lblStudentIdValue.AutoSize = True
        lblStudentIdValue.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblStudentIdValue.ForeColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        lblStudentIdValue.Location = New Point(229, 281)
        lblStudentIdValue.Margin = New Padding(5, 0, 5, 0)
        lblStudentIdValue.Name = "lblStudentIdValue"
        lblStudentIdValue.Size = New Size(116, 28)
        lblStudentIdValue.TabIndex = 2
        lblStudentIdValue.Text = "0000-0000"
        ' 
        ' lblStudentId
        ' 
        lblStudentId.Anchor = AnchorStyles.None
        lblStudentId.AutoSize = True
        lblStudentId.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        lblStudentId.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudentId.Location = New Point(11, 13)
        lblStudentId.Margin = New Padding(4, 0, 4, 0)
        lblStudentId.Name = "lblStudentId"
        lblStudentId.Size = New Size(119, 30)
        lblStudentId.TabIndex = 1
        lblStudentId.Text = "Student ID:"
        ' 

        ' lblEnrolledCourses
        ' 
        lblEnrolledCourses.Anchor = AnchorStyles.None
        lblEnrolledCourses.AutoSize = True
        lblEnrolledCourses.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblEnrolledCourses.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblEnrolledCourses.Location = New Point(94, 649)
        lblEnrolledCourses.Margin = New Padding(5, 0, 5, 0)
        lblEnrolledCourses.Name = "lblEnrolledCourses"
        lblEnrolledCourses.Size = New Size(162, 23)
        lblEnrolledCourses.TabIndex = 1
        lblEnrolledCourses.Text = "Enrolled Courses: 0"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label3.Location = New Point(94, 611)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(266, 39)
        Label3.TabIndex = 0
        Label3.Text = "📚 Your Enrolled Courses:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        Label14.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label14.Location = New Point(127, 408)
        Label14.Margin = New Padding(5, 0, 5, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(80, 23)
        Label14.TabIndex = 18
        Label14.Text = "Program:"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.None
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        Label16.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label16.Location = New Point(126, 449)
        Label16.Margin = New Padding(5, 0, 5, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(74, 23)
        Label16.TabIndex = 19
        Label16.Text = "Address:"
        ' 
        ' lblContactNum
        ' 
        lblContactNum.Anchor = AnchorStyles.None
        lblContactNum.AutoSize = True
        lblContactNum.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblContactNum.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblContactNum.Location = New Point(229, 488)
        lblContactNum.Margin = New Padding(5, 0, 5, 0)
        lblContactNum.Name = "lblContactNum"
        lblContactNum.Size = New Size(116, 23)
        lblContactNum.TabIndex = 20
        lblContactNum.Text = "Contact Num"
        ' 
        ' lblEmailAddress
        ' 
        lblEmailAddress.Anchor = AnchorStyles.None
        lblEmailAddress.AutoSize = True
        lblEmailAddress.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblEmailAddress.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblEmailAddress.Location = New Point(229, 536)
        lblEmailAddress.Margin = New Padding(5, 0, 5, 0)
        lblEmailAddress.Name = "lblEmailAddress"
        lblEmailAddress.Size = New Size(123, 23)
        lblEmailAddress.TabIndex = 21
        lblEmailAddress.Text = "EMail Address"
        ' 
        ' btnBack
        ' 
        btnBack.BorderRadius = 3
        btnBack.BorderStyle = Drawing2D.DashStyle.Dot
        btnBack.CustomizableEdges = CustomizableEdges5
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnBack.Font = New Font("Segoe UI Variable Small", 12.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(1304, 31)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(171, 45)
        btnBack.TabIndex = 22
        btnBack.Text = "Back"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.0F)
        Label6.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label6.Location = New Point(730, 836)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 23)
        Label6.TabIndex = 33
        Label6.Text = "Course Description:"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.0F)
        Label9.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label9.Location = New Point(768, 783)
        Label9.Margin = New Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(118, 23)
        Label9.TabIndex = 25
        Label9.Text = "Course Name:"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.0F)
        Label12.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label12.Location = New Point(753, 741)
        Label12.Margin = New Padding(5, 0, 5, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(112, 23)
        Label12.TabIndex = 31
        Label12.Text = "Course Code:"
        ' 
        ' dvgCourse
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dvgCourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dvgCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dvgCourse.ColumnHeadersHeight = 4
        dvgCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dvgCourse.DefaultCellStyle = DataGridViewCellStyle3
        dvgCourse.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgCourse.Location = New Point(85, 741)
        dvgCourse.Margin = New Padding(3, 4, 3, 4)
        dvgCourse.Name = "dvgCourse"
        dvgCourse.RowHeadersVisible = False
        dvgCourse.RowHeadersWidth = 51
        dvgCourse.RowTemplate.Height = 25
        dvgCourse.Size = New Size(314, 281)
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
        dvgCourse.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9.0F)
        dvgCourse.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dvgCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dvgCourse.ThemeStyle.HeaderStyle.Height = 4
        dvgCourse.ThemeStyle.ReadOnly = False
        dvgCourse.ThemeStyle.RowsStyle.BackColor = Color.White
        dvgCourse.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dvgCourse.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9.0F)
        dvgCourse.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dvgCourse.ThemeStyle.RowsStyle.Height = 25
        dvgCourse.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgCourse.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F)
        Label2.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        Label2.Location = New Point(753, 700)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(282, 23)
        Label2.TabIndex = 35
        Label2.Text = "Ito mga columns inside sa datagrid:"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(Guna2PnlHeader)
        pnlHeader.Controls.Add(lblAttendance)
        pnlHeader.Controls.Add(btnBack)
        pnlHeader.CustomizableEdges = CustomizableEdges7
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.FillColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlHeader.Size = New Size(937, 74)
        pnlHeader.TabIndex = 36
        ' 
        ' Guna2PnlHeader
        ' 
        Guna2PnlHeader.Controls.Add(Guna2HtmlLabel1)
        Guna2PnlHeader.Controls.Add(Guna2Button1)
        Guna2PnlHeader.CustomizableEdges = CustomizableEdges3
        Guna2PnlHeader.Dock = DockStyle.Top
        Guna2PnlHeader.FillColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Guna2PnlHeader.Location = New Point(0, 0)
        Guna2PnlHeader.Name = "Guna2PnlHeader"
        Guna2PnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2PnlHeader.Size = New Size(937, 74)
        Guna2PnlHeader.TabIndex = 37
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Variable Display", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.White
        Guna2HtmlLabel1.Location = New Point(25, 12)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(318, 45)
        Guna2HtmlLabel1.TabIndex = 23
        Guna2HtmlLabel1.Text = "Personal Information"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 3
        Guna2Button1.BorderStyle = Drawing2D.DashStyle.Dot
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Red
        Guna2Button1.Font = New Font("Segoe UI Variable Small", 12.0F, FontStyle.Bold)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(775, 21)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(150, 34)
        Guna2Button1.TabIndex = 22
        Guna2Button1.Text = "Back"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.BackColor = Color.Transparent
        lblAttendance.Font = New Font("Segoe UI Variable Display", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAttendance.ForeColor = Color.White
        lblAttendance.Location = New Point(37, 12)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(318, 45)
        lblAttendance.TabIndex = 23
        lblAttendance.Text = "Personal Information"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI Variable Display", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = Color.White
        Guna2HtmlLabel2.Location = New Point(27, 15)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(390, 45)
        Guna2HtmlLabel2.TabIndex = 23
        Guna2HtmlLabel2.Text = "📚 Your Enrolled Courses:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label3.Location = New Point(0, 370)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 29)
        Label3.TabIndex = 0
        Label3.Text = "📚 Your Enrolled Courses:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblProgram)
        Panel1.Controls.Add(lblStudentId)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lblCourse)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(lblStudentIdValue)
        Panel1.Controls.Add(lblFullName)
        Panel1.Controls.Add(lblYearSec)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(lblEmailAddress)
        Panel1.Controls.Add(lblPhone)
        Panel1.Controls.Add(lblContactNum)
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(lblAddress)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(937, 332)
        Panel1.TabIndex = 37
        ' 
        ' studentProfile
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1501, 1100)
        Controls.Add(Label2)
        Controls.Add(dvgCourse)
        Controls.Add(lblEnrolledCourses)
        Controls.Add(Label3)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "studentProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Portal"
        CType(dvgCourse, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        Guna2PnlHeader.ResumeLayout(False)
        Guna2PnlHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
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
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAttendance As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel1 As Panel

End Class