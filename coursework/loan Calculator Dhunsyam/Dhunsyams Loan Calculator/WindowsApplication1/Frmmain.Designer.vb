<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmain
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
        Me.TxtLoanAmount = New System.Windows.Forms.TextBox
        Me.TxtLoanYears = New System.Windows.Forms.TextBox
        Me.TxtLoanRate = New System.Windows.Forms.TextBox
        Me.Btnreset = New System.Windows.Forms.Button
        Me.Btncalculate = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        Me.Pbloan = New System.Windows.Forms.ProgressBar
        Me.DgvLoandetails = New System.Windows.Forms.DataGridView
        Me.Month = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Payment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Interest = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Principle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoanAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblMonthlyPayment = New System.Windows.Forms.Label
        Me.LblLoanAmmount = New System.Windows.Forms.Label
        Me.LblLoanYears = New System.Windows.Forms.Label
        Me.LblloanRate = New System.Windows.Forms.Label
        Me.Lbltitle = New System.Windows.Forms.Label
        CType(Me.DgvLoandetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtLoanAmount
        '
        Me.TxtLoanAmount.Location = New System.Drawing.Point(27, 61)
        Me.TxtLoanAmount.Name = "TxtLoanAmount"
        Me.TxtLoanAmount.Size = New System.Drawing.Size(100, 20)
        Me.TxtLoanAmount.TabIndex = 0
        '
        'TxtLoanYears
        '
        Me.TxtLoanYears.Location = New System.Drawing.Point(155, 61)
        Me.TxtLoanYears.Name = "TxtLoanYears"
        Me.TxtLoanYears.Size = New System.Drawing.Size(100, 20)
        Me.TxtLoanYears.TabIndex = 1
        '
        'TxtLoanRate
        '
        Me.TxtLoanRate.Location = New System.Drawing.Point(275, 61)
        Me.TxtLoanRate.Name = "TxtLoanRate"
        Me.TxtLoanRate.Size = New System.Drawing.Size(100, 20)
        Me.TxtLoanRate.TabIndex = 2
        '
        'Btnreset
        '
        Me.Btnreset.Location = New System.Drawing.Point(390, 32)
        Me.Btnreset.Name = "Btnreset"
        Me.Btnreset.Size = New System.Drawing.Size(75, 23)
        Me.Btnreset.TabIndex = 3
        Me.Btnreset.Text = "Reset"
        Me.Btnreset.UseVisualStyleBackColor = True
        '
        'Btncalculate
        '
        Me.Btncalculate.Location = New System.Drawing.Point(390, 61)
        Me.Btncalculate.Name = "Btncalculate"
        Me.Btncalculate.Size = New System.Drawing.Size(75, 23)
        Me.Btncalculate.TabIndex = 4
        Me.Btncalculate.Text = "Calulate"
        Me.Btncalculate.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(390, 363)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(101, 35)
        Me.Btnexit.TabIndex = 5
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Pbloan
        '
        Me.Pbloan.Location = New System.Drawing.Point(12, 363)
        Me.Pbloan.Name = "Pbloan"
        Me.Pbloan.Size = New System.Drawing.Size(333, 35)
        Me.Pbloan.TabIndex = 6
        '
        'DgvLoandetails
        '
        Me.DgvLoandetails.AllowUserToAddRows = False
        Me.DgvLoandetails.AllowUserToDeleteRows = False
        Me.DgvLoandetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLoandetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Month, Me.Payment, Me.Interest, Me.Principle, Me.LoanAmount})
        Me.DgvLoandetails.Location = New System.Drawing.Point(12, 100)
        Me.DgvLoandetails.Name = "DgvLoandetails"
        Me.DgvLoandetails.ReadOnly = True
        Me.DgvLoandetails.Size = New System.Drawing.Size(508, 241)
        Me.DgvLoandetails.TabIndex = 7
        '
        'Month
        '
        Me.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Month.HeaderText = "Month"
        Me.Month.Name = "Month"
        Me.Month.ReadOnly = True
        Me.Month.Width = 62
        '
        'Payment
        '
        Me.Payment.HeaderText = "Payment"
        Me.Payment.Name = "Payment"
        Me.Payment.ReadOnly = True
        '
        'Interest
        '
        Me.Interest.HeaderText = "Interest"
        Me.Interest.Name = "Interest"
        Me.Interest.ReadOnly = True
        '
        'Principle
        '
        Me.Principle.HeaderText = "Principle"
        Me.Principle.Name = "Principle"
        Me.Principle.ReadOnly = True
        '
        'LoanAmount
        '
        Me.LoanAmount.HeaderText = "Loan Amount"
        Me.LoanAmount.Name = "LoanAmount"
        Me.LoanAmount.ReadOnly = True
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(255, 9)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(0, 13)
        Me.lblMonthlyPayment.TabIndex = 8
        '
        'LblLoanAmmount
        '
        Me.LblLoanAmmount.AutoSize = True
        Me.LblLoanAmmount.Location = New System.Drawing.Point(47, 45)
        Me.LblLoanAmmount.Name = "LblLoanAmmount"
        Me.LblLoanAmmount.Size = New System.Drawing.Size(70, 13)
        Me.LblLoanAmmount.TabIndex = 9
        Me.LblLoanAmmount.Text = "Loan Amount"
        '
        'LblLoanYears
        '
        Me.LblLoanYears.AutoSize = True
        Me.LblLoanYears.Location = New System.Drawing.Point(175, 45)
        Me.LblLoanYears.Name = "LblLoanYears"
        Me.LblLoanYears.Size = New System.Drawing.Size(61, 13)
        Me.LblLoanYears.TabIndex = 10
        Me.LblLoanYears.Text = "Loan Years"
        '
        'LblloanRate
        '
        Me.LblloanRate.AutoSize = True
        Me.LblloanRate.Location = New System.Drawing.Point(288, 45)
        Me.LblloanRate.Name = "LblloanRate"
        Me.LblloanRate.Size = New System.Drawing.Size(57, 13)
        Me.LblloanRate.TabIndex = 11
        Me.LblloanRate.Text = "Loan Rate"
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.ForeColor = System.Drawing.Color.BlueViolet
        Me.Lbltitle.Location = New System.Drawing.Point(37, 9)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(167, 13)
        Me.Lbltitle.TabIndex = 12
        Me.Lbltitle.Text = "Dhunsyam's Loan Calculator"
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 410)
        Me.Controls.Add(Me.Lbltitle)
        Me.Controls.Add(Me.LblloanRate)
        Me.Controls.Add(Me.LblLoanYears)
        Me.Controls.Add(Me.LblLoanAmmount)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.DgvLoandetails)
        Me.Controls.Add(Me.Pbloan)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btncalculate)
        Me.Controls.Add(Me.Btnreset)
        Me.Controls.Add(Me.TxtLoanRate)
        Me.Controls.Add(Me.TxtLoanYears)
        Me.Controls.Add(Me.TxtLoanAmount)
        Me.Name = "Frmmain"
        Me.Text = "Loan Calculator"
        CType(Me.DgvLoandetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLoanAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtLoanYears As System.Windows.Forms.TextBox
    Friend WithEvents TxtLoanRate As System.Windows.Forms.TextBox
    Friend WithEvents Btnreset As System.Windows.Forms.Button
    Friend WithEvents Btncalculate As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents Pbloan As System.Windows.Forms.ProgressBar
    Friend WithEvents DgvLoandetails As System.Windows.Forms.DataGridView
    Friend WithEvents Month As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Interest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Principle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoanAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMonthlyPayment As System.Windows.Forms.Label
    Friend WithEvents LblLoanAmmount As System.Windows.Forms.Label
    Friend WithEvents LblLoanYears As System.Windows.Forms.Label
    Friend WithEvents LblloanRate As System.Windows.Forms.Label
    Friend WithEvents Lbltitle As System.Windows.Forms.Label

End Class
