'imports the classes necessary to manipulate xml files

Imports System.xml
Imports System.io
Public Class ownerform

    'these variables are declared globally becasue they are used throughout the "ownerform"
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

    Private Sub ownerform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' causes the "load_xml" subroutine to execute when the "ownerform" is loaded 
        Call load_xml()

    End Sub
    Private Sub load_xml()

        'this loads all the data from the xml file "xmlperson.xml" into "xmld" the "xmldocument" 
        'declared at start of the class it is called from sunroutines "BUpdate", "BDelete", 
        '"BCreate" and "ownerform_Load" 
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
        Tcode.Text = personlist.Item(listn).ChildNodes(0).InnerText
        'this does as above for the second child node (i.e. 1) - in <name>
        TName.Text = personlist.Item(listn).ChildNodes(1).InnerText
        'this does as above for the third child node (i.e. 2) - in <age>
        TAge.Text = personlist.Item(listn).ChildNodes(2).InnerText
        'this does as above for the fourth child node (i.e. 3) - in <weight>
        TWeight.Text = personlist.Item(listn).ChildNodes(3).InnerText
        'this deletes any messages created by the "Bscrollup" or "Bscrolldown" buttons / subroutines
        lendlist.Text = ""

    End Sub

    Private Sub BUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUpdate.Click

        'this takes the data currently displayed in the four text boxes and copies into the 
        'appropriate text fields in the child nodes of the current personlist.item
        'this copies the text held in the the text box "Tcode.Text" into the the first child (i.e. 0) 
        'node's text field of the "personlist.item(listn)" i.e. <code>
        personlist.Item(listn).ChildNodes(0).InnerText = Tcode.Text
        'this does as above for the second child node (i.e. 1) - <name> 
        personlist.Item(listn).ChildNodes(1).InnerText = TName.Text
        'this does as above for the third child node (i.e. 2) - <age> 
        personlist.Item(listn).ChildNodes(2).InnerText = TAge.Text
        'this does as above for the fourth child node (i.e. 3) - <weight> 
        personlist.Item(listn).ChildNodes(3).InnerText = TWeight.Text
        'this writes the amended node back the original xml file "xmlperson.xml"
        xmld.Save("xmlperson.xml")
        'this reloads the amended xml file using the subroutine "load_xml" above
        'to ensure that the currently stored xml file now held in the xml document "xmld" is up to date
        Call load_xml()

    End Sub

    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click

        'this removes the child of the parent node of the person list
        '"parentnode" is the node which is the parent of the "personlist"
        '"removechild" deletes the current node of "personlist"
        'i.e. "personlist.item(listn)"
        personlist.Item(listn).ParentNode.RemoveChild(personlist.Item(listn))
        'this rewrites the original xml file "xmlperson.xml" without the deleted node
        xmld.Save("xmlperson.xml")
        'this reloads the amended xml file using the subroutine "load_xml" above
        'to ensure that the currently stored xml file now held in the xml document "xmld" is up to date
        Call load_xml()

    End Sub

    Private Sub BCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCreate.Click

        'this creates a new node in the orginal xml file
        'this creates a variable which is defined and a newline character
        Dim cr As String = Environment.NewLine
        'these string items are temporary variables to hold the new values for the xml elements
        Dim personst, codest, namest, agest, weightst As String
        '"root" is an xml node which will eventually hold the new nodes data
        Dim root As XmlNode
        '"bitdoc" is a fragment of an xml document which will hold the string "personst" that contains the xml in string format
        Dim bitdoc As XmlDocumentFragment

        'this creates the xml fragment based upon the xml document (i.e. "xmld") 
        bitdoc = xmld.CreateDocumentFragment()
        'this creates the document element of the correct format
        root = xmld.DocumentElement

        'these variables are now set to contain the new data items for the xml fragment
        codest = Tcode.Text
        namest = TName.Text
        agest = TAge.Text
        weightst = TWeight.Text

        ' this creates the string which represents the xml (i.e. "personst") and embeds the contents of the temporary variables
        personst = _
        "<person>" & cr & _
        "    <code>" & codest & "</code>" & cr & _
        "    <name>" & namest & "</name>" & cr & _
        "    <age>" & agest & "</age>" & cr & _
        "    <weight>" & weightst & "</weight>" & _
        "</person>"

        '"bitdoc" receives a copy of "personst" as a formatted xml string
        bitdoc.InnerXml = personst
        '"bitdoc" is added (appended) to the root node "root" defined above
        root.AppendChild(bitdoc)
        'this rewrites the original xml file "xmlperson.xml" without the new node
        xmld.Save("xmlperson.xml")
        'this reloads the amended xml file using the subroutine "load_xml" above
        'to ensure that the currently stored xml file now held in the xml document "xmld" is up to date
        Call load_xml()

    End Sub

    Private Sub Bclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclose.Click

        'This closes down the current screen - see "Blogout" button / subroutine
        Me.Close()

    End Sub
End Class