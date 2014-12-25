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
        Me.LblCount = New System.Windows.Forms.Label
        Me.btn_local_count = New System.Windows.Forms.Button
        Me.BtnstaticCount = New System.Windows.Forms.Button
        Me.btnGlobalCount1 = New System.Windows.Forms.Button
        Me.BtnGlobalCount2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LblCount
        '
        Me.LblCount.AutoSize = True
        Me.LblCount.BackColor = System.Drawing.Color.Aqua
        Me.LblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCount.Location = New System.Drawing.Point(86, 49)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(141, 153)
        Me.LblCount.TabIndex = 0
        Me.LblCount.Text = "0"
        '
        'btn_local_count
        '
        Me.btn_local_count.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_local_count.Location = New System.Drawing.Point(84, 244)
        Me.btn_local_count.Name = "btn_local_count"
        Me.btn_local_count.Size = New System.Drawing.Size(143, 27)
        Me.btn_local_count.TabIndex = 1
        Me.btn_local_count.Text = "Increment Count (local)"
        Me.btn_local_count.UseVisualStyleBackColor = False
        '
        'BtnstaticCount
        '
        Me.BtnstaticCount.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnstaticCount.Location = New System.Drawing.Point(84, 300)
        Me.BtnstaticCount.Name = "BtnstaticCount"
        Me.BtnstaticCount.Size = New System.Drawing.Size(143, 25)
        Me.BtnstaticCount.TabIndex = 2
        Me.BtnstaticCount.Text = "Increment count (static)"
        Me.BtnstaticCount.UseVisualStyleBackColor = False
        '
        'btnGlobalCount1
        '
        Me.btnGlobalCount1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnGlobalCount1.Location = New System.Drawing.Point(84, 345)
        Me.btnGlobalCount1.Name = "btnGlobalCount1"
        Me.btnGlobalCount1.Size = New System.Drawing.Size(143, 23)
        Me.btnGlobalCount1.TabIndex = 3
        Me.btnGlobalCount1.Text = "Increment count (global1)"
        Me.btnGlobalCount1.UseVisualStyleBackColor = False
        '
        'BtnGlobalCount2
        '
        Me.BtnGlobalCount2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnGlobalCount2.Location = New System.Drawing.Point(84, 390)
        Me.BtnGlobalCount2.Name = "BtnGlobalCount2"
        Me.BtnGlobalCount2.Size = New System.Drawing.Size(143, 21)
        Me.BtnGlobalCount2.TabIndex = 4
        Me.BtnGlobalCount2.Text = "Increment count (global2)"
        Me.BtnGlobalCount2.UseVisualStyleBackColor = False
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 474)
        Me.Controls.Add(Me.BtnGlobalCount2)
        Me.Controls.Add(Me.btnGlobalCount1)
        Me.Controls.Add(Me.BtnstaticCount)
        Me.Controls.Add(Me.btn_local_count)
        Me.Controls.Add(Me.LblCount)
        Me.Name = "Frmmain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblCount As System.Windows.Forms.Label
    Friend WithEvents btn_local_count As System.Windows.Forms.Button
    Friend WithEvents BtnstaticCount As System.Windows.Forms.Button
    Friend WithEvents btnGlobalCount1 As System.Windows.Forms.Button
    Friend WithEvents BtnGlobalCount2 As System.Windows.Forms.Button

End Class
