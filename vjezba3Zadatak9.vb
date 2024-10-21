'Prebrojite koliko brojeva unutar zadanog raspona (koje unosi korisnik putem konzole) ima
'znamenku jedinice vrijednosti 9

Imports System

Module Program
    Sub Main(args As String())
        Dim n, brojevi As Integer
        Dim i As Integer = 0
        Dim brojac As Integer = 0
        Console.WriteLine("Unesite raspon brojeva")
        n = Console.ReadLine()
        Console.WriteLine("Unesi brojeve")
        For i = 1 To n
            brojevi = Console.ReadLine()
            If brojevi Mod 10 = 9 Then
                brojac = brojac + 1
            End If
        Next
        Console.WriteLine(" {0} je brojeva koji imaju znamenku jedinice 9", brojac)
    End Sub
End Module
