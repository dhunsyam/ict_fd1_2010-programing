<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_loops_lab
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
        Me.LblSelectNumber = New System.Windows.Forms.Label
        Me.nmSelectNumber = New System.Windows.Forms.NumericUpDown
        Me.BtnCalculatetable = New System.Windows.Forms.Button
        Me.Lbllimit = New System.Windows.Forms.Label
        Me.nmchangelimit = New System.Windows.Forms.NumericUpDown
        Me.Btnchangelimit = New System.Windows.Forms.Button
        Me.Lbltimestables = New System.Windows.Forms.Label
        Me.Lblupto = New System.Windows.Forms.Label
        Me.lbxtimestabledisplay = New System.Windows.Forms.ListBox
        CType(Me.nmSelectNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmchangelimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSelectNumber
        '
        Me.LblSelectNumber.AutoSize = True
        Me.LblSelectNumber.Location = New System.Drawing.Point(21, 74)
        Me.LblSelectNumber.Name = "LblSelectNumber"
        Me.LblSelectNumber.Size = New System.Drawing.Size(206, 13)
        Me.LblSelectNumber.TabIndex = 0
        Me.LblSelectNumber.Text = "please select number to calculate table for"
        '
        'nmSelectNumber
        '
        Me.nmSelectNumber.Location = New System.Drawing.Point(70, 105)
        Me.nmSelectNumber.Name = "nmSelectNumber"
        Me.nmSelectNumber.Size = New System.Drawing.Size(83, 20)
        Me.nmSelectNumber.TabIndex = 1
        '
        'BtnCalculatetable
        '
        Me.BtnCalculatetable.Location = New System.Drawing.Point(57, 149)
        Me.BtnCalculatetable.Name = "BtnCalculatetable"
        Me.BtnCalculatetable.Size = New System.Drawing.Size(116, 56)
        Me.BtnCalculatetable.TabIndex = 2
        Me.BtnCalculatetable.Text = "calculate times tables up to 12>>>"
        Me.BtnCalculatetable.UseVisualStyleBackColor = True
        '
        'Lbllimit
        '
        Me.Lbllimit.AutoSize = True
        Me.Lbllimit.Location = New System.Drawing.Point(67, 308)
        Me.Lbllimit.Name = "Lbllimit"
        Me.Lbllimit.Size = New System.Drawing.Size(99, 13)
        Me.Lbllimit.TabIndex = 3
        Me.Lbllimit.Text = "or select a new limit"
        '
        'nmchangelimit
        '
        Me.nmchangelimit.Location = New System.Drawing.Point(57, 352)
        Me.nmchangelimit.Name = "nmchangelimit"
        Me.nmchangelimit.Size = New System.Drawing.Size(109, 20)
        Me.nmchangelimit.TabIndex = 4
        '
        'Btnchangelimit
        '
        Me.Btnchangelimit.Location = New System.Drawing.Point(48, 427)
        Me.Btnchangelimit.Name = "Btnchangelimit"
        Me.Btnchangelimit.Size = New System.Drawing.Size(142, 74)
        Me.Btnchangelimit.TabIndex = 5
        Me.Btnchangelimit.Text = "change limit and calulate"
        Me.Btnchangelimit.UseVisualStyleBackColor = True
        '
        'Lbltimestables
        '
        Me.Lbltimestables.AutoSize = True
        Me.Lbltimestables.Location = New System.Drawing.Point(309, 74)
        Me.Lbltimestables.Name = "Lbltimestables"
        Me.Lbltimestables.Size = New System.Drawing.Size(77, 13)
        Me.Lbltimestables.TabIndex = 6
        Me.Lbltimestables.Text = "times tables for"
        '
        'Lblupto
        '
        Me.Lblupto.AutoSize = True
        Me.Lblupto.Location = New System.Drawing.Point(309, 108)
        Me.Lblupto.Name = "Lblupto"
        Me.Lblupto.Size = New System.Drawing.Size(31, 13)
        Me.Lblupto.TabIndex = 7
        Me.Lblupto.Text = "up to"
        '
        'lbxtimestabledisplay
        '
        Me.lbxtimestabledisplay.FormattingEnabled = True
        Me.lbxtimestabledisplay.Location = New System.Drawing.Point(276, 153)
        Me.lbxtimestabledisplay.Name = "lbxtimestabledisplay"
        Me.lbxtimestabledisplay.Size = New System.Drawing.Size(263, 368)
        Me.lbxtimestabledisplay.TabIndex = 8
        '
        'Frm_loops_lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 675)
        Me.Controls.Add(Me.lbxtimestabledisplay)
        Me.Controls.Add(Me.Lblupto)
        Me.Controls.Add(Me.Lbltimestables)
        Me.Controls.Add(Me.Btnchangelimit)
        Me.Controls.Add(Me.nmchangelimit)
        Me.Controls.Add(Me.Lbllimit)
        Me.Controls.Add(Me.BtnCalculatetable)
        Me.Controls.Add(Me.nmSelectNumber)
        Me.Controls.Add(Me.LblSelectNumber)
        Me.Name = "Frm_loops_lab"
        Me.Text = "Form1"
        CType(Me.nmSelectNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmchangelimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSelectNumber As System.Windows.Forms.Label
    Friend WithEvents nmSelectNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnCalculatetable As System.Windows.Forms.Button
    Friend WithEvents Lbllimit As System.Windows.Forms.Label
    Friend WithEvents nmchangelimit As System.Windows.Forms.NumericUpDown
    Friend WithEvents Btnchangelimit As System.Windows.Forms.Button
    Friend WithEvents Lbltimestables As System.Windows.Forms.Label
    Friend WithEvents Lblupto As System.Windows.Forms.Label
    Friend WithEvents lbxtimestabledisplay As System.Windows.Forms.ListBox

End Class
