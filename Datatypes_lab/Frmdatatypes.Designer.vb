<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmdatatypes
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
        Me.lblinitial = New System.Windows.Forms.Label
        Me.tblinitial = New System.Windows.Forms.TextBox
        Me.Lblsurname = New System.Windows.Forms.Label
        Me.Tbsurname = New System.Windows.Forms.TextBox
        Me.lbldob = New System.Windows.Forms.Label
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.GbxGender = New System.Windows.Forms.GroupBox
        Me.Rbtnmale = New System.Windows.Forms.RadioButton
        Me.Rbtnfemale = New System.Windows.Forms.RadioButton
        Me.btnshowdetails = New System.Windows.Forms.Button
        Me.Rtbxshowdetails = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        Me.GbxGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblinitial
        '
        Me.lblinitial.AutoSize = True
        Me.lblinitial.Location = New System.Drawing.Point(38, 43)
        Me.lblinitial.Name = "lblinitial"
        Me.lblinitial.Size = New System.Drawing.Size(134, 13)
        Me.lblinitial.TabIndex = 0
        Me.lblinitial.Text = "Please enter your first initial"
        '
        'tblinitial
        '
        Me.tblinitial.Location = New System.Drawing.Point(200, 43)
        Me.tblinitial.Name = "tblinitial"
        Me.tblinitial.Size = New System.Drawing.Size(82, 20)
        Me.tblinitial.TabIndex = 1
        '
        'Lblsurname
        '
        Me.Lblsurname.AutoSize = True
        Me.Lblsurname.Location = New System.Drawing.Point(38, 84)
        Me.Lblsurname.Name = "Lblsurname"
        Me.Lblsurname.Size = New System.Drawing.Size(132, 13)
        Me.Lblsurname.TabIndex = 2
        Me.Lblsurname.Text = "Please enter your surname"
        '
        'Tbsurname
        '
        Me.Tbsurname.Location = New System.Drawing.Point(200, 81)
        Me.Tbsurname.Name = "Tbsurname"
        Me.Tbsurname.Size = New System.Drawing.Size(130, 20)
        Me.Tbsurname.TabIndex = 3
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Location = New System.Drawing.Point(38, 122)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(147, 13)
        Me.lbldob.TabIndex = 4
        Me.lbldob.Text = "please enter your date of birth"
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(200, 115)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(130, 20)
        Me.dtpDOB.TabIndex = 5
        Me.dtpDOB.Value = New Date(1992, 1, 1, 11, 38, 0, 0)
        '
        'GbxGender
        '
        Me.GbxGender.Controls.Add(Me.Rbtnmale)
        Me.GbxGender.Controls.Add(Me.Rbtnfemale)
        Me.GbxGender.Location = New System.Drawing.Point(71, 155)
        Me.GbxGender.Name = "GbxGender"
        Me.GbxGender.Size = New System.Drawing.Size(151, 51)
        Me.GbxGender.TabIndex = 6
        Me.GbxGender.TabStop = False
        Me.GbxGender.Text = "please select your gender"
        '
        'Rbtnmale
        '
        Me.Rbtnmale.AutoSize = True
        Me.Rbtnmale.Location = New System.Drawing.Point(20, 19)
        Me.Rbtnmale.Name = "Rbtnmale"
        Me.Rbtnmale.Size = New System.Drawing.Size(48, 17)
        Me.Rbtnmale.TabIndex = 7
        Me.Rbtnmale.TabStop = True
        Me.Rbtnmale.Text = "Male"
        Me.Rbtnmale.UseVisualStyleBackColor = True
        '
        'Rbtnfemale
        '
        Me.Rbtnfemale.AutoSize = True
        Me.Rbtnfemale.Location = New System.Drawing.Point(74, 19)
        Me.Rbtnfemale.Name = "Rbtnfemale"
        Me.Rbtnfemale.Size = New System.Drawing.Size(59, 17)
        Me.Rbtnfemale.TabIndex = 0
        Me.Rbtnfemale.TabStop = True
        Me.Rbtnfemale.Text = "Female"
        Me.Rbtnfemale.UseVisualStyleBackColor = True
        '
        'btnshowdetails
        '
        Me.btnshowdetails.Location = New System.Drawing.Point(365, 29)
        Me.btnshowdetails.Name = "btnshowdetails"
        Me.btnshowdetails.Size = New System.Drawing.Size(147, 27)
        Me.btnshowdetails.TabIndex = 7
        Me.btnshowdetails.Text = "Show summary of details"
        Me.btnshowdetails.UseVisualStyleBackColor = True
        '
        'Rtbxshowdetails
        '
        Me.Rtbxshowdetails.Location = New System.Drawing.Point(351, 81)
        Me.Rtbxshowdetails.Name = "Rtbxshowdetails"
        Me.Rtbxshowdetails.Size = New System.Drawing.Size(189, 249)
        Me.Rtbxshowdetails.TabIndex = 8
        Me.Rtbxshowdetails.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "clear summary details"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(51, 293)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(99, 20)
        Me.Btnexit.TabIndex = 10
        Me.Btnexit.Text = "exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Frmdatatypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 339)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Rtbxshowdetails)
        Me.Controls.Add(Me.btnshowdetails)
        Me.Controls.Add(Me.GbxGender)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.Tbsurname)
        Me.Controls.Add(Me.Lblsurname)
        Me.Controls.Add(Me.tblinitial)
        Me.Controls.Add(Me.lblinitial)
        Me.Name = "Frmdatatypes"
        Me.Text = "vb.net data types"
        Me.GbxGender.ResumeLayout(False)
        Me.GbxGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinitial As System.Windows.Forms.Label
    Friend WithEvents tblinitial As System.Windows.Forms.TextBox
    Friend WithEvents Lblsurname As System.Windows.Forms.Label
    Friend WithEvents Tbsurname As System.Windows.Forms.TextBox
    Friend WithEvents lbldob As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents GbxGender As System.Windows.Forms.GroupBox
    Friend WithEvents Rbtnmale As System.Windows.Forms.RadioButton
    Friend WithEvents Rbtnfemale As System.Windows.Forms.RadioButton
    Friend WithEvents btnshowdetails As System.Windows.Forms.Button
    Friend WithEvents Rtbxshowdetails As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button

End Class
