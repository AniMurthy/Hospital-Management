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
    Dim time As Date

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            docid = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        End If
        DocID_txt.Text = docid
    End Sub

    Private Sub Add_apt_Click(sender As Object, e As EventArgs) Handles Add_apt.Click
        status = "Pending"
        Dim conn As New SqlConnection("Data Source=LAPTOP-G734VL11;Initial Catalog=Hospital;Integrated Security=True")
        Dim cmd As New SqlCommand("Insert into Appointments (PntID,DocID,AppointmentTime,Status) values(@pntid,@docid,@time,@status)", conn)
        cmd.Parameters.AddWithValue("@pntid", pntid)
        cmd.Parameters.AddWithValue("@docid", docid)
        cmd.Parameters.AddWithValue("@time", time)
        cmd.Parameters.AddWithValue("@status", status)
        conn.Open()
        'MessageBox.Show(time)
        Dim res As Integer = cmd.ExecuteNonQuery()
        If res > 0 Then
            Dim home As New Home
            home.Show()
            Me.Close()
        End If
        conn.Close()
    End Sub

    Private Sub appmt_time_ValueChanged(sender As Object, e As EventArgs) Handles appmt_time.ValueChanged
        time = appmt_time.Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            pntid = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        End If
        PntID_txt.Text = pntid
    End Sub
End Class