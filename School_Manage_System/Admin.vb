Imports System.Data.SqlClient
Imports System.Security.Policy

Public Class Admin
    Dim connection As SqlConnection = New SqlConnection()
    'Dim statement

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=D:\projects\VB.NET\db\SchoolManagementSystem.mdf;
                                        Integrated Security=True;Connect Timeout=30"
        connection.Open()

        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Staff", connection)

        Dim dataSet As DataSet = New DataSet()
        dataAdapter.Fill(dataSet)

        AdminDGV.DataSource = dataSet.Tables(0)
        connection.Close()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDepartments_Click(sender As Object, e As EventArgs) Handles BtnDepartments.Click
        ManageDepartments.Show()
        Me.Hide()
    End Sub

    Private Sub BtnStaff_Click(sender As Object, e As EventArgs) Handles BtnStaff.Click
        ManageUser.Show()
        Me.Hide()

    End Sub

    Private Sub BtnRooms_Click(sender As Object, e As EventArgs) Handles BtnRooms.Click
        ManageRooms.Show()
        Me.Hide()
    End Sub

    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles BtnStudents.Click
        ManageStudent.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUnits_Click(sender As Object, e As EventArgs) Handles BtnUnits.Click
        ManageUnits.Show()
        Me.Hide()
    End Sub
End Class