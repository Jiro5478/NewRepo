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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        CType(dvgAttendanceHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dvgAttendanceHistory
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dvgAttendanceHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dvgAttendanceHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dvgAttendanceHistory.ColumnHeadersHeight = 4
        dvgAttendanceHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dvgAttendanceHistory.DefaultCellStyle = DataGridViewCellStyle6
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
        lblFullName.Location = New Point(123, 214)
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
        Label1.Location = New Point(245, 214)
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
        Label2.Location = New Point(365, 214)
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
        Label3.Location = New Point(477, 214)
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
        Label4.Location = New Point(552, 214)
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
        Label5.Location = New Point(427, 356)
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
        lblAttendance.Font = New Font("Segoe UI", 20F)
        lblAttendance.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblAttendance.Location = New Point(19, 9)
        lblAttendance.Margin = New Padding(4, 0, 4, 0)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(243, 37)
        lblAttendance.TabIndex = 12
        lblAttendance.Text = "Attendance History"
        ' 
        ' lblStudentFullName
        ' 
        lblStudentFullName.Anchor = AnchorStyles.None
        lblStudentFullName.AutoSize = True
        lblStudentFullName.Font = New Font("Segoe UI", 10F)
        lblStudentFullName.ForeColor = Color.FromArgb(CByte(127), CByte(140), CByte(141))
        lblStudentFullName.Location = New Point(19, 51)
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
        lblStudentProgram.Location = New Point(19, 70)
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
        lblStudentFullN.Location = New Point(145, 51)
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
        lblStudProgram.Location = New Point(145, 70)
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
        ' attendanceHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTodayCount)
        Controls.Add(lblStudProgram)
        Controls.Add(lblStudentFullN)
        Controls.Add(lblStudentProgram)
        Controls.Add(lblStudentFullName)
        Controls.Add(lblAttendance)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblFullName)
        Controls.Add(dvgAttendanceHistory)
        Name = "attendanceHistory"
        Text = "attendanceHistory"
        CType(dvgAttendanceHistory, ComponentModel.ISupportInitialize).EndInit()
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
End Class
