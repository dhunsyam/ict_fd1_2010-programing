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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btngen = New System.Windows.Forms.Button
        Me.Tb1 = New System.Windows.Forms.TextBox
        Me.Lbltitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Btnmute = New System.Windows.Forms.Button
        Me.Btnstart = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btngen
        '
        Me.btngen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngen.Location = New System.Drawing.Point(325, 110)
        Me.btngen.Name = "btngen"
        Me.btngen.Size = New System.Drawing.Size(165, 36)
        Me.btngen.TabIndex = 0
        Me.btngen.Text = "generate keys"
        Me.btngen.UseVisualStyleBackColor = True
        '
        'Tb1
        '
        Me.Tb1.Location = New System.Drawing.Point(271, 68)
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(307, 20)
        Me.Tb1.TabIndex = 1
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Lbltitle.Location = New System.Drawing.Point(284, 27)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(255, 26)
        Me.Lbltitle.TabIndex = 2
        Me.Lbltitle.Text = "Office 2003 serial keys"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 182)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Btnmute
        '
        Me.Btnmute.Location = New System.Drawing.Point(431, 181)
        Me.Btnmute.Name = "Btnmute"
        Me.Btnmute.Size = New System.Drawing.Size(98, 30)
        Me.Btnmute.TabIndex = 4
        Me.Btnmute.Text = "Stop audio"
        Me.Btnmute.UseVisualStyleBackColor = True
        '
        'Btnstart
        '
        Me.Btnstart.Location = New System.Drawing.Point(298, 181)
        Me.Btnstart.Name = "Btnstart"
        Me.Btnstart.Size = New System.Drawing.Size(95, 29)
        Me.Btnstart.TabIndex = 5
        Me.Btnstart.Text = "Start Audio"
        Me.Btnstart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(583, 268)
        Me.Controls.Add(Me.Btnstart)
        Me.Controls.Add(Me.Btnmute)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbltitle)
        Me.Controls.Add(Me.Tb1)
        Me.Controls.Add(Me.btngen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btngen As System.Windows.Forms.Button
    Friend WithEvents Tb1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbltitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btnmute As System.Windows.Forms.Button
    Friend WithEvents Btnstart As System.Windows.Forms.Button

End Class
