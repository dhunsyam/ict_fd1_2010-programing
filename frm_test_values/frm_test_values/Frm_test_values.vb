Public Class Frm_test_values
    Private Sub BtnEqualto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnloop.Click



    End Sub
    Private Sub Btnloop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnloop.Click
        If CInt(Tb1.Text) = CInt(Tb2.Text) Then
            'if they're the same, display the word "True" in the label
            lblcomparevalue.Text = "The value in both boxes are equal"
        ElseIf CInt(Tb1.Text) <> CInt(Tb2.Text) Then
            'if they're the same, display the word "True" in the label
            lblcomparevalue.Text = "The value in both boxes are not equal"
        End If


        If CInt(Tb1.Text) < CInt(Tb2.Text) Then
            'if they're diffrent, display the word "True" in the label
            lblcomparevalue2.Text = "The value in box on the right is bigger than the one in the box on the left"


        ElseIf CInt(Tb1.Text) > CInt(Tb2.Text) Then
            'if they're diffrent, display the word "True" in the label
            lblcomparevalue2.Text = "The value in box on the left is bigger than the one in the box on the right"
        ElseIf CInt(Tb1.Text) = CInt(Tb2.Text) Then
            'if they're the same, display the word "True" in the label
            lblcomparevalue2.Text = Nothing
        ElseIf CInt(Tb1.Text) <> CInt(Tb2.Text) Then
            'if they're the same, display the word "True" in the label
            lblcomparevalue2.Text = Nothing
        End If

    End Sub

    Private Sub Frm_test_values_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Lbltestvalues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbltestvalues.Click

    End Sub

    Private Sub Lblinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lblinfo.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lblinfo.Left = Lblinfo.Left - 1
        If Lblinfo.Left = -300 Then
            Lblinfo.Left = 600
        End If
    End Sub
End Class
