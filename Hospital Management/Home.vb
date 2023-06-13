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

    Private Sub Pnt_del_Click(sender As Object, e As EventArgs) Handles Pnt_del.Click
        Dim pnt_del As New Pnt_del
        pnt_del.Show()
        Me.Hide()
    End Sub

    Private Sub Doc_view_Click(sender As Object, e As EventArgs) Handles Doc_view.Click
        Dim doc_view As New Doc_view
        doc_view.Show()
        Me.Hide()
    End Sub

    Private Sub Doc_del_Click(sender As Object, e As EventArgs) Handles Doc_del.Click
        Dim doc_del As New Doc_del
        doc_del.Show()
        Me.Hide()
    End Sub

    Private Sub Doc_updt_Click(sender As Object, e As EventArgs) Handles Doc_updt.Click
        Dim doc_updt As New Doc_update
        doc_updt.Show()
        Me.Hide()
    End Sub

    Private Sub Pnt_updt_Click(sender As Object, e As EventArgs) Handles Pnt_updt.Click
        Dim pnt_updt As New Pnt_update
        pnt_updt.Show()
        Me.Hide()
    End Sub

    Private Sub Doc_add_Click(sender As Object, e As EventArgs) Handles Doc_add.Click
        Dim doc_add As New Doc_add
        doc_add.Show()
        Me.Hide()
    End Sub
End Class