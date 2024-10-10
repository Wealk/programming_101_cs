namespace Programming101CS.Syllabus.Exercices.Solutions {
    internal class ControlFlow {
        public static void Solution() {
            Console.WriteLine("a) Declara dos variables int \"a\" = 5, \"b\" = 11 y si \"a\" + \"b\" es mayor a 16 suma \"a\" a \"b\":");
            int a = 5, b = 11;
            if (a + b > 16)
                b += a;
            Console.WriteLine($"Ejercicio a: a={a}, b={b}");

            Console.WriteLine("\nb) Usando las variables del ejercicio anterior, si \"b\" es igual a 11 añade 6 a \"a\", si no iguala \"b\" a \"a\":");
            if (b == 11) a += 6;
            else b = a;
            Console.WriteLine($"Ejercicio b: a={a}, b={b}");

            Console.WriteLine("\nc) Declara una variable \"c\" que sea igual a \"a\" + \"b\". Si \"c\" es igual a 10 suma 3 a \"a\", sino si \"c\" es igual a 25 resta 5 a \"b\", sino suma 15 a \"c\":");
            var c = a + b;
            if (c == 10) a += 3;
            else if (c == 25) b -= 5;
            else c += 15;
            Console.WriteLine($"Ejercicio c: a={a}, b={b}, c={c}");

            Console.WriteLine("\nd) Transforma el ejercicio anterior utilizando un bloque \"switch\":");
            switch (c) {
                case 10:
                    a += 3;
                    break;
                case 25:
                    b -= 5;
                    break;
                default:
                    c += 15;
                    break;
            }
            Console.WriteLine($"Ejercicio d: a={a}, b={b}, c={c}");

            Console.WriteLine("\ne) Declara una variable float \"index\" y crea un bucle \"while\" que incremente \"index\" en 0.1f hasta que \"index\" sea mayor a 100:");
            var index = 0f;
            while (index > 100)
                index += 0.1f;
            Console.WriteLine($"Ejercicio e: index={index}");

            Console.WriteLine("\nf) Utilizando la variable anterior crea un bucle \"do-while\" que reste 0.25f a \"index\" hasta ser menor o igual a 0:");
            do {
                index -= 0.25f;
            } while (index > 0);
            Console.WriteLine($"Ejercicio f: index={index}");

            Console.WriteLine("\ng) Crea un bucle \"for\" que instancie una variable char \"character\" inicializada a char.MinValue y que mientras sea menor a 255 incrementa \"character\" en 1. En cada iteración debe mostrar por la consola el valor de \"character\":");
            Console.Write($"Ejercicio g: ");
            for (var character = char.MinValue; character < 255; character++)
                Console.Write($"{character}, ");
            Console.WriteLine("");

            Console.WriteLine("\nh) Declara una lista de int \"iteration\", como en la teoria, y utilizando un bucle \"for\" asigna el valor 0 a \"a\" y mientras \"a\" sea menor a \"b\" incrementa \"a\" en 2, añadiendo el valor de \"a\" en cada iteración a la lista con la instrucción \"iteration.Add(a)\":");
            var iteration = new List<int>();
            for (a = 0; a < b; a += 2)
                iteration.Add(a);
            Console.WriteLine($"Ejercicio h: a={a}, b={b}, iteration={{{string.Join(", ", iteration)}}}");

            Console.WriteLine("\ni) Recorre la lista \"iteration\" anterior con un \"foreach\" con una variable \"item\" de tipo int, si \"item\" es 0 ignora esa iteración, si \"item\" es mayor o igual a 5 rompe el bucle. Si pasa las condiciones anteriores, muestra el valor \"item\" en la consola:");
            foreach (int item in iteration) {
                if (item == 0)
                    continue;
                if (item >= 5)
                    break;

                Console.WriteLine($"Ejercicio i: {item}");
            }
        }
    }
}
