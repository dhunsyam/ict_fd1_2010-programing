<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Looper = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.timestable = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Looper
        '
        Me.Looper.Location = New System.Drawing.Point(238, 32)
        Me.Looper.Name = "Looper"
        Me.Looper.Size = New System.Drawing.Size(141, 49)
        Me.Looper.TabIndex = 0
        Me.Looper.Text = "Looper"
        Me.Looper.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 20)
        Me.TextBox1.TabIndex = 3
        '
        'timestable
        '
        Me.timestable.FormattingEnabled = True
        Me.timestable.Location = New System.Drawing.Point(54, 84)
        Me.timestable.Name = "timestable"
        Me.timestable.Size = New System.Drawing.Size(148, 173)
        Me.timestable.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 273)
        Me.Controls.Add(Me.timestable)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Looper)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Looper As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents timestable As System.Windows.Forms.ListBox

End Class
