namespace Programming101CS.Helpers {
    internal static class PrintTools {
        public static void WriteLine(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Write(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ClearConsole() {
            Console.Clear();
            Console.Write("\x1b[3J");
        }
    }
}
