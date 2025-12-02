namespace Programming101CS.Syllabus.Solutions {
    internal class Chapter03_04 {
        public void Main() {
            // a) Implementa una función pública \"StringToUpperCase\" que dado un string devuelva una lista de chars con el mismo string pero con las letras en mayúsculas utilizando un \"foreach\" y la función char.ToUpperInvariant(item). Prueba la función con el mensaje \"Hola mundo\" mostrando el texto antes y después por consola:
            string text = "Hola mundo";
            List<char> upperText = StringToUpperCase(text);
            Console.Write($"{text} -> ");
            foreach (char item in upperText)
                Console.Write(item);
            Console.WriteLine();

            // b) Implementa una función pública \"IsEven\" que dado un número entero te diga si es par. Prueba la función con 0, con 20 y con 7 y muestra los resultados por consola:
            Console.WriteLine($"0 -> {IsEven(0)}");
            Console.WriteLine($"20 -> {IsEven(20)}");
            Console.WriteLine($"7 -> {IsEven(7)}");

            // c) Implementa una función pública \"GetNextEvenNumber\" que dado un número entero, y utilizando la función anterior, te de el número par más próximo por arriba, en caso de que no sea par y el propio número si es par:
            Console.WriteLine($"0 -> {GetNextEvenNumber(0)}");
            Console.WriteLine($"20 -> {GetNextEvenNumber(20)}");
            Console.WriteLine($"7 -> {GetNextEvenNumber(7)}");

            // d) Implementa un método público \"RoundUpFloat\" que dado un float, lo modifique redondeándolo hacia arriba con la operación Math.Ceiling(number). Prueba la función con los valores 1.2f, 1.7f, 2.5f:
            float value = 1.2f; RoundUpFloat(ref value);
            Console.WriteLine($"1.2f -> {value}");

            value = 1.7f; RoundUpFloat(ref value);
            Console.WriteLine($"1.7f -> {value}");

            value = 2.5f; RoundUpFloat(ref value);
            Console.WriteLine($"2.5f -> {value}");

            // e) Implementa una función pública \"VowelCount\" que dado un string devuelva un entero con el número de vocales que tenga. Ayúdate de un \"foreach\" y de la comprobación \"\"aeiouAEIOU\".Contains(item)\". Prueba la función con el texto \"Hello world\":
            Console.WriteLine($"Hello world -> {VowelCount("Hello world")}");

            // f) Implementa una función pública \"GetNextSunday\" que dada una fecha tipo DateTime, te devuelva un DateTime con el domingo más próximo. Usando la comprobación \"date.DayOfWeek != DayOfWeek.Sunday\" y la instrucción \"date = date.AddDays(1)\". Prueba la función con el parámetro DateTime.Today, que da la fecha de hoy:
            Console.WriteLine($"{DateTime.Today} -> {GetNextSunday(DateTime.Today)}");

            // g) Implementa un método público \"SetToFirstDayOfMonth\" que dada una fecha tipo DateTime, modifique el valor del parámetro para ponerlo al primer día del mes. Utiliza la propiedad date.Day junto a  date = date.AddDays(...) y llamando a la función mediante DateTime.Today que da la fecha de hoy:
            DateTime date = DateTime.Today; SetToFirstDayOfMonth(ref date);
            Console.WriteLine($"{DateTime.Today} -> {date}");

            // h) Implementa un método público \"SplitCharacters\" que dado un string devuelva, utilizando un parámetro array out char[], los carácteres por separado. Utiliza la instrucción \"result = new char[text.lenght]\" para iniciarlar el array resultante y ayúdate de un \"for\" para recorrer el texto. Prueba el método con el texto \"Hello world\":
            text = "Hola mundo";
            SplitCharacters(text, out char[] characters);
            Console.Write($"{text} -> ");
            foreach (char item in characters)
                Console.Write(item);
            Console.WriteLine();

            // i) Mediante una función pública \"GetLastCharacter\" recursiva busca el último carácter de un string. Ayúdate de la función \"text.Lenght\" para conocer la longitud del string y de la instrucción \"text.Substring(1)\" para devolver un string sin el primer carácter. Prueba el método con el texto \"Hello world\":
            Console.WriteLine($"Hello world -> {GetLastCharacter("Hello world")}");
        }

        public List<char> StringToUpperCase(string text) {
            var result = new List<char>();
            foreach (char item in text)
                result.Add(char.ToUpperInvariant(item));

            return result;
        }

        public bool IsEven(int number) {
            return number % 2 == 0;
        }

        public int GetNextEvenNumber(int number) {
            if (IsEven(number)) return number;
            else return number + 1;
        }

        public void RoundUpFloat(ref float number) {
            number = (float)Math.Ceiling(number);
        }

        public int VowelCount(string text) {
            int vowels = 0;
            foreach (char item in text)
                if ("aeiouAEIOU".Contains(item))
                    vowels++;

            return vowels;
        }

        public DateTime GetNextSunday(DateTime date) {
            while (date.DayOfWeek != DayOfWeek.Sunday)
                date = date.AddDays(1);
            return date;
        }

        public void SetToFirstDayOfMonth(ref DateTime date) {
            date = date.AddDays(1 - date.Day);
        }

        public void SplitCharacters(string text, out char[] result) {
            result = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
                result[i] = text[i];
        }

        public char GetLastCharacter(string text) {
            if (text.Length == 1) return text[0];
            else return GetLastCharacter(text.Substring(1));
        }
    }
}
