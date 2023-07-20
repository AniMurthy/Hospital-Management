Imports System.Data.SqlClient

Public Class appt_del
    Dim ids As New List(Of Integer)
    Private Sub appt_del_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.Appointments' table. You can move, or remove it, as needed.
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
                MessageBox.Show(CInt(row.Cells(1).Value))
                ids.Add(CInt(row.Cells(1).Value))
            End If
        Next

        'Make sure some row is being deleted
        If ids.Count = 0 Then
            MessageBox.Show(ids.Count)
        Else
            For Each num As Integer In ids
                Dim conn As New SqlConnection("Data Source=LAPTOP-C6S94HN4;Initial Catalog=Hospital;Integrated Security=True")
                Dim cmd As New SqlCommand("Update Appointments set status = 'completed' Where AptID = @val", conn)
                cmd.Parameters.AddWithValue("@val", num)
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully updated Record")
                conn.Close()
            Next
        End If

        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class