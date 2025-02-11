'header
Option Explicit On
Option Strict On
Module ArrayExamples

    Sub Main()

        MultiDimentionalArrays()

    End Sub
    Sub SimpleArrays()
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
    Sub MultiDimentionalArrays()

        Dim Students(14, 2) As Single
        Dim classes() As String = {"Math", "History", "Art"}
        Dim somethingElse(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim threeDimesionArray(,,) As Integer = {{{1}, {2}, {3}}, {{4}, {5}, {6}}, {{7}, {8}, {9}}}

        'gives three students a grade, indexes them
        Students(3, 0) = 75.43
        Students(3, 1) = 85.66
        Students(3, 2) = 94.74


        'set breakpoint here to see the grade for each student 
        Console.WriteLine()
    End Sub
End Module
