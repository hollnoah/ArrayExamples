'header
Option Explicit On
Option Strict On
Option Compare Text
Module ArrayExamples

    Sub Main()
        'arrays are cool
        Dim fruits(5) As String
        Dim names() As String = {"john", "paul", "ringo", "jeff"}

        'Dim beanCounts As New Integer() {2343, 232, 434, 54546}

        fruits(0) = "banana"
        fruits(3) = "grape"
        'fruits(6) = "apple"

        'For i = 0 To 10

        'Next

        For i = LBound(names) To UBound(names)
            Console.WriteLine(names(i))

        Next


    End Sub

End Module
