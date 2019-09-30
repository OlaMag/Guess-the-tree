Imports System.IO

Public Class TreesForm
    'declare values for images for the slide show
    Dim images(17) As Image
    Dim pos As Integer = 0
    'set starting values for keeping the score
    Dim score As Integer = 0
    Dim totalPoints As Integer = 18

    'declare the starting time of the timer
    Dim timeLeft As Integer = 180

    'timer starts when the form loads
    Private Sub TreesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'set the first picture to be displayed
        PictureBox1.Image = GuessTheTree.My.Resources.Betula_pendula
        'set the pictures and their indices
        images(0) = GuessTheTree.My.Resources.Betula_pendula
        images(0).Tag = "Betula pendula"
        images(1) = GuessTheTree.My.Resources.Larix_decidua
        images(1).Tag = "Larix decidua"
        images(2) = GuessTheTree.My.Resources.Pinus_sylvestris
        images(2).Tag = "Pinus sylvestris"
        images(3) = GuessTheTree.My.Resources.Populus_alba
        images(3).Tag = "Populus alba"
        images(4) = GuessTheTree.My.Resources.Pseudotsuga_menziesii
        images(4).Tag = "Pseudotsuga menziesii"
        images(5) = GuessTheTree.My.Resources.Robinia_pseudoacacia1
        images(5).Tag = "Robinia pseudoacacia"
        images(6) = GuessTheTree.My.Resources.Salix_alba
        images(6).Tag = "Salix alba"
        images(7) = GuessTheTree.My.Resources.Acer_campestre
        images(7).Tag = "Acer campestre"
        images(8) = GuessTheTree.My.Resources.Acer_platanoides
        images(8).Tag = "Acer platanoides"
        images(9) = GuessTheTree.My.Resources.Aesculus_hippocastanum
        images(9).Tag = "Aesculus hippocastanum"
        images(10) = GuessTheTree.My.Resources.Alnus_glutinosa
        images(10).Tag = "Alnus glutinosa"
        images(11) = GuessTheTree.My.Resources.Carpinus_betulus
        images(11).Tag = "Carpinus betulus"
        images(12) = GuessTheTree.My.Resources.Fagus_sylvatica
        images(12).Tag = "Fagus sylvatica"
        images(13) = GuessTheTree.My.Resources.Fraxinus_excelsior
        images(13).Tag = "Fraxinus excelsior"
        images(14) = GuessTheTree.My.Resources.Picea_abies
        images(14).Tag = "Picea abies"
        images(15) = GuessTheTree.My.Resources.Taxus_baccata
        images(15).Tag = "Taxus baccata"
        images(16) = GuessTheTree.My.Resources.Tilia_cordata
        images(16).Tag = "Tilia cordata"
        images(17) = GuessTheTree.My.Resources.Quercus_robur
        images(17).Tag = "Quercus robur"


    End Sub
    'Timer functionality
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            lblTimeWarning.Text = "180 seconds"
            If timeLeft > 0 Then
                ' Display the new time left by updating the Time warning label.
                timeLeft -= 1
                lblTimeWarning.Text = "You have " & timeLeft & " seconds to complete the task."
            Else
                ' If the user ran out of time, stop the timer, show a MessageBox
                Timer1.Stop()
                lblTimeWarning.Text = "Time's up!"
                MessageBox.Show("You didn't finish in time. " & "Your score is " & score & " out of total " & totalPoints)
                If Windows.Forms.DialogResult.OK Then
                    Me.Close()
                End If
            End If
        Catch exp As Exception
            ' Catch any error that we're not explicitly trapping.
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    'handling the check button - checking if the answer is correct
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Try
            'procedure when the user enetered a correct name
            If txtGuessedName.Text = images(pos).Tag Then
                MessageBox.Show("Congratulations! Correct answer!")
                If Windows.Forms.DialogResult.OK Then
                    If pos < images.Length - 1 Then
                        txtGuessedName.Text = ""
                        Label2.Text = ""
                        pos = pos + 1
                        score = score + 1
                        PictureBox1.Image = images(pos)
                        'procedure if the user completed the task before time-out
                    ElseIf (pos = images.Length - 1) Then
                        MessageBox.Show("Congratulations, you've completed the task!" & "Your score is " & score & " out of " & totalPoints & " total points")
                        Me.Close()
                    End If
                End If
                'procedure in case of an incorrect answer
            Else
                MessageBox.Show("Incorrect answer. Try again.")
                txtGuessedName.Text = ""
            End If
        Catch exp As Exception
            'Catch any error that we're not explicitly trapping.
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Label2.Text = ""
        If pos < images.Length - 1 Then
            pos = pos + 1
            PictureBox1.Image = images(pos)
        Else
            MessageBox.Show("This is the end." & "Your score is " & score & " out of " & totalPoints & " total points")
            If Windows.Forms.DialogResult.OK Then
                Me.Close()
            End If
        End If

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    'this displays the name of the tree if the user doesn't know it. They can still score a point for just copying the name
    Private Sub btnSolution_Click(sender As Object, e As EventArgs) Handles btnSolution.Click
        Label2.Text = images(pos).Tag
    End Sub
End Class