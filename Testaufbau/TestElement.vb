Public Class TestElement

    Public Dokumentliste As List(Of String)
    Public ParentControl As String
    Public ok As Boolean = False
    Public dt As DataTable

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Dokumentliste = New List(Of String)
        dt = New DataTable
        dt.Columns.Add("Filepath")
        dt.Columns.Add("Date")
        dt.Columns.Add("OK")
    End Sub

    Private Sub ListBox1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
        Select Case True
            Case sender Is ListBox1
                e.Effect = DragDropEffects.Link
        End Select

    End Sub

    Private Sub ListBox1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        Dim result = MsgBox("Prüfung wurde bestanden?", vbYesNo)


        If result = MsgBoxResult.Yes Then
            ListBox1.BackColor = Color.Green
            ListBox2.BackColor = Color.Green
            ok = True
        Else
            ListBox1.BackColor = Color.Red
            ListBox2.BackColor = Color.Red
            ok = False
        End If
        Dim Formatlist = e.Data.GetFormats
        For Each item In e.Data.GetData(Formatlist(6))
            dt.Rows.Add(FileCopier(item), Now.ToString, result.ToString)
        Next
        ListBox1.DataSource = dt
        ListBox1.DisplayMember = "Filepath"
        ListBox2.DataSource = dt
        ListBox2.DisplayMember = "Date"
    End Sub

    Private Function FileCopier(ByVal Filename As String) As String

        Dim Source As String = Filename
        Dim Destination As String = "U:\Eigene Dateien\01_Funktionstest\99_Verlauf\" + ParentControl + "\" + Filename.Split("\").Last
        If Not My.Computer.FileSystem.DirectoryExists("U:\Eigene Dateien\01_Funktionstest\99_Verlauf\" + ParentControl) Then
            My.Computer.FileSystem.CreateDirectory("U:\Eigene Dateien\01_Funktionstest\99_Verlauf\" + ParentControl)
        End If
        System.IO.File.Copy(Source, Destination, True)
        Return Destination
    End Function
 
End Class
