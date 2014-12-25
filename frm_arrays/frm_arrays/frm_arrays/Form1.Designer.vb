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
        Me.Lbltitle = New System.Windows.Forms.Label
        Me.Lblstudentno = New System.Windows.Forms.Label
        Me.Lblstudentname = New System.Windows.Forms.Label
        Me.Btnstudentdetails = New System.Windows.Forms.Button
        Me.Lblstudentnoshow = New System.Windows.Forms.Label
        Me.Lblstudentnameshow = New System.Windows.Forms.Label
        Me.Lblinfo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Location = New System.Drawing.Point(442, 29)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(81, 13)
        Me.Lbltitle.TabIndex = 0
        Me.Lbltitle.Text = "Exploring arrays"
        '
        'Lblstudentno
        '
        Me.Lblstudentno.AutoSize = True
        Me.Lblstudentno.Location = New System.Drawing.Point(210, 120)
        Me.Lblstudentno.Name = "Lblstudentno"
        Me.Lblstudentno.Size = New System.Drawing.Size(60, 13)
        Me.Lblstudentno.TabIndex = 1
        Me.Lblstudentno.Text = "student no."
        '
        'Lblstudentname
        '
        Me.Lblstudentname.AutoSize = True
        Me.Lblstudentname.Location = New System.Drawing.Point(211, 216)
        Me.Lblstudentname.Name = "Lblstudentname"
        Me.Lblstudentname.Size = New System.Drawing.Size(71, 13)
        Me.Lblstudentname.TabIndex = 2
        Me.Lblstudentname.Text = "student name"
        '
        'Btnstudentdetails
        '
        Me.Btnstudentdetails.Location = New System.Drawing.Point(214, 305)
        Me.Btnstudentdetails.Name = "Btnstudentdetails"
        Me.Btnstudentdetails.Size = New System.Drawing.Size(121, 50)
        Me.Btnstudentdetails.TabIndex = 3
        Me.Btnstudentdetails.Text = "show student details"
        Me.Btnstudentdetails.UseVisualStyleBackColor = True
        '
        'Lblstudentnoshow
        '
        Me.Lblstudentnoshow.AutoSize = True
        Me.Lblstudentnoshow.Location = New System.Drawing.Point(340, 120)
        Me.Lblstudentnoshow.Name = "Lblstudentnoshow"
        Me.Lblstudentnoshow.Size = New System.Drawing.Size(9, 13)
        Me.Lblstudentnoshow.TabIndex = 4
        Me.Lblstudentnoshow.Text = "l"
        '
        'Lblstudentnameshow
        '
        Me.Lblstudentnameshow.AutoSize = True
        Me.Lblstudentnameshow.Location = New System.Drawing.Point(340, 216)
        Me.Lblstudentnameshow.Name = "Lblstudentnameshow"
        Me.Lblstudentnameshow.Size = New System.Drawing.Size(13, 13)
        Me.Lblstudentnameshow.TabIndex = 5
        Me.Lblstudentnameshow.Text = "L"
        '
        'Lblinfo
        '
        Me.Lblinfo.AutoSize = True
        Me.Lblinfo.Location = New System.Drawing.Point(891, 438)
        Me.Lblinfo.Name = "Lblinfo"
        Me.Lblinfo.Size = New System.Drawing.Size(132, 26)
        Me.Lblinfo.TabIndex = 6
        Me.Lblinfo.Text = "Created by Dhunsyam Daji" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "created january 2011" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 486)
        Me.Controls.Add(Me.Lblinfo)
        Me.Controls.Add(Me.Lblstudentnameshow)
        Me.Controls.Add(Me.Lblstudentnoshow)
        Me.Controls.Add(Me.Btnstudentdetails)
        Me.Controls.Add(Me.Lblstudentname)
        Me.Controls.Add(Me.Lblstudentno)
        Me.Controls.Add(Me.Lbltitle)
        Me.Name = "Form1"
        Me.Text = "Frm_array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbltitle As System.Windows.Forms.Label
    Friend WithEvents Lblstudentno As System.Windows.Forms.Label
    Friend WithEvents Lblstudentname As System.Windows.Forms.Label
    Friend WithEvents Btnstudentdetails As System.Windows.Forms.Button
    Friend WithEvents Lblstudentnoshow As System.Windows.Forms.Label
    Friend WithEvents Lblstudentnameshow As System.Windows.Forms.Label
    Friend WithEvents Lblinfo As System.Windows.Forms.Label

End Class
