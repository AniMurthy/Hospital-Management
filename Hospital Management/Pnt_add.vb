Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Pnt_add
    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub add_pnt_Click(sender As Object, e As EventArgs) Handles add_pnt.Click
        Dim name, gen, addr, age, num As String
        Dim chk As Integer
        name = pnt_name_txt.Text
        addr = pnt_address_txt.Text
        gen = pnt_gen_txt.Text
        age = pnt_age_txt.Text
        num = pnt_num_txt.Text
        If gen = "M" Or gen = "F" Then
            If Integer.TryParse(age, chk) Then
                If num.Length = 10 Then
                    'Esatblish Connection
                    Dim conn As New SqlConnection("Data Source=LAPTOP-C6S94HN4;Initial Catalog=Hospital;Integrated Security=True")
                    Dim cmd As New SqlCommand("Insert Into Patients (PatientName,Gender,Age,Address,ContactNumber) Values(@name,@gen,@age,@addr,@num)", conn)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@gen", gen)
                    cmd.Parameters.AddWithValue("@age", age)
                    cmd.Parameters.AddWithValue("@addr", addr)
                    cmd.Parameters.AddWithValue("@num", num)

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
End Class