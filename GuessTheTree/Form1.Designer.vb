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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.openTxt = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTreeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.txtViewer = New System.Windows.Forms.TextBox()
        Me.btnDictionary = New System.Windows.Forms.Button()
        Me.welcomePic = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnExitWelcome = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.welcomePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuMenu
        '
        Me.menuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.openTxt, Me.SaveTreeListToolStripMenuItem})
        Me.menuMenu.Name = "menuMenu"
        Me.menuMenu.Size = New System.Drawing.Size(37, 20)
        Me.menuMenu.Text = "File"
        '
        'openTxt
        '
        Me.openTxt.Name = "openTxt"
        Me.openTxt.Size = New System.Drawing.Size(139, 22)
        Me.openTxt.Text = "See tree list"
        '
        'SaveTreeListToolStripMenuItem
        '
        Me.SaveTreeListToolStripMenuItem.Name = "SaveTreeListToolStripMenuItem"
        Me.SaveTreeListToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveTreeListToolStripMenuItem.Text = "Save tree list"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.LightSalmon
        Me.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPlay.Location = New System.Drawing.Point(293, 505)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(100, 30)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "Play!"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAbout.Location = New System.Drawing.Point(43, 505)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(100, 30)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'txtViewer
        '
        Me.txtViewer.BackColor = System.Drawing.SystemColors.Menu
        Me.txtViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtViewer.Location = New System.Drawing.Point(56, 41)
        Me.txtViewer.Multiline = True
        Me.txtViewer.Name = "txtViewer"
        Me.txtViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtViewer.Size = New System.Drawing.Size(450, 438)
        Me.txtViewer.TabIndex = 5
        Me.txtViewer.Text = resources.GetString("txtViewer.Text")
        '
        'btnDictionary
        '
        Me.btnDictionary.BackColor = System.Drawing.Color.LightSalmon
        Me.btnDictionary.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDictionary.Location = New System.Drawing.Point(168, 505)
        Me.btnDictionary.Name = "btnDictionary"
        Me.btnDictionary.Size = New System.Drawing.Size(100, 30)
        Me.btnDictionary.TabIndex = 7
        Me.btnDictionary.Text = "Dictionary"
        Me.btnDictionary.UseVisualStyleBackColor = False
        '
        'welcomePic
        '
        Me.welcomePic.InitialImage = Nothing
        Me.welcomePic.Location = New System.Drawing.Point(157, 300)
        Me.welcomePic.Name = "welcomePic"
        Me.welcomePic.Size = New System.Drawing.Size(249, 126)
        Me.welcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.welcomePic.TabIndex = 6
        Me.welcomePic.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnExitWelcome
        '
        Me.btnExitWelcome.Location = New System.Drawing.Point(418, 505)
        Me.btnExitWelcome.Name = "btnExitWelcome"
        Me.btnExitWelcome.Size = New System.Drawing.Size(100, 30)
        Me.btnExitWelcome.TabIndex = 8
        Me.btnExitWelcome.Text = "Exit"
        Me.btnExitWelcome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 584)
        Me.Controls.Add(Me.btnExitWelcome)
        Me.Controls.Add(Me.btnDictionary)
        Me.Controls.Add(Me.welcomePic)
        Me.Controls.Add(Me.txtViewer)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(576, 622)
        Me.MinimumSize = New System.Drawing.Size(576, 622)
        Me.Name = "Form1"
        Me.Text = "Guess  the Tree"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.welcomePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents openTxt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtViewer As System.Windows.Forms.TextBox
    Friend WithEvents welcomePic As System.Windows.Forms.PictureBox
    Friend WithEvents btnDictionary As System.Windows.Forms.Button
    Friend WithEvents SaveTreeListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnExitWelcome As System.Windows.Forms.Button

End Class
