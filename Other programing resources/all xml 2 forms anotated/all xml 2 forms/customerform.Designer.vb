<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerform
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
        Me.BScrolldown = New System.Windows.Forms.Button()
        Me.BScrollup = New System.Windows.Forms.Button()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.TAge = New System.Windows.Forms.TextBox()
        Me.TWeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TCode = New System.Windows.Forms.TextBox()
        Me.lendlist = New System.Windows.Forms.Label()
        Me.Bclose = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BScrolldown
        '
        Me.BScrolldown.Location = New System.Drawing.Point(33, 189)
        Me.BScrolldown.Name = "BScrolldown"
        Me.BScrolldown.Size = New System.Drawing.Size(96, 25)
        Me.BScrolldown.TabIndex = 0
        Me.BScrolldown.Text = "scroll down"
        Me.BScrolldown.UseVisualStyleBackColor = True
        '
        'BScrollup
        '
        Me.BScrollup.Location = New System.Drawing.Point(245, 189)
        Me.BScrollup.Name = "BScrollup"
        Me.BScrollup.Size = New System.Drawing.Size(96, 25)
        Me.BScrollup.TabIndex = 1
        Me.BScrollup.Text = "scroll up"
        Me.BScrollup.UseVisualStyleBackColor = True
        '
        'TName
        '
        Me.TName.Location = New System.Drawing.Point(157, 69)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(99, 20)
        Me.TName.TabIndex = 2
        '
        'TAge
        '
        Me.TAge.Location = New System.Drawing.Point(157, 109)
        Me.TAge.Name = "TAge"
        Me.TAge.Size = New System.Drawing.Size(99, 20)
        Me.TAge.TabIndex = 3
        '
        'TWeight
        '
        Me.TWeight.Location = New System.Drawing.Point(157, 145)
        Me.TWeight.Name = "TWeight"
        Me.TWeight.Size = New System.Drawing.Size(99, 20)
        Me.TWeight.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Telephone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Code"
        '
        'TCode
        '
        Me.TCode.Location = New System.Drawing.Point(157, 28)
        Me.TCode.Name = "TCode"
        Me.TCode.Size = New System.Drawing.Size(99, 20)
        Me.TCode.TabIndex = 8
        '
        'lendlist
        '
        Me.lendlist.AutoSize = True
        Me.lendlist.Location = New System.Drawing.Point(151, 35)
        Me.lendlist.Name = "lendlist"
        Me.lendlist.Size = New System.Drawing.Size(0, 13)
        Me.lendlist.TabIndex = 10
        '
        'Bclose
        '
        Me.Bclose.Location = New System.Drawing.Point(144, 237)
        Me.Bclose.Name = "Bclose"
        Me.Bclose.Size = New System.Drawing.Size(96, 25)
        Me.Bclose.TabIndex = 11
        Me.Bclose.Text = "close"
        Me.Bclose.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(310, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(203, 12)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(37, 4)
        Me.ListBox3.TabIndex = 15
        '
        'customerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(460, 339)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Bclose)
        Me.Controls.Add(Me.lendlist)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TWeight)
        Me.Controls.Add(Me.TAge)
        Me.Controls.Add(Me.TName)
        Me.Controls.Add(Me.BScrollup)
        Me.Controls.Add(Me.BScrolldown)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.HelpButton = True
        Me.Name = "customerform"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BScrolldown As System.Windows.Forms.Button
    Friend WithEvents BScrollup As System.Windows.Forms.Button
    Friend WithEvents TName As System.Windows.Forms.TextBox
    Friend WithEvents TAge As System.Windows.Forms.TextBox
    Friend WithEvents TWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TCode As System.Windows.Forms.TextBox
    Friend WithEvents lendlist As System.Windows.Forms.Label
    Friend WithEvents Bclose As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
End Class
