<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlots
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlots))
        Me.picReel1 = New System.Windows.Forms.PictureBox()
        Me.picReel2 = New System.Windows.Forms.PictureBox()
        Me.picReel3 = New System.Windows.Forms.PictureBox()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDeclaration = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.nudBet = New System.Windows.Forms.NumericUpDown()
        Me.nudLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picReel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.nudBet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picReel1
        '
        Me.picReel1.BackColor = System.Drawing.Color.White
        Me.picReel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picReel1.Image = Global.Slots.My.Resources.Resources.slot1
        Me.picReel1.Location = New System.Drawing.Point(213, 335)
        Me.picReel1.Name = "picReel1"
        Me.picReel1.Size = New System.Drawing.Size(193, 271)
        Me.picReel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picReel1.TabIndex = 0
        Me.picReel1.TabStop = False
        '
        'picReel2
        '
        Me.picReel2.BackColor = System.Drawing.Color.White
        Me.picReel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picReel2.Image = Global.Slots.My.Resources.Resources.slot1
        Me.picReel2.Location = New System.Drawing.Point(418, 336)
        Me.picReel2.Name = "picReel2"
        Me.picReel2.Size = New System.Drawing.Size(193, 271)
        Me.picReel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picReel2.TabIndex = 1
        Me.picReel2.TabStop = False
        '
        'picReel3
        '
        Me.picReel3.BackColor = System.Drawing.Color.White
        Me.picReel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picReel3.Image = Global.Slots.My.Resources.Resources.slot1
        Me.picReel3.Location = New System.Drawing.Point(623, 336)
        Me.picReel3.Name = "picReel3"
        Me.picReel3.Size = New System.Drawing.Size(193, 270)
        Me.picReel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picReel3.TabIndex = 2
        Me.picReel3.TabStop = False
        '
        'btnSpin
        '
        Me.btnSpin.BackColor = System.Drawing.Color.Transparent
        Me.btnSpin.FlatAppearance.BorderSize = 0
        Me.btnSpin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSpin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpin.ForeColor = System.Drawing.Color.Transparent
        Me.btnSpin.Location = New System.Drawing.Point(736, 652)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(84, 51)
        Me.btnSpin.TabIndex = 3
        Me.btnSpin.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 75
        '
        'lblDeclaration
        '
        Me.lblDeclaration.BackColor = System.Drawing.Color.Transparent
        Me.lblDeclaration.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeclaration.ForeColor = System.Drawing.Color.Red
        Me.lblDeclaration.Location = New System.Drawing.Point(302, 299)
        Me.lblDeclaration.Name = "lblDeclaration"
        Me.lblDeclaration.Size = New System.Drawing.Size(419, 33)
        Me.lblDeclaration.TabIndex = 4
        Me.lblDeclaration.Text = "    Spin and Win!"
        Me.lblDeclaration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1023, 29)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(47, 25)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblBalance
        '
        Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(213, 653)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(77, 47)
        Me.lblBalance.TabIndex = 7
        Me.lblBalance.Text = "50"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudBet
        '
        Me.nudBet.BackColor = System.Drawing.Color.Black
        Me.nudBet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nudBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBet.ForeColor = System.Drawing.Color.White
        Me.nudBet.Location = New System.Drawing.Point(313, 664)
        Me.nudBet.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudBet.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBet.Name = "nudBet"
        Me.nudBet.Size = New System.Drawing.Size(53, 25)
        Me.nudBet.TabIndex = 8
        Me.nudBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudBet.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudLabel
        '
        Me.nudLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLabel.Location = New System.Drawing.Point(213, 752)
        Me.nudLabel.Name = "nudLabel"
        Me.nudLabel.Size = New System.Drawing.Size(46, 47)
        Me.nudLabel.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 653)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 47)
        Me.Label1.TabIndex = 10
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.Transparent
        Me.btnMin.Location = New System.Drawing.Point(365, 650)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(61, 51)
        Me.btnMin.TabIndex = 11
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMax.ForeColor = System.Drawing.Color.Transparent
        Me.btnMax.Location = New System.Drawing.Point(434, 652)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(61, 51)
        Me.btnMax.TabIndex = 12
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'frmSlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1023, 832)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.nudLabel)
        Me.Controls.Add(Me.nudBet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblDeclaration)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picReel3)
        Me.Controls.Add(Me.picReel2)
        Me.Controls.Add(Me.picReel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmSlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spin and Win Slots"
        CType(Me.picReel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.nudBet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picReel1 As PictureBox
    Friend WithEvents picReel2 As PictureBox
    Friend WithEvents picReel3 As PictureBox
    Friend WithEvents btnSpin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDeclaration As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblBalance As Label
    Friend WithEvents nudBet As NumericUpDown
    Friend WithEvents nudLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
End Class
