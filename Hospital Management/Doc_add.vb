Imports System.Data.SqlClient

Public Class Doc_add
    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        'Go back to previous form
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub
    Dim id, age, sal, chk As Integer
    Dim d_name, gen, specialisation, qualification, email, contact As String

    Private Sub add_doc_Click(sender As Object, e As EventArgs) Handles add_doc.Click
        'Check if any field is empty
        If age_txt.Text = "" Or sal_txt.Text = "" Or name_txt.Text = "" Or gen_txt.Text = "" Or spl_txt.Text = "" Or qual_txt.Text = "" Or email_txt.Text = "" Or contact_txt.Text = "" Then
            MessageBox.Show("Do Not Leave any field empty")
        Else
            'If not, assign the values
            age = age_txt.Text
            sal = sal_txt.Text
            d_name = name_txt.Text
            gen = gen_txt.Text
            specialisation = spl_txt.Text
            qualification = qual_txt.Text
            email = email_txt.Text
            contact = contact_txt.Text

            'Security check to prevent unwanted values
            If gen = "M" Or gen = "F" Then
                If Integer.TryParse(age, chk) Then
                    If Integer.TryParse(sal, chk) Then
                        If contact.Length = 10 Then
                            Dim conn As New SqlConnection("Data Source=LAPTOP-C6S94HN4;Initial Catalog=Hospital;Integrated Security=True")
                            Dim cmd As New SqlCommand("Insert Into Doctor (DocName,Gender,Age,EmailID,Qualification,Specialisation,ContactNumber,Salary) Values(@name,@gen,@age,@email,@qual,@spl,@contact,@sal)", conn)
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
                            MessageBox.Show("Contact Number must be 10 digits!!!")
                        End If
                    Else
                        MessageBox.Show("Salary must be Integer")
                    End If
                Else
                    MessageBox.Show("Age must be Integer")
                End If
            Else
                MessageBox.Show("gender must be either 'M' or 'F'")
            End If
        End If


    End Sub
End Class