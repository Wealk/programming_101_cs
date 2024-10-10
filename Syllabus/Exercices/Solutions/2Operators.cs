namespace Programming101CS.Syllabus.Exercices.Solutions {
    internal class Operators {
        public static void Solution() {
            Console.WriteLine("a) Declara dos variables int con el nombre \"x\" = 5 y \"y\" = 3 y una tercera \"z\" que sea la suma de \"x\" e \"y\":");
            int x = 5, y = 3;
            var z = x + y;
            Console.WriteLine($"Ejercicio a: x={x}, y={y}, z={z}");

            Console.WriteLine("\nb) Declara una variable float con el nombre \"preIncrement\" que sea la suma de 1.25f y \"z\", incrementando \"z\" en 1 ANTES de la operación:");
            var preIncrement = 1.25f + ++z;
            Console.WriteLine($"Ejercicio b: preIncrement={preIncrement}, z={z}");

            Console.WriteLine("\nc) Repite el ejercicio b) con una nueva variable \"postDecrement\" pero que decremente \"z\" en 1 DESPUÉS de la operación:");
            float postDecrement = 1.25f + z--;
            Console.WriteLine($"Ejercicio c: postDecrement={postDecrement}, z={z}");

            Console.WriteLine("\nd) Declara una variable \"parenthesis\" que sea (1 + 2)/ 3 * 3, y otra \"noParenthesis\" que sea 1 + 2 / 3 * 3:");
            var parenthesis = (1 + 2) / 3 * 3;
            var noParenthesis = 1 + 2 / 3 * 3;
            Console.WriteLine($"Ejercicio d: parenthesis={parenthesis}, noParenthesis={noParenthesis}");

            Console.WriteLine("\ne) Declara una variable booleana \"xYCheck\" que compruebe si \"x\" e \"y\" son iguales:");
            bool xYCheck = x == y;
            Console.WriteLine($"Ejercicio e: xYCheck={xYCheck}, x={x}, y={y}");

            Console.WriteLine("\nf) Declara una variable \"isXEven\" que compruebe si \"x\" es par (x % 2 = 0):");
            var isXEven = x % 2 == 0;
            Console.WriteLine($"Ejercicio f: isXEven={isXEven}, x={x}");

            Console.WriteLine("\ng) Declara una variable \"isXOdd\" que sea la negada de \"isXEven\":");
            var isXOdd = !isXEven;
            Console.WriteLine($"Ejercicio g: isXOdd={isXOdd}, isXEven={isXEven}");

            Console.WriteLine("\nh) Declara una variable \"logicAnd\" que compruebe si \"isXOdd\" y \"isXEven\" son verdaderos, forzando a comprobar ambos valores:");
            var logicAnd = isXOdd & isXEven;
            Console.WriteLine($"Ejercicio h: logicAnd={logicAnd}, isXOdd={isXOdd}, isXEven={isXEven}");

            Console.WriteLine("\ni) Delcara una variable \"conditionalLogicOr\" que compruebe si \"isXEven\" o \"isXOdd\" es verdadero, comprobando el mínimo de valores posibles:");
            var conditionalLogicOr = isXEven || isXOdd;
            Console.WriteLine($"Ejercicio i: conditionalLogicOr={conditionalLogicOr}, isXEven={isXEven}, isXOdd={isXOdd}");
        }
    }
}
