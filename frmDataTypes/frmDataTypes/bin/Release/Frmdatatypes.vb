Public Class Frmdatatypes

    Private Sub btnshowdetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshowdetails.Click
        Dim myInitial As Char
        Dim mySurname As String
        Dim myDateofBirth As Date
        Dim myGenderisFemale As Boolean

        'get a SINGLE CHARACTER as first initial for tbInitial 
        myInitial = tblinitial.Text

        mySurname = Tbsurname.Text

        'get the value property from the date-time-picker control as a DATE type
        myDateofBirth = dtpDOB.Value

        If Rbtnfemale.Checked Then
            myGenderisFemale = True
        Else
            myGenderisFemale = False
        End If

        'if male, refer to as “Mr”, if female, refer to as “Ms”
        Dim mySalutation As String
        If myGenderisFemale Then
            mySalutation = "Ms"
        Else
            mySalutation = "Mr"
        End If

        ' get the DAY of your birth from the date of birth entered
        Dim myDayofBirth As String
        myDayofBirth = System.Threading.Thread.CurrentThread. _
           CurrentUICulture.DateTimeFormat. _
           GetDayName(myDateofBirth.DayOfWeek)

        'display all the gathered and derived information in the 	   rich text box
        Rtbxshowdetails.Clear()
        Rtbxshowdetails.AppendText("Hello " & mySalutation & "." _
      & myInitial & " " & mySurname & vbCrLf)
        Rtbxshowdetails.AppendText("You were born on " & _
      myDayofBirth & " the " & _
      myDateofBirth.ToLongDateString & vbCrLf)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Rtbxshowdetails.Clear()
    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Close()
    End Sub
End Class
