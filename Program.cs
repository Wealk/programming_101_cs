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
                    switch (input) {
                        case 1:
                            PrintTools.WriteLine($"{input}- TIPOS DE DATOS PRIMITIVOS", ConsoleColor.Yellow);
                            Syllabus.Primitives.Information();
                            Console.Write("\n\n");
                            PrintTools.WriteLine("EJERCICIOS", ConsoleColor.Cyan);
                            Syllabus.Exercices.Primitives.Statement();
                            if (ReadSolutionInput()) {
                                Console.WriteLine("\n\n");
                                PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                                Syllabus.Exercices.Solutions.Primitives.Solution();
                                Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                                _ = Console.ReadKey();
                            }
                            break;
                        case 2:
                            PrintTools.WriteLine($"{input}- OPERADORES", ConsoleColor.Yellow);
                            Syllabus.Operators.Information();
                            Console.Write("\n\n");
                            PrintTools.WriteLine("EJERCICIOS", ConsoleColor.Cyan);
                            Syllabus.Exercices.Operators.Statement();
                            if (ReadSolutionInput()) {
                                Console.WriteLine("\n\n");
                                PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                                Syllabus.Exercices.Solutions.Operators.Solution();
                                Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                                _ = Console.ReadKey();
                            }
                            break;
                        case 3:
                            PrintTools.WriteLine($"{input}- CONTROL DEL FLUJO DE EJECUCIÓN", ConsoleColor.Yellow);
                            Syllabus.ControlFlow.Information();
                            Console.Write("\n\n");
                            PrintTools.WriteLine("EJERCICIOS", ConsoleColor.Cyan);
                            Syllabus.Exercices.ControlFlow.Statement();
                            if (ReadSolutionInput()) {
                                Console.WriteLine("\n\n");
                                PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                                Syllabus.Exercices.Solutions.ControlFlow.Solution();
                                Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                                _ = Console.ReadKey();
                            }
                            break;
                        case 4:
                            PrintTools.WriteLine($"{input}- CONJUNTOS", ConsoleColor.Yellow);
                            Syllabus.Sets.Information();
                            Console.Write("\n\n");
                            PrintTools.WriteLine("EJERCICIOS", ConsoleColor.Cyan);
                            Syllabus.Exercices.Sets.Statement();
                            if (ReadSolutionInput()) {
                                Console.WriteLine("\n\n");
                                PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                                Syllabus.Exercices.Solutions.Sets.Solution();
                                Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                                _ = Console.ReadKey();
                            }
                            break;
                        case 5:
                            PrintTools.WriteLine($"{input}- MÉTODOS", ConsoleColor.Yellow);
                            Syllabus.Methods.Information();
                            Console.Write("\n\n");
                            PrintTools.WriteLine("EJERCICIOS", ConsoleColor.Cyan);
                            Syllabus.Exercices.Methods.Statement();
                            if (ReadSolutionInput()) {
                                Console.WriteLine("\n\n");
                                PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                                Syllabus.Exercices.Solutions.Methods.Solution();
                                Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                                _ = Console.ReadKey();
                            }
                            break;
                        case 6:
                            PrintTools.WriteLine($"{input}- PROGRAMACIÓN ORIENTADA A OBJECTO (POO/OOP)", ConsoleColor.Yellow);
                            Syllabus.ObjectOrientedProgramming.Information();
                            Console.Write("\n\n");
                            PrintTools.WriteLine("EJERCICIOS", ConsoleColor.Cyan);
                            Syllabus.Exercices.ObjectOrientedProgramming.Statement();
                            if (ReadSolutionInput()) {
                                Console.WriteLine("\n\n");
                                PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                                Syllabus.Exercices.Solutions.ObjectOrientedProgramming.Solution();
                                Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                                _ = Console.ReadKey();
                            }
                            break;
                        case 7:
                            PrintTools.WriteLine($"{input}- CONJUNTOS AVANZADOS", ConsoleColor.Yellow);
                            Syllabus.AdvancedSets.Information();
                            Console.Write("\n\n");
                            PrintTools.WriteLine("EJERCICIOS", ConsoleColor.Cyan);
                            Syllabus.Exercices.AdvancedSets.Statement();
                            if (ReadSolutionInput()) {
                                Console.WriteLine("\n\n");
                                PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                                Syllabus.Exercices.Solutions.AdvancedSets.Solution();
                                Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                                _ = Console.ReadKey();
                            }
                            
                            break;
                        case 8:
                            PrintTools.WriteLine($"{input}- PRACTICA FINAL", ConsoleColor.Yellow);
                            Practice.Statement.Information();
                            Console.Write("\n\n");
                            PrintTools.WriteLine("PASOS RECOMENDADOS", ConsoleColor.Cyan);
                            Practice.Statement.RecommendedSteps();
                            if (ReadSolutionInput()) {
                                Console.WriteLine("\n\n");
                                PrintTools.WriteLine("SOLUCIONES", ConsoleColor.Cyan);
                                Syllabus.Exercices.Solutions.ObjectOrientedProgramming.Solution();
                                Console.Write("\n\nPULSA CUALQUIER TECLA PARA VOLVER AL MENÚ");
                                _ = Console.ReadKey();
                            }
                            break;
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
            PrintTools.WriteLine("https://x.com/wealk_dev \n", ConsoleColor.Cyan);

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
            var option = 0;

            Console.Write("Opción: ");
            var keyPressed = Console.ReadKey();

            while (keyPressed.Key != ConsoleKey.Escape && (keyPressed.Key < ConsoleKey.D0 || keyPressed.Key > ConsoleKey.D8)) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" \tNop, Intenta de nuevo :)\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Opción: ");
                keyPressed = Console.ReadKey();
            }

            if (keyPressed.Key >= ConsoleKey.D1 && keyPressed.Key <= ConsoleKey.D8)
                option = keyPressed.KeyChar - '0';

            return option;
        }

        private static bool ReadSolutionInput() {
            Console.Write("\n\nPULSA Y PARA VER EL RESULTADO DE LAS SOLUCIONES O CUALQUIER OTRA TECLA PARA VOLVER AL MENÚ");
            return Console.ReadKey().Key == ConsoleKey.Y;

        }
    }
}
