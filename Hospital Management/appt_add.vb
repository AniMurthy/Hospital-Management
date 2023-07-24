Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Hospital_Management.HospitalDataSet

Public Class appt_add
    Private Sub appt_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=LAPTOP-C6S94HN4;Initial Catalog=Hospital;Integrated Security=True")
        'SQL Comamnd to be executed
        Dim cmd1 As New SqlCommand("select * from Patients where PatientID not in (select PntID from Appointments where Status = 'Pending')", conn)
        Dim cmd2 As New SqlCommand("select * from Doctor where DocID not in (select DOCID from Appointments where Status = 'Pending')", conn)
        conn.Open()
        Dim DocDataTable As New DataTable
        Dim PntDataTable As New DataTable
        Dim adapter_pnt As New SqlDataAdapter(cmd1)
        Dim adapter_doc As New SqlDataAdapter(cmd2)
        adapter_pnt.Fill(PntDataTable)
        adapter_doc.Fill(DocDataTable)

        DataGridView1.DataSource = PntDataTable
        DataGridView2.DataSource = DocDataTable
        'TODO: This line of code loads data into the 'HospitalDataSet.Doctor' table. You can move, or remove it, as needed.
        Me.DoctorTableAdapter.Fill(Me.HospitalDataSet.Doctor)
        'TODO: This line of code loads data into the 'HospitalDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.HospitalDataSet.Patients)

    End Sub
    Dim pntid, docid As Integer
    Dim status As String
    Dim time As Date

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        'Get the docID from the table
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            docid = DataGridView2.Rows(e.RowIndex).Cells(1).Value
        End If
        DocID_txt.Text = docid
    End Sub

    Private Sub Add_apt_Click(sender As Object, e As EventArgs) Handles Add_apt.Click
        status = "Pending"
        time = appmt_time.Value

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

    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Get the patientID from the table
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            pntid = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        End If
        PntID_txt.Text = pntid
    End Sub
End Class