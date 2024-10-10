namespace Programming101CS.Syllabus {
    internal class Primitives {
        public static void Information() {
            // Condicionales
            bool boolFalse = false;
            bool boolTrue = true;
            Console.WriteLine($"- {typeof(bool)} ({sizeof(bool)} bytes), False: {boolFalse}, True: {boolTrue}, IsObject: {typeof(bool) is object}");

            // Enteros
            sbyte sbyteMinValue = sbyte.MinValue;
            sbyte sbyteMaxValue = sbyte.MaxValue;
            Console.WriteLine($"- {typeof(sbyte)} ({sizeof(sbyte)} bytes), MinValue: {sbyteMinValue}, MaxValue: {sbyteMaxValue}, IsObject: {typeof(sbyte) is object}");

            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;
            Console.WriteLine($"- {typeof(byte)} ({sizeof(byte)} bytes), MinValue: {byteMinValue}, MaxValue: {byteMaxValue}, IsObject: {typeof(byte) is object}");

            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;
            Console.WriteLine($"- {typeof(short)} ({sizeof(short)} bytes), MinValue: {shortMinValue}, MaxValue: {shortMaxValue}, IsObject: {typeof(short) is object}");

            ushort ushortMinValue = ushort.MinValue;
            ushort ushortMaxValue = ushort.MaxValue;
            Console.WriteLine($"- {typeof(ushort)} ({sizeof(ushort)} bytes), MinValue: {ushortMinValue}, MaxValue: {ushortMaxValue}, IsObject: {typeof(ushort) is object}");

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;
            Console.WriteLine($"- {typeof(int)} ({sizeof(int)} bytes), MinValue: {intMinValue}, MaxValue: {intMaxValue}, IsObject: {typeof(int) is object}");

            uint uintMinValue = uint.MinValue;
            uint uintMaxValue = uint.MaxValue;
            Console.WriteLine($"- {typeof(uint)} ({sizeof(uint)} bytes), MinValue: {uintMinValue}, MaxValue: {uintMaxValue}, IsObject: {typeof(uint) is object}");

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            Console.WriteLine($"- {typeof(long)} ({sizeof(long)} bytes), MinValue: {longMinValue}, MaxValue: {longMaxValue}, IsObject: {typeof(long) is object}");

            ulong ulongMinValue = ulong.MinValue;
            ulong ulongMaxValue = ulong.MaxValue;
            Console.WriteLine($"- {typeof(ulong)} ({sizeof(ulong)} bytes), MinValue: {ulongMinValue}, MaxValue: {ulongMaxValue}, IsObject: {typeof(ulong) is object}");

            // Decimales
            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;
            Console.WriteLine($"- {typeof(float)} ({sizeof(float)} bytes), MinValue: {floatMinValue}, MaxValue: {floatMaxValue}, IsObject: {typeof(float) is object}");

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;
            Console.WriteLine($"- {typeof(double)} ({sizeof(double)} bytes), MinValue: {doubleMinValue}, MaxValue: {doubleMaxValue}, IsObject: {typeof(double) is object}");

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;
            Console.WriteLine($"- {typeof(decimal)} ({sizeof(decimal)} bytes), MinValue: {decimalMinValue}, MaxValue: {decimalMaxValue}, IsObject: {typeof(decimal) is object}");

            // Unicode
            char charMinValue = char.MinValue;
            char charMaxValue = char.MaxValue;
            Console.WriteLine($"- {typeof(char)} ({sizeof(char)} bytes), MinValue: {charMinValue}, MaxValue: {charMaxValue}, IsObject: {typeof(char) is object}");

            Console.WriteLine("\n¿Y estos valores de donde salen?");
            Console.WriteLine("- 1 bit únicamente puede tener dos valores representados en binario como 0 y 1");
            Console.WriteLine("- 1 byte se corresponde 8 a bits (representado en binario con valores desde 00000000 hasta 11111111)");
            Console.WriteLine("- Con esto podemos decir que una estructura podrá representar tantos números como sus combinaciones le permitan");
            Console.WriteLine($"- Las estructuras con 1 byte puede tener {Math.Pow(2, 8 * 1)} (2^8) combinaciones");
            Console.WriteLine($"- Las estructuras con 2 byte pueden tener {Math.Pow(2, 8 * 2)} (2^16) combinaciones");
            Console.WriteLine($"- Las estructuras con 4 byte pueden tener {Math.Pow(2, 8 * 4)} (2^32) combinaciones");
            Console.WriteLine($"- Las estructuras con 8 byte pueden tener {Math.Pow(2, 8 * 8)} (2^64) combinaciones");
            Console.WriteLine($"- Las estructuras con 16 byte pueden tener {Math.Pow(2, 8 * 16)} (2^128) combinaciones");
            Console.WriteLine($"- El incremento se basa en potencias de 2: 2^0={Math.Pow(2, 0)}, 2^1={Math.Pow(2, 1)}, 2^2={Math.Pow(2, 2)}, 2^3={Math.Pow(2, 3)}, 2^4={Math.Pow(2, 4)}, 2^5={Math.Pow(2, 5)}, 2^6={Math.Pow(2, 6)}, 2^7={Math.Pow(2, 7)}, ...");

            Console.WriteLine("\nStrings:");
            string charArrayMin = string.Empty;
            string charArray1 = "H";
            string charArray2 = "Hello world";
            Console.WriteLine("- Se define como string la union de carácteres");
            Console.WriteLine($"- {typeof(string)}, Empty: ({charArrayMin.Length * sizeof(char)} bytes), {charArray1}: ({charArray1.Length * sizeof(char)} bytes), {charArray2}: ({charArray2.Length * sizeof(char)} bytes)");
            Console.WriteLine("- Los strings, a diferencia de los caracteres basan su tamaño y posibles valores en el encoding utilizado");
            Console.WriteLine("- Hay múltiples encodings aunque los más habituales son Unicode (UTF-8) o ASCII");
            Console.WriteLine("- UTF-8 usa 2 bytes para representar los carácteres incluyendo carácteres especiales");
            Console.WriteLine("- ASCII por otro lado utiliza 1 byte para representar los carácteres sin incluir los carácteres especiales");
            Console.WriteLine($"- Tamaño según codificacion ASCII: ({System.Text.Encoding.ASCII.GetByteCount(charArrayMin)} bytes), {charArray1}: ({System.Text.Encoding.ASCII.GetByteCount(charArray1)} bytes), {charArray2}: ({System.Text.Encoding.ASCII.GetByteCount(charArray2)} bytes)");
            Console.WriteLine($"- Tamaño según unicode: ({System.Text.Encoding.Unicode.GetByteCount(charArrayMin)} bytes), {charArray1}: ({System.Text.Encoding.Unicode.GetByteCount(charArray1)} bytes), {charArray2}: ({System.Text.Encoding.Unicode.GetByteCount(charArray2)} bytes)");

            Console.WriteLine("\nAclaraciones:");
            Console.WriteLine("- Un bool (false o true) podría ser representado por un bit (0 o 1), pero las CPU modernas no pueden gestionar información más pequeña a un byte");
            Console.WriteLine("- Se conoce como 'castear' la acción de pasar de un tipo de dato a otro (int -> float o float -> decimal)");
            Console.WriteLine("- Los tipos de los valores literales se pueden indicar con su letra correspondiente (1.245f para float, 1.2345m para decimal, 1.2345d para double, ...)");
        }
    }
}
