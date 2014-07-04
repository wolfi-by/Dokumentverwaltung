Public Class frmSettings

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click


        If txtDocs.Text <> "" Then
            My.Settings.DocPath = txtDocs.Text
        End If
        If txtDatabase.Text <> "" Then
            My.Settings.DatabasePath = txtDatabase.Text
        End If
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
        End If
    End Sub

    Private Sub butOpenDatabasePath_Click(sender As Object, e As EventArgs) Handles butOpenDatabasePath.Click
        Dim dia As New FolderBrowserDialog
        dia.ShowDialog()
        If dia.SelectedPath <> "" Then
            txtDatabase.Text = dia.SelectedPath
        End If
    End Sub
End Class