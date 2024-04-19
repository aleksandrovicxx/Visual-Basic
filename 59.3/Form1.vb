Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = Val(TextBox1.Text)
        Dim counter As Integer = 0

        For i As Integer = 1 To 999999
            If i Mod 17 = 0 Then
                TextBox2.Text += $"{i}   "
                counter += 1
                If counter = n Then
                    Exit For
                End If
            End If
        Next

    End Sub
End Class
