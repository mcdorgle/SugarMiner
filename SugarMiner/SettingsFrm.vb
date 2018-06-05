Public Class SettingsFrm
    Private dataset As DataClass

    Public Sub New(dataset As DataClass)
        ' This call is required by the designer.
        InitializeComponent()

        Me.dataset = dataset
    End Sub

    Private Sub SettingsOKBtn_Click(sender As Object, e As EventArgs) Handles SettingsOKBtn.Click
        'this data should be in a ratio format like 2:1 and store in the field ratio and to always display on form load for main form in ratio box
        'update database for ratio
        Dim ratio As Integer = Integer.Parse(RatioBoxSt.Text)
        dataset.setRatio(ratio)
        Close()
    End Sub

    Private Sub RatioBoxSt_TextChanged(sender As Object, e As EventArgs)
        'user enters their current insulin to carb ratio provided by doctor
    End Sub

    Private Sub RatioBoxSt_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles RatioBoxSt.MaskInputRejected
    End Sub

    Private Sub SettingsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RatioBoxSt.Text = dataset.getRatio()
    End Sub
End Class