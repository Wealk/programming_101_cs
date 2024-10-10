using Programming101CS.Syllabus.Exercices.Solutions.Classes;

namespace Programming101CS.Syllabus.Exercices.Solutions {
    internal class ObjectOrientedProgramming {
        public static void Solution() {
            Console.WriteLine("a) Crea un enumerado público llamado SizeType que tenga los valores Big, Medium, Small:");

            Console.WriteLine("\nb) Crea una clase Car que tenga las variables privadas: float fuel, float consommer, float distance, SizeType size y un constructor que acepte un SizeType y se establezca en size, y inicialize fuel = 100 y distance = 0:");

            Console.WriteLine("\nc) Crea una función privada en Car llamada GetConsommer(SizeType siz), que acepte un SizeType y devuelva un float. Utiliza un switch para que Big devuelva 15.5f, Medium devuelva 7.5f y Small devuelva 4.5f:");

            Console.WriteLine("\nd) Utilizando la función anterior inicializa consomer utilizando el parámetro del constructor y añade los getters y setters de las variables privadas anteriores, siendo los getters públicos y los setters protected:");

            Console.WriteLine("\ne) Implementa un método publico llamado Move que, si tiene fuel es mayor a 0, incremente distance en 1 y decremente fuel en consomer:");

            Console.WriteLine("\nf) Crea una interfaz llamada IPurchaseItem que contenga una función float GetPurchasePrice():");

            Console.WriteLine("\ng) Implementa la interfaz del ejercicio anterior en la clase Car haciendo que el método tenga en cuenta el fuel restante (cuanto más fuel más caro), la distancia (cuanta más distancia más barato) y el tamaño (cuanto mayor más caro):");

            Console.WriteLine("\nh) Crea una clase Smarthphone que tenga las variables privadas: DateTime releaseDate y SizeType size con sus getters y setters, cuyo constructor acepte un DateTime para releaseDate y un SizeType para size que implemente la interfaz IPurchaseItem haciendo que el método tenga en cuenta releaseDate (cuanto más cercano a hoy más caro) y el tamaño (cuando mayor más barato):");

            Console.WriteLine("\ni) Crea un método estático InitializeShop() con una lista de IPurchaseItem que incluya tres coches: uno sin ningún movimiento, uno con un movimiento (car.Move()) y otro con dos movimientos, y dos smartphones con las características que quieras. Recorre la lista y muestra por consola su precio de venta:");
            InitializeShop();
        }

        private static void InitializeShop() {
            var items = new List<IPurchaseItem>();
            for (var i = 0; i < 3; i++) {
                var car = new Car((SizeType)i);
                for (var j = 0; j < i; j++)
                    car.Move();

                items.Add(car);
            }

            items.Add(new Smartphone(DateTime.Today.AddYears(-3), SizeType.Medium));
            items.Add(new Smartphone(DateTime.Today.AddYears(-1), SizeType.Small));

            foreach (var item in items)
                Console.WriteLine($"Ejercicio i: {item.GetType()} with price {item.GetPurchasePrice()}€");
        }
    }
}
