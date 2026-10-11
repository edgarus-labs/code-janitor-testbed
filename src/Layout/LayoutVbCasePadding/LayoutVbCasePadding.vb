Module Program
    Function Describe(value As Integer) As String
        Select Case value
            Case 1
                Return "one"
            Case 2
                Return "two"
            Case Else
                Return "many"
        End Select
    End Function
End Module
