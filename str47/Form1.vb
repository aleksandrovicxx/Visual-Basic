Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tekst As String
        If PedesetProcenataAngazovanja.Checked Then
            tekst += "50% Angazovanja" & vbNewLine
        End If

        If predavanjaPoPozivu.Checked Then
            tekst += "Predavanja po pozivu" & vbNewLine
        End If

        If profesor.Checked Then
            tekst += "Profesor" & vbNewLine
        ElseIf asistent.Checked Then
            tekst += "Asistent" & vbNewLine
        ElseIf saradnik.Checked Then
            tekst += "Saradnik" & vbNewLine
        End If

        MessageBox.Show(tekst)


    End Sub
End Class
