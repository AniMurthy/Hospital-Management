Imports System.Data.SqlClient

Public Class appt_del
    Dim ids As New List(Of Integer)
    Private Sub appt_del_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataView As New DataView(Me.HospitalDataSet.Appointments)

        ' Set the RowFilter to show only the records where the specific column matches the condition.
        dataView.RowFilter = "Status = 'Pending'"

        ' Set the filtered DataView as the DataSource for the DataGridView.
        DataGridView1.DataSource = dataView
        Me.AppointmentsTableAdapter.Fill(Me.HospitalDataSet.Appointments)

    End Sub

    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub del_rec_Click(sender As Object, e As EventArgs) Handles del_rec.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim checkbox As DataGridViewCheckBoxCell = CType(row.Cells(0), DataGridViewCheckBoxCell)
            If CBool(checkbox.Value) = True Then
                'MessageBox.Show(CInt(row.Cells(1).Value))
                ids.Add(CInt(row.Cells(1).Value))
            End If
        Next

        'Make sure some row is being deleted
        If ids.Count > 0 Then
            For Each num As Integer In ids
                Dim conn As New SqlConnection("Data Source=LAPTOP-G734VL11;Initial Catalog=Hospital;Integrated Security=True")
                Dim cmd As New SqlCommand("Update Appointments set status = 'completed' Where AptID = @val", conn)
                cmd.Parameters.AddWithValue("@val", num)
                conn.Open()
                cmd.ExecuteNonQuery()

                conn.Close()
            Next
            MessageBox.Show("Successfully updated Records")
            Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
            If previousform IsNot Nothing Then
                previousform.Show()
            End If
            Me.Close()
        Else
            MessageBox.Show("Please setect an appointment to close")
        End If
    End Sub

End Class