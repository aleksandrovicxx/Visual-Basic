Module Module1

    Sub Main()
        Dim ime As String = "imeimeime"
        Dim password As String = "sifrasifra"
        Dim unetoIme As String
        Dim unetiPass
        Dim brojac As Integer = 0
        Do
            Console.WriteLine("Unesite ime i lozinku")
            Console.WriteLine("Preostali broj pokusaja: ")
            If brojac = 3 Then

                Exit Do
            End If
            brojac = brojac + 1
            unetoIme = Console.ReadLine()
            unetiPass = Console.ReadLine()
        Loop Until unetoIme = ime And unetiPass = password

    End Sub

End Module
