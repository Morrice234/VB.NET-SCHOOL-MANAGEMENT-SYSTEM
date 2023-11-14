<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Me.BtnCourses = New System.Windows.Forms.Button()
        Me.BtnUnits = New System.Windows.Forms.Button()
        Me.BtnRooms = New System.Windows.Forms.Button()
        Me.BtnStudents = New System.Windows.Forms.Button()
        Me.BtnStaff = New System.Windows.Forms.Button()
        Me.BtnDepartments = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdminDGV = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.AdminDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.BtnLogout)
        Me.Panel2.Controls.Add(Me.BtnCourses)
        Me.Panel2.Controls.Add(Me.BtnUnits)
        Me.Panel2.Controls.Add(Me.BtnRooms)
        Me.Panel2.Controls.Add(Me.BtnStudents)
        Me.Panel2.Controls.Add(Me.BtnStaff)
        Me.Panel2.Controls.Add(Me.BtnDepartments)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(-5, -28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(198, 505)
        Me.Panel2.TabIndex = 1
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.White
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLogout.Location = New System.Drawing.Point(12, 446)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(178, 49)
        Me.BtnLogout.TabIndex = 2
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnCourses
        '
        Me.BtnCourses.BackColor = System.Drawing.Color.White
        Me.BtnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCourses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCourses.Location = New System.Drawing.Point(12, 318)
        Me.BtnCourses.Name = "BtnCourses"
        Me.BtnCourses.Size = New System.Drawing.Size(178, 49)
        Me.BtnCourses.TabIndex = 2
        Me.BtnCourses.Text = "Courses"
        Me.BtnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCourses.UseVisualStyleBackColor = False
        '
        'BtnUnits
        '
        Me.BtnUnits.BackColor = System.Drawing.Color.White
        Me.BtnUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUnits.Location = New System.Drawing.Point(12, 373)
        Me.BtnUnits.Name = "BtnUnits"
        Me.BtnUnits.Size = New System.Drawing.Size(178, 49)
        Me.BtnUnits.TabIndex = 2
        Me.BtnUnits.Text = "Units"
        Me.BtnUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUnits.UseVisualStyleBackColor = False
        '
        'BtnRooms
        '
        Me.BtnRooms.BackColor = System.Drawing.Color.White
        Me.BtnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRooms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRooms.Location = New System.Drawing.Point(12, 263)
        Me.BtnRooms.Name = "BtnRooms"
        Me.BtnRooms.Size = New System.Drawing.Size(178, 49)
        Me.BtnRooms.TabIndex = 2
        Me.BtnRooms.Text = "Rooms"
        Me.BtnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRooms.UseVisualStyleBackColor = False
        '
        'BtnStudents
        '
        Me.BtnStudents.BackColor = System.Drawing.Color.White
        Me.BtnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnStudents.Location = New System.Drawing.Point(12, 208)
        Me.BtnStudents.Name = "BtnStudents"
        Me.BtnStudents.Size = New System.Drawing.Size(178, 49)
        Me.BtnStudents.TabIndex = 2
        Me.BtnStudents.Text = "Students"
        Me.BtnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStudents.UseVisualStyleBackColor = False
        '
        'BtnStaff
        '
        Me.BtnStaff.BackColor = System.Drawing.Color.White
        Me.BtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnStaff.Location = New System.Drawing.Point(12, 153)
        Me.BtnStaff.Name = "BtnStaff"
        Me.BtnStaff.Size = New System.Drawing.Size(178, 49)
        Me.BtnStaff.TabIndex = 2
        Me.BtnStaff.Text = "Staff"
        Me.BtnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStaff.UseVisualStyleBackColor = False
        '
        'BtnDepartments
        '
        Me.BtnDepartments.BackColor = System.Drawing.Color.White
        Me.BtnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDepartments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepartments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDepartments.Location = New System.Drawing.Point(12, 98)
        Me.BtnDepartments.Name = "BtnDepartments"
        Me.BtnDepartments.Size = New System.Drawing.Size(178, 49)
        Me.BtnDepartments.TabIndex = 2
        Me.BtnDepartments.Text = "Departments"
        Me.BtnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDepartments.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(234, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 80)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Admin Panel"
        '
        'AdminDGV
        '
        Me.AdminDGV.BackgroundColor = System.Drawing.Color.White
        Me.AdminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDGV.Location = New System.Drawing.Point(199, 69)
        Me.AdminDGV.Name = "AdminDGV"
        Me.AdminDGV.Size = New System.Drawing.Size(795, 408)
        Me.AdminDGV.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-5, -3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1008, 66)
        Me.Panel3.TabIndex = 3
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 479)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AdminDGV)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Panel2.ResumeLayout(False)
        CType(Me.AdminDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents AdminDGV As DataGridView
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnUnits As Button
    Friend WithEvents BtnRooms As Button
    Friend WithEvents BtnStaff As Button
    Friend WithEvents BtnDepartments As Button
    Friend WithEvents BtnCourses As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnStudents As Button
End Class
