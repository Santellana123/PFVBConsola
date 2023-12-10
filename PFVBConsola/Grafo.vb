Public Class Grafo
    Inherits EstructuraBase

    Private vertices As Dictionary(Of String, List(Of String))

    Public Sub New()
        vertices = New Dictionary(Of String, List(Of String))()
    End Sub

    Public Overrides Sub MostrarFunciones()
        Console.WriteLine("1. Agregar vértice")
        Console.WriteLine("2. Agregar arista")
        Console.WriteLine("3. Mostrar Grafo")
        Console.WriteLine("4. Búsqueda en Profundidad (DFS)")
        Console.WriteLine("5. Búsqueda en Amplitud (BFS)")
    End Sub

    Public Sub AgregarVertice(nombreVertice As String)
        If Not vertices.ContainsKey(nombreVertice) Then
            vertices(nombreVertice) = New List(Of String)()
        Else
            Console.WriteLine($"El vértice {nombreVertice} ya existe en el grafo.")
        End If
    End Sub

    Public Sub AgregarArista(origen As String, destino As String)
        If vertices.ContainsKey(origen) AndAlso vertices.ContainsKey(destino) Then
            vertices(origen).Add(destino)
        Else
            Console.WriteLine("Al menos uno de los vértices no existe en el grafo.")
        End If
    End Sub

    Public Sub MostrarGrafo()
        For Each vertice In vertices
            Console.Write($"{vertice.Key}: ")
            Console.WriteLine(String.Join(", ", vertice.Value))
        Next
    End Sub

    Public Sub BusquedaProfundidad(inicio As String)
        Console.WriteLine("Recorrido DFS:")
        Dim visitados As New HashSet(Of String)()
        DFS(inicio, visitados)
        Console.WriteLine()
    End Sub

    Private Sub DFS(vertice As String, visitados As HashSet(Of String))
        If Not visitados.Contains(vertice) Then
            Console.Write($"{vertice} ")
            visitados.Add(vertice)

            For Each vecino In vertices(vertice)
                DFS(vecino, visitados)
            Next
        End If
    End Sub

    Public Sub BusquedaAmplitud(inicio As String)
        Console.WriteLine("Recorrido BFS:")
        Dim visitados As New HashSet(Of String)()
        Dim cola As New Queue(Of String)()

        visitados.Add(inicio)
        cola.Enqueue(inicio)

        While cola.Count > 0
            Dim actual As String = cola.Dequeue()
            Console.Write($"{actual} ")

            For Each vecino In vertices(actual)
                If Not visitados.Contains(vecino) Then
                    visitados.Add(vecino)
                    cola.Enqueue(vecino)
                End If
            Next
        End While

        Console.WriteLine()
    End Sub

End Class
