Public Class lotto

    Private Sub Clear()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Btnget.Enabled = True
        Btnreset.Enabled = False
    End Sub

    Private Sub lotto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear()
        Randomize()

    End Sub

    Private Sub Btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnreset.Click
        Clear()
    End Sub

    Private Sub Btnget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnget.Click

        Dim i, r, temp, nums(50) As Integer

        For i = 1 To 49
            nums(i) = i
        Next

        For i = 1 To 49
            r = Int(49 * Rnd()) + 1
            temp = nums(i)
            nums(i) = nums(r)
            nums(r) = temp
        Next
        Label1.Text = nums(1)
        Label2.Text = nums(2)
        Label3.Text = nums(3)
        Label4.Text = nums(4)
        Label5.Text = nums(5)
        Label6.Text = nums(6)

        Btnget.Enabled = False
        Btnreset.Enabled = True

    End Sub
End Class
