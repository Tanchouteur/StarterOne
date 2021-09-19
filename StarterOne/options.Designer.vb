<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class options
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.startVol = New System.Windows.Forms.TrackBar()
        Me.start_radio = New System.Windows.Forms.CheckBox()
        Me.start_win = New System.Windows.Forms.CheckBox()
        Me.btn_save = New System.Windows.Forms.Button()
        CType(Me.startVol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(12, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Régler le son au démarage à :"
        '
        'startVol
        '
        Me.startVol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startVol.Location = New System.Drawing.Point(194, 26)
        Me.startVol.Maximum = 100
        Me.startVol.Name = "startVol"
        Me.startVol.Size = New System.Drawing.Size(149, 45)
        Me.startVol.TabIndex = 1
        Me.startVol.Value = 30
        '
        'start_radio
        '
        Me.start_radio.AutoSize = True
        Me.start_radio.Checked = True
        Me.start_radio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.start_radio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.start_radio.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_radio.ForeColor = System.Drawing.Color.White
        Me.start_radio.Location = New System.Drawing.Point(12, 66)
        Me.start_radio.Name = "start_radio"
        Me.start_radio.Size = New System.Drawing.Size(331, 21)
        Me.start_radio.TabIndex = 2
        Me.start_radio.Text = "Démarrer la lecture en même temp que le lecteur"
        Me.start_radio.UseVisualStyleBackColor = True
        '
        'start_win
        '
        Me.start_win.AutoSize = True
        Me.start_win.Checked = True
        Me.start_win.CheckState = System.Windows.Forms.CheckState.Checked
        Me.start_win.Cursor = System.Windows.Forms.Cursors.Hand
        Me.start_win.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_win.ForeColor = System.Drawing.Color.White
        Me.start_win.Location = New System.Drawing.Point(12, 93)
        Me.start_win.Name = "start_win"
        Me.start_win.Size = New System.Drawing.Size(238, 21)
        Me.start_win.TabIndex = 2
        Me.start_win.Text = "Démarrer le lecteur avec Windows"
        Me.start_win.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI Symbol", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(12, 120)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(331, 35)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Enregistrer"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(362, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.start_win)
        Me.Controls.Add(Me.start_radio)
        Me.Controls.Add(Me.startVol)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "options"
        Me.Text = "Options - Starter One"
        CType(Me.startVol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents startVol As TrackBar
    Friend WithEvents start_radio As CheckBox
    Friend WithEvents start_win As CheckBox
    Friend WithEvents btn_save As Button
End Class
