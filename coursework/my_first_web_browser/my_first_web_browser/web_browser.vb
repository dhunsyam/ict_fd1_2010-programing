
Option Explicit On
'Application Created by Dhunsyam Daji
'Date Created 27/01/2011
'Application Requirements this allows all users to surf the internet 
'and to be able to save favorites and history and to be able to come 
' come back to prvious websites from a previous session'

Public Class web_browser

    ' 3 dims specifying i as a interger so the website will work 
    Dim i As Integer = 1
    'urlsting fro the url's typed 
    Dim URLstring As String
    'home url as the homepage set for the home button
    Dim HomeURL As String = "http://www.google.co.uk"

    Private Sub Loading(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserProgressChangedEventArgs)
        'these show the status of the page loding in the progress bar at the bottom of the screen and max is when its finshed loading
        stsprgPageLoadProgress.Maximum = e.MaximumProgress
        stsprgPageLoadProgress.Value = e.CurrentProgress
        
    End Sub


    Private Sub Done(ByVal sender As Object, ByVal e As Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        'this makes the tab that has loaded use the url string to show the title of the website in the top of the tab
        'so the suer knows what website he/she is on
        TabCtrl.SelectedTab.Text = CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        cbwebsite.Text = CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Url.ToString
    End Sub
    'This is our own module that causes the browser to navigate to the link selected elsewhere'
    Private Sub GotoURL(ByVal selectedURL As String)
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(cbwebsite.Text)
        If (cbwebsite.FindStringExact(URLstring) < 0) And (URLstring <> Nothing) Then
            'if not already in list - add this URL to the combobox 
            cbwebsite.Items.Add(URLstring)
        End If
    End Sub
    Private Sub btnGoogle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngoogle.Click
        'this is the code for google to go straight to google search when clicked and show it in the current tab
        URLstring = "http://www.google.co.uk/search?hl=en&q=" & cbwebsite.Text
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(URLstring)
    End Sub

    Private Sub btnMSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmsn.Click
        'this is the code for bing to go straight to google search when clicked and show it in the current tab
        URLstring = "http://search.msn.co.uk/results.aspx?q=" & cbwebsite.Text()
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(URLstring)
    End Sub

    Private Sub btnAskJeeves_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAskJeeves.Click
        'this is the code for ask jeeves to go straight to google search when clicked and show it in the current tab
        URLstring = "http://uk.ask.com/web?q=" & cbwebsite.Text
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(URLstring)
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btngo.Click
        'if the combo box has a selected item in it then go to its url string then go to it 
        If cbwebsite.SelectedItem = "" Then

            URLstring = cbwebsite.SelectedItem
        End If
        GotoURL(URLstring)


    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        'navigate back to the previous website in the current tab
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForward.Click
        'navigate forward to the previous website in the current tab
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'navigate to the home page in the dim at the top
        GotoURL(HomeURL)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'if the user needs help it will show the user to msdn and take him to support and then go to the url below
        URLstring = "http://msdn.microsoft.com/en-us/library/e58c44b8(VS.80).aspx"
        GotoURL(URLstring)
    End Sub

    Private Sub WbBrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
        'this will show the user the user that status of the page in written words and say fully loaded when done
        stslblReady.Text = "Page " & e.Url.ToString & " is fully loaded!"
    End Sub

    Private Sub WbBrowser_ProgressChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs)
        'create a variable for the calculated page load progress percentage value
        Dim progress As Double
        'calcualte progress based on how much of the page has been loaded so far
        progress = (e.CurrentProgress / e.MaximumProgress) * 100
        'set to display progress percentage value on progressbar
        stsprgPageLoadProgress.Value = progress

    End Sub

    Private Sub web_browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dim it creates a new webbrowser as browse
        Dim Browse As New WebBrowser
        'it adds the handler to load a new page and show the address of the loaded site
        TabCtrl.TabPages.Add(1, "new tab")
        'it take the value of 1 from the current tab
        TabCtrl.SelectTab(i - 1)
        'the new browser name as new browser
        Browse.Name = "wb"
        'it makes the page fill the tab 
        Browse.Dock = DockStyle.Fill
        'this adds the above commands together and opens the page
        TabCtrl.SelectedTab.Controls.Add(Browse)
        'below it adds the status and the name of the page loading
        AddHandler Browse.ProgressChanged, AddressOf Loading
        AddHandler Browse.DocumentCompleted, AddressOf Done

        'interger add's one to the value and takes away when tabs close
        i = i + 1
        'once it opens go straight to the default home page
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
        'add the current page to the history combobox
        cbwebsite.AutoCompleteMode = AutoCompleteMode.Suggest
        cbwebsite.AutoCompleteSource = AutoCompleteSource.HistoryList
        'add the current page to the favorites box
        For Each item As String In My.Settings.Favorites
            Lstboxfavorites.Items.Add(item)
        Next
    End Sub
    Private Sub Btnnewtab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnewtab.Click
        'dim it creates a new webbrowser as browse
        Dim Browse As New WebBrowser
        'it adds the handler to load a new page and show the address of the loaded site
        TabCtrl.TabPages.Add(1, "AddHandler Browse.DocumentCompleted, AddressOf Done")
        'it take the value of 1 from the current tab
        TabCtrl.SelectTab(i - 1)
        'the new browser name as new browser
        Browse.Name = "web browser"
        'it makes the page fill the tab 
        Browse.Dock = DockStyle.Fill
        'this adds the above commands together and opens the page
        TabCtrl.SelectedTab.Controls.Add(Browse)
        'below it adds the status and the name of the page loading 
        AddHandler Browse.ProgressChanged, AddressOf Loading
        AddHandler Browse.DocumentCompleted, AddressOf Done

        'interger add's one to the value and takes away when tabs close
        i = i + 1
        'once it opens go straight to the default home page
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
        'add the current page to the history combobox
        cbwebsite.AutoCompleteMode = AutoCompleteMode.Suggest
        cbwebsite.AutoCompleteSource = AutoCompleteSource.HistoryList
    End Sub
    Private Sub Btnclosetab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclosetab.Click
        'this closes the current active tab that has a value of 1 and drops the value down by 1 
        If Not TabCtrl.TabPages.Count = 1 Then
            CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Navigate("about blank")
            TabCtrl.TabPages.RemoveAt(TabCtrl.TabPages.Count - 1)
            i = i - 1
        End If
    End Sub
    Private Sub Btnstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstop.Click
        'stops the navigation of the current page if its loading 
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Stop()
    End Sub
    Private Sub Btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnrefresh.Click
        'refreshes the current tab and reloads the page
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub
    Private Sub BtnHome_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        'takes the current tab to the default home page
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).GoHome()
    End Sub
    Private Sub Btnaddfavorites_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddfavorites.Click
        'adds the link from the combobox to the favorites list box
        My.Settings.Favorites.Add(cbwebsite.Text.ToString)
        Lstboxfavorites.Items.Clear()
        'adds eacth item to a string which is saved in the app.config
        For Each item As String In My.Settings.Favorites
            Lstboxfavorites.Items.Add(item)
        Next
    End Sub
    Private Sub Btnclearfavorites_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclearfavorites.Click
        'clears the favorites from the settings and list box
        My.Settings.Favorites.Clear()
        Lstboxfavorites.Items.Clear()
    End Sub
    Private Sub Lstboxfavorites_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstboxfavorites.DoubleClick
        'naviagates to the website when double clicked in the favorites.
        CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(Lstboxfavorites.Text)
    End Sub

    Private Sub cbwebsite_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbwebsite.KeyDown
        'make the enter key work as soon as you hit it it navigates to the website in the combobox
        If e.KeyCode = Keys.Enter Then
            CType(TabCtrl.SelectedTab.Controls.Item(0), WebBrowser).Navigate(cbwebsite.Text)
        End If

    End Sub

    Private Sub stsprgPageLoadProgress_Click(sender As System.Object, e As System.EventArgs) Handles stsprgPageLoadProgress.Click

    End Sub

    Private Sub Statusstripbrowser_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles Statusstripbrowser.ItemClicked

    End Sub
End Class
