Public Class Heapsort
    Public Shared Sub OrdenarHeap(ByRef array As Integer())
        If array Is Nothing OrElse array.Length <= 1 Then
            Return
        End If

        Dim n As Integer = array.Length

        ' Construir el heap (montículo)
        For i As Integer = n \ 2 - 1 To 0 Step -1
            Heapify(array, n, i)
        Next

        ' Extraer elementos uno por uno desde el heap
        For i As Integer = n - 1 To 1 Step -1
            ' Intercambiar la raíz (elemento máximo) con el último elemento no ordenado
            Dim temp As Integer = array(0)
            array(0) = array(i)
            array(i) = temp

            ' Llamar a Heapify para reconstruir el heap en el subarray reducido
            Heapify(array, i, 0)
        Next
    End Sub

    ' Función para convertir un subárbol con raíz en el índice 'i' en un montículo (heap)
    Private Shared Sub Heapify(array As Integer(), n As Integer, i As Integer)
        Dim mayor As Integer = i          ' Inicializar el mayor como la raíz
        Dim izquierda As Integer = 2 * i + 1  ' índice del hijo izquierdo
        Dim derecha As Integer = 2 * i + 2     ' índice del hijo derecho

        ' Si el hijo izquierdo es mayor que la raíz
        If izquierda < n AndAlso array(izquierda) > array(mayor) Then
            mayor = izquierda
        End If

        ' Si el hijo derecho es mayor que la raíz
        If derecha < n AndAlso array(derecha) > array(mayor) Then
            mayor = derecha
        End If

        ' Si el mayor no es la raíz
        If mayor <> i Then
            ' Intercambiar la raíz con el mayor
            Dim temp As Integer = array(i)
            array(i) = array(mayor)
            array(mayor) = temp

            ' Llamar recursivamente a Heapify para el subárbol afectado
            Heapify(array, n, mayor)
        End If
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
