using System; //Es como una librería que sirve para distintas cosas, una de ellas es manjear el Console.
using System.Collections.Generic;

namespace PrimerosPasos //Espacio de nombre, son únicos y pueden tener varias clases
{
    class MainClass //NO puede repetirse el nombre de la clase en el mismo namespace; porque es redundancia de clases.
    {
        public static void Main(string[] args)
        {
            //Ejercicios ejercicios = new Ejercicios();

            //Variables variables = new Variables();

            //6) Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)
            var productos = new Dictionary<string, int>
            {
                {"crema", 29},
                {"papas", 30},
                {"coca", 20},
                {"agua", 15}
            };
            Console.WriteLine("Menú de productos:");
            foreach (var producto in productos)
            {
                Console.WriteLine($"{producto.Key}: ${producto.Value}");
            }
            Console.WriteLine("\t\t\t\t\t");
            Console.WriteLine("¿Qué producto se va a llevar?");

            string productoSeleccionado = Console.ReadLine().ToLower();

            if (!productos.ContainsKey(productoSeleccionado))
            {
                Console.WriteLine("El producto ingresado no está disponible.");
                return;
            }

            int precio = productos[productoSeleccionado];

            Console.WriteLine("\t\t\t\t\t");
            Console.WriteLine("¿Cómo desea pagar? (efectivo/tarjeta)");
            string formaPago = Console.ReadLine().ToLower();

            if (formaPago == "tarjeta")
            {
                Console.WriteLine("Ingrese el número de cuenta:");
                string numeroCuenta = Console.ReadLine();

                Console.WriteLine("\t\t\t\t\t");
                Console.WriteLine("Resumen de la compra:");
                Console.WriteLine("Producto: " + productoSeleccionado);
                Console.WriteLine("Precio: " + precio);
                Console.WriteLine("Forma de pago: " + formaPago);
                Console.WriteLine("Número de cuenta: " + numeroCuenta);
            }
            else if (formaPago == "efectivo")
            {
                Console.WriteLine("\t\t\t\t\t");
                Console.WriteLine("Pagado");
            }
            else
            {
                Console.WriteLine("\t\t\t\t\t");
                Console.WriteLine("Forma de pago no reconocida.");
            }
        }
    }
}
