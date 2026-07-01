using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace OrquestaVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Instrumento> instrumentos = new List<Instrumento>();

            instrumentos.Add(new Guitarra { Modelo = "Fender Stratocaster", NumeroCuerdas = 6 });
            instrumentos.Add(new Piano { Modelo = "Yamaha C3", NumeroTeclas = 88 });

            Console.WriteLine("--- Orquesta Virtual ---");

            foreach (Instrumento instrumento in instrumentos)
            {
                Console.WriteLine(instrumento.TocarNota());
            }

            Console.ReadLine();
        }
    }
}