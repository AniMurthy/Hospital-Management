Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class Pnt_del
    Private Sub Pnt_del_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.HospitalDataSet.Patients)

    End Sub
    Dim ids As New List(Of Integer)

    Private Sub del_rec_Click(sender As Object, e As EventArgs) Handles del_rec.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim checkbox As DataGridViewCheckBoxCell = CType(row.Cells(0), DataGridViewCheckBoxCell)
            If CBool(checkbox.Value) = True Then
                ids.Add(CInt(row.Cells(1).Value))
            End If
        Next
        If ids.Count = 0 Then
            MessageBox.Show("Please select record to delete")
        Else


            For Each num As Integer In ids
                Dim conn As New SqlConnection("Data Source=LAPTOP-G734VL11;Initial Catalog=Hospital;Integrated Security=True")
                Dim cmd As New SqlCommand("Delete from Patients Where PatientID = @val", conn)
                cmd.Parameters.AddWithValue("@val", num)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            Next
            MessageBox.Show("Successfully deleted Record")
            Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
            If previousform IsNot Nothing Then
                previousform.Show()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub


End Class