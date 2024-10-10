namespace Programming101CS.Syllabus {
    internal class ObjectOrientedProgramming {
        public static void Information() {
            Console.WriteLine("- Antes de avanzar es recomendable haber entendido perfectamente los puntos anteriores y haber completado correctamente los ejercicios");
            Console.WriteLine("- Con todas las piezas descritas empezamos el trabajo de operar con enumerados, estructuras, clases e interfaces");
            Console.WriteLine("- Todas las herramientas vistas hasta ahora nos permitirán definir nuestros propios objetos para cumplir con nuestros objetivos");

            Console.WriteLine("\nEnumerados:");
            Console.WriteLine("- Podemos definir nuestros propios tipos enumerados");
            Console.WriteLine("- Nos permiten diferenciar entre varios valores fijos, los lenguages suelen representarlos internamente como un int");
            Console.WriteLine("- Son alternativas óptimas para evitar el uso de strings, números 'mágicos', ... y mejorar la legibilidad del código");

            Console.WriteLine("\nDefinición de objeto:");
            Console.WriteLine("- Podemos definir un objeto como un conjunto de propiedades y funcionalidades");
            Console.WriteLine("- Requieren de una instanciación previa que llame al constructor de la clase");
            Console.WriteLine("- Los hemos utilizado cuando utilizamos List<>, Dictionary<>, Hashset<>, ...");
            Console.WriteLine("- Tienen dos tipos de modificadores: implementaciones y herencia que veremos más adelante");

            Console.WriteLine("\nClases:");
            Console.WriteLine("- Una clase es la delcaración de la estructura de la información que tendrán los objetos de ese tipo");
            Console.WriteLine("- Generalmente se suele enseñar como si se tratara de una plantilla a la que modificar ciertos valores");
            Console.WriteLine("- Las clases tienen propiedades, métodos y un constructor");
            Console.WriteLine("- Las propiedades determinan la información necesaria para gestionar la clase. Son las variables de tendrá dicha clase");
            Console.WriteLine("- Los métodos describirán las acciones y funcionalidades para implementar y utilizar los objetos de esa clase");
            Console.WriteLine("- El constructor de la clase será el método llamado para inicializar los objectos de ese tipo");
            Console.WriteLine("- Algunos lenguajes permiten definir el destructor de la clase, que se llamará cuando se destruya el objeto");
            Console.WriteLine("- Se conoce como encapsulamiento el hecho de evitar el acceso directo a las variable e implementarlos mediante métodos get y set de esa propiedad");
            Console.WriteLine("- Los getters (obtención) y setters (establecer valor) sirven para evitar la modificación directa de las variables");

            Console.WriteLine("\nEstructuras:");
            Console.WriteLine("- Una estructura es similar a una clase pero con ciertas características dependiendo del lenguaje");
            Console.WriteLine("- La principal diferencia es que las estructuras suelen utilizarse para agrupar propiedades");
            Console.WriteLine("- La mayoría de lenguajes suelen determinar la visibilidad por defecto como pública, mientras que en las clases es privada");
            Console.WriteLine("- La mayoría de lenguajes impiden iniciarlizarlos con null, siempre utilizan los valores por defecto de sus propidades");
            Console.WriteLine("- Los más habituales son: fechas, vectores (x,y)/(x,y,z), ...");

            Console.WriteLine("\nHerencia:");
            Console.WriteLine("- Las clases permiten implementar la herencia entre ellas estableciendo una jerarquía similar a padres-hijos");
            Console.WriteLine("- Siguiendo con la analogía, las clases hijas de otra clase tendrán acceso a toda la información > protected, tanto atributos como métodos");
            Console.WriteLine("- Mediante la herencia se puede castear un objeto de una clase hija a la clase padre, pero nunca un objecto de la clase padre a una clase hija");
            Console.WriteLine("- Es la herramienta más potente, utilizada y distintiva de la POO");
            Console.WriteLine("- Las clases que heredan de otras pueden sobreescribir sus métodos si son marcados como virtual o deberán hacerlo obligatoriamente son son abstract");
            Console.WriteLine("- Generalmente los lenguages permiten una única herencia directa, aunque hay lenguages que permiten herencia múltiple");

            Console.WriteLine("\nAbstracción:");
            Console.WriteLine("- Un modificador directamente dependiente de la herencia es el modificador de métodos abstract, lo que únicamente se podrá aplicar sobre clases abstractas");
            Console.WriteLine("- Definimos una clase abstracta como una clase que no puede ser instanciada directamente. ¿De que sirve entonces esta clase?");
            Console.WriteLine("- Las clases abstractas se utilizan en el 100% de los casos como bases para otras clases que compartirán su estructura.");
            Console.WriteLine("- Supongamos la clase Animal para definir animales, y las hijas Mammal, Bird, Fish, ... No hay ningún animal que sea únicamente Animal, si no que recaerá sobre mamífero, ave, pez, ...");
            Console.WriteLine("- Los métodos abstractos dictan la estructura que debe tener el método, nunca podrán tener un cuerpo que defina su comportamiento");
            Console.WriteLine("- Que una clase abstracta no pueda ser instanciada no quiere decir que no se puede castear un objeto de clase hija a la clase padre abstracta");

            Console.WriteLine("\nVirtual:");
            Console.WriteLine("- Otro modificador que únicamente tiene sentido especificar al aplicar herencia sobre la clase");
            Console.WriteLine("- A diferencia de abstract, un método virtual permite definir el comportamiento que tendrá una método que no haya sido sobreescrito");
            Console.WriteLine("- Especificar un método virtual no nos fuerza a actualizar la clase a abstract dado que ese método siempre tendrá un cuerpo base definido");

            Console.WriteLine("\nInterfaces:");
            Console.WriteLine("- Una interfaz únicamente sirve para forzar a una clase a tener que especicar los métodos definidos en dicha interfaz");
            Console.WriteLine("- Cuando una clase utiliza una interfaz se dice que dicha clase implementa esa interfaz");
            Console.WriteLine("- Las clases pueden implementar tantas interfaces como necesiten, a diferencia a la herencia que suele ser única");
            Console.WriteLine("- La potencia de las interfaces reside en la posibilidad de castear los objetos que la implementen sean de la clase que sean");

            Console.WriteLine("\nGenéricos:");
            Console.WriteLine("- Uno de los conceptos más dificiles de entender y asimilar de la POO");
            Console.WriteLine("- El uso de genéricos permite describir clases, métodos, estructuras, ... sin la necesidad de especificar un tipo concreto de dato");
            Console.WriteLine("- Hemos utilizado genéricos al definir List<?>. Dictionary<?>, Hashset<?> donde independientemente del tipo de ? el objeto se comporta de la misma manera");
            Console.WriteLine("- Dependiendo del lenguaje se pueden restringir las clases que acepta el genérico. Forzando que herede de una clase en concreto, o que implemente una interfaz concreta");
            Console.WriteLine("- Es un recurso muy potente y versátil que te permitirá generalizar tus funciones y clases");
        }
    }
}
