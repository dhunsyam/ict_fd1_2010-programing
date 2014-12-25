<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbldisplay = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtBox1 = New System.Windows.Forms.ListBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'lbldisplay
        '
        Me.lbldisplay.AutoSize = True
        Me.lbldisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldisplay.Location = New System.Drawing.Point(373, 28)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(46, 13)
        Me.lbldisplay.TabIndex = 0
        Me.lbldisplay.Text = "display"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(302, 203)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(140, 21)
        Me.ProgressBar1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(339, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(102, 20)
        Me.TextBox1.TabIndex = 2
        '
        'txtBox1
        '
        Me.txtBox1.FormattingEnabled = True
        Me.txtBox1.Location = New System.Drawing.Point(288, 139)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(153, 30)
        Me.txtBox1.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(149, 203)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(498, 288)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbldisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldisplay As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBox1 As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
