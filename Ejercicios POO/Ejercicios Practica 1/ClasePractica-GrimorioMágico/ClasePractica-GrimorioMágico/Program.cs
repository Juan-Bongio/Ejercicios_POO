using System;
using System.Collections.Generic;

namespace GrimorioMagico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hechizo> hechizos = new List<Hechizo>();

            hechizos.Add(new BolaFuego { Encantamiento = "Fire Ball", TemperaturaC = 1200 });
            hechizos.Add(new EscudoHielo { Encantamiento = "Glaciar Defense", GrosorCapas = 5 });

            Console.WriteLine("--- Grimorio Mágico ---");

            foreach (Hechizo hechizo in hechizos)
            {
                Console.WriteLine(hechizo.Lanzar());
            }

            Console.ReadLine();
        }
    }
}