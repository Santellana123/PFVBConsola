Public Class Bucket_sort
    Public Shared Sub OrdenarBucket(ByRef array As Integer())
        If array Is Nothing OrElse array.Length = 0 Then
            Return
        End If

        Dim max As Integer = array.Max()
        Dim min As Integer = array.Min()
        Dim range As Integer = max - min + 1

        ' Crear buckets
        Dim buckets(range - 1) As List(Of Integer)
        For i As Integer = 0 To range - 1
            buckets(i) = New List(Of Integer)()
        Next

        ' Colocar elementos en los buckets
        For i As Integer = 0 To array.Length - 1
            buckets(array(i) - min).Add(array(i))
        Next

        ' Ordenar cada bucket e insertar de nuevo en el array
        Dim index As Integer = 0
        For Each bucket As List(Of Integer) In buckets
            If bucket.Count > 0 Then
                bucket.Sort()
                For Each item As Integer In bucket
                    array(index) = item
                    index += 1
                Next
            End If
        Next
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
