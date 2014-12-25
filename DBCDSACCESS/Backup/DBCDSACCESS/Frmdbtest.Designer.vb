<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdbtest
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
        Me.Cbomusiccategory = New System.Windows.Forms.ComboBox
        Me.Lblmusiccategory = New System.Windows.Forms.Label
        Me.Lsbcds = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Cbomusiccategory
        '
        Me.Cbomusiccategory.FormattingEnabled = True
        Me.Cbomusiccategory.Location = New System.Drawing.Point(85, 50)
        Me.Cbomusiccategory.Name = "Cbomusiccategory"
        Me.Cbomusiccategory.Size = New System.Drawing.Size(292, 21)
        Me.Cbomusiccategory.TabIndex = 0
        '
        'Lblmusiccategory
        '
        Me.Lblmusiccategory.AutoSize = True
        Me.Lblmusiccategory.Location = New System.Drawing.Point(85, 13)
        Me.Lblmusiccategory.Name = "Lblmusiccategory"
        Me.Lblmusiccategory.Size = New System.Drawing.Size(111, 13)
        Me.Lblmusiccategory.TabIndex = 1
        Me.Lblmusiccategory.Text = "Select music catogory"
        '
        'Lsbcds
        '
        Me.Lsbcds.FormattingEnabled = True
        Me.Lsbcds.Location = New System.Drawing.Point(94, 134)
        Me.Lsbcds.Name = "Lsbcds"
        Me.Lsbcds.Size = New System.Drawing.Size(268, 225)
        Me.Lsbcds.TabIndex = 2
        '
        'Frmdbtest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 445)
        Me.Controls.Add(Me.Lsbcds)
        Me.Controls.Add(Me.Lblmusiccategory)
        Me.Controls.Add(Me.Cbomusiccategory)
        Me.Name = "Frmdbtest"
        Me.Text = "testing connection to database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbomusiccategory As System.Windows.Forms.ComboBox
    Friend WithEvents Lblmusiccategory As System.Windows.Forms.Label
    Friend WithEvents Lsbcds As System.Windows.Forms.ListBox

End Class
