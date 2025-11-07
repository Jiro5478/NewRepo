<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SAFacultyList
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        FLpnlHead = New Guna.UI2.WinForms.Guna2GradientPanel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        SAdgvFacList = New Guna.UI2.WinForms.Guna2DataGridView()
        pnlMain.SuspendLayout()
        FLpnlHead.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        CType(SAdgvFacList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(FLpnlHead)
        pnlMain.CustomizableEdges = CustomizableEdges5
        pnlMain.Dock = DockStyle.Top
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlMain.Size = New Size(1111, 100)
        pnlMain.TabIndex = 0
        ' 
        ' FLpnlHead
        ' 
        FLpnlHead.Controls.Add(Guna2HtmlLabel1)
        FLpnlHead.CustomizableEdges = CustomizableEdges3
        FLpnlHead.Dock = DockStyle.Bottom
        FLpnlHead.FillColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        FLpnlHead.Location = New Point(0, -9)
        FLpnlHead.Name = "FLpnlHead"
        FLpnlHead.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        FLpnlHead.Size = New Size(1111, 109)
        FLpnlHead.TabIndex = 1
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.Transparent
        Guna2HtmlLabel1.Location = New Point(32, 40)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(113, 30)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "Faculty List"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(SAdgvFacList)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 100)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(1111, 646)
        Guna2Panel1.TabIndex = 1
        ' 
        ' SAdgvFacList
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        SAdgvFacList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        SAdgvFacList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        SAdgvFacList.ColumnHeadersHeight = 4
        SAdgvFacList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        SAdgvFacList.DefaultCellStyle = DataGridViewCellStyle3
        SAdgvFacList.Dock = DockStyle.Fill
        SAdgvFacList.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        SAdgvFacList.Location = New Point(0, 0)
        SAdgvFacList.Name = "SAdgvFacList"
        SAdgvFacList.RowHeadersVisible = False
        SAdgvFacList.Size = New Size(1111, 646)
        SAdgvFacList.TabIndex = 0
        SAdgvFacList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        SAdgvFacList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        SAdgvFacList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        SAdgvFacList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        SAdgvFacList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        SAdgvFacList.ThemeStyle.BackColor = Color.White
        SAdgvFacList.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        SAdgvFacList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        SAdgvFacList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        SAdgvFacList.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        SAdgvFacList.ThemeStyle.HeaderStyle.ForeColor = Color.White
        SAdgvFacList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        SAdgvFacList.ThemeStyle.HeaderStyle.Height = 4
        SAdgvFacList.ThemeStyle.ReadOnly = False
        SAdgvFacList.ThemeStyle.RowsStyle.BackColor = Color.White
        SAdgvFacList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        SAdgvFacList.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        SAdgvFacList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        SAdgvFacList.ThemeStyle.RowsStyle.Height = 25
        SAdgvFacList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        SAdgvFacList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' SAFacultyList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1111, 746)
        Controls.Add(Guna2Panel1)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.None
        Name = "SAFacultyList"
        Text = "SAFacultyList"
        pnlMain.ResumeLayout(False)
        FLpnlHead.ResumeLayout(False)
        FLpnlHead.PerformLayout()
        Guna2Panel1.ResumeLayout(False)
        CType(SAdgvFacList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents FLpnlHead As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SAdgvFacList As Guna.UI2.WinForms.Guna2DataGridView
End Class
