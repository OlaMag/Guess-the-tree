Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class Dictionary
    'declaring strings needed to establish OLE DB connection
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim userDir As String
    Dim dbSource As String
    Dim sql As String
    'on default there is a suggestion how to input the directory name, once the field is clicked it becomes empty and ready for user's input
    Private Sub txtUserDir_Click(sender As Object, e As EventArgs) Handles txtUserDir.Click
        Me.txtUserDir.Text = ""
        txtUserDir.ForeColor = Color.Black
    End Sub
    'when clicked outside of the input box, remind the user what format the directory and database name have to be in
    Private Sub Dictionary_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If txtUserDir.Text = "" Then
            Me.txtUserDir.Text = "Eg.: F:\Programming\FinalProject\TreeDB.mdb"
            txtUserDir.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub btnDirectory_Click(sender As Object, e As EventArgs) Handles btnDirectory.Click

        Try
            userDir = txtUserDir.Text
            dbSource = "Data Source =" & userDir
            'establish connection with the database
            con.ConnectionString = dbProvider & dbSource
            con.Open()
            MsgBox("Connection established!")
            btnDirectory.Visible = False
            btnBrowse.Visible = False
        Catch dirNotFound As OleDb.OleDbException 'throw an error if the directory entered by the user isn't found
            MsgBox("Directory not found")
        End Try

    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'finding the directory by the user:
        With OpenFileDialog2
            .InitialDirectory = System.IO.Directory.GetCurrentDirectory
            ' Check to ensure that the selected file exists.
            .CheckFileExists = True
            ' Check to ensure that the selected path exists.
            .CheckPathExists = True
            ' "txt" is a default extension of a file. NOTE: the "." is not included.
            .DefaultExt = "mdb"
            ' Only databases can be displayed
            .Filter = "database (*.mdb)|*.mdb"
            ' Only one file can be selected.
            .Multiselect = False
            .Title = "Select a database to open"
            'once directory is found
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    userDir = .FileName
                    dbSource = "Data Source =" & userDir
                    'establish connection with the database
                    con.ConnectionString = dbProvider & dbSource
                    con.Open()
                    MsgBox("Connection established!")
                    btnBrowse.Visible = False
                    btnDirectory.Visible = False
                Catch dirNotFound As OleDb.OleDbException 'throw an error if the directory entered by the user isn't found
                    MsgBox("Directory not found")
                End Try

            End If
        End With
    End Sub
    Private Sub btnShowTrans_Click(sender As Object, e As EventArgs) Handles btnShowTrans.Click
        'finding the right record depending on what language the input is in
        Try
            Dim ds As New DataSet
            Dim da As OleDb.OleDbDataAdapter

            If btnLatin.Checked = True Then
                sql = "SELECT Latin, English, Polish FROM TreesCheatSheet WHERE Latin LIKE '%" & txtSpeciesName.Text & "%'"
            ElseIf btnEnglish.Checked = True Then
                sql = "SELECT Latin, English, Polish FROM TreesCheatSheet WHERE English LIKE '%" & txtSpeciesName.Text & "%'"
            ElseIf btnPolish.Checked = True Then
                sql = "SELECT Latin, English, Polish FROM TreesCheatSheet WHERE Polish LIKE '%" & txtSpeciesName.Text & "%'"
            Else
                MsgBox("Specify the language of your input")
            End If

            'declare variable values
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Translations")

            'assign the data from the data set to a data grid view element, use the name assigned to table in the adapter not the database table name! 
            DataGridView1.DataSource = ds.Tables("Translations")
        Catch
            MsgBox("Sorry! Something went wrong...There's no such record in this database or you set the wrong input language. Check your input again.")
        End Try
    End Sub
    'close the OLE DB connection when done and reset controls for establishing new connection
    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        con.Close()
        Me.txtUserDir.Text = "Eg.: F:\Programming\FinalProject\TreeDB.mdb"
        txtUserDir.ForeColor = Color.Gray
        btnDirectory.Visible = True
        btnBrowse.Visible = True
        MsgBox("The database is now disconnected!")
    End Sub
    'exit button
    Private Sub btnExitDict_Click(sender As Object, e As EventArgs) Handles btnExitDict.Click
        Me.Close()
    End Sub

End Class