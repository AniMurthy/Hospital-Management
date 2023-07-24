Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Doc_add
    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        'Go back to previous form
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub
    Dim id, chk As Integer


    Dim d_name, gen, age, sal, specialisation, qualification, email, contact As String

    ' Function to check if the string contains only numeric characters
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
    Private Sub add_doc_Click(sender As Object, e As EventArgs) Handles add_doc.Click

        'Check if any field is empty
        If age_txt.Text = "" Or sal_txt.Text = "" Or name_txt.Text = "" Or gender.Text = "" Or spl_cmb.Text = "" Or qual_cmb.Text = "" Or email_txt.Text = "" Or contact_txt.Text = "" Then
            MessageBox.Show("Do Not Leave any field empty")
        Else
            'If not, assign the values
            age = age_txt.Text
            sal = sal_txt.Text
            d_name = name_txt.Text
            gen = gender.Text
            specialisation = spl_cmb.Text
            qualification = qual_cmb.Text
            email = email_txt.Text
            contact = contact_txt.Text

            'Security check to prevent unwanted values
            If IsNumericString(age) Then
                If IsNumericString(sal) Then
                    If IsNumericString(contact) And contact.Length = 10 Then
                        If IsValidEmail(email_txt.Text) Then
                            Dim conn As New SqlConnection("Data Source=LAPTOP-G734VL11;Initial Catalog=Hospital;Integrated Security=True")
                            Dim cmd As New SqlCommand("Insert Into Doctor (DocName,Gender,Experience,EmailID,Qualification,Specialisation,ContactNumber,Salary) Values(@name,@gen,@age,@email,@qual,@spl,@contact,@sal)", conn)
                            cmd.Parameters.AddWithValue("@name", Name)
                            cmd.Parameters.AddWithValue("@gen", gen)
                            cmd.Parameters.AddWithValue("@age", age)
                            cmd.Parameters.AddWithValue("@spl", specialisation)
                            cmd.Parameters.AddWithValue("@qual", qualification)
                            cmd.Parameters.AddWithValue("@contact", contact)
                            cmd.Parameters.AddWithValue("@email", email)
                            cmd.Parameters.AddWithValue("@sal", sal)

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
                            'MessageBox.Show("Contact number must be all digits")
                            MessageBox.Show("Invalid Contact number")
                    End If
                Else
                    'MessageBox.Show("Salary must be Integer")
                    MessageBox.Show("Invalid Salary")
                End If
            Else
                'MessageBox.Show("Experience must be Integer and positive")
                MessageBox.Show("Invalid Experience")
            End If
        End If
    End Sub
End Class