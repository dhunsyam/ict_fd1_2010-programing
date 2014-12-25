Public Class Form1
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        newfile()
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        newfile()
    End Sub
    Private Sub newfile()
        RichTextBox1.Text = ""
        ToolStripStatusLabel1.Text = "ready"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDialog1.AllowSomePages = True
            PrintDialog1.ShowHelp = True
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDialog1.AllowSomePages = True
            PrintDialog1.ShowHelp = True
            If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        openfile()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        openfile()
    End Sub
    Private Sub openfile()
        With OpenFileDialog1
            .Title = "open file"
            .Filter = "rich text files|*.rtf| text files| *.txt"
            .FileName = ""
            .CheckFileExists = True

        End With

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveFile()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFile()
    End Sub
    Private Sub savefile()
        SaveFileDialog1.Filter = "rich text files | *.rtf| text files| *.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then RichTextBox1.SaveFile(RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

End Class
