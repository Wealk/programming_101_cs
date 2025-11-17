using Programming101CS.Syllabus.Definitions;
using System.Text;

namespace Programming101CS.Syllabus.Chapters {
    internal static class Chapter06 {
        public static SyllabusChapter GetChapter() {
            return new SyllabusChapter(11, "Práctica final: Dungeon searcher", GetInformation(), GetExercices());
        }

        private static string GetInformation() {
            var message = new StringBuilder();
            message.AppendLine("Antes de continuar te recomiendo que, si no has completado todas las actividades ni la teoría, la completes...");
            message.AppendLine("Si hay algún concepto que no te haya quedado claro, intenta aclararlo mediante ChatGPT, búsquedas en internet o coméntalo en el vídeo correspondiente y lo resolveremos");
            message.Append("¿Ya lo tienes todo listo? Pues venga que viene la ");
            message.AppendLine("¡BATALLA FINAL!");

            message.AppendLine("\nComo la finalidad del curso es que te adentres en la programación para iniciarte en el desarrollo de videojuegos");
            message.AppendLine("que mejor que hacer nuestro primer 'jueguito' para afianzar el camino en el que has decidido embarcarte");
            message.AppendLine("Vamos a hacer un juego que consista en la exploración de una mazmorra de dos niveles con varios enemigos que");
            message.AppendLine("merodearán por la zona dificultándonos la búsqueda de un tesoro.");

            message.AppendLine(@"
Desarrolla un programa completo que al iniciar pida al usuario el número de celdas que será utilizado para 
definir el tamaño (cuadrado) de la mazmorra. Una vez introducido el tamaño de la mazmorra tendrás que instanciar 
el mapa con los dos niveles, posicionar al jugador en una posición inicial, posicionar una celda especial que 
será la escalera en la misma posición en ambos niveles y tendrás que instanciar otra celda especial en el segundo 
nivel que será el tesoro que deberémos alcanzar. Además, tendrás que instanciar un enemigo en el primer nivel y 
dos enemigos en el segundo nivel. Estos enemigos no podrán acceder a la casilla de la escalera ni a la casilla del 
tesoro y se moverán aleatoriamente por el mapa en cada turno evitando que haya dos enemigos en la misma celda.
            ");

            message.AppendLine(@"
Los turnos los gestionará el propio usuario mediante sus acciones, cada acción del usuario supondrá un turno
Utiliza WASD para mover al jugador a arriba, izquierda, abajo y derecha respectivamente, si pulsa ESC en cualquier 
momento el juego deberá finalizar. Si el jugador y el monstruo comparten celda el juego terminará perdiendo el jugador, 
si el jugador llega a la casilla del tesoro el jugador ganará. En ambos casos se volverá a la fase inicial del 
programa pidiendo de nuevo el tamaño de la mazmorra
            ");

            message.AppendLine(@"
Para la respresentación de la escena utilizaremos únicamente la consola puesto que es un ejercicio puramente 
de programación. Cada turno se deberá mostrar la situación de las celdas especiales y las entidades de la mazmorra 
(jugador y monstruos).
            ");

            message.AppendLine("Utiliza las herramientas, estructuras y métodos que prefieras para la resolución de la practica");
            return message.ToString();
        }

        private static string GetExercices() {
            var message = new StringBuilder();
            message.AppendLine("1- Antes de ponerte al lío piensa bien la estructura general que necesitarás para la practica y el flujo de ejecución que tendrá.");
            message.AppendLine("2- Intenta modularizar la practica en entidades y sus funcionalidades específicas.");
            message.AppendLine("3- Para el pintado de la información intenta utilizar el override de ToString().");
            message.AppendLine("4- Ayúdate de una función auxiliar para obtener las casillas colindantes a una entidad y obtener los movimientos disponibles.");
            message.AppendLine("5- Usa las funciones auxiliares proporcionadas en Helpers.PrintTools para pintar información en la consola o limpiar la consola.");

            return message.ToString();
        }
    }
}
