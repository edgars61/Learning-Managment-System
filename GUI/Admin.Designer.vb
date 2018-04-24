<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.StudentGridLSTBOX = New System.Windows.Forms.ListBox()
        Me.Gradelbl = New System.Windows.Forms.Label()
        Me.StudentIDlbl = New System.Windows.Forms.Label()
        Me.Semesterlbl = New System.Windows.Forms.Label()
        Me.CRNlbl = New System.Windows.Forms.Label()
        Me.StudentIDtxt = New System.Windows.Forms.TextBox()
        Me.gradeUpdatebtn = New System.Windows.Forms.Button()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.SearchIconBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CRNComboBox = New System.Windows.Forms.ComboBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GPAlbl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentGridLSTBOX
        '
        Me.StudentGridLSTBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentGridLSTBOX.FormattingEnabled = True
        Me.StudentGridLSTBOX.ItemHeight = 24
        Me.StudentGridLSTBOX.Location = New System.Drawing.Point(29, 58)
        Me.StudentGridLSTBOX.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentGridLSTBOX.Name = "StudentGridLSTBOX"
        Me.StudentGridLSTBOX.Size = New System.Drawing.Size(320, 244)
        Me.StudentGridLSTBOX.TabIndex = 0
        '
        'Gradelbl
        '
        Me.Gradelbl.BackColor = System.Drawing.Color.Crimson
        Me.Gradelbl.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gradelbl.ForeColor = System.Drawing.Color.White
        Me.Gradelbl.Location = New System.Drawing.Point(29, 22)
        Me.Gradelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Gradelbl.Name = "Gradelbl"
        Me.Gradelbl.Size = New System.Drawing.Size(211, 34)
        Me.Gradelbl.TabIndex = 1
        Me.Gradelbl.Text = "Grade Table"
        Me.Gradelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentIDlbl
        '
        Me.StudentIDlbl.BackColor = System.Drawing.Color.Crimson
        Me.StudentIDlbl.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentIDlbl.ForeColor = System.Drawing.Color.White
        Me.StudentIDlbl.Location = New System.Drawing.Point(374, 22)
        Me.StudentIDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StudentIDlbl.Name = "StudentIDlbl"
        Me.StudentIDlbl.Size = New System.Drawing.Size(159, 34)
        Me.StudentIDlbl.TabIndex = 2
        Me.StudentIDlbl.Text = "Student ID"
        Me.StudentIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Semesterlbl
        '
        Me.Semesterlbl.BackColor = System.Drawing.Color.Crimson
        Me.Semesterlbl.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Semesterlbl.ForeColor = System.Drawing.Color.White
        Me.Semesterlbl.Location = New System.Drawing.Point(374, 185)
        Me.Semesterlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Semesterlbl.Name = "Semesterlbl"
        Me.Semesterlbl.Size = New System.Drawing.Size(159, 34)
        Me.Semesterlbl.TabIndex = 3
        Me.Semesterlbl.Text = "Semester"
        Me.Semesterlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CRNlbl
        '
        Me.CRNlbl.BackColor = System.Drawing.Color.Crimson
        Me.CRNlbl.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRNlbl.ForeColor = System.Drawing.Color.White
        Me.CRNlbl.Location = New System.Drawing.Point(374, 103)
        Me.CRNlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CRNlbl.Name = "CRNlbl"
        Me.CRNlbl.Size = New System.Drawing.Size(159, 34)
        Me.CRNlbl.TabIndex = 4
        Me.CRNlbl.Text = "CRN"
        Me.CRNlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentIDtxt
        '
        Me.StudentIDtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentIDtxt.Location = New System.Drawing.Point(373, 58)
        Me.StudentIDtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentIDtxt.Name = "StudentIDtxt"
        Me.StudentIDtxt.Size = New System.Drawing.Size(126, 29)
        Me.StudentIDtxt.TabIndex = 5
        '
        'gradeUpdatebtn
        '
        Me.gradeUpdatebtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gradeUpdatebtn.Location = New System.Drawing.Point(373, 263)
        Me.gradeUpdatebtn.Margin = New System.Windows.Forms.Padding(2)
        Me.gradeUpdatebtn.Name = "gradeUpdatebtn"
        Me.gradeUpdatebtn.Size = New System.Drawing.Size(161, 33)
        Me.gradeUpdatebtn.TabIndex = 8
        Me.gradeUpdatebtn.Text = "Update"
        Me.gradeUpdatebtn.UseVisualStyleBackColor = True
        '
        'Resetbtn
        '
        Me.Resetbtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetbtn.Location = New System.Drawing.Point(49, 321)
        Me.Resetbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(128, 29)
        Me.Resetbtn.TabIndex = 9
        Me.Resetbtn.Text = "Reset"
        Me.Resetbtn.UseVisualStyleBackColor = True
        '
        'Closebtn
        '
        Me.Closebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Closebtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closebtn.Location = New System.Drawing.Point(198, 321)
        Me.Closebtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(122, 29)
        Me.Closebtn.TabIndex = 10
        Me.Closebtn.Text = "Close"
        Me.Closebtn.UseVisualStyleBackColor = True
        '
        'SearchIconBtn
        '
        Me.SearchIconBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SearchIconBtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchIconBtn.Image = CType(resources.GetObject("SearchIconBtn.Image"), System.Drawing.Image)
        Me.SearchIconBtn.Location = New System.Drawing.Point(504, 57)
        Me.SearchIconBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchIconBtn.Name = "SearchIconBtn"
        Me.SearchIconBtn.Size = New System.Drawing.Size(30, 30)
        Me.SearchIconBtn.TabIndex = 11
        Me.SearchIconBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SemesterComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(364, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 216)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Location = New System.Drawing.Point(10, 131)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(160, 32)
        Me.SemesterComboBox.TabIndex = 15
        Me.SemesterComboBox.Text = "Choose One"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 367)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(573, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel1.Text = "Waiting..."
        '
        'CRNComboBox
        '
        Me.CRNComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRNComboBox.FormattingEnabled = True
        Me.CRNComboBox.Items.AddRange(New Object() {"CRN 1", "CRN 2", "CRN 3", "CRN 4", "CRN 5"})
        Me.CRNComboBox.Location = New System.Drawing.Point(373, 144)
        Me.CRNComboBox.Name = "CRNComboBox"
        Me.CRNComboBox.Size = New System.Drawing.Size(160, 32)
        Me.CRNComboBox.TabIndex = 14
        Me.CRNComboBox.Text = "Choose One"
        '
        'AddBtn
        '
        Me.AddBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AddBtn.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(376, 321)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(155, 29)
        Me.AddBtn.TabIndex = 15
        Me.AddBtn.Text = "Add Student"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(244, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 34)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "GPA:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GPAlbl
        '
        Me.GPAlbl.AutoSize = True
        Me.GPAlbl.BackColor = System.Drawing.Color.LightGray
        Me.GPAlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GPAlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPAlbl.Location = New System.Drawing.Point(301, 26)
        Me.GPAlbl.Name = "GPAlbl"
        Me.GPAlbl.Size = New System.Drawing.Size(47, 26)
        Me.GPAlbl.TabIndex = 17
        Me.GPAlbl.Text = "0.00"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Closebtn
        Me.ClientSize = New System.Drawing.Size(573, 389)
        Me.Controls.Add(Me.GPAlbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.CRNComboBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SearchIconBtn)
        Me.Controls.Add(Me.Closebtn)
        Me.Controls.Add(Me.Resetbtn)
        Me.Controls.Add(Me.gradeUpdatebtn)
        Me.Controls.Add(Me.StudentIDtxt)
        Me.Controls.Add(Me.CRNlbl)
        Me.Controls.Add(Me.Semesterlbl)
        Me.Controls.Add(Me.StudentIDlbl)
        Me.Controls.Add(Me.Gradelbl)
        Me.Controls.Add(Me.StudentGridLSTBOX)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentGridLSTBOX As ListBox
    Friend WithEvents Gradelbl As Label
    Friend WithEvents StudentIDlbl As Label
    Friend WithEvents Semesterlbl As Label
    Friend WithEvents CRNlbl As Label
    Friend WithEvents gradeUpdatebtn As Button
    Friend WithEvents Resetbtn As Button
    Friend WithEvents Closebtn As Button
    Friend WithEvents SearchIconBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SemesterComboBox As ComboBox
    Public WithEvents CRNComboBox As ComboBox
    Public WithEvents StudentIDtxt As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GPAlbl As Label
End Class
