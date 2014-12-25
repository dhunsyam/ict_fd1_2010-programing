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
        Me.WbBrowser = New System.Windows.Forms.WebBrowser
        Me.Tbwebsite = New System.Windows.Forms.TextBox
        Me.Btn_website = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'WbBrowser
        '
        Me.WbBrowser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WbBrowser.Location = New System.Drawing.Point(0, 184)
        Me.WbBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbBrowser.Name = "WbBrowser"
        Me.WbBrowser.Size = New System.Drawing.Size(901, 431)
        Me.WbBrowser.TabIndex = 0
        Me.WbBrowser.Url = New System.Uri("http://www.facebook.com", System.UriKind.Absolute)
        '
        'Tbwebsite
        '
        Me.Tbwebsite.Location = New System.Drawing.Point(277, 79)
        Me.Tbwebsite.Name = "Tbwebsite"
        Me.Tbwebsite.Size = New System.Drawing.Size(442, 20)
        Me.Tbwebsite.TabIndex = 1
        Me.Tbwebsite.Text = "enter full website url here"
        '
        'Btn_website
        '
        Me.Btn_website.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_website.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_website.Location = New System.Drawing.Point(737, 77)
        Me.Btn_website.Name = "Btn_website"
        Me.Btn_website.Size = New System.Drawing.Size(90, 21)
        Me.Btn_website.TabIndex = 2
        Me.Btn_website.Text = ">>>GO>>>"
        Me.Btn_website.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Go to website"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 615)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_website)
        Me.Controls.Add(Me.Tbwebsite)
        Me.Controls.Add(Me.WbBrowser)
        Me.Name = "Form1"
        Me.Text = "My first web brwser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WbBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents Tbwebsite As System.Windows.Forms.TextBox
    Friend WithEvents Btn_website As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
