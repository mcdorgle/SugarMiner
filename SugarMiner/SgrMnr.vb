'Sugar Miner developed by Deshi McDorgle for diabetics to more closely monitor blood sugar levels when using an insulin to carb ratio rather than sliding scale
'program is not yet functional
'I sit on freenode irc #web-social and #thelair
'also working on bluetooth capabilities for MedTronic insulin pump systems
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
        'displays ratio from settings page entered by user  not sure what type of object this should be it should not be an editable field on main form only in the settings form
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
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim connMakeDB As SQLiteConnection = New SQLiteConnection("SugarDB.sqlite")
        Dim conn = New SQLiteConnection("Data Source=SugarDB.sqlite;Version=3")
        conn.Open()

        Dim sql As String = "CREATE TABLE IF NOT EXISTS Sugars (sugar INT, carbs INT, insulin INT, datetime STRING)"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)

        Try
            dbCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        '====================================================values need to be entered from input boxes from date, time, sugar, carbs, insulin
        '====================================================ratio value is entered on settings form and the display box should only show the most recent ratio that was entered into settings
        Dim sugars As Integer = Integer.Parse(sgrbox.Text)
        Dim carbs As Integer = Integer.Parse(carbox.Text)
        Dim insulin As Integer = Integer.Parse(insulinbox.Text)
        Dim datetime As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")

        sql = "INSERT INTO Sugars (sugar, carbs, insulin, datetime) values ({0}, {1}, {2}, '{3}')"
        dbCommand.CommandText = String.Format(sql, sugars, carbs, insulin, datetime)
        dbCommand.ExecuteNonQuery()

        '====================================================in product needs to have all results displayed in a nice table/grid ordered by date/time not sure how to do that yet

        sql = "SELECT * FROM Sugars order by sugar desc"
        dbCommand.CommandText = sql

        Dim reader As SQLiteDataReader = dbCommand.ExecuteReader()
        list1.Items.Clear()
        While (reader.Read())
            list1.Items.Add("Sugar:  " & reader("sugar") & "   Carbs:  " & reader("carbs") & "   Insulin:  " & reader("insulin") & "   Date:  " & reader("datetime"))
        End While
        conn.Close()
    End Sub

    Private Sub refrshbtn_Click(sender As Object, e As EventArgs) Handles refrshbtn.Click
        'refresh button should refresh the display of data in the grid to show all results

    End Sub

    Private Sub addsgrbtn_Click(sender As Object, e As EventArgs) Handles addsgrbtn.Click
        'add button will insert all entered values into database
        Dim connMakeDB As SQLiteConnection = New SQLiteConnection("SugarDB.sqlite")
        Dim conn = New SQLiteConnection("Data Source=SugarDB.sqlite;Version=3")
        conn.Open()

        Dim sql As String = "CREATE TABLE IF NOT EXISTS Sugars (sugar INT, carbs INT, insulin INT, datetime STRING, ratio INT)"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)

        Try
            dbCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        '====================================================values need to be entered from input boxes from date, time, sugar, carbs, insulin
        '====================================================ratio value is entered on settings form and the display box should only show the most recent ratio that was entered into settings
        Dim sugars As Integer = Integer.Parse(sgrbox.Text)
        Dim carbs As Integer = Integer.Parse(carbox.Text)
        Dim insulin As Integer = Integer.Parse(insulinbox.Text)
        Dim datetime As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")

        sql = "INSERT INTO Sugars (sugar, carbs, insulin, datetime) values ({0}, {1}, {2}, '{3}')"
        dbCommand.CommandText = String.Format(sql, sugars, carbs, insulin, datetime)
        dbCommand.ExecuteNonQuery()

        '====================================================in product needs to have all results displayed in a nice table/grid ordered by date/time not sure how to do that yet

        sql = "SELECT * FROM Sugars order by datetime desc"
        dbCommand.CommandText = sql

        Dim reader As SQLiteDataReader = dbCommand.ExecuteReader()
        list1.Items.Clear()
        While (reader.Read())
            list1.Items.Add("Date:  " & reader("datetime") & "   Sugar:  " & reader("sugar") & "   Carbs:  " & reader("carbs") & "   Insulin:  " & reader("insulin"))
        End While
        conn.Close()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        'calendar should eventually jump to a specific entry in the database and display all results for that date into the grid but ignore the time
    End Sub

    Private Sub lstInput1_SelectedIndexChanged(sender As Object, e As EventArgs)
        'this will be removed after database functionality is fully working
    End Sub

    Private Sub sgrbox_TextChanged(sender As Object, e As EventArgs) Handles sgrbox.TextChanged

    End Sub
End Class
