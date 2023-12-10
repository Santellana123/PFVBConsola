Public Class Bubblesort
    Public Shared Sub OrdenarBurbuja(ByRef array As Integer())
        Dim n As Integer = array.Length
        Dim swapped As Boolean

        Do
            swapped = False

            For i As Integer = 1 To n - 1
                If array(i - 1) > array(i) Then
                    ' Intercambiar elementos
                    Dim temp As Integer = array(i - 1)
                    array(i - 1) = array(i)
                    array(i) = temp

                    swapped = True
                End If
            Next

            ' Después de cada pasada, el elemento no ordenado más grande está al final
            n -= 1
        Loop While swapped

        ' Mostrar el arreglo ordenado
        Console.WriteLine("Arreglo ordenado con Bubblesort:")
        MostrarArreglo(array)
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
