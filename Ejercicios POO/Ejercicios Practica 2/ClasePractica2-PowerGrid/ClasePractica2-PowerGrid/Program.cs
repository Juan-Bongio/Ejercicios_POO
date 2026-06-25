using System;
using System.Collections.Generic;

namespace PowerGrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bateria> baterias = new List<Bateria>();

            baterias.Add(new BateriaLitio { PorcentajeCarga = 50 });
            baterias.Add(new BateriaSolar { PorcentajeCarga = 50, EficienciaPanel = 30 });

            Console.WriteLine("--- PowerGrid ---");

            for (int ronda = 1; ronda <= 3; ronda++)
            {
                Console.WriteLine($"\nRonda {ronda}");

                foreach (Bateria bateria in baterias)
                {
                    Console.WriteLine(bateria.ConsumirEnergia(25));
                }
            }

            Console.ReadLine();
        }
    }
}