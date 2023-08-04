Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Pnt_add
    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub

    Function IsNumericString(inp As String) As Boolean
        For Each c As Char In inp
            If Not Char.IsDigit(c) Then
                Return False
            End If
        Next
        If inp > 0 Then
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
        If name = "" Or addr = "" Or gen = "" Or age = "" Or num = "" Then
            MessageBox.Show("Do not leave any feild empty")
        Else
            If IsNumericString(age) And age < 110 Then
                If IsNumericString(num) And num.Length = 10 Then
                    Dim input As String = pnt_name_txt.Text
                    Dim pattern As String = "^[A-Za-z]+$"
                    If System.Text.RegularExpressions.Regex.IsMatch(input, pattern) Then
                        Dim input1 As String = pnt_address_txt.Text
                        Dim pattern1 As String = "^[A-Za-z0-9# ]+$"
                        If System.Text.RegularExpressions.Regex.IsMatch(input1, pattern1) Then
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
                            MessageBox.Show("Invalid address")
                        End If
                    Else
                        MessageBox.Show("Invalid name")
                    End If
                Else
                    MessageBox.Show("invalid contact number")
                End If
            Else
                MessageBox.Show("invalid age")
            End If
        End If
    End Sub
    Private Sub pnt_age_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pnt_age_txt.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub pnt_num_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pnt_num_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


End Class
