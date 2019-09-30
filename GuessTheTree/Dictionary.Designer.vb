<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dictionary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dictionary))
        Me.bxRadioBtn = New System.Windows.Forms.GroupBox()
        Me.btnPolish = New System.Windows.Forms.RadioButton()
        Me.btnEnglish = New System.Windows.Forms.RadioButton()
        Me.btnLatin = New System.Windows.Forms.RadioButton()
        Me.txtSpeciesName = New System.Windows.Forms.TextBox()
        Me.lblDictionary = New System.Windows.Forms.Label()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.txtUserDir = New System.Windows.Forms.TextBox()
        Me.btnDirectory = New System.Windows.Forms.Button()
        Me.btnShowTrans = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExitDict = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.bxRadioBtn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bxRadioBtn
        '
        Me.bxRadioBtn.Controls.Add(Me.btnPolish)
        Me.bxRadioBtn.Controls.Add(Me.btnEnglish)
        Me.bxRadioBtn.Controls.Add(Me.btnLatin)
        Me.bxRadioBtn.Location = New System.Drawing.Point(71, 214)
        Me.bxRadioBtn.Name = "bxRadioBtn"
        Me.bxRadioBtn.Size = New System.Drawing.Size(342, 94)
        Me.bxRadioBtn.TabIndex = 0
        Me.bxRadioBtn.TabStop = False
        Me.bxRadioBtn.Text = "What language is it in?"
        '
        'btnPolish
        '
        Me.btnPolish.AutoSize = True
        Me.btnPolish.Location = New System.Drawing.Point(246, 44)
        Me.btnPolish.Name = "btnPolish"
        Me.btnPolish.Size = New System.Drawing.Size(53, 17)
        Me.btnPolish.TabIndex = 4
        Me.btnPolish.TabStop = True
        Me.btnPolish.Text = "Polish"
        Me.btnPolish.UseVisualStyleBackColor = True
        '
        'btnEnglish
        '
        Me.btnEnglish.AutoSize = True
        Me.btnEnglish.Location = New System.Drawing.Point(130, 44)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(59, 17)
        Me.btnEnglish.TabIndex = 3
        Me.btnEnglish.TabStop = True
        Me.btnEnglish.Text = "English"
        Me.btnEnglish.UseVisualStyleBackColor = True
        '
        'btnLatin
        '
        Me.btnLatin.AutoSize = True
        Me.btnLatin.Location = New System.Drawing.Point(13, 44)
        Me.btnLatin.Name = "btnLatin"
        Me.btnLatin.Size = New System.Drawing.Size(48, 17)
        Me.btnLatin.TabIndex = 2
        Me.btnLatin.TabStop = True
        Me.btnLatin.Text = "Latin"
        Me.btnLatin.UseVisualStyleBackColor = True
        '
        'txtSpeciesName
        '
        Me.txtSpeciesName.Location = New System.Drawing.Point(71, 177)
        Me.txtSpeciesName.Name = "txtSpeciesName"
        Me.txtSpeciesName.Size = New System.Drawing.Size(342, 20)
        Me.txtSpeciesName.TabIndex = 0
        '
        'lblDictionary
        '
        Me.lblDictionary.AutoSize = True
        Me.lblDictionary.Location = New System.Drawing.Point(68, 144)
        Me.lblDictionary.Name = "lblDictionary"
        Me.lblDictionary.Size = New System.Drawing.Size(175, 13)
        Me.lblDictionary.TabIndex = 1
        Me.lblDictionary.Text = "Enter the name of the species here:"
        '
        'lblDirectory
        '
        Me.lblDirectory.AutoSize = True
        Me.lblDirectory.Location = New System.Drawing.Point(68, 34)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(308, 13)
        Me.lblDirectory.TabIndex = 3
        Me.lblDirectory.Text = "Enter the directory and name of the database as in the example:"
        '
        'txtUserDir
        '
        Me.txtUserDir.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUserDir.Location = New System.Drawing.Point(71, 62)
        Me.txtUserDir.Name = "txtUserDir"
        Me.txtUserDir.Size = New System.Drawing.Size(342, 20)
        Me.txtUserDir.TabIndex = 4
        Me.txtUserDir.Text = "Eg.: F:\Programming\FinalProject\TreeDB.mdb"
        '
        'btnDirectory
        '
        Me.btnDirectory.Location = New System.Drawing.Point(71, 100)
        Me.btnDirectory.Name = "btnDirectory"
        Me.btnDirectory.Size = New System.Drawing.Size(128, 23)
        Me.btnDirectory.TabIndex = 5
        Me.btnDirectory.Text = "Use this directory"
        Me.btnDirectory.UseVisualStyleBackColor = True
        '
        'btnShowTrans
        '
        Me.btnShowTrans.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnShowTrans.Location = New System.Drawing.Point(178, 324)
        Me.btnShowTrans.Name = "btnShowTrans"
        Me.btnShowTrans.Size = New System.Drawing.Size(128, 23)
        Me.btnShowTrans.TabIndex = 7
        Me.btnShowTrans.Text = "Show translation"
        Me.btnShowTrans.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(274, 553)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(136, 23)
        Me.btnDisconnect.TabIndex = 14
        Me.btnDisconnect.Text = "Disconnect database"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(41, 384)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(396, 144)
        Me.DataGridView1.TabIndex = 15
        Me.DataGridView1.UseWaitCursor = True
        '
        'btnExitDict
        '
        Me.btnExitDict.Location = New System.Drawing.Point(71, 553)
        Me.btnExitDict.Name = "btnExitDict"
        Me.btnExitDict.Size = New System.Drawing.Size(136, 23)
        Me.btnExitDict.TabIndex = 16
        Me.btnExitDict.Text = "Exit"
        Me.btnExitDict.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(285, 100)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(128, 23)
        Me.btnBrowse.TabIndex = 17
        Me.btnBrowse.Text = "Browse "
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Dictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 623)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnExitDict)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnShowTrans)
        Me.Controls.Add(Me.btnDirectory)
        Me.Controls.Add(Me.txtUserDir)
        Me.Controls.Add(Me.lblDirectory)
        Me.Controls.Add(Me.lblDictionary)
        Me.Controls.Add(Me.txtSpeciesName)
        Me.Controls.Add(Me.bxRadioBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(495, 661)
        Me.MinimumSize = New System.Drawing.Size(495, 661)
        Me.Name = "Dictionary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dictionary"
        Me.bxRadioBtn.ResumeLayout(False)
        Me.bxRadioBtn.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bxRadioBtn As System.Windows.Forms.GroupBox
    Friend WithEvents btnPolish As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents btnLatin As System.Windows.Forms.RadioButton
    Friend WithEvents txtSpeciesName As System.Windows.Forms.TextBox
    Friend WithEvents lblDictionary As System.Windows.Forms.Label
    Friend WithEvents lblDirectory As System.Windows.Forms.Label
    Friend WithEvents txtUserDir As System.Windows.Forms.TextBox
    Friend WithEvents btnDirectory As System.Windows.Forms.Button
    Friend WithEvents btnShowTrans As System.Windows.Forms.Button
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnExitDict As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
End Class
