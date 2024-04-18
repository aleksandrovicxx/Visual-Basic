Module Module1

    Sub Main()
        Dim broj As Integer = 1
        Console.WriteLine("Brojevi od 0 do 10 bez 4")
        While broj <= 10
            If broj = 4 Then
                broj = broj + 1
                Continue While
            End If
            Console.Write($"{broj}")
            broj = broj + 1
        End While
        Console.WriteLine()
    End Sub

End Module
