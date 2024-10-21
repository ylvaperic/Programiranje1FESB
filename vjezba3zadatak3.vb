' Učitavajte brojeve s konzole sve dok se upisuju neparni brojevi. Izračunajte aritmetičku sredinu
'uzimajući samo brojeve veće od 10 a manje od 50 u izračun


Imports System

Module Program
    Sub Main(args As String())
        Dim brojevi, suma As Double
        Dim i As Integer
        suma = 0
        Do
            brojevi = Console.ReadLine()
            If brojevi > 10 And brojevi < 50 Then
                suma = suma + brojevi
                i = i + 1
            End If
        Loop While (brojevi Mod 2 = 1)

        Console.WriteLine("Aritmetička sredina iznosi: {0} ", suma / i)


    End Sub
End Module
