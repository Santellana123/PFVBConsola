Public Class Cocktail_sort
    Public Shared Sub OrdenarCocktail(ByRef array As Integer())
        Dim swapped As Boolean
        Dim start As Integer = 0
        Dim [end] As Integer = array.Length

        Do
            ' Fase ascendente (de izquierda a derecha)
            swapped = False
            For i As Integer = start To [end] - 2
                If array(i) > array(i + 1) Then
                    ' Intercambiar elementos
                    Dim temp As Integer = array(i)
                    array(i) = array(i + 1)
                    array(i + 1) = temp

                    swapped = True
                End If
            Next

            If Not swapped Then
                Exit Do
            End If

            ' Disminuir el rango ya que el último elemento está en su posición correcta
            [end] -= 1

            ' Fase descendente (de derecha a izquierda)
            swapped = False
            For i As Integer = [end] - 2 To start Step -1
                If array(i) > array(i + 1) Then
                    ' Intercambiar elementos
                    Dim temp As Integer = array(i)
                    array(i) = array(i + 1)
                    array(i + 1) = temp

                    swapped = True
                End If
            Next

            ' Aumentar el rango ya que el primer elemento está en su posición correcta
            start += 1
        Loop While swapped
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
