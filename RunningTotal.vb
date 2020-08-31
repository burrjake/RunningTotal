Option Strict On
Option Explicit On

Module RunningTotal

    Sub Main()
        Dim userInput As String
        Dim runningTotal As Integer
        Const TAXRATE As Decimal = 0.06D

        Console.WriteLine("Please select an option.")
        Console.WriteLine("1. Add item")
        Console.WriteLine("2. Calculate tax")

        'User Choice
        userInput = Console.ReadLine()


        While userInput <> "q"
            userInput = Console.ReadLine()

            If userInput = "1" Then




                Try
                    'runningTotal = runningTotal + CInt(userInput)
                    runningTotal += CInt(userInput)

                Catch ex As Exception
                    'prompt usr to give good data
                End Try
            ElseIf userInput = "2" Then
                Console.WriteLine("Tax: " runningTotal * TAXRATE)
            Else

            End If



            Try
                'runningTotal = runningTotal + CInt(userInput)
                runningTotal += CInt(userInput)

            Catch ex As Exception
                'prompt usr to give good data
            End Try

            Console.WriteLine("Total: " & runningTotal)
            Console.WriteLine("Tax: " runningTotal * TAXRATE)
        End While
    End Sub

End Module
