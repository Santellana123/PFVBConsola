Public Class MergeSort
    Public Shared Sub OrdenarMerge(ByRef array As Integer())
        If array Is Nothing OrElse array.Length <= 1 Then
            Return
        End If

        ' Dividir el array en dos mitades
        Dim medio As Integer = array.Length \ 2
        Dim izquierda(medio - 1) As Integer
        Dim derecha(array.Length - medio - 1) As Integer

        array.Copy(array, 0, izquierda, 0, medio)
        array.Copy(array, medio, derecha, 0, array.Length - medio)

        ' Recursivamente ordenar las dos mitades
        OrdenarMerge(izquierda)
        OrdenarMerge(derecha)

        ' Combinar las mitades ordenadas
        Combinar(array, izquierda, derecha)
    End Sub

    Private Shared Sub Combinar(array As Integer(), izquierda As Integer(), derecha As Integer())
        Dim i As Integer = 0, j As Integer = 0, k As Integer = 0

        While i < izquierda.Length AndAlso j < derecha.Length
            If izquierda(i) <= derecha(j) Then
                array(k) = izquierda(i)
                i += 1
            Else
                array(k) = derecha(j)
                j += 1
            End If
            k += 1
        End While

        While i < izquierda.Length
            array(k) = izquierda(i)
            i += 1
            k += 1
        End While

        While j < derecha.Length
            array(k) = derecha(j)
            j += 1
            k += 1
        End While
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
