using System;
using System.Collections.Generic;

namespace CitadelDefense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Torreta> torretas = new List<Torreta>();

            torretas.Add(new TorretaLaser { Ubicacion = "Muralla Norte", CargaBateria = 85 });
            torretas.Add(new Lanzamisiles { Ubicacion = "Torre Este", MunicionRestante = 12 });

            Console.WriteLine("--- CitadelDefense ---");

            foreach (Torreta torreta in torretas)
            {
                Console.WriteLine(torreta.Disparar());
            }

            Console.ReadLine();
        }
    }
}