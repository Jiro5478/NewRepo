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
        lblAttendance = New Label()
        lblStudentFullName = New Label()
        lblStudentProgram = New Label()
        lblStudentFullN = New Label()
        lblStudProgram = New Label()
        lblTodayCount = New Label()
        Guna2PnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(dvgAttendanceHistory, ComponentModel.ISupportInitialize).BeginInit()
        Guna2PnlHeader.SuspendLayout()
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
        dvgAttendanceHistory.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dvgAttendanceHistory.Location = New Point(109, 205)
        dvgAttendanceHistory.Name = "dvgAttendanceHistory"
        dvgAttendanceHistory.RowHeadersVisible = False
        dvgAttendanceHistory.Size = New Size(511, 129)
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
        lblFullName.Location = New Point(192, 248)
        lblFullName.Margin = New Padding(4, 0, 4, 0)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(105, 21)
        lblFullName.TabIndex = 6
        lblFullName.Text = "Course Code"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(314, 248)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 21)
        Label1.TabIndex = 7
        Label1.Text = "Course Name"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label2.Location = New Point(434, 248)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 21)
        Label2.TabIndex = 8
        Label2.Text = "Course Time"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label3.Location = New Point(546, 248)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 21)
        Label3.TabIndex = 9
        Label3.Text = "Time In"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label4.Location = New Point(621, 248)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 21)
        Label4.TabIndex = 10
        Label4.Text = "Status"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label5.Location = New Point(496, 390)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(233, 21)
        Label5.TabIndex = 11
        Label5.Text = "(present,absent,late,excused)"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.Anchor = AnchorStyles.None
        lblAttendance.AutoSize = True
        lblAttendance.BackColor = Color.Transparent
        lblAttendance.Font = New Font("Segoe UI Variable Display", 24F, FontStyle.Bold)
        lblAttendance.ForeColor = Color.Transparent
        lblAttendance.Location = New Point(14, 12)
        lblAttendance.Margin = New Padding(4, 0, 4, 0)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(312, 43)
        lblAttendance.TabIndex = 12
        lblAttendance.Text = "Attendance History"
        ' 
        ' lblStudentFullName
        ' 
        lblStudentFullName.Anchor = AnchorStyles.None
        lblStudentFullName.AutoSize = True
        lblStudentFullName.Font = New Font("Segoe UI", 10F)
        lblStudentFullName.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudentFullName.Location = New Point(102, 394)
        lblStudentFullName.Margin = New Padding(4, 0, 4, 0)
        lblStudentFullName.Name = "lblStudentFullName"
        lblStudentFullName.Size = New Size(118, 19)
        lblStudentFullName.TabIndex = 13
        lblStudentFullName.Text = "Student FullName"
        ' 
        ' lblStudentProgram
        ' 
        lblStudentProgram.Anchor = AnchorStyles.None
        lblStudentProgram.AutoSize = True
        lblStudentProgram.Font = New Font("Segoe UI", 10F)
        lblStudentProgram.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudentProgram.Location = New Point(105, 413)
        lblStudentProgram.Margin = New Padding(4, 0, 4, 0)
        lblStudentProgram.Name = "lblStudentProgram"
        lblStudentProgram.Size = New Size(114, 19)
        lblStudentProgram.TabIndex = 14
        lblStudentProgram.Text = "Student Program"
        ' 
        ' lblStudentFullN
        ' 
        lblStudentFullN.Anchor = AnchorStyles.None
        lblStudentFullN.AutoSize = True
        lblStudentFullN.Font = New Font("Segoe UI", 10F)
        lblStudentFullN.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudentFullN.Location = New Point(234, 394)
        lblStudentFullN.Margin = New Padding(4, 0, 4, 0)
        lblStudentFullN.Name = "lblStudentFullN"
        lblStudentFullN.Size = New Size(118, 19)
        lblStudentFullN.TabIndex = 15
        lblStudentFullN.Text = "Student FullName"
        ' 
        ' lblStudProgram
        ' 
        lblStudProgram.Anchor = AnchorStyles.None
        lblStudProgram.AutoSize = True
        lblStudProgram.Font = New Font("Segoe UI", 10F)
        lblStudProgram.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudProgram.Location = New Point(234, 413)
        lblStudProgram.Margin = New Padding(4, 0, 4, 0)
        lblStudProgram.Name = "lblStudProgram"
        lblStudProgram.Size = New Size(118, 19)
        lblStudProgram.TabIndex = 16
        lblStudProgram.Text = "Student FullName"
        ' 
        ' lblTodayCount
        ' 
        lblTodayCount.AutoSize = True
        lblTodayCount.Location = New Point(109, 176)
        lblTodayCount.Name = "lblTodayCount"
        lblTodayCount.Size = New Size(165, 15)
        lblTodayCount.TabIndex = 17
        lblTodayCount.Text = "Today's Attendance: 0 records"
        ' 
        ' Guna2PnlHeader
        ' 
        Guna2PnlHeader.Controls.Add(Guna2Button1)
        Guna2PnlHeader.Controls.Add(lblAttendance)
        Guna2PnlHeader.CustomizableEdges = CustomizableEdges3
        Guna2PnlHeader.Dock = DockStyle.Top
        Guna2PnlHeader.FillColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Guna2PnlHeader.Location = New Point(0, 0)
        Guna2PnlHeader.Name = "Guna2PnlHeader"
        Guna2PnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2PnlHeader.Size = New Size(938, 80)
        Guna2PnlHeader.TabIndex = 38
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
        Guna2Button1.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Bold)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(775, 21)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(150, 34)
        Guna2Button1.TabIndex = 22
        Guna2Button1.Text = "Back"
        ' 
        ' attendanceHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(938, 519)
        ControlBox = False
        Controls.Add(Guna2PnlHeader)
        Controls.Add(lblTodayCount)
        Controls.Add(lblStudProgram)
        Controls.Add(lblStudentFullN)
        Controls.Add(lblStudentProgram)
        Controls.Add(lblStudentFullName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblFullName)
        Controls.Add(dvgAttendanceHistory)
        FormBorderStyle = FormBorderStyle.None
        Name = "attendanceHistory"
        Text = "attendanceHistory"
        CType(dvgAttendanceHistory, ComponentModel.ISupportInitialize).EndInit()
        Guna2PnlHeader.ResumeLayout(False)
        Guna2PnlHeader.PerformLayout()
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
    Friend WithEvents lblAttendance As Label
    Friend WithEvents lblStudentFullName As Label
    Friend WithEvents lblStudentProgram As Label
    Friend WithEvents lblStudentFullN As Label
    Friend WithEvents lblStudProgram As Label
    Friend WithEvents lblTodayCount As Label
    Friend WithEvents Guna2PnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
