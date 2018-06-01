Imports System.Data.SQLite
Public Class SettingsFrm
    Private Sub SettingsOKBtn_Click(sender As Object, e As EventArgs) Handles SettingsOKBtn.Click
        'this data should be in a ratio format like 2:1 and store in the field ratio and to always display on form load for main form in ratio box
        'update database for ratio
        Dim sql As String = "CREATE TABLE IF NOT EXISTS Sugars (sugar INT, carbs INT, insulin INT, datetime STRING, ratio BLOB)"
        Dim connMakeDB As SQLiteConnection = New SQLiteConnection("SugarDB.sqlite")
        Dim conn = New SQLiteConnection("Data Source=SugarDB.sqlite;Version=3")
        conn.Open()
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim ratio As Integer = Integer.Parse(RatioBoxSt.Text)
        sql = "INSERT INTO Sugars (ratio) values ({0})"
        dbCommand.CommandText = String.Format(sql, ratio)
        dbCommand.ExecuteNonQuery()
        Close()
    End Sub

    Private Sub RatioBoxSt_TextChanged(sender As Object, e As EventArgs) Handles RatioBoxSt.TextChanged
        'user enters their current insulin to carb ratio provided by doctor
    End Sub
End Class