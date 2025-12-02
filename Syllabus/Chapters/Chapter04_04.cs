using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter04_04 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(8, "Programación orientada a objetos: Abstracción, virtualidad y sellado", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            message.AppendLine("- En esta sección, exploraremos tres conceptos avanzados de la programación orientada a objetos: la abstracción, la virtualidad y el sellado");
            message.AppendLine("- Estos tres conceptos te darán un mayor control sobre cómo se comportan tus clases y objetos en C#");

            // Abstracción
            message.AppendLine("\nAbstracción");
            message.AppendLine("");

            // Virtualidad
            message.AppendLine("\nVirtualidad");
            message.AppendLine("");

            // Sellado
            message.AppendLine("\nSellado");
            message.AppendLine("");

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();


            return message.ToString();
        }
    }
}
