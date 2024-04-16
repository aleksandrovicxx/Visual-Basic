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
        Me.PedesetProcenataAngazovanja = New System.Windows.Forms.CheckBox()
        Me.predavanjaPoPozivu = New System.Windows.Forms.CheckBox()
        Me.profesor = New System.Windows.Forms.RadioButton()
        Me.saradnik = New System.Windows.Forms.RadioButton()
        Me.asistent = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(158, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registracija spoljnjeg osoblja"
        '
        'PedesetProcenataAngazovanja
        '
        Me.PedesetProcenataAngazovanja.AutoSize = True
        Me.PedesetProcenataAngazovanja.Location = New System.Drawing.Point(47, 123)
        Me.PedesetProcenataAngazovanja.Name = "PedesetProcenataAngazovanja"
        Me.PedesetProcenataAngazovanja.Size = New System.Drawing.Size(110, 17)
        Me.PedesetProcenataAngazovanja.TabIndex = 1
        Me.PedesetProcenataAngazovanja.Text = "50% angazovanja"
        Me.PedesetProcenataAngazovanja.UseVisualStyleBackColor = True
        '
        'predavanjaPoPozivu
        '
        Me.predavanjaPoPozivu.AutoSize = True
        Me.predavanjaPoPozivu.Location = New System.Drawing.Point(47, 179)
        Me.predavanjaPoPozivu.Name = "predavanjaPoPozivu"
        Me.predavanjaPoPozivu.Size = New System.Drawing.Size(129, 17)
        Me.predavanjaPoPozivu.TabIndex = 2
        Me.predavanjaPoPozivu.Text = "Predavanja po pozivu"
        Me.predavanjaPoPozivu.UseVisualStyleBackColor = True
        '
        'profesor
        '
        Me.profesor.AutoSize = True
        Me.profesor.Checked = True
        Me.profesor.Location = New System.Drawing.Point(377, 123)
        Me.profesor.Name = "profesor"
        Me.profesor.Size = New System.Drawing.Size(64, 17)
        Me.profesor.TabIndex = 3
        Me.profesor.TabStop = True
        Me.profesor.Text = "Profesor"
        Me.profesor.UseVisualStyleBackColor = True
        '
        'saradnik
        '
        Me.saradnik.AutoSize = True
        Me.saradnik.Location = New System.Drawing.Point(377, 191)
        Me.saradnik.Name = "saradnik"
        Me.saradnik.Size = New System.Drawing.Size(67, 17)
        Me.saradnik.TabIndex = 4
        Me.saradnik.TabStop = True
        Me.saradnik.Text = "Saradnik"
        Me.saradnik.UseVisualStyleBackColor = True
        '
        'asistent
        '
        Me.asistent.AutoSize = True
        Me.asistent.Location = New System.Drawing.Point(377, 156)
        Me.asistent.Name = "asistent"
        Me.asistent.Size = New System.Drawing.Size(62, 17)
        Me.asistent.TabIndex = 5
        Me.asistent.TabStop = True
        Me.asistent.Text = "Asistent"
        Me.asistent.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Snimi podatke"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.asistent)
        Me.Controls.Add(Me.saradnik)
        Me.Controls.Add(Me.profesor)
        Me.Controls.Add(Me.predavanjaPoPozivu)
        Me.Controls.Add(Me.PedesetProcenataAngazovanja)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PedesetProcenataAngazovanja As CheckBox
    Friend WithEvents predavanjaPoPozivu As CheckBox
    Friend WithEvents profesor As RadioButton
    Friend WithEvents saradnik As RadioButton
    Friend WithEvents asistent As RadioButton
    Friend WithEvents Button1 As Button
End Class
