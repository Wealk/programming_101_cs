using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter03_04 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(4, "Programación básica: Métodos", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            message.AppendLine("- Se utilizan para reutilizar y facilitar la legibilidad del código");
            message.AppendLine("- Permiten unificar instrucciones recurrentes en un solo lugar");
            message.AppendLine("- Por ejemplo: Resolución de ecuaciones de primer grado (aX + b = 0)");
            message.AppendLine($"- 5x - 10 = 0 -> x = {SimpleEquation(5, -10)}");
            message.AppendLine($"- 12x + 8 = 0 -> x = {SimpleEquation(12, 8)}");

            // Estructura de la declaracion
            message.AppendLine("\nEstructura de la declaración");
            message.AppendLine("- [modificador de acceso] ([static]|[]) [tipo a devolver] [nombre] ([parámetros]). Por ejemplo: public void Information()'");
            message.AppendLine("- El modificador de acceso del método determina su tipo de 'visibilidad'");
            message.AppendLine("- El tipo resultante determina el tipo del objeto que será devuelto, si hay alguno");
            message.AppendLine("- El nombre del método determina como invocarlo");
            message.AppendLine("- El conjunto de parametros de entrada determina la firma del método");
            message.AppendLine("- Llamamos función a un método que devuelve algún objeto");
            message.AppendLine("- Se puede llamar procedimiento a un método que contenga un conjunto de instrucciones y no devuelva nada");
            message.AppendLine($"- Función string ToUpperCase(\"Hola\") -> {ToUpperCase("Hola")}");
            message.AppendLine($"- Método void PrintText(\"Hola\") -> ");
            PrintText("Hola");

            // Visibilidad
            message.AppendLine("\nModificador de acceso");
            message.AppendLine("- Es utilizado para evitar que se llamen a métodos (o propiedades, como veremos más adelante) desde otros puntos de la solución");
            message.AppendLine("- Dependen del lenguaje, pero generalmente los tipos de visibilidad que encontramos son: public, protected, y private");
            message.AppendLine("- El modificador de acceso public hace que no haya restricciones, es accesible desde cualquier lado");
            message.AppendLine("- El modificador de acceso protected hace que su acceso se limite a la propia clase que lo contiene o derivados de esta (ya lo veremos más adelante)");
            message.AppendLine("- El modificador de acceso private limita su acceso al contenedor o a la propia clase que lo contiene (ya lo veremos más adelante)");
            message.AppendLine("- Adicionalmente, los lenguages integran otros tipos de visibilidad como: internal, que permite el acceso únicamente dentro del propio proyecto");

            // Estáticos vs instanciados
            message.AppendLine("\nEstáticos vs Instanciados:");
            message.AppendLine("- Un concepto relacionado con los métodos y las propiedes es la manera de acceso que tienen");
            message.AppendLine("- Cuando para acceder a un método necesitamos un objeto que haya sido instanciado se tratará de un método del objeto instanciado. Por ejemplo: array.Lenght");
            message.AppendLine("- Por el contraro, cuando podemos utilizar algún método sin hacer referencia a un objeto instanciado será un método estático. Por ejemplo: Math.Ceiling(number)");

            // Sobrecarga de métodos
            message.AppendLine("\nSobrecarga del método");
            message.AppendLine("- Implica la duplicidad de parte de la firma del método");
            message.AppendLine("- Permite diferenciar métodos con un mismo nombre y mismo tipo de devolución utilizando como elemento distintivo los parametros de entrada");
            message.AppendLine("- Un método no puede diferenciarse de otro únicamente por lo que devuelva, debe modificar su firma");
            message.AppendLine("- Consejo: Recurso muy potente para el estructurar correctamente y facilitar la legibilidad del código");
            message.AppendLine($"- private void PrintText(): PrintText()\n{PrintText()}");

            message.AppendLine($"- private void PrintText(string): PrintText (\"Hola mundo\")\n{PrintText("Hola mundo")}");
            message.AppendLine($"- private void PrintText(float): PrintText (1.2345f)\n{PrintText(1.2345f)}");
            message.AppendLine($"- private void PrintText(params string[] text): PrintText (\"Hola\", \"mundo\")\n{PrintText("Hola", "mundo")}");

            // Tipos de parametro
            message.AppendLine("\nTipos de parámetros");
            message.AppendLine("- Los parámetros de un método podrán ser pasados como copia o como referencia");
            message.AppendLine("- Las modificaciones sobre los parámetros pasados como copia no permanecerán tras salir del método");
            message.AppendLine("- Las modificaciones sobre los parámetros pasados como copia no permanecerán tras salir del método");
            message.AppendLine("- Las modificaciones sobre los parámetros pasados como referencia permanecerán tras salir del método");
            message.AppendLine("- Dependiendo del lenguaje esta especificación se realiza de manera automática o puede forzarse");
            message.AppendLine("- Dependiendo del lenguaje hay tipos de datos que solo se pasarán como copia o referencia");
            message.AppendLine("- Dependiendo del lenguaje encontramos otros parámetros, como los parámetros de salida");
            var text = "Hola";
            message.AppendLine($"- Valor de text = {text} antes de llamar a la función por copia");
            ModifyText(text);
            message.AppendLine($"- Valor de text = {text} después de llamar a la función por copia");

            text = "Hola";
            message.AppendLine($"- Valor de text = {text} antes de llamar a la función por referencia");
            ModifyText(ref text);
            message.AppendLine($"- Valor de text = {text} después de llamar a la función por referencia");

            text = "Hola";
            message.AppendLine($"- Valor de text = {text} antes de llamar a la función con parámetro de salida");
            ModifyText(text, out var result);
            message.AppendLine($"- Valor de result = {result} después de llamar a la función con parámetro de salida");

            // Recursividad
            message.AppendLine("\nRecursividad");
            message.AppendLine("- Entendemos como recursividad cuando un método se llama a si mismo");
            message.AppendLine("- Recurso utilizado sobretodo para la iteración de estructuras avanzadas");
            message.AppendLine("- Dependiendo de la colocación del bloque de procesado (antes o después de la recursividad), se ejecutará en orden inverso");
            message.AppendLine("- Suele componerse de un bloque común y un punto que bifurca entre el avance y la condición de salida");
            message.AppendLine("- Toda recursividad se puede reescribir utilizando un bucle, mejorando la optimización pero suele dificultar la lectura");
            message.AppendLine("- Advertencia: Cuidado con provocar un stack overflow (sobrecarga de la pila de llamadas) (bucle infinito)");
            message.AppendLine("- Ejecución de la llamada recursiva: BeforeRecursivity(0, 10)");
            BeforeRecursivity(0, 10);
            message.AppendLine("- Ejecución de la llamada recursiva: AfterRecursivity(0, 10)");
            AfterRecursivity(0, 10);

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();
            message.AppendLine("a) Implementa una función pública \"StringToUpperCase\" que dado un string devuelva una lista de chars con el mismo string pero con las letras en mayúsculas utilizando un \"foreach\" y la función char.ToUpperInvariant(item). Prueba la función con el mensaje \"Hola mundo\" mostrando el texto antes y después por consola:");
            message.AppendLine("\nb) Implementa una función pública \"IsEven\" que dado un número entero te diga si es par. Prueba la función con 0, con 20 y con 7 y muestra los resultados por consola:");
            message.AppendLine("\nc) Implementa una función pública \"GetNextEvenNumber\" que dado un número entero, y utilizando la función anterior, te de el número par más próximo por arriba, en caso de que no sea par y el propio número si es par. Prueba la función con los mismos valores anteriores:");
            message.AppendLine("\nd) Implementa un método público \"RoundUpFloat\" que dado un float, lo modifique redondeándolo hacia arriba con la operación Math.Ceiling(number). Prueba la función con los valores 1.2f, 1.7f, 2.5f:");
            message.AppendLine("\ne) Implementa una función pública \"VowelCount\" que dado un string devuelva un entero con el número de vocales que tenga. Ayúdate de un \"foreach\" y de la comprobación \"\"aeiouAEIOU\".Contains(item)\". Prueba la función con el texto \"Hello world\":");
            message.AppendLine("\nf) Implementa una función pública \"GetNextSunday\" que dada una fecha tipo DateTime, te devuelva un DateTime con el domingo más próximo. Usando la comprobación \"date.DayOfWeek != DayOfWeek.Sunday\" y la instrucción \"date = date.AddDays(1)\". Prueba la función con el parámetro DateTime.Today, que da la fecha de hoy:");
            message.AppendLine("\ng) Implementa un método público \"SetToFirstDayOfMonth\" que dada una fecha tipo DateTime, modifique el valor del parámetro para ponerlo al primer día del mes. Utiliza la propiedad date.Day junto a  date = date.AddDays(...) y llamando a la función mediante DateTime.Today que da la fecha de hoy:");
            message.AppendLine("\nh) Implementa un método público \"SplitCharacters\" que dado un string devuelva, utilizando un parámetro array out char[], los carácteres por separado. Utiliza la instrucción \"result = new char[text.lenght]\" para iniciarlar el array resultante y ayúdate de un \"for\" para recorrer el texto. Prueba el método con el texto \"Hello world\":");
            message.AppendLine("\ni) Mediante una función pública \"GetLastCharacter\" recursiva busca el último carácter de un string. Ayúdate de la función \"text.Lenght\" para conocer la longitud del string y de la instrucción \"text.Substring(1)\" para devolver un string sin el primer carácter. Prueba el método con el texto \"Hello world\":");

            return message.ToString();
        }

        // Private methods
        private static float SimpleEquation(float a, float b) {
            return -b / a;
        }

        private static string PrintText() {
            return "Hello world";
        }

        private static string PrintText(string text) {
            return text;
        }

        private static string PrintText(float number) {
            return $"{number:##.00}";
        }

        private static string PrintText(params string[] text) {
            return string.Join(' ', text);
        }

        private static string ToUpperCase(string text) {
            return text.ToUpperInvariant();
        }

        private static void ModifyText(string text) {
            text = text.ToUpperInvariant();
        }

        private static void ModifyText(ref string text) {
            text = text.ToUpperInvariant();
        }

        private static void ModifyText(string text, out string result) {
            result = text.ToUpperInvariant();
        }

        private static void BeforeRecursivity(int value, int maxValue) {
            if (value > maxValue - 1) return;
            else BeforeRecursivity(value + 1, maxValue);
        }

        private static void AfterRecursivity(int value, int maxValue) {
            if (value > maxValue - 1) return;
            else AfterRecursivity(value + 1, maxValue);
        }
    }
}
