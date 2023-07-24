﻿Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Doc_update
    Private Sub Doc_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.Doctor' table. You can move, or remove it, as needed.
        Me.DoctorTableAdapter.Fill(Me.HospitalDataSet.Doctor)

    End Sub
    Dim id As Integer
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Get values form table
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            id = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            name_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            gender.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            spl_cmb.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            qual_cmb.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            age_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            contact_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
            email_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
            sal_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        End If

    End Sub

    Function IsNumericString(input As String) As Boolean
        For Each c As Char In input
            If Not Char.IsDigit(c) Then
                Return False
            End If
        Next
        If input > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return Regex.IsMatch(email, pattern)
    End Function
    Private Sub updt_btn_Click(sender As Object, e As EventArgs) Handles updt_btn.Click
        Dim chk As Integer
        'Security check
        If gender.Text = "Male" Or gender.Text = "Female" Or gender.Text = "Others" Then
            If IsNumericString(age_txt.Text) Then
                If IsNumericString(contact_txt.Text) And contact_txt.Text.Length = 10 Then
                    If IsNumericString(sal_txt.Text) Then
                        If IsValidEmail(email_txt.Text) Then
                            'Esatblish Connection
                            Dim conn As New SqlConnection("Data Source=LAPTOP-G734VL11;Initial Catalog=Hospital;Integrated Security=True")
                            Dim cmd As New SqlCommand("UPDATE Doctor SET DocName = @name, Gender = @gen, Experience = @age ,Specialisation = @spl,Qualification = @qual, ContactNumber = @contact, EmailID = @email,Salary = @sal Where DocID = @id", conn)
                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.Parameters.AddWithValue("@name", name_txt.Text)
                            cmd.Parameters.AddWithValue("@gen", gender.Text)
                            cmd.Parameters.AddWithValue("@age", age_txt.Text)
                            cmd.Parameters.AddWithValue("@spl", spl_cmb.Text)
                            cmd.Parameters.AddWithValue("@qual", qual_cmb.Text)
                            cmd.Parameters.AddWithValue("@contact", contact_txt.Text)
                            cmd.Parameters.AddWithValue("@email", email_txt.Text)
                            cmd.Parameters.AddWithValue("@sal", sal_txt.Text)

                            conn.Open()
                            Dim Res As Integer = cmd.ExecuteNonQuery()
                            If Res > 0 Then
                                MessageBox.Show("Entered successfully")
                                Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
                                If previousform IsNot Nothing Then
                                    previousform.Show()
                                    Me.Close()
                                End If
                            Else
                                MessageBox.Show("Error occured while entering values")
                            End If
                            conn.Close()
                        Else
                            MessageBox.Show("Invalid email")
                        End If
                    Else
                            MessageBox.Show("Salary must be Integer")
                    End If
                Else
                    MessageBox.Show("Contact Number must be 10 digits!!!")
                End If
            Else
                MessageBox.Show("Experience must be Integer")
            End If
        Else
            MessageBox.Show("gender must be either 'M' or 'F'")
        End If
    End Sub

    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        'Go to previous form
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub


End Class