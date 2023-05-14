Imports System.Data.SqlClient
Imports System.Data
Public Class Login
    Dim username, password As String
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim conn As New SqlConnection("Data Source=LAPTOP-C6S94HN4;Initial Catalog=Hospital;Integrated Security=True")
        Dim cmd As New SqlCommand("Select Username , Password from Users where Username = @username and Password = @password", conn)
        conn.Open()
        username = username_text.Text
        password = pass_text.Text
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        If username = "" Or password = "" Then
            MessageBox.Show("Username or password field cannot be empty")
        ElseIf rd.HasRows Then
            MessageBox.Show("User verified")
            Dim home As New Home
            Me.Hide()
            home.Show()
        Else
            MessageBox.Show("user not verified")
        End If
    End Sub
End Class
