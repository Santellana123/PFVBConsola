Imports System
Imports ProyectoFinalC_Consola
Module Program
    Sub Main(args As String())
        Dim cola As New Cola()
        Dim pila As New Pila()
        Dim arbol As New Arboles()
        Dim listaEnlazada As New ListaEnlazada()
        Dim grafo As New Grafo()
        While True
            Console.WriteLine("Elija una estructura de datos:")
            Console.WriteLine("1. Cola")
            Console.WriteLine("2. Pila")
            Console.WriteLine("3. Árbol")
            Console.WriteLine("4. Lista Enlazada")
            Console.WriteLine("5. Grafo")
            Console.WriteLine("6. Algoritmos de Ordenamiento")
            Console.WriteLine("0. Salir")

            Console.Write("Ingrese su elección: ")
            Dim opcion As String = Console.ReadLine()

            Select Case opcion
                Case "1"
                    RealizarOperacionesCola(cola)
                Case "2"
                    RealizarOperacionesPila(pila)
                Case "3"
                    RealizarOperacionesArbol(arbol)
                Case "4"
                    RealizarOperacionesListaEnlazada(listaEnlazada)
                Case "5"
                    RealizarOperacionesGrafo(grafo)
                Case "6"
                    RealizarOperacionesOrdenamiento(listaEnlazada)
                Case "0"
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!")
                    Return
                Case Else
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.")
            End Select
        End While
    End Sub
    Sub MostrarFuncionesBasicas(nombreEstructura As String, estructura As EstructuraBase)
        Console.WriteLine($"Funciones básicas de {nombreEstructura}:")
        estructura.MostrarFunciones()
        Console.WriteLine()
    End Sub
    Sub RealizarOperacionesArbol(arbol As Arboles)
        While True
            Console.WriteLine("Operaciones del Árbol:")
            Console.WriteLine("1. Insertar nodo")
            Console.WriteLine("2. Eliminar nodo")
            Console.WriteLine("3. Mostrar Árbol")
            Console.WriteLine("0. Volver al menú principal")

            Console.Write("Ingrese su elección: ")
            Dim opcionArbol As String = Console.ReadLine()

            Select Case opcionArbol
                Case "1"
                    Console.Write("Ingrese el valor del nuevo nodo: ")
                    Dim valorNodo As Integer = Integer.Parse(Console.ReadLine())
                    arbol.InsertarNodo(valorNodo)
                Case "2"
                    Console.Write("Ingrese el valor del nodo a eliminar: ")
                    Dim valorEliminar As Integer = Integer.Parse(Console.ReadLine())
                    arbol.EliminarNodo(valorEliminar)
                Case "3"
                    Console.WriteLine("Árbol actual:")
                    arbol.MostrarArbol()
                Case "0"
                    Return
                Case Else
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.")
            End Select
        End While
    End Sub
    Sub RealizarOperacionesCola(Cola As Cola)
        While True
            Console.WriteLine("Operaciones de la Cola:")
            Console.WriteLine("1. Encolar")
            Console.WriteLine("2. Desencolar")
            Console.WriteLine("3. Mostrar Cola")
            Console.WriteLine("0. Volver al menú principal")

            Console.Write("Ingrese su elección: ")
            Dim opcionCola As String = Console.ReadLine()

            Select Case opcionCola
                Case "1"
                    Console.Write("Ingrese el valor a encolar: ")
                    Dim valorEncolar As Integer = Integer.Parse(Console.ReadLine())
                    Cola.Encolar(valorEncolar)
                Case "2"
                    Cola.Desencolar()
                Case "3"
                    Console.WriteLine("Cola actual:")
                    Cola.MostrarCola()
                Case "0"
                    Return
                Case Else
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.")
            End Select
        End While
    End Sub
    Sub RealizarOperacionesPila(pila As Pila)
        While True
            Console.WriteLine("Operaciones de la Pila:")
            Console.WriteLine("1. Apilar")
            Console.WriteLine("2. Desapilar")
            Console.WriteLine("3. Mostrar Pila")
            Console.WriteLine("0. Volver al menú principal")

            Console.Write("Ingrese su elección: ")
            Dim opcionPila As String = Console.ReadLine()

            Select Case opcionPila
                Case "1"
                    Console.Write("Ingrese el valor a apilar: ")
                    Dim valorApilar As Integer = Integer.Parse(Console.ReadLine())
                    pila.Apilar(valorApilar)
                Case "2"
                    pila.Desapilar()
                Case "3"
                    Console.WriteLine("Pila actual:")
                    pila.MostrarPila()
                Case "0"
                    Return
                Case Else
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.")
            End Select
        End While
    End Sub
    Sub RealizarOperacionesListaEnlazada(listaEnlazada As ListaEnlazada)
        While True
            Console.WriteLine("Operaciones de la Lista Enlazada:")
            Console.WriteLine("1. Insertar elemento")
            Console.WriteLine("2. Eliminar elemento")
            Console.WriteLine("3. Mostrar Lista Enlazada")
            Console.WriteLine("0. Volver al menú principal")

            Console.Write("Ingrese su elección: ")
            Dim opcionLista As String = Console.ReadLine()

            Select Case opcionLista
                Case "1"
                    Console.Write("Ingrese el valor a insertar: ")
                    Dim valorInsertar As Integer = Integer.Parse(Console.ReadLine())
                    listaEnlazada.InsertarElemento(valorInsertar)
                Case "2"
                    Console.Write("Ingrese el valor a eliminar: ")
                    Dim valorEliminar As Integer = Integer.Parse(Console.ReadLine())
                    listaEnlazada.EliminarElemento(valorEliminar)
                Case "3"
                    Console.WriteLine("Lista Enlazada actual:")
                    listaEnlazada.MostrarLista()
                Case "0"
                    Return
                Case Else
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.")
            End Select
        End While
    End Sub
    Sub RealizarOperacionesGrafo(grafo As Grafo)
        While True
            Console.WriteLine("Operaciones del Grafo:")
            Console.WriteLine("1. Agregar vértice")
            Console.WriteLine("2. Agregar arista")
            Console.WriteLine("3. Mostrar Grafo")
            Console.WriteLine("0. Volver al menú principal")

            Console.Write("Ingrese su elección: ")
            Dim opcionGrafo As String = Console.ReadLine()

            Select Case opcionGrafo
                Case "1"
                    Console.Write("Ingrese el nombre del vértice a agregar: ")
                    Dim nombreVertice As String = Console.ReadLine()
                    grafo.AgregarVertice(nombreVertice)
                Case "2"
                    Console.Write("Ingrese el nombre del vértice de origen: ")
                    Dim origen As String = Console.ReadLine()
                    Console.Write("Ingrese el nombre del vértice de destino: ")
                    Dim destino As String = Console.ReadLine()
                    grafo.AgregarArista(origen, destino)
                Case "3"
                    Console.WriteLine("Grafo actual:")
                    grafo.MostrarGrafo()
                Case "4"
                    Console.Write("Ingrese el vértice de inicio para DFS: ")
                    Dim inicioDFS As String = Console.ReadLine()
                    grafo.BusquedaProfundidad(inicioDFS)
                Case "5"
                    Console.Write("Ingrese el vértice de inicio para BFS: ")
                    Dim inicioBFS As String = Console.ReadLine()
                    grafo.BusquedaAmplitud(inicioBFS)
                Case "0"
                    Return
                Case Else
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.")
            End Select
        End While
    End Sub
    Sub RealizarOperacionesOrdenamiento(listaEnlazada As ListaEnlazada)
        While True
            Console.WriteLine("Algoritmos de Ordenamiento:")
            Console.WriteLine("1. Bubblesort")
            Console.WriteLine("2. Cocktail sort")
            Console.WriteLine("3. Insertion sort")
            Console.WriteLine("4. Bucket sort")
            Console.WriteLine("5. Counting sort")
            Console.WriteLine("6. Merge sort")
            Console.WriteLine("7. Binary tree sort")
            Console.WriteLine("8. Radix sort")
            Console.WriteLine("9. Shell sort")
            Console.WriteLine("10. Selection sort")
            Console.WriteLine("11. Heapsort")
            Console.WriteLine("12. Quicksort")
            Console.WriteLine("0. Volver al menú principal")

            Console.Write("Ingrese su elección: ")
            Dim opcionOrdenamiento As String = Console.ReadLine()

            Select Case opcionOrdenamiento
                Case "1"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputBubblesort As String = Console.ReadLine()
                    Dim valoresBubblesort As Integer() = Array.ConvertAll(inputBubblesort.Split(" "), Function(s) Integer.Parse(s))
                    Bubblesort.OrdenarBurbuja(valoresBubblesort)
                Case "2"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputCocktailSort As String = Console.ReadLine()
                    Dim valoresCocktailSort As Integer() = Array.ConvertAll(inputCocktailSort.Split(" "), Function(s) Integer.Parse(s))
                    Cocktail_sort.OrdenarCocktail(valoresCocktailSort)
                Case "3"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputInsertionSort As String = Console.ReadLine()
                    Dim valoresInsertionSort As Integer() = Array.ConvertAll(inputInsertionSort.Split(" "), Function(s) Integer.Parse(s))
                    InsertionSort.OrdenarInsercion(valoresInsertionSort)
                Case "4"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputBucketSort As String = Console.ReadLine()
                    Dim valoresBucketSort As Integer() = Array.ConvertAll(inputBucketSort.Split(" "), Function(s) Integer.Parse(s))
                    Bucket_sort.OrdenarBucket(valoresBucketSort)
                Case "5"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputCountingSort As String = Console.ReadLine()
                    Dim valoresCountingSort As Integer() = Array.ConvertAll(inputCountingSort.Split(" "), Function(s) Integer.Parse(s))
                    CountingSort.OrdenarCounting(valoresCountingSort)
                Case "6"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputMergeSort As String = Console.ReadLine()
                    Dim valoresMergeSort As Integer() = Array.ConvertAll(inputMergeSort.Split(" "), Function(s) Integer.Parse(s))
                    MergeSort.OrdenarMerge(valoresMergeSort)
                Case "7"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputBinaryTreeSort As String = Console.ReadLine()
                    Dim valoresBinaryTreeSort As Integer() = Array.ConvertAll(inputBinaryTreeSort.Split(" "), Function(s) Integer.Parse(s))
                    BinaryTreeSort.OrdenarBinaryTree(valoresBinaryTreeSort)
                Case "8"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputRadixSort As String = Console.ReadLine()
                    Dim valoresRadixSort As Integer() = Array.ConvertAll(inputRadixSort.Split(" "), Function(s) Integer.Parse(s))
                    RadixSort.OrdenarRadix(valoresRadixSort)
                Case "9"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputShellSort As String = Console.ReadLine()
                    Dim valoresShellSort As Integer() = Array.ConvertAll(inputShellSort.Split(" "), Function(s) Integer.Parse(s))
                    ShellSort.OrdenarShell(valoresShellSort)
                Case "10"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputSelectionSort As String = Console.ReadLine()
                    Dim valoresSelectionSort As Integer() = Array.ConvertAll(inputSelectionSort.Split(" "), Function(s) Integer.Parse(s))
                    SelectionSort.OrdenarSeleccion(valoresSelectionSort)
                Case "11"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputHeapsort As String = Console.ReadLine()
                    Dim valoresHeapsort As Integer() = Array.ConvertAll(inputHeapsort.Split(" "), Function(s) Integer.Parse(s))
                    Heapsort.OrdenarHeap(valoresHeapsort)
                Case "12"
                    Console.Write("Ingrese los valores separados por espacios: ")
                    Dim inputQuicksort As String = Console.ReadLine()
                    Dim valoresQuicksort As Integer() = Array.ConvertAll(inputQuicksort.Split(" "), Function(s) Integer.Parse(s))
                    Quicksort.OrdenarQuick(valoresQuicksort)
                Case "0"
                    Return
                Case Else
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.")
            End Select
        End While
    End Sub
End Module
