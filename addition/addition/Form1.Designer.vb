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
        Me.lblnum1 = New System.Windows.Forms.Label
        Me.lblnum2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Lblres = New System.Windows.Forms.Label
        Me.Lblresult = New System.Windows.Forms.Label
        Me.btnadd = New System.Windows.Forms.Button
        Me.Btnclear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(94, 52)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(59, 13)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "1st number"
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(94, 108)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(63, 13)
        Me.lblnum2.TabIndex = 1
        Me.lblnum2.Text = "2nd number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(217, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(217, 105)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Lblres
        '
        Me.Lblres.AutoSize = True
        Me.Lblres.Location = New System.Drawing.Point(94, 168)
        Me.Lblres.Name = "Lblres"
        Me.Lblres.Size = New System.Drawing.Size(32, 13)
        Me.Lblres.TabIndex = 4
        Me.Lblres.Text = "result"
        '
        'Lblresult
        '
        Me.Lblresult.AutoSize = True
        Me.Lblresult.BackColor = System.Drawing.Color.Yellow
        Me.Lblresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblresult.Location = New System.Drawing.Point(214, 168)
        Me.Lblresult.Name = "Lblresult"
        Me.Lblresult.Size = New System.Drawing.Size(16, 17)
        Me.Lblresult.TabIndex = 5
        Me.Lblresult.Text = "?"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(146, 213)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 25)
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(315, 213)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(118, 24)
        Me.Btnclear.TabIndex = 7
        Me.Btnclear.Text = "clear"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 268)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Lblresult)
        Me.Controls.Add(Me.Lblres)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.lblnum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnum1 As System.Windows.Forms.Label
    Friend WithEvents lblnum2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Lblres As System.Windows.Forms.Label
    Friend WithEvents Lblresult As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Btnclear As System.Windows.Forms.Button

End Class
