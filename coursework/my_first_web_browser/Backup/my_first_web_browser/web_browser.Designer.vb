<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class web_browser
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(web_browser))
        Me.Btngo = New System.Windows.Forms.Button
        Me.BtnBack = New System.Windows.Forms.Button
        Me.BtnForward = New System.Windows.Forms.Button
        Me.BtnHome = New System.Windows.Forms.Button
        Me.lblsearch = New System.Windows.Forms.Label
        Me.cbwebsite = New System.Windows.Forms.ComboBox
        Me.Statusstripbrowser = New System.Windows.Forms.StatusStrip
        Me.stslblReady = New System.Windows.Forms.ToolStripStatusLabel
        Me.stsprgPageLoadProgress = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabCtrl = New System.Windows.Forms.TabControl
        Me.Btnstop = New System.Windows.Forms.Button
        Me.Btnrefresh = New System.Windows.Forms.Button
        Me.Btnnewtab = New System.Windows.Forms.Button
        Me.Btnclosetab = New System.Windows.Forms.Button
        Me.btngoogle = New System.Windows.Forms.Button
        Me.Btnmsn = New System.Windows.Forms.Button
        Me.BtnAskJeeves = New System.Windows.Forms.Button
        Me.Btnaddfavorites = New System.Windows.Forms.Button
        Me.Btnclearfavorites = New System.Windows.Forms.Button
        Me.Lstboxfavorites = New System.Windows.Forms.ListBox
        Me.Statusstripbrowser.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btngo
        '
        Me.Btngo.BackgroundImage = CType(resources.GetObject("Btngo.BackgroundImage"), System.Drawing.Image)
        Me.Btngo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btngo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btngo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Btngo.Location = New System.Drawing.Point(283, 5)
        Me.Btngo.Name = "Btngo"
        Me.Btngo.Size = New System.Drawing.Size(53, 42)
        Me.Btngo.TabIndex = 2
        Me.Btngo.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(355, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(40, 20)
        Me.BtnBack.TabIndex = 4
        Me.BtnBack.Text = "<"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnForward
        '
        Me.BtnForward.Location = New System.Drawing.Point(401, 12)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.Size = New System.Drawing.Size(36, 21)
        Me.BtnForward.TabIndex = 5
        Me.BtnForward.Text = ">"
        Me.BtnForward.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Location = New System.Drawing.Point(454, 11)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(56, 23)
        Me.BtnHome.TabIndex = 6
        Me.BtnHome.Text = "Home"
        Me.ToolTip1.SetToolTip(Me.BtnHome, "Click Here to go to the home page")
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.BackColor = System.Drawing.Color.Aqua
        Me.lblsearch.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(15, 5)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(262, 18)
        Me.lblsearch.TabIndex = 8
        Me.lblsearch.Text = "type website address in box below "
        '
        'cbwebsite
        '
        Me.cbwebsite.FormattingEnabled = True
        Me.cbwebsite.Location = New System.Drawing.Point(12, 26)
        Me.cbwebsite.Name = "cbwebsite"
        Me.cbwebsite.Size = New System.Drawing.Size(265, 21)
        Me.cbwebsite.TabIndex = 8
        '
        'Statusstripbrowser
        '
        Me.Statusstripbrowser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stslblReady, Me.stsprgPageLoadProgress})
        Me.Statusstripbrowser.Location = New System.Drawing.Point(0, 663)
        Me.Statusstripbrowser.Name = "Statusstripbrowser"
        Me.Statusstripbrowser.Size = New System.Drawing.Size(1098, 22)
        Me.Statusstripbrowser.TabIndex = 10
        Me.Statusstripbrowser.Text = "StatusStrip"
        '
        'stslblReady
        '
        Me.stslblReady.Name = "stslblReady"
        Me.stslblReady.Size = New System.Drawing.Size(38, 17)
        Me.stslblReady.Text = "Ready"
        '
        'stsprgPageLoadProgress
        '
        Me.stsprgPageLoadProgress.ForeColor = System.Drawing.Color.LimeGreen
        Me.stsprgPageLoadProgress.Name = "stsprgPageLoadProgress"
        Me.stsprgPageLoadProgress.Size = New System.Drawing.Size(100, 16)
        '
        'TabCtrl
        '
        Me.TabCtrl.Location = New System.Drawing.Point(18, 113)
        Me.TabCtrl.Name = "TabCtrl"
        Me.TabCtrl.SelectedIndex = 0
        Me.TabCtrl.Size = New System.Drawing.Size(845, 540)
        Me.TabCtrl.TabIndex = 11
        '
        'Btnstop
        '
        Me.Btnstop.BackgroundImage = CType(resources.GetObject("Btnstop.BackgroundImage"), System.Drawing.Image)
        Me.Btnstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnstop.Location = New System.Drawing.Point(516, 11)
        Me.Btnstop.Name = "Btnstop"
        Me.Btnstop.Size = New System.Drawing.Size(43, 40)
        Me.Btnstop.TabIndex = 12
        Me.Btnstop.UseVisualStyleBackColor = True
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackgroundImage = CType(resources.GetObject("Btnrefresh.BackgroundImage"), System.Drawing.Image)
        Me.Btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnrefresh.Location = New System.Drawing.Point(565, 11)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(49, 40)
        Me.Btnrefresh.TabIndex = 13
        Me.Btnrefresh.UseVisualStyleBackColor = True
        '
        'Btnnewtab
        '
        Me.Btnnewtab.Location = New System.Drawing.Point(638, 20)
        Me.Btnnewtab.Name = "Btnnewtab"
        Me.Btnnewtab.Size = New System.Drawing.Size(69, 23)
        Me.Btnnewtab.TabIndex = 14
        Me.Btnnewtab.Text = "New Tab"
        Me.Btnnewtab.UseVisualStyleBackColor = True
        '
        'Btnclosetab
        '
        Me.Btnclosetab.Location = New System.Drawing.Point(713, 20)
        Me.Btnclosetab.Name = "Btnclosetab"
        Me.Btnclosetab.Size = New System.Drawing.Size(75, 23)
        Me.Btnclosetab.TabIndex = 15
        Me.Btnclosetab.Text = "Close tab"
        Me.Btnclosetab.UseVisualStyleBackColor = True
        '
        'btngoogle
        '
        Me.btngoogle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btngoogle.Location = New System.Drawing.Point(942, 79)
        Me.btngoogle.Name = "btngoogle"
        Me.btngoogle.Size = New System.Drawing.Size(118, 31)
        Me.btngoogle.TabIndex = 9
        Me.btngoogle.Text = "Google"
        Me.btngoogle.UseVisualStyleBackColor = False
        '
        'Btnmsn
        '
        Me.Btnmsn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Btnmsn.Location = New System.Drawing.Point(942, 43)
        Me.Btnmsn.Name = "Btnmsn"
        Me.Btnmsn.Size = New System.Drawing.Size(118, 30)
        Me.Btnmsn.TabIndex = 10
        Me.Btnmsn.Text = "MSN"
        Me.Btnmsn.UseVisualStyleBackColor = False
        '
        'BtnAskJeeves
        '
        Me.BtnAskJeeves.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAskJeeves.Location = New System.Drawing.Point(942, 116)
        Me.BtnAskJeeves.Name = "BtnAskJeeves"
        Me.BtnAskJeeves.Size = New System.Drawing.Size(118, 29)
        Me.BtnAskJeeves.TabIndex = 11
        Me.BtnAskJeeves.Text = "Ask Jeeves"
        Me.BtnAskJeeves.UseVisualStyleBackColor = False
        '
        'Btnaddfavorites
        '
        Me.Btnaddfavorites.Location = New System.Drawing.Point(884, 504)
        Me.Btnaddfavorites.Name = "Btnaddfavorites"
        Me.Btnaddfavorites.Size = New System.Drawing.Size(95, 23)
        Me.Btnaddfavorites.TabIndex = 17
        Me.Btnaddfavorites.Text = "Add to favorites"
        Me.Btnaddfavorites.UseVisualStyleBackColor = True
        '
        'Btnclearfavorites
        '
        Me.Btnclearfavorites.Location = New System.Drawing.Point(982, 504)
        Me.Btnclearfavorites.Name = "Btnclearfavorites"
        Me.Btnclearfavorites.Size = New System.Drawing.Size(104, 23)
        Me.Btnclearfavorites.TabIndex = 18
        Me.Btnclearfavorites.Text = "clear favorites"
        Me.Btnclearfavorites.UseVisualStyleBackColor = True
        '
        'Lstboxfavorites
        '
        Me.Lstboxfavorites.FormattingEnabled = True
        Me.Lstboxfavorites.Location = New System.Drawing.Point(884, 151)
        Me.Lstboxfavorites.Name = "Lstboxfavorites"
        Me.Lstboxfavorites.Size = New System.Drawing.Size(202, 342)
        Me.Lstboxfavorites.TabIndex = 19
        '
        'web_browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 685)
        Me.Controls.Add(Me.Lstboxfavorites)
        Me.Controls.Add(Me.Btnclearfavorites)
        Me.Controls.Add(Me.Btnaddfavorites)
        Me.Controls.Add(Me.BtnAskJeeves)
        Me.Controls.Add(Me.Btnclosetab)
        Me.Controls.Add(Me.Btnmsn)
        Me.Controls.Add(Me.Btnnewtab)
        Me.Controls.Add(Me.btngoogle)
        Me.Controls.Add(Me.Btnrefresh)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.Btnstop)
        Me.Controls.Add(Me.TabCtrl)
        Me.Controls.Add(Me.Statusstripbrowser)
        Me.Controls.Add(Me.cbwebsite)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnForward)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Btngo)
        Me.Name = "web_browser"
        Me.Text = "Dhunerz's  browser"
        Me.Statusstripbrowser.ResumeLayout(False)
        Me.Statusstripbrowser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btngo As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents BtnForward As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents cbwebsite As System.Windows.Forms.ComboBox
    Friend WithEvents Statusstripbrowser As System.Windows.Forms.StatusStrip
    Friend WithEvents stsprgPageLoadProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents stslblReady As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabCtrl As System.Windows.Forms.TabControl
    Friend WithEvents Btnstop As System.Windows.Forms.Button
    Friend WithEvents Btnrefresh As System.Windows.Forms.Button
    Friend WithEvents Btnnewtab As System.Windows.Forms.Button
    Friend WithEvents Btnclosetab As System.Windows.Forms.Button
    Friend WithEvents btngoogle As System.Windows.Forms.Button
    Friend WithEvents Btnmsn As System.Windows.Forms.Button
    Friend WithEvents BtnAskJeeves As System.Windows.Forms.Button
    Friend WithEvents Btnaddfavorites As System.Windows.Forms.Button
    Friend WithEvents Btnclearfavorites As System.Windows.Forms.Button
    Friend WithEvents Lstboxfavorites As System.Windows.Forms.ListBox

End Class
