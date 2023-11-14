Imports System.Data.SqlClient

Public Class ManageStudent

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=D:\projects\VB.NET\db\SchoolManagementSystem.mdf;
                                        Integrated Security=True;Connect Timeout=30")
    Private Sub clearText()
        txtRegNo.Clear()
        txtFirstName.Clear()
        txtSecondName.Clear()
        TxtPassword.Clear()
        txtSurname.Clear()
        TxtNationality.Clear()
    End Sub

    Private Sub loadStudent()
        connection.Open()

        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Students", connection)

        Dim dataSet As DataSet = New DataSet()
        dataAdapter.Fill(dataSet)
        ManageStudentDGV.DataSource = dataSet.Tables(0)
        ManageStudentDGV.AllowUserToAddRows = False
        connection.Close()

    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub ManageStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadStudent()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim regNo As String = txtRegNo.Text
        Dim firstName As String = txtFirstName.Text
        Dim secondName As String = txtSecondName.Text
        Dim surname As String = txtSurname.Text
        Dim gender As String = ComboGender.SelectedItem
        Dim dob As DateTime = DateTimePicker1.Text
        Dim nationality As String = TxtNationality.Text
        Dim password As String = TxtPassword.Text
        Dim yoa As Integer = TxtYOA.Text

        Dim command As New SqlCommand("INSERT INTO Students(RegNo, First_Name, Second_Name, Surname, DOB, Gender, Nationality, YearOfAdmission, Password)
                                        VALUES('" & regNo & "', '" & firstName & "', '" & secondName & "',
                                        '" & surname & "', '" & dob & "', '" & gender & "', '" & nationality & "', '" & yoa & "', '" & password & "')", connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        loadStudent()
        clearText()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim regNo As String = txtRegNo.Text
        Dim firstName As String = txtFirstName.Text
        Dim secondName As String = txtSecondName.Text
        Dim surname As String = txtSurname.Text
        Dim gender As String = ComboGender.SelectedItem
        Dim dob As String = DateTimePicker1.Text
        Dim nationality As String = TxtNationality.Text
        Dim password As String = TxtPassword.Text
        Dim yoa As Integer = TxtYOA.Text
        Dim i As Integer
        Dim count As Integer = ManageStudentDGV.SelectedRows.Count

        For i = 0 To count - 1
            Dim StudentId = ManageStudentDGV.SelectedRows(i).Cells(0).Value.ToString()

            Dim command As New SqlCommand("UPDATE Students SET RegNo = '" & regNo & "', First_Name = '" & firstName & "', Second_Name = '" & secondName & "',
                                            Surname = '" & surname & "', DOB = '" & dob & "', Gender = '" & gender & "', Nationality = '" & nationality & "', YearOfAdmission = '" & yoa & "', Password = '" & password & "'
                                            WHERE RegNo = '" & StudentId & "'", connection)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

        Next
        loadStudent()
        clearText()

    End Sub

    Private Sub ManageStudentDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ManageStudentDGV.CellClick
        Dim i As Integer
        Dim count As Integer = ManageStudentDGV.SelectedRows.Count

        For i = 0 To count - 1
            txtRegNo.Text = ManageStudentDGV.SelectedRows(i).Cells(0).Value
            txtFirstName.Text = ManageStudentDGV.SelectedRows(i).Cells(1).Value
            txtSecondName.Text = ManageStudentDGV.SelectedRows(i).Cells(2).Value
            txtSurname.Text = ManageStudentDGV.SelectedRows(i).Cells(3).Value
            DateTimePicker1.Text = ManageStudentDGV.SelectedRows(i).Cells(4).Value
            ComboGender.SelectedItem = ManageStudentDGV.SelectedRows(i).Cells(5).Value
            TxtNationality.Text = ManageStudentDGV.SelectedRows(i).Cells(6).Value
            TxtYOA.Text = ManageStudentDGV.SelectedRows(i).Cells(7).Value
            TxtPassword.Text = ManageStudentDGV.SelectedRows(i).Cells(8).Value
        Next
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim i As Integer
        Dim count As Integer = ManageStudentDGV.SelectedRows.Count
        For i = 0 To count - 1
            Dim regNo As Integer = ManageStudentDGV.SelectedRows(i).Cells(0).Value
            Dim command As New SqlCommand("DELETE FROM Staff WHERE RegNo = '" & regNo & "'", connection)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
        Next
        loadStudent()
        clearText()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        clearText()
    End Sub
End Class