<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Midterm1txt = New System.Windows.Forms.TextBox()
        Me.Midterm2txt = New System.Windows.Forms.TextBox()
        Me.FinalMidtermtxt = New System.Windows.Forms.TextBox()
        Me.CourseGradetxt = New System.Windows.Forms.TextBox()
        Me.CRNtxt = New System.Windows.Forms.TextBox()
        Me.CRNlbl = New System.Windows.Forms.Label()
        Me.CRNComboBox = New System.Windows.Forms.ComboBox()
        Me.CourseDataLSTBOX = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SemesterComBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Crimson
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 254)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Course Grade"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 205)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Final Midterm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 34)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Midterm Midterm 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Crimson
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Midterm Midterm 1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(52, 317)
        Me.Save.Margin = New System.Windows.Forms.Padding(2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(110, 29)
        Me.Save.TabIndex = 8
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close.Location = New System.Drawing.Point(305, 317)
        Me.Close.Margin = New System.Windows.Forms.Padding(2)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(110, 29)
        Me.Close.TabIndex = 9
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(178, 317)
        Me.Reset.Margin = New System.Windows.Forms.Padding(2)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(110, 29)
        Me.Reset.TabIndex = 10
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Midterm1txt
        '
        Me.Midterm1txt.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Midterm1txt.Location = New System.Drawing.Point(233, 109)
        Me.Midterm1txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Midterm1txt.Name = "Midterm1txt"
        Me.Midterm1txt.Size = New System.Drawing.Size(167, 33)
        Me.Midterm1txt.TabIndex = 11
        '
        'Midterm2txt
        '
        Me.Midterm2txt.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Midterm2txt.Location = New System.Drawing.Point(233, 157)
        Me.Midterm2txt.Margin = New System.Windows.Forms.Padding(2)
        Me.Midterm2txt.Name = "Midterm2txt"
        Me.Midterm2txt.Size = New System.Drawing.Size(167, 33)
        Me.Midterm2txt.TabIndex = 12
        '
        'FinalMidtermtxt
        '
        Me.FinalMidtermtxt.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalMidtermtxt.Location = New System.Drawing.Point(233, 205)
        Me.FinalMidtermtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.FinalMidtermtxt.Name = "FinalMidtermtxt"
        Me.FinalMidtermtxt.Size = New System.Drawing.Size(167, 33)
        Me.FinalMidtermtxt.TabIndex = 13
        '
        'CourseGradetxt
        '
        Me.CourseGradetxt.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseGradetxt.Location = New System.Drawing.Point(233, 254)
        Me.CourseGradetxt.Margin = New System.Windows.Forms.Padding(2)
        Me.CourseGradetxt.Name = "CourseGradetxt"
        Me.CourseGradetxt.Size = New System.Drawing.Size(167, 33)
        Me.CourseGradetxt.TabIndex = 14
        '
        'CRNtxt
        '
        Me.CRNtxt.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRNtxt.Location = New System.Drawing.Point(233, 20)
        Me.CRNtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.CRNtxt.Name = "CRNtxt"
        Me.CRNtxt.Size = New System.Drawing.Size(167, 33)
        Me.CRNtxt.TabIndex = 16
        '
        'CRNlbl
        '
        Me.CRNlbl.BackColor = System.Drawing.Color.Crimson
        Me.CRNlbl.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRNlbl.ForeColor = System.Drawing.Color.White
        Me.CRNlbl.Location = New System.Drawing.Point(21, 20)
        Me.CRNlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CRNlbl.Name = "CRNlbl"
        Me.CRNlbl.Size = New System.Drawing.Size(159, 34)
        Me.CRNlbl.TabIndex = 15
        Me.CRNlbl.Text = "CRN"
        Me.CRNlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CRNComboBox
        '
        Me.CRNComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRNComboBox.FormattingEnabled = True
        Me.CRNComboBox.Location = New System.Drawing.Point(438, 25)
        Me.CRNComboBox.Name = "CRNComboBox"
        Me.CRNComboBox.Size = New System.Drawing.Size(360, 32)
        Me.CRNComboBox.TabIndex = 17
        Me.CRNComboBox.Text = "Choose a Class Room Number"
        '
        'CourseDataLSTBOX
        '
        Me.CourseDataLSTBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseDataLSTBOX.FormattingEnabled = True
        Me.CourseDataLSTBOX.ItemHeight = 24
        Me.CourseDataLSTBOX.Location = New System.Drawing.Point(438, 70)
        Me.CourseDataLSTBOX.Name = "CourseDataLSTBOX"
        Me.CourseDataLSTBOX.Size = New System.Drawing.Size(360, 268)
        Me.CourseDataLSTBOX.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Crimson
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 34)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Semester"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SemesterComBox
        '
        Me.SemesterComBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemesterComBox.FormattingEnabled = True
        Me.SemesterComBox.Items.AddRange(New Object() {"Fall2015", "Spring2016"})
        Me.SemesterComBox.Location = New System.Drawing.Point(233, 65)
        Me.SemesterComBox.Name = "SemesterComBox"
        Me.SemesterComBox.Size = New System.Drawing.Size(167, 32)
        Me.SemesterComBox.TabIndex = 21
        Me.SemesterComBox.Text = "Choose One"
        '
        'updateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Close
        Me.ClientSize = New System.Drawing.Size(836, 375)
        Me.Controls.Add(Me.SemesterComBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CourseDataLSTBOX)
        Me.Controls.Add(Me.CRNComboBox)
        Me.Controls.Add(Me.CRNtxt)
        Me.Controls.Add(Me.CRNlbl)
        Me.Controls.Add(Me.CourseGradetxt)
        Me.Controls.Add(Me.FinalMidtermtxt)
        Me.Controls.Add(Me.Midterm2txt)
        Me.Controls.Add(Me.Midterm1txt)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "updateForm"
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Save As Button
    Friend WithEvents Close As Button
    Friend WithEvents Reset As Button
    Friend WithEvents Midterm1txt As TextBox
    Friend WithEvents Midterm2txt As TextBox
    Friend WithEvents FinalMidtermtxt As TextBox
    Friend WithEvents CourseGradetxt As TextBox
    Friend WithEvents CRNtxt As TextBox
    Friend WithEvents CRNlbl As Label
    Friend WithEvents CRNComboBox As ComboBox
    Friend WithEvents CourseDataLSTBOX As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SemesterComBox As ComboBox
End Class
