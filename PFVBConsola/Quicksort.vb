Public Class Quicksort
    Public Shared Sub OrdenarQuick(ByRef array As Integer())
        If array Is Nothing OrElse array.Length <= 1 Then
            Return
        End If

        QuicksortRecursivo(array, 0, array.Length - 1)
    End Sub

    ' Función recursiva para Quicksort
    Private Shared Sub QuicksortRecursivo(ByRef array As Integer(), inicio As Integer, fin As Integer)
        If inicio < fin Then
            ' Obtener el índice de partición, array(p) ahora está en su posición correcta
            Dim indiceParticion As Integer = Particionar(array, inicio, fin)

            ' Ordenar los elementos antes y después de la partición
            QuicksortRecursivo(array, inicio, indiceParticion - 1)
            QuicksortRecursivo(array, indiceParticion + 1, fin)
        End If
    End Sub

    ' Función para particionar el array y devolver el índice de la posición del pivote
    Private Shared Function Particionar(ByRef array As Integer(), inicio As Integer, fin As Integer) As Integer
        Dim pivote As Integer = array(fin)
        Dim i As Integer = inicio - 1

        For j As Integer = inicio To fin - 1
            ' Si el elemento actual es menor o igual al pivote
            If array(j) <= pivote Then
                i += 1

                ' Intercambiar array(i) y array(j)
                Dim temp As Integer = array(i)
                array(i) = array(j)
                array(j) = temp
            End If
        Next

        ' Intercambiar array(i+1) y array(fin) (poner el pivote en su posición correcta)
        Dim temp2 As Integer = array(i + 1)
        array(i + 1) = array(fin)
        array(fin) = temp2

        ' Devolver el índice del pivote
        Return i + 1
    End Function

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
