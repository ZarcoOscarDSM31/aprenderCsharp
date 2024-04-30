using System;
using System.Collections.Generic;


namespace PrimerosPasos
{
    public class Variables
    {
        public Variables()
        {

            Console.WriteLine("Hello World");

            //Existen este tipo de comentarios que son de una sola línea 
            /*
             * Y existen estos otros comentarios 
             * que son de multilíneas          
             */

            //C# es un lenguaje fuertemente tipado, donde cada una de las variables se deben tipar en coparación a python o JS


            //********************************************* T I P O S    D E    D A T O S    P R I M I T I V O S ********************************************************

            //TEXTO
            string miTexto;
            miTexto = "Example";

            Console.WriteLine(miTexto);
            //****************************************************************

            //NÚMEROS ENTEROS
            int miNumero, miNumero2;
            miNumero = 10;
            miNumero2 = 20;

            Console.WriteLine(miNumero);
            Console.WriteLine(miNumero - 1);
            Console.WriteLine((miNumero + 2) * 4);
            //****************************************************************

            //NÚMEROS DECIMALES CORTOS
            float miDecimal;
            miDecimal = 5.5f;

            Console.WriteLine(miDecimal);
            //****************************************************************

            //NÚMEROS DECIMALES LARGOS
            double miDecLargo;
            miDecLargo = 5.55654455;

            Console.WriteLine(miDecLargo);
            //****************************************************************

            //BOOLEANOS
            bool verdad, falso;
            verdad = true;
            falso = false;

            Console.WriteLine(verdad);
            Console.WriteLine(falso);
            //****************************************************************

            //DINÁMICOS
            /* 
            dynamic miDinamico; //DATO DE TIPO DINÁMICO, O SEA, SE PUEDE CAMBIAR ENTRE ENTEROS, TEXTO, BOOLEANOS, ETC.
            miDinamico = 10;
            miDinamico = "Ejemplo de cambio";

            Console.WriteLine(miDinamico);
            */

            //DEBIDO A PROBLEMAS CON MONODEVELOP Y DEPENDENCIAS NO INSTALADAS; ESTE TIPO DE DATO NO FUNCIONA CORRECTAMENTE



            //********************************************* V A R I A B L E S   Y   C O N S T A N T E S ********************************************************

            //VARIABLES (declaración implícita de variables)
            //En este tipo de variables C# ya infiere cuál es el tipo de dato
            var texto = "hola mundo"; //VARIABLE DE TIPO INFERIDO
            // texto = 2;  Si yo intento hacer esto, como en las asignaciones que hice anteriormente, no se puede porque no está tipado el dato manualmente
            var numero = 9;
            Console.WriteLine(texto);
            Console.WriteLine(numero);

            //CONSTANTES
            //En este caso se debe de tipar la constante porque C# no lo puede inferir
            const string textoConstante = "Ejemplo de constante";
            Console.WriteLine(textoConstante);
            //EN AMBOS CASOS DE LAS VARIABLES Y LAS CONSTANTES ESTÁS SE DEBERÁN ASIGNAR Y TIPAR DENTRO DE LA MISMA LÍNEA.



            //********************************************* O P E R A C I O N E S   B A S I C A S ********************************************************

            //Suma 
            int suma;
            suma = miNumero + miNumero2;
            Console.WriteLine(suma);
            //****************************************************************

            //resta
            int resta;
            resta = miNumero - miNumero2;
            Console.WriteLine(resta);
            //****************************************************************

            //multiplicacion
            int multiplicacion;
            multiplicacion = miNumero * miNumero2;
            Console.WriteLine(multiplicacion);
            //****************************************************************

            //division
            int division;
            division = miNumero / miNumero2;
            Console.WriteLine(division);
            //****************************************************************

            //modulo / residuo
            int residuo;
            residuo = miNumero % miNumero2;
            Console.WriteLine(residuo);



            //********************************************* O P E R A D O R E S ********************************************************
                
            //incremento "++"
            int number = 10;
            //number++;
            number += 10;
            Console.WriteLine(number);
            //****************************************************************

            //decremento "--"
            //number--;
            number -= 5;
            Console.WriteLine(number);
            //****************************************************************

            //Asignacion "="
            int edadPersona1, edadPersona2, edadPersona3, edadPersona4;
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 50;
            Console.WriteLine(edadPersona4);


            //********************************************* I M P R E S I O N E S   D E S D E   C O N S O L A ********************************************************

            //En caso de que no solamente quiera sumar numeros enteros también puedo hacerlo desde la impresión de la consola
            Console.WriteLine(miNumero + miDecimal);
            Console.WriteLine(miNumero + miDecLargo);
            //****************************************************************

            //Interpolar texto con números
            var sumaD = miNumero + miDecimal;
            Console.WriteLine($"El valor de mi número 1 es: {miNumero} y el valor de mi número decimal es: {miDecimal} y el resultado de la suma es: {sumaD}");
            //****************************************************************

            //Concatenar texto con números
            Console.WriteLine("El valor de mi número 1 es: " + miNumero + " y el valor de mi número decimal es: " + miDecimal + " y el resultado de la suma es: " + sumaD);
            //****************************************************************

            //Prefijos
            int numerito = 10;
            Console.WriteLine(numerito++); //Esto no es recomendable, pues la lectura del código va de izquierda a derecha y no imprime la incrementación 
            //****************************************************************

            //Sufijos
            numerito += 5;
            Console.WriteLine(numerito);



            //******************************************************** E S T R U C T U R A S ********************************************************

            //ARREGLOS
            var miArray = new string[] { "Oscar", "Daniel", "Zarco" };
            Console.WriteLine(miArray[0]);
            //****************************************************************

            //DICCIONARIOS
            var miDIccionario = new Dictionary<string, int>
            {
                {"Oscar", 20},
                {"Daniel", 30}
            };
            Console.WriteLine(miDIccionario["Oscar"]);
            //****************************************************************

            //SET'S
            var MiSet = new HashSet<string> { "Oscar", "Daniel", "Zarco" }; //Estructuras desordenadas
            //Console.WriteLine(MiSet[0]);
            //****************************************************************

            //TUPLAS
            var miTupla = ("Oscar", "Daniel", "Zarco");
            Console.WriteLine(miTupla);



            //******************************************************** C I C L O S ********************************************************

            //FOR 
            for (int index = 0; index <= 10; index++)
            {
                Console.WriteLine(index);
            }
            //****************************************************************

            //FOREACH
            foreach (var miItem in miArray) //recorrer el arreglo
            {
                Console.WriteLine(miItem);
            }
            foreach (var miItem in miDIccionario) //recorrer el diccionario
            {
                Console.WriteLine(miItem);
            }
            foreach (var miItem in MiSet) //recorrer el set
            {
                Console.WriteLine(miItem);
            }
            //****************************************************************

            //WHILE 
            //****************************************************************

            //DO-WHILE


            //******************************************************** D E S I C I O N ********************************************************

            //IF
            if (miNumero == 11 && falso == false)
            {
                Console.WriteLine("El valor es de 11");
            }
            else if (miNumero == 12 || verdad == true)
            {
                Console.WriteLine("El valor es de 12");
            }
            else
            {
                Console.WriteLine($"El valor del dato es {miNumero}");
            }
            //****************************************************************

            //SWITCH


            //******************************************************** T I P S   O   A Y U D A S ***************************
            //Conversión explícita
            double temperaura = 30.5;
            int temperaturaMexico;

            temperaturaMexico = (int)temperaura;
            Console.WriteLine(temperaturaMexico);


            //******************************************************** T I P S   O   A Y U D A S ***************************

            /*
             El "++" ayuda mucho cuando se quieren hacer incrementos automáticos
             se usa mucho en ciclos y aplica lo mismo con el "--" pero este 
             es decremento, o sea que va restando            
                         
                         Existe también esto "+=5" que ayuda para que se vaya incrementando de 5 en 5
                         o el "-=5" que aqui se va decrementando de 5 en 5                        
             */
        }
    }
}
