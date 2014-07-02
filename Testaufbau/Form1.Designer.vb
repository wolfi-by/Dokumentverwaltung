<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuePrüfungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuePrüfungToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktivesProduktLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuePrüfungToolStripMenuItem, Me.NeuePrüfungToolStripMenuItem1, Me.AktivesProduktLöschenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'NeuePrüfungToolStripMenuItem
        '
        Me.NeuePrüfungToolStripMenuItem.Name = "NeuePrüfungToolStripMenuItem"
        Me.NeuePrüfungToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NeuePrüfungToolStripMenuItem.Text = "Neues Produkt"
        '
        'NeuePrüfungToolStripMenuItem1
        '
        Me.NeuePrüfungToolStripMenuItem1.Name = "NeuePrüfungToolStripMenuItem1"
        Me.NeuePrüfungToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NeuePrüfungToolStripMenuItem1.Text = "Neue Prüfung"
        '
        'MyLayout
        '
        Me.MyLayout.AutoScroll = True
        Me.MyLayout.AutoSize = True
        Me.MyLayout.ColumnCount = 2
        Me.MyLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.07042!))
        Me.MyLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.92958!))
        Me.MyLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyLayout.Location = New System.Drawing.Point(0, 24)
        Me.MyLayout.Name = "MyLayout"
        Me.MyLayout.RowCount = 2
        Me.MyLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MyLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MyLayout.Size = New System.Drawing.Size(284, 238)
        Me.MyLayout.TabIndex = 1
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'AktivesProduktLöschenToolStripMenuItem
        '
        Me.AktivesProduktLöschenToolStripMenuItem.Name = "AktivesProduktLöschenToolStripMenuItem"
        Me.AktivesProduktLöschenToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.AktivesProduktLöschenToolStripMenuItem.Text = "Aktives Produkt löschen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MyLayout)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuePrüfungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuePrüfungToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ÖffnenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AktivesProduktLöschenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
