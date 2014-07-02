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
        Me.components = New System.ComponentModel.Container()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LadenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuesProduktHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeueVersionHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuePrüfungHinzufügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.PruefungDataGridView = New System.Windows.Forms.DataGridView()
        Me.PruefungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dokumente = New Dokumentverwaltung.Dokumente()
        Me.lblHint2 = New System.Windows.Forms.Label()
        Me.lblHint3 = New System.Windows.Forms.Label()
        Me.lblHint4 = New System.Windows.Forms.Label()
        Me.butFileDrop = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ProdukteDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProdukteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VersionenDataGridView = New System.Windows.Forms.DataGridView()
        Me.VersionenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblHint1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DocumentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocumentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.PruefungDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PruefungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dokumente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProdukteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VersionenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VersionenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DocumentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpeichernToolStripMenuItem, Me.LadenToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Enabled = False
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'LadenToolStripMenuItem
        '
        Me.LadenToolStripMenuItem.Enabled = False
        Me.LadenToolStripMenuItem.Name = "LadenToolStripMenuItem"
        Me.LadenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LadenToolStripMenuItem.Text = "Laden"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'AktionToolStripMenuItem
        '
        Me.AktionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuesProduktHinzufügenToolStripMenuItem, Me.NeueVersionHinzufügenToolStripMenuItem, Me.NeuePrüfungHinzufügenToolStripMenuItem})
        Me.AktionToolStripMenuItem.Name = "AktionToolStripMenuItem"
        Me.AktionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.AktionToolStripMenuItem.Text = "Aktion"
        '
        'NeuesProduktHinzufügenToolStripMenuItem
        '
        Me.NeuesProduktHinzufügenToolStripMenuItem.Name = "NeuesProduktHinzufügenToolStripMenuItem"
        Me.NeuesProduktHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NeuesProduktHinzufügenToolStripMenuItem.Text = "Neues Produkt hinzufügen"
        '
        'NeueVersionHinzufügenToolStripMenuItem
        '
        Me.NeueVersionHinzufügenToolStripMenuItem.Name = "NeueVersionHinzufügenToolStripMenuItem"
        Me.NeueVersionHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NeueVersionHinzufügenToolStripMenuItem.Text = "Neue Version hinzufügen"
        '
        'NeuePrüfungHinzufügenToolStripMenuItem
        '
        Me.NeuePrüfungHinzufügenToolStripMenuItem.Name = "NeuePrüfungHinzufügenToolStripMenuItem"
        Me.NeuePrüfungHinzufügenToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NeuePrüfungHinzufügenToolStripMenuItem.Text = "Neue Prüfung hinzufügen"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.AktionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.lblHint4)
        Me.SplitContainer3.Panel2.Controls.Add(Me.butFileDrop)
        Me.SplitContainer3.Size = New System.Drawing.Size(632, 108)
        Me.SplitContainer3.SplitterDistance = 460
        Me.SplitContainer3.SplitterWidth = 8
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.AutoScroll = True
        Me.SplitContainer4.Panel1.Controls.Add(Me.PruefungDataGridView)
        Me.SplitContainer4.Panel1.Controls.Add(Me.lblHint2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.AutoScroll = True
        Me.SplitContainer4.Panel2.Controls.Add(Me.DocumentsDataGridView)
        Me.SplitContainer4.Panel2.Controls.Add(Me.lblHint3)
        Me.SplitContainer4.Size = New System.Drawing.Size(460, 108)
        Me.SplitContainer4.SplitterDistance = 153
        Me.SplitContainer4.SplitterWidth = 8
        Me.SplitContainer4.TabIndex = 0
        '
        'PruefungDataGridView
        '
        Me.PruefungDataGridView.AllowUserToAddRows = False
        Me.PruefungDataGridView.AllowUserToDeleteRows = False
        Me.PruefungDataGridView.AutoGenerateColumns = False
        Me.PruefungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PruefungDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PruefungDataGridView.DataSource = Me.PruefungBindingSource
        Me.PruefungDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PruefungDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PruefungDataGridView.Name = "PruefungDataGridView"
        Me.PruefungDataGridView.ReadOnly = True
        Me.PruefungDataGridView.RowHeadersVisible = False
        Me.PruefungDataGridView.Size = New System.Drawing.Size(153, 108)
        Me.PruefungDataGridView.TabIndex = 2
        '
        'PruefungBindingSource
        '
        Me.PruefungBindingSource.DataMember = "Pruefung"
        Me.PruefungBindingSource.DataSource = Me.Dokumente
        '
        'Dokumente
        '
        Me.Dokumente.DataSetName = "Dokumente"
        Me.Dokumente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblHint2
        '
        Me.lblHint2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHint2.AutoSize = True
        Me.lblHint2.BackColor = System.Drawing.Color.Transparent
        Me.lblHint2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint2.Location = New System.Drawing.Point(3, 45)
        Me.lblHint2.Name = "lblHint2"
        Me.lblHint2.Size = New System.Drawing.Size(171, 18)
        Me.lblHint2.TabIndex = 2
        Me.lblHint2.Text = "No Version selected"
        '
        'lblHint3
        '
        Me.lblHint3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHint3.AutoSize = True
        Me.lblHint3.BackColor = System.Drawing.Color.Transparent
        Me.lblHint3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint3.Location = New System.Drawing.Point(76, 45)
        Me.lblHint3.Name = "lblHint3"
        Me.lblHint3.Size = New System.Drawing.Size(144, 18)
        Me.lblHint3.TabIndex = 2
        Me.lblHint3.Text = "No test selected"
        '
        'lblHint4
        '
        Me.lblHint4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHint4.AutoSize = True
        Me.lblHint4.BackColor = System.Drawing.Color.Transparent
        Me.lblHint4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint4.Location = New System.Drawing.Point(9, 45)
        Me.lblHint4.Name = "lblHint4"
        Me.lblHint4.Size = New System.Drawing.Size(144, 18)
        Me.lblHint4.TabIndex = 3
        Me.lblHint4.Text = "No test selected"
        '
        'butFileDrop
        '
        Me.butFileDrop.AllowDrop = True
        Me.butFileDrop.BackColor = System.Drawing.Color.ForestGreen
        Me.butFileDrop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butFileDrop.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butFileDrop.Location = New System.Drawing.Point(0, 0)
        Me.butFileDrop.Name = "butFileDrop"
        Me.butFileDrop.Size = New System.Drawing.Size(164, 108)
        Me.butFileDrop.TabIndex = 0
        Me.butFileDrop.Text = "Drop Files here"
        Me.butFileDrop.UseVisualStyleBackColor = False
        Me.butFileDrop.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProdukteDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.VersionenDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblHint1)
        Me.SplitContainer1.Size = New System.Drawing.Size(632, 116)
        Me.SplitContainer1.SplitterDistance = 210
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 11
        '
        'ProdukteDataGridView
        '
        Me.ProdukteDataGridView.AllowUserToAddRows = False
        Me.ProdukteDataGridView.AllowUserToDeleteRows = False
        Me.ProdukteDataGridView.AutoGenerateColumns = False
        Me.ProdukteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdukteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.ProdukteDataGridView.DataSource = Me.ProdukteBindingSource
        Me.ProdukteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdukteDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProdukteDataGridView.Name = "ProdukteDataGridView"
        Me.ProdukteDataGridView.ReadOnly = True
        Me.ProdukteDataGridView.RowHeadersVisible = False
        Me.ProdukteDataGridView.Size = New System.Drawing.Size(210, 116)
        Me.ProdukteDataGridView.TabIndex = 0
        '
        'ProdukteBindingSource
        '
        Me.ProdukteBindingSource.DataMember = "Produkte"
        Me.ProdukteBindingSource.DataSource = Me.Dokumente
        '
        'VersionenDataGridView
        '
        Me.VersionenDataGridView.AllowUserToAddRows = False
        Me.VersionenDataGridView.AllowUserToDeleteRows = False
        Me.VersionenDataGridView.AutoGenerateColumns = False
        Me.VersionenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VersionenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.VersionenDataGridView.DataSource = Me.VersionenBindingSource
        Me.VersionenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VersionenDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.VersionenDataGridView.Name = "VersionenDataGridView"
        Me.VersionenDataGridView.ReadOnly = True
        Me.VersionenDataGridView.RowHeadersVisible = False
        Me.VersionenDataGridView.Size = New System.Drawing.Size(414, 116)
        Me.VersionenDataGridView.TabIndex = 1
        '
        'VersionenBindingSource
        '
        Me.VersionenBindingSource.DataMember = "Versionen"
        Me.VersionenBindingSource.DataSource = Me.Dokumente
        '
        'lblHint1
        '
        Me.lblHint1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHint1.AutoSize = True
        Me.lblHint1.BackColor = System.Drawing.Color.Transparent
        Me.lblHint1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint1.Location = New System.Drawing.Point(108, 61)
        Me.lblHint1.Name = "lblHint1"
        Me.lblHint1.Size = New System.Drawing.Size(172, 18)
        Me.lblHint1.TabIndex = 1
        Me.lblHint1.Text = "No Product selected"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(632, 232)
        Me.SplitContainer2.SplitterDistance = 116
        Me.SplitContainer2.SplitterWidth = 8
        Me.SplitContainer2.TabIndex = 12
        '
        'DocumentsBindingSource
        '
        Me.DocumentsBindingSource.DataMember = "Documents"
        Me.DocumentsBindingSource.DataSource = Me.Dokumente
        '
        'DocumentsDataGridView
        '
        Me.DocumentsDataGridView.AllowUserToAddRows = False
        Me.DocumentsDataGridView.AllowUserToDeleteRows = False
        Me.DocumentsDataGridView.AutoGenerateColumns = False
        Me.DocumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocumentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.DocumentsDataGridView.DataSource = Me.DocumentsBindingSource
        Me.DocumentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DocumentsDataGridView.Name = "DocumentsDataGridView"
        Me.DocumentsDataGridView.ReadOnly = True
        Me.DocumentsDataGridView.RowHeadersVisible = False
        Me.DocumentsDataGridView.Size = New System.Drawing.Size(299, 108)
        Me.DocumentsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Produktname"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Produktname"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Freigegeben"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Freigegeben"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        Me.DataGridViewCheckBoxColumn4.Width = 72
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Datum"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 63
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Benutzer"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Benutzer"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 74
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Version"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Version"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Freigegeben"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Freigegeben"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Width = 72
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Datum"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 63
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Benutzer"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Benutzer"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 74
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Pruefung"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Pruefung"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Freigegeben"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Freigegeben"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 72
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Datum"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 63
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Benutzer"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Benutzer"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Dokument"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dokument"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Freigegeben"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Freigegeben"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 72
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Datum"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 63
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Benutzer"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Benutzer"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 74
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 256)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.SplitContainer3.Panel1.ResumeLayout(false)
        Me.SplitContainer3.Panel2.ResumeLayout(false)
        Me.SplitContainer3.Panel2.PerformLayout
        CType(Me.SplitContainer3,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer3.ResumeLayout(false)
        Me.SplitContainer4.Panel1.ResumeLayout(false)
        Me.SplitContainer4.Panel1.PerformLayout
        Me.SplitContainer4.Panel2.ResumeLayout(false)
        Me.SplitContainer4.Panel2.PerformLayout
        CType(Me.SplitContainer4,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer4.ResumeLayout(false)
        CType(Me.PruefungDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PruefungBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Dokumente,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        CType(Me.ProdukteDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProdukteBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.VersionenDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.VersionenBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        CType(Me.DocumentsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DocumentsDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AktionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuesProduktHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeueVersionHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuePrüfungHinzufügenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents butFileDrop As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblHint2 As System.Windows.Forms.Label
    Friend WithEvents lblHint3 As System.Windows.Forms.Label
    Friend WithEvents lblHint1 As System.Windows.Forms.Label
    Friend WithEvents lblHint4 As System.Windows.Forms.Label
    Friend WithEvents PruefungDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PruefungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dokumente As Dokumentverwaltung.Dokumente
    Friend WithEvents ProdukteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProdukteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VersionenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VersionenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpeichernToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LadenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DocumentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
