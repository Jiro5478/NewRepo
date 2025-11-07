<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendanceHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dvgAttendanceHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        lblFullName = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblStudentFullName = New Label()
        lblStudentProgram = New Label()
        lblStudentFullN = New Label()
        lblStudProgram = New Label()
        lblTodayCount = New Label()
        pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Panel1 = New Panel()
        btnBack = New Guna.UI2.WinForms.Guna2Button()
        CType(dvgAttendanceHistory, ComponentModel.ISupportInitialize).BeginInit()
        pnlHeader.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dvgAttendanceHistory
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dvgAttendanceHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dvgAttendanceHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dvgAttendanceHistory.ColumnHeadersHeight = 4
        dvgAttendanceHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dvgAttendanceHistory.DefaultCellStyle = DataGridViewCellStyle3
        dvgAttendanceHistory.Dock = DockStyle.Bottom
        dvgAttendanceHistory.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgAttendanceHistory.Location = New Point(0, 311)
        dvgAttendanceHistory.Margin = New Padding(3, 4, 3, 4)
        dvgAttendanceHistory.Name = "dvgAttendanceHistory"
        dvgAttendanceHistory.RowHeadersVisible = False
        dvgAttendanceHistory.RowHeadersWidth = 51
        dvgAttendanceHistory.RowTemplate.Height = 25
        dvgAttendanceHistory.Size = New Size(914, 172)
        dvgAttendanceHistory.TabIndex = 0
        dvgAttendanceHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dvgAttendanceHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dvgAttendanceHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dvgAttendanceHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dvgAttendanceHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dvgAttendanceHistory.ThemeStyle.BackColor = Color.White
        dvgAttendanceHistory.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgAttendanceHistory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dvgAttendanceHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dvgAttendanceHistory.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dvgAttendanceHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dvgAttendanceHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dvgAttendanceHistory.ThemeStyle.HeaderStyle.Height = 4
        dvgAttendanceHistory.ThemeStyle.ReadOnly = False
        dvgAttendanceHistory.ThemeStyle.RowsStyle.BackColor = Color.White
        dvgAttendanceHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dvgAttendanceHistory.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dvgAttendanceHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dvgAttendanceHistory.ThemeStyle.RowsStyle.Height = 25
        dvgAttendanceHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgAttendanceHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' lblFullName
        ' 
        lblFullName.Anchor = AnchorStyles.None
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFullName.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblFullName.Location = New Point(363, 161)
        lblFullName.Margin = New Padding(5, 0, 5, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(129, 28)
        lblFullName.TabIndex = 6
        lblFullName.Text = "Course Code"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(499, 161)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 28)
        Label1.TabIndex = 7
        Label1.Text = "Course Name"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label2.Location = New Point(637, 161)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 28)
        Label2.TabIndex = 8
        Label2.Text = "Course Time"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label3.Location = New Point(769, 161)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 28)
        Label3.TabIndex = 9
        Label3.Text = "Time In"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label4.Location = New Point(850, 161)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 28)
        Label4.TabIndex = 10
        Label4.Text = "Status"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label5.Location = New Point(627, 427)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(287, 28)
        Label5.TabIndex = 11
        Label5.Text = "(present,absent,late,excused)"
        ' 
        ' lblStudentFullName
        ' 
        lblStudentFullName.Anchor = AnchorStyles.None
        lblStudentFullName.AutoSize = True
        lblStudentFullName.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold)
        lblStudentFullName.ForeColor = SystemColors.ControlText
        lblStudentFullName.Location = New Point(5, 12)
        lblStudentFullName.Margin = New Padding(5, 0, 5, 0)
        lblStudentFullName.Name = "lblStudentFullName"
        lblStudentFullName.Size = New Size(179, 27)
        lblStudentFullName.TabIndex = 13
        lblStudentFullName.Text = "Student FullName:"
        ' 
        ' lblStudentProgram
        ' 
        lblStudentProgram.Anchor = AnchorStyles.None
        lblStudentProgram.AutoSize = True
        lblStudentProgram.Font = New Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold)
        lblStudentProgram.ForeColor = SystemColors.ControlText
        lblStudentProgram.Location = New Point(6, 44)
        lblStudentProgram.Margin = New Padding(5, 0, 5, 0)
        lblStudentProgram.Name = "lblStudentProgram"
        lblStudentProgram.Size = New Size(171, 27)
        lblStudentProgram.TabIndex = 14
        lblStudentProgram.Text = "Student Program:"
        ' 
        ' lblStudentFullN
        ' 
        lblStudentFullN.Anchor = AnchorStyles.None
        lblStudentFullN.AutoSize = True
        lblStudentFullN.Font = New Font("Segoe UI", 10F)
        lblStudentFullN.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudentFullN.Location = New Point(189, 15)
        lblStudentFullN.Margin = New Padding(5, 0, 5, 0)
        lblStudentFullN.Name = "lblStudentFullN"
        lblStudentFullN.Size = New Size(146, 23)
        lblStudentFullN.TabIndex = 15
        lblStudentFullN.Text = "Student FullName"
        ' 
        ' lblStudProgram
        ' 
        lblStudProgram.Anchor = AnchorStyles.None
        lblStudProgram.AutoSize = True
        lblStudProgram.Font = New Font("Segoe UI", 10F)
        lblStudProgram.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudProgram.Location = New Point(192, 46)
        lblStudProgram.Margin = New Padding(5, 0, 5, 0)
        lblStudProgram.Name = "lblStudProgram"
        lblStudProgram.Size = New Size(146, 23)
        lblStudProgram.TabIndex = 16
        lblStudProgram.Text = "Student FullName"
        ' 
        ' lblTodayCount
        ' 
        lblTodayCount.AutoSize = True
        lblTodayCount.Location = New Point(459, 263)
        lblTodayCount.Name = "lblTodayCount"
        lblTodayCount.Size = New Size(206, 20)
        lblTodayCount.TabIndex = 17
        lblTodayCount.Text = "Today's Attendance: 0 records"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(btnBack)
        pnlHeader.Controls.Add(Guna2HtmlLabel1)
        pnlHeader.CustomizableEdges = CustomizableEdges3
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.FillColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlHeader.Size = New Size(914, 81)
        pnlHeader.TabIndex = 18
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.White
        Guna2HtmlLabel1.Location = New Point(14, 12)
        Guna2HtmlLabel1.Margin = New Padding(3, 4, 3, 4)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(383, 48)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "ATTENDANCE HISTORY"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblStudentProgram)
        Panel1.Controls.Add(lblStudentFullName)
        Panel1.Controls.Add(lblStudProgram)
        Panel1.Controls.Add(lblStudentFullN)
        Panel1.Location = New Point(3, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(376, 225)
        Panel1.TabIndex = 19
        ' 
        ' btnBack
        ' 
        btnBack.BorderRadius = 3
        btnBack.BorderStyle = Drawing2D.DashStyle.Dot
        btnBack.CustomizableEdges = CustomizableEdges1
        btnBack.DisabledState.BorderColor = Color.DarkGray
        btnBack.DisabledState.CustomBorderColor = Color.DarkGray
        btnBack.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBack.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBack.FillColor = Color.Red
        btnBack.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(731, 15)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnBack.Size = New Size(171, 45)
        btnBack.TabIndex = 23
        btnBack.Text = "Back"
        ' 
        ' attendanceHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 483)
        Controls.Add(Panel1)
        Controls.Add(pnlHeader)
        Controls.Add(lblTodayCount)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblFullName)
        Controls.Add(dvgAttendanceHistory)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "attendanceHistory"
        Text = "attendanceHistory"
        CType(dvgAttendanceHistory, ComponentModel.ISupportInitialize).EndInit()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dvgAttendanceHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblFullName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStudentFullName As Label
    Friend WithEvents lblStudentProgram As Label
    Friend WithEvents lblStudentFullN As Label
    Friend WithEvents lblStudProgram As Label
    Friend WithEvents lblTodayCount As Label
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
End Class
