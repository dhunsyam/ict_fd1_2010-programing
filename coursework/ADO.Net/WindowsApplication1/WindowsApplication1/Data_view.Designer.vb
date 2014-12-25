<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_view
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Course_assignmentsDataSet = New WindowsApplication1.Course_assignmentsDataSet
        Me.TblEnrolledStudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEnrolledStudentTableAdapter = New WindowsApplication1.Course_assignmentsDataSetTableAdapters.tblEnrolledStudentTableAdapter
        Me.StudentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CourseReferenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Btnmainview = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Course_assignmentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEnrolledStudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNumberDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.CourseReferenceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblEnrolledStudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(62, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(403, 240)
        Me.DataGridView1.TabIndex = 0
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
        'StudentNumberDataGridViewTextBoxColumn
        '
        Me.StudentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.Name = "StudentNumberDataGridViewTextBoxColumn"
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'CourseReferenceDataGridViewTextBoxColumn
        '
        Me.CourseReferenceDataGridViewTextBoxColumn.DataPropertyName = "CourseReference"
        Me.CourseReferenceDataGridViewTextBoxColumn.HeaderText = "CourseReference"
        Me.CourseReferenceDataGridViewTextBoxColumn.Name = "CourseReferenceDataGridViewTextBoxColumn"
        '
        'Btnmainview
        '
        Me.Btnmainview.Location = New System.Drawing.Point(106, 429)
        Me.Btnmainview.Name = "Btnmainview"
        Me.Btnmainview.Size = New System.Drawing.Size(118, 23)
        Me.Btnmainview.TabIndex = 1
        Me.Btnmainview.Text = "back to main view"
        Me.Btnmainview.UseVisualStyleBackColor = True
        '
        'Data_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 536)
        Me.Controls.Add(Me.Btnmainview)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Data_view"
        Me.Text = "Data_view"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Course_assignmentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEnrolledStudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Course_assignmentsDataSet As WindowsApplication1.Course_assignmentsDataSet
    Friend WithEvents TblEnrolledStudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEnrolledStudentTableAdapter As WindowsApplication1.Course_assignmentsDataSetTableAdapters.tblEnrolledStudentTableAdapter
    Friend WithEvents StudentNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseReferenceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btnmainview As System.Windows.Forms.Button
End Class
