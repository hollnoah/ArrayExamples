'header
Option Explicit On
Option Strict On
Module ArrayExamples

    Sub Main()

        'MultiDimentionalArrays()
        TestRandomness()

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

    Sub TestRandomness()
        Dim beanCounter(20) As Integer

        For i = 1 To 1000000
            beanCounter(randomNumberBetween(5, 16)) += 1
        Next

        For i = LBound(beanCounter) To UBound(beanCounter)
            Console.WriteLine($"{i} hit {beanCounter(i)} times!")

        Next

    End Sub

    Function randomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        'establishes range
        temp *= max - min + 1 '+ 1 'makes range bigger by 1 to fix inclusivity max/min
        temp += min '- 1 'shifts range down so math.ceiling works
        'Return CInt(temp) 'bad randomness, has same number on min and max
        'Return CInt(Int(temp)) 'randomness okay but max not included
        Return CInt(Math.Floor(temp)) 'randomness okay but max not included
        'Return CInt(Math.Ceiling(temp)) 'randomness okay but min not included
    End Function
End Module
