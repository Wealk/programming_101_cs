using Programming101CS.OOP;
using System.Xml.Linq;

namespace Programming101CS.Syllabus.Exercices.Solutions {
    internal class AdvancedSets {
        static BinaryTree<char> tree = new BinaryTree<char>(new BinaryTreeNode<char>('H'));

        public static void Solution() {
            Console.WriteLine("a) Declara una variable mediante BinaryTree<char>(new BinaryTreeNode<char>('H')) y añade los nodos BinaryTreeNode<char>('o'), BinaryTreeNode<char>('l'), BinaryTreeNode<char>('a') usando tree.AddChild(...):");
            tree.AddChild(new BinaryTreeNode<char>('o'));
            tree.AddChild(new BinaryTreeNode<char>('l'));
            tree.AddChild(new BinaryTreeNode<char>('a'));

            Console.WriteLine("\nb) Desarrolla los algoritmos de profundidad y anchura mediante recursividad para mostrar por consola los valores de los nodos:");
            DepthFirst(true);
            BreadthFirst(true);

            Console.WriteLine("\nc) Implementa los mismos algoritmos anteriores pero sustituyendo la recursividad por bucles. Ayúdate de variables de tipo Stack<BinaryTreeNode<char>> y Queue<BinaryTreeNode<char>> para ello:");
            DepthFirst(false);
            BreadthFirst(false);

            Console.WriteLine("\nd) Supón el árbol binario auto-balanceable siguiente: Root=5-> LeftChild=3, RightChild=null. ¿Cómo quedaría tras añadir Nodo(1)? ¿Y cómo quedaría el árbol original tras añadir el Nodo(4)?");
            // Solución en el vídeo

            Console.WriteLine("\ne) Convierte en grafo una cuadrícula de 3x3 donde cada casilla esté relacionada con las casillas colindantes, sin incluir las diagonales:");
            // Solución en el vídeo

            Console.WriteLine("\nf) Convierte en grafo una cuadrícula de 3x3 donde la casilla (x=1,y=0) y la casilla (x=1,y=1) estén vacías. Suponiendo que inicias el problema en la casilla (x=0,y=0) calcula manualmente el camino y el coste para llegar a la casilla (x=2, y=2):");
            // Solución en el vídeo

            Console.WriteLine("\ng) Teniendo los textos \"Hola\", \"Hello\", \"Salut\" y \"Hallo\" y \"Adiós\", \"Bye\", \"Adieu\" y \"Tschüss\" ¿Cómo almacenarías esta información priorizando la obtención de todos los textos en un idioma utilizando una función que reciba un string que sea case insensitive?. Por ejemplo: GetTexts(\"inGlEs\") = {\"Hello\", \"Bye\"}. Puedes ayudarte de la función text.ToUpperInvariant() o text.ToLowerInvariant():");
            GetTextsByLanguage();

            Console.WriteLine("\nh) Repite el ejercicio anterior pero priorizando la obtención por texto en castellano e idioma. Por ejemplo: GetText(\"HOlA\", \"aLeman\") = \"Hallo\":");
            GetTextByTagAndLanguage();
        }

        private static void DepthFirst(bool useRecursivity) {
            Console.WriteLine("Búsqueda en profundidad:");
            if (useRecursivity) DepthFirstRecursivity(tree.Root);
            else DepthFirstIterative(tree.Root);
        }

        private static void DepthFirstRecursivity(BinaryTreeNode<char> node) {
            if (node == null) return;

            Console.WriteLine(node.Value);
            DepthFirstRecursivity(node.LeftChild);
            DepthFirstRecursivity(node.RightChild);
        }

        private static void DepthFirstIterative(BinaryTreeNode<char> node) {
            if (node == null) return;

            var stack = new Stack<BinaryTreeNode<char>>();
            stack.Push(node);

            while (stack.Count > 0) {
                var currentNode = stack.Pop();

                Console.WriteLine(currentNode.Value);

                // Al ser una pila, primero insertamos el nodo derecho y luego el izquierdo para procesarlos en orden inverso
                if (currentNode.RightChild != null)
                    stack.Push(currentNode.RightChild);
                if (currentNode.LeftChild != null)
                    stack.Push(currentNode.LeftChild);
            }
        }

        private static void BreadthFirst(bool useRecursivity) {
            Console.WriteLine("Búsqueda en anchura:");
            if (useRecursivity) BreadthFirstRecursivity(tree.Root);
            else BreadthFirstIterative(tree.Root);
        }

        private static void BreadthFirstRecursivity(BinaryTreeNode<char> node) {
            var treeHeight = GetTreeHeight(node);
            for (var level = 1; level <= treeHeight; level++)
                PrintLevelNodes(node, level);
        }

        private static int GetTreeHeight(BinaryTreeNode<char> node) {
            if (node == null)
                return 0;

            // Miramos que subarbol tiene la mayor profundidad
            return Math.Max(GetTreeHeight(node.LeftChild), GetTreeHeight(node.RightChild)) + 1;
        }

        private static void PrintLevelNodes(BinaryTreeNode<char> node, int level) {
            if (node == null)
                return;

            if (level == 1) {
                Console.WriteLine(node.Value);
            } else if (level > 1) {
                PrintLevelNodes(node.LeftChild, level - 1);
                PrintLevelNodes(node.RightChild, level - 1);
            }
        }


        private static void BreadthFirstIterative(BinaryTreeNode<char> node) {
            if (node == null) return;

            var queue = new Queue<BinaryTreeNode<char>>();
            queue.Enqueue(node);

            while (queue.Count > 0) {
                var currentNode = queue.Dequeue();

                Console.WriteLine(currentNode.Value);

                // Al ser una cola, primero insertamos el nodo izquierdo y luego el derecho para procesarlos en ese orden
                if (currentNode.LeftChild != null)
                    queue.Enqueue(currentNode.LeftChild);
                if (currentNode.RightChild != null)
                    queue.Enqueue(currentNode.RightChild);
            }
        }

        private static void GetTextsByLanguage() {
            var texts = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase) {
                { "español", new List<string>{ "Hola", "Adiós" } },
                { "ingles", new List<string>{ "Hello", "Bye" } },
                { "italiano", new List<string>{ "Salut", "Adieu" } },
                { "aleman", new List<string>{ "Hallo", "Tschüss" } }
            };

            var languages = new List<string> { "Español", "Ingles", "Italiano", "Aleman" };
            foreach (var lang in languages)
                if (texts.TryGetValue(lang, out var value))
                    Console.WriteLine($"{lang}: {string.Join(", ", value)}");
        }

        private static void GetTextByTagAndLanguage() {
            var texts = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase) {
                { "español", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "hola", "Hola" }, { "adios", "Adiós" }, } },
                { "ingles", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "hola", "Hello" }, { "adios", "Bye" }, } },
                { "italiano", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "hola", "Salut" }, { "adios", "Adieu" }, } },
                { "aleman", new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "hola", "Hallo" }, { "adios", "Tschüss" }, } }
            };

            var languages = new List<string> { "Español", "Ingles", "Italiano", "Aleman" };
            var tags = new List<string> { "Hola", "Adios" };
            foreach (var lang in languages)
                foreach (var tag in tags)
                    if (texts.TryGetValue(lang, out var words) && words.TryGetValue(tag, out var word))
                        Console.WriteLine($"{lang} - {tag}: {word}");
        }
    }
}
