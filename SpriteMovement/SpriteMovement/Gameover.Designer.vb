﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gameover
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Restart = New System.Windows.Forms.Button()
        Me.lblscoregameover = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GAME OVER"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(478, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 81)
        Me.Button1.TabIndex = 1
        Me.Button1.TabStop = False
        Me.Button1.Text = "Exit Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Restart
        '
        Me.Restart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restart.Location = New System.Drawing.Point(216, 262)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(119, 77)
        Me.Restart.TabIndex = 2
        Me.Restart.TabStop = False
        Me.Restart.Text = "Restart"
        Me.Restart.UseVisualStyleBackColor = True
        '
        'lblscoregameover
        '
        Me.lblscoregameover.AutoSize = True
        Me.lblscoregameover.ForeColor = System.Drawing.Color.Maroon
        Me.lblscoregameover.Location = New System.Drawing.Point(418, 299)
        Me.lblscoregameover.Name = "lblscoregameover"
        Me.lblscoregameover.Size = New System.Drawing.Size(13, 13)
        Me.lblscoregameover.TabIndex = 9
        Me.lblscoregameover.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(371, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SCORE : "
        '
        'Gameover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblscoregameover)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Restart)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gameover"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gameover"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Restart As Button
    Friend WithEvents lblscoregameover As Label
    Friend WithEvents Label2 As Label
End Class
