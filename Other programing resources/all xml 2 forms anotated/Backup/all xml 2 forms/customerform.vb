'imports the classes necessary to manipulate xml files

Imports System.Xml
Imports System.IO
Public Class customerform

    'these variables are declared globally becasue they are used throughout the "customerform"
    ' "xmld2 holds the whole of the current XML file
    Dim xmld As New XmlDocument
    ' "personlist" holds a list of all the people nodes and each part of the list may be accessed by using and index
    ' which is similar to accessing array elements
    Dim personlist As XmlNodeList
    ' "personnode" holds a person xml node
    Dim personnode As XmlNode
    ' "listn" is an index upon which the scrolling buttons work to access data in the "personlist" - see Bscrolldown and Bscrollup subroutines
    ' set intially to one to ensure that it is not possible to sroll up or down past the end of the "personlist"
    Dim listn As Integer = -1
    ' "maxlist is to hold the maximum number of items in the "personlist" and is used to ensure that it is not possible to scroll past the end of the list
    Dim maxlist As Integer

    Private Sub BScrolldown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BScrolldown.Click

        'if the last item in the "personlist" has been displayed then (i.e. listn = maxlist)
        'then send message otherwise display next item
        If listn < maxlist Then

            'increment current item number i.e. "listn"
            listn = listn + 1
            'call the subroutine "displels2 which displays the data item in position "listn" in the "personlist"
            Call dispels()

        Else

            'send message - see above
            lendlist.Text = "bottom of list"

        End If

    End Sub

    Private Sub BScrollup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BScrollup.Click

        'if the lfirst item in the "personlist" has been displayed then (i.e. listn = 0)
        'then send message otherwise display previous item
        If listn > 0 Then

            'decrement current item number i.e. "listn"
            listn = listn - 1
            'call the subroutine "displels2 which displays the data item in position "listn" in the "personlist"
            Call dispels()

        Else

            'send message - see above
            lendlist.Text = "top of list"

        End If

    End Sub

    Private Sub customerform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'this loads all the data into "xmld" the "xmldocument declared at start of the class
        'when the "customerform" is loaded
        xmld.Load("xmlperson.xml")
        'this selects all the nodes of the type "person" and puts them into the list "personlist"
        'the nodes are indexed from 0 upwrads
        personlist = xmld.SelectNodes("/people/person")
        '"maxlist" holds the number of nodes in the list (i.e. "personlist.count")
        'subtracting one because the maximum index is 1 less than the number of nodes in the list
        maxlist = personlist.Count - 1

    End Sub
    Private Sub dispels()

        'this displays the data items in text boxes
        'note that all indexes, as do arrays, default to start at zero , 0
        'this copies the text held in the first child node (i.e. 0) of the "personlist.item(listn)" 
        'into the textbox (Tcode.Text) - in <code>
        TCode.Text = personlist.Item(listn).ChildNodes(0).InnerText
        'this does as above for the second child node (i.e. 1) - in <name>
        TName.Text = personlist.Item(listn).ChildNodes(1).InnerText
        'this does as above for the third child node (i.e. 2) - in <age>
        TAge.Text = personlist.Item(listn).ChildNodes(2).InnerText
        'this does as above for the fourth child node (i.e. 3) - in <weight>
        TWeight.Text = personlist.Item(listn).ChildNodes(3).InnerText
        'this deletes any messages created by the "Bscrollup" or "Bscrolldown" buttons / subroutines
        lendlist.Text = ""

    End Sub

    Private Sub Bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclose.Click

        'This closes down the current screen - see "Blogout" button / subroutine
        Me.Close()

    End Sub
End Class