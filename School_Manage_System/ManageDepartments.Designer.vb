<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageDepartments
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
        Me.DepartmentPanel = New System.Windows.Forms.Panel()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnBack1 = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DptId = New System.Windows.Forms.Label()
        Me.txtHodId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDptId = New System.Windows.Forms.TextBox()
        Me.ManageDepartmentsDGV = New System.Windows.Forms.DataGridView()
        Me.DepartmentPanel.SuspendLayout()
        CType(Me.ManageDepartmentsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentPanel
        '
        Me.DepartmentPanel.BackColor = System.Drawing.Color.White
        Me.DepartmentPanel.Controls.Add(Me.BtnUpdate)
        Me.DepartmentPanel.Controls.Add(Me.BtnAdd)
        Me.DepartmentPanel.Controls.Add(Me.BtnBack1)
        Me.DepartmentPanel.Controls.Add(Me.BtnCancel)
        Me.DepartmentPanel.Controls.Add(Me.BtnDelete)
        Me.DepartmentPanel.Controls.Add(Me.Label3)
        Me.DepartmentPanel.Controls.Add(Me.Label2)
        Me.DepartmentPanel.Controls.Add(Me.DptId)
        Me.DepartmentPanel.Controls.Add(Me.txtHodId)
        Me.DepartmentPanel.Controls.Add(Me.txtName)
        Me.DepartmentPanel.Controls.Add(Me.txtDptId)
        Me.DepartmentPanel.Location = New System.Drawing.Point(12, 12)
        Me.DepartmentPanel.Name = "DepartmentPanel"
        Me.DepartmentPanel.Size = New System.Drawing.Size(669, 184)
        Me.DepartmentPanel.TabIndex = 4
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Location = New System.Drawing.Point(453, 28)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(81, 29)
        Me.BtnUpdate.TabIndex = 8
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Location = New System.Drawing.Point(352, 28)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 29)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnBack1
        '
        Me.BtnBack1.BackColor = System.Drawing.Color.Gray
        Me.BtnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack1.Location = New System.Drawing.Point(570, 117)
        Me.BtnBack1.Name = "BtnBack1"
        Me.BtnBack1.Size = New System.Drawing.Size(81, 29)
        Me.BtnBack1.TabIndex = 4
        Me.BtnBack1.Text = "Back"
        Me.BtnBack1.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Gray
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(453, 117)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(81, 29)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(353, 117)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(81, 29)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "HOD Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'DptId
        '
        Me.DptId.AutoSize = True
        Me.DptId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DptId.Location = New System.Drawing.Point(12, 37)
        Me.DptId.Name = "DptId"
        Me.DptId.Size = New System.Drawing.Size(125, 20)
        Me.DptId.TabIndex = 1
        Me.DptId.Text = "Department Id"
        '
        'txtHodId
        '
        Me.txtHodId.Location = New System.Drawing.Point(143, 126)
        Me.txtHodId.Name = "txtHodId"
        Me.txtHodId.Size = New System.Drawing.Size(166, 20)
        Me.txtHodId.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(143, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 20)
        Me.txtName.TabIndex = 0
        '
        'txtDptId
        '
        Me.txtDptId.Location = New System.Drawing.Point(143, 37)
        Me.txtDptId.Name = "txtDptId"
        Me.txtDptId.Size = New System.Drawing.Size(166, 20)
        Me.txtDptId.TabIndex = 0
        '
        'ManageDepartmentsDGV
        '
        Me.ManageDepartmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ManageDepartmentsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ManageDepartmentsDGV.BackgroundColor = System.Drawing.Color.White
        Me.ManageDepartmentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ManageDepartmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ManageDepartmentsDGV.Location = New System.Drawing.Point(13, 203)
        Me.ManageDepartmentsDGV.Name = "ManageDepartmentsDGV"
        Me.ManageDepartmentsDGV.Size = New System.Drawing.Size(668, 246)
        Me.ManageDepartmentsDGV.TabIndex = 5
        '
        'ManageDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 450)
        Me.Controls.Add(Me.ManageDepartmentsDGV)
        Me.Controls.Add(Me.DepartmentPanel)
        Me.Name = "ManageDepartments"
        Me.Text = "ManageDepartments"
        Me.DepartmentPanel.ResumeLayout(False)
        Me.DepartmentPanel.PerformLayout()
        CType(Me.ManageDepartmentsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DepartmentPanel As Panel
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DptId As Label
    Friend WithEvents txtHodId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDptId As TextBox
    Friend WithEvents ManageDepartmentsDGV As DataGridView
    Friend WithEvents BtnBack1 As Button
End Class
