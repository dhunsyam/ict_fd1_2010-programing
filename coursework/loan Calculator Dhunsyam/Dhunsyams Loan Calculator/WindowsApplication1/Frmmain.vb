
Option Explicit On
'Application Created by Dhunsyam Daji
'Date Created 25/01/2011
'Application Requirements this allows all users to work out how much time it takes to pay back their loan
'and how much to pay back per month based on the current intrest which the user has to work out

Public Class Frmmain

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        'end program
        End
    End Sub

    Private Sub Btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnreset.Click
        'clear fields
        TxtLoanAmount.Clear()
        TxtLoanYears.Clear()
        TxtLoanRate.Clear()
        lblMonthlyPayment.Text = ""
        TxtLoanAmount.Text = ""
        DgvLoandetails.Rows.Clear()
    End Sub

    Private Sub Btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncalculate.Click
        Try
            Dim LoanAmount As Double
            Dim Payment As Double
            Dim InterestRate As Double
            Dim Interest As Double
            Dim Principle As Double
            Dim Years As Integer
            Dim PaymentPeriods As Integer

            'validate loan amount input
            If IsNumeric(TxtLoanAmount.Text) = False Then
                MsgBox("Loan amount must be numeric. Please enter a valid loan amount.")
                TxtLoanAmount.Clear()
                TxtLoanAmount.Focus()
                Exit Sub
            End If

            'validate loan years input
            If IsNumeric(TxtLoanYears.Text) = False Then
                MsgBox("Loan years must be numeric. Please enter a valid years amount.")
                TxtLoanYears.Clear()
                TxtLoanYears.Focus()
                Exit Sub
            End If

            'validate loan rate input
            If IsNumeric(TxtLoanRate.Text) = False Then
                MsgBox("Loan rate must be numeric. Please enter a valid rate amount.")
                TxtLoanRate.Clear()
                TxtLoanRate.Focus()
                Exit Sub
            End If

            'set loan variables
            LoanAmount = TxtLoanAmount.Text
            Years = TxtLoanYears.Text
            InterestRate = TxtLoanRate.Text

            'calulate total payment periods
            PaymentPeriods = Years * 12

            'if rate is in percent form convert to decimal
            If InterestRate > 1 Then InterestRate = InterestRate / 100

            'calculate monthly payment and return value
            Payment = (LoanAmount * Math.Pow((InterestRate / 12) + 1, (PaymentPeriods)) * InterestRate / 12) / (Math.Pow(InterestRate / 12 + 1, (PaymentPeriods)) - 1)

            'display calculated payment
            lblMonthlyPayment.Text = "Monthly Payment: " & FormatCurrency(Payment)

            'clear datagrid view control (remove all rows)
            DgvLoandetails.Rows.Clear()

            'setup progress bar
            Pbloan.Minimum = 1
            Pbloan.Maximum = PaymentPeriods
            Pbloan.Value = 1
            Pbloan.Visible = True

            'loop the loan payment periods displaying loan details
            Dim i As Integer
            For i = 1 To PaymentPeriods

                'increase progress bar
                Pbloan.Value = i

                'set interest
                Interest = (LoanAmount * InterestRate) / 12

                'set loan amount
                LoanAmount = (LoanAmount - Payment) + Interest

                'set principle
                Principle = Payment - Interest

                'output loan details
                DgvLoandetails.Rows.Add()
                DgvLoandetails.Item("Month", i - 1).Value = i
                DgvLoandetails.Item("Payment", i - 1).Value = FormatCurrency(Payment)
                DgvLoandetails.Item("Interest", i - 1).Value = FormatCurrency(Interest)
                DgvLoandetails.Item("Principle", i - 1).Value = FormatCurrency(Principle)
                DgvLoandetails.Item("LoanAmount", i - 1).Value = FormatCurrency(LoanAmount)
            Next

            'hide progress bar now that processing is completed
            Pbloan.Visible = False

        Catch ex As Exception
            MsgBox("Error: " & ex.Message.ToString())
        End Try
    End Sub
End Class
