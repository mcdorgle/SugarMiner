Imports System.Data.SQLite

Public Class SgrMnr
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles sugrlbl.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim oForm As Aboutfrm
        oForm = New Aboutfrm()
        oForm.Show()
        oForm = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SgrMnr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles crntratiobox.TextChanged
        'displays ratio from setup page entered by user 
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles insulinlbl.Click

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        Dim oForm As SettingsFrm
        oForm = New SettingsFrm()
        oForm.Show()
        oForm = Nothing
    End Sub

    '==========================================================DATABASE TEST=========================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connMakeDB As SQLiteConnection = New SQLiteConnection("SugarDB.sqlite")
        Dim conn = New SQLiteConnection("Data Source=SugarDB.sqlite;Version=3")
        conn.Open()

        Dim sql As String = "CREATE TABLE IF NOT EXISTS Sugars (sugar INT, carbs INT, insulin INT)"
        Dim cmd1 As SQLiteCommand = New SQLiteCommand(sql, conn)

        Try
            cmd1.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        '====================================================values need to be entered from input boxes from date, time, sugar, carbs, insulin
        '====================================================ratio value is entered on settings form and the display box should only show the most recent ratio that was entered into settings
        sql = "INSERT INTO Sugars (sugar, carbs, insulin) values (127, 43, 22)"
        Dim cmd2 As SQLiteCommand = New SQLiteCommand(sql, conn)
        cmd2.ExecuteNonQuery()

        '====================================================in product needs to have all results displayed in a nice table/grid ordered by date/time not sure how to do that yet

        sql = "SELECT * FROM Sugars order by sugar desc"
        Dim cmd3 As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim reader As SQLiteDataReader = cmd3.ExecuteReader()
        lstInput1.Items.Clear()
        While (reader.Read())

            lstInput1.Items.Add("Sugar:  " & reader("sugar") & "   Carbs:  " & reader("carbs") & "   Insulin:  " & reader("insulin"))
        End While
        conn.Close()
    End Sub
End Class
