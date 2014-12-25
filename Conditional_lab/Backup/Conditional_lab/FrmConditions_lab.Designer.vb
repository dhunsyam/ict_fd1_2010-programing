<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConditions_lab
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
        Me.Lblresult = New System.Windows.Forms.Label
        Me.tbvalue2 = New System.Windows.Forms.TextBox
        Me.tbvalue1 = New System.Windows.Forms.TextBox
        Me.BtnEqualto = New System.Windows.Forms.Button
        Me.BtnNotEqualto = New System.Windows.Forms.Button
        Me.Btnlessthan = New System.Windows.Forms.Button
        Me.BtnGreaterthan = New System.Windows.Forms.Button
        Me.Btnlessthanorequalto = New System.Windows.Forms.Button
        Me.Btngreaterthanorequalto = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lblresult
        '
        Me.Lblresult.AutoSize = True
        Me.Lblresult.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Lblresult.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblresult.Location = New System.Drawing.Point(250, 87)
        Me.Lblresult.Name = "Lblresult"
        Me.Lblresult.Size = New System.Drawing.Size(103, 23)
        Me.Lblresult.TabIndex = 0
        Me.Lblresult.Text = "True/False"
        '
        'tbvalue2
        '
        Me.tbvalue2.Location = New System.Drawing.Point(399, 83)
        Me.tbvalue2.Name = "tbvalue2"
        Me.tbvalue2.Size = New System.Drawing.Size(136, 20)
        Me.tbvalue2.TabIndex = 1
        '
        'tbvalue1
        '
        Me.tbvalue1.Location = New System.Drawing.Point(40, 84)
        Me.tbvalue1.Name = "tbvalue1"
        Me.tbvalue1.Size = New System.Drawing.Size(160, 20)
        Me.tbvalue1.TabIndex = 2
        '
        'BtnEqualto
        '
        Me.BtnEqualto.Location = New System.Drawing.Point(77, 154)
        Me.BtnEqualto.Name = "BtnEqualto"
        Me.BtnEqualto.Size = New System.Drawing.Size(123, 22)
        Me.BtnEqualto.TabIndex = 3
        Me.BtnEqualto.Text = "=(equal to)"
        Me.BtnEqualto.UseVisualStyleBackColor = True
        '
        'BtnNotEqualto
        '
        Me.BtnNotEqualto.Location = New System.Drawing.Point(357, 153)
        Me.BtnNotEqualto.Name = "BtnNotEqualto"
        Me.BtnNotEqualto.Size = New System.Drawing.Size(122, 22)
        Me.BtnNotEqualto.TabIndex = 4
        Me.BtnNotEqualto.Text = "<>(not equal to)"
        Me.BtnNotEqualto.UseVisualStyleBackColor = True
        '
        'Btnlessthan
        '
        Me.Btnlessthan.Location = New System.Drawing.Point(77, 218)
        Me.Btnlessthan.Name = "Btnlessthan"
        Me.Btnlessthan.Size = New System.Drawing.Size(132, 24)
        Me.Btnlessthan.TabIndex = 5
        Me.Btnlessthan.Text = "<(less than)"
        Me.Btnlessthan.UseVisualStyleBackColor = True
        '
        'BtnGreaterthan
        '
        Me.BtnGreaterthan.Location = New System.Drawing.Point(357, 218)
        Me.BtnGreaterthan.Name = "BtnGreaterthan"
        Me.BtnGreaterthan.Size = New System.Drawing.Size(133, 24)
        Me.BtnGreaterthan.TabIndex = 6
        Me.BtnGreaterthan.Text = ">(Greater than)"
        Me.BtnGreaterthan.UseVisualStyleBackColor = True
        '
        'Btnlessthanorequalto
        '
        Me.Btnlessthanorequalto.Location = New System.Drawing.Point(357, 278)
        Me.Btnlessthanorequalto.Name = "Btnlessthanorequalto"
        Me.Btnlessthanorequalto.Size = New System.Drawing.Size(133, 28)
        Me.Btnlessthanorequalto.TabIndex = 7
        Me.Btnlessthanorequalto.Text = "<=(less than or equal to)"
        Me.Btnlessthanorequalto.UseVisualStyleBackColor = True
        '
        'Btngreaterthanorequalto
        '
        Me.Btngreaterthanorequalto.Location = New System.Drawing.Point(77, 282)
        Me.Btngreaterthanorequalto.Name = "Btngreaterthanorequalto"
        Me.Btngreaterthanorequalto.Size = New System.Drawing.Size(135, 24)
        Me.Btngreaterthanorequalto.TabIndex = 8
        Me.Btngreaterthanorequalto.Text = ">=(greater than or equal to)"
        Me.Btngreaterthanorequalto.UseVisualStyleBackColor = True
        '
        'FrmConditions_lab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 387)
        Me.Controls.Add(Me.Btngreaterthanorequalto)
        Me.Controls.Add(Me.Btnlessthanorequalto)
        Me.Controls.Add(Me.BtnGreaterthan)
        Me.Controls.Add(Me.Btnlessthan)
        Me.Controls.Add(Me.BtnNotEqualto)
        Me.Controls.Add(Me.BtnEqualto)
        Me.Controls.Add(Me.tbvalue1)
        Me.Controls.Add(Me.tbvalue2)
        Me.Controls.Add(Me.Lblresult)
        Me.Name = "FrmConditions_lab"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblresult As System.Windows.Forms.Label
    Friend WithEvents tbvalue2 As System.Windows.Forms.TextBox
    Friend WithEvents tbvalue1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnEqualto As System.Windows.Forms.Button
    Friend WithEvents BtnNotEqualto As System.Windows.Forms.Button
    Friend WithEvents Btnlessthan As System.Windows.Forms.Button
    Friend WithEvents BtnGreaterthan As System.Windows.Forms.Button
    Friend WithEvents Btnlessthanorequalto As System.Windows.Forms.Button
    Friend WithEvents Btngreaterthanorequalto As System.Windows.Forms.Button

End Class
