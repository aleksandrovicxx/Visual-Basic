Public Class Form1
    Private Sub Prikazi_Click(sender As Object, e As EventArgs) Handles Prikazi.Click
        Dim prvi As Integer
        Dim drugi As Integer

        prvi = Val(TextBox1.Text)
        drugi = Val(TextBox2.Text)

        For i As Integer = prvi To drugi
            If CheckBox1.Checked Then
                If Not i Mod 5 = 0 Then
                    Continue For
                End If
            End If
            TextBox3.Text += $"{i}" & vbNewLine
        Next


    End Sub
End Class
