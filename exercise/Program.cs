using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  (1)
                //Número al cuadrado
                int numero;
                Console.WriteLine("ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                //Con metodo Math.Pow
                //var response = Math.Pow(numero, 2);
                //Console.WriteLine($"el cuadrado de {numero} es {response}");

                //Sin método Math.Pow
                Console.WriteLine("{0} al cuadrado  es: {1}", numero, numero * numero);

                Console.ReadLine();
            */
            //*****************************

            /*  (2)
                //Multiplicación entre 3 factores

                double num1, num2, num3, multiplicacion;

                Console.WriteLine("ingrese el primer numero");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el segundo numero");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el tercer numero");
                num3 = double.Parse(Console.ReadLine());


                //Todo en una sola linea
                Console.WriteLine("{0} * {1} * {2} = {3}", num1, num2, num3, num1 * num2 * num3);

                //En diferentes lineas
                multiplicacion = (num1 * num2) * num3;
                //Console.WriteLine("El resultado de la multiplicación entre los números {0}, {1}, {2} es: " + multiplicacion, num1, num2, num3, multiplicacion);
            */
            //*****************************

            /*  (3)
                //solicite dos números enteros al usuario (x, y) y imprima el resultado de la división y el resto de la división en una nueva linea.

                int num1, num2;

                Console.WriteLine("ingrese el primer numero");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                var division = num1 / num2;
                var resto = num1 % num2;

                Console.WriteLine("El resultado de la división es: " + division);
                Console.WriteLine( "El resto/sobrante es: " + resto);
            */

            //*****************************

            /*  (4)
                int num1, num2, division;

                Console.WriteLine("ingrese el primer numero");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el segundo numero"); 
                num2 = Convert.ToInt32(Console.ReadLine());

                try 
                {
                    division = num1 / num2;
                    Console.WriteLine("El resultado de la división es: " + division);

                    //Console.WriteLine("{0}/{1}= {2}", num1, num2, num1 / num2);

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("No se puede dividir por 0");
                }
            */

            //*****************************

            /*  (5)
                int num1;

                Console.WriteLine("ingrese un numero");
                num1 = Convert.ToInt32(Console.ReadLine());

                var operacion1 = -6 + (num1 * 5);
                Console.WriteLine($"El resultado de la operación -6 + {num1} * 5 es: " + operacion1);

                var operacion2 = (13 - 2) * num1;
                Console.WriteLine($"El resultado de la operación (13 - 2) * {num1} es: " + operacion2);

                var operacion3 = (num1 + (-2)) * (20 / 10);
                Console.WriteLine($"El resultado de la operación {num1} + (-2) * (20 / 10) es: " + operacion3);

                var operacion4 = (12 + num1) % (5 - 4);
                Console.WriteLine($"El resultado de la operación (12 + {num1}) % (5 - 4) es: " + operacion4);
            */

            //*****************************

            Console.ReadLine();


        }
    }
}
