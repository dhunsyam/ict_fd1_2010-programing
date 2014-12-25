Public Class Form1

    Private Sub Lblresult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lblresult.Click

    End Sub

    Private Sub Btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Lblresult.Text = " "
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            Dim num1 As Long = Val(TextBox1.Text)
            Dim num2 As Long = Val(TextBox2.Text)
            Lblresult.Text = num1 + num2

        Catch ex As OverflowException
            MsgBox("up to 2 billion max")
        End Try


    End Sub
End Class
