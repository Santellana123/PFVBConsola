Public Class Cola
    Inherits EstructuraBase

    Private cola As New Queue(Of Integer)()

    Public Overrides Sub MostrarFunciones()
        Console.WriteLine("1. Encolar")
        Console.WriteLine("2. Desencolar")
    End Sub

    Public Sub Encolar(valor As Integer)
        cola.Enqueue(valor)
    End Sub

    Public Sub Desencolar()
        If cola.Count > 0 Then
            Dim valorDesencolado As Integer = cola.Dequeue()
            Console.WriteLine($"Elemento desencolado: {valorDesencolado}")
        Else
            Console.WriteLine("La cola está vacía.")
        End If
    End Sub

    Public Sub MostrarCola()
        For Each elemento As Integer In cola
            Console.Write($"{elemento} ")
        Next
        Console.WriteLine()
    End Sub
End Class
