Public Class Frmdebugtest

    Private Sub Btnquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnquit.Click
        Application.Exit()
    End Sub

    Private Sub Btntest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntest.Click
        Dim age As Integer

        age = txbinput.Text

        If age >= 13 And age < 20 Then

            Txboutput.Text = "you are a teenager"
        Else
            Txboutput.Text = "you are not a teenager"
        End If

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Txboutput.Clear()
    End Sub

    Private Sub Frmdebugtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
