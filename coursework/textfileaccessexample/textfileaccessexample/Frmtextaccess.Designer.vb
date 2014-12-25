<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmtextaccess
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
        Me.Lbxtextdata = New System.Windows.Forms.ListBox
        Me.Lblfilename = New System.Windows.Forms.Label
        Me.Btnopen = New System.Windows.Forms.Button
        Me.Btnreadline = New System.Windows.Forms.Button
        Me.OpenFileD = New System.Windows.Forms.OpenFileDialog
        Me.Txbtitle = New System.Windows.Forms.TextBox
        Me.Txbauthor = New System.Windows.Forms.TextBox
        Me.Txbyear = New System.Windows.Forms.TextBox
        Me.btnbackup = New System.Windows.Forms.Button
        Me.Txbpublish = New System.Windows.Forms.TextBox
        Me.Lbltitle = New System.Windows.Forms.Label
        Me.Lblauthor = New System.Windows.Forms.Label
        Me.Lblyear = New System.Windows.Forms.Label
        Me.Lblpublisher = New System.Windows.Forms.Label
        Me.Btnsave = New System.Windows.Forms.Button
        Me.SaveFileD = New System.Windows.Forms.SaveFileDialog
        Me.Btnclear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lbxtextdata
        '
        Me.Lbxtextdata.FormattingEnabled = True
        Me.Lbxtextdata.HorizontalScrollbar = True
        Me.Lbxtextdata.Location = New System.Drawing.Point(31, 68)
        Me.Lbxtextdata.Name = "Lbxtextdata"
        Me.Lbxtextdata.ScrollAlwaysVisible = True
        Me.Lbxtextdata.Size = New System.Drawing.Size(321, 160)
        Me.Lbxtextdata.TabIndex = 0
        '
        'Lblfilename
        '
        Me.Lblfilename.AutoSize = True
        Me.Lblfilename.Location = New System.Drawing.Point(48, 35)
        Me.Lblfilename.Name = "Lblfilename"
        Me.Lblfilename.Size = New System.Drawing.Size(39, 13)
        Me.Lblfilename.TabIndex = 1
        Me.Lblfilename.Text = "Label1"
        '
        'Btnopen
        '
        Me.Btnopen.Location = New System.Drawing.Point(31, 238)
        Me.Btnopen.Name = "Btnopen"
        Me.Btnopen.Size = New System.Drawing.Size(75, 23)
        Me.Btnopen.TabIndex = 2
        Me.Btnopen.Text = "Open File"
        Me.Btnopen.UseVisualStyleBackColor = True
        '
        'Btnreadline
        '
        Me.Btnreadline.Location = New System.Drawing.Point(144, 237)
        Me.Btnreadline.Name = "Btnreadline"
        Me.Btnreadline.Size = New System.Drawing.Size(75, 23)
        Me.Btnreadline.TabIndex = 3
        Me.Btnreadline.Text = "Read a line"
        Me.Btnreadline.UseVisualStyleBackColor = True
        '
        'OpenFileD
        '
        Me.OpenFileD.FileName = "OpenFileDialog1"
        '
        'Txbtitle
        '
        Me.Txbtitle.Location = New System.Drawing.Point(373, 68)
        Me.Txbtitle.Multiline = True
        Me.Txbtitle.Name = "Txbtitle"
        Me.Txbtitle.Size = New System.Drawing.Size(243, 207)
        Me.Txbtitle.TabIndex = 5
        '
        'Txbauthor
        '
        Me.Txbauthor.Location = New System.Drawing.Point(641, 68)
        Me.Txbauthor.Multiline = True
        Me.Txbauthor.Name = "Txbauthor"
        Me.Txbauthor.Size = New System.Drawing.Size(212, 207)
        Me.Txbauthor.TabIndex = 6
        '
        'Txbyear
        '
        Me.Txbyear.Location = New System.Drawing.Point(872, 68)
        Me.Txbyear.Multiline = True
        Me.Txbyear.Name = "Txbyear"
        Me.Txbyear.Size = New System.Drawing.Size(217, 207)
        Me.Txbyear.TabIndex = 7
        '
        'btnbackup
        '
        Me.btnbackup.Location = New System.Drawing.Point(31, 267)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(75, 23)
        Me.btnbackup.TabIndex = 11
        Me.btnbackup.Text = "backup"
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'Txbpublish
        '
        Me.Txbpublish.Location = New System.Drawing.Point(1113, 68)
        Me.Txbpublish.Multiline = True
        Me.Txbpublish.Name = "Txbpublish"
        Me.Txbpublish.Size = New System.Drawing.Size(217, 207)
        Me.Txbpublish.TabIndex = 12
        '
        'Lbltitle
        '
        Me.Lbltitle.Location = New System.Drawing.Point(403, 34)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(100, 23)
        Me.Lbltitle.TabIndex = 13
        Me.Lbltitle.Text = "title"
        '
        'Lblauthor
        '
        Me.Lblauthor.AutoSize = True
        Me.Lblauthor.Location = New System.Drawing.Point(667, 35)
        Me.Lblauthor.Name = "Lblauthor"
        Me.Lblauthor.Size = New System.Drawing.Size(37, 13)
        Me.Lblauthor.TabIndex = 14
        Me.Lblauthor.Text = "author"
        '
        'Lblyear
        '
        Me.Lblyear.AutoSize = True
        Me.Lblyear.Location = New System.Drawing.Point(890, 35)
        Me.Lblyear.Name = "Lblyear"
        Me.Lblyear.Size = New System.Drawing.Size(27, 13)
        Me.Lblyear.TabIndex = 15
        Me.Lblyear.Text = "year"
        '
        'Lblpublisher
        '
        Me.Lblpublisher.AutoSize = True
        Me.Lblpublisher.Location = New System.Drawing.Point(1143, 35)
        Me.Lblpublisher.Name = "Lblpublisher"
        Me.Lblpublisher.Size = New System.Drawing.Size(49, 13)
        Me.Lblpublisher.TabIndex = 16
        Me.Lblpublisher.Text = "publisher"
        '
        'Btnsave
        '
        Me.Btnsave.Location = New System.Drawing.Point(144, 266)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 23)
        Me.Btnsave.TabIndex = 17
        Me.Btnsave.Text = "save file"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(269, 237)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(75, 23)
        Me.Btnclear.TabIndex = 18
        Me.Btnclear.Text = "clear"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Frmtextaccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 349)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Lblpublisher)
        Me.Controls.Add(Me.Lblyear)
        Me.Controls.Add(Me.Lblauthor)
        Me.Controls.Add(Me.Lbltitle)
        Me.Controls.Add(Me.Txbpublish)
        Me.Controls.Add(Me.btnbackup)
        Me.Controls.Add(Me.Txbyear)
        Me.Controls.Add(Me.Txbauthor)
        Me.Controls.Add(Me.Txbtitle)
        Me.Controls.Add(Me.Btnreadline)
        Me.Controls.Add(Me.Btnopen)
        Me.Controls.Add(Me.Lblfilename)
        Me.Controls.Add(Me.Lbxtextdata)
        Me.Name = "Frmtextaccess"
        Me.Text = "frm_textaccess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbxtextdata As System.Windows.Forms.ListBox
    Friend WithEvents Lblfilename As System.Windows.Forms.Label
    Friend WithEvents Btnopen As System.Windows.Forms.Button
    Friend WithEvents Btnreadline As System.Windows.Forms.Button
    Friend WithEvents OpenFileD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Txbtitle As System.Windows.Forms.TextBox
    Friend WithEvents Txbauthor As System.Windows.Forms.TextBox
    Friend WithEvents Txbyear As System.Windows.Forms.TextBox
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents Txbpublish As System.Windows.Forms.TextBox
    Friend WithEvents Lbltitle As System.Windows.Forms.Label
    Friend WithEvents Lblauthor As System.Windows.Forms.Label
    Friend WithEvents Lblyear As System.Windows.Forms.Label
    Friend WithEvents Lblpublisher As System.Windows.Forms.Label
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents SaveFileD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Btnclear As System.Windows.Forms.Button

End Class
