Module Module1

    Sub Main()
        Dim ime As String = "imeimeime"
        Dim password As String = "sifrasifra"
        Dim unetoIme As String
        Dim unetiPass
        Dim brojac As Integer = 0
        Dim odgovor As String
        Do
            If Not brojac = 0 Then
                Console.WriteLine("Da li zelite ponovni pokusaj? (Y/N)")
                odgovor = Console.ReadLine()
                If odgovor = "N" Or odgovor = "n" Then
                    Exit Do
                End If
            End If
            If brojac = 3 Then
                Console.WriteLine("Prekoracili ste broj pokusaja")
                Exit Do
            End If
            Console.WriteLine("Unesite ime i lozinku")
            Console.WriteLine($"Preostali broj pokusaja: {3 - brojac}")
            brojac = brojac + 1
            unetoIme = Console.ReadLine()
            unetiPass = Console.ReadLine()
        Loop Until unetoIme = ime And unetiPass = password

    End Sub

End Module
