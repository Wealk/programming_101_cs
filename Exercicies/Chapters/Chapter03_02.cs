namespace Programming101CS.Exercicies.Chapters {
    internal class Chapter03_02 {
        public void Main() {
            // a) Declara dos variables int con el nombre \"x\" = 5 y \"y\" = 3 y una tercera \"z\" que sea la suma de \"x\" e \"y\":
            int x = 5, y = 3;
            int z = x + y;

            // b) Declara una variable float con el nombre \"preIncrement\" que sea la suma de 1.25f y \"z\", incrementando \"z\" en 1 ANTES de la operación:
            float preIncrement = 1.25f + ++z;

            // c) Repite el ejercicio b) con una nueva variable \"postDecrement\" pero que decremente \"z\" en 1 DESPUÉS de la operación:
            float postDecrement = 1.25f + z--;

            // d) Declara una variable \"parenthesis\" que sea (1 + 2)/ 3 * 3, y otra \"noParenthesis\" que sea 1 + 2 / 3 * 3:
            float parenthesis = (1 + 2) / 3f * 3;
            float noParenthesis = 1 + 2 / 3f * 3;

            // e) Declara una variable booleana \"xYCheck\" que compruebe si \"x\" e \"y\" son iguales:
            bool xYCheck = x == y;

            // f) Declara una variable booleana \"isXEven\" que compruebe si \"x\" es par (x % 2 = 0):
            bool isEven = x % 2 == 0;

            // g) Declara una variable booleana \"isXOdd\" que sea la negada de \"isXEven\":
            bool isXOdd = !isEven;

            // h) Declara una variable booleana \"logicAnd\" que compruebe si \"isXOdd\" y \"isXEven\" son verdaderos, forzando a comprobar ambos valores:
            bool logicAnd = isXOdd & isEven;

            // i) Declara una variable booleana \"conditionalLogicOr\" que compruebe si \"isXEven\" o \"isXOdd\" es verdadero, comprobando el mínimo de valores posibles:
            bool conditionalLogicOr = isEven || isXOdd;
        }
    }
}
