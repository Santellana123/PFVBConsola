Public Class Arboles
    Private raiz As NodoArbol

    Public Sub MostrarFunciones()
        Console.WriteLine("1. Insertar nodo")
        Console.WriteLine("2. Eliminar nodo")
    End Sub

    Public Sub InsertarNodo(valor As Integer)
        raiz = InsertarNodoRecursivo(raiz, valor)
    End Sub

    Private Function InsertarNodoRecursivo(nodo As NodoArbol, valor As Integer) As NodoArbol
        If nodo Is Nothing Then
            Return New NodoArbol(valor)
        End If

        If valor < nodo.Valor Then
            nodo.Izquierda = InsertarNodoRecursivo(nodo.Izquierda, valor)
        ElseIf valor > nodo.Valor Then
            nodo.Derecha = InsertarNodoRecursivo(nodo.Derecha, valor)
        End If

        Return nodo
    End Function

    Public Sub EliminarNodo(valor As Integer)
        raiz = EliminarNodoRecursivo(raiz, valor)
    End Sub

    Private Function EliminarNodoRecursivo(nodo As NodoArbol, valor As Integer) As NodoArbol
        If nodo Is Nothing Then
            Return nodo
        End If

        If valor < nodo.Valor Then
            nodo.Izquierda = EliminarNodoRecursivo(nodo.Izquierda, valor)
        ElseIf valor > nodo.Valor Then
            nodo.Derecha = EliminarNodoRecursivo(nodo.Derecha, valor)
        Else
            If nodo.Izquierda Is Nothing Then
                Return nodo.Derecha
            ElseIf nodo.Derecha Is Nothing Then
                Return nodo.Izquierda
            End If

            nodo.Valor = ObtenerMinimoValor(nodo.Derecha)
            nodo.Derecha = EliminarNodoRecursivo(nodo.Derecha, nodo.Valor)
        End If

        Return nodo
    End Function

    Private Function ObtenerMinimoValor(nodo As NodoArbol) As Integer
        Dim minimoValor As Integer = nodo.Valor
        While nodo.Izquierda IsNot Nothing
            minimoValor = nodo.Izquierda.Valor
            nodo = nodo.Izquierda
        End While
        Return minimoValor
    End Function

    Public Sub MostrarArbol()
        MostrarArbolRecursivo(raiz, 0)
    End Sub

    Private Sub MostrarArbolRecursivo(nodo As NodoArbol, nivel As Integer)
        If nodo IsNot Nothing Then
            MostrarArbolRecursivo(nodo.Derecha, nivel + 1)

            For i As Integer = 0 To nivel - 1
                Console.Write("   ")
            Next

            Console.WriteLine(nodo.Valor)

            MostrarArbolRecursivo(nodo.Izquierda, nivel + 1)
        End If
    End Sub

    Private Class NodoArbol
        Public Property Valor As Integer
        Public Property Izquierda As NodoArbol
        Public Property Derecha As NodoArbol

        Public Sub New(valor As Integer)
            Me.Valor = valor
            Izquierda = Nothing
            Derecha = Nothing
        End Sub
    End Class
End Class
