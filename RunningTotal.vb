﻿Option Strict On
Option Explicit On
Option Compare Text
Imports System.Linq.Expressions

Module RunningTotal

    Sub Main()
        Dim userInput As String
        Dim runningTotal As Decimal
        Const TAXRATE As Decimal = 0.06D
        Dim taxAmount As Decimal
        Dim badData As Boolean = True

        Do
            Console.Clear()
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
                        runningTotal += CDec(userInput)
                        badData = False
                    Catch ex As Exception
                        'prompt usr to give good data
                        Console.WriteLine()
                        Console.ReadLine('Please enter a vnumber')

                        badData = True
                    End Try
                ElseIf userInput = "2" Then
                    Console.WriteLine("Tax: " & runningTotal * TAXRATE)
                Else

                End If
            Loop While badData


        Try
                'runningTotal = runningTotal + CInt(userInput)
                runningTotal += CInt(userInput)

            Catch ex As Exception
                'prompt usr to give good data
            End Try

            Console.WriteLine("Total: " & runningTotal)
            Console.WriteLine("Tax: " & runningTotal * TAXRATE)
        End While
    End Sub

End Module
