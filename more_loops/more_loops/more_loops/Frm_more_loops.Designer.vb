<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_more_loops
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
        Me.lblselectno = New System.Windows.Forms.Label
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.btncalculate = New System.Windows.Forms.Button
        Me.Rtb = New System.Windows.Forms.RichTextBox
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblselectno
        '
        Me.lblselectno.AutoSize = True
        Me.lblselectno.Location = New System.Drawing.Point(33, 51)
        Me.lblselectno.Name = "lblselectno"
        Me.lblselectno.Size = New System.Drawing.Size(243, 13)
        Me.lblselectno.TabIndex = 0
        Me.lblselectno.Text = "Please Select a number to calculate Factorials for:"
        '
        'NumericUpDown
        '
        Me.NumericUpDown.Location = New System.Drawing.Point(46, 86)
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(165, 20)
        Me.NumericUpDown.TabIndex = 1
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(68, 134)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(128, 42)
        Me.btncalculate.TabIndex = 2
        Me.btncalculate.Text = "Calculate Factorial>>"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'Rtb
        '
        Me.Rtb.Location = New System.Drawing.Point(282, 12)
        Me.Rtb.Name = "Rtb"
        Me.Rtb.Size = New System.Drawing.Size(221, 280)
        Me.Rtb.TabIndex = 3
        Me.Rtb.Text = ""
        '
        'Frm_more_loops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 341)
        Me.Controls.Add(Me.Rtb)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.NumericUpDown)
        Me.Controls.Add(Me.lblselectno)
        Me.Name = "Frm_more_loops"
        Me.Text = "using more loops"
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblselectno As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents Rtb As System.Windows.Forms.RichTextBox

End Class
