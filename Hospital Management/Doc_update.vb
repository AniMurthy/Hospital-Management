Imports System.Data.SqlClient

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
            gen_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            age_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            spl_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            qual_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            contact_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
            email_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
            sal_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        End If

    End Sub

    Private Sub updt_btn_Click(sender As Object, e As EventArgs) Handles updt_btn.Click
        Dim chk As Integer
        'Security check
        If gen_txt.Text = "M" Or gen_txt.Text = "F" Then
            If Integer.TryParse(age_txt.Text, chk) Then
                If contact_txt.Text.Length = 10 Then
                    'Esatblish Connection
                    Dim conn As New SqlConnection("Data Source=LAPTOP-C6S94HN4;Initial Catalog=Hospital;Integrated Security=True")
                    Dim cmd As New SqlCommand("UPDATE Doctor SET DocName = @name, Gender = @gen, Age = @age ,Specialisation = @spl,Qualification = @qual, ContactNumber = @contact, EmailID = @email,Salary = @sal Where DocID = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@name", name_txt.Text)
                    cmd.Parameters.AddWithValue("@gen", gen_txt.Text)
                    cmd.Parameters.AddWithValue("@age", Integer.Parse(age_txt.Text))
                    cmd.Parameters.AddWithValue("@spl", spl_txt.Text)
                    cmd.Parameters.AddWithValue("@qual", qual_txt.Text)
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
                    MessageBox.Show("Contact Number must be 10 digits!!!")
                End If
            Else
                MessageBox.Show("Age must be Integer")
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