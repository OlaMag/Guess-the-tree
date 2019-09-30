<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreesForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreesForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSolution = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLatin = New System.Windows.Forms.Label()
        Me.txtGuessedName = New System.Windows.Forms.TextBox()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeWarning = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSolution)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lblLatin)
        Me.GroupBox1.Controls.Add(Me.txtGuessedName)
        Me.GroupBox1.Controls.Add(Me.btnSkip)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnCheck)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 483)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 33)
        Me.Label2.TabIndex = 4
        '
        'btnSolution
        '
        Me.btnSolution.Location = New System.Drawing.Point(178, 434)
        Me.btnSolution.Name = "btnSolution"
        Me.btnSolution.Size = New System.Drawing.Size(117, 23)
        Me.btnSolution.TabIndex = 3
        Me.btnSolution.Text = "Tell me the name"
        Me.btnSolution.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(94, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(421, 260)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblLatin
        '
        Me.lblLatin.AutoSize = True
        Me.lblLatin.Location = New System.Drawing.Point(155, 334)
        Me.lblLatin.Name = "lblLatin"
        Me.lblLatin.Size = New System.Drawing.Size(327, 13)
        Me.lblLatin.TabIndex = 2
        Me.lblLatin.Text = "Enter the Latin name of the tree here. Watch out, it's case sensitive!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtGuessedName
        '
        Me.txtGuessedName.Location = New System.Drawing.Point(153, 368)
        Me.txtGuessedName.Name = "txtGuessedName"
        Me.txtGuessedName.Size = New System.Drawing.Size(329, 20)
        Me.txtGuessedName.TabIndex = 1
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(313, 434)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(117, 23)
        Me.btnSkip.TabIndex = 1
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(448, 434)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(43, 434)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(117, 23)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Check answer"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Write the Latin name of the tree!"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTimeWarning
        '
        Me.lblTimeWarning.AutoSize = True
        Me.lblTimeWarning.Location = New System.Drawing.Point(288, 68)
        Me.lblTimeWarning.Name = "lblTimeWarning"
        Me.lblTimeWarning.Size = New System.Drawing.Size(126, 13)
        Me.lblTimeWarning.TabIndex = 2
        Me.lblTimeWarning.Text = "You have 180 seconds..."
        '
        'TreesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 627)
        Me.Controls.Add(Me.lblTimeWarning)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(713, 665)
        Me.MinimumSize = New System.Drawing.Size(713, 665)
        Me.Name = "TreesForm"
        Me.Text = "Guess the Tree"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLatin As System.Windows.Forms.Label
    Friend WithEvents txtGuessedName As System.Windows.Forms.TextBox
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSolution As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimeWarning As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
