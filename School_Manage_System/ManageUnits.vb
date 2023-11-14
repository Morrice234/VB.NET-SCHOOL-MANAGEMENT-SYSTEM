Imports System.Data.SqlClient

Public Class ManageUnits
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub ManageUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As SqlConnection = New SqlConnection

        connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=D:\projects\VB.NET\db\SchoolManagementSystem.mdf;
                                        Integrated Security=True;Connect Timeout=30"
        connection.Open()

        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM CourseUnit", connection)

        Dim dataSet As DataSet = New DataSet()
        dataAdapter.Fill(dataSet)
        ManageUnitsDGV.DataSource = dataSet.Tables(0)
        connection.Close()
    End Sub
End Class