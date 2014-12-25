
Public Class Account
    Private accountNumber As Integer
    Private currentBalance As Integer
    Private overdraftLimit As Integer

    Sub New(ByVal accountNo As Integer)
        accountNumber = accountNo
    End Sub

    Public Function getAccountNumber() As String
        Return accountNumber.ToString()
    End Function

    Public Function setBalance(ByVal balance As String) As Double
        currentBalance = balance
    End Function

    Public Function deposit(ByVal amount As String) As Double
        If (amount > 0) Then
            currentBalance += amount
        Else
            MsgBox("Amount to be deposited / transferred is invalid - Deposit will NOT be made")
        End If

    End Function

    Public Sub withdraw(ByVal amount As Double)
        withdraw(currentBalance - amount)
    End Sub

    Public Sub closeAccount()
        withdraw(currentBalance)
    End Sub

    Public Function getBalance() As Double
        Return currentBalance
    End Function
End Class
