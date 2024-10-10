using System.Runtime.InteropServices;

namespace Programming101CS.Syllabus {
    internal class Sets {
        unsafe public static void Information() {
            Console.WriteLine("- Los conjuntos de datos nos permiten trabajar con múltiples elementos del mismo tipo");
            Console.WriteLine("- En función del método de acceso, tipo de inserción, tipo de retirada, consulta, ... deberemos usar un conjunto o otro");
            Console.WriteLine("- Deberemos evaluar en cada situación que tipo de conjunto es más oportuno");

            // Arrays
            Console.WriteLine("\nArrays:");
            var intArray = new int[10];
            intArray[0] = 10;
            intArray[1] = 9;
            intArray[9] = 1;

            var text = "Conjuntos";
            fixed (int* firstIntArrayItem = &intArray[0]) {
                Console.WriteLine("- Conjunto de datos de tamaño fijo definido en la declaración de la variable");
                Console.WriteLine("- Acceso directo a la posición física utilizando la posición en memoria de la variable más un offset según el índice");
                Console.WriteLine($"- Los string se indexan como una array de chars. text={text}, text[0]={text[0]}, text[4]={text[4]}");
                Console.WriteLine($"- intArray[0]: {(int)(firstIntArrayItem + 0):X16} ({*(firstIntArrayItem + 0)}), intArray[1]: {(int)(firstIntArrayItem + 1):X16} ({*(firstIntArrayItem + 1)}), ..., intArray[9]: {(int)(firstIntArrayItem + 9):X16} ({*(firstIntArrayItem + 9)})");
                Console.WriteLine($"- Aumento de direcciones: {(int)(firstIntArrayItem + 1) - (int)(firstIntArrayItem + 0)} bytes que se corresponde con sizeof(int) ({sizeof(int)} bytes)");
            }

            // Listas
            Console.WriteLine("\nListas:");
            var intList = new List<int>();
            intList.Add(10);
            intList.Add(1);
            intList.Insert(1, 9);
            GCHandle firstHandle = GCHandle.Alloc(intList[0], GCHandleType.Pinned);
            GCHandle secondHandle = GCHandle.Alloc(intList[1], GCHandleType.Pinned);
            GCHandle thirdHandle = GCHandle.Alloc(intList[2], GCHandleType.Pinned);
            IntPtr firstListItem = GCHandle.ToIntPtr(firstHandle);
            IntPtr secondListItem = GCHandle.ToIntPtr(secondHandle);
            IntPtr thirdListItem = GCHandle.ToIntPtr(thirdHandle);
            Console.WriteLine("- Conjunto de datos de tamaño variable con inserción indexada");
            Console.WriteLine("- Acceso indirecto a las variables utilizando la propia indexación de la lista");
            Console.WriteLine($"- intList: {(int)&intList:X16}, intList[0]: {firstListItem:X16} ({intList[0]}), intList[1]: {secondListItem:X16} ({intList[1]}), intList[2]: {thirdListItem:X16} ({intList[2]})");
            Console.WriteLine($"- El elemento 2 es el primero en memoria dado que los elementos 0 y 1 se han reubicado.");
            Console.WriteLine($"- Diferencia [1]-[2]: {secondListItem - thirdListItem} bytes (posición en memoria [1] > [2]), diferencia [0]-[1]: {firstListItem - secondListItem} bytes (posición en memoria [0] > [1])");
            Console.WriteLine($"- Orden de acceso: [0], [1], [2]. Orden en memoria: [2], [1], [0]");

            // Colas
            Console.WriteLine("\nColas (FIFO):");
            var intQueue = new Queue<int>();
            intQueue.Enqueue(10);
            intQueue.Enqueue(9);
            Console.WriteLine("- Conjunto de datos de tamaño variable que sigue esquema First In - First Out (FIFO)");
            Console.WriteLine("- Acceso indirecto a las variables utilizando la propia indexación de la cola");
            Console.WriteLine("- Estructura habitual para el procesado de instrucciones según el orden de inserción");
            Console.WriteLine($"- Datos: [10, 9] Primer dequeue: {intQueue.Dequeue()}, Segundo dequeue: {intQueue.Dequeue()}");

            // Pilas
            Console.WriteLine("\nPilas (LIFO):");
            var intStack = new Stack<int>();
            intStack.Push(10);
            intStack.Push(9);
            Console.WriteLine("- Conjunto de datos de tamaño variable que sigue esquema Last In - First Out (LIFO)");
            Console.WriteLine("- Acceso indirecto a las variables utilizando la propia indexación de la pila");
            Console.WriteLine("- Estructura tipìca para resolver el puzzle de la Torre de Hanoi");
            Console.WriteLine($"- Datos: [10, 9] Primer pop: {intStack.Pop()}, Segundo pop: {intStack.Pop()}");

            // Diccionarios/Mapas
            Console.WriteLine("\nDiccionarios:");
            var intDic = new Dictionary<int, string>();
            intDic.Add(1, "Mundo");
            intDic.Add(4, "Hola");
            Console.WriteLine("- Conjunto de datos de tamaño variable con inserción por key-value");
            Console.WriteLine("- Acceso directo a las variables utilizando la key insertada");
            Console.WriteLine("- Estructura habitual para multiples consultas sobre el mismo set de datos");
            Console.WriteLine($"- Datos: <1, ' Mundo'>, <4, 'Hola'>. <4>: {intDic[4]}, <1>: {intDic[1]}");

            // Hashset
            Console.WriteLine("\nHashset:");
            var intHashset = new HashSet<int>();
            intHashset.Add(1);
            intHashset.Add(5);
            intHashset.Add(1);
            intHashset.Add(2);
            Console.WriteLine("- Conjunto de datos de tamaño variable con inserción única basada en la igualdad del tipo");
            Console.WriteLine("- No es usado para acceder a la información guardada directamente");
            Console.WriteLine("- Estructura habitual para saber si el conjunto contiene ciertos valores con rapidez");
            Console.WriteLine($"- Insertado: 1, 5, 1, 2. Tamaño: {intHashset.Count} elementos, contiene 1: {intHashset.Contains(1)}, contiene 3: {intHashset.Contains(3)}");
        }
    }
}
