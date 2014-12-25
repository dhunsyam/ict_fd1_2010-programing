<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm1
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
        Me.WbBrowser = New System.Windows.Forms.WebBrowser
        Me.tbwebsite = New System.Windows.Forms.TextBox
        Me.Btngo = New System.Windows.Forms.Button
        Me.BtnBack = New System.Windows.Forms.Button
        Me.BtnForward = New System.Windows.Forms.Button
        Me.BtnHome = New System.Windows.Forms.Button
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.BtnAskJeeves = New System.Windows.Forms.Button
        Me.Btnmsn = New System.Windows.Forms.Button
        Me.btngoogle = New System.Windows.Forms.Button
        Me.lblsearch = New System.Windows.Forms.Label
        Me.cbwebsite = New System.Windows.Forms.ComboBox
        Me.Mnubrowser = New System.Windows.Forms.MenuStrip
        Me.mnusearch = New System.Windows.Forms.ToolStripMenuItem
        Me.mnugoogle = New System.Windows.Forms.ToolStripMenuItem
        Me.mnumsn = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuaskjeeves = New System.Windows.Forms.ToolStripMenuItem
        Me.mnunavigate = New System.Windows.Forms.ToolStripMenuItem
        Me.mnugo = New System.Windows.Forms.ToolStripMenuItem
        Me.menuback = New System.Windows.Forms.ToolStripMenuItem
        Me.menuhome = New System.Windows.Forms.ToolStripMenuItem
        Me.menuforward = New System.Windows.Forms.ToolStripMenuItem
        Me.menuhelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuhelp = New System.Windows.Forms.ToolStripMenuItem
        Me.Statusstripbrowser = New System.Windows.Forms.StatusStrip
        Me.stslblReady = New System.Windows.Forms.ToolStripStatusLabel
        Me.stsprgPageLoadProgress = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PnlSearch.SuspendLayout()
        Me.Mnubrowser.SuspendLayout()
        Me.Statusstripbrowser.SuspendLayout()
        Me.SuspendLayout()
        '
        'WbBrowser
        '
        Me.WbBrowser.Location = New System.Drawing.Point(12, 173)
        Me.WbBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbBrowser.Name = "WbBrowser"
        Me.WbBrowser.Size = New System.Drawing.Size(673, 414)
        Me.WbBrowser.TabIndex = 0
        Me.WbBrowser.Url = New System.Uri("http://www.facebook.com", System.UriKind.Absolute)
        '
        'tbwebsite
        '
        Me.tbwebsite.Location = New System.Drawing.Point(25, 81)
        Me.tbwebsite.Name = "tbwebsite"
        Me.tbwebsite.Size = New System.Drawing.Size(175, 20)
        Me.tbwebsite.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tbwebsite, "Enter Web Address here")
        '
        'Btngo
        '
        Me.Btngo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btngo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Btngo.Location = New System.Drawing.Point(650, 72)
        Me.Btngo.Name = "Btngo"
        Me.Btngo.Size = New System.Drawing.Size(90, 21)
        Me.Btngo.TabIndex = 2
        Me.Btngo.Text = ">>>GO>>>"
        Me.Btngo.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(534, 73)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(87, 20)
        Me.BtnBack.TabIndex = 4
        Me.BtnBack.Text = "<<<back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnForward
        '
        Me.BtnForward.Location = New System.Drawing.Point(757, 72)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.Size = New System.Drawing.Size(87, 19)
        Me.BtnForward.TabIndex = 5
        Me.BtnForward.Text = "forward>>>"
        Me.BtnForward.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Location = New System.Drawing.Point(411, 73)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(86, 23)
        Me.BtnHome.TabIndex = 6
        Me.BtnHome.Text = "Home"
        Me.ToolTip1.SetToolTip(Me.BtnHome, "Click Here to go to the home page")
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlSearch.Controls.Add(Me.BtnAskJeeves)
        Me.PnlSearch.Controls.Add(Me.Btnmsn)
        Me.PnlSearch.Controls.Add(Me.btngoogle)
        Me.PnlSearch.Controls.Add(Me.lblsearch)
        Me.PnlSearch.Controls.Add(Me.tbwebsite)
        Me.PnlSearch.Location = New System.Drawing.Point(712, 186)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(225, 401)
        Me.PnlSearch.TabIndex = 7
        '
        'BtnAskJeeves
        '
        Me.BtnAskJeeves.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAskJeeves.Location = New System.Drawing.Point(45, 275)
        Me.BtnAskJeeves.Name = "BtnAskJeeves"
        Me.BtnAskJeeves.Size = New System.Drawing.Size(118, 29)
        Me.BtnAskJeeves.TabIndex = 11
        Me.BtnAskJeeves.Text = "Ask Jeeves"
        Me.BtnAskJeeves.UseVisualStyleBackColor = False
        '
        'Btnmsn
        '
        Me.Btnmsn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Btnmsn.Location = New System.Drawing.Point(45, 210)
        Me.Btnmsn.Name = "Btnmsn"
        Me.Btnmsn.Size = New System.Drawing.Size(118, 30)
        Me.Btnmsn.TabIndex = 10
        Me.Btnmsn.Text = "MSN"
        Me.Btnmsn.UseVisualStyleBackColor = False
        '
        'btngoogle
        '
        Me.btngoogle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btngoogle.Location = New System.Drawing.Point(45, 140)
        Me.btngoogle.Name = "btngoogle"
        Me.btngoogle.Size = New System.Drawing.Size(118, 31)
        Me.btngoogle.TabIndex = 9
        Me.btngoogle.Text = "Google"
        Me.btngoogle.UseVisualStyleBackColor = False
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.BackColor = System.Drawing.Color.Aqua
        Me.lblsearch.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(42, 27)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(139, 18)
        Me.lblsearch.TabIndex = 8
        Me.lblsearch.Text = "type in box below "
        '
        'cbwebsite
        '
        Me.cbwebsite.FormattingEnabled = True
        Me.cbwebsite.Location = New System.Drawing.Point(71, 70)
        Me.cbwebsite.Name = "cbwebsite"
        Me.cbwebsite.Size = New System.Drawing.Size(265, 21)
        Me.cbwebsite.TabIndex = 8
        '
        'Mnubrowser
        '
        Me.Mnubrowser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusearch, Me.mnunavigate, Me.menuhelp})
        Me.Mnubrowser.Location = New System.Drawing.Point(0, 0)
        Me.Mnubrowser.Name = "Mnubrowser"
        Me.Mnubrowser.Size = New System.Drawing.Size(949, 24)
        Me.Mnubrowser.TabIndex = 9
        Me.Mnubrowser.Text = "Mnustrip"
        '
        'mnusearch
        '
        Me.mnusearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnugoogle, Me.mnumsn, Me.mnuaskjeeves})
        Me.mnusearch.Name = "mnusearch"
        Me.mnusearch.Size = New System.Drawing.Size(54, 20)
        Me.mnusearch.Text = "Search"
        '
        'mnugoogle
        '
        Me.mnugoogle.Name = "mnugoogle"
        Me.mnugoogle.Size = New System.Drawing.Size(126, 22)
        Me.mnugoogle.Text = "Google"
        '
        'mnumsn
        '
        Me.mnumsn.Name = "mnumsn"
        Me.mnumsn.Size = New System.Drawing.Size(126, 22)
        Me.mnumsn.Text = "MSN"
        '
        'mnuaskjeeves
        '
        Me.mnuaskjeeves.Name = "mnuaskjeeves"
        Me.mnuaskjeeves.Size = New System.Drawing.Size(126, 22)
        Me.mnuaskjeeves.Text = "ask jeeves"
        '
        'mnunavigate
        '
        Me.mnunavigate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnugo, Me.menuback, Me.menuhome, Me.menuforward})
        Me.mnunavigate.Name = "mnunavigate"
        Me.mnunavigate.Size = New System.Drawing.Size(66, 20)
        Me.mnunavigate.Text = "Navigate"
        '
        'mnugo
        '
        Me.mnugo.Name = "mnugo"
        Me.mnugo.Size = New System.Drawing.Size(115, 22)
        Me.mnugo.Text = "Go"
        '
        'menuback
        '
        Me.menuback.Name = "menuback"
        Me.menuback.Size = New System.Drawing.Size(115, 22)
        Me.menuback.Text = "back"
        '
        'menuhome
        '
        Me.menuhome.Name = "menuhome"
        Me.menuhome.Size = New System.Drawing.Size(115, 22)
        Me.menuhome.Text = "home"
        '
        'menuforward
        '
        Me.menuforward.Name = "menuforward"
        Me.menuforward.Size = New System.Drawing.Size(115, 22)
        Me.menuforward.Text = "forward"
        '
        'menuhelp
        '
        Me.menuhelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuhelp})
        Me.menuhelp.Name = "menuhelp"
        Me.menuhelp.Size = New System.Drawing.Size(42, 20)
        Me.menuhelp.Text = "help"
        '
        'mnuhelp
        '
        Me.mnuhelp.Name = "mnuhelp"
        Me.mnuhelp.Size = New System.Drawing.Size(99, 22)
        Me.mnuhelp.Text = "Help"
        '
        'Statusstripbrowser
        '
        Me.Statusstripbrowser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stslblReady, Me.stsprgPageLoadProgress})
        Me.Statusstripbrowser.Location = New System.Drawing.Point(0, 588)
        Me.Statusstripbrowser.Name = "Statusstripbrowser"
        Me.Statusstripbrowser.Size = New System.Drawing.Size(949, 22)
        Me.Statusstripbrowser.TabIndex = 10
        Me.Statusstripbrowser.Text = "StatusStrip"
        '
        'stslblReady
        '
        Me.stslblReady.Name = "stslblReady"
        Me.stslblReady.Size = New System.Drawing.Size(38, 17)
        Me.stslblReady.Text = "StsLbl"
        '
        'stsprgPageLoadProgress
        '
        Me.stsprgPageLoadProgress.ForeColor = System.Drawing.Color.LimeGreen
        Me.stsprgPageLoadProgress.Name = "stsprgPageLoadProgress"
        Me.stsprgPageLoadProgress.Size = New System.Drawing.Size(100, 16)
        '
        'Frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 610)
        Me.Controls.Add(Me.Statusstripbrowser)
        Me.Controls.Add(Me.cbwebsite)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnForward)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Btngo)
        Me.Controls.Add(Me.WbBrowser)
        Me.Controls.Add(Me.Mnubrowser)
        Me.MainMenuStrip = Me.Mnubrowser
        Me.Name = "Frm1"
        Me.Text = "My first web brwser"
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlSearch.PerformLayout()
        Me.Mnubrowser.ResumeLayout(False)
        Me.Mnubrowser.PerformLayout()
        Me.Statusstripbrowser.ResumeLayout(False)
        Me.Statusstripbrowser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WbBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents tbwebsite As System.Windows.Forms.TextBox
    Friend WithEvents Btngo As System.Windows.Forms.Button
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Friend WithEvents BtnForward As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents Btnmsn As System.Windows.Forms.Button
    Friend WithEvents btngoogle As System.Windows.Forms.Button
    Friend WithEvents BtnAskJeeves As System.Windows.Forms.Button
    Friend WithEvents cbwebsite As System.Windows.Forms.ComboBox
    Friend WithEvents Mnubrowser As System.Windows.Forms.MenuStrip
    Friend WithEvents mnusearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnugoogle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnumsn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuaskjeeves As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnunavigate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnugo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuback As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuhome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuforward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuhelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuhelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Statusstripbrowser As System.Windows.Forms.StatusStrip
    Friend WithEvents stsprgPageLoadProgress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents stslblReady As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
