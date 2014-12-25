<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colourfontimage
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Btncolour = New System.Windows.Forms.Button
        Me.btnfont = New System.Windows.Forms.Button
        Me.Btnimg = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(29, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 128)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(269, 43)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 128)
        Me.TextBox1.TabIndex = 1
        '
        'Btncolour
        '
        Me.Btncolour.Location = New System.Drawing.Point(29, 218)
        Me.Btncolour.Name = "Btncolour"
        Me.Btncolour.Size = New System.Drawing.Size(134, 36)
        Me.Btncolour.TabIndex = 2
        Me.Btncolour.Text = "colour"
        Me.Btncolour.UseVisualStyleBackColor = True
        '
        'btnfont
        '
        Me.btnfont.Location = New System.Drawing.Point(185, 218)
        Me.btnfont.Name = "btnfont"
        Me.btnfont.Size = New System.Drawing.Size(137, 36)
        Me.btnfont.TabIndex = 3
        Me.btnfont.Text = "font"
        Me.btnfont.UseVisualStyleBackColor = True
        '
        'Btnimg
        '
        Me.Btnimg.Location = New System.Drawing.Point(355, 218)
        Me.Btnimg.Name = "Btnimg"
        Me.Btnimg.Size = New System.Drawing.Size(140, 36)
        Me.Btnimg.TabIndex = 4
        Me.Btnimg.Text = "image"
        Me.Btnimg.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'colourfontimage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 296)
        Me.Controls.Add(Me.Btnimg)
        Me.Controls.Add(Me.btnfont)
        Me.Controls.Add(Me.Btncolour)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "colourfontimage"
        Me.Text = "colourfontimage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Btncolour As System.Windows.Forms.Button
    Friend WithEvents btnfont As System.Windows.Forms.Button
    Friend WithEvents Btnimg As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
