'Sugar Miner developed by Deshi McDorgle for diabetics to more closely monitor blood sugar levels when using an insulin
'to carb ratio rather than sliding scale
'program is not yet functional
'I sit on freenode irc #web-social and ##thelair
'also working on bluetooth capabilities for MedTronic insulin pump systems

Public Class SgrMnr
    Private dataset As DataClass

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
        dataset = New DataClass()
        crntratiobox.Text = dataset.getRatio()
        refreshResults()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles crntratiobox.TextChanged
        'displays ratio from settings page entered by user  not sure what type of object this should be it should not be an editable field on main form only in the settings form
    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        Dim oForm As SettingsFrm
        oForm = New SettingsFrm(dataset)
        oForm.ShowDialog()
        oForm = Nothing
        crntratiobox.Text = dataset.getRatio()
    End Sub

    Private Sub refrshbtn_Click(sender As Object, e As EventArgs) Handles refrshbtn.Click
        'refresh button should refresh the display of data in the grid to show all results
        refreshResults()
    End Sub

    Private Sub refreshResults()
        Dim dt As New DataTable()
        dt.Columns.AddRange(
        {
            New DataColumn("Sugar", GetType(Integer)),
            New DataColumn("Carbs", GetType(Integer)),
            New DataColumn("Insulin", GetType(Integer)),
            New DataColumn("Date Time")
        })
        For Each sugar In dataset.getSugars()
            Dim row = dt.NewRow
            row.Item(0) = sugar.sugar
            row.Item(1) = sugar.carbs
            row.Item(2) = sugar.insulin
            row.Item(3) = sugar.datetime.ToString
            dt.Rows.Add(row)
        Next
        DataGridView1.DataSource = dt
        DataGridView1.Sort(DataGridView1.Columns(3), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub addsgrbtn_Click(sender As Object, e As EventArgs) Handles addsgrbtn.Click
        'add button will insert all entered values into database

        'values need to be entered from input boxes from date, time, sugar, carbs, insulin
        'ratio value is entered on settings form and the display box should only show the most recent ratio that was entered into settings
        Try
            Dim sugars = New Sugars()
            sugars.sugar = Integer.Parse(sgrbox.Text)
            sugars.carbs = Integer.Parse(carbox.Text)
            sugars.insulin = Integer.Parse(insulinbox.Text)
            sugars.datetime = DateTimePicker1.Value
            dataset.addSugars(sugars)
        Catch ex As Exception
        End Try
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
