Public Class MainForm
    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub uxGenerateButton_Click(sender As System.Object, e As System.EventArgs) Handles uxGenerateButton.Click
        Dim passPhrase As New PassPhrase(Me.uxNumberOfWordsNumeric.Value,
                                         Me.uxMinWordLengthNumeric.Value,
                                         Me.uxMaxWordLengthNumeric.Value)
        MessageBox.Show(passPhrase.Generate)
    End Sub

    Private Sub uxExitButton_Click(sender As System.Object, e As System.EventArgs) Handles uxExitButton.Click
        Me.Close()
    End Sub
End Class
