<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Me.BLogin = New System.Windows.Forms.Button
        Me.TPassword = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Blogout = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BLogin
        '
        Me.BLogin.Location = New System.Drawing.Point(70, 56)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(83, 22)
        Me.BLogin.TabIndex = 0
        Me.BLogin.Text = "log in"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(54, 120)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Size = New System.Drawing.Size(122, 20)
        Me.TPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "enter password"
        '
        'Blogout
        '
        Me.Blogout.Location = New System.Drawing.Point(70, 169)
        Me.Blogout.Name = "Blogout"
        Me.Blogout.Size = New System.Drawing.Size(83, 22)
        Me.Blogout.TabIndex = 3
        Me.Blogout.Text = "log out"
        Me.Blogout.UseVisualStyleBackColor = True
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Blogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.BLogin)
        Me.Name = "loginform"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BLogin As System.Windows.Forms.Button
    Friend WithEvents TPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Blogout As System.Windows.Forms.Button

End Class
