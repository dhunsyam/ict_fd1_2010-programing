Public Class Form1

    Private Sub Looper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Looper.Click

        Dim num, index, result As Integer
        num = TextBox1.Text
        For index = -1 To -12 Step -1

            result = index * num
            timestable.Items.Add(num & " * " & index & " = " & result)

        Next
        Loopcount = -12
        While loopcount <= -1
            List(box2.items.Add(Multiple & "*" & loopcount & "= " & loopcount * multiple))
            loopcount = loopcount + 1
        End While

    End Sub


End Class
