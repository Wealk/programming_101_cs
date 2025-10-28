using Programming101CS.Helpers;
using Programming101CS.Practice.Solution.Classes;
using Programming101CS.Practice.Solution.Classes.Dungeon;
using Programming101CS.Practice.Solution.Classes.Entities;

namespace Programming101CS.Practice.Solution {
    internal class DungeonSearcher {
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
                var dungeon = new Dungeon(FLOORS, dungeonSize);

                Console.WriteLine("Eligiendo localizaciones...");
                dungeon.AddStairs();
                dungeon.AddTreasure();

                Console.WriteLine("Posicionando enemigos...");
                var enemies = new List<Enemy>();
                for (var i = 1; i <= FLOORS; i++) {
                    for (var e = i; e > 0; e--) {
                        var position = dungeon.GetAvailableRandomPosition(i - 1, enemies);
                        enemies.Add(new Enemy(position));
                    }
                }

                Console.WriteLine("Entrando jugador...");
                var wallPosition = dungeon.GetAvailableRandomWallPosition(0, enemies);
                var adventurer = new Adventurer(wallPosition);

                PrintTools.WriteLine("\n¡Todo listo! Que empiece el juego", ConsoleColor.Yellow);
                Console.Write("\nPULSA CUALQUIER TECLA CUANDO ESTÉS LISTO PARA EMPEZAR ");
                _ = Console.ReadKey();

                GameLoop(dungeon, adventurer, [.. enemies]);
            }

            PrintTools.WriteLine("\nFIN DEL JUEGO\n", ConsoleColor.Magenta);
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

        private static DirectionType? GetUserInput(DirectionType[] availableDirections) {
            var available = string.Join(", ", availableDirections);

            DirectionType? direction = null;
            var hasValidInput = false;
            while (!hasValidInput) {
                Console.Write($"¿A qué dirección quieres ir? ({available}): ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) {
                    hasValidInput = true;
                    direction = null;
                } else {
                    switch (key.KeyChar) {
                        case 'W':
                        case 'w':
                            hasValidInput = true;
                            direction = DirectionType.North;
                            break;
                        case 'D':
                        case 'd':
                            hasValidInput = true;
                            direction = DirectionType.East;
                            break;
                        case 'S':
                        case 's':
                            hasValidInput = true;
                            direction = DirectionType.South;
                            break;
                        case 'A':
                        case 'a':
                            hasValidInput = true;
                            direction = DirectionType.West;
                            break;
                    }

                    if (!availableDirections.Any(ad => ad == direction)) {
                        hasValidInput = false;
                        direction = null;

                        PrintTools.WriteLine("\tNop, Intenta de nuevo :)", ConsoleColor.Red);
                    }
                }
            }

            return direction;
        }

        private static void GameLoop(Dungeon dungeon, Adventurer player, Enemy[] enemies) {
            var isPlaying = true;
            while (isPlaying) {
                PrintTools.ClearConsole();
                dungeon.PrintDungeon(player, enemies);

                var availableDirections = dungeon.GetAvailableDirections(player);
                var userDirection = GetUserInput(availableDirections);
                if (!userDirection.HasValue) {
                    Console.WriteLine("Saliendo de la mazmorra...");
                    isPlaying = false;
                } else {
                    player.Move(userDirection.Value);
                    if (dungeon.StairsPosition.Any(s => s == player.Position)) player.ChangeFloor();

                    if (enemies.Any(e => e.Position == player.Position)) {
                        isPlaying = false;
                        PrintTools.ClearConsole();
                        dungeon.PrintDungeon(player, enemies);
                        PrintTools.WriteLine("\nEl jugador ha sido eliminado...", ConsoleColor.Red);
                    }

                    foreach (var enemy in enemies) {
                        availableDirections = dungeon.GetAvailableDirections(enemy, enemies);
                        enemy.Move(availableDirections);
                        if (enemy.Position == player.Position) {
                            isPlaying = false;
                            PrintTools.ClearConsole();
                            dungeon.PrintDungeon(player, enemies);
                            PrintTools.WriteLine("\nEl jugador ha sido eliminado...", ConsoleColor.Red);
                            break;
                        }
                    }

                    if (isPlaying && player.Position == dungeon.TreasurePosition) {
                        isPlaying = false;
                        PrintTools.ClearConsole();
                        dungeon.PrintDungeon(player, enemies);
                        PrintTools.WriteLine("\n¡El jugador ha encontrado el tesoro!", ConsoleColor.Yellow);
                    }
                }
            }
        }
    }
}
