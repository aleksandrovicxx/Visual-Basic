Public Class Form1
    Dim brojac As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        brojac = brojac + 1
        Button1.Text = Str(brojac)
    End Sub
End Class
