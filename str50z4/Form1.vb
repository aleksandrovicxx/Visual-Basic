Public Class Form1

    Dim hleb As Integer = 45
    Dim kifla As Integer = 10
    Dim mleko As Integer = 98
    Dim jogurt As Integer = 115
    Dim pavlaka As Integer = 55
    Dim cokolada As Integer = 125
    Dim cena As Integer = 0
    Dim poruka As String = " "

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            cena = cena + hleb
            poruka += "Hleb " & vbNewLine
        End If
        If CheckBox2.Checked Then
            cena = cena + kifla
            poruka += "Kifla" & vbNewLine
        End If
        If CheckBox3.Checked Then
            cena = cena + mleko
            poruka += "Mleko" & vbNewLine
        End If
        If CheckBox4.Checked Then
            cena = cena + jogurt
            poruka += "Jogurt" & vbNewLine
        End If
        If CheckBox5.Checked Then
            cena = cena + pavlaka
            poruka += "Pavlaka" & vbNewLine
        End If
        If CheckBox6.Checked Then
            cena = cena + cokolada
            poruka += "Cokolada" & vbNewLine
        End If

        TextBox1.Text = poruka & vbNewLine & "Ukupno: " & cena

    End Sub
End Class
