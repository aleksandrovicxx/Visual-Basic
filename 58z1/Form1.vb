Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Prikazi.Click
        Dim brojp As Integer
        Dim brojd As Integer

        If RadioButton1.Checked Then
            brojp = TextBox1.Text
            brojd = TextBox2.Text
            TextBox3.Text = $"{brojp + brojd}"
        End If
        If Proizvod.Checked Then
            brojp = TextBox1.Text
            brojd = TextBox2.Text
            TextBox3.Text = $"{brojp * brojd}"
        End If
    End Sub

End Class
