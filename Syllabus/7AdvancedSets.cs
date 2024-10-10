namespace Programming101CS.Syllabus {
    internal class AdvancedSets {
        public static void Information() {
            Console.WriteLine("- No tenemos porque limitarnos a ofrecer una estructura de datos lineal");
            Console.WriteLine("- Los conjusto vistos hasta ahora permiten agrupar información a nivel de objetos individual no relacionados");
            Console.WriteLine("- Los conjuntos avanzados permiten relacionar los elementos insertados de cierta manera");
            Console.WriteLine("- No es habitual que los lenguajes contengan estas estructuras en su core");

            // Combinaciones
            Console.WriteLine("\nCombinaciones de conjuntos:");
            Console.WriteLine("- En el punto de conjuntos tratamos los conjuntos individuales pero se pueden combinar de cualquier manera");
            Console.WriteLine("- Diccionario de listas, listas de diccionarios, pilas de hashets, ...");
            Console.WriteLine("- La facilidad y la optimización en la resolución de los problemas viene dada directamente por el conjunto de datos utilizado");
            Console.WriteLine("- Aprender a combinar los conjuntos requiere práctica y conocimiento");

            // Árboles
            Console.WriteLine("\nÁrboles (General):");
            Console.WriteLine("- Estructura que se basa en nodos y hojas (hijos) para determinar una jerarquía entre los elementos del conjunto");
            Console.WriteLine("- Los árboles deben tener un y solo un elemento raíz (root) como nodo inicial");
            Console.WriteLine("- La única relación que existe entre los nodos es la de padre-hijos");
            Console.WriteLine("- Iterar/Buscar elementos en un arbol suele implicar el uso de recursividad");

            // Árboles binarios
            Console.WriteLine("\nÁrboles binarios:");
            Console.WriteLine("- Estructura basada en los árboles");
            Console.WriteLine("- En este caso, los nodos del árbol pueden tener dos hijos como máximo");
            Console.WriteLine("- Utilizado como base para infinidad de estructuras enfocadas en búsquedas dicotomicas");

            // Árboles binarios auto-balanceables
            Console.WriteLine("\nÁrbol de búsqueda binario auto-balanceables:");
            Console.WriteLine("- Estructura basada en los áboles binarios");
            Console.WriteLine("- Balancea de manera automática los nodos al insertar/eliminar un nuevo valor");
            Console.WriteLine("- Enfocado en optimizar la búsqueda de valores");

            // Grafos
            Console.WriteLine("\nGrafos:");
            Console.WriteLine("- Los nodos son llamados vértices, y las relaciones entre ellos arcos o aristas");
            Console.WriteLine("- A diferencia de los árboles los grafos pueden tener múltiples relaciones entre los vértices");
            Console.WriteLine("- En los grafos las relaciones no se limitan entre padres e hijos");

            // Grafos con pesos
            Console.WriteLine("\nGrafos ponderados:");
            Console.WriteLine("- Estructura basada en los grafos donde las aristas tienen pesos diferentes");
            Console.WriteLine("- Estos pesos afectan a la hora de calcular el mejor camino entre los vértices");
            Console.WriteLine("- Generalmente se devuelve el camino recorrido a la hora de buscar un vértice concreto");

            // Grafos dirigidos
            Console.WriteLine("\nGrafos dirigidos:");
            Console.WriteLine("- Estructura basada en los grafos donde las aristas tienen una dirección concreta");
            Console.WriteLine("- En estos grafos las relaciones no tienen porque ser bidireccionales");

            // Grafos dirigidos
            Console.WriteLine("\nGrafos dirigidos con pesos:");
            Console.WriteLine("- Estructura basada en los grafos donde las aristas tienen una dirección concreta y un peso determinado");
            Console.WriteLine("- Es la unión de los dos grafos anteriores donde los arcos no son bidireccionales y además cada uno tiene un peso concreto");

            // Abstración de estructura interna
            Console.WriteLine("\nAdvertencia al tratar con estructuras complejas compuestas:");
            Console.WriteLine("- Saber diferenciar entre como ser utilizado y como procesar internamente las peticiones forma parte del proceso de abstracción");
            Console.WriteLine("- Las operaciones de los conjuntos deberían ser idénticas independientemente del tratamiento interno");
            Console.WriteLine("- No perder de vista la finalidad de la implementación que estés intentando realizar");
            Console.WriteLine("- Intentar hacer estructuras completas e independientes de otros componentes para maximizar su uso");
        }
    }
}
