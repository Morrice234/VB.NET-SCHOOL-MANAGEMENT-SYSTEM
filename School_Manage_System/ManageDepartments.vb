Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class ManageDepartments
    Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;
                                       AttachDbFilename=D:\projects\VB.NET\db\SchoolManagementSystem.mdf;
                                       Integrated Security=True;Connect Timeout=30")

    Private Sub loadData()
        connection.Open()

        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Department", connection)

        Dim dataSet As DataSet = New DataSet()
        dataAdapter.Fill(dataSet)
        ManageDepartmentsDGV.DataSource = dataSet.Tables(0)
        ManageDepartmentsDGV.MultiSelect = True
        ManageDepartmentsDGV.AllowUserToAddRows = False
        connection.Close()
    End Sub

    Private Sub clearText()
        txtDptId.Clear()
        txtHodId.Clear()
        txtName.Clear()
    End Sub
    Private Sub ManageDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()

    End Sub

    Private Sub BtnBack1_Click(sender As Object, e As EventArgs) Handles BtnBack1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Try
            connection.Open()
            Dim departmentId As Integer = txtDptId.Text
            Dim departmentName As String = txtName.Text
            Dim departmentHod As Integer = txtHodId.Text

            Dim command As SqlCommand = New SqlCommand("INSERT INTO Department(Department_Id, Name, HOD) VALUES('" & departmentId & "', '" & departmentName & "', '" & departmentHod & "')", connection)

            command.ExecuteNonQuery()
            connection.Close()
            loadData()
            clearText()
        Catch ex As MySqlExeption
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim i As Integer
        Dim count As Integer = ManageDepartmentsDGV.SelectedRows.Count
        For i = 0 To count - 1
            Dim departmentId As Integer = ManageDepartmentsDGV.SelectedRows(i).Cells(0).Value
            Dim command As New SqlCommand("DELETE FROM Department WHERE Department_Id = '" & departmentId & "'", connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Next
        loadData()
        clearText()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        clearText()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim i As Integer
        Dim count As Integer = ManageDepartmentsDGV.SelectedRows.Count
        Dim dptId As Integer = txtDptId.Text
        Dim departmentName As String = txtName.Text
        Dim departmentHod As Integer = txtHodId.Text

        For i = 0 To count - 1
            Dim departmentId As Integer = ManageDepartmentsDGV.SelectedRows(i).Cells(0).Value
            Dim command As New SqlCommand("UPDATE Department SET Department_Id = '" & dptId & "', Name = '" & departmentName & "', Hod = '" & departmentHod & "' WHERE Department_Id = '" & departmentId & "'", connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Next
        loadData()
        clearText()
    End Sub

    Private Sub ManageDepartmentsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ManageDepartmentsDGV.CellClick
        Dim i As Integer
        Dim count As Integer = ManageDepartmentsDGV.SelectedRows.Count
        For i = 0 To count - 1
            txtDptId.Text = ManageDepartmentsDGV.SelectedRows(i).Cells(0).Value
            txtName.Text = ManageDepartmentsDGV.SelectedRows(i).Cells(1).Value
            txtHodId.Text = ManageDepartmentsDGV.SelectedRows(i).Cells(2).Value
        Next

    End Sub
End Class