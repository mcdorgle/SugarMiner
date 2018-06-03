Imports System.Data.SQLite



Public Class DataClass

    Private Sub createSugarsTable()
        Dim sql As String = "CREATE TABLE IF NOT EXISTS Sugars (sugar INT, carbs INT, insulin INT, datetime STRING)"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        dbCommand.ExecuteNonQuery()
    End Sub

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

    Private Sub createDatabase()
        createSugarsTable()
        createSettingsTable()
    End Sub
    Public Sub New()
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
    Private conn As SQLiteConnection

    Protected Overrides Sub Finalize()
        conn.Close()
    End Sub


    Public Function getRatio() As Integer

        Dim sql As String = "SELECT value from Settings WHERE name='ratio'"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim ratio = dbCommand.ExecuteScalar()
        Return ratio
    End Function
End Class
