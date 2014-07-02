Imports Dokumentverwaltung.Dokumente
Imports System.IO
Imports System.Collections.Specialized

Public Class Form1

    ''' <summary>
    ''' Neues Produkt per Menü oder doppelklick hinzufügen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NeuesProduktHinzufuegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuesProduktHinzufügenToolStripMenuItem.Click, ProdukteDataGridView.MouseDoubleClick
        Dim newProduct As New frmAddItem
        newProduct.Text = "Neues Produkt hinzufügen"
        newProduct.Label1.Text = "Produktname"
        newProduct.ShowDialog()
        If newProduct.DialogResult = DialogResult.OK Then
            Dokumente.Produkte.AddProdukteRow(newProduct.ItemName.Text, Now, User, False)
            VersionCheckVisualState()
        End If
    End Sub

    ''' <summary>
    ''' Neue Version per Menü oder doppelklick hinzufügen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NeueVersionHinzufuegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeueVersionHinzufügenToolStripMenuItem.Click, VersionenDataGridView.MouseDoubleClick
        Dim newVersion As New frmAddItem
        newVersion.Text = "Neue Version hinzufügen"
        newVersion.Label1.Text = "Versionsnummer"
        newVersion.ShowDialog()
        If newVersion.DialogResult = Windows.Forms.DialogResult.OK Then
            Dokumente.Versionen.AddVersionenRow(newVersion.ItemName.Text, ActiveProduct.ID, Now, User, False)
            VersionCheckVisualState()
        End If

    End Sub
    
    ''' <summary>
    ''' Neue Prüfung per menü oder doppelklick hinzufügen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub NeuePruefungHinzufügenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuePrüfungHinzufügenToolStripMenuItem.Click, PruefungDataGridView.MouseDoubleClick
        Dim newTest As New frmAddItem
        newTest.Text = "Neue Prüfung hinzufügen"
        newTest.Label1.Text = "Prüfbezeichnung"
        newTest.ShowDialog()
        If newTest.DialogResult = Windows.Forms.DialogResult.OK Then
            Dokumente.Pruefung.AddPruefungRow(newTest.ItemName.Text, ActiveVersion.ID, Now, User, False)
            TestCheckVisualState()
        End If
    End Sub
    Private Sub VersionCheckVisualState()
       
            'Filter setzen
        If Not ActiveVersion Is Nothing Then
            VersionenDataGridView.Refresh()
            VersionenBindingSource.Filter = String.Format("ProduktID = " & ActiveProduct.ID.ToString)
            If VersionenBindingSource.Count = 0 Then
                lblHint1.Visible = True
                lblHint2.Visible = True
                lblHint3.Visible = True
                lblHint4.Visible = True
                VersionenDataGridView.Visible = False
                PruefungDataGridView.Visible = False
                DocumentsDataGridView.Visible = False
                butFileDrop.Visible = False
            Else
                lblHint1.Visible = False
                VersionenDataGridView.Visible = True
                VersionenBindingSource.MoveFirst()
            End If
        Else
            lblHint1.Visible = True
            lblHint2.Visible = True
            lblHint3.Visible = True
            lblHint4.Visible = True
            VersionenDataGridView.Visible = False
            PruefungDataGridView.Visible = False
            DocumentsDataGridView.Visible = False
            butFileDrop.Visible = False
        End If
        UpdateFormText()
    End Sub
    Private Sub TestCheckVisualState()
        If Not ActiveTest Is Nothing Then

            PruefungDataGridView.Refresh()
            PruefungBindingSource.Filter = String.Format("VersionID = " & ActiveVersion.ID.ToString)
            If PruefungBindingSource.Count = 0 Then
                lblHint2.Visible = True
                lblHint3.Visible = True
                lblHint4.Visible = True
                butFileDrop.Visible = False
                PruefungDataGridView.Visible = False
                DocumentsDataGridView.Visible = False
                butFileDrop.Visible = False
            Else
                lblHint2.Visible = False
                lblHint4.Visible = False
                PruefungDataGridView.Visible = True
                butFileDrop.Visible = True
                PruefungBindingSource.MoveFirst()
            End If
        Else
            lblHint3.Visible = True
            lblHint4.Visible = True
            DocumentsDataGridView.Visible = False
            butFileDrop.Visible = False
        End If
        UpdateFormText()
    End Sub
    Private Sub DocumentsCheckVisualState()
        If Not ActiveTest Is Nothing Then

            DocumentsDataGridView.Refresh()
            DocumentsBindingSource.Filter = String.Format("PruefungID = " & ActiveTest.ID.ToString)
            If DocumentsBindingSource.Count = 0 Then
                lblHint3.Visible = True
                DocumentsDataGridView.Visible = False
            Else
                lblHint3.Visible = False
                lblHint4.Visible = False
                DocumentsDataGridView.Visible = True
                butFileDrop.Visible = True
                DocumentsBindingSource.MoveFirst()
            End If
        End If
        UpdateFormText()
    End Sub
    ''' <summary>
    ''' Anderes Produkt ausgewählt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ProdukteBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles ProdukteBindingSource.CurrentItemChanged
        ActiveProduct = CType(CType(ProdukteBindingSource.Current, DataRowView).Row, ProdukteRow)
        VersionCheckVisualState()
        UpdateFormText()
    End Sub
    ''' <summary>
    ''' Andere Version gewählt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub VersionenBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles VersionenBindingSource.CurrentItemChanged
        ActiveVersion = CType(CType(VersionenBindingSource.Current, DataRowView).Row, VersionenRow)
        TestCheckVisualState()
        UpdateFormText()
    End Sub

    ''' <summary>
    ''' Andere Prüfung gewählt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PruefungBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles PruefungBindingSource.CurrentItemChanged
        ActiveTest = CType(CType(PruefungBindingSource.Current, DataRowView).Row, PruefungRow)

        DocumentsCheckVisualState()
        UpdateFormText()
    End Sub
    ''' <summary>
    ''' Anderes Produkt gewählt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DocumentsBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles DocumentsBindingSource.CurrentItemChanged
        ActiveDocument = CType(CType(DocumentsBindingSource.Current, DataRowView).Row, DocumentsRow)
        DocumentsCheckVisualState()
        UpdateFormText()
    End Sub
    ''' <summary>
    ''' Text der Form neu darstellen
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateFormText()
        Dim title As String = "Dokumentverwaltung "
        If ProdukteBindingSource.Count > 0 Then
            title += ActiveProduct.Produktname + " "
            If VersionenBindingSource.Count > 0 Then
                title += ActiveVersion.Version + " "
                If PruefungBindingSource.Count > 0 Then
                    title += ActiveTest.Pruefung + " "
                    If DocumentsBindingSource.Count > 0 Then
                        title += ActiveDocument.Dokument
                    End If
                End If
            End If
        End If
        Me.Text = title

    End Sub
    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        frmSettings.ShowDialog()
        If My.Settings.DocPath <> "" AndAlso My.Settings.DatabasePath <> "" Then
            SpeichernToolStripMenuItem.Enabled = True
            If File.Exists(My.Settings.DatabasePath + "Database.xml") Then
                LadenToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DocPath <> "" AndAlso My.Settings.DatabasePath <> "" Then
            SpeichernToolStripMenuItem.Enabled = True
            If File.Exists(My.Settings.DatabasePath + "Database.xml") Then
                LadenToolStripMenuItem.Enabled = True
            End If
        End If
        VersionenDataGridView.Visible = False
        PruefungDataGridView.Visible = False
        DocumentsDataGridView.Visible = False
        butFileDrop.Visible = False
        lblHint1.Visible = True
        lblHint2.Visible = True
        lblHint3.Visible = True
        lblHint4.Visible = True
        lblHint1.Text = "No Data"
        lblHint2.Text = "No Data"
        lblHint3.Text = "No Data"
        lblHint4.Text = "No Data"
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click
        Dokumente.WriteXml(My.Settings.DatabasePath + "Database.xml")
    End Sub

    Private Sub LadenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LadenToolStripMenuItem.Click
        Dokumente.ReadXml(My.Settings.DatabasePath + "Database.xml")
    End Sub



    Private Sub butFileDrop_DragEnter(sender As Object, e As DragEventArgs) Handles butFileDrop.DragEnter
        Dim data = DirectCast(e.Data, DataObject)
        If data.ContainsFileDropList Then e.Effect = DragDropEffects.All
    End Sub

    Private Sub butFileDrop_DragDrop(sender As Object, e As DragEventArgs) Handles butFileDrop.DragDrop
        Dim data = DirectCast(e.Data, DataObject)
        Dim files As StringCollection = data.GetFileDropList
        Dim freigabe As Boolean
        Dim result As DialogResult = MessageBox.Show("Soll die Freigabe gesetzt werden?", "Frage", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            freigabe = True
        Else
            freigabe = False
        End If
        For Each file As String In files
            Dokumente.Documents.AddDocumentsRow(file, Now, User, freigabe, ActiveTest.ID)
        Next
    End Sub

   
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        End
    End Sub
End Class
