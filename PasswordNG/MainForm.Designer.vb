<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.uxPassPhraseRadioButton = New System.Windows.Forms.RadioButton()
        Me.uxNumberOfWordsLabel = New System.Windows.Forms.Label()
        Me.uxMinWordLengthLabel = New System.Windows.Forms.Label()
        Me.uxMaxWordLengthLabel = New System.Windows.Forms.Label()
        Me.uxNumberOfWordsNumeric = New System.Windows.Forms.NumericUpDown()
        Me.uxMinWordLengthNumeric = New System.Windows.Forms.NumericUpDown()
        Me.uxMaxWordLengthNumeric = New System.Windows.Forms.NumericUpDown()
        Me.uxGenerateButton = New System.Windows.Forms.Button()
        Me.uxExitButton = New System.Windows.Forms.Button()
        Me.uxAboutButton = New System.Windows.Forms.Button()
        CType(Me.uxNumberOfWordsNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxMinWordLengthNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxMaxWordLengthNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxPassPhraseRadioButton
        '
        Me.uxPassPhraseRadioButton.AutoSize = True
        Me.uxPassPhraseRadioButton.Location = New System.Drawing.Point(12, 12)
        Me.uxPassPhraseRadioButton.Name = "uxPassPhraseRadioButton"
        Me.uxPassPhraseRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.uxPassPhraseRadioButton.TabIndex = 0
        Me.uxPassPhraseRadioButton.TabStop = True
        Me.uxPassPhraseRadioButton.Text = "Pass &Phrase"
        Me.uxPassPhraseRadioButton.UseVisualStyleBackColor = True
        '
        'uxNumberOfWordsLabel
        '
        Me.uxNumberOfWordsLabel.AutoSize = True
        Me.uxNumberOfWordsLabel.Location = New System.Drawing.Point(74, 45)
        Me.uxNumberOfWordsLabel.Name = "uxNumberOfWordsLabel"
        Me.uxNumberOfWordsLabel.Size = New System.Drawing.Size(93, 13)
        Me.uxNumberOfWordsLabel.TabIndex = 1
        Me.uxNumberOfWordsLabel.Text = "Number of &Words:"
        Me.uxNumberOfWordsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'uxMinWordLengthLabel
        '
        Me.uxMinWordLengthLabel.AutoSize = True
        Me.uxMinWordLengthLabel.Location = New System.Drawing.Point(51, 71)
        Me.uxMinWordLengthLabel.Name = "uxMinWordLengthLabel"
        Me.uxMinWordLengthLabel.Size = New System.Drawing.Size(116, 13)
        Me.uxMinWordLengthLabel.TabIndex = 2
        Me.uxMinWordLengthLabel.Text = "Mi&nimum Word Length:"
        Me.uxMinWordLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'uxMaxWordLengthLabel
        '
        Me.uxMaxWordLengthLabel.AutoSize = True
        Me.uxMaxWordLengthLabel.Location = New System.Drawing.Point(48, 97)
        Me.uxMaxWordLengthLabel.Name = "uxMaxWordLengthLabel"
        Me.uxMaxWordLengthLabel.Size = New System.Drawing.Size(119, 13)
        Me.uxMaxWordLengthLabel.TabIndex = 3
        Me.uxMaxWordLengthLabel.Text = "Ma&ximum Word Length:"
        Me.uxMaxWordLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'uxNumberOfWordsNumeric
        '
        Me.uxNumberOfWordsNumeric.Location = New System.Drawing.Point(173, 43)
        Me.uxNumberOfWordsNumeric.Name = "uxNumberOfWordsNumeric"
        Me.uxNumberOfWordsNumeric.Size = New System.Drawing.Size(60, 20)
        Me.uxNumberOfWordsNumeric.TabIndex = 4
        Me.uxNumberOfWordsNumeric.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'uxMinWordLengthNumeric
        '
        Me.uxMinWordLengthNumeric.Location = New System.Drawing.Point(173, 69)
        Me.uxMinWordLengthNumeric.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.uxMinWordLengthNumeric.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.uxMinWordLengthNumeric.Name = "uxMinWordLengthNumeric"
        Me.uxMinWordLengthNumeric.Size = New System.Drawing.Size(60, 20)
        Me.uxMinWordLengthNumeric.TabIndex = 5
        Me.uxMinWordLengthNumeric.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'uxMaxWordLengthNumeric
        '
        Me.uxMaxWordLengthNumeric.Location = New System.Drawing.Point(173, 95)
        Me.uxMaxWordLengthNumeric.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.uxMaxWordLengthNumeric.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.uxMaxWordLengthNumeric.Name = "uxMaxWordLengthNumeric"
        Me.uxMaxWordLengthNumeric.Size = New System.Drawing.Size(60, 20)
        Me.uxMaxWordLengthNumeric.TabIndex = 6
        Me.uxMaxWordLengthNumeric.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'uxGenerateButton
        '
        Me.uxGenerateButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.uxGenerateButton.Location = New System.Drawing.Point(250, 342)
        Me.uxGenerateButton.Name = "uxGenerateButton"
        Me.uxGenerateButton.Size = New System.Drawing.Size(75, 23)
        Me.uxGenerateButton.TabIndex = 7
        Me.uxGenerateButton.Text = "&Generate"
        Me.uxGenerateButton.UseVisualStyleBackColor = True
        '
        'uxExitButton
        '
        Me.uxExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.uxExitButton.Location = New System.Drawing.Point(12, 342)
        Me.uxExitButton.Name = "uxExitButton"
        Me.uxExitButton.Size = New System.Drawing.Size(75, 23)
        Me.uxExitButton.TabIndex = 8
        Me.uxExitButton.Text = "E&xit"
        Me.uxExitButton.UseVisualStyleBackColor = True
        '
        'uxAboutButton
        '
        Me.uxAboutButton.Location = New System.Drawing.Point(93, 342)
        Me.uxAboutButton.Name = "uxAboutButton"
        Me.uxAboutButton.Size = New System.Drawing.Size(75, 23)
        Me.uxAboutButton.TabIndex = 9
        Me.uxAboutButton.Text = "&About"
        Me.uxAboutButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 377)
        Me.Controls.Add(Me.uxAboutButton)
        Me.Controls.Add(Me.uxExitButton)
        Me.Controls.Add(Me.uxGenerateButton)
        Me.Controls.Add(Me.uxMaxWordLengthNumeric)
        Me.Controls.Add(Me.uxMinWordLengthNumeric)
        Me.Controls.Add(Me.uxNumberOfWordsNumeric)
        Me.Controls.Add(Me.uxMaxWordLengthLabel)
        Me.Controls.Add(Me.uxMinWordLengthLabel)
        Me.Controls.Add(Me.uxNumberOfWordsLabel)
        Me.Controls.Add(Me.uxPassPhraseRadioButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "PasswordNG"
        CType(Me.uxNumberOfWordsNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxMinWordLengthNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxMaxWordLengthNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uxPassPhraseRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents uxNumberOfWordsLabel As System.Windows.Forms.Label
    Friend WithEvents uxMinWordLengthLabel As System.Windows.Forms.Label
    Friend WithEvents uxMaxWordLengthLabel As System.Windows.Forms.Label
    Friend WithEvents uxNumberOfWordsNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents uxMinWordLengthNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents uxMaxWordLengthNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents uxGenerateButton As System.Windows.Forms.Button
    Friend WithEvents uxExitButton As System.Windows.Forms.Button
    Friend WithEvents uxAboutButton As System.Windows.Forms.Button

End Class
