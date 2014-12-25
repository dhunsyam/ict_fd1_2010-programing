Public Class Frm_more_loops

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        'Declare a loopcounter as a whole number…
        Dim Factorial As Double = 1.0
        Dim iLoop, InputValue As Integer
        ' Read input value from form control
        InputValue = NumericUpDown.Value
        ' Calculate factorial of the value
        ' in 'going-up' loop.
        ' n! = n.(n-1.n-2). ... 1 => going-down iteration
        ' = 1. ... (n-2)(n-1)n => going-up iteration
        For iLoop = 1 To InputValue
            Factorial *= iLoop
        Next
        ' Display result
        Rtb.Text = "The factorial of " & CStr(InputValue) & _
        ControlChars.CrLf & "is " & _
        CStr(Factorial)
        Rtb.Visible = True
    End Sub
End Class
       