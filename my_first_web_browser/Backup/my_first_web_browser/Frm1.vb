Public Class Frm1
    Dim URLstring As String
    Dim HomeURL As String = "http://www.bcu.ac.uk"
    'This is our own module that causes the browser to navigate to the link selected elsewhere'
    Private Sub GotoURL(ByVal selectedURL As String)
        WbBrowser.Navigate(selectedURL)
        If (cbwebsite.FindStringExact(URLstring) < 0) And (URLstring <> Nothing) Then
            'if not already in list - add this URL to the combobox 
            cbwebsite.Items.Add(URLstring)
        End If
    End Sub
    Private Sub btnGoogle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngoogle.Click, mnugoogle.Click
        URLstring = "http://www.google.co.uk/search?hl=en&q=" & cbwebsite.Text
        GotoURL(URLstring)
    End Sub

    Private Sub btnMSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmsn.Click, mnumsn.Click
        URLstring = "http://search.msn.co.uk/results.aspx?q=" & cbwebsite.Text()
        GotoURL(URLstring)
    End Sub

    Private Sub btnAskJeeves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAskJeeves.Click, mnuaskjeeves.Click
        URLstring = "http://uk.ask.com/web?q=" & cbwebsite.Text
        GotoURL(URLstring)
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btngo.Click, mnugo.Click
        If cbwebsite.SelectedItem = "" Then
            URLstring = tbwebsite.Text
        Else
            URLstring = cbwebsite.SelectedItem
        End If
        GotoURL(URLstring)
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click, menuback.Click
        WbBrowser.GoBack()
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForward.Click, menuforward.Click
        WbBrowser.GoForward()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click, menuhome.Click
        GotoURL(HomeURL)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuhelp.Click
        URLstring = "http://msdn.microsoft.com/en-us/library/e58c44b8(VS.80).aspx"
        GotoURL(URLstring)
    End Sub

    Private Sub WbBrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WbBrowser.DocumentCompleted
        stslblReady.Text = "Page " & e.Url.ToString & " is fully loaded!"
    End Sub

    Private Sub WbBrowser_ProgressChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WbBrowser.ProgressChanged
        'create a variable for the calculated page load progress percentage value
        Dim progress As Double
        'calcualte progress based on how much of the page has been loaded so far
        progress = (e.CurrentProgress / e.MaximumProgress) * 100
        'set to display progress percentage value on progressbar
        stsprgPageLoadProgress.Value = progress

    End Sub

    Private Sub stsprgPageLoadProgress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stsprgPageLoadProgress.Click

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub cbwebsite_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbwebsite.SelectedIndexChanged

    End Sub
End Class
