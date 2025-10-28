using Programming101CS.Syllabus.Definitions;
using System.Runtime.InteropServices;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter04_01 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(9, "Conjuntos: Conjuntos simples", GetInformation(), GetExercices());
        }

        unsafe private static string GetInformation() {
            var message = new StringBuilder();
            message.AppendLine("- Los conjuntos de datos nos permiten trabajar con múltiples elementos del mismo tipo");
            message.AppendLine("- En función del método de acceso, tipo de inserción, tipo de retirada, consulta, ... deberemos usar un conjunto o otro");
            message.AppendLine("- Deberemos evaluar en cada situación que tipo de conjunto es más oportuno");

            // Arrays
            message.AppendLine("\nArrays:");
            var intArray = new int[10];
            intArray[0] = 10;
            intArray[1] = 9;
            intArray[9] = 1;

            var text = "Conjuntos";
            fixed (int* firstIntArrayItem = &intArray[0]) {
                message.AppendLine("- Conjunto de datos de tamaño fijo definido en la declaración de la variable");
                message.AppendLine("- Acceso directo a la posición física utilizando la posición en memoria de la variable más un offset según el índice");
                message.AppendLine($"- Los string se indexan como una array de chars. text={text}, text[0]={text[0]}, text[4]={text[4]}");
                message.AppendLine($"- intArray[0]: {(int)(firstIntArrayItem + 0):X16} ({*(firstIntArrayItem + 0)}), intArray[1]: {(int)(firstIntArrayItem + 1):X16} ({*(firstIntArrayItem + 1)}), ..., intArray[9]: {(int)(firstIntArrayItem + 9):X16} ({*(firstIntArrayItem + 9)})");
                message.AppendLine($"- Aumento de direcciones: {(int)(firstIntArrayItem + 1) - (int)(firstIntArrayItem + 0)} bytes que se corresponde con sizeof(int) ({sizeof(int)} bytes)");
            }

            // Listas
            message.AppendLine("\nListas:");
            var intList = new List<int> { 10, 1 };
            intList.Insert(1, 9);
            GCHandle firstHandle = GCHandle.Alloc(intList[0], GCHandleType.Pinned);
            GCHandle secondHandle = GCHandle.Alloc(intList[1], GCHandleType.Pinned);
            GCHandle thirdHandle = GCHandle.Alloc(intList[2], GCHandleType.Pinned);
            IntPtr firstListItem = GCHandle.ToIntPtr(firstHandle);
            IntPtr secondListItem = GCHandle.ToIntPtr(secondHandle);
            IntPtr thirdListItem = GCHandle.ToIntPtr(thirdHandle);
            message.AppendLine("- Conjunto de datos de tamaño variable con inserción indexada");
            message.AppendLine("- Acceso indirecto a las variables utilizando la propia indexación de la lista");
            message.AppendLine($"- intList: {(int)&intList:X16}, intList[0]: {firstListItem:X16} ({intList[0]}), intList[1]: {secondListItem:X16} ({intList[1]}), intList[2]: {thirdListItem:X16} ({intList[2]})");
            message.AppendLine($"- El elemento 2 es el primero en memoria dado que los elementos 0 y 1 se han reubicado.");
            message.AppendLine($"- Diferencia [1]-[2]: {secondListItem - thirdListItem} bytes (posición en memoria [1] > [2]), diferencia [0]-[1]: {firstListItem - secondListItem} bytes (posición en memoria [0] > [1])");
            message.AppendLine($"- Orden de acceso: [0], [1], [2]. Orden en memoria: [2], [1], [0]");

            // Colas
            message.AppendLine("\nColas (FIFO):");
            var intQueue = new Queue<int>();
            intQueue.Enqueue(10);
            intQueue.Enqueue(9);
            message.AppendLine("- Conjunto de datos de tamaño variable que sigue esquema First In - First Out (FIFO)");
            message.AppendLine("- Acceso indirecto a las variables utilizando la propia indexación de la cola");
            message.AppendLine("- Estructura habitual para el procesado de instrucciones según el orden de inserción");
            message.AppendLine($"- Datos: [10, 9] Primer dequeue: {intQueue.Dequeue()}, Segundo dequeue: {intQueue.Dequeue()}");

            // Pilas
            message.AppendLine("\nPilas (LIFO):");
            var intStack = new Stack<int>();
            intStack.Push(10);
            intStack.Push(9);
            message.AppendLine("- Conjunto de datos de tamaño variable que sigue esquema Last In - First Out (LIFO)");
            message.AppendLine("- Acceso indirecto a las variables utilizando la propia indexación de la pila");
            message.AppendLine("- Estructura tipìca para resolver el puzzle de la Torre de Hanoi");
            message.AppendLine($"- Datos: [10, 9] Primer pop: {intStack.Pop()}, Segundo pop: {intStack.Pop()}");

            // Diccionarios/Mapas
            message.AppendLine("\nDiccionarios:");
            var intDic = new Dictionary<int, string> {
                { 1, "Mundo" },
                { 4, "Hola" }
            };
            message.AppendLine("- Conjunto de datos de tamaño variable con inserción por key-value");
            message.AppendLine("- Acceso directo a las variables utilizando la key insertada");
            message.AppendLine("- Estructura habitual para multiples consultas sobre el mismo set de datos");
            message.AppendLine($"- Datos: <1, ' Mundo'>, <4, 'Hola'>. <4>: {intDic[4]}, <1>: {intDic[1]}");

            // Hashset
            message.AppendLine("\nHashset:");
            var intHashset = new HashSet<int> { 1, 5, 1, 2 };
            message.AppendLine("- Conjunto de datos de tamaño variable con inserción única basada en la igualdad del tipo");
            message.AppendLine("- No es usado para acceder a la información guardada directamente");
            message.AppendLine("- Estructura habitual para saber si el conjunto contiene ciertos valores con rapidez");
            message.AppendLine($"- Insertado: 1, 5, 1, 2. Tamaño: {intHashset.Count} elementos, contiene 1: {intHashset.Contains(1)}, contiene 3: {intHashset.Contains(3)}");

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();
            message.AppendLine("a) Declara un array de tamaño 5 de enteros y utilizando un \"for\" establece los valores de 0 a 4:");
            message.AppendLine("\nb) Declara una lista de float y utilizando un \"foreach\" del array anterior añade los valores a la lista:");
            message.AppendLine("\nc) Declara una variable int \"index\" inicializada 0 y utilizando un \"while\" hasta 100, añade a la lista anterior los números que sean pares ignorando los impares utilizando la instrucción \"continue\":");
            message.AppendLine("\nd) Declara un hashset de enteros y mediante un \"foreach\" sobre la lista anterior añade los elementos que no estén dentro del hashset:");
            message.AppendLine("\ne) Declara un diccionario char,string y mediante un \"for\" recorre de char.MinValue hasta char.MaxValue añadiendo el char y su valor como string:");
            message.AppendLine("\nf) Declara una pila de float y llénala utilizando un \"for\" desde 0 hasta 100 incrementando 0.5f en cada iteración y mostrando el valor por consola:");
            message.AppendLine("\ng) Utilizando un \"while\" vacía la pila anterior hasta que no quede ningún elemento mostrando los elementos por consola. Ayúdate de la propiedad stack.Count para saber los items que hay en la pila:");
            message.AppendLine("\nh) Repite los ejercicios f) y g) pero en vez de usar una pila utilizando una cola. De nuevo, ayúdate de queue.Count para saber los items que hay en la cola:");
            message.AppendLine("\ni) Utilizando la lista resultante del ejercicio c) crea un array de floats del tamaño de la lista y llénalo con sus valores utilizando cualquier método visto hasta ahora. Utiliza la propiedad list.Count para saber los items que hay en la lista:");

            return message.ToString();
        }
    }
}
