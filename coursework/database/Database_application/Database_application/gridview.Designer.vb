<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gridview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gridview))
        Me.QryAllCoursesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.QryAllCoursesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.QryAllCoursesDataGridView = New System.Windows.Forms.DataGridView
        Me.btnmainView = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QryAllCoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Course_assignmentsDataSet = New Database_application.Course_assignmentsDataSet
        Me.QryAllCoursesTableAdapter = New Database_application.Course_assignmentsDataSetTableAdapters.qryAllCoursesTableAdapter
        Me.TableAdapterManager = New Database_application.Course_assignmentsDataSetTableAdapters.TableAdapterManager
        Me.QryStudentsOnAllCoursesTableAdapter = New Database_application.Course_assignmentsDataSetTableAdapters.qryStudentsOnAllCoursesTableAdapter
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton
        CType(Me.QryAllCoursesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QryAllCoursesBindingNavigator.SuspendLayout()
        CType(Me.QryAllCoursesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryAllCoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Course_assignmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'QryAllCoursesBindingNavigator
        '
        Me.QryAllCoursesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QryAllCoursesBindingNavigator.BindingSource = Me.QryAllCoursesBindingSource
        Me.QryAllCoursesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QryAllCoursesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QryAllCoursesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QryAllCoursesBindingNavigatorSaveItem})
        Me.QryAllCoursesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QryAllCoursesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QryAllCoursesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QryAllCoursesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QryAllCoursesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QryAllCoursesBindingNavigator.Name = "QryAllCoursesBindingNavigator"
        Me.QryAllCoursesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QryAllCoursesBindingNavigator.Size = New System.Drawing.Size(539, 25)
        Me.QryAllCoursesBindingNavigator.TabIndex = 0
        Me.QryAllCoursesBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'QryAllCoursesBindingNavigatorSaveItem
        '
        Me.QryAllCoursesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QryAllCoursesBindingNavigatorSaveItem.Enabled = False
        Me.QryAllCoursesBindingNavigatorSaveItem.Image = CType(resources.GetObject("QryAllCoursesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QryAllCoursesBindingNavigatorSaveItem.Name = "QryAllCoursesBindingNavigatorSaveItem"
        Me.QryAllCoursesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QryAllCoursesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QryAllCoursesDataGridView
        '
        Me.QryAllCoursesDataGridView.AutoGenerateColumns = False
        Me.QryAllCoursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QryAllCoursesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.QryAllCoursesDataGridView.DataSource = Me.QryAllCoursesBindingSource
        Me.QryAllCoursesDataGridView.Location = New System.Drawing.Point(21, 51)
        Me.QryAllCoursesDataGridView.Name = "QryAllCoursesDataGridView"
        Me.QryAllCoursesDataGridView.Size = New System.Drawing.Size(378, 242)
        Me.QryAllCoursesDataGridView.TabIndex = 1
        '
        'btnmainView
        '
        Me.btnmainView.Location = New System.Drawing.Point(60, 317)
        Me.btnmainView.Name = "btnmainView"
        Me.btnmainView.Size = New System.Drawing.Size(116, 23)
        Me.btnmainView.TabIndex = 2
        Me.btnmainView.Text = "back to main page"
        Me.btnmainView.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CourseReference"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CourseReference"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CourseName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CourseName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CourseModuleName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CourseModuleName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'QryAllCoursesBindingSource
        '
        Me.QryAllCoursesBindingSource.DataMember = "qryAllCourses"
        Me.QryAllCoursesBindingSource.DataSource = Me.Course_assignmentsDataSet
        '
        'Course_assignmentsDataSet
        '
        Me.Course_assignmentsDataSet.DataSetName = "Course_assignmentsDataSet"
        Me.Course_assignmentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QryAllCoursesTableAdapter
        '
        Me.QryAllCoursesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tblCourseModuleTableAdapter = Nothing
        Me.TableAdapterManager.tblCourseTableAdapter = Nothing
        Me.TableAdapterManager.tblEnrolledStudentTableAdapter = Nothing
        Me.TableAdapterManager.tblModuleAssignmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Database_application.Course_assignmentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QryStudentsOnAllCoursesTableAdapter
        '
        Me.QryStudentsOnAllCoursesTableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(539, 25)
        Me.FillToolStrip.TabIndex = 4
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'gridview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 365)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.btnmainView)
        Me.Controls.Add(Me.QryAllCoursesDataGridView)
        Me.Controls.Add(Me.QryAllCoursesBindingNavigator)
        Me.Name = "gridview"
        Me.Text = "gridview"
        CType(Me.QryAllCoursesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QryAllCoursesBindingNavigator.ResumeLayout(False)
        Me.QryAllCoursesBindingNavigator.PerformLayout()
        CType(Me.QryAllCoursesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryAllCoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Course_assignmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Course_assignmentsDataSet As Database_application.Course_assignmentsDataSet
    Friend WithEvents QryAllCoursesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryAllCoursesTableAdapter As Database_application.Course_assignmentsDataSetTableAdapters.qryAllCoursesTableAdapter
    Friend WithEvents TableAdapterManager As Database_application.Course_assignmentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents QryAllCoursesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents QryAllCoursesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QryAllCoursesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnmainView As System.Windows.Forms.Button
    Friend WithEvents QryStudentsOnAllCoursesTableAdapter As Database_application.Course_assignmentsDataSetTableAdapters.qryStudentsOnAllCoursesTableAdapter
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
End Class
