namespace Programming101CS.Syllabus.Exercices {
    internal class Methods {
        public static void Statement() {
            Console.WriteLine("a) Implementa una función privada que dado un string devuelva un array de chars con el mismo string con las letras 'a'-'z' convertidas a 'A'-'Z' utilizando un \"foreach\" y la función char.ToUpperInvariant(item):");
            // Solución

            Console.WriteLine("\nb) Implementa una función privada que dado un número entero te diga si es par:");
            // Solución

            Console.WriteLine("\nc) Implementa una función protected que dado un número entero, y utilizando la función anterior, te de el número par más próximo por arriba, en caso de que no sea par y el propio número si es par:");
            // Solución

            Console.WriteLine("\nd) Implementa un método protected que dado un float, lo modifique redondeándolo hacia arriba con la operación Math.Ceiling(number):");
            // Solución

            Console.WriteLine("\ne) Implementa una función pública que dado un string cuente cuantas vocales hay:");
            // Solución

            Console.WriteLine("\nf) Implementa una función pública que dada una fecha tipo DateTime, te devuelva un DateTime con el domingo más próximo. Mirando la propiedad date.DayOfWeek, usando date = date.AddDays(1) y llamando a la función mediante DateTime.Today que da la fecha de hoy:");
            // Solución

            Console.WriteLine("\ng) Implementa un método público que dada una fecha tipo DateTime, modifique el valor del parámetro para ponerlo al primer día del mes. Utiliza la propiedad date.Day junto a  date = date.AddDays(...) y llamando a la función mediante DateTime.Today que da la fecha de hoy:");
            // Solución

            Console.WriteLine("\nh) Implementa mediante un método privado la inversión del parámetro string (Hola => aloH). Ayúdate de una función recursiva auxiliar y de la función text.Substring(1) para aplicar la recursividad:");
            // Solución

            Console.WriteLine("\ni) Mediante una función protected recursiva búsca el último carácter de un string. Ayúdate de la función text.Lenght para conocer la longitud del string:");
            // Solución
        }
    }
}
