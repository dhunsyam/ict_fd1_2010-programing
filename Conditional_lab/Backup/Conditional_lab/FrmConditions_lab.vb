Public Class FrmConditions_lab

    Private Sub BtnEqualto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEqualto.Click
        'check if the value in the first textbox is the same as the one in the second one
        If tbvalue1.Text = tbvalue2.Text Then
            'if they're the same, display the word "True" in the label
            Lblresult.Text = "True"
            Lblresult.BackColor = Color.Lime
        Else
            'if they're not, display the word "False" in the label
            Lblresult.Text = "False"
            Lblresult.BackColor = Color.Red
        End If

    End Sub

    Private Sub BtnNotEqualto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotEqualto.Click
        'check if the value in the first textbox is not the same as the one in the second one
        If tbvalue1.Text <> tbvalue2.Text Then
            'if they're the same, display the word "True" in the label
            Lblresult.Text = "True"
            Lblresult.BackColor = Color.Lime
        Else
            'if they're not, display the word "False" in the label
            Lblresult.Text = "False"
            Lblresult.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnlessthan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlessthan.Click
        'check if the value in the first textbox is  less than the one in the second one
        If tbvalue1.Text < tbvalue2.Text Then
            'if they're diffrent, display the word "True" in the label
            Lblresult.Text = "True"
            Lblresult.BackColor = Color.Lime
        Else
            'if they're not, display the word "False" in the label
            Lblresult.Text = "False"
            Lblresult.BackColor = Color.Red

        End If
    End Sub

    Private Sub BtnGreaterthan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGreaterthan.Click
        'check if the value in the first textbox is  more than the one in the second one
        If tbvalue1.Text > tbvalue2.Text Then
            'if they're diffrent, display the word "True" in the label
            Lblresult.Text = "True"
            Lblresult.BackColor = Color.Lime
        Else
            'if they're not, display the word "False" in the label
            Lblresult.Text = "False"
            Lblresult.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btngreaterthanorequalto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btngreaterthanorequalto.Click
        'check if the value in the first textbox is  greater than or equal to the one in the second one
        If tbvalue1.Text >= tbvalue2.Text Then
            'if they're diffrent, display the word "True" in the label
            Lblresult.Text = "True"
            Lblresult.BackColor = Color.Lime
        Else
            'if they're not, display the word "False" in the label
            Lblresult.Text = "False"
            Lblresult.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnlessthanorequalto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlessthanorequalto.Click
        'check if the value in the first textbox is  less than or equal to the one in the second one
        If tbvalue1.Text <= tbvalue2.Text Then
            'if they're diffrent, display the word "True" in the label
            Lblresult.Text = "True"
            Lblresult.BackColor = Color.Lime
        Else
            'if they're not, display the word "False" in the label
            Lblresult.Text = "False"
            Lblresult.BackColor = Color.Red
        End If
    End Sub

    Private Sub FrmConditions_lab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
