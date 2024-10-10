namespace Programming101CS.Syllabus.Exercices {
    internal class AdvancedSets {
        public static void Statement() {
            Console.WriteLine("a) Declara una variable mediante BinaryTree<char>(new BinaryTreeNode<char>('H')) y añade los nodos BinaryTreeNode<char>('o'), BinaryTreeNode<char>('l'), BinaryTreeNode<char>('a') mediante tree.AddChild(...):");
            // Solución

            Console.WriteLine("\nb) Desarrolla los algoritmos de profundidad y anchura mediante recursividad para mostrar por consola los valores de los nodos:");
            // Solución

            Console.WriteLine("\nc) Implementa los mismos algoritmos anteriores pero sustituyendo la recursividad por bucles. Ayúdate de variables de tipo Stack<BinaryTreeNode<char>> y Queue<BinaryTreeNode<char>> para ello:");
            // Solución

            Console.WriteLine("\nd) Supón el árbol binario auto-balanceable siguiente: Root=5-> LeftChild=3, RightChild=null. ¿Cómo quedaría tras añadir Nodo(1)? ¿Y cómo quedaría el árbol original tras añadir el Nodo(4)?");
            // Solución

            Console.WriteLine("\ne) Convierte en grafo una cuadrícula de 3x3 donde cada casilla esté relacionada con las casillas colindantes, sin incluir las diagonales:");
            // Solución

            Console.WriteLine("\nf) Convierte en grafo una cuadrícula de 3x3 donde la casilla (x=1,y=0) y la casilla (x=1,y=1) estén vacías. Suponiendo que inicias el problema en la casilla (x=0,y=0) calcula manualmente el camino y el coste para llegar a la casilla (x=2, y=2):");
            // Solución

            Console.WriteLine("\ng) Teniendo los textos \"Hola\", \"Hello\", \"Salut\" y \"Hallo\" y \"Adiós\", \"Bye\", \"Adieu\" y \"Tschüss\" ¿Cómo almacenarías esta información priorizando la obtención de todos los textos en un idioma utilizando una función que reciba un string que sea case insensitive?. Por ejemplo: GetTexts(\"inGlEs\") = {\"Hello\", \"Bye\"}. Ayúdate de la función text.ToUpperInvariant() o text.ToLowerInvariant():");
            // Solución

            Console.WriteLine("\nh) Repite el ejercicio anterior pero priorizando la obtención por texto e idioma. Por ejemplo: GetText(\"HOlA\", \"aLeman\") = \"Hallo\":");
            // Solución

        }
    }
}
