using calculosMatematicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;
            Console.WriteLine("ingrese el primer numero");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            numero2 = Convert.ToDouble(Console.ReadLine());

            double suma = Operaciones.Sumar(numero1, numero2);
            double resta = Operaciones.Restar(numero1, numero2);


            Console.WriteLine($"la suma es: {suma}" );
            Console.WriteLine($"la resta es: {resta}");
            Console.ReadLine();
        }
    }
}
