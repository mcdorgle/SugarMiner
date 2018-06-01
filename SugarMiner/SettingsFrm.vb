Public Class SettingsFrm
    Private Sub SettingsOKBtn_Click(sender As Object, e As EventArgs) Handles SettingsOKBtn.Click
        'update database for ratio
        Close()
    End Sub

    Private Sub RatioBoxSt_TextChanged(sender As Object, e As EventArgs) Handles RatioBoxSt.TextChanged
        'user enters their current insulin to carb ratio provided by doctor
    End Sub
End Class