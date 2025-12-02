using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter04_03 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(7, "Programación orientada a objetos: Implementación y herencia", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            message.Append("- En esta sección, exploraremos dos conceptos fundamentales de la programación orientada a objetos: las interfaces y la herencia");
            message.Append("- Estos conceptos nos permiten crear sistemas más flexibles, reutilizables y mantenibles al definir contratos y relaciones entre clases");

            // Interfaces
            message.AppendLine("\nInterfaces");
            message.AppendLine("- Las interfaces nos permiten definir la estructura que tendrá definir obligatoriamente la clase o struct que la implemente");
            message.AppendLine("- Puede contener definiciones de métodos, propiedades, eventos e indexadores");
            message.AppendLine("- No pueden contener implementación de métodos ni campos");
            message.AppendLine("- Se definen usando la palabra clave 'interface' y con la estructura [modificador de acceso] interface [nombre de la interfaz] { [lista de métodos, propiedades, eventos e indexadores] }");
            message.AppendLine("- Una clase o estructura puede implementar múltiples interfaces usando la sintaxis: class [nombre de la clase] : [interfaz1], [interfaz2], ... { ... }");
            message.AppendLine("- Al implementar una interfaz, la clase o estructura debe proporcionar una implementación para todos los miembros definidos en la interfaz");
            message.AppendLine("- Las interfaces son útiles para promover la reutilización del código a través de la herencia múltiple de comportamientos");
            IGameEntity player = new Player();
            IGameEntity enemy = new Enemy();
            UpdateEntity(player);
            UpdateEntity(enemy);

            // Herencia
            message.AppendLine("\nHerencia");
            message.AppendLine("- La herencia nos permite crear nuevas clases basadas en clases existentes");
            message.AppendLine("- La clase derivada hereda los miembros (propiedades, métodos, etc.) de la clase base");
            message.AppendLine("- Se define usando la sintaxis: class [nombre de la clase derivada] : [nombre de la clase base] { ... }");
            message.AppendLine("- La herencia promueve la reutilización del código y facilita la creación de jerarquías de clases");
            message.AppendLine("- Una clase puede heredar de una sola clase base (herencia simple), pero puede implementar múltiples interfaces");
            message.AppendLine("- Podemos usar la palabra clave 'base' para acceder a miembros de la clase base desde la clase derivada");
            message.AppendLine("- La herencia es un concepto fundamental en la programación orientada a objetos y nos permite modelar relaciones entre entidades de manera efectiva");
            Warrior warrior = new Warrior();
            Mage mage = new Mage();
            Thief thief = new Thief();
            warrior.Strenght = 10.0f;
            mage.Mana = 50.0f;
            thief.Agility = 15.0f;

            // Relación entre clases
            message.AppendLine("\nRelación entre clases");
            message.AppendLine("- Cuando encontramos una jerarquía entre las clases, podemos acceder a un objeto de una clase determinada, utilizando cualquier clase que esté incluída en esa jerarquía");
            message.AppendLine("- Por ejemplo, si tenemos una clase base Animal y una clase derivada Perro, podemos usar una variable de tipo Animal para referenciar un objeto de tipo Perro");
            message.AppendLine("- Esto nos permite aprovechar el polimorfismo y escribir código más flexible y reutilizable");
            message.AppendLine("- Sin embargo, al acceder a un objeto a través de una referencia de clase base, solo podremos acceder a los miembros definidos en la clase base, a menos que utilicemos casting para acceder a los miembros específicos de la clase derivada");
            message.AppendLine("- Es importante entender cómo funcionan las jerarquías de clases y cómo aprovecharlas para diseñar sistemas orientados a objetos de manera efectiva");
            message.AppendLine("- La relación entre clases es un concepto clave en la programación orientada a objetos y nos permite modelar el mundo real de manera más precisa");
            ((Player)warrior).Initialize();
            ((Player)mage).Update();
            ((Player)thief).Destroy();
            UpdateEntity(warrior);

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();


            return message.ToString();
        }

        private interface IGameEntity {
            public bool ShouldBeDestroyed { get; }

            public void Initialize();
            public void Update();
            public void Destroy();
        }

        private class Player : IGameEntity {
            public bool ShouldBeDestroyed => lives <= 0;

            private int lives;

            public void Initialize() {
                // Inicializa el objeto
            }

            public void Update() {
                // Actualiza el objeto
            }

            public void Destroy() {
                // Destruye el objeto
            }
        }

        private class Enemy : IGameEntity {
            public bool ShouldBeDestroyed => !isAlive;

            private bool isAlive;

            public void Initialize() {
                // Inicializa el objeto
            }

            public void Update() {
                // Actualiza el objeto
            }

            public void Destroy() {
                // Destruye el objeto
            }
        }

        private static void UpdateEntity(IGameEntity entity) {
            entity.Update();
        }

        private class Warrior : Player {
            public float Strenght { get; set; }
        }

        private class Mage : Player {
            public float Mana { get; set; }
        }

        private class Thief : Player {
            public float Agility { get; set; }
        }
    }
}
