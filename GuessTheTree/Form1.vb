Imports System
Imports System.IO
Public Class Form1
    Private myFileName As String
    'on load open the image picture
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomePic.Image = GuessTheTree.My.Resources.Pinus_sylvestris
    End Sub
    'clicking this button opens the dictionary
    Private Sub btnDictionary_Click(sender As Object, e As EventArgs) Handles btnDictionary.Click
        Dictionary.Show()
    End Sub
    'clicking this button opens the quiz window
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        TreesForm.Show()
    End Sub
    'clicking this button displays credits for this programme
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutForm.Show()
    End Sub
    'this handles the menu strip item responsible for opening the text file with a list of species used in the quiz
    Private Sub openTxt_Click(sender As Object, e As EventArgs) Handles openTxt.Click
        welcomePic.Visible = False
        'txtViewer.Text = GuessTheTree.My.Resources.treesCheatSheet

        With OpenFileDialog1
            .InitialDirectory = System.IO.Directory.GetCurrentDirectory
            ' Check to ensure that the selected file exists.
            .CheckFileExists = True
            ' Check to ensure that the selected path exists.
            .CheckPathExists = True
            ' "txt" is a default extension of a file. NOTE: the "." is not included.
            .DefaultExt = "txt"
            ' Only text files can be displayed
            .Filter = "Text files (*.txt)|*.txt"
            ' Only one file can be selected.
            .Multiselect = False
            .Title = "Select a file to open"

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtViewer.Text = My.Computer.FileSystem.ReadAllText(.FileName)
            End If
        End With
    End Sub

    'this allows the user to save the text file to the user's preferred directory
    Private Sub SaveTreeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveTreeListToolStripMenuItem.Click

        With SaveFileDialog1
            ' Add the default extension, if the user neglects to add an extension.
            .AddExtension = True
            ' Check to ensure that the selected path exists.
            .CheckPathExists = True
            ' Prompt before creating a new file.
            .CreatePrompt = False
            ' Prompt before overwriting.
            .OverwritePrompt = True
            ' Show the Help button.
            .ShowHelp = True
            .DefaultExt = "txt"
            myFileName = "treesCheatSheet1"
            .FileName = myFileName
            .Filter = "Text files (*.txt)|*.txt"

            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(.FileName, GuessTheTree.My.Resources.treesCheatSheet, False)
            End If

        End With
    End Sub

    Private Sub btnExitWelcome_Click(sender As Object, e As EventArgs) Handles btnExitWelcome.Click
        Me.Close()
    End Sub
End Class

