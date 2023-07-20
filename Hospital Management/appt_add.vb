Imports System.Data.SqlClient

Public Class appt_add
    Private Sub appt_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.Doctor' table. You can move, or remove it, as needed.
        Me.DoctorTableAdapter.Fill(Me.HospitalDataSet.Doctor)
        'TODO: This line of code loads data into the 'HospitalDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.HospitalDataSet.Patients)

    End Sub
    Dim pntid, docid As Integer
    Dim status As String
    Dim time As Date = appmt_time.Value


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        'Get the docID from the table
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            docid = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        End If
        DocID_txt.Text = docid
    End Sub

    Private Sub Add_apt_Click(sender As Object, e As EventArgs) Handles Add_apt.Click
        status = "Pending"
        'Make SQL connection
        Dim conn As New SqlConnection("Data Source=LAPTOP-C6S94HN4;Initial Catalog=Hospital;Integrated Security=True")
        'SQL Comamnd to be executed
        Dim cmd As New SqlCommand("Insert into Appointments (PntID,DocID,AppointmentTime,Status) values(@pntid,@docid,@time,@status)", conn)
        'Pass the values to the SQL Command
        cmd.Parameters.AddWithValue("@pntid", pntid)
        cmd.Parameters.AddWithValue("@docid", docid)
        cmd.Parameters.AddWithValue("@time", time)
        cmd.Parameters.AddWithValue("@status", status)
        'Open the connection
        conn.Open()
        'Execute Command
        Dim res As Integer = cmd.ExecuteNonQuery()
        'Check if the query was executed succesfully. If it was not, the result will be 0. If it was executed succesfully the result is 0
        If res > 0 Then
            Dim home As New Home
            home.Show()
            Me.Close()
        End If
        conn.Close()
    End Sub

    Private Sub appmt_time_ValueChanged(sender As Object, e As EventArgs) Handles appmt_time.ValueChanged
        'Set time
        time = appmt_time.Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Get the patientID from the table
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            pntid = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        End If
        PntID_txt.Text = pntid
    End Sub
End Class