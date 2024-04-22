Module Module1

    Sub Main()
        Dim brojevi() As Integer = {7, 3, 1, 4, 2}
        Dim pom As Integer

        For Each broj As Integer In brojevi
            Console.WriteLine(broj)
        Next

        For i As Integer = brojevi.Length - 1 To 0 Step -1
            For j = 0 To i - 1
                If brojevi(j + 1) < brojevi(j) Then
                    pom = brojevi(j)
                    brojevi(j) = brojevi(j + 1)
                    brojevi(j + 1) = pom
                End If
            Next
        Next

        For Each broj As Integer In brojevi
            Console.WriteLine(broj)
        Next
    End Sub

End Module
