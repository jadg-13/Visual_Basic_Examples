Public Class Factorial

    'Made by: José A. Durán G. (jadg13)

    Public Function CalculateByFor(ByVal number As Integer) As Integer
        Dim result As Integer = 1
        For i As Integer = 1 To number
            result *= i
        Next
        Return result
    End Function

    Public Function CalculateByWhile(ByVal number As Integer) As Integer
        Dim result As Integer = 1
        Dim i As Integer = 1
        While i <= number
            result *= i
            i += 1
        End While
        Return result
    End Function

    Public Function CalculateByDoWhile(ByVal number As Integer) As Integer
        Dim result As Integer = 1
        Dim i As Integer = 1
        Do While i <= number
            result *= i
            i += 1
        Loop
        Return result
    End Function

    Public Function CalculateByRecursion(ByVal number As Integer) As Integer
        If number = 0 Then
            Return 1
        Else
            Return number * CalculateByRecursion(number - 1)
        End If
    End Function

End Class
