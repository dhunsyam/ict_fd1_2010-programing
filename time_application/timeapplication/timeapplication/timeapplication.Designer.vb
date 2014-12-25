<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timeapplication
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
        Me.Btncreatenewobject = New System.Windows.Forms.Button
        Me.Btnsettime = New System.Windows.Forms.Button
        Me.Btnunitime = New System.Windows.Forms.Button
        Me.Btnstdtime = New System.Windows.Forms.Button
        Me.Lblcreatenewobject = New System.Windows.Forms.Label
        Me.Tbsettimehr = New System.Windows.Forms.TextBox
        Me.Tbsettimemin = New System.Windows.Forms.TextBox
        Me.Tbsettimesec = New System.Windows.Forms.TextBox
        Me.Lblunitime = New System.Windows.Forms.Label
        Me.Lblstdtime = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Btncreatenewobject
        '
        Me.Btncreatenewobject.Location = New System.Drawing.Point(50, 88)
        Me.Btncreatenewobject.Name = "Btncreatenewobject"
        Me.Btncreatenewobject.Size = New System.Drawing.Size(138, 23)
        Me.Btncreatenewobject.TabIndex = 0
        Me.Btncreatenewobject.Text = "create new object"
        Me.Btncreatenewobject.UseVisualStyleBackColor = True
        '
        'Btnsettime
        '
        Me.Btnsettime.Location = New System.Drawing.Point(50, 150)
        Me.Btnsettime.Name = "Btnsettime"
        Me.Btnsettime.Size = New System.Drawing.Size(138, 24)
        Me.Btnsettime.TabIndex = 1
        Me.Btnsettime.Text = "set time"
        Me.Btnsettime.UseVisualStyleBackColor = True
        '
        'Btnunitime
        '
        Me.Btnunitime.Location = New System.Drawing.Point(50, 215)
        Me.Btnunitime.Name = "Btnunitime"
        Me.Btnunitime.Size = New System.Drawing.Size(138, 22)
        Me.Btnunitime.TabIndex = 2
        Me.Btnunitime.Text = "universal time"
        Me.Btnunitime.UseVisualStyleBackColor = True
        '
        'Btnstdtime
        '
        Me.Btnstdtime.Location = New System.Drawing.Point(50, 281)
        Me.Btnstdtime.Name = "Btnstdtime"
        Me.Btnstdtime.Size = New System.Drawing.Size(138, 22)
        Me.Btnstdtime.TabIndex = 3
        Me.Btnstdtime.Text = "standard time"
        Me.Btnstdtime.UseVisualStyleBackColor = True
        '
        'Lblcreatenewobject
        '
        Me.Lblcreatenewobject.AutoSize = True
        Me.Lblcreatenewobject.Location = New System.Drawing.Point(245, 96)
        Me.Lblcreatenewobject.Name = "Lblcreatenewobject"
        Me.Lblcreatenewobject.Size = New System.Drawing.Size(9, 13)
        Me.Lblcreatenewobject.TabIndex = 4
        Me.Lblcreatenewobject.Text = "l"
        '
        'Tbsettimehr
        '
        Me.Tbsettimehr.Location = New System.Drawing.Point(249, 154)
        Me.Tbsettimehr.Name = "Tbsettimehr"
        Me.Tbsettimehr.Size = New System.Drawing.Size(35, 20)
        Me.Tbsettimehr.TabIndex = 5
        '
        'Tbsettimemin
        '
        Me.Tbsettimemin.Location = New System.Drawing.Point(300, 154)
        Me.Tbsettimemin.Name = "Tbsettimemin"
        Me.Tbsettimemin.Size = New System.Drawing.Size(35, 20)
        Me.Tbsettimemin.TabIndex = 6
        '
        'Tbsettimesec
        '
        Me.Tbsettimesec.Location = New System.Drawing.Point(350, 154)
        Me.Tbsettimesec.Name = "Tbsettimesec"
        Me.Tbsettimesec.Size = New System.Drawing.Size(35, 20)
        Me.Tbsettimesec.TabIndex = 7
        '
        'Lblunitime
        '
        Me.Lblunitime.AutoSize = True
        Me.Lblunitime.Location = New System.Drawing.Point(259, 224)
        Me.Lblunitime.Name = "Lblunitime"
        Me.Lblunitime.Size = New System.Drawing.Size(9, 13)
        Me.Lblunitime.TabIndex = 8
        Me.Lblunitime.Text = "l"
        '
        'Lblstdtime
        '
        Me.Lblstdtime.AutoSize = True
        Me.Lblstdtime.Location = New System.Drawing.Point(261, 284)
        Me.Lblstdtime.Name = "Lblstdtime"
        Me.Lblstdtime.Size = New System.Drawing.Size(13, 13)
        Me.Lblstdtime.TabIndex = 9
        Me.Lblstdtime.Text = "L"
        '
        'timeapplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 420)
        Me.Controls.Add(Me.Lblstdtime)
        Me.Controls.Add(Me.Lblunitime)
        Me.Controls.Add(Me.Tbsettimesec)
        Me.Controls.Add(Me.Tbsettimemin)
        Me.Controls.Add(Me.Tbsettimehr)
        Me.Controls.Add(Me.Lblcreatenewobject)
        Me.Controls.Add(Me.Btnstdtime)
        Me.Controls.Add(Me.Btnunitime)
        Me.Controls.Add(Me.Btnsettime)
        Me.Controls.Add(Me.Btncreatenewobject)
        Me.Name = "timeapplication"
        Me.Text = "timeapplication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btncreatenewobject As System.Windows.Forms.Button
    Friend WithEvents Btnsettime As System.Windows.Forms.Button
    Friend WithEvents Btnunitime As System.Windows.Forms.Button
    Friend WithEvents Btnstdtime As System.Windows.Forms.Button
    Friend WithEvents Lblcreatenewobject As System.Windows.Forms.Label
    Friend WithEvents Tbsettimehr As System.Windows.Forms.TextBox
    Friend WithEvents Tbsettimemin As System.Windows.Forms.TextBox
    Friend WithEvents Tbsettimesec As System.Windows.Forms.TextBox
    Friend WithEvents Lblunitime As System.Windows.Forms.Label
    Friend WithEvents Lblstdtime As System.Windows.Forms.Label

End Class
