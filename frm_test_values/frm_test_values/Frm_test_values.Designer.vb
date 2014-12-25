<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_test_values
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
        Me.Lbltestvalues = New System.Windows.Forms.Label
        Me.Lblinfo = New System.Windows.Forms.Label
        Me.Tb1 = New System.Windows.Forms.TextBox
        Me.Tb2 = New System.Windows.Forms.TextBox
        Me.Btnloop = New System.Windows.Forms.Button
        Me.lblcomparevalue = New System.Windows.Forms.Label
        Me.lblcomparevalue2 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Lbltestvalues
        '
        Me.Lbltestvalues.AutoSize = True
        Me.Lbltestvalues.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltestvalues.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Lbltestvalues.Location = New System.Drawing.Point(305, 9)
        Me.Lbltestvalues.Name = "Lbltestvalues"
        Me.Lbltestvalues.Size = New System.Drawing.Size(127, 26)
        Me.Lbltestvalues.TabIndex = 0
        Me.Lbltestvalues.Text = "test values"
        '
        'Lblinfo
        '
        Me.Lblinfo.AutoSize = True
        Me.Lblinfo.Location = New System.Drawing.Point(235, 49)
        Me.Lblinfo.Name = "Lblinfo"
        Me.Lblinfo.Size = New System.Drawing.Size(242, 13)
        Me.Lblinfo.TabIndex = 1
        Me.Lblinfo.Text = "my name is dhunsyam daji and this is the loops lab"
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(52, 127)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(254, 20)
        Me.Tb1.TabIndex = 2
        Me.ToolTip2.SetToolTip(Me.Tb1, "enter no.1 in here")
        '
        'Tb2
        '
        Me.Tb2.Location = New System.Drawing.Point(353, 127)
        Me.Tb2.Name = "Tb2"
        Me.Tb2.Size = New System.Drawing.Size(278, 20)
        Me.Tb2.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Tb2, "enter value no.2 in here")
        '
        'Btnloop
        '
        Me.Btnloop.Location = New System.Drawing.Point(238, 171)
        Me.Btnloop.Name = "Btnloop"
        Me.Btnloop.Size = New System.Drawing.Size(195, 21)
        Me.Btnloop.TabIndex = 4
        Me.Btnloop.Text = "compare the values"
        Me.Btnloop.UseVisualStyleBackColor = True
        '
        'lblcomparevalue
        '
        Me.lblcomparevalue.AutoSize = True
        Me.lblcomparevalue.Location = New System.Drawing.Point(229, 239)
        Me.lblcomparevalue.Name = "lblcomparevalue"
        Me.lblcomparevalue.Size = New System.Drawing.Size(39, 13)
        Me.lblcomparevalue.TabIndex = 5
        Me.lblcomparevalue.Text = "Label1"
        '
        'lblcomparevalue2
        '
        Me.lblcomparevalue2.AutoSize = True
        Me.lblcomparevalue2.Location = New System.Drawing.Point(229, 278)
        Me.lblcomparevalue2.Name = "lblcomparevalue2"
        Me.lblcomparevalue2.Size = New System.Drawing.Size(39, 13)
        Me.lblcomparevalue2.TabIndex = 7
        Me.lblcomparevalue2.Text = "Label1"
        '
        'ToolTip1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'Frm_test_values
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 434)
        Me.Controls.Add(Me.lblcomparevalue2)
        Me.Controls.Add(Me.lblcomparevalue)
        Me.Controls.Add(Me.Btnloop)
        Me.Controls.Add(Me.Tb2)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.Lblinfo)
        Me.Controls.Add(Me.Lbltestvalues)
        Me.Name = "Frm_test_values"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbltestvalues As System.Windows.Forms.Label
    Friend WithEvents Lblinfo As System.Windows.Forms.Label
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Tb2 As System.Windows.Forms.TextBox
    Friend WithEvents Btnloop As System.Windows.Forms.Button
    Friend WithEvents lblcomparevalue As System.Windows.Forms.Label
    Friend WithEvents lblcomparevalue2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
