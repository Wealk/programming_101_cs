using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter03_03 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(3, "Programación básica: Control del flujo", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            message.AppendLine("- Permite modificar el flujo de ejecución del programa según requiera el desarrollador");
            message.AppendLine("- Los más habituales son las ramificaciones (if/switch) y los diferentes bucles (while/do while/for/foreach)");

            // If-Else
            message.AppendLine("\nIf-Else");
            message.AppendLine("- Permite determinar que sección de código se deberá ejecutar según una evaluación booleana");
            message.AppendLine("- Se puede describir con la siguiente expresión regular: if (condición) { bloque } (else if (condición) { bloque })* (else { bloque })");
            message.AppendLine("- En otras palabras un if, seguido de 0 o + else if, terminando con un posible else final");

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
            message.AppendLine("\nSwitch");
            message.AppendLine("- A diferencia del If-Else permite evaluar valores no necesariamente booleanos");
            message.AppendLine("- Deberemos espeficiar los posibles valores que nos interese y un caso general");
            message.AppendLine("- En caso de no encontrar el valor específico se ejecutará el caso general");
            message.AppendLine("- Se pueden usar estructuras complejas, int, strings, enumerados, ...");

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
            message.AppendLine("\nWhile");
            message.AppendLine("- Bloque de instrucciones que se ejecutarán en bucle mientras se cumpla la condición booleana");
            message.AppendLine("- Si al procesar la entrada del bucle la condición no se cumple no se ejecutará ninguna vez");
            message.AppendLine("- Advertencia: Cuidado con los bucles infinitos");

            while (condition) {
                // Bloque
                condition = false;
            }

            // Do-While
            message.AppendLine("\nDo-While");
            message.AppendLine("- Bloque de instrucciones que se ejecutarán en bucle mientras se cumpla la condición booleana");
            message.AppendLine("- A diferencia del anterior, como mínimo se ejecutará una vez");
            message.AppendLine("- Advertencia: Cuidado con el tratamiento de la primera iteración");
            message.AppendLine("- Advertencia: Cuidado con los bucles infinitos");

            do {
                // Bloque
                condition = false;
            } while (condition);

            // For
            message.AppendLine("\nFor");
            message.AppendLine("- Bucle que se ejecutará mientras que se cumpla la condición booleana de la sección central");
            message.AppendLine("- La estructura del bucle se divide en for (declaración; condición; iteración)");
            message.AppendLine("- La única sección obligatoria es la condición. La declaración y la iteración pueden estar vacias");
            message.AppendLine("- La declaración y la condición se ejecutará al iniciar el bucle");
            message.AppendLine("- La condición y la iteración se ejecutará tras cada iteración del bucle. Primero la iteración y luego la condición");
            message.AppendLine("- Consejo: Recordar que la declaración/iteración pueden trabajar con múltiples variables");
            message.AppendLine("- Advertencia: Cuidado con los bucles infinitos");

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
            message.AppendLine("\nForeach");
            message.AppendLine("- Bucle que recorrerá todos los elementos de un conjunto");
            message.AppendLine("- Utilizado principalmente para recorrer los elementos de cualquier objeto con un iterador definido");
            message.AppendLine("- Este bucle utiliza el iterador del objeto para recorrer el conjunto utilizado");

            var list = new List<int> { 1, 5, 5 };
            foreach (var item in list) {
                // Bloque
            }

            var hashset = new HashSet<char> { 'h', 'O', 'L', 'a' };
            foreach (var item in hashset) {
                // Bloque
            }

            // Break-Continue
            message.AppendLine("\nPuntos de ruptura en bucles");
            message.AppendLine("- Permiten alterar el flujo dentro de los bucles y ramificaciones");
            message.AppendLine("- break: rompe con el bucle/bloque del nivel de profundidad más cercano");
            message.AppendLine("- continue: salta la iteración del bucle más cerano");

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

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();
            message.AppendLine("a) Declara dos variables int \"a\" = 5, \"b\" = 11 y si \"a\" + \"b\" es mayor a 16 suma \"a\" a \"b\":");
            message.AppendLine("\nb) Usando las variables del ejercicio anterior, si \"b\" es igual a 11 añade 6 a \"a\", si no iguala \"b\" a \"a\":");
            message.AppendLine("\nc) Declara una variable \"c\" que sea igual a \"a\" + \"b\". Si \"c\" es igual a 10 suma 3 a \"a\", sino si \"c\" es igual a 25 resta 5 a \"b\", sino suma 15 a \"c\":");
            message.AppendLine("\nd) Transforma el ejercicio anterior utilizando un bloque \"switch\":");
            message.AppendLine("\ne) Declara una variable float \"index\" y crea un bucle \"while\" que incremente \"index\" en 0.1f hasta que \"index\" sea mayor a 100 y lo muestre por consola con la instrucción \"Console.Write($\"{index}, \");\" tras el incremento:");
            message.AppendLine("\nf) Utilizando la variable anterior crea un bucle \"do-while\" que reste 0.25f a \"index\" hasta ser menor o igual a 0 y muestralo por consola después del decremento:");
            message.AppendLine("\ng) Crea un bucle \"for\" que instancie una variable char \"character\" inicializada a char.MinValue y que mientras sea menor a 255 incrementa \"character\" en 1. En cada iteración debe mostrar por la consola el valor de \"character\":");
            message.AppendLine("\nh) Declara una lista de int \"iteration\", como en la teoria, y utilizando un bucle \"for\" asigna el valor 0 a \"a\" y mientras \"a\" sea menor a \"b\" incrementa \"a\" en 2, añadiendo el valor de \"a\" en cada iteración a la lista con la instrucción \"iteration.Add(a)\":");
            message.AppendLine("\ni) Recorre la lista \"iteration\" anterior con un \"foreach\" con una variable \"item\" de tipo int, si \"item\" es 0 ignora esa iteración, si \"item\" es mayor o igual a 5 rompe el bucle. Si pasa las condiciones anteriores, muestra el valor \"item\" en la consola:");

            return message.ToString();
        }
    }
}
