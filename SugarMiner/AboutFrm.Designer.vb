<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aboutfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aboutfrm))
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.AppName = New System.Windows.Forms.Label()
        Me.VersionLbl = New System.Windows.Forms.Label()
        Me.CopyleftLbl = New System.Windows.Forms.Label()
        Me.AuthorLbl = New System.Windows.Forms.Label()
        Me.DescLong = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.DescPane = New System.Windows.Forms.Panel()
        Me.AuthorPane = New System.Windows.Forms.Panel()
        Me.AbtOKBtn = New System.Windows.Forms.Button()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DescPane.SuspendLayout()
        Me.AuthorPane.SuspendLayout()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(186, 337)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'AppName
        '
        Me.AppName.AutoSize = True
        Me.AppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppName.Location = New System.Drawing.Point(6, 7)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(75, 13)
        Me.AppName.TabIndex = 1
        Me.AppName.Text = "Sugar Miner"
        '
        'VersionLbl
        '
        Me.VersionLbl.AutoSize = True
        Me.VersionLbl.Location = New System.Drawing.Point(6, 31)
        Me.VersionLbl.Name = "VersionLbl"
        Me.VersionLbl.Size = New System.Drawing.Size(66, 13)
        Me.VersionLbl.TabIndex = 2
        Me.VersionLbl.Text = "Version 1.01"
        '
        'CopyleftLbl
        '
        Me.CopyleftLbl.AutoSize = True
        Me.CopyleftLbl.Location = New System.Drawing.Point(6, 54)
        Me.CopyleftLbl.Name = "CopyleftLbl"
        Me.CopyleftLbl.Size = New System.Drawing.Size(72, 13)
        Me.CopyleftLbl.TabIndex = 3
        Me.CopyleftLbl.Text = "Copyleft 2018"
        '
        'AuthorLbl
        '
        Me.AuthorLbl.AutoSize = True
        Me.AuthorLbl.Location = New System.Drawing.Point(6, 77)
        Me.AuthorLbl.Name = "AuthorLbl"
        Me.AuthorLbl.Size = New System.Drawing.Size(98, 13)
        Me.AuthorLbl.TabIndex = 4
        Me.AuthorLbl.Text = "By Deshi McDorgle"
        '
        'DescLong
        '
        Me.DescLong.AutoSize = True
        Me.DescLong.Location = New System.Drawing.Point(15, 49)
        Me.DescLong.Name = "DescLong"
        Me.DescLong.Size = New System.Drawing.Size(243, 78)
        Me.DescLong.TabIndex = 5
        Me.DescLong.Text = "Sugar Miner is freeware software by Deshi that will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "allow you to log your blood " &
    "sugars as well as view" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "previous entries." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Future version:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Working to integra" &
    "te with medtronic insulin pumps."
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(15, 23)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(63, 13)
        Me.Description.TabIndex = 6
        Me.Description.Text = "Description:"
        '
        'DescPane
        '
        Me.DescPane.Controls.Add(Me.DescLong)
        Me.DescPane.Controls.Add(Me.Description)
        Me.DescPane.Location = New System.Drawing.Point(204, 141)
        Me.DescPane.Name = "DescPane"
        Me.DescPane.Size = New System.Drawing.Size(281, 154)
        Me.DescPane.TabIndex = 7
        '
        'AuthorPane
        '
        Me.AuthorPane.Controls.Add(Me.VersionLbl)
        Me.AuthorPane.Controls.Add(Me.AppName)
        Me.AuthorPane.Controls.Add(Me.AuthorLbl)
        Me.AuthorPane.Controls.Add(Me.CopyleftLbl)
        Me.AuthorPane.Location = New System.Drawing.Point(204, 12)
        Me.AuthorPane.Name = "AuthorPane"
        Me.AuthorPane.Size = New System.Drawing.Size(200, 100)
        Me.AuthorPane.TabIndex = 8
        '
        'AbtOKBtn
        '
        Me.AbtOKBtn.Location = New System.Drawing.Point(303, 326)
        Me.AbtOKBtn.Name = "AbtOKBtn"
        Me.AbtOKBtn.Size = New System.Drawing.Size(75, 23)
        Me.AbtOKBtn.TabIndex = 9
        Me.AbtOKBtn.Text = "OK"
        Me.AbtOKBtn.UseVisualStyleBackColor = True
        '
        'Aboutfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 361)
        Me.Controls.Add(Me.AbtOKBtn)
        Me.Controls.Add(Me.AuthorPane)
        Me.Controls.Add(Me.DescPane)
        Me.Controls.Add(Me.logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aboutfrm"
        Me.Text = "About"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DescPane.ResumeLayout(False)
        Me.DescPane.PerformLayout()
        Me.AuthorPane.ResumeLayout(False)
        Me.AuthorPane.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents AppName As Label
    Friend WithEvents VersionLbl As Label
    Friend WithEvents CopyleftLbl As Label
    Friend WithEvents AuthorLbl As Label
    Friend WithEvents DescLong As Label
    Friend WithEvents Description As Label
    Friend WithEvents DescPane As Panel
    Friend WithEvents AuthorPane As Panel
    Friend WithEvents AbtOKBtn As Button
End Class
