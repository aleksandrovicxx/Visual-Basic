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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.crvena = New System.Windows.Forms.CheckBox()
        Me.plava = New System.Windows.Forms.CheckBox()
        Me.zelena = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Boje"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 104)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Oboji"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'crvena
        '
        Me.crvena.AutoSize = True
        Me.crvena.Location = New System.Drawing.Point(62, 102)
        Me.crvena.Name = "crvena"
        Me.crvena.Size = New System.Drawing.Size(81, 17)
        Me.crvena.TabIndex = 5
        Me.crvena.Text = "CheckBox1"
        Me.crvena.UseVisualStyleBackColor = True
        '
        'plava
        '
        Me.plava.AutoSize = True
        Me.plava.Location = New System.Drawing.Point(62, 147)
        Me.plava.Name = "plava"
        Me.plava.Size = New System.Drawing.Size(81, 17)
        Me.plava.TabIndex = 6
        Me.plava.Text = "CheckBox2"
        Me.plava.UseVisualStyleBackColor = True
        '
        'zelena
        '
        Me.zelena.AutoSize = True
        Me.zelena.Location = New System.Drawing.Point(62, 189)
        Me.zelena.Name = "zelena"
        Me.zelena.Size = New System.Drawing.Size(81, 17)
        Me.zelena.TabIndex = 7
        Me.zelena.Text = "CheckBox3"
        Me.zelena.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.zelena)
        Me.Controls.Add(Me.plava)
        Me.Controls.Add(Me.crvena)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents crvena As CheckBox
    Friend WithEvents plava As CheckBox
    Friend WithEvents zelena As CheckBox
End Class
