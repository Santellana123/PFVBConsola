Public Class CountingSort
    Public Shared Sub OrdenarCounting(ByRef array As Integer())
        If array Is Nothing OrElse array.Length = 0 Then
            Return
        End If

        Dim max As Integer = array.Max()
        Dim min As Integer = array.Min()
        Dim range As Integer = max - min + 1

        ' Inicializar el arreglo de conteo
        Dim conteo(range - 1) As Integer
        Dim resultado(array.Length - 1) As Integer

        ' Contar la frecuencia de cada elemento
        For i As Integer = 0 To array.Length - 1
            conteo(array(i) - min) += 1
        Next

        ' Calcular las posiciones finales de los elementos en el resultado
        For i As Integer = 1 To range - 1
            conteo(i) += conteo(i - 1)
        Next

        ' Construir el arreglo ordenado
        For i As Integer = array.Length - 1 To 0 Step -1
            resultado(conteo(array(i) - min) - 1) = array(i)
            conteo(array(i) - min) -= 1
        Next

        ' Copiar el resultado al arreglo original
        For i As Integer = 0 To array.Length - 1
            array(i) = resultado(i)
        Next
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
