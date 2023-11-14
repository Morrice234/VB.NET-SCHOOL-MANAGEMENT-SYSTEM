<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageRooms
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoomId = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRoomId = New System.Windows.Forms.TextBox()
        Me.ManageRoomsDGV = New System.Windows.Forms.DataGridView()
        Me.DepartmentPanel.SuspendLayout()
        CType(Me.ManageRoomsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DepartmentPanel.Controls.Add(Me.Label1)
        Me.DepartmentPanel.Controls.Add(Me.Label2)
        Me.DepartmentPanel.Controls.Add(Me.RoomId)
        Me.DepartmentPanel.Controls.Add(Me.txtCapacity)
        Me.DepartmentPanel.Controls.Add(Me.txtName)
        Me.DepartmentPanel.Controls.Add(Me.txtRoomId)
        Me.DepartmentPanel.Location = New System.Drawing.Point(12, 12)
        Me.DepartmentPanel.Name = "DepartmentPanel"
        Me.DepartmentPanel.Size = New System.Drawing.Size(669, 184)
        Me.DepartmentPanel.TabIndex = 6
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
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Capacity"
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
        'RoomId
        '
        Me.RoomId.AutoSize = True
        Me.RoomId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomId.Location = New System.Drawing.Point(12, 37)
        Me.RoomId.Name = "RoomId"
        Me.RoomId.Size = New System.Drawing.Size(77, 20)
        Me.RoomId.TabIndex = 1
        Me.RoomId.Text = "Room Id"
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(143, 126)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(166, 20)
        Me.txtCapacity.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(143, 81)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 20)
        Me.txtName.TabIndex = 0
        '
        'txtRoomId
        '
        Me.txtRoomId.Location = New System.Drawing.Point(143, 37)
        Me.txtRoomId.Name = "txtRoomId"
        Me.txtRoomId.Size = New System.Drawing.Size(166, 20)
        Me.txtRoomId.TabIndex = 0
        '
        'ManageRoomsDGV
        '
        Me.ManageRoomsDGV.BackgroundColor = System.Drawing.Color.White
        Me.ManageRoomsDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ManageRoomsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ManageRoomsDGV.Location = New System.Drawing.Point(13, 203)
        Me.ManageRoomsDGV.Name = "ManageRoomsDGV"
        Me.ManageRoomsDGV.Size = New System.Drawing.Size(668, 246)
        Me.ManageRoomsDGV.TabIndex = 7
        '
        'ManageRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 450)
        Me.Controls.Add(Me.DepartmentPanel)
        Me.Controls.Add(Me.ManageRoomsDGV)
        Me.Name = "ManageRooms"
        Me.Text = "ManageRooms"
        Me.DepartmentPanel.ResumeLayout(False)
        Me.DepartmentPanel.PerformLayout()
        CType(Me.ManageRoomsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DepartmentPanel As Panel
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnBack1 As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RoomId As Label
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRoomId As TextBox
    Friend WithEvents ManageRoomsDGV As DataGridView
    Friend WithEvents Label1 As Label
End Class
