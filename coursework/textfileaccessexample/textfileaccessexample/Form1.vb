Imports System.IO

Public Class Form1
    Private BooksFile As System.IO.StreamReader
    Private SPLITLINE As Array
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
        Dim dataLine As String = Nothing
        Dim COUNT As Integer

        'checks to see if end of file reached
        If (BooksFile.Peek > -1) Then

            dataLine = BooksFile.ReadLine()
            Lbxtextdata.Items.Add(dataLine)


            SPLITLINE = Split(dataLine, ",")

            COUNT = SPLITLINE.GetUpperBound(0)

            TextBox1.Text = SPLITLINE(0)

            TextBox2.Text = SPLITLINE(1)

            TextBox3.Text = SPLITLINE(2)
        Else

            MsgBox("No more data to be read from file", MsgBoxStyle.Exclamation, "End of File")

        End If

    End Sub

End Class
