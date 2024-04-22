Module Module1

    Sub Main()
        Dim imeStudenata() As String = {"Marko", "Darko", "Jelena", "Milica", "Sanja"}
        Dim counter = 0

        For i As Integer = imeStudenata.Length - 1 To 0 Step -1
            Console.WriteLine(imeStudenata(i))
        Next
        Console.WriteLine("-------------------------------")

        For Each ime As String In imeStudenata
            Console.WriteLine(imeStudenata(imeStudenata.Length - 1 - counter))
            'Console.WriteLine(imeStudenata.Length - 1 - counter)
            counter = counter + 1
        Next
    End Sub

End Module
