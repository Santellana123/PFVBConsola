Public Class InsertionSort
    Public Shared Sub OrdenarInsercion(ByRef array As Integer())
        Dim n As Integer = array.Length

        For i As Integer = 1 To n - 1
            Dim key As Integer = array(i)
            Dim j As Integer = i - 1

            ' Mover los elementos del array[0..i-1] que son mayores que key
            ' a una posición por delante de su posición actual
            While j >= 0 AndAlso array(j) > key
                array(j + 1) = array(j)
                j = j - 1
            End While

            array(j + 1) = key
        Next
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
