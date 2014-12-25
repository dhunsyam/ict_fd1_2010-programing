Public Class frmAccounts
    Dim accountNumber As Integer
    Dim currentBalance As Double
    Dim amount As Double



    Public Sub New(ByVal accountNo As Integer)
        accountNumber = accountNo
    End Sub

    Public Function getAccountNumber() As String
        Return accountNumber.ToString()
    End Function

    Private Sub setBalance(ByVal balance As Double)
        currentBalance = balance
    End Sub

    Public Function getBalance() As Double
        Return currentBalance
    End Function


    Private Sub Btndeposit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndeposit1.Click
        If (amount > 0) Then
            currentBalance += amount
        Else
            MsgBox("Amount to be deposited / transferred is invalid - Deposit will NOT be made")
        End If
    End Sub

    Private Sub Btndeposit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndeposit2.Click
        If (amount > 0) Then
            currentBalance += amount
        Else
            MsgBox("Amount to be deposited / transferred is invalid - Deposit will NOT be made")
        End If
    End Sub
End Class
