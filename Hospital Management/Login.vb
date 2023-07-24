Imports System.Data.SqlClient
Imports System.Data
Public Class Login
    Dim username, password As String

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        'Make SQL connection
        Dim conn As New SqlConnection("Data Source=LAPTOP-G734VL11;Initial Catalog=Hospital;Integrated Security=True")
        'SQL Comamnd to be executed
        Dim cmd As New SqlCommand("Select Username , Password from Users where Username = @username and Password = @password", conn)
        'Open the connection
        conn.Open()
        username = username_text.Text
        password = pass_text.Text
        'Pass the values to the SQL Command
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        'Execute Command
        Dim rd As SqlDataReader = cmd.ExecuteReader()
        'Check if the fields are empty
        If username = "" Or password = "" Then
            MessageBox.Show("Username or password field cannot be empty")
        ElseIf rd.HasRows Then
            Dim home As New Home
            'Hide current form
            Me.Hide()
            'Show next form
            home.Show()
        Else
            MessageBox.Show("user not verified")
            username_text.Focus()
        End If
    End Sub
End Class
