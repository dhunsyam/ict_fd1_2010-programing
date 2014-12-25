Public Class Form1
    ' author dhunsyam daji
    ' date 13th january 2011
    ' project arrays 
    Dim studentname() As String = {"adam", "paul", "joe", "swax", "james", "tom", "will", "sarah", "samantha", "sam", "jim"}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Btnstudentdetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstudentdetails.Click
        Static Dim countstudents As Integer = 0

        Lblstudentnoshow.Text = CInt(countstudents + 1)
        Lblstudentnameshow.Text = studentname(countstudents)
        Lblinfo.Visible = True
        countstudents += 1
    End Sub
End Class
