<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_procedures
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
        Me.Mtb = New System.Windows.Forms.MaskedTextBox
        Me.Lblloan = New System.Windows.Forms.Label
        Me.Cbintrest = New System.Windows.Forms.ComboBox
        Me.Lblintrest = New System.Windows.Forms.Label
        Me.Gbterm = New System.Windows.Forms.GroupBox
        Me.Rbtn5yrs = New System.Windows.Forms.RadioButton
        Me.Rbtn15yrs = New System.Windows.Forms.RadioButton
        Me.Rbtn30yrs = New System.Windows.Forms.RadioButton
        Me.Btnmpay = New System.Windows.Forms.Button
        Me.Btntp = New System.Windows.Forms.Button
        Me.Btndone = New System.Windows.Forms.Button
        Me.Gbterm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mtb
        '
        Me.Mtb.Location = New System.Drawing.Point(200, 65)
        Me.Mtb.Mask = "00000"
        Me.Mtb.Name = "Mtb"
        Me.Mtb.Size = New System.Drawing.Size(240, 20)
        Me.Mtb.TabIndex = 0
        Me.Mtb.ValidatingType = GetType(Integer)
        '
        'Lblloan
        '
        Me.Lblloan.AutoSize = True
        Me.Lblloan.Location = New System.Drawing.Point(12, 65)
        Me.Lblloan.Name = "Lblloan"
        Me.Lblloan.Size = New System.Drawing.Size(118, 13)
        Me.Lblloan.TabIndex = 1
        Me.Lblloan.Text = "Loan required ammount"
        '
        'Cbintrest
        '
        Me.Cbintrest.FormattingEnabled = True
        Me.Cbintrest.Location = New System.Drawing.Point(207, 122)
        Me.Cbintrest.Name = "Cbintrest"
        Me.Cbintrest.Size = New System.Drawing.Size(148, 21)
        Me.Cbintrest.TabIndex = 2
        '
        'Lblintrest
        '
        Me.Lblintrest.AutoSize = True
        Me.Lblintrest.Location = New System.Drawing.Point(36, 130)
        Me.Lblintrest.Name = "Lblintrest"
        Me.Lblintrest.Size = New System.Drawing.Size(59, 13)
        Me.Lblintrest.TabIndex = 3
        Me.Lblintrest.Text = "intrest rate "
        '
        'Gbterm
        '
        Me.Gbterm.Controls.Add(Me.Rbtn30yrs)
        Me.Gbterm.Controls.Add(Me.Rbtn15yrs)
        Me.Gbterm.Controls.Add(Me.Rbtn5yrs)
        Me.Gbterm.Location = New System.Drawing.Point(200, 176)
        Me.Gbterm.Name = "Gbterm"
        Me.Gbterm.Size = New System.Drawing.Size(142, 161)
        Me.Gbterm.TabIndex = 4
        Me.Gbterm.TabStop = False
        Me.Gbterm.Text = "duration of loan"
        '
        'Rbtn5yrs
        '
        Me.Rbtn5yrs.AutoSize = True
        Me.Rbtn5yrs.Location = New System.Drawing.Point(15, 27)
        Me.Rbtn5yrs.Name = "Rbtn5yrs"
        Me.Rbtn5yrs.Size = New System.Drawing.Size(59, 17)
        Me.Rbtn5yrs.TabIndex = 0
        Me.Rbtn5yrs.TabStop = True
        Me.Rbtn5yrs.Text = "5 years"
        Me.Rbtn5yrs.UseVisualStyleBackColor = True
        '
        'Rbtn15yrs
        '
        Me.Rbtn15yrs.AutoSize = True
        Me.Rbtn15yrs.Location = New System.Drawing.Point(14, 64)
        Me.Rbtn15yrs.Name = "Rbtn15yrs"
        Me.Rbtn15yrs.Size = New System.Drawing.Size(65, 17)
        Me.Rbtn15yrs.TabIndex = 1
        Me.Rbtn15yrs.TabStop = True
        Me.Rbtn15yrs.Text = "15 years"
        Me.Rbtn15yrs.UseVisualStyleBackColor = True
        '
        'Rbtn30yrs
        '
        Me.Rbtn30yrs.AutoSize = True
        Me.Rbtn30yrs.Location = New System.Drawing.Point(14, 103)
        Me.Rbtn30yrs.Name = "Rbtn30yrs"
        Me.Rbtn30yrs.Size = New System.Drawing.Size(65, 17)
        Me.Rbtn30yrs.TabIndex = 2
        Me.Rbtn30yrs.TabStop = True
        Me.Rbtn30yrs.Text = "30 years"
        Me.Rbtn30yrs.UseVisualStyleBackColor = True
        '
        'Btnmpay
        '
        Me.Btnmpay.Location = New System.Drawing.Point(526, 176)
        Me.Btnmpay.Name = "Btnmpay"
        Me.Btnmpay.Size = New System.Drawing.Size(160, 57)
        Me.Btnmpay.TabIndex = 5
        Me.Btnmpay.Text = "monthly payment"
        Me.Btnmpay.UseVisualStyleBackColor = True
        '
        'Btntp
        '
        Me.Btntp.Location = New System.Drawing.Point(528, 263)
        Me.Btntp.Name = "Btntp"
        Me.Btntp.Size = New System.Drawing.Size(157, 57)
        Me.Btntp.TabIndex = 6
        Me.Btntp.Text = "total paid"
        Me.Btntp.UseVisualStyleBackColor = True
        '
        'Btndone
        '
        Me.Btndone.Location = New System.Drawing.Point(536, 356)
        Me.Btndone.Name = "Btndone"
        Me.Btndone.Size = New System.Drawing.Size(148, 52)
        Me.Btndone.TabIndex = 7
        Me.Btndone.Text = "done"
        Me.Btndone.UseVisualStyleBackColor = True
        '
        'frm_procedures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 481)
        Me.Controls.Add(Me.Btndone)
        Me.Controls.Add(Me.Btntp)
        Me.Controls.Add(Me.Btnmpay)
        Me.Controls.Add(Me.Gbterm)
        Me.Controls.Add(Me.Lblintrest)
        Me.Controls.Add(Me.Cbintrest)
        Me.Controls.Add(Me.Lblloan)
        Me.Controls.Add(Me.Mtb)
        Me.Name = "frm_procedures"
        Me.Text = "Form1"
        Me.Gbterm.ResumeLayout(False)
        Me.Gbterm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mtb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Lblloan As System.Windows.Forms.Label
    Friend WithEvents Cbintrest As System.Windows.Forms.ComboBox
    Friend WithEvents Lblintrest As System.Windows.Forms.Label
    Friend WithEvents Gbterm As System.Windows.Forms.GroupBox
    Friend WithEvents Rbtn5yrs As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtn15yrs As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtn30yrs As System.Windows.Forms.RadioButton
    Friend WithEvents Btnmpay As System.Windows.Forms.Button
    Friend WithEvents Btntp As System.Windows.Forms.Button
    Friend WithEvents Btndone As System.Windows.Forms.Button

End Class
