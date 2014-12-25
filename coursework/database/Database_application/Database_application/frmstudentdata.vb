Option Explicit On
Public Class frmstudentdata
    'Application Created by Dhunsyam Daji
    'Date Created 19/03/2011
    'Application Requirements this allows all users to navigate and edit the database via querrys and gridviews and it will all be saved to the database

    Private Sub TblEnrolledStudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblEnrolledStudentBindingNavigatorSaveItem.Click
        'this enables the controls like the edit and delete to work
        Me.Validate()
        Me.TblEnrolledStudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Course_assignmentsDataSet)

    End Sub

    Private Sub frmstudentdata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Course_assignmentsDataSet.qryAllCourses' table. You can move, or remove it, as needed.
        Me.QryAllCoursesTableAdapter.Fill(Me.Course_assignmentsDataSet.qryAllCourses)
        'TODO: This line of code loads data into the 'Course_assignmentsDataSet.tblEnrolledStudent' table. You can move, or remove it, as needed.
        Me.TblEnrolledStudentTableAdapter.Fill(Me.Course_assignmentsDataSet.tblEnrolledStudent)

    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        'navigates to the datagrid view
        gridview.Show()
    End Sub
End Class
