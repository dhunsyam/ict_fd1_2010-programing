﻿Public Class frmprogram_flow_lab
    ' declare a global variable to hold the number to be guessed
    Private NumberToGuess As Integer


    'create a global random number generator using the .NET                                                                                                                                                                                                                                   	'Random' class
    Dim RandomGenerator As New Random

    Private Sub frmprogram_flow_lab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'get the next random integer number between 0 - 100 to 		be guessed
        NumberToGuess = RandomGenerator.Next(0, 100)

    End Sub


    Private Sub btnGuessNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnguessnumber.Click
        'declare a local integer variable to hold the guess
        Dim GuessedNumber As Int16
        'declare a 'static' integer to keep track of number of guesses made
        Dim NumberofAttempts As Integer
        'declare a local boolean variable to indicate if this guess was successful
        Dim GuessedCorrectly As String = False
        'increment number of attempts made and display it
        NumberofAttempts = NumberofAttempts + 1
        Lblguessessofar.Text = "Number of attempts so far: " & NumberofAttempts
        'get the entered text and convert it into an Integer
        GuessedNumber = Convert.ToInt32(MsktbguessNumber.Text)

        'if the guess is correct...
        If NumberToGuess = GuessedNumber Then
            Lblguessnumber.Text = "Well Done!!" & vbCrLf & "You 			Guessed it in " & NumberofAttempts & vbCrLf & "Start 			Guessing Again..."
            GuessedCorrectly = True
            'otherwise, if the guess is too low
        ElseIf GuessedNumber <= NumberToGuess Then
            'add number to the 'too low' list
            Lstlowervalues.Items.Add(GuessedNumber)
            Lblguessnumber.Text = "Try Again" & vbCrLf & "Your guess 		was too LOW "
            'otherwise, if the guess is too high
        ElseIf GuessedNumber <> NumberToGuess Then
            LstHighervalues.Items.Add(GuessedNumber)
            Lblguessnumber.Text = "Try Again" & vbCrLf & "Your guess 		was too HIGH "
        End If

        'if the guess was correct...
        If GuessedCorrectly Then
            'get the next random integer number between 0 - 100 to 			be guessed
            NumberToGuess = RandomGenerator.Next(0, 100)
            'clear the listboxes for next set of guesses
            LstHighervalues.Items.Clear()
            Lstlowervalues.Items.Clear()
            Lblguessessofar.Text = "Number of attempts so far: 0"
        End If

        'clears and set focus to the number text box for next 			guess
        MsktbguessNumber.Clear()
        MsktbguessNumber.Focus()
    End Sub
End Class
