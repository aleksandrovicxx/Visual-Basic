Module Module1

    Sub Main()
        Console.WriteLine("Unesite broj bodova: ")
        Dim brojBodova As Integer = Console.ReadLine()

        Select Case brojBodova
            Case 0 To 50
                Console.WriteLine("Ocena 5")
            Case 51 To 60
                Console.WriteLine("Ocena 6")
            Case 61 To 70
                Console.WriteLine("Ocena 7")
            Case 71 To 80
                Console.WriteLine("Ocena 8")
            Case 81 To 90
                Console.WriteLine("Ocena 9")
            Case 91 To 100
                Console.WriteLine("Ocena 10")
        End Select
    End Sub

End Module
