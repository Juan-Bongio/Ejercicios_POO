using System;
using System.Collections.Generic;

namespace NetFetch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Descarga> descargas = new List<Descarga>();

            descargas.Add(new StreamingVideo { TamanoMegas = 1000, Progreso = 0, BufferMinimo = 20 });
            descargas.Add(new ArchivoComprimido { TamanoMegas = 500, Progreso = 0, EsSeguro = true });

            Console.WriteLine("--- NetFetch ---");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\nCiclo {i}");

                foreach (Descarga descarga in descargas)
                {
                    Console.WriteLine(descarga.ActualizarProgreso(100));
                }
            }

            Console.ReadLine();
        }
    }
}