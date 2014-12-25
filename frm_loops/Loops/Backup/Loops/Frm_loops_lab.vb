Public Class Frm_loops_lab



    Private Sub BtnCalculatetable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculatetable.Click
        'what do the following two lines of code do?
        Dim LoopCounter As Integer
        Dim CurrentValue As Integer = nmSelectNumber.Value
        Dim displaystring As String
        Lbltimestables.Text = "Times table for: " & CurrentValue
        Lblupto.Text = "Up To 12"

        'what does the following line of code do?
        lbxtimestabledisplay.Items.Clear()

        'set up FOR...NEXT loop to calcuate times table from 1 to 12
        For LoopCounter = 1 To 12
            'create the formatted string to be displayed...
            displaystring = CStr(CurrentValue) & " x " & (LoopCounter) & "  = " & CStr(CurrentValue * LoopCounter)

            '... and display it
            lbxtimestabledisplay.Items.Add(displaystring)
        Next

    End Sub

    Private Sub Btnchangelimit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnchangelimit.Click
        'what do the following two lines of code do? the 3rd dim declares the displaystring used later
        Dim LoopCounter As Integer
        Dim CurrentValue As Integer = nmchangelimit.Value
        Dim displaystring As String

        Lbltimestables.Text = "Times table for: " & CurrentValue
        Lblupto.Text = "Up To:" & nmchangelimit.Value

        'what does the following line of code do?
        lbxtimestabledisplay.Items.Clear()
        'this keeps looping if less than 12 which is  the limit if this is changed then the limit is changed
        LoopCounter = 1
        Do
            If LoopCounter > nmchangelimit.Value Then

                Exit Do
            End If
        

            'create the formatted string to be displayed... the x is changed so it looks like times tables 
            displaystring = (CurrentValue) & " x " & (LoopCounter) & "  = " & (CurrentValue * LoopCounter)
            LoopCounter = LoopCounter + 1

            '... and display it and it also loops if the value is more than or equal to 1
            lbxtimestabledisplay.Items.Add(displaystring)
        Loop While LoopCounter >= 1
    End Sub
End Class




