Imports System.Windows.Forms

Public Class AboutWin
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub AboutWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver.Text = $"v{Application.ProductVersion}.0 (2023)"
    End Sub

    Private Sub AuthorSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AuthorSite.LinkClicked
        Try
            Dim URL = "https://kay-software.ru/dosx"
            If MsgBox($"Open ""{URL}""?", &H4, URL) = MsgBoxResult.Yes Then
                Diagnostics.Process.Start("explorer.exe", URL)
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub AuthorSite_FocusCloseBtn(sender As Object, e As EventArgs) Handles AuthorSite.GotFocus,
                                                                                   AuthorSite.MouseDown
        CloseBtn.Focus()

    End Sub

    Private Sub Ver_Click(sender As Object, e As EventArgs) Handles Ver.Click
        Me.Hide()
        HelpMsg()
    End Sub
End Class