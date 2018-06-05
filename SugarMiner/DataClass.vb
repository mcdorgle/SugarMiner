Imports System.Data.SQLite

Public Class DataClass
    Private conn As SQLiteConnection

    Public Sub New()
        conn = New SQLiteConnection("Data Source=SugarDB.sqlite;Version=3")
        conn.Open()

        'Only creates the database and tables if they don't already exist
        createDatabase()
    End Sub

    Protected Overrides Sub Finalize()
        Try
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Function getRatio() As Integer
        Dim sql As String = "SELECT value from Settings WHERE name='ratio'"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim ratio = Integer.Parse(dbCommand.ExecuteScalar())
        Return ratio
    End Function

    Public Sub setRatio(ratio As Integer)
        Dim sql = "INSERT OR REPLACE INTO Settings (rowid, name, value) values ((SELECT rowid FROM Settings WHERE name='ratio'), 'ratio', {0})"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        dbCommand.CommandText = String.Format(sql, ratio)
        dbCommand.ExecuteNonQuery()
    End Sub

    Public Function getSugars() As List(Of Sugars)
        Dim sugars = New List(Of Sugars)

        Dim sql = "SELECT * FROM Sugars order by datetime desc"
        Dim dbCommand = New SQLiteCommand(sql, conn)

        Dim reader As SQLiteDataReader = dbCommand.ExecuteReader()
        While (reader.Read())
            Dim sugar = New Sugars()
            sugar.sugar = reader("sugar")
            sugar.carbs = reader("carbs")
            sugar.insulin = reader("insulin")
            sugar.datetime = Date.Parse(reader("datetime"))
            sugars.Add(sugar)
        End While
        Return sugars
    End Function

    Public Sub addSugars(sugars As Sugars)
        Dim sql = "INSERT INTO Sugars (sugar, carbs, insulin, datetime) values ({0}, {1}, {2}, '{3}')"
        Dim dbCommand = New SQLiteCommand(String.Format(sql, sugars.sugar, sugars.carbs, sugars.insulin, sugars.datetime.ToString("yyyy-MM-dd HH:mm:ss.fff")), conn)
        dbCommand.ExecuteNonQuery()
    End Sub

    Private Sub createSugarsTable()
        Dim sql As String = "CREATE TABLE IF NOT EXISTS Sugars (sugar INT, carbs INT, insulin INT, datetime STRING)"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        dbCommand.ExecuteNonQuery()
    End Sub

    Private Sub createSettingsTable()
        Dim sql As String = "CREATE TABLE IF NOT EXISTS Settings (name TEXT, value TEXT)"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim tableCreated = dbCommand.ExecuteNonQuery() = 0

        'If the table was just created, insert a default setting for ratio
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
End Class
