'Sugar Miner developed by Deshi McDorgle for diabetics to more closely monitor blood sugar levels when using an insulin
'to carb ratio rather than sliding scale
'program is not yet functional
'I sit on freenode irc #web-social and ##thelair
'also working on bluetooth capabilities for MedTronic insulin pump systems
Imports System.Data.SQLite




Public Class SgrMnr
    Private conn As SQLiteConnection

    Protected Overrides Sub Finalize()
        conn.Close()
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
        conn = New SQLiteConnection("Data Source=SugarDB.sqlite;Version=3")
        conn.Open()

        createDatabase()
        getRatio()

        Dim sql = "SELECT * FROM Sugars order by datetime desc"
        Dim dbCommand = New SQLiteCommand(sql, conn)

        Dim reader As SQLiteDataReader = dbCommand.ExecuteReader()
        list1.Items.Clear()
        While (reader.Read())
            list1.Items.Add("Date:  " & reader("datetime") & "   Sugar:  " & reader("sugar") & "   Carbs:  " & reader("carbs") & "   Insulin:  " & reader("insulin"))
        End While
    End Sub

    Private Sub createDatabase()
        createSugarsTable()
        createSettingsTable()
    End Sub

    Private Sub createSugarsTable()
        Dim sql As String = "CREATE TABLE IF NOT EXISTS Sugars (sugar INT, carbs INT, insulin INT, datetime STRING)"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        dbCommand.ExecuteNonQuery()
    End Sub

    ' Create the settings table if it doesn't exist and initialize
    Private Sub createSettingsTable()
        Dim sql As String = "CREATE TABLE IF NOT EXISTS Settings (name TEXT, value TEXT)"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim tableCreated = dbCommand.ExecuteNonQuery() = 0
        If tableCreated Then
            sql = "INSERT INTO Settings (name, value) values ('ratio', '1')"
            dbCommand.CommandText = sql
            dbCommand.ExecuteNonQuery()
        End If
    End Sub

    'get the ratio value from database
    Private Sub getRatio()
        Dim sql As String = "SELECT value from Settings WHERE name='ratio'"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim ratio = dbCommand.ExecuteScalar()
        crntratiobox.Text = ratio & ":1"
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles crntratiobox.TextChanged

        'displays ratio from settings page entered by user  not sure what type of object this should be it should not be an editable field on main form only in the settings form
    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        Dim oForm As SettingsFrm
        oForm = New SettingsFrm(conn)
        oForm.ShowDialog()
        oForm = Nothing
        getRatio()
    End Sub

    Private Sub refrshbtn_Click(sender As Object, e As EventArgs) Handles refrshbtn.Click
        'refresh button should refresh the display of data in the grid to show all results
        refreshResults()
    End Sub

    Private Sub refreshResults()
        Dim sql = "SELECT * FROM Sugars order by datetime desc"
        Dim dbCommand = New SQLiteCommand(sql, conn)

        Dim reader As SQLiteDataReader = dbCommand.ExecuteReader()
        list1.Items.Clear()
        While (reader.Read())
            list1.Items.Add("Date:  " & reader("datetime") & "   Sugar:  " & reader("sugar") & "   Carbs:  " & reader("carbs") & "   Insulin:  " & reader("insulin"))
        End While
    End Sub

    Private Sub addsgrbtn_Click(sender As Object, e As EventArgs) Handles addsgrbtn.Click
        'add button will insert all entered values into database

        'values need to be entered from input boxes from date, time, sugar, carbs, insulin
        'ratio value is entered on settings form and the display box should only show the most recent ratio that was entered into settings
        Dim sugars As Integer = Integer.Parse(sgrbox.Text)
        Dim carbs As Integer = Integer.Parse(carbox.Text)
        Dim insulin As Integer = Integer.Parse(insulinbox.Text)
        Dim datetime As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff")

        Dim sql = "INSERT INTO Sugars (sugar, carbs, insulin, datetime) values ({0}, {1}, {2}, '{3}')"
        Dim dbCommand = New SQLiteCommand(String.Format(sql, sugars, carbs, insulin, datetime), conn)
        dbCommand.ExecuteNonQuery()
        refreshResults()
        'end product needs to have all results displayed in a nice table/grid ordered by date/time not sure how to do that yet
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        'calendar should eventually jump to a specific entry in the database and display all results for that date into the grid but ignore the time
    End Sub

    Private Sub lstInput1_SelectedIndexChanged(sender As Object, e As EventArgs)
        'this will be removed after database functionality is fully working
    End Sub
End Class
