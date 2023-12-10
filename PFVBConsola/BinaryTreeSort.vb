Public Class BinaryTreeSort
    Private Class Nodo
        Public Valor As Integer
        Public Izquierda, Derecha As Nodo

        Public Sub New(valor As Integer)
            Me.Valor = valor
            Izquierda = Nothing
            Derecha = Nothing
        End Sub
    End Class

    ' Función para insertar un valor en el árbol binario
    Private Shared Function Insertar(nodo As Nodo, valor As Integer) As Nodo
        If nodo Is Nothing Then
            Return New Nodo(valor)
        End If

        If valor < nodo.Valor Then
            nodo.Izquierda = Insertar(nodo.Izquierda, valor)
        ElseIf valor > nodo.Valor Then
            nodo.Derecha = Insertar(nodo.Derecha, valor)
        End If

        Return nodo
    End Function

    ' Función para realizar un recorrido en orden del árbol y almacenar los elementos en el array
    Private Shared Sub RecorridoEnOrden(nodo As Nodo, ByRef array As Integer(), ByRef index As Integer)
        If nodo IsNot Nothing Then
            RecorridoEnOrden(nodo.Izquierda, array, index)
            array(index) = nodo.Valor
            index += 1
            RecorridoEnOrden(nodo.Derecha, array, index)
        End If
    End Sub

    ' Función principal para ordenar utilizando Binary Tree Sort
    Public Shared Sub OrdenarBinaryTree(ByRef array As Integer())
        If array Is Nothing OrElse array.Length <= 1 Then
            Return
        End If

        Dim raiz As Nodo = Nothing

        ' Insertar todos los elementos en el árbol binario
        For Each valor As Integer In array
            raiz = Insertar(raiz, valor)
        Next

        ' Realizar un recorrido en orden del árbol y almacenar los elementos en el array
        Dim index As Integer = 0
        RecorridoEnOrden(raiz, array, index)
    End Sub

    Public Shared Sub MostrarArreglo(array As Integer())
        For Each num As Integer In array
            Console.Write($"{num} ")
        Next

        Console.WriteLine()
    End Sub
End Class
