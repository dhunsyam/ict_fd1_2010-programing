<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Course_assignmentsDataSet = New WindowsApplication1.Course_assignmentsDataSet
        Me.TblEnrolledStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEnrolledStudentTableAdapter = New WindowsApplication1.Course_assignmentsDataSetTableAdapters.tblEnrolledStudentTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Course_assignmentsDataSetTableAdapters.TableAdapterManager
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
        Me.CourseReferenceComboBox = New System.Windows.Forms.ComboBox
        Me.Btngridview = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        StudentNumberLabel = New System.Windows.Forms.Label
        StudentNameLabel = New System.Windows.Forms.Label
        CourseReferenceLabel = New System.Windows.Forms.Label
        CType(Me.Course_assignmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEnrolledStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEnrolledStudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblEnrolledStudentBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentNumberLabel
        '
        StudentNumberLabel.AutoSize = True
        StudentNumberLabel.Location = New System.Drawing.Point(60, 52)
        StudentNumberLabel.Name = "StudentNumberLabel"
        StudentNumberLabel.Size = New System.Drawing.Size(87, 13)
        StudentNumberLabel.TabIndex = 1
        StudentNumberLabel.Text = "Student Number:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(66, 126)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(78, 13)
        StudentNameLabel.TabIndex = 3
        StudentNameLabel.Text = "Student Name:"
        '
        'CourseReferenceLabel
        '
        CourseReferenceLabel.AutoSize = True
        CourseReferenceLabel.Location = New System.Drawing.Point(51, 176)
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
        Me.TableAdapterManager.tblEnrolledStudentTableAdapter = Me.TblEnrolledStudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Course_assignmentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.TblEnrolledStudentBindingNavigator.Size = New System.Drawing.Size(558, 25)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
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
        Me.StudentNumberTextBox.Location = New System.Drawing.Point(153, 49)
        Me.StudentNumberTextBox.Name = "StudentNumberTextBox"
        Me.StudentNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNumberTextBox.TabIndex = 2
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEnrolledStudentBindingSource, "StudentName", True))
        Me.StudentNameTextBox.Location = New System.Drawing.Point(150, 123)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNameTextBox.TabIndex = 4
        '
        'CourseReferenceComboBox
        '
        Me.CourseReferenceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblEnrolledStudentBindingSource, "CourseReference", True))
        Me.CourseReferenceComboBox.FormattingEnabled = True
        Me.CourseReferenceComboBox.Location = New System.Drawing.Point(153, 173)
        Me.CourseReferenceComboBox.Name = "CourseReferenceComboBox"
        Me.CourseReferenceComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CourseReferenceComboBox.TabIndex = 6
        '
        'Btngridview
        '
        Me.Btngridview.Location = New System.Drawing.Point(99, 305)
        Me.Btngridview.Name = "Btngridview"
        Me.Btngridview.Size = New System.Drawing.Size(151, 23)
        Me.Btngridview.TabIndex = 7
        Me.Btngridview.Text = "go to datagrid view"
        Me.Btngridview.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(356, 304)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(75, 23)
        Me.Btnexit.TabIndex = 8
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'frmstudentdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 395)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btngridview)
        Me.Controls.Add(CourseReferenceLabel)
        Me.Controls.Add(Me.CourseReferenceComboBox)
        Me.Controls.Add(StudentNameLabel)
        Me.Controls.Add(Me.StudentNameTextBox)
        Me.Controls.Add(StudentNumberLabel)
        Me.Controls.Add(Me.StudentNumberTextBox)
        Me.Controls.Add(Me.TblEnrolledStudentBindingNavigator)
        Me.Name = "frmstudentdata"
        Me.Text = "Student_data"
        CType(Me.Course_assignmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEnrolledStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEnrolledStudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblEnrolledStudentBindingNavigator.ResumeLayout(False)
        Me.TblEnrolledStudentBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Course_assignmentsDataSet As WindowsApplication1.Course_assignmentsDataSet
    Friend WithEvents TblEnrolledStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEnrolledStudentTableAdapter As WindowsApplication1.Course_assignmentsDataSetTableAdapters.tblEnrolledStudentTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Course_assignmentsDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents CourseReferenceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Btngridview As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button

End Class
