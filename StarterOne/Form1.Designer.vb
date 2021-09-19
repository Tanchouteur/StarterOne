<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StarterOne
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StarterOne))
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.volVal = New System.Windows.Forms.Label()
        Me.bar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.play = New System.Windows.Forms.PictureBox()
        Me.pause = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.play, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(288, 12)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(77, 17)
        Me.player.TabIndex = 2
        Me.player.Visible = False
        '
        'volVal
        '
        Me.volVal.AutoSize = True
        Me.volVal.ForeColor = System.Drawing.Color.White
        Me.volVal.Location = New System.Drawing.Point(173, 110)
        Me.volVal.Name = "volVal"
        Me.volVal.Size = New System.Drawing.Size(25, 13)
        Me.volVal.TabIndex = 6
        Me.volVal.Text = "100"
        '
        'bar
        '
        Me.bar.Location = New System.Drawing.Point(83, 93)
        Me.bar.Maximum = 100
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(115, 45)
        Me.bar.TabIndex = 1
        Me.bar.Value = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "0"
        '
        'play
        '
        Me.play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.play.Image = Global.StarterOne.My.Resources.Resources.played651
        Me.play.Location = New System.Drawing.Point(13, 62)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(65, 65)
        Me.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.play.TabIndex = 1
        Me.play.TabStop = False
        '
        'pause
        '
        Me.pause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pause.Image = Global.StarterOne.My.Resources.Resources.play_pause65
        Me.pause.Location = New System.Drawing.Point(12, 62)
        Me.pause.Name = "pause"
        Me.pause.Size = New System.Drawing.Size(65, 65)
        Me.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pause.TabIndex = 0
        Me.pause.TabStop = False
        Me.pause.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(297, 105)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Options"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StarterOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(377, 139)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.volVal)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.pause)
        Me.Controls.Add(Me.bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "StarterOne"
        Me.Tag = ""
        Me.Text = "Starter One  -  Radio"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.play, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pause As PictureBox
    Friend WithEvents play As PictureBox
    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents volVal As Label
    Friend WithEvents bar As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
