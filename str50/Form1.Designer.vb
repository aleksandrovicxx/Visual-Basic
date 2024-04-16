<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dva = New System.Windows.Forms.CheckBox()
        Me.sedamnaest = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unesite broj: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'dva
        '
        Me.dva.AutoSize = True
        Me.dva.Location = New System.Drawing.Point(90, 100)
        Me.dva.Name = "dva"
        Me.dva.Size = New System.Drawing.Size(83, 17)
        Me.dva.TabIndex = 2
        Me.dva.Text = "deljv sa dva"
        Me.dva.UseVisualStyleBackColor = True
        '
        'sedamnaest
        '
        Me.sedamnaest.AutoSize = True
        Me.sedamnaest.Location = New System.Drawing.Point(203, 100)
        Me.sedamnaest.Name = "sedamnaest"
        Me.sedamnaest.Size = New System.Drawing.Size(79, 17)
        Me.sedamnaest.TabIndex = 3
        Me.sedamnaest.Text = "deljiv sa 17"
        Me.sedamnaest.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Proveri deljivost"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sedamnaest)
        Me.Controls.Add(Me.dva)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dva As CheckBox
    Friend WithEvents sedamnaest As CheckBox
    Friend WithEvents Button1 As Button
End Class
