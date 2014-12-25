Public Class Data_view

    Private Sub Data_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Course_assignmentsDataSet.tblEnrolledStudent' table. You can move, or remove it, as needed.
        Try
            Me.TblEnrolledStudentTableAdapter.Fill(Me.Course_assignmentsDataSet.tblEnrolledStudent)
        Catch ex As OleDb.OleDbException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btnmainview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmainview.Click
        'closes the datgridview
        Close()
        'then goes back to the 1st document
        frmstudentdata.Show()

    End Sub
End Class