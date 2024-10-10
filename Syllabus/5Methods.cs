namespace Programming101CS.Syllabus {
    internal class Methods {
        public static void Information() {
            Console.WriteLine("- Se utilizan para reutilizar y facilitar la legibilidad del código");
            Console.WriteLine("- Permiten unificar instrucciones recurrentes en un solo lugar");
            Console.WriteLine("- Por ejemplo: Resolución de ecuaciones de primer grado (aX + b = 0)");
            Console.WriteLine($"- 5x - 10 = 0 -> x = {SimpleEquation(5, -10)}");
            Console.WriteLine($"- 12x + 8 = 0 -> x = {SimpleEquation(12, 8)}");

            // Estructura de la declaracion
            Console.WriteLine("\nEstructura de la declaración");
            Console.WriteLine("- [modificador de acceso] ([static]|[]) [tipo a devolver] [nombre] ([parámetros]). Por ejemplo: public void Information()'");
            Console.WriteLine("- El modificador de acceso del método determina su tipo de 'visibilidad'");
            Console.WriteLine("- El tipo resultante determina el tipo del objeto que será devuelto, si hay alguno");
            Console.WriteLine("- El nombre del método determina como invocarlo");
            Console.WriteLine("- El conjunto de parametros de entrada determina la firma del método");
            Console.WriteLine("- Llamamos función a un método que devuelve algún objeto");
            Console.WriteLine("- Se puede llamar procedimiento a un método que contenga un conjunto de instrucciones y no devuelva nada");
            Console.WriteLine($"- Función string ToUpperCase(\"Hola\") -> {ToUpperCase("Hola")}");
            Console.WriteLine($"- Método void PrintText(\"Hola\") -> ");
            PrintText("Hola");

            // Visibilidad
            Console.WriteLine("\nModificador de acceso");
            Console.WriteLine("- Es utilizado para evitar que se llamen a métodos (o propiedades, como veremos más adelante) desde otros puntos de la solución");
            Console.WriteLine("- Dependen del lenguaje, pero generalmente los tipos de visibilidad que encontramos son: public, protected, y private");
            Console.WriteLine("- El modificador de acceso public hace que no haya restricciones, es accesible desde cualquier lado");
            Console.WriteLine("- El modificador de acceso protected hace que su acceso se limite a la propia clase que lo contiene o derivados de esta (ya lo veremos más adelante)");
            Console.WriteLine("- El modificador de acceso private limita su acceso al contenedor o a la propia clase que lo contiene (ya lo veremos más adelante)");
            Console.WriteLine("- Adicionalmente, los lenguages integran otros tipos de visibilidad como: internal, que permite el acceso únicamente dentro del propio proyecto");

            // Estáticos vs instanciados
            Console.WriteLine("\nEstáticos vs Instanciados:");
            Console.WriteLine("- Un concepto relacionado con los métodos y las propiedes es la manera de acceso que tienen");
            Console.WriteLine("- Cuando para acceder a un método necesitamos un objeto que haya sido instanciado se tratará de un método del objeto instanciado. Por ejemplo: array.Lenght");
            Console.WriteLine("- Por el contraro, cuando podemos utilizar algún método sin hacer referencia a un objeto instanciado será un método estático. Por ejemplo: Math.Ceiling(number)");

            // Sobrecarga de métodos
            Console.WriteLine("\nSobrecarga del método");
            Console.WriteLine("- Implica la duplicidad de parte de la firma del método");
            Console.WriteLine("- Permite diferenciar métodos con un mismo nombre y mismo tipo de devolución utilizando como elemento distintivo los parametros de entrada");
            Console.WriteLine("- Un método no puede diferenciarse de otro únicamente por lo que devuelva, debe modificar su firma");
            Console.WriteLine("- Consejo: Recurso muy potente para el estructurar correctamente y facilitar la legibilidad del código");
            Console.WriteLine("- private void PrintText(): PrintText()");
            PrintText();
            Console.WriteLine("- private void PrintText(string): PrintText (\"Hola mundo\")");
            PrintText("Hola mundo");
            Console.WriteLine("- private void PrintText(float): PrintText (1.2345f)");
            PrintText(1.2345f);
            Console.WriteLine("- private void PrintText(params string[] text): PrintText (\"Hola\", \"mundo\")");
            PrintText("Hola", "mundo");

            // Tipos de parametro
            Console.WriteLine("\nTipos de parámetros");
            Console.WriteLine("- Los parámetros de un método podrán ser pasados como copia o como referencia");
            Console.WriteLine("- Las modificaciones sobre los parámetros pasados como copia no permanecerán tras salir del método");
            Console.WriteLine("- Las modificaciones sobre los parámetros pasados como copia no permanecerán tras salir del método");
            Console.WriteLine("- Las modificaciones sobre los parámetros pasados como referencia permanecerán tras salir del método");
            Console.WriteLine("- Dependiendo del lenguaje esta especificación se realiza de manera automática o puede forzarse");
            Console.WriteLine("- Dependiendo del lenguaje hay tipos de datos que solo se pasarán como copia o referencia");
            Console.WriteLine("- Dependiendo del lenguaje encontramos otros parámetros, como los parámetros de salida");
            var text = "Hola";
            Console.WriteLine($"- Valor de text = {text} antes de llamar a la función por copia");
            ModifyText(text);
            Console.WriteLine($"- Valor de text = {text} después de llamar a la función por copia");

            text = "Hola";
            Console.WriteLine($"- Valor de text = {text} antes de llamar a la función por referencia");
            ModifyText(ref text);
            Console.WriteLine($"- Valor de text = {text} después de llamar a la función por referencia");

            // Recursividad
            Console.WriteLine("\nRecursividad");
            Console.WriteLine("- Entendemos como recursividad llamar un método dentro del mismo método");
            Console.WriteLine("- Recurso utilizado sobretodo para la iteración de estructuras avanzadas");
            Console.WriteLine("- Dependiendo de la colocación del bloque de procesado (antes o después de la recursividad), se ejecutará en orden inverso");
            Console.WriteLine("- Suele componerse de un bloque común y un punto que bifurca entre el avance y la condición de salida");
            Console.WriteLine("- Toda recursividad se puede reescribir utilizando un bucle, mejorando la optimización pero suele dificultar la lectura");
            Console.WriteLine("- Advertencia: Cuidado con provocar un stack overflow (sobrecarga de la pila de llamadas) (bucle infinito)");
            Console.WriteLine("- Ejecución de la llamada recursiva: BeforeRecursivity(0, 10)");
            BeforeRecursivity(0, 10);
            Console.WriteLine("- Ejecución de la llamada recursiva: AfterRecursivity(0, 10)");
            AfterRecursivity(0, 10);
        }

        private static float SimpleEquation(float a, float b) {
            return -b / a;
        }

        private static void PrintText() {
            Console.WriteLine("Hello world");
        }

        private static void PrintText(string text) {
            Console.WriteLine(text);
        }

        private static void PrintText(float number) {
            Console.WriteLine($"{number:##.00}");
        }

        private static void PrintText(params string[] text) {
            Console.WriteLine(string.Join(' ', text));
        }

        private static string ToUpperCase(string text) {
            return text.ToUpperInvariant();
        }

        private static void ModifyText(string text) {
            text = text.ToUpperInvariant();
            Console.WriteLine($"Valor dentro de ModifyText: {text}");
        }

        private static void ModifyText(ref string text) {
            text = text.ToUpperInvariant();
            Console.WriteLine($"Valor dentro de ModifyText: {text}");
        }

        private static void ModifyText(string text, out string result) {
            result = text.ToUpperInvariant();
        }

        private static void BeforeRecursivity(int value, int maxValue) {
            Console.WriteLine($"BeforeRecursivity value: {value}, maxValue: {maxValue}");

            if (value > maxValue - 1) return;
            else BeforeRecursivity(value + 1, maxValue);
        }

        private static void AfterRecursivity(int value, int maxValue) {
            if (value > maxValue - 1) return;
            else AfterRecursivity(value + 1, maxValue);

            Console.WriteLine($"AfterRecursivity value: {value}, maxValue: {maxValue}");
        }
    }
}
