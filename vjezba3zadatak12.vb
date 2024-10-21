'Učitavati troznamenkaste brojeve dok je zbroj znamenki paran. Ispisati koliko je brojeva učitano.

Imports System

Module Program
    Sub Main(args As String())
        Dim brojevi, ostatak As Integer
        Dim zbrojznamenki As Integer = 0
        Dim suma As Integer = 0
        Do
            brojevi = Console.ReadLine()
            suma = 0
            If brojevi < 100 And brojevi > 999 Then
                Console.WriteLine("Pokušajte ponovo")
            Else
                ostatak = brojevi Mod 10
                zbrojznamenki += ostatak
                brojevi = brojevi / 10
            End If
        Loop While zbrojznamenki Mod 2 = 0
    End Sub
End Module
