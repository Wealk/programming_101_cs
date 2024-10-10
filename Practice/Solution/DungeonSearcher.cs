using Programming101CS.Helpers;
using Programming101CS.Practice.Solution.Classes;
using Programming101CS.Practice.Solution.Classes.Dungeon;

namespace Programming101CS.Practice.Solution {
    internal class DungeonSearcher {
        public static Dungeon Dungeon { get; set; }
        private const int FLOORS = 2;

        public static void StartAdventure() {
            PrintTools.ClearConsole();
            Console.Write("Bienvenido a ");
            PrintTools.Write("DUNGEON SEARCHER", ConsoleColor.Red);
            Console.WriteLine(", el juego de aventuras esperado por todos.");
            Console.WriteLine("Empieza tu aventura decidiendo de que tamaño quieres que sea la mazmorra a explorar.");
            Console.WriteLine("Para que no te aburras hemos limitado el tamaño de la mazmorra a un mínimo de 4 y un máximo de 10.");
            PrintTools.WriteLine("Ha llegado el momento...\n\n", ConsoleColor.Yellow);

            var dungeonSize = GetDungeonSize();
            if (dungeonSize > 0) {
                Console.WriteLine("Instanciando mazmorra...");
                Console.WriteLine("Eligiendo localizaciones...");
                Console.WriteLine("Posicionando enemigos...");
                Console.WriteLine("Entrando jugador...");

                PrintTools.WriteLine("¡Todo listo! Que empiece el juego", ConsoleColor.Yellow);
                Console.Write("PULSA CUALQUIER TECLA CUANDO ESTÉS LISTO PARA EMPEZAR ");
                _ = Console.ReadKey();

                GameLoop();
            }

            PrintTools.WriteLine("FIN DEL JUEGO", ConsoleColor.Magenta);
        }

        private static int GetDungeonSize() {
            var input = 0;
            while (input == 0) {
                Console.Write("Elige el tamaño de tu mazmorra entre 4 y 10 incluídos (vacio para salir): ");

                var lineInput = Console.ReadLine();
                if (int.TryParse(lineInput, out var number) && number >= 4 && number <= 10) input = number;
                else if (string.IsNullOrEmpty(lineInput)) input = -1;
                else PrintTools.WriteLine("Nop, Intenta de nuevo :)", ConsoleColor.Red);
            }

            return input;
        }

        private static int GetUserInput(DirectionType[] availableDirections) {
            var available = string.Join(", ", availableDirections);
            var input = 0;
            while (input == 0) {
                Console.Write($"¿A qué dirección quieres ir? ({available}): ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) input = -1;
                else if (int.TryParse($"{key.KeyChar}", out var inputInt) && Enum.IsDefined(typeof(DirectionType), inputInt)) input = inputInt;
                else PrintTools.WriteLine("Nop, Intenta de nuevo :)", ConsoleColor.Red);
            }

            return input;
        }

        private static void GameLoop() {
            var isPlaying = true;
            while (isPlaying) {
                PrintTools.ClearConsole();
                // Print dungeon state
                // Get available movements for the player
                // Process user input
                // Update enemy positions
                // Check win/lose condition
            }
        }
    }
}
