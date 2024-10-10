using Programming101CS.OOP;

namespace Programming101CS.Syllabus {
    internal class ControlFlow {
        public static void Information() {
            Console.WriteLine("- Permite modificar el flujo de ejecución del programa según requiera el desarrollador");
            Console.WriteLine("- Los más habituales son las ramificaciones (if/switch) y los diferentes bucles (while/do while/for/foreach)");

            // If-Else
            Console.WriteLine("\nIf-Else");
            Console.WriteLine("- Permite determinar que sección de código se deberá ejecutar según una evaluación booleana");
            Console.WriteLine("- Se puede describir con la siguiente expresión regular: if (condición) { bloque } (else if (condición) { bloque })* (else { bloque })");
            Console.WriteLine("- En otras palabras un if, seguido de 0 o + else if, terminando con un posible else final");

            bool condition = false;
            if (condition || true) {
                // Bloque
            }

            if (condition && true) {
                // Bloque
            } else {
                // Bloque
            }

            if (condition && true) {
                // Bloque

            } else if (condition || true) {
                // Bloque
            } else {
                // Bloque
            }

            // Switch
            Console.WriteLine("\nSwitch");
            Console.WriteLine("- A diferencia del If-Else permite evaluar valores no necesariamente booleanos");
            Console.WriteLine("- Deberemos espeficiar los posibles valores que nos interese y un caso general");
            Console.WriteLine("- En caso de no encontrar el valor específico se ejecutará el caso general");
            Console.WriteLine("- Se pueden usar estructuras complejas, int, strings, enumerados, ...");

            switch (condition) {
                case true:
                    // Bloque
                    break;
                case false:
                    // Bloque
                    break;
            }

            var intValue = 5;
            switch (intValue) {
                case 0:
                    // Bloque
                    break;
                case 5:
                    // Bloque
                    break;
                default:
                    // Bloque
                    break;
            }

            var dow = DayOfWeek.Monday;
            switch (dow) {
                case DayOfWeek.Wednesday:
                    // Bloque
                    break;
                case DayOfWeek.Friday:
                    // Bloque
                    break;
                case DayOfWeek.Sunday:
                    // Bloque
                    break;
                default:
                    // Bloque
                    break;
            }

            // While
            Console.WriteLine("\nWhile");
            Console.WriteLine("- Bloque de instrucciones que se ejecutarán en bucle mientras se cumpla la condición booleana");
            Console.WriteLine("- Si al procesar la entrada del bucle la condición no se cumple no se ejecutará ninguna vez");
            Console.WriteLine("- Advertencia: Cuidado con los bucles infinitos");

            while (condition) {
                // Bloque
                condition = false;
            }

            // Do-While
            Console.WriteLine("\nDo-While");
            Console.WriteLine("- Bloque de instrucciones que se ejecutarán en bucle mientras se cumpla la condición booleana");
            Console.WriteLine("- A diferencia del anterior, como mínimo se ejecutará una vez");
            Console.WriteLine("- Advertencia: Cuidado con el tratamiento de la primera iteración");
            Console.WriteLine("- Advertencia: Cuidado con los bucles infinitos");

            do {
                // Bloque
                condition = false;
            } while (condition);

            // For
            Console.WriteLine("\nFor");
            Console.WriteLine("- Bucle que se ejecutará mientras que se cumpla la condición booleana de la sección central");
            Console.WriteLine("- La estructura del bucle se divide en for (declaración; condición; iteración)");
            Console.WriteLine("- La única sección obligatoria es la condición. La declaración y la iteración pueden estar vacias");
            Console.WriteLine("- La declaración y la condición se ejecutará al iniciar el bucle");
            Console.WriteLine("- La condición y la iteración se ejecutará tras cada iteración del bucle. Primero la iteración y luego la condición");
            Console.WriteLine("- Consejo: Recordar que la declaración/iteración pueden trabajar con múltiples variables");
            Console.WriteLine("- Advertencia: Cuidado con los bucles infinitos");

            for (int i = 0; i < 10; i++) {
                // Bloque
            }

            for (int i = 0, j = 0; i < 10 || j < 10; i++, j++) {
                // Bloque
            }

            for (; condition;) {
                // Bloque
            }

            // Foreach
            Console.WriteLine("\nForeach");
            Console.WriteLine("- Bucle que recorrerá todos los elementos de un conjunto");
            Console.WriteLine("- Utilizado principalmente para recorrer los elementos de cualquier objeto con un iterador definido");
            Console.WriteLine("- Este bucle utiliza el iterador del objeto para recorrer el conjunto utilizado");

            var list = new List<int>();
            list.Add(1);
            list.Add(5);
            list.Add(5);
            foreach (var item in list) {
                // Bloque
            }

            var hashset = new HashSet<char> { 'h', 'O', 'L', 'a' };
            foreach (var item in hashset) {
                // Bloque
            }

            // Break-Continue
            Console.WriteLine("\nPuntos de ruptura en bucles");
            Console.WriteLine("- Permiten alterar el flujo dentro de los bucles y ramificaciones");
            Console.WriteLine("- break: rompe con el bucle/bloque del nivel de profundidad más cercano");
            Console.WriteLine("- continue: salta la iteración del bucle más cerano");

            while (condition) {
                // Bloque
                if (condition)
                    break;
                if (condition)
                    continue;

                condition = false;
            }

            for (int i = 0; i < 10; i++) {
                // Bloque
                if (condition)
                    break;
                if (condition)
                    continue;
            }
        }
    }
}
