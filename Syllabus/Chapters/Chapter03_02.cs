using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter03_02 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(2, "Programación básica: Operadores", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            int a = 2;
            int b = 10;
            message.AppendLine("- Los modificadores actualizan los valores de las variables");
            message.AppendLine("- Hay incrementos (++) que suman 1 al valor y decrementos (--) que restan 1");
            message.AppendLine("- Según este situado como postfijo o prefijo se aplica la modificación antes o después de la ejectuar la instrucción");
            message.AppendLine($"- Valor inicial: a={a}, ++a: {++a}, valor actual: {a}, a++: {a++}, valor actual {a}");
            message.AppendLine($"- Valor inicial: a={a}, --a: {--a}, valor actual: {a}, a--: {a--}, valor actual {a}");

            // Aritmeticos
            message.AppendLine("\nOperaciones aritmeticas:");
            message.AppendLine($"- Suma: {a}+{b} = {a + b}");
            message.AppendLine($"- Resta: {a}-{b} = {a - b}");
            message.AppendLine($"- Multiplicacion: {a}*{b} = {a * b}");
            message.AppendLine($"- Division entera: {a}/{b} = {a / b}");
            message.AppendLine($"- Division decimal: {a}/{b} = {a / (float)b}");
            message.AppendLine($"- Modulo (Resto): {a}%{b} = {a % b}");
            message.AppendLine($"- Negativo (Unario -): -{a} = {-a}");
            message.AppendLine($"- Negativo (Unario -): -(-{a}) = {-(-a)}");

            // Prioridades
            message.AppendLine("\n¿En que orden se ejecutan las instrucciones?");
            message.AppendLine("- El orden es el mismo que al aplicar operaciones matematicas comunes");
            message.AppendLine("- 1: Primero se aplicaran los modificadores con postfijo (a++)");
            message.AppendLine("- 2: Luego se aplicaran los modificadores con prefijo (++a) y los operadores unarios (-a)");
            message.AppendLine("- 3: Los siguientes son las multiplicaciones (*), divisiones (/) y modulos (%)");
            message.AppendLine("- 4: Para terminar las sumas (+) y las restas (-)");
            message.AppendLine("- Igual que con las operaciones comunes se pueden usar paréntis para modificar el orden");
            message.AppendLine($"- 2 + 4 - 2 * 10 / 2 = {2 + 4 - 2 * 10 / 2}. 2 * 10 = 20, 20 / 2 = 10, 2 + 4 = 6, 6 - 10 = -4");

            // Comparaciones
            int c = 5;
            int d = 6;
            message.AppendLine("\nOperadores de igualdad y comparación:");
            message.AppendLine($"- Igualdad: {c} == {d} es {c == d}");
            message.AppendLine($"- Diferente: {c} != {d} es {c != d}");
            message.AppendLine($"- Menor: {c} < {d} es {c < d}");
            message.AppendLine($"- Menor o igual: {c} <= {d} es {c <= d}");
            message.AppendLine($"- Mayor o igual: {c} >= {d} es {c >= d}");
            message.AppendLine($"- Mayor: {c} > {d} es {c > d}");

            // Logicos booleanos
            message.AppendLine("\nOperadores lógicos:");
            message.AppendLine($"- Negación logica (!): invierte el valor. !false = {!false} ");
            message.AppendLine($"- AND logico (&) y AND logico condicional (&&): es verdadero si todos los dos condicionales lo son");
            message.AppendLine($"- OR logico (|) y OR logico condicional (||): es verdadero si al menos un condicional lo es");
            message.AppendLine($"- IR logico (^): es verdadero si un unico condicional lo es");
            message.AppendLine($"- Los operadores condicionales evaluan de izquierda a derecha y solo evaluan si es necesario");
            message.AppendLine($"- true || false = {true || false} y false && true = {false && true} solo evaluaría la primera condicion");
            message.AppendLine($"- false || true = {false || true} y true && false = {true && false} evaluaria las dos condiciones");
            message.AppendLine($"- true | false = {true | false} y false & true = {false & true} evaluaria las dos condiciones");

            // Asignaciones
            message.AppendLine("\nMediante asignaciones actualizamos el valor de las variables:");
            int e = 5;
            e = e + 2;
            e += 2;
            message.AppendLine("- Siendo e = 5, hacer e = e+2 es equivalente a e += 2, resultando e = 7");
            e = e - 2;
            e -= 2;
            message.AppendLine("- Siendo e = 5, hacer e = e-2 es equivalente a e -= 2, resultando e = 3");
            bool f = true;
            f = f || false;
            f |= false;
            message.AppendLine("- Lo mismo se aplica a las operaciones lógicas. Siendo f = true, hacer f = f || false es igual a f |= false ");

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();
            message.AppendLine("a) Declara dos variables int con el nombre \"x\" = 5 y \"y\" = 3 y una tercera \"z\" que sea la suma de \"x\" e \"y\":");
            message.AppendLine("\nb) Declara una variable float con el nombre \"preIncrement\" que sea la suma de 1.25f y \"z\", incrementando \"z\" en 1 ANTES de la operación:");
            message.AppendLine("\nc) Repite el ejercicio b) con una nueva variable \"postDecrement\" pero que decremente \"z\" en 1 DESPUÉS de la operación:");
            message.AppendLine("\nd) Declara una variable \"parenthesis\" que sea (1 + 2)/ 3 * 3, y otra \"noParenthesis\" que sea 1 + 2 / 3 * 3:");
            message.AppendLine("\ne) Declara una variable booleana \"xYCheck\" que compruebe si \"x\" e \"y\" son iguales:");
            message.AppendLine("\nf) Declara una variable booleana \"isXEven\" que compruebe si \"x\" es par (x % 2 = 0):");
            message.AppendLine("\ng) Declara una variable booleana \"isXOdd\" que sea la negada de \"isXEven\":");
            message.AppendLine("\nh) Declara una variable booleana \"logicAnd\" que compruebe si \"isXOdd\" y \"isXEven\" son verdaderos, forzando a comprobar ambos valores:");
            message.AppendLine("\ni) Declara una variable booleana \"conditionalLogicOr\" que compruebe si \"isXEven\" o \"isXOdd\" es verdadero, comprobando el mínimo de valores posibles:");

            return message.ToString();
        }
    }
}
