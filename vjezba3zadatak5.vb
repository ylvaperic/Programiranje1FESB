'Korisnik unosi prirodni broj. Provjerite unos i ispišite odgovarajući poruku ako uneseni
'broj nije prirodni. Ispišite znamenke unesenog broja jednu ispod druge, počevši od one
's najmanjom vrijednosti


Imports System

Module Program
    Sub Main(args As String())
        Dim broj As Integer
        Dim ostatak, temp As Integer

        Console.WriteLine("Unesite neki broj")
        broj = Console.ReadLine
        If (broj < 0) AndAlso (broj Mod 1 <> 0) Then
            Console.WriteLine("Uneseni broj nije prirodan. Pokušajte ponovo.")
        Else
            While broj <> 0
                ostatak = broj Mod 10
                Console.WriteLine("{0}", ostatak)
                broj = broj \ 10
            End While
        End If
    End Sub
End Module
