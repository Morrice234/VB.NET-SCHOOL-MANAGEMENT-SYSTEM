<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnComplaint = New System.Windows.Forms.Button()
        Me.BtnTimeTable = New System.Windows.Forms.Button()
        Me.BtnResults = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.BtnLogout)
        Me.Panel2.Controls.Add(Me.BtnComplaint)
        Me.Panel2.Controls.Add(Me.BtnTimeTable)
        Me.Panel2.Controls.Add(Me.BtnResults)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(-9, -26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(198, 415)
        Me.Panel2.TabIndex = 2
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.White
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLogout.Location = New System.Drawing.Point(12, 356)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(178, 49)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnComplaint
        '
        Me.BtnComplaint.BackColor = System.Drawing.Color.White
        Me.BtnComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComplaint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComplaint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnComplaint.Location = New System.Drawing.Point(12, 204)
        Me.BtnComplaint.Name = "BtnComplaint"
        Me.BtnComplaint.Size = New System.Drawing.Size(178, 49)
        Me.BtnComplaint.TabIndex = 2
        Me.BtnComplaint.Text = "Complaints"
        Me.BtnComplaint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnComplaint.UseVisualStyleBackColor = False
        '
        'BtnTimeTable
        '
        Me.BtnTimeTable.BackColor = System.Drawing.Color.White
        Me.BtnTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTimeTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTimeTable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTimeTable.Location = New System.Drawing.Point(12, 149)
        Me.BtnTimeTable.Name = "BtnTimeTable"
        Me.BtnTimeTable.Size = New System.Drawing.Size(178, 49)
        Me.BtnTimeTable.TabIndex = 2
        Me.BtnTimeTable.Text = "Time Table"
        Me.BtnTimeTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTimeTable.UseVisualStyleBackColor = False
        '
        'BtnResults
        '
        Me.BtnResults.BackColor = System.Drawing.Color.White
        Me.BtnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnResults.Location = New System.Drawing.Point(12, 94)
        Me.BtnResults.Name = "BtnResults"
        Me.BtnResults.Size = New System.Drawing.Size(178, 49)
        Me.BtnResults.TabIndex = 2
        Me.BtnResults.Text = "Results"
        Me.BtnResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResults.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(234, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 80)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-6, -4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(813, 66)
        Me.Panel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Darshboard"
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 386)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Student"
        Me.Text = "Student"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnComplaint As Button
    Friend WithEvents BtnTimeTable As Button
    Friend WithEvents BtnResults As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
