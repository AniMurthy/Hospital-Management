Public Class Pnt_view
    Private Sub Pnt_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.HospitalDataSet.Patients)
        'TODO: This line of code loads data into the 'HospitalDataSet1.Patients' table. You can move, or remove it, as needed.
        'Me.PatientsTableAdapter1.Fill(Me.HospitalDataSet1.Patients)
        'Me.PatientsTableAdapter.Fill(Me.HospitalDataSet.Patients)

    End Sub

    Private Sub bck_btn_Click(sender As Object, e As EventArgs) Handles bck_btn.Click
        Dim previousform As Form = Application.OpenForms.OfType(Of Home)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class