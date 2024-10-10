namespace Programming101CS.Syllabus.Exercices.Solutions {
    internal class Primitives {
        public static void Solution() {
            Console.WriteLine("a) Declara una variable bool llamada \"exerciceA\" inicializada a true:");
            var exerciceA = true;
            Console.WriteLine("Ejercicio a: var exerciceA = true;");

            Console.WriteLine("\nb) Declara una variable de tipo int llamada \"result\" sin inicializar:");
            int result;
            Console.WriteLine("Ejercicio b: int result;");

            Console.WriteLine("\nc) Declara una variable double llamada \"subsection\" inicializada a 1.25d:");
            var subsection = 1.25d;
            Console.WriteLine("Ejercicio c: var subsection = 1.25d;");

            Console.WriteLine("\nd) Declara una variable decimal llamada \"section\" inicializada a subsection casteado a decimal:");
            var section = (decimal)subsection;
            Console.WriteLine("Ejercicio d: var section = (decimal)subsection;");

            Console.WriteLine("\ne) Declara una variable char llamada \"character\" inicializada al caracter 'Z':");
            char character = 'Z';
            Console.WriteLine("Ejercicio e: char character = 'Z';");

            Console.WriteLine("\nf) Declara una variable string llamada \"text\" inicializada al texto \"Hello world\":");
            var text = "Hello world";
            Console.WriteLine("Ejercicio f: var text = \"Hello world\";");

            Console.WriteLine("\ng) Declara una variable unsigned int llamada \"charToUInt\" inicializada a \"character\" casteado a int:");
            uint charToUInt = (uint)character;
            Console.WriteLine("Ejercicio g: uint charToUInt = (uint)character;");

            Console.WriteLine("\nh) Asigna la variable \"result\" al valor 35:");
            result = 35;
            Console.WriteLine("Ejercicio h: result = 35;");

            Console.WriteLine("\ni) Declara una variable long llamada \"intToLong\" inicializada a \"result\" casteado a long:");
            long intToLong = (long)result;
            Console.WriteLine("Ejercicio i: long intToLong = (long)result;");
        }
    }
}
