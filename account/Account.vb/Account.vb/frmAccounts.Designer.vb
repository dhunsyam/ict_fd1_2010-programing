<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts
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
        Me.Lblaccount1 = New System.Windows.Forms.Label
        Me.Lblaccountno1 = New System.Windows.Forms.Label
        Me.lblaccount2 = New System.Windows.Forms.Label
        Me.Lblaccountno2 = New System.Windows.Forms.Label
        Me.Lblcurrentbalance1 = New System.Windows.Forms.Label
        Me.Lblcurrentbalance2 = New System.Windows.Forms.Label
        Me.Lbl1 = New System.Windows.Forms.Label
        Me.Lbltransterfunds = New System.Windows.Forms.Label
        Me.Lbl2 = New System.Windows.Forms.Label
        Me.Lblenterammount = New System.Windows.Forms.Label
        Me.Btntransferleft = New System.Windows.Forms.Button
        Me.Btntranferright = New System.Windows.Forms.Button
        Me.Btndeposit1 = New System.Windows.Forms.Button
        Me.Btnwithdraw1 = New System.Windows.Forms.Button
        Me.Btndeposit2 = New System.Windows.Forms.Button
        Me.Btnwithdraw2 = New System.Windows.Forms.Button
        Me.Tbammount = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Lblaccount1
        '
        Me.Lblaccount1.AutoSize = True
        Me.Lblaccount1.Location = New System.Drawing.Point(102, 88)
        Me.Lblaccount1.Name = "Lblaccount1"
        Me.Lblaccount1.Size = New System.Drawing.Size(53, 13)
        Me.Lblaccount1.TabIndex = 0
        Me.Lblaccount1.Text = "Account1"
        '
        'Lblaccountno1
        '
        Me.Lblaccountno1.AutoSize = True
        Me.Lblaccountno1.Location = New System.Drawing.Point(102, 128)
        Me.Lblaccountno1.Name = "Lblaccountno1"
        Me.Lblaccountno1.Size = New System.Drawing.Size(31, 13)
        Me.Lblaccountno1.TabIndex = 1
        Me.Lblaccountno1.Text = "1001"
        '
        'lblaccount2
        '
        Me.lblaccount2.AutoSize = True
        Me.lblaccount2.Location = New System.Drawing.Point(371, 88)
        Me.lblaccount2.Name = "lblaccount2"
        Me.lblaccount2.Size = New System.Drawing.Size(53, 13)
        Me.lblaccount2.TabIndex = 2
        Me.lblaccount2.Text = "Account2"
        '
        'Lblaccountno2
        '
        Me.Lblaccountno2.AutoSize = True
        Me.Lblaccountno2.Location = New System.Drawing.Point(371, 137)
        Me.Lblaccountno2.Name = "Lblaccountno2"
        Me.Lblaccountno2.Size = New System.Drawing.Size(31, 13)
        Me.Lblaccountno2.TabIndex = 3
        Me.Lblaccountno2.Text = "1002"
        '
        'Lblcurrentbalance1
        '
        Me.Lblcurrentbalance1.AutoSize = True
        Me.Lblcurrentbalance1.Location = New System.Drawing.Point(102, 205)
        Me.Lblcurrentbalance1.Name = "Lblcurrentbalance1"
        Me.Lblcurrentbalance1.Size = New System.Drawing.Size(83, 13)
        Me.Lblcurrentbalance1.TabIndex = 4
        Me.Lblcurrentbalance1.Text = "Current Balance"
        '
        'Lblcurrentbalance2
        '
        Me.Lblcurrentbalance2.AutoSize = True
        Me.Lblcurrentbalance2.Location = New System.Drawing.Point(371, 205)
        Me.Lblcurrentbalance2.Name = "Lblcurrentbalance2"
        Me.Lblcurrentbalance2.Size = New System.Drawing.Size(83, 13)
        Me.Lblcurrentbalance2.TabIndex = 5
        Me.Lblcurrentbalance2.Text = "Current Balance"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(102, 258)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(39, 13)
        Me.Lbl1.TabIndex = 6
        Me.Lbl1.Text = "Label7"
        '
        'Lbltransterfunds
        '
        Me.Lbltransterfunds.AutoSize = True
        Me.Lbltransterfunds.Location = New System.Drawing.Point(235, 258)
        Me.Lbltransterfunds.Name = "Lbltransterfunds"
        Me.Lbltransterfunds.Size = New System.Drawing.Size(88, 13)
        Me.Lbltransterfunds.TabIndex = 7
        Me.Lbltransterfunds.Text = "Transfer all funds"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(371, 258)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(39, 13)
        Me.Lbl2.TabIndex = 8
        Me.Lbl2.Text = "Label9"
        '
        'Lblenterammount
        '
        Me.Lblenterammount.AutoSize = True
        Me.Lblenterammount.Location = New System.Drawing.Point(205, 373)
        Me.Lblenterammount.Name = "Lblenterammount"
        Me.Lblenterammount.Size = New System.Drawing.Size(145, 13)
        Me.Lblenterammount.TabIndex = 9
        Me.Lblenterammount.Text = "Enter ammount of transaction"
        '
        'Btntransferleft
        '
        Me.Btntransferleft.Location = New System.Drawing.Point(215, 195)
        Me.Btntransferleft.Name = "Btntransferleft"
        Me.Btntransferleft.Size = New System.Drawing.Size(94, 23)
        Me.Btntransferleft.TabIndex = 10
        Me.Btntransferleft.Text = "<<<"
        Me.Btntransferleft.UseVisualStyleBackColor = True
        '
        'Btntranferright
        '
        Me.Btntranferright.Location = New System.Drawing.Point(215, 291)
        Me.Btntranferright.Name = "Btntranferright"
        Me.Btntranferright.Size = New System.Drawing.Size(94, 23)
        Me.Btntranferright.TabIndex = 11
        Me.Btntranferright.Text = ">>>"
        Me.Btntranferright.UseVisualStyleBackColor = True
        '
        'Btndeposit1
        '
        Me.Btndeposit1.Location = New System.Drawing.Point(105, 373)
        Me.Btndeposit1.Name = "Btndeposit1"
        Me.Btndeposit1.Size = New System.Drawing.Size(94, 23)
        Me.Btndeposit1.TabIndex = 12
        Me.Btndeposit1.Text = "Deposit"
        Me.Btndeposit1.UseVisualStyleBackColor = True
        '
        'Btnwithdraw1
        '
        Me.Btnwithdraw1.Location = New System.Drawing.Point(105, 423)
        Me.Btnwithdraw1.Name = "Btnwithdraw1"
        Me.Btnwithdraw1.Size = New System.Drawing.Size(94, 23)
        Me.Btnwithdraw1.TabIndex = 13
        Me.Btnwithdraw1.Text = "Withdraw"
        Me.Btnwithdraw1.UseVisualStyleBackColor = True
        '
        'Btndeposit2
        '
        Me.Btndeposit2.Location = New System.Drawing.Point(354, 373)
        Me.Btndeposit2.Name = "Btndeposit2"
        Me.Btndeposit2.Size = New System.Drawing.Size(94, 23)
        Me.Btndeposit2.TabIndex = 14
        Me.Btndeposit2.Text = "Deposit"
        Me.Btndeposit2.UseVisualStyleBackColor = True
        '
        'Btnwithdraw2
        '
        Me.Btnwithdraw2.Location = New System.Drawing.Point(354, 423)
        Me.Btnwithdraw2.Name = "Btnwithdraw2"
        Me.Btnwithdraw2.Size = New System.Drawing.Size(94, 23)
        Me.Btnwithdraw2.TabIndex = 15
        Me.Btnwithdraw2.Text = "Withdraw"
        Me.Btnwithdraw2.UseVisualStyleBackColor = True
        '
        'Tbammount
        '
        Me.Tbammount.Location = New System.Drawing.Point(251, 422)
        Me.Tbammount.Name = "Tbammount"
        Me.Tbammount.Size = New System.Drawing.Size(57, 20)
        Me.Tbammount.TabIndex = 16
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 522)
        Me.Controls.Add(Me.Tbammount)
        Me.Controls.Add(Me.Btnwithdraw2)
        Me.Controls.Add(Me.Btndeposit2)
        Me.Controls.Add(Me.Btnwithdraw1)
        Me.Controls.Add(Me.Btndeposit1)
        Me.Controls.Add(Me.Btntranferright)
        Me.Controls.Add(Me.Btntransferleft)
        Me.Controls.Add(Me.Lblenterammount)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbltransterfunds)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Lblcurrentbalance2)
        Me.Controls.Add(Me.Lblcurrentbalance1)
        Me.Controls.Add(Me.Lblaccountno2)
        Me.Controls.Add(Me.lblaccount2)
        Me.Controls.Add(Me.Lblaccountno1)
        Me.Controls.Add(Me.Lblaccount1)
        Me.Name = "form"
        Me.Text = "Frm_test_Accounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblaccount1 As System.Windows.Forms.Label
    Friend WithEvents Lblaccountno1 As System.Windows.Forms.Label
    Friend WithEvents lblaccount2 As System.Windows.Forms.Label
    Friend WithEvents Lblaccountno2 As System.Windows.Forms.Label
    Friend WithEvents Lblcurrentbalance1 As System.Windows.Forms.Label
    Friend WithEvents Lblcurrentbalance2 As System.Windows.Forms.Label
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Lbltransterfunds As System.Windows.Forms.Label
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents Lblenterammount As System.Windows.Forms.Label
    Friend WithEvents Btntransferleft As System.Windows.Forms.Button
    Friend WithEvents Btntranferright As System.Windows.Forms.Button
    Friend WithEvents Btndeposit1 As System.Windows.Forms.Button
    Friend WithEvents Btnwithdraw1 As System.Windows.Forms.Button
    Friend WithEvents Btndeposit2 As System.Windows.Forms.Button
    Friend WithEvents Btnwithdraw2 As System.Windows.Forms.Button
    Friend WithEvents Tbammount As System.Windows.Forms.TextBox

End Class
