Public Class frmSettings

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDocs.Text = My.Settings.DocPath
        txtDatabase.Text = My.Settings.DatabasePath
    End Sub

    Private Sub butOpenDocPath_Click(sender As Object, e As EventArgs) Handles butOpenDocPath.Click
        Dim dia As New FolderBrowserDialog
        dia.ShowDialog()
        If dia.SelectedPath <> "" Then
            txtDocs.Text = dia.SelectedPath
            My.Settings.DocPath = dia.SelectedPath
        End If
    End Sub

    Private Sub butOpenDatabasePath_Click(sender As Object, e As EventArgs) Handles butOpenDatabasePath.Click
        Dim dia As New FolderBrowserDialog
        dia.ShowDialog()
        If dia.SelectedPath <> "" Then
            txtDatabase.Text = dia.SelectedPath
            My.Settings.DatabasePath = dia.SelectedPath
        End If
    End Sub
End Class