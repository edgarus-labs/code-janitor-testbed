Module Program
    Sub Check(value As Integer)
        If value > 0 Then
            Console.WriteLine("positive")

        Else
            Console.WriteLine("other")
        End If
        Try
            Console.WriteLine(value)

        Catch ex As Exception
            Console.WriteLine(ex.Message)

        Finally
            Console.WriteLine("done")
        End Try
    End Sub
End Module
