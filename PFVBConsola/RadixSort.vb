Public Class RadixSort
    Private Shared Function ObtenerDigito(num As Integer, posicion As Integer) As Integer
        For i As Integer = 0 To posicion - 1
            num \= 10
        Next
        Return num Mod 10
    End Function

    ' Función para encontrar el número de dígitos en el número más grande
    Private Shared Function NumeroDeDigitos(num As Integer) As Integer
        Dim count As Integer = 0
        While num > 0
            num \= 10
            count += 1
        End While
        Return count
    End Function

    ' Función principal para ordenar utilizando Radix Sort
    Public Shared Sub OrdenarRadix(ByRef array As Integer())
        If array Is Nothing OrElse array.Length <= 1 Then
            Return
        End If

        Dim max As Integer = array.Max()
        Dim numDigitos As Integer = NumeroDeDigitos(max)

        ' Aplicar Radix Sort para cada posición de dígito
        For posicion As Integer = 0 To numDigitos - 1
            ' Crear buckets para cada dígito (0-9)
            Dim buckets(9) As List(Of Integer)
            For i As Integer = 0 To 9
                buckets(i) = New List(Of Integer)()
            Next

            ' Colocar elementos en los buckets según el dígito en la posición actual
            For Each num As Integer In array
                Dim digito As Integer = ObtenerDigito(num, posicion)
                buckets(digito).Add(num)
            Next

            ' Reconstruir el array ordenado a partir de los buckets
            Dim index As Integer = 0
            For i As Integer = 0 To 9
                For Each num As Integer In buckets(i)
                    array(index) = num
                    index += 1
                Next
            Next
        Next
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
