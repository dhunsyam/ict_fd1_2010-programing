Public Class frmstudentdata

    Private Sub TblEnrolledStudentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblEnrolledStudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblEnrolledStudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Course_assignmentsDataSet)

    End Sub

    Private Sub frmstudentdata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Course_assignmentsDataSet.tblEnrolledStudent' table. You can move, or remove it, as needed.
        Try
            Me.TblEnrolledStudentTableAdapter.Fill(Me.Course_assignmentsDataSet.tblEnrolledStudent)
        Catch ex As OleDb.OleDbException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        'exits the program
        Close()
    End Sub

    Private Sub Btngridview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'navigates to the datagrid view

    End Sub

    Private Sub Btngridview_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btngridview.Click
        Data_view.Show()
    End Sub
End Class
