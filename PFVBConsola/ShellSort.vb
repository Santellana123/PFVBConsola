Public Class ShellSort
    Public Shared Sub OrdenarShell(ByRef array As Integer())
        If array Is Nothing OrElse array.Length <= 1 Then
            Return
        End If

        Dim n As Integer = array.Length
        Dim brecha As Integer = n \ 2

        While brecha > 0
            For i As Integer = brecha To n - 1
                Dim temp As Integer = array(i)
                Dim j As Integer = i

                ' Realizar inserción directa en el subarray
                While j >= brecha AndAlso array(j - brecha) > temp
                    array(j) = array(j - brecha)
                    j -= brecha
                End While

                array(j) = temp
            Next

            ' Reducir la brecha
            brecha \= 2
        End While
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
