using Programming101CS.Helpers;

namespace Programming101CS {
    public class Program {
        public static void Main() {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int input;
            do {
                ShowMainMenu();
                Console.Write("\n\n");
                input = ReadUserInput();

                if (input >= 1 && input <= 8) {
                    PrintTools.ClearConsole();

                    PrintTools.WriteLine($"{input}- {GetSectionTitle(input)}", ConsoleColor.Yellow);
                    GetSectionSyllabus(input);
                    Console.Write("\n\n");
                    PrintTools.WriteLine(input != 8 ? "EJERCICIOS" : "PASOS RECOMENDADOS", ConsoleColor.Cyan);
                    GetSectionExercicies(input);

                    if (ReadSolutionInput()) {
                        Console.WriteLine("\n\n");
                        PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                        GetSectionSolutions(input);
                        Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                        _ = Console.ReadKey();
                    }

                    PrintTools.ClearConsole();
                }

            } while (input != 0);
        }

        private static void ShowMainMenu() {
            PrintTools.WriteLine("¡BIENVENIDOS AL CURSO DE PROGRAMACIÓN 101!\n", ConsoleColor.Yellow);
            Console.WriteLine("Te recomiendo que sigas los vídeos explicativos con la teoría de cada sección para mejores resultados");
            Console.WriteLine("De esta manera aprenderás a revisar el código buscando la sección correspondiente a la explicación");
            Console.WriteLine("Lo que mejorará tu comprensión y te ayudará a resolver los ejercicos de manera más eficiente");
            Console.WriteLine("Recuerda no frustarte, buscar información siempre que la necesites y intentar hacer las cosas tú mism@");
            Console.WriteLine("Esta bien respaldarte en Google, ChatGPT, StackOverflow, Copilot, ... pero la idea es que aprendas ;)");
            Console.Write("\nMuy bien pues...");
            PrintTools.WriteLine("¡'Allévamos'!", ConsoleColor.Magenta);

            Console.Write("\nCanal de ");
            PrintTools.Write("Youtube", ConsoleColor.Red);
            Console.Write(": ");
            PrintTools.WriteLine("https://www.youtube.com/@wealk_dev", ConsoleColor.Cyan);

            Console.Write("Cuenta de ");
            PrintTools.Write("X (Twitter)", ConsoleColor.DarkGreen);
            Console.Write(": ");
            PrintTools.WriteLine("https://x.com/wealk90 \n", ConsoleColor.Cyan);

            Console.WriteLine("¿Qué capítulo quieres revisar?");
            Console.WriteLine("\t1- Tipos de datos primitivos");
            Console.WriteLine("\t2- Operadores");
            Console.WriteLine("\t3- Control del flujo de ejecución");
            Console.WriteLine("\t4- Conjuntos");
            Console.WriteLine("\t5- Métodos");
            Console.WriteLine("\t6- Programación orientada a objetos");
            Console.WriteLine("\t7- Conjuntos avanzados");
            Console.WriteLine("\t8- Práctica final");
            Console.WriteLine("\n\t0- Salir");
        }

        private static int ReadUserInput() {
            Console.Write("Opción: ");
            var keyPressed = Console.ReadKey();

            var option = 0;
            while (keyPressed.Key != ConsoleKey.Escape && (!int.TryParse($"{keyPressed.KeyChar}", out option) || option < 0 || option > 8)) {
                PrintTools.WriteLine(" \tNop, Intenta de nuevo :)", ConsoleColor.Red);
                Console.Write("Opción: ");
                keyPressed = Console.ReadKey();
            }

            return option;
        }

        private static bool ReadSolutionInput() {
            Console.Write("\n\nPULSA Y PARA VER EL RESULTADO DE LAS SOLUCIONES O CUALQUIER OTRA TECLA PARA VOLVER AL MENÚ");
            return Console.ReadKey().Key == ConsoleKey.Y;
        }

        private static string GetSectionTitle(int input) {
            return input switch {
                1 => "TIPOS DE DATOS PRIMITIVOS",
                2 => "OPERADORES",
                3 => "CONTROL DEL FLUJO DE EJECUCIÓN",
                4 => "CONJUNTOS",
                5 => "MÉTODOS",
                6 => "PROGRAMACIÓN ORIENTADA A OBJECTO (POO/OOP)",
                7 => "CONJUNTOS AVANZADOS",
                8 => "PRACTICA FINAL",
                _ => string.Empty
            };
        }

        private static void GetSectionSyllabus(int input) {
            switch (input) {
                case 1:
                    Syllabus.Primitives.Information();
                    break;
                case 2:
                    Syllabus.Operators.Information();
                    break;
                case 3:
                    Syllabus.ControlFlow.Information();
                    break;
                case 4:
                    Syllabus.Sets.Information();
                    break;
                case 5:
                    Syllabus.Methods.Information();
                    break;
                case 6:
                    Syllabus.ObjectOrientedProgramming.Information();
                    break;
                case 7:
                    Syllabus.AdvancedSets.Information();
                    break;
                case 8:
                    Practice.Statement.Information();
                    break;
            }
        }

        private static void GetSectionExercicies(int input) {
            switch (input) {
                case 1:
                    Syllabus.Exercices.Primitives.Statement();
                    break;
                case 2:
                    Syllabus.Exercices.Operators.Statement();
                    break;
                case 3:
                    Syllabus.Exercices.ControlFlow.Statement();
                    break;
                case 4:
                    Syllabus.Exercices.Sets.Statement();
                    break;
                case 5:
                    Syllabus.Exercices.Methods.Statement();
                    break;
                case 6:
                    Syllabus.Exercices.ObjectOrientedProgramming.Statement();
                    break;
                case 7:
                    Syllabus.Exercices.AdvancedSets.Statement();
                    break;
                case 8:
                    Practice.Statement.RecommendedSteps();
                    break;
            }
        }

        private static void GetSectionSolutions(int input) {
            switch (input) {
                case 1:
                    Syllabus.Exercices.Solutions.Primitives.Solution();
                    break;
                case 2:
                    Syllabus.Exercices.Solutions.Operators.Solution();
                    break;
                case 3:
                    Syllabus.Exercices.Solutions.ControlFlow.Solution();
                    break;
                case 4:
                    Syllabus.Exercices.Solutions.Sets.Solution();
                    break;
                case 5:
                    Syllabus.Exercices.Solutions.Methods.Solution();
                    break;
                case 6:
                    Syllabus.Exercices.Solutions.ObjectOrientedProgramming.Solution();
                    break;
                case 7:
                    Syllabus.Exercices.Solutions.AdvancedSets.Solution();
                    break;
                case 8:
                    Practice.Solution.DungeonSearcher.StartAdventure();
                    break;
            }
        }
    }
}
