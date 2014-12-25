Public Class Frmmain

    Private Sub LblCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCount.Click

    End Sub

    Private Sub btn_local_count_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_local_count.Click
        Dim count As Integer
        count = count + 1
        LblCount.Text = count

    End Sub

    Private Sub BtnstaticCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnstaticCount.Click
        Static count As Integer
        count = count + 1
        LblCount.Text = count

    End Sub
    Private count As Integer
    Private Sub btnGlobalCount1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlobalCount1.Click
        count = count + 1
        LblCount.Text = count

    End Sub


    Private Sub BtnGlobalCount2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGlobalCount2.Click
        count = count + 1
        LblCount.Text = count
    End Sub

    Private Sub Frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
