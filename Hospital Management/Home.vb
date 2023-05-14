Imports System.Windows

Public Class Home
    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim previousform As Form = Application.OpenForms.OfType(Of Login)().FirstOrDefault()
        If previousform IsNot Nothing Then
            previousform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Pnt_view_Click(sender As Object, e As EventArgs) Handles Pnt_view.Click
        Dim pnt As New Pnt_view
        pnt.Show()
        Me.Hide()
    End Sub

    Private Sub Pnt_add_Click(sender As Object, e As EventArgs) Handles Pnt_add.Click
        Dim pnt_add As New Pnt_add
        pnt_add.Show()
        Me.Hide()
    End Sub
End Class