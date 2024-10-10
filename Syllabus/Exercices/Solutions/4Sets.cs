namespace Programming101CS.Syllabus.Exercices.Solutions {
    internal class Sets {
        public static void Solution() {
            Console.WriteLine("a) Declara un array de tamaño 5 de enteros y utilizando un \"for\" establece los valores de 0 a 4:");
            var exerciceA = new int[5];
            for (var i = 0; i < 5; i++)
                exerciceA[i] = i;
            Console.WriteLine($"Ejercicio a: exerciceA={{{string.Join(", ", exerciceA)}}}");

            Console.WriteLine("\nb) Declara una lista de float y utilizando un \"foreach\" del array anterior añade los valores a la lista:");
            var exerciceB = new List<float>();
            foreach (var item in exerciceA)
                exerciceB.Add(item);
            Console.WriteLine($"Ejercicio b: exerciceB={{{string.Join(", ", exerciceB)}}}");

            Console.WriteLine("\nc) Declara una variable int \"index\" inicializada 0 y utilizando un \"while\" hasta 100, añade a la lista anterior los números que sean pares ignorando los impares utilizando la instrucción \"continue\":");
            var index = 0;
            while (index <= 100) {
                if (index % 2 != 0) {
                    index++;
                    continue;
                }

                exerciceB.Add(index);
                index++;
            }
            Console.WriteLine($"Ejercicio c: index={index}, exerciceB={{{string.Join(", ", exerciceB)}}}");

            Console.WriteLine("\nd) Declara un hashset de enteros y mediante un \"foreach\" sobre la lista anterior añade los elementos que no estén dentro del hashset :");
            var exerciceD = new HashSet<int>();
            foreach (var item in exerciceB)
                if (!exerciceD.Contains(index))
                    exerciceD.Add((int)item);
            Console.WriteLine($"Ejercicio d: exerciceD={{{string.Join(", ", exerciceD)}}}");

            Console.WriteLine("\ne) Declara un diccionario char,string y mediante un \"for\" recorre de char.MinValue hasta 255 sin incluir añadiendo el char y su valor como string:");
            Dictionary<char, string> exerciceE = new();
            for (var i = char.MinValue; i < 255; i++)
                exerciceE.Add(i, $"{i}");
            Console.WriteLine($"Ejercicio e: exerciceE={{{string.Join(", ", exerciceE.Select(e => $"{{ key={e.Key}, value={e.Value} }}"))}}}");

            Console.WriteLine("\nf) Declara una pila de float y llénala utilizando un \"for\" desde 0 hasta 100 incrementando 0.5f en cada iteración y mostrando el valor por consola:");
            var exerciceF = new Stack<float>();
            for (var i = 0f; i <= 100; i += 0.5f) {
                exerciceF.Push(i);
                Console.WriteLine($"Ejercicio f: i={i}, stack={exerciceF.Count}");
            }

            Console.WriteLine("\ng) Utilizando un \"while\" vacía la pila anterior hasta que no quede ningún elemento mostrando los elementos por consola. Ayúdate de la propiedad stack.Count para saber los items que hay en la pila:");
            while (exerciceF.Count > 0)
                Console.WriteLine($"Ejercicio g: item={exerciceF.Pop()}, stack={exerciceF.Count}");

            Console.WriteLine("\nh) Repite los ejercicios f) y g) pero en vez de usar una pila utilizando una cola. De nuevo, ayúdate de queue.Count para saber los items que hay en la cola:");
            var exerciceH = new Queue<float>();
            for (var i = 0f; i <= 100; i += 0.5f) {
                exerciceH.Enqueue(i);
                Console.WriteLine($"Ejercicio h: i={i}, queue={exerciceH.Count}");
            }

            while (exerciceH.Count > 0)
                Console.WriteLine($"Ejercicio h: item={exerciceH.Dequeue()}, queue={exerciceH.Count}");

            Console.WriteLine("\ni) Utilizando la lista resultante del ejercicio c) crea un array de floats del tamaño de la lista y llénalo con sus valores utilizando cualquier método visto hasta ahora. Utiliza la propiedad list.Count para saber los items que hay en la lista:");
            var exerciceI = new float[exerciceB.Count];
            for (var i = 0; i < exerciceB.Count; i++)
                exerciceI[i] = exerciceB[i];
            Console.WriteLine($"Ejercicio i: exerciceI={{{string.Join(", ", exerciceI)}}}");
        }
    }
}
