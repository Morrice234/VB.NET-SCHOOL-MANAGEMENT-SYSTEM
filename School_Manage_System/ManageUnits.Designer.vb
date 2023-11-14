<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUnits
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
        Me.AdminStaffPanel = New System.Windows.Forms.Panel()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHomeDept = New System.Windows.Forms.TextBox()
        Me.txtCreditUnit = New System.Windows.Forms.TextBox()
        Me.txtUnitName = New System.Windows.Forms.TextBox()
        Me.txtUnitCode = New System.Windows.Forms.TextBox()
        Me.ManageUnitsDGV = New System.Windows.Forms.DataGridView()
        Me.AdminStaffPanel.SuspendLayout()
        CType(Me.ManageUnitsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminStaffPanel
        '
        Me.AdminStaffPanel.Controls.Add(Me.BtnBack)
        Me.AdminStaffPanel.Controls.Add(Me.BtnCancel)
        Me.AdminStaffPanel.Controls.Add(Me.BtnDelete)
        Me.AdminStaffPanel.Controls.Add(Me.BtnUpdate)
        Me.AdminStaffPanel.Controls.Add(Me.BtnAdd)
        Me.AdminStaffPanel.Controls.Add(Me.Label7)
        Me.AdminStaffPanel.Controls.Add(Me.Label6)
        Me.AdminStaffPanel.Controls.Add(Me.Label5)
        Me.AdminStaffPanel.Controls.Add(Me.Label1)
        Me.AdminStaffPanel.Controls.Add(Me.Label4)
        Me.AdminStaffPanel.Controls.Add(Me.txtHomeDept)
        Me.AdminStaffPanel.Controls.Add(Me.txtCreditUnit)
        Me.AdminStaffPanel.Controls.Add(Me.txtUnitName)
        Me.AdminStaffPanel.Controls.Add(Me.txtUnitCode)
        Me.AdminStaffPanel.Location = New System.Drawing.Point(5, -2)
        Me.AdminStaffPanel.Name = "AdminStaffPanel"
        Me.AdminStaffPanel.Size = New System.Drawing.Size(659, 201)
        Me.AdminStaffPanel.TabIndex = 8
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Gray
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Location = New System.Drawing.Point(495, 103)
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
        Me.BtnCancel.Location = New System.Drawing.Point(495, 54)
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
        Me.BtnDelete.Location = New System.Drawing.Point(374, 149)
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
        Me.BtnUpdate.Location = New System.Drawing.Point(374, 103)
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
        Me.BtnAdd.Location = New System.Drawing.Point(374, 55)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 29)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Home Dept"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Credit Units"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Unit Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(246, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Units"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Unit Code"
        '
        'txtHomeDept
        '
        Me.txtHomeDept.Location = New System.Drawing.Point(178, 157)
        Me.txtHomeDept.Name = "txtHomeDept"
        Me.txtHomeDept.Size = New System.Drawing.Size(147, 20)
        Me.txtHomeDept.TabIndex = 0
        '
        'txtCreditUnit
        '
        Me.txtCreditUnit.Location = New System.Drawing.Point(178, 125)
        Me.txtCreditUnit.Name = "txtCreditUnit"
        Me.txtCreditUnit.Size = New System.Drawing.Size(147, 20)
        Me.txtCreditUnit.TabIndex = 0
        '
        'txtUnitName
        '
        Me.txtUnitName.Location = New System.Drawing.Point(179, 92)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(146, 20)
        Me.txtUnitName.TabIndex = 0
        '
        'txtUnitCode
        '
        Me.txtUnitCode.Location = New System.Drawing.Point(179, 59)
        Me.txtUnitCode.Name = "txtUnitCode"
        Me.txtUnitCode.Size = New System.Drawing.Size(146, 20)
        Me.txtUnitCode.TabIndex = 0
        '
        'ManageUnitsDGV
        '
        Me.ManageUnitsDGV.BackgroundColor = System.Drawing.Color.White
        Me.ManageUnitsDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ManageUnitsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ManageUnitsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ManageUnitsDGV.GridColor = System.Drawing.Color.Black
        Me.ManageUnitsDGV.Location = New System.Drawing.Point(5, 205)
        Me.ManageUnitsDGV.Name = "ManageUnitsDGV"
        Me.ManageUnitsDGV.Size = New System.Drawing.Size(659, 340)
        Me.ManageUnitsDGV.TabIndex = 9
        '
        'ManageUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 552)
        Me.Controls.Add(Me.AdminStaffPanel)
        Me.Controls.Add(Me.ManageUnitsDGV)
        Me.Name = "ManageUnits"
        Me.Text = "ManageUnits"
        Me.AdminStaffPanel.ResumeLayout(False)
        Me.AdminStaffPanel.PerformLayout()
        CType(Me.ManageUnitsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminStaffPanel As Panel
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHomeDept As TextBox
    Friend WithEvents txtCreditUnit As TextBox
    Friend WithEvents txtUnitName As TextBox
    Friend WithEvents txtUnitCode As TextBox
    Friend WithEvents ManageUnitsDGV As DataGridView
End Class
