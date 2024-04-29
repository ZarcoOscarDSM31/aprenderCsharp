using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructure
{
    internal class Program
    {

        public class Musician
        {
            public string Name { get; set; }
            public string Instrument { get; set; }
            public int Age { get; set; }
        }

        public static void Main(string[] args)
        {
            /*
            //ESTRUCTURA DE DATOS (QUEUE) = COLA
            var queue = new Queue<Musician>();

            queue.Enqueue(new Musician
            {
                Name = "Michael",
                Instrument = "Piano",
                Age = 35
            });
            queue.Enqueue(new Musician
            {
                Name = "John",
                Instrument = "Guitarra",
                Age = 30
            });
            queue.Enqueue(new Musician
            {
                Name = "Paul",
                Instrument = "Bateria",
                Age = 40
            });

            while (queue.Count > 0)
            {
                var musician = queue.Dequeue();
                Console.WriteLine($"El nombre del músico es: '{musician.Name}', el instrumento que interpreta es: '" +
                    $"{musician.Instrument}'");
            }
            */



            
            //ESTRUCTURA DE DATOS (ARRAY) = ARREGLO
            var musicianArray = new Musician[]
            {
                new Musician
                {
                    Name = "Michael",
                    Instrument = "Piano",
                    Age = 35
                },
                new Musician
                {
                    Name = "Jhon",
                    Instrument = "Guitarra",
                    Age = 40
                },
                new Musician
                {
                    Name = "Paul",
                    Instrument = "Bateria",
                    Age = 40
                }
            };

            //foreach (var musician in musicianArray)
            //{
            //    Console.WriteLine("El nombre del músico es: '" + musician.Name + "' y El instrumento que interpreta es: '" + musician.Instrument + "'");
            //}
            


            //ESTRUCTURA DE DATOS (LIST) = LISTA
            var musicianList= new List<Musician>();

            musicianList.AddRange(musicianArray);
            musicianList.ForEach(x => Console.WriteLine(x?.Name + " - " + x?.Instrument + " - " + x?.Age));



            Console.ReadLine();
        }
}
}
