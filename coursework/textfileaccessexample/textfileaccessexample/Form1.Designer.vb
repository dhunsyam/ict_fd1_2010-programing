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
        Me.Lbxtextdata = New System.Windows.Forms.ListBox
        Me.Lblfilename = New System.Windows.Forms.Label
        Me.Btnopen = New System.Windows.Forms.Button
        Me.Btnreadline = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Btnsavetext = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Lbxtextdata
        '
        Me.Lbxtextdata.FormattingEnabled = True
        Me.Lbxtextdata.Location = New System.Drawing.Point(31, 68)
        Me.Lbxtextdata.Name = "Lbxtextdata"
        Me.Lbxtextdata.Size = New System.Drawing.Size(200, 147)
        Me.Lbxtextdata.TabIndex = 0
        '
        'Lblfilename
        '
        Me.Lblfilename.AutoSize = True
        Me.Lblfilename.Location = New System.Drawing.Point(48, 35)
        Me.Lblfilename.Name = "Lblfilename"
        Me.Lblfilename.Size = New System.Drawing.Size(39, 13)
        Me.Lblfilename.TabIndex = 1
        Me.Lblfilename.Text = "Label1"
        '
        'Btnopen
        '
        Me.Btnopen.Location = New System.Drawing.Point(31, 238)
        Me.Btnopen.Name = "Btnopen"
        Me.Btnopen.Size = New System.Drawing.Size(75, 23)
        Me.Btnopen.TabIndex = 2
        Me.Btnopen.Text = "Open File"
        Me.Btnopen.UseVisualStyleBackColor = True
        '
        'Btnreadline
        '
        Me.Btnreadline.Location = New System.Drawing.Point(144, 237)
        Me.Btnreadline.Name = "Btnreadline"
        Me.Btnreadline.Size = New System.Drawing.Size(75, 23)
        Me.Btnreadline.TabIndex = 3
        Me.Btnreadline.Text = "Read a line"
        Me.Btnreadline.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Btnsavetext
        '
        Me.Btnsavetext.Location = New System.Drawing.Point(236, 237)
        Me.Btnsavetext.Name = "Btnsavetext"
        Me.Btnsavetext.Size = New System.Drawing.Size(75, 23)
        Me.Btnsavetext.TabIndex = 4
        Me.Btnsavetext.Text = "Save text "
        Me.Btnsavetext.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(250, 68)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 147)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(385, 68)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(129, 147)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(535, 68)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(141, 147)
        Me.TextBox3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 472)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btnsavetext)
        Me.Controls.Add(Me.Btnreadline)
        Me.Controls.Add(Me.Btnopen)
        Me.Controls.Add(Me.Lblfilename)
        Me.Controls.Add(Me.Lbxtextdata)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbxtextdata As System.Windows.Forms.ListBox
    Friend WithEvents Lblfilename As System.Windows.Forms.Label
    Friend WithEvents Btnopen As System.Windows.Forms.Button
    Friend WithEvents Btnreadline As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Btnsavetext As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
