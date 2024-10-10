namespace Programming101CS.Syllabus {
    internal class Operators {
        public static void Information() {
            // Modificadores
            int a = 2;
            int b = 10;
            Console.WriteLine("- Los modificadores actualizan los valores de las variables");
            Console.WriteLine("- Hay incrementos (++) que suman 1 al valor y decrementos (--) que restan 1");
            Console.WriteLine("- Según este situado como postfijo o prefijo se aplica la modificación antes o después de la ejectuar la instrucción");
            Console.WriteLine($"- Valor inicial: a={a}, ++a: {++a}, valor actual: {a}, a++: {a++}, valor actual {a}");
            Console.WriteLine($"- Valor inicial: a={a}, --a: {--a}, valor actual: {a}, a--: {a--}, valor actual {a}");

            // Aritmeticos
            Console.WriteLine("\nOperaciones aritmeticas:");
            Console.WriteLine($"- Suma: {a}+{b} = {a + b}");
            Console.WriteLine($"- Resta: {a}-{b} = {a - b}");
            Console.WriteLine($"- Multiplicacion: {a}*{b} = {a * b}");
            Console.WriteLine($"- Division entera: {a}/{b} = {a / b}");
            Console.WriteLine($"- Division decimal: {a}/{b} = {a / (float)b}");
            Console.WriteLine($"- Modulo (Resto): {a}%{b} = {a % b}");
            Console.WriteLine($"- Negativo (Unario -): -{a} = {-a}");
            Console.WriteLine($"- Negativo (Unario -): -(-{a}) = {-(-a)}");

            // Prioridades
            Console.WriteLine("\n¿En que orden se ejecutan las instrucciones?");
            Console.WriteLine("- El orden es el mismo que al aplicar operaciones matematicas comunes");
            Console.WriteLine("- 1: Primero se aplicaran los modificadores con postfijo (a++)");
            Console.WriteLine("- 2: Luego se aplicaran los modificadores con prefijo (++a) y los operadores unarios (-a)");
            Console.WriteLine("- 3: Los siguientes son las multiplicaciones (*), divisiones (/) y modulos (%)");
            Console.WriteLine("- 4: Para terminar las sumas (+) y las restas (-)");
            Console.WriteLine("- Igual que con las operaciones comunes se pueden usar paréntis para modificar el orden");
            Console.WriteLine($"- 2 + 4 - 2 * 10 / 2 = {2 + 4 - 2 * 10 / 2}. 2 * 10 = 20, 20 / 2 = 10, 2 + 4 = 6, 6 - 10 = -4");

            // Comparativos
            int c = 5;
            int d = 6;
            Console.WriteLine("\nOperadores de igualdad y comparación:");
            Console.WriteLine($"- Igualdad: {c} == {d} es {c == d}");
            Console.WriteLine($"- Diferente: {c} != {d} es {c != d}");
            Console.WriteLine($"- Menor: {c} < {d} es {c < d}");
            Console.WriteLine($"- Menor o igual: {c} <= {d} es {c <= d}");
            Console.WriteLine($"- Mayor o igual: {c} >= {d} es {c >= d}");
            Console.WriteLine($"- Mayor: {c} > {d} es {c > d}");

            // Logicos booleanos
            Console.WriteLine("\nOperadores lógicos:");
            Console.WriteLine($"- Negación logica (!): invierte el valor. !false = {!false} ");
            Console.WriteLine($"- AND logico (&) y AND logico condicional (&&): es verdadero si todos los dos condicionales lo son");
            Console.WriteLine($"- OR logico (|) y OR logico condicional (||): es verdadero si al menos un condicional lo es");
            Console.WriteLine($"- IR logico (^): es verdadero si un unico condicional lo es");
            Console.WriteLine($"- Los operadores condicionales evaluan de izquierda a derecha y solo evaluan si es necesario");
            Console.WriteLine($"- true || false = {true || false} y false && true = {false && true} solo evaluaría la primera condicion");
            Console.WriteLine($"- false || true = {false || true} y true && false = {true && false} evaluaria las dos condiciones");
            Console.WriteLine($"- true | false = {true | false} y false & true = {false & true} evaluaria las dos condiciones");

            // Asignaciones
            Console.WriteLine("\nMediante asignaciones actualizamos el valor de las variables:");
            int e = 5;
            e = e + 2;
            e += 2;
            Console.WriteLine("- Siendo e = 5, hacer e = e+2 es equivalente a e += 2, resultando e = 7");
            e = e - 2;
            e -= 2;
            Console.WriteLine("- Siendo e = 5, hacer e = e-2 es equivalente a e -= 2, resultando e = 3");
            bool f = true;
            f = f || false;
            f |= false;
            Console.WriteLine("- Lo mismo se aplica a las operaciones lógicas. Siendo f = true, hacer f = f || false es igual a f |= false ");
        }
    }
}
