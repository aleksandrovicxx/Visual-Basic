Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stepen As Integer = TextBox1.Text
        TextBox2.Text = Math.Sin(stepen)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stepen As Integer = TextBox1.Text
        TextBox2.Text = Math.Cos(stepen)
    End Sub
End Class
