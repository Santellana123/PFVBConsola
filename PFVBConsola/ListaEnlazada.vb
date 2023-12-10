Public Class ListaEnlazada
    Inherits EstructuraBase

    Private inicio As NodoListaEnlazada

    Public Overrides Sub MostrarFunciones()
        Console.WriteLine("1. Insertar elemento")
        Console.WriteLine("2. Eliminar elemento")
        Console.WriteLine("3. Mostrar Lista Enlazada")
    End Sub

    Public Sub InsertarElemento(valor As Integer)
        Dim nuevoNodo As New NodoListaEnlazada(valor)
        If inicio Is Nothing Then
            inicio = nuevoNodo
        Else
            Dim actual As NodoListaEnlazada = inicio
            While actual.Siguiente IsNot Nothing
                actual = actual.Siguiente
            End While
            actual.Siguiente = nuevoNodo
        End If
    End Sub

    Public Sub EliminarElemento(valor As Integer)
        If inicio Is Nothing Then
            Console.WriteLine("La lista está vacía.")
            Return
        End If

        If inicio.Valor = valor Then
            inicio = inicio.Siguiente
            Return
        End If

        Dim actual As NodoListaEnlazada = inicio
        While actual.Siguiente IsNot Nothing AndAlso actual.Siguiente.Valor <> valor
            actual = actual.Siguiente
        End While

        If actual.Siguiente IsNot Nothing Then
            actual.Siguiente = actual.Siguiente.Siguiente
        Else
            Console.WriteLine($"El elemento {valor} no se encuentra en la lista.")
        End If
    End Sub

    Public Sub MostrarLista()
        Dim actual As NodoListaEnlazada = inicio
        While actual IsNot Nothing
            Console.Write($"{actual.Valor} ")
            actual = actual.Siguiente
        End While
        Console.WriteLine()
    End Sub

    Private Class NodoListaEnlazada
        Public ReadOnly Property Valor As Integer
        Public Property Siguiente As NodoListaEnlazada

        Public Sub New(valor As Integer)
            Me.Valor = valor
            Siguiente = Nothing
        End Sub
    End Class
End Class
