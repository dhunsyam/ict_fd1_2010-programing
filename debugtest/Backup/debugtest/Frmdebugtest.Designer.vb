<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdebugtest
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
        Me.txbinput = New System.Windows.Forms.TextBox
        Me.Lblinput = New System.Windows.Forms.Label
        Me.Lbloutput = New System.Windows.Forms.Label
        Me.Txboutput = New System.Windows.Forms.TextBox
        Me.lblquestion = New System.Windows.Forms.Label
        Me.Btntest = New System.Windows.Forms.Button
        Me.Btnquit = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txbinput
        '
        Me.txbinput.Location = New System.Drawing.Point(107, 166)
        Me.txbinput.Name = "txbinput"
        Me.txbinput.Size = New System.Drawing.Size(241, 20)
        Me.txbinput.TabIndex = 0
        '
        'Lblinput
        '
        Me.Lblinput.AutoSize = True
        Me.Lblinput.Location = New System.Drawing.Point(156, 150)
        Me.Lblinput.Name = "Lblinput"
        Me.Lblinput.Size = New System.Drawing.Size(84, 13)
        Me.Lblinput.TabIndex = 1
        Me.Lblinput.Text = "How old are you"
        '
        'Lbloutput
        '
        Me.Lbloutput.AutoSize = True
        Me.Lbloutput.Location = New System.Drawing.Point(120, 212)
        Me.Lbloutput.Name = "Lbloutput"
        Me.Lbloutput.Size = New System.Drawing.Size(37, 13)
        Me.Lbloutput.TabIndex = 2
        Me.Lbloutput.Text = "output"
        '
        'Txboutput
        '
        Me.Txboutput.Location = New System.Drawing.Point(107, 242)
        Me.Txboutput.Name = "Txboutput"
        Me.Txboutput.Size = New System.Drawing.Size(232, 20)
        Me.Txboutput.TabIndex = 3
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquestion.Location = New System.Drawing.Point(64, 85)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(323, 24)
        Me.lblquestion.TabIndex = 4
        Me.lblquestion.Text = "can you find the programing error"
        '
        'Btntest
        '
        Me.Btntest.Location = New System.Drawing.Point(418, 150)
        Me.Btntest.Name = "Btntest"
        Me.Btntest.Size = New System.Drawing.Size(75, 23)
        Me.Btntest.TabIndex = 5
        Me.Btntest.Text = "test"
        Me.Btntest.UseVisualStyleBackColor = True
        '
        'Btnquit
        '
        Me.Btnquit.Location = New System.Drawing.Point(418, 239)
        Me.Btnquit.Name = "Btnquit"
        Me.Btnquit.Size = New System.Drawing.Size(75, 23)
        Me.Btnquit.TabIndex = 6
        Me.Btnquit.Text = "quit"
        Me.Btnquit.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(418, 189)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "Clear output"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Frmdebugtest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 429)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Btnquit)
        Me.Controls.Add(Me.Btntest)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.Txboutput)
        Me.Controls.Add(Me.Lbloutput)
        Me.Controls.Add(Me.Lblinput)
        Me.Controls.Add(Me.txbinput)
        Me.Name = "Frmdebugtest"
        Me.Text = "Frmdebugtest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbinput As System.Windows.Forms.TextBox
    Friend WithEvents Lblinput As System.Windows.Forms.Label
    Friend WithEvents Lbloutput As System.Windows.Forms.Label
    Friend WithEvents Txboutput As System.Windows.Forms.TextBox
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents Btntest As System.Windows.Forms.Button
    Friend WithEvents Btnquit As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button

End Class
