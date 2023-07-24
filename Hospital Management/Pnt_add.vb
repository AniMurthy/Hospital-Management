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
    Private Sub add_pnt_Click(sender As Object, e As EventArgs) Handles add_pnt.Click
        Dim name, gen, addr, age, num As String
        name = pnt_name_txt.Text
        addr = pnt_address_txt.Text
        gen = gender.Text
        age = pnt_age_txt.Text
        num = pnt_num_txt.Text
        If IsNumericString(age) And age < 110 Then
            If IsNumericString(num) And num.Length = 10 Then
                'Esatblish Connection
                Dim conn As New SqlConnection("Data Source=LAPTOP-G734VL11;Initial Catalog=Hospital;Integrated Security=True")
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
                MessageBox.Show("Invalid Contact number")
            End If
        Else
            MessageBox.Show("Invalid Age")
        End If

    End Sub
End Class