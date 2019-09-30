<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.aboutPicture = New System.Windows.Forms.PictureBox()
        Me.lblAbout1 = New System.Windows.Forms.Label()
        CType(Me.aboutPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aboutPicture
        '
        Me.aboutPicture.InitialImage = Global.GuessTheTree.My.Resources.Resources.Populus_alba
        Me.aboutPicture.Location = New System.Drawing.Point(190, 47)
        Me.aboutPicture.Name = "aboutPicture"
        Me.aboutPicture.Size = New System.Drawing.Size(269, 145)
        Me.aboutPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.aboutPicture.TabIndex = 2
        Me.aboutPicture.TabStop = False
        '
        'lblAbout1
        '
        Me.lblAbout1.AutoSize = True
        Me.lblAbout1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAbout1.Location = New System.Drawing.Point(18, 232)
        Me.lblAbout1.Name = "lblAbout1"
        Me.lblAbout1.Size = New System.Drawing.Size(621, 128)
        Me.lblAbout1.TabIndex = 3
        Me.lblAbout1.Text = resources.GetString("lblAbout1.Text")
        Me.lblAbout1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(657, 406)
        Me.Controls.Add(Me.lblAbout1)
        Me.Controls.Add(Me.aboutPicture)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(673, 444)
        Me.MinimumSize = New System.Drawing.Size(673, 444)
        Me.Name = "AboutForm"
        Me.Text = "About the project"
        CType(Me.aboutPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aboutPicture As System.Windows.Forms.PictureBox
    Friend WithEvents lblAbout1 As System.Windows.Forms.Label
End Class
