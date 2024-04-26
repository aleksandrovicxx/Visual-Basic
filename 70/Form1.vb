Public Class Form1

    Dim brojImena As Integer = 0
    Dim niz() As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReDim Preserve niz(brojImena)
        niz(brojImena) = TextBox1.Text
        TextBox2.Text += TextBox1.Text & vbNewLine

        For i As Integer = 0 To niz.Length - 2
            Dim pozicija As Integer = i
            For j = i + 1 To niz.Length - 1
                If StrComp(niz(pozicija), niz(j)) = 1 Then
                    pozicija = j
                End If
            Next
            If pozicija <> i Then
                Dim tmp As String = niz(i)
                niz(i) = niz(pozicija)
                niz(pozicija) = tmp
            End If
        Next

        TextBox3.Text = ""
        For Each ime As String In niz
            TextBox3.Text += ime & vbNewLine
        Next
        brojImena = brojImena + 1
        TextBox1.Text = ""
    End Sub
End Class
