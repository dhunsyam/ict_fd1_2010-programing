<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprogram_flow_lab
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
        Me.LblGuessPrompt = New System.Windows.Forms.Label
        Me.MsktbguessNumber = New System.Windows.Forms.MaskedTextBox
        Me.Btnguessnumber = New System.Windows.Forms.Button
        Me.Lblguessnumber = New System.Windows.Forms.Label
        Me.Lbltoohigh = New System.Windows.Forms.Label
        Me.LstHighervalues = New System.Windows.Forms.ListBox
        Me.Lbltoolow = New System.Windows.Forms.Label
        Me.Lstlowervalues = New System.Windows.Forms.ListBox
        Me.Lblguessessofar = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LblGuessPrompt
        '
        Me.LblGuessPrompt.AutoSize = True
        Me.LblGuessPrompt.Location = New System.Drawing.Point(69, 84)
        Me.LblGuessPrompt.Name = "LblGuessPrompt"
        Me.LblGuessPrompt.Size = New System.Drawing.Size(192, 13)
        Me.LblGuessPrompt.TabIndex = 0
        Me.LblGuessPrompt.Text = "guess the number im thinking of (0-100)"
        '
        'MsktbguessNumber
        '
        Me.MsktbguessNumber.Location = New System.Drawing.Point(140, 145)
        Me.MsktbguessNumber.Mask = "000"
        Me.MsktbguessNumber.Name = "MsktbguessNumber"
        Me.MsktbguessNumber.Size = New System.Drawing.Size(72, 20)
        Me.MsktbguessNumber.TabIndex = 1
        Me.MsktbguessNumber.Text = "000"
        '
        'Btnguessnumber
        '
        Me.Btnguessnumber.Location = New System.Drawing.Point(88, 214)
        Me.Btnguessnumber.Name = "Btnguessnumber"
        Me.Btnguessnumber.Size = New System.Drawing.Size(213, 63)
        Me.Btnguessnumber.TabIndex = 2
        Me.Btnguessnumber.Text = "Guess Number>>"
        Me.Btnguessnumber.UseVisualStyleBackColor = True
        '
        'Lblguessnumber
        '
        Me.Lblguessnumber.AutoSize = True
        Me.Lblguessnumber.Location = New System.Drawing.Point(118, 324)
        Me.Lblguessnumber.Name = "Lblguessnumber"
        Me.Lblguessnumber.Size = New System.Drawing.Size(161, 13)
        Me.Lblguessnumber.TabIndex = 3
        Me.Lblguessnumber.Text = "I have a number start guessing !!"
        '
        'Lbltoohigh
        '
        Me.Lbltoohigh.AutoSize = True
        Me.Lbltoohigh.Location = New System.Drawing.Point(500, 57)
        Me.Lbltoohigh.Name = "Lbltoohigh"
        Me.Lbltoohigh.Size = New System.Drawing.Size(81, 13)
        Me.Lbltoohigh.TabIndex = 4
        Me.Lbltoohigh.Text = "guesses to high"
        '
        'LstHighervalues
        '
        Me.LstHighervalues.FormattingEnabled = True
        Me.LstHighervalues.Location = New System.Drawing.Point(485, 86)
        Me.LstHighervalues.Name = "LstHighervalues"
        Me.LstHighervalues.Size = New System.Drawing.Size(181, 108)
        Me.LstHighervalues.TabIndex = 5
        '
        'Lbltoolow
        '
        Me.Lbltoolow.AutoSize = True
        Me.Lbltoolow.Location = New System.Drawing.Point(491, 253)
        Me.Lbltoolow.Name = "Lbltoolow"
        Me.Lbltoolow.Size = New System.Drawing.Size(77, 13)
        Me.Lbltoolow.TabIndex = 6
        Me.Lbltoolow.Text = "guesses to low"
        '
        'Lstlowervalues
        '
        Me.Lstlowervalues.FormattingEnabled = True
        Me.Lstlowervalues.Location = New System.Drawing.Point(496, 305)
        Me.Lstlowervalues.Name = "Lstlowervalues"
        Me.Lstlowervalues.Size = New System.Drawing.Size(181, 95)
        Me.Lstlowervalues.TabIndex = 7
        '
        'Lblguessessofar
        '
        Me.Lblguessessofar.AutoSize = True
        Me.Lblguessessofar.Location = New System.Drawing.Point(207, 396)
        Me.Lblguessessofar.Name = "Lblguessessofar"
        Me.Lblguessessofar.Size = New System.Drawing.Size(140, 13)
        Me.Lblguessessofar.TabIndex = 8
        Me.Lblguessessofar.Text = "Number of guesses fo far : 0"
        '
        'frmprogram_flow_lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 481)
        Me.Controls.Add(Me.Lblguessessofar)
        Me.Controls.Add(Me.Lstlowervalues)
        Me.Controls.Add(Me.Lbltoolow)
        Me.Controls.Add(Me.LstHighervalues)
        Me.Controls.Add(Me.Lbltoohigh)
        Me.Controls.Add(Me.Lblguessnumber)
        Me.Controls.Add(Me.Btnguessnumber)
        Me.Controls.Add(Me.MsktbguessNumber)
        Me.Controls.Add(Me.LblGuessPrompt)
        Me.Name = "frmprogram_flow_lab"
        Me.Text = "Higher lower game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblGuessPrompt As System.Windows.Forms.Label
    Friend WithEvents MsktbguessNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Btnguessnumber As System.Windows.Forms.Button
    Friend WithEvents Lblguessnumber As System.Windows.Forms.Label
    Friend WithEvents Lbltoohigh As System.Windows.Forms.Label
    Friend WithEvents LstHighervalues As System.Windows.Forms.ListBox
    Friend WithEvents Lbltoolow As System.Windows.Forms.Label
    Friend WithEvents Lstlowervalues As System.Windows.Forms.ListBox
    Friend WithEvents Lblguessessofar As System.Windows.Forms.Label

End Class
