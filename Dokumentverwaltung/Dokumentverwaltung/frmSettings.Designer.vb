<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.butOpenDocPath = New System.Windows.Forms.Button()
        Me.butOpenDatabasePath = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butCancel
        '
        Me.butCancel.Location = New System.Drawing.Point(12, 221)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(75, 23)
        Me.butCancel.TabIndex = 0
        Me.butCancel.Text = "Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(456, 221)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(75, 23)
        Me.butOK.TabIndex = 1
        Me.butOK.Text = "OK"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dokumentablage"
        '
        'txtDocs
        '
        Me.txtDocs.Location = New System.Drawing.Point(33, 29)
        Me.txtDocs.Name = "txtDocs"
        Me.txtDocs.Size = New System.Drawing.Size(449, 20)
        Me.txtDocs.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Datenbankpfad"
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(33, 85)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(449, 20)
        Me.txtDatabase.TabIndex = 5
        '
        'butOpenDocPath
        '
        Me.butOpenDocPath.Location = New System.Drawing.Point(488, 27)
        Me.butOpenDocPath.Name = "butOpenDocPath"
        Me.butOpenDocPath.Size = New System.Drawing.Size(39, 23)
        Me.butOpenDocPath.TabIndex = 6
        Me.butOpenDocPath.Text = "..."
        Me.butOpenDocPath.UseVisualStyleBackColor = True
        '
        'butOpenDatabasePath
        '
        Me.butOpenDatabasePath.Location = New System.Drawing.Point(488, 83)
        Me.butOpenDatabasePath.Name = "butOpenDatabasePath"
        Me.butOpenDatabasePath.Size = New System.Drawing.Size(39, 23)
        Me.butOpenDatabasePath.TabIndex = 7
        Me.butOpenDatabasePath.Text = "..."
        Me.butOpenDatabasePath.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 256)
        Me.Controls.Add(Me.butOpenDatabasePath)
        Me.Controls.Add(Me.butOpenDocPath)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDocs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.butCancel)
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butCancel As System.Windows.Forms.Button
    Friend WithEvents butOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDocs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents butOpenDocPath As System.Windows.Forms.Button
    Friend WithEvents butOpenDatabasePath As System.Windows.Forms.Button
End Class
