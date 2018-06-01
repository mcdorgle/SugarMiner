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

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim oForm As SettingsFrm
        oForm = New SettingsFrm()
        oForm.Show()
        oForm = Nothing
    End Sub
End Class
