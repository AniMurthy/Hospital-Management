Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class Pnt_del
    Private Sub Pnt_del_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.HospitalDataSet.Patients)

    End Sub

    Private Sub del_rec_Click(sender As Object, e As EventArgs) Handles del_rec.Click
        Dim ids As New List(Of Integer)
        For Each row As DataGridViewRow In DataGridView1.Rows
            Console.WriteLine(row)
            Dim checkbox As DataGridViewCheckBoxCell = CType(row.Cells(6), DataGridViewCheckBoxCell)
            If CBool(checkbox.Value) = True Then
                ids.Add(CInt(row.Cells(0).Value))
            End If
        Next

        If ids.Count = 0 Then
            MessageBox.Show("Please select record to delete")
        Else
            For Each num As Integer In ids
                Dim conn As New SqlConnection("Data Source=LAPTOP-C6S94HN4;Initial Catalog=Hospital;Integrated Security=True")
                Dim cmd As New SqlCommand("Delete from Patients Where PatientID = @val", conn)
                cmd.Parameters.AddWithValue("@val", num)
                conn.Open()
                Dim schemaTable As DataTable = conn.GetSchema("Columns", New String() {Nothing, Nothing, "Patients"})
                For Each row As DataRow In schemaTable.Rows
                    Dim columnName As String = row("COLUMN_NAME").ToString()
                    Console.WriteLine(columnName)
                Next
                cmd.ExecuteNonQuery()
                conn.Close()
            Next
        End If
        MessageBox.Show("Successfully deleted Record")
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub
End Class