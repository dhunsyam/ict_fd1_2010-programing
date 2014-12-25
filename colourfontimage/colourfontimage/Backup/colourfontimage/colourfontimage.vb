Public Class colourfontimage

    Private Sub Btncolour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncolour.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnfont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfont.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font


        End If
    End Sub

    Private Sub Btnimg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnimg.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)

            Catch ex As Exception
                MsgBox("Not An image")
            End Try
        End If
    End Sub
End Class
