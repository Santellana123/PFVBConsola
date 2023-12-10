Public Class SelectionSort
    Public Shared Sub OrdenarSeleccion(ByRef array As Integer())
        If array Is Nothing OrElse array.Length <= 1 Then
            Return
        End If

        Dim n As Integer = array.Length

        For i As Integer = 0 To n - 2
            ' Encontrar el índice del elemento mínimo en el subarray no ordenado
            Dim indiceMinimo As Integer = i
            For j As Integer = i + 1 To n - 1
                If array(j) < array(indiceMinimo) Then
                    indiceMinimo = j
                End If
            Next

            ' Intercambiar el elemento mínimo con el primer elemento no ordenado
            Dim temp As Integer = array(indiceMinimo)
            array(indiceMinimo) = array(i)
            array(i) = temp
        Next
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
