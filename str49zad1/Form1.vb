Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If crvena.Checked And plava.Checked And zelena.Checked Then
            Me.BackColor = Color.White
        ElseIf crvena.Checked And plava.Checked Then
            Me.BackColor = Color.Violet
        ElseIf crvena.Checked And zelena.Checked Then
            Me.BackColor = Color.Yellow
        ElseIf plava.Checked And zelena.Checked Then
            Me.BackColor = Color.Indigo
        ElseIf crvena.Checked Then
            Me.BackColor = Color.Red
        ElseIf plava.Checked Then
            Me.BackColor = Color.Blue
        ElseIf zelena.Checked Then
            Me.BackColor = Color.Green
        End If

    End Sub

End Class
