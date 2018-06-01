<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SgrMnr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SgrMnr))
        Me.sgrbox = New System.Windows.Forms.TextBox()
        Me.insulinbox = New System.Windows.Forms.TextBox()
        Me.carbox = New System.Windows.Forms.TextBox()
        Me.sugrlbl = New System.Windows.Forms.Label()
        Me.carblbl = New System.Windows.Forms.Label()
        Me.insulinlbl = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.datelbl = New System.Windows.Forms.Label()
        Me.timelbl = New System.Windows.Forms.Label()
        Me.timebox = New System.Windows.Forms.DateTimePicker()
        Me.addsgrbtn = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.tpleftpane = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.refrshbtn = New System.Windows.Forms.Button()
        Me.preventrylbl = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.resultsgrid = New System.Windows.Forms.DataGridView()
        Me.crntratiobox = New System.Windows.Forms.TextBox()
        Me.ratiolbl = New System.Windows.Forms.Label()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpleftpane.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.resultsgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sgrbox
        '
        Me.sgrbox.Location = New System.Drawing.Point(193, 20)
        Me.sgrbox.Name = "sgrbox"
        Me.sgrbox.Size = New System.Drawing.Size(100, 20)
        Me.sgrbox.TabIndex = 3
        '
        'insulinbox
        '
        Me.insulinbox.Location = New System.Drawing.Point(193, 69)
        Me.insulinbox.Name = "insulinbox"
        Me.insulinbox.Size = New System.Drawing.Size(100, 20)
        Me.insulinbox.TabIndex = 4
        '
        'carbox
        '
        Me.carbox.Location = New System.Drawing.Point(193, 43)
        Me.carbox.Name = "carbox"
        Me.carbox.Size = New System.Drawing.Size(100, 20)
        Me.carbox.TabIndex = 5
        '
        'sugrlbl
        '
        Me.sugrlbl.AutoSize = True
        Me.sugrlbl.Location = New System.Drawing.Point(299, 20)
        Me.sugrlbl.Name = "sugrlbl"
        Me.sugrlbl.Size = New System.Drawing.Size(35, 13)
        Me.sugrlbl.TabIndex = 6
        Me.sugrlbl.Text = "Sugar"
        '
        'carblbl
        '
        Me.carblbl.AutoSize = True
        Me.carblbl.Location = New System.Drawing.Point(299, 43)
        Me.carblbl.Name = "carblbl"
        Me.carblbl.Size = New System.Drawing.Size(34, 13)
        Me.carblbl.TabIndex = 7
        Me.carblbl.Text = "Carbs"
        '
        'insulinlbl
        '
        Me.insulinlbl.AutoSize = True
        Me.insulinlbl.Location = New System.Drawing.Point(299, 69)
        Me.insulinlbl.Name = "insulinlbl"
        Me.insulinlbl.Size = New System.Drawing.Size(37, 13)
        Me.insulinlbl.TabIndex = 8
        Me.insulinlbl.Text = "Insulin"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(17, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'datelbl
        '
        Me.datelbl.AutoSize = True
        Me.datelbl.Location = New System.Drawing.Point(123, 20)
        Me.datelbl.Name = "datelbl"
        Me.datelbl.Size = New System.Drawing.Size(30, 13)
        Me.datelbl.TabIndex = 10
        Me.datelbl.Text = "Date"
        '
        'timelbl
        '
        Me.timelbl.AutoSize = True
        Me.timelbl.Location = New System.Drawing.Point(123, 46)
        Me.timelbl.Name = "timelbl"
        Me.timelbl.Size = New System.Drawing.Size(30, 13)
        Me.timelbl.TabIndex = 11
        Me.timelbl.Text = "Time"
        '
        'timebox
        '
        Me.timebox.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timebox.Location = New System.Drawing.Point(17, 46)
        Me.timebox.Name = "timebox"
        Me.timebox.ShowUpDown = True
        Me.timebox.Size = New System.Drawing.Size(100, 20)
        Me.timebox.TabIndex = 12
        '
        'addsgrbtn
        '
        Me.addsgrbtn.Location = New System.Drawing.Point(378, 18)
        Me.addsgrbtn.Name = "addsgrbtn"
        Me.addsgrbtn.Size = New System.Drawing.Size(75, 23)
        Me.addsgrbtn.TabIndex = 14
        Me.addsgrbtn.Text = "Add Sugar"
        Me.addsgrbtn.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(572, 66)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 15
        '
        'tpleftpane
        '
        Me.tpleftpane.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tpleftpane.Controls.Add(Me.ratiolbl)
        Me.tpleftpane.Controls.Add(Me.Label8)
        Me.tpleftpane.Controls.Add(Me.crntratiobox)
        Me.tpleftpane.Controls.Add(Me.refrshbtn)
        Me.tpleftpane.Controls.Add(Me.timelbl)
        Me.tpleftpane.Controls.Add(Me.sgrbox)
        Me.tpleftpane.Controls.Add(Me.addsgrbtn)
        Me.tpleftpane.Controls.Add(Me.insulinbox)
        Me.tpleftpane.Controls.Add(Me.carbox)
        Me.tpleftpane.Controls.Add(Me.timebox)
        Me.tpleftpane.Controls.Add(Me.sugrlbl)
        Me.tpleftpane.Controls.Add(Me.carblbl)
        Me.tpleftpane.Controls.Add(Me.datelbl)
        Me.tpleftpane.Controls.Add(Me.insulinlbl)
        Me.tpleftpane.Controls.Add(Me.DateTimePicker1)
        Me.tpleftpane.Location = New System.Drawing.Point(31, 66)
        Me.tpleftpane.Name = "tpleftpane"
        Me.tpleftpane.Size = New System.Drawing.Size(480, 162)
        Me.tpleftpane.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(454, 52)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'refrshbtn
        '
        Me.refrshbtn.Location = New System.Drawing.Point(378, 69)
        Me.refrshbtn.Name = "refrshbtn"
        Me.refrshbtn.Size = New System.Drawing.Size(75, 23)
        Me.refrshbtn.TabIndex = 15
        Me.refrshbtn.Text = "Refresh"
        Me.refrshbtn.UseVisualStyleBackColor = True
        '
        'preventrylbl
        '
        Me.preventrylbl.AutoSize = True
        Me.preventrylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preventrylbl.Location = New System.Drawing.Point(302, 330)
        Me.preventrylbl.Name = "preventrylbl"
        Me.preventrylbl.Size = New System.Drawing.Size(139, 20)
        Me.preventrylbl.TabIndex = 17
        Me.preventrylbl.Text = "Previous Entries"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(838, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(305, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "display all database entries sorted by date field newest to oldest"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(429, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(397, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "calendar to function as a jump to point in database by date to display that date " &
    "only"
        '
        'resultsgrid
        '
        Me.resultsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resultsgrid.Location = New System.Drawing.Point(31, 366)
        Me.resultsgrid.Name = "resultsgrid"
        Me.resultsgrid.Size = New System.Drawing.Size(768, 244)
        Me.resultsgrid.TabIndex = 21
        '
        'crntratiobox
        '
        Me.crntratiobox.Location = New System.Drawing.Point(17, 72)
        Me.crntratiobox.Name = "crntratiobox"
        Me.crntratiobox.Size = New System.Drawing.Size(100, 20)
        Me.crntratiobox.TabIndex = 23
        '
        'ratiolbl
        '
        Me.ratiolbl.AutoSize = True
        Me.ratiolbl.Location = New System.Drawing.Point(123, 74)
        Me.ratiolbl.Name = "ratiolbl"
        Me.ratiolbl.Size = New System.Drawing.Size(32, 13)
        Me.ratiolbl.TabIndex = 23
        Me.ratiolbl.Text = "Ratio"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'SgrMnr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 622)
        Me.Controls.Add(Me.resultsgrid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.preventrylbl)
        Me.Controls.Add(Me.tpleftpane)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SgrMnr"
        Me.Text = "Sugar Miner"
        Me.tpleftpane.ResumeLayout(False)
        Me.tpleftpane.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.resultsgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sgrbox As TextBox
    Friend WithEvents insulinbox As TextBox
    Friend WithEvents carbox As TextBox
    Friend WithEvents sugrlbl As Label
    Friend WithEvents carblbl As Label
    Friend WithEvents insulinlbl As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents datelbl As Label
    Friend WithEvents timelbl As Label
    Friend WithEvents timebox As DateTimePicker
    Friend WithEvents addsgrbtn As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents tpleftpane As Panel
    Friend WithEvents preventrylbl As Label
    Friend WithEvents refrshbtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents resultsgrid As DataGridView
    Friend WithEvents ratiolbl As Label
    Friend WithEvents crntratiobox As TextBox
    Friend WithEvents SettingsToolStripMenuItem1 As ToolStripMenuItem
End Class
