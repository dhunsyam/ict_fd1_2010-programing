﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudentdata
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim StudentNumberLabel As System.Windows.Forms.Label
        Dim StudentNameLabel As System.Windows.Forms.Label
        Dim CourseReferenceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstudentdata))
        Me.Course_assignmentsDataSet = New Database_application.Course_assignmentsDataSet
        Me.TblEnrolledStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEnrolledStudentTableAdapter = New Database_application.Course_assignmentsDataSetTableAdapters.tblEnrolledStudentTableAdapter
        Me.TableAdapterManager = New Database_application.Course_assignmentsDataSetTableAdapters.TableAdapterManager
        Me.TblEnrolledStudentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TblEnrolledStudentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.StudentNumberTextBox = New System.Windows.Forms.TextBox
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox
        Me.CourseReferenceTextBox = New System.Windows.Forms.TextBox
        Me.QryAllCoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QryAllCoursesTableAdapter = New Database_application.Course_assignmentsDataSetTableAdapters.qryAllCoursesTableAdapter
        Me.btnview = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        StudentNumberLabel = New System.Windows.Forms.Label
        StudentNameLabel = New System.Windows.Forms.Label
        CourseReferenceLabel = New System.Windows.Forms.Label
        CType(Me.Course_assignmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEnrolledStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEnrolledStudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblEnrolledStudentBindingNavigator.SuspendLayout()
        CType(Me.QryAllCoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentNumberLabel
        '
        StudentNumberLabel.AutoSize = True
        StudentNumberLabel.Location = New System.Drawing.Point(24, 69)
        StudentNumberLabel.Name = "StudentNumberLabel"
        StudentNumberLabel.Size = New System.Drawing.Size(87, 13)
        StudentNumberLabel.TabIndex = 1
        StudentNumberLabel.Text = "Student Number:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(33, 109)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(78, 13)
        StudentNameLabel.TabIndex = 3
        StudentNameLabel.Text = "Student Name:"
        '
        'CourseReferenceLabel
        '
        CourseReferenceLabel.AutoSize = True
        CourseReferenceLabel.Location = New System.Drawing.Point(15, 146)
        CourseReferenceLabel.Name = "CourseReferenceLabel"
        CourseReferenceLabel.Size = New System.Drawing.Size(96, 13)
        CourseReferenceLabel.TabIndex = 5
        CourseReferenceLabel.Text = "Course Reference:"
        '
        'Course_assignmentsDataSet
        '
        Me.Course_assignmentsDataSet.DataSetName = "Course_assignmentsDataSet"
        Me.Course_assignmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEnrolledStudentBindingSource
        '
        Me.TblEnrolledStudentBindingSource.DataMember = "tblEnrolledStudent"
        Me.TblEnrolledStudentBindingSource.DataSource = Me.Course_assignmentsDataSet
        '
        'TblEnrolledStudentTableAdapter
        '
        Me.TblEnrolledStudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCourseModuleTableAdapter = Nothing
        Me.TableAdapterManager.tblCourseTableAdapter = Nothing
        Me.TableAdapterManager.tblEnrolledStudentTableAdapter = Me.TblEnrolledStudentTableAdapter
        Me.TableAdapterManager.tblModuleAssignmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Database_application.Course_assignmentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblEnrolledStudentBindingNavigator
        '
        Me.TblEnrolledStudentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblEnrolledStudentBindingNavigator.BindingSource = Me.TblEnrolledStudentBindingSource
        Me.TblEnrolledStudentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblEnrolledStudentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblEnrolledStudentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblEnrolledStudentBindingNavigatorSaveItem})
        Me.TblEnrolledStudentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblEnrolledStudentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblEnrolledStudentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblEnrolledStudentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblEnrolledStudentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblEnrolledStudentBindingNavigator.Name = "TblEnrolledStudentBindingNavigator"
        Me.TblEnrolledStudentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblEnrolledStudentBindingNavigator.Size = New System.Drawing.Size(302, 25)
        Me.TblEnrolledStudentBindingNavigator.TabIndex = 0
        Me.TblEnrolledStudentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblEnrolledStudentBindingNavigatorSaveItem
        '
        Me.TblEnrolledStudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblEnrolledStudentBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblEnrolledStudentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblEnrolledStudentBindingNavigatorSaveItem.Name = "TblEnrolledStudentBindingNavigatorSaveItem"
        Me.TblEnrolledStudentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblEnrolledStudentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentNumberTextBox
        '
        Me.StudentNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEnrolledStudentBindingSource, "StudentNumber", True))
        Me.StudentNumberTextBox.Location = New System.Drawing.Point(117, 66)
        Me.StudentNumberTextBox.Name = "StudentNumberTextBox"
        Me.StudentNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNumberTextBox.TabIndex = 2
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEnrolledStudentBindingSource, "StudentName", True))
        Me.StudentNameTextBox.Location = New System.Drawing.Point(117, 106)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNameTextBox.TabIndex = 4
        '
        'CourseReferenceTextBox
        '
        Me.CourseReferenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEnrolledStudentBindingSource, "CourseReference", True))
        Me.CourseReferenceTextBox.Location = New System.Drawing.Point(117, 143)
        Me.CourseReferenceTextBox.Name = "CourseReferenceTextBox"
        Me.CourseReferenceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CourseReferenceTextBox.TabIndex = 6
        '
        'QryAllCoursesBindingSource
        '
        Me.QryAllCoursesBindingSource.DataMember = "qryAllCourses"
        Me.QryAllCoursesBindingSource.DataSource = Me.Course_assignmentsDataSet
        '
        'QryAllCoursesTableAdapter
        '
        Me.QryAllCoursesTableAdapter.ClearBeforeFill = True
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(18, 194)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(168, 23)
        Me.btnview.TabIndex = 7
        Me.btnview.Text = "show grid view of student data"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(192, 194)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 8
        Me.btnclose.Text = "Exit"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'frmstudentdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 225)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(CourseReferenceLabel)
        Me.Controls.Add(Me.CourseReferenceTextBox)
        Me.Controls.Add(StudentNameLabel)
        Me.Controls.Add(Me.StudentNameTextBox)
        Me.Controls.Add(StudentNumberLabel)
        Me.Controls.Add(Me.StudentNumberTextBox)
        Me.Controls.Add(Me.TblEnrolledStudentBindingNavigator)
        Me.Name = "frmstudentdata"
        Me.Text = "student data"
        CType(Me.Course_assignmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEnrolledStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEnrolledStudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblEnrolledStudentBindingNavigator.ResumeLayout(False)
        Me.TblEnrolledStudentBindingNavigator.PerformLayout()
        CType(Me.QryAllCoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Course_assignmentsDataSet As Database_application.Course_assignmentsDataSet
    Friend WithEvents TblEnrolledStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEnrolledStudentTableAdapter As Database_application.Course_assignmentsDataSetTableAdapters.tblEnrolledStudentTableAdapter
    Friend WithEvents TableAdapterManager As Database_application.Course_assignmentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblEnrolledStudentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblEnrolledStudentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CourseReferenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QryAllCoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryAllCoursesTableAdapter As Database_application.Course_assignmentsDataSetTableAdapters.qryAllCoursesTableAdapter
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button

End Class
