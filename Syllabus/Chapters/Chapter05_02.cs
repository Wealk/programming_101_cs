using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter05_02 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(10, "Conjuntos: Conjuntos complejos", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            message.AppendLine("- No tenemos porque limitarnos a ofrecer una estructura de datos lineal");
            message.AppendLine("- Los conjusto vistos hasta ahora permiten agrupar información a nivel de objetos individual no relacionados");
            message.AppendLine("- Los conjuntos avanzados permiten relacionar los elementos insertados de cierta manera");
            message.AppendLine("- No es habitual que los lenguajes contengan estas estructuras en su core");

            // Combinaciones
            message.AppendLine("\nCombinaciones de conjuntos:");
            message.AppendLine("- En el punto de conjuntos tratamos los conjuntos individuales pero se pueden combinar de cualquier manera");
            message.AppendLine("- Diccionario de listas, listas de diccionarios, pilas de hashets, ...");
            message.AppendLine("- La facilidad y la optimización en la resolución de los problemas viene dada directamente por el conjunto de datos utilizado");
            message.AppendLine("- Aprender a combinar los conjuntos requiere práctica y conocimiento");

            // Árboles
            message.AppendLine("\nÁrboles (General):");
            message.AppendLine("- Estructura que se basa en nodos y hojas (hijos) para determinar una jerarquía entre los elementos del conjunto");
            message.AppendLine("- Los árboles deben tener un y solo un elemento raíz (root) como nodo inicial");
            message.AppendLine("- La única relación que existe entre los nodos es la de padre-hijos");
            message.AppendLine("- Iterar/Buscar elementos en un arbol suele implicar el uso de recursividad");

            // Árboles binarios
            message.AppendLine("\nÁrboles binarios:");
            message.AppendLine("- Estructura basada en los árboles");
            message.AppendLine("- En este caso, los nodos del árbol pueden tener dos hijos como máximo");
            message.AppendLine("- Utilizado como base para infinidad de estructuras enfocadas en búsquedas dicotomicas");

            // Árboles binarios auto-balanceables
            message.AppendLine("\nÁrbol de búsqueda binario auto-balanceables:");
            message.AppendLine("- Estructura basada en los áboles binarios");
            message.AppendLine("- Balancea de manera automática los nodos al insertar/eliminar un nuevo valor");
            message.AppendLine("- Enfocado en optimizar la búsqueda de valores");

            // Grafos
            message.AppendLine("\nGrafos:");
            message.AppendLine("- Los nodos son llamados vértices, y las relaciones entre ellos arcos o aristas");
            message.AppendLine("- A diferencia de los árboles los grafos pueden tener múltiples relaciones entre los vértices");
            message.AppendLine("- En los grafos las relaciones no se limitan entre padres e hijos");

            // Grafos con pesos
            message.AppendLine("\nGrafos ponderados:");
            message.AppendLine("- Estructura basada en los grafos donde las aristas tienen pesos diferentes");
            message.AppendLine("- Estos pesos afectan a la hora de calcular el mejor camino entre los vértices");
            message.AppendLine("- Generalmente se devuelve el camino recorrido a la hora de buscar un vértice concreto");

            // Grafos dirigidos
            message.AppendLine("\nGrafos dirigidos:");
            message.AppendLine("- Estructura basada en los grafos donde las aristas tienen una dirección concreta");
            message.AppendLine("- En estos grafos las relaciones no tienen porque ser bidireccionales");

            // Grafos dirigidos
            message.AppendLine("\nGrafos dirigidos con pesos:");
            message.AppendLine("- Estructura basada en los grafos donde las aristas tienen una dirección concreta y un peso determinado");
            message.AppendLine("- Es la unión de los dos grafos anteriores donde los arcos no son bidireccionales y además cada uno tiene un peso concreto");

            // Abstración de estructura interna
            message.AppendLine("\nAdvertencia al tratar con estructuras complejas compuestas:");
            message.AppendLine("- Saber diferenciar entre como ser utilizado y como procesar internamente las peticiones forma parte del proceso de abstracción");
            message.AppendLine("- Las operaciones de los conjuntos deberían ser idénticas independientemente del tratamiento interno");
            message.AppendLine("- No perder de vista la finalidad de la implementación que estés intentando realizar");
            message.AppendLine("- Intentar hacer estructuras completas e independientes de otros componentes para maximizar su uso");

            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();
            message.AppendLine("a) Declara una variable mediante BinaryTree<char>(new BinaryTreeNode<char>('H')) y añade los nodos BinaryTreeNode<char>('o'), BinaryTreeNode<char>('l'), BinaryTreeNode<char>('a') mediante tree.AddChild(...):");
            message.AppendLine("\nb) Desarrolla los algoritmos de profundidad y anchura mediante recursividad para mostrar por consola los valores de los nodos:");
            message.AppendLine("\nc) Implementa los mismos algoritmos anteriores pero sustituyendo la recursividad por bucles. Ayúdate de variables de tipo Stack<BinaryTreeNode<char>> y Queue<BinaryTreeNode<char>> para ello:");
            message.AppendLine("\nd) Supón el árbol binario auto-balanceable siguiente: Root=5-> LeftChild=3, RightChild=null. ¿Cómo quedaría tras añadir Nodo(1)? ¿Y cómo quedaría el árbol original tras añadir el Nodo(4)?");
            message.AppendLine("\ne) Convierte en grafo una cuadrícula de 3x3 donde cada casilla esté relacionada con las casillas colindantes, sin incluir las diagonales:");
            message.AppendLine("\nf) Convierte en grafo una cuadrícula de 3x3 donde la casilla (x=1,y=0) y la casilla (x=1,y=1) estén vacías. Suponiendo que inicias el problema en la casilla (x=0,y=0) calcula manualmente el camino y el coste para llegar a la casilla (x=2, y=2):");
            message.AppendLine("\ng) Teniendo los textos \"Hola\", \"Hello\", \"Salut\" y \"Hallo\" y \"Adiós\", \"Bye\", \"Adieu\" y \"Tschüss\" ¿Cómo almacenarías esta información priorizando la obtención de todos los textos en un idioma utilizando una función que reciba un string que sea case insensitive?. Por ejemplo: GetTexts(\"inGlEs\") = {\"Hello\", \"Bye\"}. Ayúdate de la función text.ToUpperInvariant() o text.ToLowerInvariant():");
            message.AppendLine("\nh) Repite el ejercicio anterior pero priorizando la obtención por texto e idioma. Por ejemplo: GetText(\"HOlA\", \"aLeman\") = \"Hallo\":");

            return message.ToString();
        }
    }
}
