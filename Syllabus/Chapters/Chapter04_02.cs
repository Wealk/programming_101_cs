using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter04_02 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(6, "Programación orientada a objetos: Visibilidad y encapsulamiento", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            message.AppendLine("- Vistos los tipos de objetos, nos centraremos sobretodo en las clases");
            message.AppendLine("- Ten en cuenta que gran la información que veamos, puede ser aplicada tambien a los structs");
            message.AppendLine("- Veremos dos conceptos muy importantes: Visibilidad y Encapsulamiento");

            // Visibilidad
            message.AppendLine("\nVisibilidad");
            message.AppendLine("- La visibilidad nos permite controlar qué partes de nuestro código pueden acceder a ciertas propiedades o métodos de una clase");
            message.AppendLine("- Esto es importante para proteger los datos y asegurar que solo se accede a ellos de manera controlada");
            message.AppendLine("- Los modificadores de acceso más comunes son:");
            message.AppendLine("  - public: Accesible desde cualquier parte del código");
            message.AppendLine("  - private: Accesible solo dentro de la clase");
            message.AppendLine("  - protected: Accesible dentro de la clase y en clases derivadas");
            message.AppendLine("  - internal: Accesible solo dentro del mismo ensamblado");
            message.AppendLine("- Podemos combinar estos modificadores para ajustar la visibilidad según nuestras necesidades");
            Player player = new Player();
            // player.level = 10; // Error: 'level' es privado
            // player.name = "Hero"; // Error: 'name' es protegido
            player.health = 100f; // Correcto: 'health' es interno
            player.coins = 50; // Correcto: 'coins' es público

            // Encapsulamiento
            message.AppendLine("\nEncapsulamiento");
            message.AppendLine("- El encapsulamiento es el principio de ocultar los detalles internos de una clase y exponer solo lo necesario");
            message.AppendLine("- Esto ayuda a mantener la integridad de los datos y facilita el mantenimiento del código");
            message.AppendLine("- Podemos lograr el encapsulamiento utilizando propiedades con getters y setters");
            message.AppendLine("- Por ejemplo, podemos tener una propiedad privada y exponerla a través de una propiedad pública que controle cómo se accede o modifica ese valor");
            message.AppendLine("- También podemos usar métodos públicos para realizar operaciones en los datos internos de la clase sin exponerlos directamente");
            message.AppendLine("- De esta manera, podemos asegurar que los datos se manejan de manera segura y consistente");
            message.AppendLine("- El encapsulamiento es una práctica fundamental en la programación orientada a objetos y contribuye a la creación de código robusto y mantenible");
            Vector2 vector2 = new Vector2(1, 2);
            vector2.SetX(10); // Establecemos el valor de la variable sin acceder directamente a ella
            vector2.SetY(20);
            float x = vector2.GetX(); // Obtenemos el valor de la variable sin acceder directamente a ella
            float y = vector2.GetY();

            // Propiedades
            message.AppendLine("\nPropiedades");
            message.AppendLine("- Las propiedades automáticas nos permiten definir propiedades de manera concisa, delegando la gestión del campo de respaldo al compilador");
            message.AppendLine("- Podemos definir propiedades automáticas usando la sintaxis: public [tipo] [NombreDeLaPropiedad] { get; set; }");
            message.AppendLine("- También podemos definir propiedades de solo lectura o solo escritura usando get; o set; respectivamente");
            message.AppendLine("- Además, podemos agregar lógica personalizada en los getters y setters si necesitamos controlar cómo se accede o modifica el valor de la propiedad");
            message.AppendLine("- Por ejemplo, podemos validar un valor antes de asignarlo en el setter o calcular un valor derivado en el getter");
            message.AppendLine("- Las propiedades automáticas son una herramienta útil para simplificar la definición de propiedades en nuestras clases, manteniendo al mismo tiempo el encapsulamiento y la integridad de los datos");
            Vector3 vector3 = new Vector3(1, 2, 3);
            vector3.X = 10; // Usamos la propiedad para establecer el valor
            vector3.Y = 20;
            vector3.Z = 30;
            x = vector3.X; // Usamos la propiedad para obtener el valor
            y = vector3.Y;
            float z = vector3.Z;

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();


            return message.ToString();
        }

        public class Player {
            private int level;
            protected string name;
            internal float health;
            public int coins;
        }

        private struct Vector2 {
            private float x;
            private float y;

            public Vector2(float x, float y) {
                this.x = x;
                this.y = y;
            }

            public float GetX() {
                return x;
            }

            public void SetX(float x) {
                this.x = x;
            }

            public float GetY() {
                return y;
            }

            public void SetY(float y) {
                this.y = y;
            }
        }

        private struct Vector3 {
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }

            public Vector3(float x, float y, float z) {
                X = x;
                Y = y;
                Z = z;
            }
        }
    }
}
