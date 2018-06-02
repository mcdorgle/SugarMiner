<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsFrm))
        Me.SettingsOKBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RatioSet = New System.Windows.Forms.Label()
        Me.RatioBoxSt = New System.Windows.Forms.MaskedTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsOKBtn
        '
        Me.SettingsOKBtn.Location = New System.Drawing.Point(49, 67)
        Me.SettingsOKBtn.Name = "SettingsOKBtn"
        Me.SettingsOKBtn.Size = New System.Drawing.Size(75, 23)
        Me.SettingsOKBtn.TabIndex = 0
        Me.SettingsOKBtn.Text = "OK"
        Me.SettingsOKBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.RatioBoxSt, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RatioSet, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(31, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(107, 52)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'RatioSet
        '
        Me.RatioSet.AutoSize = True
        Me.RatioSet.Location = New System.Drawing.Point(3, 0)
        Me.RatioSet.Name = "RatioSet"
        Me.RatioSet.Size = New System.Drawing.Size(90, 13)
        Me.RatioSet.TabIndex = 3
        Me.RatioSet.Text = "Your Insulin Ratio"
        Me.RatioSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RatioBoxSt
        '
        Me.RatioBoxSt.Location = New System.Drawing.Point(3, 29)
        Me.RatioBoxSt.Mask = "00"
        Me.RatioBoxSt.Name = "RatioBoxSt"
        Me.RatioBoxSt.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.RatioBoxSt.Size = New System.Drawing.Size(100, 20)
        Me.RatioBoxSt.TabIndex = 2
        Me.RatioBoxSt.Text = "2"
        Me.RatioBoxSt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SettingsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(178, 120)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.SettingsOKBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsFrm"
        Me.Text = "Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SettingsOKBtn As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RatioSet As Label
    Friend WithEvents RatioBoxSt As MaskedTextBox
End Class
