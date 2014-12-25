Public Class Form1

    Private Sub btngen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngen.Click

        Tb1.Text = Int(Rnd() * 4)
        Select Case Tb1.Text
            Case 0
                Tb1.Text = "GWH28-DGCMP-P6RC4-6J4MT-3HFDY"
            Case 1
                Tb1.Text = "rm8d4-b3fkx-3ryyv-8dgwp-vtxp3"
            Case 2
                Tb1.Text = "WFDWY-XQXJF-RHRYG-BG7RQ-BBDH"
            Case 3
                Tb1.Text = "HCVCD-M87YF-Q6CHV-M236Y-RJB2Q "
        End Select


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Solo___IYAZ, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Btnmute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmute.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstart.Click
        My.Computer.Audio.Play(My.Resources.Solo___IYAZ, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
