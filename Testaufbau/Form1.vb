Imports System.Xml.Serialization

Public Class Form1

    Private Elementliste As List(Of MainControl)
    Private Testliste As List(Of TestElement)
    Private SelectedMainControl As MainControl
    Private Gespeichert As Boolean


    Private Sub NeuePrüfungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuePrüfungToolStripMenuItem.Click
        Dim Testname As String = InputBox("Produktkennung")
        If Testname <> "" Then
            Gespeichert = False
            Dim np As New MainControl
            With np
                .Font = New Font("Verdana", 12)
                .ReadOnly = True
                .Multiline = True
                .Text = Testname
                AddHandler .MouseClick, AddressOf SelectAnotherMainControl
            End With
            Elementliste.Add(np)
            SelectAnotherMainControl(np, Nothing)
        End If


    End Sub
    Private Sub SelectAnotherMainControl(ByVal sender As Object, ByVal e As MouseEventArgs)
       
        teststatus()
        For Each main As MainControl In Elementliste
            If main.OK Then
                main.BackColor = Color.Green
            Else
                main.BackColor = Color.Red
            End If
        Next

                SelectedMainControl = CType(sender, MainControl)
                SelectedMainControl.BackColor = Color.Blue
        
        UpdateControls()
    End Sub
    Private Sub teststatus()
        For Each main As MainControl In Elementliste
            main.OK = True
            For Each test As TestElement In Testliste
                If test.ParentControl = main.Text Then
                    If Not test.ok Then
                        main.OK = False
                        Exit For
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub UpdateControls()
        Dim g As Graphics = Me.CreateGraphics
        Dim NumberOfControls = Me.Controls.Count
        Me.Text = NumberOfControls.ToString
        MyLayout.Controls.Clear()
        MyLayout.RowCount = Elementliste.Count + Testliste.Count + 1



        'Dim zaehler As Integer = 20
        Dim zaehler As Integer = 0
        For Each item As MainControl In Elementliste

            ' zaehler += item.Height + 20

            ' Me.Controls.Add(item)
            item.Dock = DockStyle.Fill
            MyLayout.Controls.Add(item)
            MyLayout.SetCellPosition(item, New TableLayoutPanelCellPosition With {.Column = 0, .Row = zaehler})
            zaehler += 1
            'item.Location = New Point(50, zaehler)

            If item.Text = SelectedMainControl.Text Then
                Dim mc As MainControl = item

                Dim ChildControls = From a As TestElement In Testliste Where a.ParentControl = mc.Text

                For Each child As TestElement In ChildControls
                    'child.Location = New Point(50 + item.Width + 20, zaehler)
                    'Me.Controls.Add(child)
                    ' zaehler += child.Height + 20

                    child.Dock = DockStyle.Fill
                    MyLayout.Controls.Add(child)
                    MyLayout.SetCellPosition(child, New TableLayoutPanelCellPosition With {.Column = 1, .Row = zaehler - 1})
                    zaehler += 1
                Next

            End If



        Next
    End Sub

    

    Private Sub NeuePrüfungToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuePrüfungToolStripMenuItem1.Click
        Dim Pruefname As String = InputBox("Prüfname")
        If Pruefname <> "" Then
            Gespeichert = False
            Dim pn As New TestElement
            With pn
                .TestName.Text = Pruefname
                .ParentControl = SelectedMainControl.Text
            End With
            Testliste.Add(pn)
            UpdateControls()
        End If

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveData()
    End Sub

    Private Sub SaveData()
        If MsgBox("Daten sichern?", vbYesNo, "Speichern") = MsgBoxResult.Yes Then
            Dim filename As String = "U:\Eigene Dateien\01_Funktionstest\99_Verlauf\Tests.xml"
            Dim sr As IO.StreamWriter = New IO.StreamWriter(filename)
            sr.AutoFlush = True
            'Maincontrols
            For Each item As MainControl In Elementliste
                sr.WriteLine("main;" + item.Text)
            Next
            'TestElemente
            For Each item As TestElement In Testliste
                sr.WriteLine("test;" + item.TestName.Text + ";" + item.ParentControl)
                If item.dt.Rows.Count > 0 Then
                    For Each row As DataRow In item.dt.Rows
                        sr.WriteLine("doc;" + item.TestName.Text + ";" + item.ParentControl + ";" + row(0) + ";" + row(1) + ";" + row(2))
                    Next
                End If
            Next
            sr.Close()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Elementliste = New List(Of MainControl)
        Testliste = New List(Of TestElement)
        SelectedMainControl = New MainControl
        Me.DoubleBuffered = True
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        SaveData()
        End
    End Sub

    Private Sub BearbeitenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BearbeitenToolStripMenuItem.Click

    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripMenuItem.Click
        SaveData()
    End Sub
 


    Private Sub ÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click
        Dim filename As String = "U:\Eigene Dateien\01_Funktionstest\99_Verlauf\Tests.xml"
        Dim sr As IO.StreamReader = New IO.StreamReader(filename)
        Dim data As New List(Of String)
        While Not sr.EndOfStream
            data.Add(sr.ReadLine)
        End While
        Elementliste.Clear()
        Testliste.Clear()
        Dim pn As TestElement
        For Each item As String In data
            Dim text() As String = item.Split(";")
            If text(0) = "main" Then
                Dim np As New MainControl
                With np
                    .Font = New Font("Verdana", 12)
                    .ReadOnly = True
                    .Text = text(1)
                    .Multiline = True
                    AddHandler .MouseClick, AddressOf SelectAnotherMainControl
                End With
                Elementliste.Add(np)
                SelectAnotherMainControl(np, Nothing)
            End If
            If text(0) = "test" Then
                pn = New TestElement
                With pn
                    .TestName.Text = text(1)
                    .ParentControl = text(2)
                End With
                Testliste.Add(pn)
            End If
            If text(0) = "doc" Then

                Dim i As Integer
                For i = 0 To Testliste.Count - 1
                    If (Testliste.Item(i).TestName.Text = text(1)) And _
                        (Testliste.Item(i).ParentControl = text(2)) Then Exit For
                Next
                Try
                    Testliste.Item(i).dt.Rows.Add(text(3), text(4), text(5))
                Catch
                    Testliste.Item(i).dt.Rows.Add(text(3), text(4))
                End Try
                Testliste.Item(i).ListBox1.DataSource = Testliste.Item(i).dt
                Testliste.Item(i).ListBox1.DisplayMember = "Filepath"
                Testliste.Item(i).ListBox2.DataSource = Testliste.Item(i).dt
                Testliste.Item(i).ListBox2.DisplayMember = "Date"
                If Testliste.Item(i).dt.Rows(Testliste.Item(i).dt.Rows.Count - 1)("OK") = "Yes" Then
                    Testliste.Item(i).ok = True
                End If
            End If
        Next
        sr.Close()
        SelectAnotherMainControl(Elementliste.Item(0), Nothing)
    End Sub

    Private Sub AktivesProduktLöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AktivesProduktLöschenToolStripMenuItem.Click
        Dim question As MsgBoxResult = MsgBox("Produkt wirklich aus liste löschen?", MsgBoxStyle.YesNo, "Produkt löschen")
        If question = MsgBoxResult.Yes Then
            Dim i As Integer
            For i = 0 To Elementliste.Count - 1
                If Elementliste.Item(i).Text = SelectedMainControl.Text Then Exit For
            Next
            Elementliste.RemoveAt(i)
            SelectAnotherMainControl(Elementliste.Item(0), Nothing)
        End If
    End Sub
End Class
