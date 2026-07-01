using System;
using System.Collections.Generic;

namespace ToyFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Juguete> juguetes = new List<Juguete>();

            juguetes.Add(new Muneca { NumeroSerie = "JUG 1", MaterialCabello = "Nailon" });
            juguetes.Add(new AutoControl { NumeroSerie = "JUG 2", Frecuencia = 2.4 });

            Console.WriteLine("--- ToyFactory ---");

            foreach (Juguete juguete in juguetes)
            {
                Console.WriteLine(juguete.ProbarJuguete());
            }

            Console.ReadLine();
        }
    }
}