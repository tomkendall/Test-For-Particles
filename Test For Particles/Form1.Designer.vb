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
        Me.components = New System.ComponentModel.Container()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.NumberOfParticlesLabel = New System.Windows.Forms.Label()
        Me.Add10Button = New System.Windows.Forms.Button()
        Me.ParticleSizeBar = New System.Windows.Forms.TrackBar()
        Me.ResetSizeButton = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.ChangeParticleSizeLabel = New System.Windows.Forms.Label()
        Me.Add100Button = New System.Windows.Forms.Button()
        Me.IncreaseArrowButton = New System.Windows.Forms.Button()
        Me.DecreaseArrowButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CoordsCheckBox = New System.Windows.Forms.CheckBox()
        Me.CollisionsCheckBox = New System.Windows.Forms.CheckBox()
        Me.FPSCounter = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ParticleSizeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1
        '
        'NumberOfParticlesLabel
        '
        Me.NumberOfParticlesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumberOfParticlesLabel.AutoSize = True
        Me.NumberOfParticlesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.NumberOfParticlesLabel.Location = New System.Drawing.Point(527, 518)
        Me.NumberOfParticlesLabel.Name = "NumberOfParticlesLabel"
        Me.NumberOfParticlesLabel.Size = New System.Drawing.Size(296, 36)
        Me.NumberOfParticlesLabel.TabIndex = 1
        Me.NumberOfParticlesLabel.Text = "Number Of Particles: "
        '
        'Add10Button
        '
        Me.Add10Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Add10Button.Location = New System.Drawing.Point(12, 569)
        Me.Add10Button.Name = "Add10Button"
        Me.Add10Button.Size = New System.Drawing.Size(300, 100)
        Me.Add10Button.TabIndex = 2
        Me.Add10Button.Text = "Add 10 Particles"
        Me.Add10Button.UseVisualStyleBackColor = True
        '
        'ParticleSizeBar
        '
        Me.ParticleSizeBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ParticleSizeBar.LargeChange = 10
        Me.ParticleSizeBar.Location = New System.Drawing.Point(12, 518)
        Me.ParticleSizeBar.Maximum = 100
        Me.ParticleSizeBar.Minimum = 7
        Me.ParticleSizeBar.Name = "ParticleSizeBar"
        Me.ParticleSizeBar.Size = New System.Drawing.Size(463, 45)
        Me.ParticleSizeBar.TabIndex = 3
        Me.ParticleSizeBar.Value = 100
        '
        'ResetSizeButton
        '
        Me.ResetSizeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResetSizeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.ResetSizeButton.Location = New System.Drawing.Point(481, 526)
        Me.ResetSizeButton.Name = "ResetSizeButton"
        Me.ResetSizeButton.Size = New System.Drawing.Size(40, 20)
        Me.ResetSizeButton.TabIndex = 4
        Me.ResetSizeButton.Text = "Reset"
        Me.ResetSizeButton.UseVisualStyleBackColor = True
        '
        'PauseButton
        '
        Me.PauseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PauseButton.Location = New System.Drawing.Point(624, 569)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(300, 100)
        Me.PauseButton.TabIndex = 5
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'ChangeParticleSizeLabel
        '
        Me.ChangeParticleSizeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChangeParticleSizeLabel.AutoSize = True
        Me.ChangeParticleSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.ChangeParticleSizeLabel.Location = New System.Drawing.Point(208, 505)
        Me.ChangeParticleSizeLabel.Name = "ChangeParticleSizeLabel"
        Me.ChangeParticleSizeLabel.Size = New System.Drawing.Size(104, 13)
        Me.ChangeParticleSizeLabel.TabIndex = 6
        Me.ChangeParticleSizeLabel.Text = "Change Particle Size"
        '
        'Add100Button
        '
        Me.Add100Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Add100Button.Location = New System.Drawing.Point(318, 569)
        Me.Add100Button.Name = "Add100Button"
        Me.Add100Button.Size = New System.Drawing.Size(300, 100)
        Me.Add100Button.TabIndex = 7
        Me.Add100Button.Text = "Add 100 Particles"
        Me.Add100Button.UseVisualStyleBackColor = True
        '
        'IncreaseArrowButton
        '
        Me.IncreaseArrowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IncreaseArrowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.IncreaseArrowButton.Location = New System.Drawing.Point(887, 513)
        Me.IncreaseArrowButton.Name = "IncreaseArrowButton"
        Me.IncreaseArrowButton.Size = New System.Drawing.Size(27, 20)
        Me.IncreaseArrowButton.TabIndex = 8
        Me.IncreaseArrowButton.Text = "/\"
        Me.IncreaseArrowButton.UseVisualStyleBackColor = True
        '
        'DecreaseArrowButton
        '
        Me.DecreaseArrowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DecreaseArrowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.DecreaseArrowButton.Location = New System.Drawing.Point(887, 540)
        Me.DecreaseArrowButton.Name = "DecreaseArrowButton"
        Me.DecreaseArrowButton.Size = New System.Drawing.Size(27, 20)
        Me.DecreaseArrowButton.TabIndex = 9
        Me.DecreaseArrowButton.Text = "\/"
        Me.DecreaseArrowButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.ClearButton.Location = New System.Drawing.Point(920, 526)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(40, 20)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CoordsCheckBox
        '
        Me.CoordsCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CoordsCheckBox.AutoSize = True
        Me.CoordsCheckBox.Checked = True
        Me.CoordsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CoordsCheckBox.Location = New System.Drawing.Point(1102, 652)
        Me.CoordsCheckBox.Name = "CoordsCheckBox"
        Me.CoordsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CoordsCheckBox.Size = New System.Drawing.Size(150, 17)
        Me.CoordsCheckBox.TabIndex = 11
        Me.CoordsCheckBox.Text = "Show Particle Coordinates"
        Me.CoordsCheckBox.UseVisualStyleBackColor = True
        '
        'CollisionsCheckBox
        '
        Me.CollisionsCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CollisionsCheckBox.AutoSize = True
        Me.CollisionsCheckBox.Checked = True
        Me.CollisionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CollisionsCheckBox.Location = New System.Drawing.Point(1147, 629)
        Me.CollisionsCheckBox.Name = "CollisionsCheckBox"
        Me.CollisionsCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CollisionsCheckBox.Size = New System.Drawing.Size(105, 17)
        Me.CollisionsCheckBox.TabIndex = 12
        Me.CollisionsCheckBox.Text = "Enable Collisions"
        Me.CollisionsCheckBox.UseVisualStyleBackColor = True
        '
        'FPSCounter
        '
        Me.FPSCounter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FPSCounter.AutoSize = True
        Me.FPSCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPSCounter.Location = New System.Drawing.Point(1188, 505)
        Me.FPSCounter.Name = "FPSCounter"
        Me.FPSCounter.Size = New System.Drawing.Size(48, 20)
        Me.FPSCounter.TabIndex = 13
        Me.FPSCounter.Text = "FPS: "
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.FPSCounter)
        Me.Controls.Add(Me.CollisionsCheckBox)
        Me.Controls.Add(Me.CoordsCheckBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DecreaseArrowButton)
        Me.Controls.Add(Me.IncreaseArrowButton)
        Me.Controls.Add(Me.Add100Button)
        Me.Controls.Add(Me.ChangeParticleSizeLabel)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.ResetSizeButton)
        Me.Controls.Add(Me.ParticleSizeBar)
        Me.Controls.Add(Me.Add10Button)
        Me.Controls.Add(Me.NumberOfParticlesLabel)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(1150, 720)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Particle Collision Simulator"
        CType(Me.ParticleSizeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents pbDraw As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents NumberOfParticlesLabel As Label
    Friend WithEvents Add10Button As Button
    Friend WithEvents ParticleSizeBar As TrackBar
    Friend WithEvents ResetSizeButton As Button
    Friend WithEvents PauseButton As Button
    Friend WithEvents ChangeParticleSizeLabel As Label
    Friend WithEvents Add100Button As Button
    Friend WithEvents IncreaseArrowButton As Button
    Friend WithEvents DecreaseArrowButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CoordsCheckBox As CheckBox
    Friend WithEvents CollisionsCheckBox As CheckBox
    Friend WithEvents FPSCounter As Label
    Friend WithEvents Timer2 As Timer
End Class
