Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Pnt_update
    Private Sub Pnt_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.HospitalDataSet.Patients)

    End Sub
    Dim id As Integer
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            id = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            pnt_name_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            gender.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            pnt_age_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            pnt_address_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            pnt_num_txt.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
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
    Private Sub update_pnt_Click(sender As Object, e As EventArgs) Handles update_pnt.Click
        Dim chk As Integer
        If gender.Text = "Male" Or gender.Text = "Female" Or gender.Text = "Others" Then
            If IsNumericString(pnt_age_txt.Text) Then
                If IsNumericString(pnt_num_txt.Text) And pnt_num_txt.Text.Length = 10 Then
                    'Esatblish Connection
                    Dim conn As New SqlConnection("Data Source=LAPTOP-G734VL11;Initial Catalog=Hospital;Integrated Security=True")
                    'Dim cmd As New SqlCommand("Insert Into Patients (PatientName,Gender,Age,Address,ContactNumber) Values(@name,@gen,@age,@addr,@num)", conn)
                    Dim cmd As New SqlCommand("UPDATE Patients SET PatientName = @name, Gender = @gen, Age = @age ,Address = @addr,ContactNumber = @num WHERE  PatientID = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@name", pnt_name_txt.Text)
                    cmd.Parameters.AddWithValue("@gen", gender.Text)
                    cmd.Parameters.AddWithValue("@age", Integer.Parse(pnt_age_txt.Text))
                    cmd.Parameters.AddWithValue("@addr", pnt_address_txt.Text)
                    cmd.Parameters.AddWithValue("@num", pnt_num_txt.Text)

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
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub
End Class