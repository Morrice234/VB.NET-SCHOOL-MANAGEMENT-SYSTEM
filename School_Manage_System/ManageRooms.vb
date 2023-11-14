Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class ManageRooms

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=D:\projects\VB.NET\db\SchoolManagementSystem.mdf;
                                        Integrated Security = True;Connect Timeout=30")

    Private Sub loadRoom()
        connection.Open()

        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Room", connection)

        Dim dataSet As DataSet = New DataSet()
        dataAdapter.Fill(dataSet)
        ManageRoomsDGV.DataSource = dataSet.Tables(0)
        connection.Close()
    End Sub

    Private Sub clearText()
        txtRoomId.Clear()
        txtCapacity.Clear()
        txtName.Clear()
    End Sub
    Private Sub ManageRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRoom()
    End Sub

    Private Sub BtnBack1_Click(sender As Object, e As EventArgs) Handles BtnBack1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim roomId As Integer = txtRoomId.Text
        Dim name As String = txtName.Text
        Dim capacity As Integer = txtCapacity.Text

        Dim command As New SqlCommand("INSERT INTO Room(RoomId, RoomName, Capacity) VALUES('" & roomId & "', '" & name & "', '" & capacity & "')", connection)

        connection.Open()
        Command.ExecuteNonQuery()
        connection.Close()
        loadRoom()
        clearText()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim roomId As Integer = txtRoomId.Text
        Dim name As String = txtName.Text
        Dim capacity As Integer = txtCapacity.Text
        Dim i As Integer
        Dim count As Integer = ManageRoomsDGV.SelectedRows.Count

        For i = 0 To count - 1
            Dim Room_Id As Integer = ManageRoomsDGV.SelectedRows(i).Cells(0).Value
            Dim command As New SqlCommand("UPDATE Room SET RoomId = '" & roomId & "', RoomName = '" & name & "', Capacity = '" & capacity & "'", connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Next
        loadRoom()
        clearText()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim i As Integer
        Dim count As Integer = ManageRoomsDGV.SelectedRows.Count

        For i = 0 To count - 1
            Dim RoomId As Integer = ManageRoomsDGV.SelectedRows(i).Cells(0).Value

            Dim command As New SqlCommand("DELETE FROM Room WHERE RoomId = '" & RoomId & "'", connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Next
        loadRoom()
        clearText()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        clearText()
    End Sub

    Private Sub ManageRoomsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ManageRoomsDGV.CellClick
        Dim i As Integer
        Dim count As Integer = ManageRoomsDGV.SelectedRows.Count

        For i = 0 To count - 1
            txtRoomId.Text = ManageRoomsDGV.SelectedRows(i).Cells(0).Value
            txtName.Text = ManageRoomsDGV.SelectedRows(i).Cells(1).Value
            txtCapacity.Text = ManageRoomsDGV.SelectedRows(i).Cells(2).Value
        Next
    End Sub
End Class