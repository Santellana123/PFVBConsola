Public Class Pila
    Inherits EstructuraBase

    Private pila As New Stack(Of Integer)()

    Public Overrides Sub MostrarFunciones()
        Console.WriteLine("1. Apilar")
        Console.WriteLine("2. Desapilar")
    End Sub

    Public Sub Apilar(valor As Integer)
        pila.Push(valor)
    End Sub

    Public Sub Desapilar()
        If pila.Count > 0 Then
            Dim valorDesapilado As Integer = pila.Pop()
            Console.WriteLine($"Elemento desapilado: {valorDesapilado}")
        Else
            Console.WriteLine("La pila está vacía.")
        End If
    End Sub

    Public Sub MostrarPila()
        For Each elemento As Integer In pila
            Console.Write($"{elemento} ")
        Next
        Console.WriteLine()
    End Sub
End Class
