Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions

Public Class Form1
    Public regNo As String

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;
                                        AttachDbFilename=D:\projects\VB.NET\db\SchoolManagementSystem.mdf;
                                        Integrated Security=True;Connect Timeout=30")
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        Dim usertype = ComboUserType.SelectedItem



        If usertype = "Staff" Then
            'If username = "root".ToUpper And password = "root".ToUpper Then
            'Admin.Show()
            'Me.Hide()
            'Else

            connection.Open()

            Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Staff WHERE Staff_Id='" & username & "' AND Password='" & password & "'", connection)
            Dim dataTable As DataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            If dataTable.Rows.Count > 0 Then
                Dim Rank = dataTable.Rows(0)(3)

                If Rank = "Admin" Then
                    Admin.Show()
                    Me.Hide()
                ElseIf Rank = "HOD" Then
                    HOD.Show()
                    Me.Hide()
                ElseIf Rank = "Staff" Then
                    Staff.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("You are not allowed to login here")
                End If

            Else
                MessageBox.Show("Please enter the correct details!")
            End If
            'End If
        ElseIf usertype = "Student" Then

            connection.Open()
            Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Students WHERE RegNo='" & username & "' AND Password='" & password & "'", connection)
            Dim dataTable As DataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            If dataTable.Rows.Count > 0 Then
                regNo = dataTable.Rows(0)(0)
                Student.Show()
                Me.Hide()

            Else
                MessageBox.Show("Please enter the correct details!")
            End If
        Else
            MessageBox.Show("You are not allowed to login")
        End If


    End Sub

    Private Sub ComboUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboUserType.SelectedIndexChanged
        If ComboUserType.SelectedItem = "Staff" Then
            LblUsername.Text = "Staff Id:"
        Else
            LblUsername.Text = "Reg No:"
        End If
    End Sub
End Class
