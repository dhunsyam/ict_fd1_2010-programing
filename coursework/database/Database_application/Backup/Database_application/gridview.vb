Option Explicit On
'Application Created by Dhunsyam Daji
'Date Created 19/03/2011
'Application Requirements this allows all users to navigate and edit the database via querrys and gridviews and it will all be saved to the database

Public Class gridview

    Private Sub gridview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Course_assignmentsDataSet.qryAllCourses' table. You can move, or remove it, as needed.
        Me.QryAllCoursesTableAdapter.Fill(Me.Course_assignmentsDataSet.qryAllCourses)

    End Sub

    Private Sub btnmainView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmainView.Click
        'closes the datgridview
        Close()
        'then goes back to the 1st document
        frmstudentdata.Show()
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'if the database cant be found it shows up a messagebox showing the error of the database
        Try
            Me.QryAllCoursesTableAdapter.FillBy(Me.Course_assignmentsDataSet.qryAllCourses)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'if the database cant be found it shows up a messagebox showing the error of the database
        Try
            Me.QryStudentsOnAllCoursesTableAdapter.Fill(Me.Course_assignmentsDataSet.qryStudentsOnAllCourses)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
        'if the database cant be found it shows up a messagebox showing the error of the database
        Try
            Me.QryAllCoursesTableAdapter.Fill(Me.Course_assignmentsDataSet.qryAllCourses)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class