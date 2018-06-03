Imports System.Data.SQLite
Public Class DataClass

    Private conn As SQLiteConnection

    Protected Overrides Sub Finalize()
        conn.Close()
    End Sub

    Dim sql As String = "SELECT value from Settings WHERE name='ratio'"
    Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
    Dim ratio = dbCommand.ExecuteScalar()


End Class
