Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class ManageUser
    Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=D:\projects\VB.NET\db\SchoolManagementSystem.mdf;
                                        Integrated Security=True;Connect Timeout=30")

    Private Sub clearText()
        txtStaffId.Clear()
        txtFirstName.Clear()
        txtSecondName.Clear()
        ComboRank.SelectedItem = ""
        TxtPassword.Clear()
        txtDepartmentId.Clear()
    End Sub

    Private Sub loadStaff()
        connection.Open()

        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Staff", connection)

        Dim dataSet As DataSet = New DataSet()
        dataAdapter.Fill(dataSet)
        ManageStaffDGV.DataSource = dataSet.Tables(0)
        ManageStaffDGV.AllowUserToAddRows = False
        connection.Close()

    End Sub
    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStaff()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim i As Integer
        Dim count As Integer = ManageStaffDGV.SelectedRows.Count
        For i = 0 To count - 1
            Dim staffId As Integer = ManageStaffDGV.SelectedRows(i).Cells(0).Value
            Dim command As New SqlCommand("DELETE FROM Staff WHERE Staff_Id = '" & staffId & "'", connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Next
        loadStaff()
        clearText()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        clearText()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim staffId As Integer = txtStaffId.Text
        Dim firstName As String = txtFirstName.Text
        Dim secondName As String = txtSecondName.Text
        Dim rank As String = ComboRank.SelectedItem
        Dim gender As String = ComboGender.SelectedItem
        Dim dob As String = DateTimePicker1.Text
        Dim departmentId As Integer = txtDepartmentId.Text
        Dim password As String = TxtPassword.Text

        Dim command As New SqlCommand("INSERT INTO Staff(Staff_Id, First_Name, Second_Name, Rank, DOB, Gender, Department_Id, Password)
                                        VALUES('" & staffId & "', '" & firstName & "', '" & secondName & "',
                                        '" & rank & "', '" & dob & "', '" & gender & "', '" & departmentId & "', '" & password & "')", connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        loadStaff()
        clearText()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim staffId As Integer = txtStaffId.Text
        Dim firstName As String = txtFirstName.Text
        Dim secondName As String = txtSecondName.Text
        Dim rank As String = ComboRank.SelectedItem
        Dim gender As String = ComboGender.SelectedItem
        Dim dob As String = DateTimePicker1.Text
        Dim departmentId As Integer = txtDepartmentId.Text
        Dim password As String = TxtPassword.Text
        Dim i As Integer
        Dim count As Integer = ManageStaffDGV.SelectedRows.Count

        For i = 0 To count - 1
            Dim staff_Id As Integer = ManageStaffDGV.SelectedRows(i).Cells(0).Value

            Dim command As New SqlCommand("UPDATE Staff SET Staff_Id = '" & staffId & "', First_Name = '" & firstName & "', Second_Name = '" & secondName & "',
                                            Rank = '" & rank & "', DOB = '" & dob & "', Gender = '" & gender & "', Department_Id = '" & departmentId & "', Password = '" & password & "'
                                            WHERE Staff_Id = '" & staff_Id & "'", connection)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

        Next
        loadStaff()
        clearText()
    End Sub

    Private Sub ManageStaffDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ManageStaffDGV.CellClick
        Dim i As Integer
        Dim count As Integer = ManageStaffDGV.SelectedRows.Count

        For i = 0 To count - 1
            txtStaffId.Text = ManageStaffDGV.SelectedRows(i).Cells(0).Value
            txtFirstName.Text = ManageStaffDGV.SelectedRows(i).Cells(1).Value
            txtSecondName.Text = ManageStaffDGV.SelectedRows(i).Cells(2).Value
            ComboRank.SelectedItem = ManageStaffDGV.SelectedRows(i).Cells(3).Value
            DateTimePicker1.Text = ManageStaffDGV.SelectedRows(i).Cells(4).Value
            ComboGender.SelectedItem = ManageStaffDGV.SelectedRows(i).Cells(5).Value
            txtDepartmentId.Text = ManageStaffDGV.SelectedRows(i).Cells(6).Value
            TxtPassword.Text = ManageStaffDGV.SelectedRows(i).Cells(7).Value
        Next
    End Sub
End Class