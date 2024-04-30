using System;
using System.Collections.Generic;



namespace PrimerosPasos
{
    public class Ejercicios
    {
        public Ejercicios()
        {
            //****************************************************************
            // 1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.
            int variable1, variable2, variable3, resultado;
            variable1 = 10;
            variable2 = 5;
            variable3 = 20;

            resultado = variable1 + variable2 + variable3;

            Console.WriteLine($"El resultado de la suma es: {resultado}");
            //****************************************************************

            // 2) Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales o comprobarlos) y mostrar por pantalla, el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad>
            string nombre, ciudad;
            Console.WriteLine("Ingresa tu nombre sin apellidos");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el nombre de tu ciudad");
            ciudad = Console.ReadLine();

            Console.WriteLine($"Tu nombre es: {nombre} y vives en: {ciudad}");
            //****************************************************************

            // 3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: «Te llamas » <nombre> » y tienes » <años> » años»}
            string name;
            int edad;
            Console.WriteLine("Ingresa tu nombre sin apellidos");
            name = Console.ReadLine();

            Console.WriteLine("¿Cuántos años tienes?");
            edad = int.Parse(Console.ReadLine());

            //alternativa
            /*
             Console.WriteLine ("¿Cuántos años tienes?");
            String texto = Console.ReadLine ();
 
            int edad = Convert.ToInt32 (texto);
             */

            Console.WriteLine($"Te llamas {name} y tu edad es: {edad}");
            //****************************************************************

            //4) Pedir dos números al usuario por teclado y decir que número es el mayor.
            int num1, num2, mayor;
            Console.WriteLine("Ingresa el primer número entero");
            num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingresa el segundo número entero");
            num2 = int.Parse(Console.ReadLine());

            mayor = num1 <= num2 ? num2 : num1;

            Console.WriteLine("El número mayor es: " + mayor);

            /*
                ALTERNATIVA
                 Console.WriteLine("Ingresa dos números enteros separados por espacio:");
                string[] numeros = Console.ReadLine().Split();

                int num1 = int.Parse(numeros[0]);
                int num2 = int.Parse(numeros[1]);

                int mayor = num1 < num2 ? num2 : num1;

                Console.WriteLine("El número mayor es: " + mayor);               
            */
            //****************************************************************

            // 5) Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo.
            string dia;

            Console.WriteLine("Ingresa un día de la semana");
            dia = Console.ReadLine().ToLower();

            switch (dia)
            {
                case "lunes":
                case "martes":
                case "miércoles":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana, trabaja");
                    break;
                case "sábado":
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana, disfrútalo");
                    break;
                default:
                    Console.WriteLine("No existe ese día de la semana");
                    break;
            }

            //****************************************************************


        }
    }
}
