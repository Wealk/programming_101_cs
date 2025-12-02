using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter04_01 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(5, "Programación orientada a objetos: Tipos de objetos", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            message.AppendLine("- Para poder definir nuestras entidades encontramos varios tipos de objetos");
            message.AppendLine("- Cada objeto y cada tipo tiene sus características que veremos aquí");

            // Primitivos
            message.AppendLine("\nPrimitivos");
            message.AppendLine("- Como ya hemos visto, los primitivos conforman los tipos esenciales");
            message.AppendLine("- Construiremos el resto de estructura combinando primitivos y funcionalidades");
            message.AppendLine("- A diferencia del resto de tipos que veremos, no podemos generar primitivos propios");
            bool boolean;
            byte byteNumber; sbyte signedByteNumber;
            short shortNumber; ushort unsignedShortNumber;
            int integerNumber; uint unsignedIntegerNumber;
            long longNumber; ulong unsignedLongNumber;
            float floatNumber;
            double doubleNumber;
            decimal decimalNumber;
            char character;
            string text;

            // Enumerados
            message.AppendLine("\nEnumerados");
            message.AppendLine("- Los enumerados nos permiten definir un conjunto de valores posibles para una variable");
            message.AppendLine("- Nos ayudan a mejorar la legibilidad del código y evitar errores");
            message.AppendLine("- Por ejemplo: DayOfWeek, para los días de la semana, o ConsoleColor para los colores de la consola");
            message.AppendLine("- Podemos definir nuestros propios enumerados usando la palabra clave 'enum' y con la estructura enum [nombre del enumerado] { [lista de opciones separadas por coma] }");
            DayOfWeek dow = DayOfWeek.Monday;
            ConsoleColor consoleColor = ConsoleColor.Red;
            PlayerStatus status = PlayerStatus.Sleep;

            // Estructuras
            message.AppendLine("\nEstructuras");
            message.AppendLine("- Las estructuras son tipos de datos que agrupan varios valores relacionados");
            message.AppendLine("- A diferencia de las clases, las estructuras son tipos de valor lo que implica una gestión interna diferente a las clases al ser usadas como parámetros");
            message.AppendLine("- Por ejemplo: DateTime o TimeSpan");
            message.AppendLine("- Podemos definir nuestras propias estructuras usando la palabra calve 'struct' y con la estructura [modificador de acceso] struct [nombre de la estructura] { [lista de propiedades, variables y métodos] }");
            DateTime now = DateTime.Now;
            TimeSpan duration = new TimeSpan(1, 30, 0);
            Vector2 position = new Vector2(10.5f, 20.3f);

            // Clases
            message.AppendLine("\nClases");
            message.AppendLine("- Las clases son tipos de datos que pueden contener datos y funcionalidades");
            message.AppendLine("- A diferencia de las estructuras, las clases son tipos de referencia y se gestionan con un acceso directo a la referencia al ser usadas como parámetros");
            message.AppendLine("- Por ejemplo: Queue<T>, List<T>, o cualquier clase que definamos nosotros mismos");
            message.AppendLine("- Podemos definir nuestras propias clases usando la palabra clave 'class' y con la estructura [modificador de acceso] class [nombre de la clase] { [lista de propiedades, variables y métodos] }");
            Queue<string> queue = new Queue<string>();
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Player player = new Player("Wealk", 1, 5.0f);

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();


            return message.ToString();
        }

        private enum PlayerStatus {
            None,
            Posion,
            Confusion,
            Blind,
            Paralysis,
            Sleep,
            Freeze,
            Burn,
            Curse
        }

        private struct Vector2 {
            public float x;
            public float y;

            public Vector2(float x, float y) {
                this.x = x;
                this.y = y;
            }
        }

        private class Player {
            public string name;
            public int level;
            public PlayerStatus status;
            public float movementSpeed;

            public Player(string name, int level, float movementSpeed) {
                this.name = name;
                this.level = level;
                status = PlayerStatus.None;
                this.movementSpeed = movementSpeed;
            }
        }
    }
}
