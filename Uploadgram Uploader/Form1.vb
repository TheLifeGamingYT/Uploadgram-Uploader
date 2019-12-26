Public Class MainForm

    Dim localfile As String

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click

        OpenFileDialog1.ShowDialog()
        localfile = OpenFileDialog1.FileName
        TxtBoxPath.Text = localfile

    End Sub
End Class
