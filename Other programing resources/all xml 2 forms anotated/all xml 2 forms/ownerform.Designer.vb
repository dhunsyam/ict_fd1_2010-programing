<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ownerform
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TWeight = New System.Windows.Forms.TextBox()
        Me.TAge = New System.Windows.Forms.TextBox()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.BScrollup = New System.Windows.Forms.Button()
        Me.BScrolldown = New System.Windows.Forms.Button()
        Me.BUpdate = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.BCreate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tcode = New System.Windows.Forms.TextBox()
        Me.lendlist = New System.Windows.Forms.Label()
        Me.Bclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 249)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Telephone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 137)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name"
        '
        'TWeight
        '
        Me.TWeight.Location = New System.Drawing.Point(238, 249)
        Me.TWeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TWeight.Name = "TWeight"
        Me.TWeight.Size = New System.Drawing.Size(145, 26)
        Me.TWeight.TabIndex = 12
        '
        'TAge
        '
        Me.TAge.Location = New System.Drawing.Point(238, 197)
        Me.TAge.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TAge.Name = "TAge"
        Me.TAge.Size = New System.Drawing.Size(145, 26)
        Me.TAge.TabIndex = 11
        '
        'TName
        '
        Me.TName.Location = New System.Drawing.Point(238, 137)
        Me.TName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(145, 26)
        Me.TName.TabIndex = 10
        '
        'BScrollup
        '
        Me.BScrollup.Location = New System.Drawing.Point(325, 385)
        Me.BScrollup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BScrollup.Name = "BScrollup"
        Me.BScrollup.Size = New System.Drawing.Size(144, 37)
        Me.BScrollup.TabIndex = 9
        Me.BScrollup.Text = "scroll up"
        Me.BScrollup.UseVisualStyleBackColor = True
        '
        'BScrolldown
        '
        Me.BScrolldown.Location = New System.Drawing.Point(113, 385)
        Me.BScrolldown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BScrolldown.Name = "BScrolldown"
        Me.BScrolldown.Size = New System.Drawing.Size(144, 37)
        Me.BScrolldown.TabIndex = 8
        Me.BScrolldown.Text = "scroll down"
        Me.BScrolldown.UseVisualStyleBackColor = True
        '
        'BUpdate
        '
        Me.BUpdate.Location = New System.Drawing.Point(584, 152)
        Me.BUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BUpdate.Name = "BUpdate"
        Me.BUpdate.Size = New System.Drawing.Size(132, 33)
        Me.BUpdate.TabIndex = 16
        Me.BUpdate.Text = "update"
        Me.BUpdate.UseVisualStyleBackColor = True
        '
        'BDelete
        '
        Me.BDelete.Location = New System.Drawing.Point(584, 225)
        Me.BDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(132, 33)
        Me.BDelete.TabIndex = 17
        Me.BDelete.Text = "delete"
        Me.BDelete.UseVisualStyleBackColor = True
        '
        'BCreate
        '
        Me.BCreate.Location = New System.Drawing.Point(584, 300)
        Me.BCreate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BCreate.Name = "BCreate"
        Me.BCreate.Size = New System.Drawing.Size(132, 33)
        Me.BCreate.TabIndex = 18
        Me.BCreate.Text = "create"
        Me.BCreate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Code"
        '
        'Tcode
        '
        Me.Tcode.Location = New System.Drawing.Point(238, 79)
        Me.Tcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tcode.Name = "Tcode"
        Me.Tcode.Size = New System.Drawing.Size(145, 26)
        Me.Tcode.TabIndex = 19
        '
        'lendlist
        '
        Me.lendlist.AutoSize = True
        Me.lendlist.Location = New System.Drawing.Point(278, 76)
        Me.lendlist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lendlist.Name = "lendlist"
        Me.lendlist.Size = New System.Drawing.Size(0, 19)
        Me.lendlist.TabIndex = 21
        '
        'Bclose
        '
        Me.Bclose.Location = New System.Drawing.Point(584, 72)
        Me.Bclose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bclose.Name = "Bclose"
        Me.Bclose.Size = New System.Drawing.Size(132, 33)
        Me.Bclose.TabIndex = 22
        Me.Bclose.Text = "close"
        Me.Bclose.UseVisualStyleBackColor = True
        '
        'ownerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(818, 487)
        Me.Controls.Add(Me.Bclose)
        Me.Controls.Add(Me.lendlist)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tcode)
        Me.Controls.Add(Me.BCreate)
        Me.Controls.Add(Me.BDelete)
        Me.Controls.Add(Me.BUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TWeight)
        Me.Controls.Add(Me.TAge)
        Me.Controls.Add(Me.TName)
        Me.Controls.Add(Me.BScrollup)
        Me.Controls.Add(Me.BScrolldown)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ownerform"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TWeight As System.Windows.Forms.TextBox
    Friend WithEvents TAge As System.Windows.Forms.TextBox
    Friend WithEvents TName As System.Windows.Forms.TextBox
    Friend WithEvents BScrollup As System.Windows.Forms.Button
    Friend WithEvents BScrolldown As System.Windows.Forms.Button
    Friend WithEvents BUpdate As System.Windows.Forms.Button
    Friend WithEvents BDelete As System.Windows.Forms.Button
    Friend WithEvents BCreate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tcode As System.Windows.Forms.TextBox
    Friend WithEvents lendlist As System.Windows.Forms.Label
    Friend WithEvents Bclose As System.Windows.Forms.Button
End Class