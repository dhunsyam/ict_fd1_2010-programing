Public Class timeapplication
    Private myclock As Clock
    Private Sub Btncreatenewobject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncreatenewobject.Click
        'instantiate the Clock based object…
        myClock = New Clock
        'and call its accessor method
        Lblcreatenewobject.Text = myclock.GetTime()

    End Sub

    Private Sub Btnsettime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsettime.Click
        Dim hrs, mins, secs As Integer
        hrs = Convert.ToInt32(Tbsettimehr.Text)
        mins = Convert.ToInt32(Tbsettimemin.Text)
        secs = Convert.ToInt32(Tbsettimesec.Text)
        'continue to use the previously instantiated object wherever it’s in scope
        myclock.SetTime(hrs, mins, secs)
        Lblcreatenewobject.Text = myclock.GetTime()

    End Sub

    Private Sub Btnunitime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnunitime.Click
        If myclock Is Nothing Then
            MessageBox.Show("Please create a 'Clock' object First")
        Else
            Lblunitime.Text = myclock.ToUniversalString()
        End If

    End Sub

    Private Sub Btnstdtime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstdtime.Click
        If myclock Is Nothing Then
            MessageBox.Show("Please create a 'Clock' object First")
        Else
            Lblstdtime.Text = myclock.ToStandardString()
        End If

    End Sub

    Private Sub timeapplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class Clock

    'encapsulate the attributes - make them private
    Private hour As Integer
    Private minute As Integer
    Private second As Integer

    'constructor
    Public Sub New()
        SetTime(0, 0, 0)
    End Sub

    'accessor 
    Public Function GetTime() As String
        Return (hour.ToString + " , " + minute.ToString + " , " + second.ToString)
    End Function

    'mutator
    Public Sub SetTime(ByVal hr As Integer, ByVal mn As Integer, ByVal sc As Integer)
        If (hr >= 0 And hr < 24) Then
            hour = hr
        Else
            MsgBox("Invalid hour value entered, will be set to 0")
            hour = 0
        End If
        If (mn >= 0 And mn < 60) Then
            minute = mn
        Else
            MsgBox("Invalid minute value entered, will be set to 0")
            minute = 0
        End If
        If (sc >= 0 And sc < 60) Then
            second = sc
        Else
            MsgBox("Invalid second value entered, will be set to 0")
            second = 0
        End If
    End Sub

    'other methods… 
    Public Function ToUniversalString() As String
        Return String.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second)
    End Function

    Public Function ToStandardString() As String
        Dim ampm As String
        Dim standardHR As Integer
        If (hour < 12) Then
            ampm = "am"
        Else
            ampm = "pm"
        End If
        If (hour = 12 Or hour = 0) Then
            standardHR = 12
        Else
            standardHR = hour Mod 12
        End If
        Return String.Format("{0}:{1:D2}:{2:D2} {3}", standardHR, minute, second, ampm)



    End Function
End Class
