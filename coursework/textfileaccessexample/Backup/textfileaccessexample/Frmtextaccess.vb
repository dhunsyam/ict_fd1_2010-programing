Option Explicit On
Imports System.IO
'sets the code so all dims have to be declared
'Application Created by Dhunsyam Daji
'Date Created 19/03/2011
'Application Requirements this allows all users to read a text file with commas and split over 4 text boxes for each section and save the text file and create a backup
Public Class Frmtextaccess
    'private dims which declare the streamreader and array
    Private BooksFile As System.IO.StreamReader
    Private SPLITLINE As Array
    Private Sub Btnopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnopen.Click
        ' delaring a string
        Dim filename As String
        'sets the open diologebox filters
        OpenFileD.Title = "Locate the Books text file"
        OpenFileD.Filter = "Books CSV File (*.txt) | *.txt"
        If (OpenFileD.ShowDialog() = DialogResult.OK) Then
            'a file located
            filename = OpenFileD.FileName
            'open the file for reading
            BooksFile = System.IO.File.OpenText(filename)
            Lblfilename.Text = filename
            Btnreadline.Enabled = True
        Else
            'otherwise it will show a messagebox saying the message below
            MessageBox.Show("Please select a valid Books file")
            Lblfilename.Text = "(File not opened)"
        End If
    End Sub

    Private Sub Btnreadline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnreadline.Click
        Dim dataLine As String = Nothing
        Dim COUNT As Integer
        'checks to see if end of file reached
        If (BooksFile.Peek > -1) Then
            'it reads the line of the text file
            dataLine = BooksFile.ReadLine()
            'adds to the dataline
            Lbxtextdata.Items.Add(dataLine)
            'splits the dataline
            SPLITLINE = Split(dataLine, ",")
            'starts the count 
            COUNT = SPLITLINE.GetUpperBound(0)
            'splits the text to the relevent textboxes
            Txbtitle.Text = SPLITLINE(0)
            Txbauthor.Text = SPLITLINE(1)
            Txbyear.Text = SPLITLINE(2)
            Txbpublish.Text = SPLITLINE(3)
        Else
            'if theres no more text in the doucment then it shows this message box
            MsgBox("No more data to be read from file", MsgBoxStyle.Exclamation, "End of File")
        End If
    End Sub
    Private Sub btnbackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbackup.Click
        'creates a string
        Dim filename As String
        'if there is no file it backs up the document otherwise it creates 
        If (File.Exists(filename & ".bkp")) Then
            MsgBox("File already backed up")
        Else
            File.Create(filename & ".bkp")
            MsgBox("backup created sucessfully")
        End If
    End Sub
    Private Sub ClearTextBoxes()
        'clears all the text boxes function specifies what to clear
        Txbtitle.Text = ""
        Txbauthor.Text = ""
        Txbyear.Text = ""
        Txbpublish.Text = ""
    End Sub
    Private Sub Lbxtextdata_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbxtextdata.DoubleClick
        'clear all text boxes 
        ClearTextBoxes()
        'dims to declare
        Dim dataLine2 As String = Nothing
        Dim COUNT As Integer
        'same code as above it redoes the splitline

        dataLine2 = Lbxtextdata.SelectedItem
        SPLITLINE = Split(dataLine2, ",")
        COUNT = SPLITLINE.GetUpperBound(0)
        If SPLITLINE(0) <> Nothing Then
            Txbtitle.Text = SPLITLINE(0)
        End If
        If SPLITLINE(1) <> Nothing Then
            Txbauthor.Text = SPLITLINE(1)
        End If
        If SPLITLINE(2) <> Nothing Then
            Txbyear.Text = SPLITLINE(2)
        End If
        If SPLITLINE(3) <> Nothing Then
            Txbpublish.Text = SPLITLINE(3)
        Else
            'if the splitline fails then it will use this
            MsgBox(dataLine2, MsgBoxStyle.OkOnly, " ")
        End If
    End Sub
    Dim writer As IO.StreamWriter
    ' dim to write out to text file
    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Dim i As Integer
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        'sets all the filters 
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            'if the dialog box is ok then it will continue
            writer = New IO.StreamWriter(saveFileDialog1.FileName)
            For i = 0 To Lbxtextdata.Items.Count - 1
                writer.WriteLine(Lbxtextdata.Items.Item(i))
                'it writes using streamwriter and saves whatever the user calls the file name 
            Next
            writer.Flush()
            writer.Close()
            'closes and finishes streamwriter
        End If
    End Sub

    Private Sub Btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click
        ClearTextBoxes()
        'clears the textboxes
    End Sub
End Class
