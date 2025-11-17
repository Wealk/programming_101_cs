using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter03_01 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(1, "Programación básica: Tipos primitivos", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            bool boolFalse = false;
            bool boolTrue = true;
            message.AppendLine($"- {typeof(bool)} ({sizeof(bool)} bytes), False: {boolFalse}, True: {boolTrue}, IsObject: {typeof(bool) is object}");

            // Enteros
            sbyte sbyteMinValue = sbyte.MinValue;
            sbyte sbyteMaxValue = sbyte.MaxValue;
            message.AppendLine($"- {typeof(sbyte)} ({sizeof(sbyte)} bytes), MinValue: {sbyteMinValue}, MaxValue: {sbyteMaxValue}, IsObject: {typeof(sbyte) is object}");

            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;
            message.AppendLine($"- {typeof(byte)} ({sizeof(byte)} bytes), MinValue: {byteMinValue}, MaxValue: {byteMaxValue}, IsObject: {typeof(byte) is object}");

            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;
            message.AppendLine($"- {typeof(short)} ({sizeof(short)} bytes), MinValue: {shortMinValue}, MaxValue: {shortMaxValue}, IsObject: {typeof(short) is object}");

            ushort ushortMinValue = ushort.MinValue;
            ushort ushortMaxValue = ushort.MaxValue;
            message.AppendLine($"- {typeof(ushort)} ({sizeof(ushort)} bytes), MinValue: {ushortMinValue}, MaxValue: {ushortMaxValue}, IsObject: {typeof(ushort) is object}");

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;
            message.AppendLine($"- {typeof(int)} ({sizeof(int)} bytes), MinValue: {intMinValue}, MaxValue: {intMaxValue}, IsObject: {typeof(int) is object}");

            uint uintMinValue = uint.MinValue;
            uint uintMaxValue = uint.MaxValue;
            message.AppendLine($"- {typeof(uint)} ({sizeof(uint)} bytes), MinValue: {uintMinValue}, MaxValue: {uintMaxValue}, IsObject: {typeof(uint) is object}");

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            message.AppendLine($"- {typeof(long)} ({sizeof(long)} bytes), MinValue: {longMinValue}, MaxValue: {longMaxValue}, IsObject: {typeof(long) is object}");

            ulong ulongMinValue = ulong.MinValue;
            ulong ulongMaxValue = ulong.MaxValue;
            message.AppendLine($"- {typeof(ulong)} ({sizeof(ulong)} bytes), MinValue: {ulongMinValue}, MaxValue: {ulongMaxValue}, IsObject: {typeof(ulong) is object}");

            // Decimales
            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;
            message.AppendLine($"- {typeof(float)} ({sizeof(float)} bytes), MinValue: {floatMinValue}, MaxValue: {floatMaxValue}, IsObject: {typeof(float) is object}");

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;
            message.AppendLine($"- {typeof(double)} ({sizeof(double)} bytes), MinValue: {doubleMinValue}, MaxValue: {doubleMaxValue}, IsObject: {typeof(double) is object}");

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;
            message.AppendLine($"- {typeof(decimal)} ({sizeof(decimal)} bytes), MinValue: {decimalMinValue}, MaxValue: {decimalMaxValue}, IsObject: {typeof(decimal) is object}");

            // Unicode
            char charMinValue = char.MinValue;
            char charMaxValue = char.MaxValue;
            message.AppendLine($"- {typeof(char)} ({sizeof(char)} bytes), MinValue: {charMinValue}, MaxValue: {charMaxValue}, IsObject: {typeof(char) is object}");

            message.AppendLine("\n¿Y estos valores de dónde salen?");
            message.AppendLine("- 1 bit únicamente puede tener dos valores representados en binario como 0 y 1");
            message.AppendLine("- 1 byte se corresponde 8 a bits (representado en binario con valores desde 00000000 hasta 11111111)");
            message.AppendLine("- Con esto podemos decir que una estructura podrá representar tantos números como sus combinaciones le permitan");
            message.AppendLine($"- Las estructuras con 1 byte puede tener {Math.Pow(2, 8 * 1)} (2^8) combinaciones");
            message.AppendLine($"- Las estructuras con 2 byte pueden tener {Math.Pow(2, 8 * 2)} (2^16) combinaciones");
            message.AppendLine($"- Las estructuras con 4 byte pueden tener {Math.Pow(2, 8 * 4)} (2^32) combinaciones");
            message.AppendLine($"- Las estructuras con 8 byte pueden tener {Math.Pow(2, 8 * 8)} (2^64) combinaciones");
            message.AppendLine($"- Las estructuras con 16 byte pueden tener {Math.Pow(2, 8 * 16)} (2^128) combinaciones");
            message.AppendLine($"- El incremento se basa en potencias de 2: 2^0={Math.Pow(2, 0)}, 2^1={Math.Pow(2, 1)}, 2^2={Math.Pow(2, 2)}, 2^3={Math.Pow(2, 3)}, 2^4={Math.Pow(2, 4)}, 2^5={Math.Pow(2, 5)}, 2^6={Math.Pow(2, 6)}, 2^7={Math.Pow(2, 7)}, ...");

            message.AppendLine("\nStrings:");
            string charArrayMin = string.Empty;
            string charArray1 = "H";
            string charArray2 = "Hello world";
            message.AppendLine("- Se define como string la unión de carácteres");
            message.AppendLine($"- {typeof(string)}, Empty: ({charArrayMin.Length * sizeof(char)} bytes), {charArray1}: ({charArray1.Length * sizeof(char)} bytes), {charArray2}: ({charArray2.Length * sizeof(char)} bytes)");
            message.AppendLine("- Los strings, a diferencia de los caracteres basan su tamaño y posibles valores en el encoding utilizado");
            message.AppendLine("- Hay múltiples encodings aunque los más habituales son Unicode (UTF-8) o ASCII");
            message.AppendLine("- UTF-8 usa 2 bytes para representar los carácteres incluyendo carácteres especiales");
            message.AppendLine("- ASCII por otro lado utiliza 1 byte para representar los carácteres sin incluir los carácteres especiales");
            message.AppendLine($"- Tamaño según codificacion ASCII: ({Encoding.ASCII.GetByteCount(charArrayMin)} bytes), {charArray1}: ({Encoding.ASCII.GetByteCount(charArray1)} bytes), {charArray2}: ({Encoding.ASCII.GetByteCount(charArray2)} bytes)");
            message.AppendLine($"- Tamaño según unicode: ({Encoding.Unicode.GetByteCount(charArrayMin)} bytes), {charArray1}: ({Encoding.Unicode.GetByteCount(charArray1)} bytes), {charArray2}: ({Encoding.Unicode.GetByteCount(charArray2)} bytes)");

            message.AppendLine("\nAclaraciones:");
            message.AppendLine("- Un bool (false o true) podría ser representado por un bit (0 o 1), pero las CPU modernas no pueden gestionar información más pequeña a un byte");
            message.AppendLine("- Se conoce como 'castear' la acción de pasar de un tipo de dato a otro (int -> float o float -> decimal)");
            message.AppendLine("- Los tipos de los valores literales se pueden indicar con su letra correspondiente (1.245f para float, 1.2345m para decimal, 1.2345d para double, ...)");

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();
            message.AppendLine("a) Declara una variable bool llamada \"exerciceA\" inicializada a true:");
            message.AppendLine("\nb) Declara una variable de tipo int llamada \"result\" sin inicializar:");
            message.AppendLine("\nc) Declara una variable double llamada \"subsection\" inicializada a 1.25d:");
            message.AppendLine("\nd) Declara una variable decimal llamada \"section\" inicializada a subsection casteado a decimal:");
            message.AppendLine("\ne) Declara una variable char llamada \"character\" inicializada al caracter 'Z':");
            message.AppendLine("\nf) Declara una variable string llamada \"text\" inicializada al texto \"Hello world\":");
            message.AppendLine("\ng) Declara una variable unsigned int llamada \"charToUInt\" inicializada a \"character\" casteado a unsigned int:");
            message.AppendLine("\nh) Asigna el valor 35 a la variable \"result\":");
            message.AppendLine("\ni) Declara una variable long llamada \"intToLong\" inicializada a \"result\" casteado a long:");

            return message.ToString();
        }
    }
}
