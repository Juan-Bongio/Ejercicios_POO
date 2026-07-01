using System;
using System.Collections.Generic;

namespace AeroCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aeronave> aeronaves = new List<Aeronave>();

            aeronaves.Add(new AvionComercial { Matricula = "LV-ABC", HorasVuelo = 1200, CantidadPasajeros = 180 });
            aeronaves.Add(new AvionComercial { Matricula = "LV-DEF", HorasVuelo = 800, CantidadPasajeros = 120 });
            aeronaves.Add(new Helicoptero { Matricula = "LV-HEL", HorasVuelo = 300, EquipoRescate = true });

            Console.WriteLine("--- AeroCheck ---");

            foreach (Aeronave aeronave in aeronaves)
            {
                Console.WriteLine(aeronave.RevisarEstado());
            }

            Console.ReadLine();
        }
    }
}