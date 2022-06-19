<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.trainerID_lbl = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.victoryBGMExample_lbl = New System.Windows.Forms.Label()
        Me.victoryBGM_txt = New System.Windows.Forms.TextBox()
        Me.victoryBGM_lbl = New System.Windows.Forms.Label()
        Me.battleBGMExample_lbl = New System.Windows.Forms.Label()
        Me.battleBGM_txt = New System.Windows.Forms.TextBox()
        Me.battleBGM_lbl = New System.Windows.Forms.Label()
        Me.introBGMExample_lbl = New System.Windows.Forms.Label()
        Me.introBGM_txt = New System.Windows.Forms.TextBox()
        Me.introBGM_lbl = New System.Windows.Forms.Label()
        Me.baseMoneyExample_lbl = New System.Windows.Forms.Label()
        Me.baseMoney_txt = New System.Windows.Forms.TextBox()
        Me.baseMoney_lbl = New System.Windows.Forms.Label()
        Me.trainerGender_lbl = New System.Windows.Forms.Label()
        Me.trainerGenderUnknown_rad = New System.Windows.Forms.RadioButton()
        Me.trainerGenderFemale_rad = New System.Windows.Forms.RadioButton()
        Me.trainerGenderMale_rad = New System.Windows.Forms.RadioButton()
        Me.trainerNameExample_lbl = New System.Windows.Forms.Label()
        Me.trainerName_txt = New System.Windows.Forms.TextBox()
        Me.trainerName_lbl = New System.Windows.Forms.Label()
        Me.trainerIDExample_lbl = New System.Windows.Forms.Label()
        Me.trainerID_txt = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.output_rchTxt = New System.Windows.Forms.RichTextBox()
        Me.generate_btn = New System.Windows.Forms.Button()
        Me.generateExport_btn = New System.Windows.Forms.Button()
        Me.trainerTypesTXT_SaveDiag = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'trainerID_lbl
        '
        Me.trainerID_lbl.AutoSize = True
        Me.trainerID_lbl.Location = New System.Drawing.Point(5, 9)
        Me.trainerID_lbl.Name = "trainerID_lbl"
        Me.trainerID_lbl.Size = New System.Drawing.Size(56, 15)
        Me.trainerID_lbl.TabIndex = 0
        Me.trainerID_lbl.Text = "Trainer ID"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 291)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.victoryBGMExample_lbl)
        Me.TabPage1.Controls.Add(Me.victoryBGM_txt)
        Me.TabPage1.Controls.Add(Me.victoryBGM_lbl)
        Me.TabPage1.Controls.Add(Me.battleBGMExample_lbl)
        Me.TabPage1.Controls.Add(Me.battleBGM_txt)
        Me.TabPage1.Controls.Add(Me.battleBGM_lbl)
        Me.TabPage1.Controls.Add(Me.introBGMExample_lbl)
        Me.TabPage1.Controls.Add(Me.introBGM_txt)
        Me.TabPage1.Controls.Add(Me.introBGM_lbl)
        Me.TabPage1.Controls.Add(Me.baseMoneyExample_lbl)
        Me.TabPage1.Controls.Add(Me.baseMoney_txt)
        Me.TabPage1.Controls.Add(Me.baseMoney_lbl)
        Me.TabPage1.Controls.Add(Me.trainerGender_lbl)
        Me.TabPage1.Controls.Add(Me.trainerGenderUnknown_rad)
        Me.TabPage1.Controls.Add(Me.trainerGenderFemale_rad)
        Me.TabPage1.Controls.Add(Me.trainerGenderMale_rad)
        Me.TabPage1.Controls.Add(Me.trainerNameExample_lbl)
        Me.TabPage1.Controls.Add(Me.trainerName_txt)
        Me.TabPage1.Controls.Add(Me.trainerName_lbl)
        Me.TabPage1.Controls.Add(Me.trainerIDExample_lbl)
        Me.TabPage1.Controls.Add(Me.trainerID_txt)
        Me.TabPage1.Controls.Add(Me.trainerID_lbl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(435, 263)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'victoryBGMExample_lbl
        '
        Me.victoryBGMExample_lbl.AutoSize = True
        Me.victoryBGMExample_lbl.Location = New System.Drawing.Point(246, 179)
        Me.victoryBGMExample_lbl.Name = "victoryBGMExample_lbl"
        Me.victoryBGMExample_lbl.Size = New System.Drawing.Size(119, 15)
        Me.victoryBGMExample_lbl.TabIndex = 21
        Me.victoryBGMExample_lbl.Text = "Example: Victory.ogg"
        '
        'victoryBGM_txt
        '
        Me.victoryBGM_txt.Location = New System.Drawing.Point(84, 176)
        Me.victoryBGM_txt.Name = "victoryBGM_txt"
        Me.victoryBGM_txt.Size = New System.Drawing.Size(156, 23)
        Me.victoryBGM_txt.TabIndex = 20
        '
        'victoryBGM_lbl
        '
        Me.victoryBGM_lbl.AutoSize = True
        Me.victoryBGM_lbl.Location = New System.Drawing.Point(5, 179)
        Me.victoryBGM_lbl.Name = "victoryBGM_lbl"
        Me.victoryBGM_lbl.Size = New System.Drawing.Size(73, 15)
        Me.victoryBGM_lbl.TabIndex = 19
        Me.victoryBGM_lbl.Text = "Victory BGM"
        '
        'battleBGMExample_lbl
        '
        Me.battleBGMExample_lbl.AutoSize = True
        Me.battleBGMExample_lbl.Location = New System.Drawing.Point(246, 150)
        Me.battleBGMExample_lbl.Name = "battleBGMExample_lbl"
        Me.battleBGMExample_lbl.Size = New System.Drawing.Size(112, 15)
        Me.battleBGMExample_lbl.TabIndex = 18
        Me.battleBGMExample_lbl.Text = "Example: Battle.ogg"
        '
        'battleBGM_txt
        '
        Me.battleBGM_txt.Location = New System.Drawing.Point(77, 147)
        Me.battleBGM_txt.Name = "battleBGM_txt"
        Me.battleBGM_txt.Size = New System.Drawing.Size(163, 23)
        Me.battleBGM_txt.TabIndex = 17
        '
        'battleBGM_lbl
        '
        Me.battleBGM_lbl.AutoSize = True
        Me.battleBGM_lbl.Location = New System.Drawing.Point(5, 150)
        Me.battleBGM_lbl.Name = "battleBGM_lbl"
        Me.battleBGM_lbl.Size = New System.Drawing.Size(66, 15)
        Me.battleBGM_lbl.TabIndex = 16
        Me.battleBGM_lbl.Text = "Battle BGM"
        '
        'introBGMExample_lbl
        '
        Me.introBGMExample_lbl.AutoSize = True
        Me.introBGMExample_lbl.Location = New System.Drawing.Point(246, 121)
        Me.introBGMExample_lbl.Name = "introBGMExample_lbl"
        Me.introBGMExample_lbl.Size = New System.Drawing.Size(107, 15)
        Me.introBGMExample_lbl.TabIndex = 15
        Me.introBGMExample_lbl.Text = "Example: Intro.ogg"
        '
        'introBGM_txt
        '
        Me.introBGM_txt.Location = New System.Drawing.Point(72, 118)
        Me.introBGM_txt.Name = "introBGM_txt"
        Me.introBGM_txt.Size = New System.Drawing.Size(168, 23)
        Me.introBGM_txt.TabIndex = 14
        '
        'introBGM_lbl
        '
        Me.introBGM_lbl.AutoSize = True
        Me.introBGM_lbl.Location = New System.Drawing.Point(5, 121)
        Me.introBGM_lbl.Name = "introBGM_lbl"
        Me.introBGM_lbl.Size = New System.Drawing.Size(61, 15)
        Me.introBGM_lbl.TabIndex = 13
        Me.introBGM_lbl.Text = "Intro BGM"
        '
        'baseMoneyExample_lbl
        '
        Me.baseMoneyExample_lbl.AutoSize = True
        Me.baseMoneyExample_lbl.Location = New System.Drawing.Point(246, 92)
        Me.baseMoneyExample_lbl.Name = "baseMoneyExample_lbl"
        Me.baseMoneyExample_lbl.Size = New System.Drawing.Size(70, 15)
        Me.baseMoneyExample_lbl.TabIndex = 12
        Me.baseMoneyExample_lbl.Text = "Example: 30"
        '
        'baseMoney_txt
        '
        Me.baseMoney_txt.Location = New System.Drawing.Point(82, 89)
        Me.baseMoney_txt.Name = "baseMoney_txt"
        Me.baseMoney_txt.Size = New System.Drawing.Size(158, 23)
        Me.baseMoney_txt.TabIndex = 11
        Me.baseMoney_txt.Text = "30"
        '
        'baseMoney_lbl
        '
        Me.baseMoney_lbl.AutoSize = True
        Me.baseMoney_lbl.Location = New System.Drawing.Point(5, 92)
        Me.baseMoney_lbl.Name = "baseMoney_lbl"
        Me.baseMoney_lbl.Size = New System.Drawing.Size(71, 15)
        Me.baseMoney_lbl.TabIndex = 10
        Me.baseMoney_lbl.Text = "Base Money"
        '
        'trainerGender_lbl
        '
        Me.trainerGender_lbl.AutoSize = True
        Me.trainerGender_lbl.Location = New System.Drawing.Point(5, 66)
        Me.trainerGender_lbl.Name = "trainerGender_lbl"
        Me.trainerGender_lbl.Size = New System.Drawing.Size(83, 15)
        Me.trainerGender_lbl.TabIndex = 9
        Me.trainerGender_lbl.Text = "Trainer Gender"
        '
        'trainerGenderUnknown_rad
        '
        Me.trainerGenderUnknown_rad.AutoSize = True
        Me.trainerGenderUnknown_rad.Checked = True
        Me.trainerGenderUnknown_rad.Location = New System.Drawing.Point(220, 64)
        Me.trainerGenderUnknown_rad.Name = "trainerGenderUnknown_rad"
        Me.trainerGenderUnknown_rad.Size = New System.Drawing.Size(76, 19)
        Me.trainerGenderUnknown_rad.TabIndex = 8
        Me.trainerGenderUnknown_rad.TabStop = True
        Me.trainerGenderUnknown_rad.Text = "Unknown"
        Me.trainerGenderUnknown_rad.UseVisualStyleBackColor = True
        '
        'trainerGenderFemale_rad
        '
        Me.trainerGenderFemale_rad.AutoSize = True
        Me.trainerGenderFemale_rad.Location = New System.Drawing.Point(151, 64)
        Me.trainerGenderFemale_rad.Name = "trainerGenderFemale_rad"
        Me.trainerGenderFemale_rad.Size = New System.Drawing.Size(63, 19)
        Me.trainerGenderFemale_rad.TabIndex = 7
        Me.trainerGenderFemale_rad.Text = "Female"
        Me.trainerGenderFemale_rad.UseVisualStyleBackColor = True
        '
        'trainerGenderMale_rad
        '
        Me.trainerGenderMale_rad.AutoSize = True
        Me.trainerGenderMale_rad.Location = New System.Drawing.Point(94, 64)
        Me.trainerGenderMale_rad.Name = "trainerGenderMale_rad"
        Me.trainerGenderMale_rad.Size = New System.Drawing.Size(51, 19)
        Me.trainerGenderMale_rad.TabIndex = 6
        Me.trainerGenderMale_rad.Text = "Male"
        Me.trainerGenderMale_rad.UseVisualStyleBackColor = True
        '
        'trainerNameExample_lbl
        '
        Me.trainerNameExample_lbl.AutoSize = True
        Me.trainerNameExample_lbl.Location = New System.Drawing.Point(246, 38)
        Me.trainerNameExample_lbl.Name = "trainerNameExample_lbl"
        Me.trainerNameExample_lbl.Size = New System.Drawing.Size(125, 15)
        Me.trainerNameExample_lbl.TabIndex = 5
        Me.trainerNameExample_lbl.Text = "Example: Team Rocket"
        '
        'trainerName_txt
        '
        Me.trainerName_txt.Location = New System.Drawing.Point(88, 35)
        Me.trainerName_txt.Name = "trainerName_txt"
        Me.trainerName_txt.Size = New System.Drawing.Size(152, 23)
        Me.trainerName_txt.TabIndex = 4
        '
        'trainerName_lbl
        '
        Me.trainerName_lbl.AutoSize = True
        Me.trainerName_lbl.Location = New System.Drawing.Point(5, 38)
        Me.trainerName_lbl.Name = "trainerName_lbl"
        Me.trainerName_lbl.Size = New System.Drawing.Size(77, 15)
        Me.trainerName_lbl.TabIndex = 3
        Me.trainerName_lbl.Text = "Trainer Name"
        '
        'trainerIDExample_lbl
        '
        Me.trainerIDExample_lbl.AutoSize = True
        Me.trainerIDExample_lbl.Location = New System.Drawing.Point(246, 9)
        Me.trainerIDExample_lbl.Name = "trainerIDExample_lbl"
        Me.trainerIDExample_lbl.Size = New System.Drawing.Size(143, 15)
        Me.trainerIDExample_lbl.TabIndex = 2
        Me.trainerIDExample_lbl.Text = "Example: TEAMROCKETM"
        '
        'trainerID_txt
        '
        Me.trainerID_txt.Location = New System.Drawing.Point(67, 6)
        Me.trainerID_txt.Name = "trainerID_txt"
        Me.trainerID_txt.Size = New System.Drawing.Size(173, 23)
        Me.trainerID_txt.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.output_rchTxt)
        Me.TabPage2.Controls.Add(Me.generate_btn)
        Me.TabPage2.Controls.Add(Me.generateExport_btn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(435, 263)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Output"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'output_rchTxt
        '
        Me.output_rchTxt.Location = New System.Drawing.Point(6, 6)
        Me.output_rchTxt.Name = "output_rchTxt"
        Me.output_rchTxt.ReadOnly = True
        Me.output_rchTxt.Size = New System.Drawing.Size(423, 220)
        Me.output_rchTxt.TabIndex = 2
        Me.output_rchTxt.Text = ""
        '
        'generate_btn
        '
        Me.generate_btn.Location = New System.Drawing.Point(216, 232)
        Me.generate_btn.Name = "generate_btn"
        Me.generate_btn.Size = New System.Drawing.Size(75, 23)
        Me.generate_btn.TabIndex = 1
        Me.generate_btn.Text = "Generate"
        Me.generate_btn.UseVisualStyleBackColor = True
        '
        'generateExport_btn
        '
        Me.generateExport_btn.Location = New System.Drawing.Point(297, 232)
        Me.generateExport_btn.Name = "generateExport_btn"
        Me.generateExport_btn.Size = New System.Drawing.Size(130, 23)
        Me.generateExport_btn.TabIndex = 0
        Me.generateExport_btn.Text = "Generate && export"
        Me.generateExport_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 291)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trainer Type Generator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents trainerID_lbl As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents trainerID_txt As TextBox
    Friend WithEvents trainerIDExample_lbl As Label
    Friend WithEvents trainerNameExample_lbl As Label
    Friend WithEvents trainerName_txt As TextBox
    Friend WithEvents trainerName_lbl As Label
    Friend WithEvents trainerGender_lbl As Label
    Friend WithEvents trainerGenderUnknown_rad As RadioButton
    Friend WithEvents trainerGenderFemale_rad As RadioButton
    Friend WithEvents trainerGenderMale_rad As RadioButton
    Friend WithEvents baseMoneyExample_lbl As Label
    Friend WithEvents baseMoney_txt As TextBox
    Friend WithEvents baseMoney_lbl As Label
    Friend WithEvents introBGMExample_lbl As Label
    Friend WithEvents introBGM_txt As TextBox
    Friend WithEvents introBGM_lbl As Label
    Friend WithEvents battleBGMExample_lbl As Label
    Friend WithEvents battleBGM_txt As TextBox
    Friend WithEvents battleBGM_lbl As Label
    Friend WithEvents victoryBGMExample_lbl As Label
    Friend WithEvents victoryBGM_txt As TextBox
    Friend WithEvents victoryBGM_lbl As Label
    Friend WithEvents generateExport_btn As Button
    Friend WithEvents generate_btn As Button
    Friend WithEvents output_rchTxt As RichTextBox
    Friend WithEvents trainerTypesTXT_SaveDiag As SaveFileDialog
End Class
