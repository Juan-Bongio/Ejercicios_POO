using System;
using System.Collections.Generic;

namespace SmartToll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new Particular { Patente = "ABC123", Saldo = 1000 });
            vehiculos.Add(new Particular { Patente = "DEF456", Saldo = 50 });
            vehiculos.Add(new Camion { Patente = "GHI789", Saldo = 3000, Ejes = 6 });
            vehiculos.Add(new Camion { Patente = "JKL012", Saldo = 500, Ejes = 4 });

            decimal tarifaBase = 200;

            Console.WriteLine("--- SmartToll ---");

            foreach (Vehiculo vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.PagarPeaje(tarifaBase));
            }

            Console.ReadLine();
        }
    }
}