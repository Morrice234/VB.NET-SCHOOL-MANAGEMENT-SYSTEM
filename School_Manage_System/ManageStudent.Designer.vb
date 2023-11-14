<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudent
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
        Me.ManageStudentDGV = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.ComboGender = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.txtSecondName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.AdminStaffPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtYOA = New System.Windows.Forms.TextBox()
        Me.TxtNationality = New System.Windows.Forms.TextBox()
        CType(Me.ManageStudentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminStaffPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ManageStudentDGV
        '
        Me.ManageStudentDGV.BackgroundColor = System.Drawing.Color.White
        Me.ManageStudentDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ManageStudentDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ManageStudentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ManageStudentDGV.GridColor = System.Drawing.Color.Black
        Me.ManageStudentDGV.Location = New System.Drawing.Point(3, 220)
        Me.ManageStudentDGV.Name = "ManageStudentDGV"
        Me.ManageStudentDGV.Size = New System.Drawing.Size(940, 322)
        Me.ManageStudentDGV.TabIndex = 7
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Gray
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Location = New System.Drawing.Point(758, 146)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(81, 29)
        Me.BtnBack.TabIndex = 2
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Gray
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(671, 111)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(81, 29)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(671, 146)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(81, 29)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Location = New System.Drawing.Point(584, 146)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(81, 29)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Location = New System.Drawing.Point(584, 111)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 29)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'ComboGender
        '
        Me.ComboGender.FormattingEnabled = True
        Me.ComboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboGender.Location = New System.Drawing.Point(414, 57)
        Me.ComboGender.Name = "ComboGender"
        Me.ComboGender.Size = New System.Drawing.Size(147, 21)
        Me.ComboGender.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(361, 156)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(297, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "D.O.B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Surname"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(296, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Second Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(297, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nationality"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "First Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(296, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(317, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Student"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Reg No"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(125, 157)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(147, 20)
        Me.txtSurname.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(414, 125)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(147, 20)
        Me.TxtPassword.TabIndex = 0
        '
        'txtSecondName
        '
        Me.txtSecondName.Location = New System.Drawing.Point(125, 125)
        Me.txtSecondName.Name = "txtSecondName"
        Me.txtSecondName.Size = New System.Drawing.Size(147, 20)
        Me.txtSecondName.TabIndex = 0
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(126, 92)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(146, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtRegNo
        '
        Me.txtRegNo.Location = New System.Drawing.Point(126, 59)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(146, 20)
        Me.txtRegNo.TabIndex = 0
        '
        'AdminStaffPanel
        '
        Me.AdminStaffPanel.Controls.Add(Me.BtnBack)
        Me.AdminStaffPanel.Controls.Add(Me.BtnCancel)
        Me.AdminStaffPanel.Controls.Add(Me.BtnDelete)
        Me.AdminStaffPanel.Controls.Add(Me.BtnUpdate)
        Me.AdminStaffPanel.Controls.Add(Me.BtnAdd)
        Me.AdminStaffPanel.Controls.Add(Me.ComboGender)
        Me.AdminStaffPanel.Controls.Add(Me.DateTimePicker1)
        Me.AdminStaffPanel.Controls.Add(Me.Label8)
        Me.AdminStaffPanel.Controls.Add(Me.Label7)
        Me.AdminStaffPanel.Controls.Add(Me.Label2)
        Me.AdminStaffPanel.Controls.Add(Me.Label11)
        Me.AdminStaffPanel.Controls.Add(Me.Label6)
        Me.AdminStaffPanel.Controls.Add(Me.Label10)
        Me.AdminStaffPanel.Controls.Add(Me.Label5)
        Me.AdminStaffPanel.Controls.Add(Me.Label9)
        Me.AdminStaffPanel.Controls.Add(Me.Label1)
        Me.AdminStaffPanel.Controls.Add(Me.Label4)
        Me.AdminStaffPanel.Controls.Add(Me.txtSurname)
        Me.AdminStaffPanel.Controls.Add(Me.TxtYOA)
        Me.AdminStaffPanel.Controls.Add(Me.TxtNationality)
        Me.AdminStaffPanel.Controls.Add(Me.TxtPassword)
        Me.AdminStaffPanel.Controls.Add(Me.txtSecondName)
        Me.AdminStaffPanel.Controls.Add(Me.txtFirstName)
        Me.AdminStaffPanel.Controls.Add(Me.txtRegNo)
        Me.AdminStaffPanel.Location = New System.Drawing.Point(3, 2)
        Me.AdminStaffPanel.Name = "AdminStaffPanel"
        Me.AdminStaffPanel.Size = New System.Drawing.Size(940, 212)
        Me.AdminStaffPanel.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(582, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y.O.A"
        '
        'TxtYOA
        '
        Me.TxtYOA.Location = New System.Drawing.Point(650, 56)
        Me.TxtYOA.Name = "TxtYOA"
        Me.TxtYOA.Size = New System.Drawing.Size(147, 20)
        Me.TxtYOA.TabIndex = 0
        '
        'TxtNationality
        '
        Me.TxtNationality.Location = New System.Drawing.Point(414, 91)
        Me.TxtNationality.Name = "TxtNationality"
        Me.TxtNationality.Size = New System.Drawing.Size(147, 20)
        Me.TxtNationality.TabIndex = 0
        '
        'ManageStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 547)
        Me.Controls.Add(Me.ManageStudentDGV)
        Me.Controls.Add(Me.AdminStaffPanel)
        Me.Name = "ManageStudent"
        Me.Text = "ManageStudent"
        CType(Me.ManageStudentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminStaffPanel.ResumeLayout(False)
        Me.AdminStaffPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ManageStudentDGV As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents ComboGender As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents txtSecondName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtRegNo As TextBox
    Friend WithEvents AdminStaffPanel As Panel
    Friend WithEvents TxtNationality As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtYOA As TextBox
End Class
