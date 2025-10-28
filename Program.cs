using Programming101CS.Helpers;
using Programming101CS.Practice.Solution;
using Programming101CS.Syllabus.Definitions;

namespace Programming101CS {
    public class Program {
        // Private variables
        static SyllabusChapter[] chapters;

        public static void Main() {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            chapters = GetChapters();
            int input;
            do {
                ShowMainMenu();
                Console.Write("\n\n");
                input = ReadUserInput();

                PrintTools.ClearConsole();
                if (input >= 1 && input <= 11) {
                    var chapter = chapters[input - 1];
                    PrintTools.WriteLine($"{chapter.ID}- {chapter.Title.ToUpperInvariant()}\n", ConsoleColor.Yellow);
                    Console.WriteLine(chapter.Information);
                    PrintTools.WriteLine(input != 11 ? "EJERCICIOS" : "PASOS RECOMENDADOS", ConsoleColor.Cyan);
                    Console.WriteLine(chapter.Exercises);

                    if (input == 11 && ReadSolutionInput()) 
                        DungeonSearcher.StartAdventure();
                    
                    WaitForUserInput();
                }
            } while (input != 0);
        }

        private static SyllabusChapter[] GetChapters() {
            return [
                Syllabus.Chapters.Chapter02_01.GetChapter(),
                Syllabus.Chapters.Chapter02_02.GetChapter(),
                Syllabus.Chapters.Chapter02_03.GetChapter(),
                Syllabus.Chapters.Chapter02_04.GetChapter(),
                Syllabus.Chapters.Chapter03_01.GetChapter(),
                Syllabus.Chapters.Chapter03_02.GetChapter(),
                Syllabus.Chapters.Chapter03_03.GetChapter(),
                Syllabus.Chapters.Chapter03_04.GetChapter(),
                Syllabus.Chapters.Chapter04_01.GetChapter(),
                Syllabus.Chapters.Chapter04_02.GetChapter(),
                Syllabus.Chapters.Chapter05.GetChapter(),
            ];
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
            PrintTools.WriteLine("https://www.youtube.com/@wealks_playground \n", ConsoleColor.Cyan);

            Console.WriteLine("¿Qué capítulo quieres revisar?");
            foreach (var chapter in chapters)
                Console.WriteLine($"\t{chapter.ID}- {chapter.Title}");
            Console.WriteLine("\n\t0- Salir");
        }

        private static int ReadUserInput() {
            var option = 0;
            string userLine;
            bool validOption;
            do {
                Console.Write("Opción: ");
                userLine = Console.ReadLine();
                validOption = userLine != string.Empty && int.TryParse(userLine, out option) && option >= 0 && option <= 11;
                if (!validOption)
                    PrintTools.WriteLine(" \tNop, Intenta de nuevo :)", ConsoleColor.Red);
            } while (!validOption);

            return option;
        }

        private static bool ReadSolutionInput() {
            Console.Write("\n\nPULSA Y PARA VER EL RESULTADO DE LAS SOLUCIONES O CUALQUIER OTRA TECLA PARA VOLVER AL MENÚ");
            return Console.ReadKey().Key == ConsoleKey.Y;
        }

        private static void WaitForUserInput() {
            Console.Write("\n\nPulsa cualquier tecla para volver al menú principal...".ToUpperInvariant());
            Console.ReadKey();
            PrintTools.ClearConsole();
        }
    }
}
