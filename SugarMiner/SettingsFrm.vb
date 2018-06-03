Imports System.Data.SQLite
Public Class SettingsFrm
    Private conn As SQLiteConnection

    Public Sub New(conn As SQLiteConnection)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.conn = conn
    End Sub

    Private Sub SettingsOKBtn_Click(sender As Object, e As EventArgs) Handles SettingsOKBtn.Click
        'this data should be in a ratio format like 2:1 and store in the field ratio and to always display on form load for main form in ratio box
        'update database for ratio
        Dim ratio As Integer = Integer.Parse(RatioBoxSt.Text)
        Dim sql = "INSERT OR REPLACE INTO Settings (rowid, name, value) values ((SELECT rowid FROM Settings WHERE name='ratio'), 'ratio', {0})"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        dbCommand.CommandText = String.Format(sql, ratio)
        dbCommand.ExecuteNonQuery()
        Close()


    End Sub

    Private Sub RatioBoxSt_TextChanged(sender As Object, e As EventArgs)
        'user enters their current insulin to carb ratio provided by doctor
    End Sub

    Private Sub RatioBoxSt_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles RatioBoxSt.MaskInputRejected

    End Sub

    Private Sub SettingsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT value from Settings WHERE name='ratio'"
        Dim dbCommand As SQLiteCommand = New SQLiteCommand(sql, conn)
        Dim ratio = dbCommand.ExecuteScalar()
        RatioBoxSt.Text = ratio


    End Sub
End Class