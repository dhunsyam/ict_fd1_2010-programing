Imports System.IO

Public Class Form1
    Private BooksFile As System.IO.StreamReader
    Private Sub Btnopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnopen.Click
        Dim filename As String

        OpenFileDialog1.Title = "Locate the Books text file"
        OpenFileDialog1.Filter = "Books CSV File (*.txt) | *.txt"

        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            'a file located
            filename = OpenFileDialog1.FileName
            'open the file for reading
            BooksFile = System.IO.File.OpenText(filename)
            Lblfilename.Text = filename
            Btnreadline.Enabled = True
        Else
            MessageBox.Show("Please select a valid Books file")
            Lblfilename.Text = "(File not opened)"
        End If

    End Sub

    Private Sub Btnreadline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnreadline.Click
        Dim dataLine As String

        'checks to see if end of file reached
        If (BooksFile.Peek > -1) Then

            dataLine = BooksFile.ReadLine()
            Lbxtextdata.Items.Add(dataLine)

        Else

            MsgBox("No more data to be read from file", MsgBoxStyle.Exclamation, "End of File")

        End If

    End Sub


   

    Private Sub Lbxtextdata_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbxtextdata.SelectedIndexChanged

    End Sub
End Class
