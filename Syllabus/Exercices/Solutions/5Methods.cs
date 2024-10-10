namespace Programming101CS.Syllabus.Exercices.Solutions {
    internal class Methods {
        public static void Solution() {
            Console.WriteLine("a) Implementa una función privada que dado un string devuelva un array de chars con el mismo string con las letras 'a'-'z' convertidas a 'A'-'Z' utilizando un \"foreach\" y la función char.ToUpperInvariant(item):");
            Console.WriteLine($"Ejercicio a: ExerciceA(\"HoLa YouTUBE\"), Result={{{string.Join(", ", ExerciceA("HoLa YouTUBE"))}}}");

            Console.WriteLine("\nb) Implementa una función privada que dado un número entero te diga si es par:");
            Console.WriteLine($"Ejercicio b: ExerciceB(0)={ExerciceB(0)}, ExerciceB(5)={ExerciceB(5)}, ExerciceB(8)={ExerciceB(8)}.");

            Console.WriteLine("\nc) Implementa una función protected que dado un número entero, y utilizando la función anterior, te de el número par más próximo por arriba, en caso de que no sea par y el propio número si es par:");
            Console.WriteLine($"Ejercicio c: ExerciceC(0)={ExerciceC(0)}, ExerciceC(5)={ExerciceC(5)}, ExerciceC(8)={ExerciceC(8)}.");

            Console.WriteLine("\nd) Implementa un método protected que dado un float, lo modifique redondeándolo hacia arriba con la operación Math.Ceiling(number):");
            Console.Write("Ejercicio d: ");
            var number = 0.5f;
            Console.Write($"number={number}, ");
            ExerciceD(ref number);
            Console.Write($"ExerciceD(ref number), number={number}, ");
            number = 15.05f;
            Console.Write($"number={number}, ");
            ExerciceD(ref number);
            Console.WriteLine($"ExerciceD(ref number), number={number}");

            Console.WriteLine("\ne) Implementa una función pública que dado un string cuente cuantas vocales hay:");
            Console.WriteLine($"Ejercicio e: ExerciceE(\"HolA\")={ExerciceE("HolA")}, ExerciceE(\"QuE es lO quE quIeRes\")={ExerciceE("QuE es lO quE quIeRes")}");

            Console.WriteLine("\nf) Implementa una función pública que dada una fecha tipo DateTime, te devuelva un DateTime con el domingo más próximo. Usa la propiedad date.DayOfWeek, la función date = date.AddDays(1) y llamando a la función mediante DateTime.Today que da la fecha de hoy:");
            Console.Write("Ejercicio f:");
            var date = DateTime.Today;
            Console.Write($" date={date}, ExerciceF(date)={ExerciceF(date)}, date={date},");
            date = DateTime.Today.AddDays(-35);
            Console.WriteLine($" date={date}, ExerciceF(date)={ExerciceF(date)}, date={date}");

            Console.WriteLine("\ng) Implementa un método público que dada una fecha tipo DateTime, modifique el valor del parámetro para ponerlo al primer día del mes. Utiliza la propiedad date.Day junto a date = date.AddDays(...) y llamando a la función mediante DateTime.Today que da la fecha de hoy:");
            Console.Write("Ejercicio g: ");
            date = DateTime.Today;
            Console.Write($"date={date}, ");
            ExerciceG(ref date);
            Console.Write($"ExerciceG(ref date), date={date}, ");
            date = DateTime.Today.AddDays(-35);
            Console.Write($"date={date}, ");
            ExerciceG(ref date);
            Console.WriteLine($"ExerciceG(ref date), date={date}");

            Console.WriteLine("\nh) Implementa mediante un método privado la inversión de su parámetro string (Hola => aloH). Ayúdate de una función recursiva auxiliar y de la función text.Substring(1) para aplicar la recursividad:");
            Console.Write($"Ejercicio h: ");
            var text = "Hola";
            Console.Write($"text={text}, ");
            ExerciceH(ref text);
            Console.Write($"ExerciceH(text), text={text}, ");
            text = "QuE es lO quE quIeRes";
            Console.Write($"text={text}, ");
            ExerciceH(ref text);
            Console.WriteLine($"ExerciceH(text), text={text} ");

            Console.WriteLine("\ni) Mediante una función protected recursiva búsca el último carácter de un string. Ayúdate de la función text.Lenght para conocer la longitud del string y la misma función text.Substring(1) para aplicar la recursividad:");
            Console.Write($"Ejercicio i: ExerciceI(\"Hola\")={ExerciceI("Hola")}, ExerciceI(\"QuE es lO quE quIeRes\")={ExerciceI("QuE es lO quE quIeRes")}");
        }

        private static char[] ExerciceA(string text) {
            var result = new char[text.Length];
            var index = 0;
            foreach (var character in text) {
                var processedCharacter = character >= 'a' && character <= 'z' ? char.ToUpperInvariant(character) : character;
                result[index++] = processedCharacter;
            }

            return result;
        }

        private static bool ExerciceB(int number) {
            return number % 2 == 0;
        }

        protected static int ExerciceC(int number) {
            return ExerciceB(number) ? number : number + 1;
        }

        protected static void ExerciceD(ref float number) {
            number = (float)Math.Ceiling(number);
        }

        public static int ExerciceE(string text) {
            var result = 0;
            foreach (var character in text)
                if (character == 'a' || character == 'A' || character == 'e' || character == 'E' || character == 'i' || character == 'I' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
                    result++;

            return result;
        }

        public static DateTime ExerciceF(DateTime date) {
            while (date.DayOfWeek != DayOfWeek.Sunday)
                date = date.AddDays(1);

            return date;
        }

        public static void ExerciceG(ref DateTime date) {
            date = date.AddDays(-date.Day + 1);
        }

        private static void ExerciceH(ref string text) {
            text = ExerciceHAux(text);
        }

        private static string ExerciceHAux(string text) {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return ExerciceHAux(text.Substring(1)) + text[0];
        }

        protected static char ExerciceI(string text) {
            if (text.Length == 1) return text[0];
            else return ExerciceI(text.Substring(1));
        }
    }
}
