using System;
using System.Collections.Generic;

namespace BioTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Planta> plantas = new List<Planta>();

            plantas.Add(new Cactus { EdadDias = 30, Salud = 80 });
            plantas.Add(new Helecho { EdadDias = 15, Salud = 90, HumedadRequerida = 70 });

            Console.WriteLine("--- BioTech ---");

            string[] climas = { "Seco", "Lluvioso", "Desértico" };

            foreach (string clima in climas)
            {
                Console.WriteLine($"\nClima: {clima}");

                foreach (Planta planta in plantas)
                {
                    Console.WriteLine(planta.AplicarClima(clima));
                }
            }

            Console.ReadLine();
        }
    }
}