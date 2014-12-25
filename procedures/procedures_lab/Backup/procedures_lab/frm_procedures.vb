Public Class frm_procedures


    Private Sub Cbintrest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbintrest.SelectedIndexChanged
        Cbintrest = intrate / 100
        monthRate = interestRate / conversionPeriod
        numberOfPayments = loanLength * conversionPeriod
        MonthlyPayment = Pmt(monthRate, numberOfPayments, -loanAmount)
        MsgBox(MonthlyPayment, MsgBoxStyle.OkOnly, "Monthly Payment")

    End Sub


End Class
