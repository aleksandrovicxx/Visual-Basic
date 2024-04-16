Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim broj As Integer = TextBox1.Text
        Dim poruka As String

        If dva.Checked Then
            poruka = "Nije deljiv sa 2"
            If ((broj Mod 2) = 0) Then
                poruka = "Deljiv sa dva"
            End If
        End If
        If sedamnaest.Checked Then
            poruka = "Nije deljiv sa 17"
            If ((broj Mod 17) = 0) Then
                poruka = "Deljiv sa 17"
            End If
        End If
        MessageBox.Show(poruka)
    End Sub
End Class
