Public Class DiskWriterDialog
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Using dialog As New SaveFileDialog
            dialog.AddExtension = True
            dialog.DefaultExt = "webm"
            dialog.Title = "Save file"
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            Me.OutFile.Text = dialog.FileName
            Me.OutFile.Update()
        End Using
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class