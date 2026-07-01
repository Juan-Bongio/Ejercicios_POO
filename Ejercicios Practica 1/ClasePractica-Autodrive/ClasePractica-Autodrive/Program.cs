using System;
using System.Collections.Generic;

namespace AutoDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            vehiculos.Add(new AutoElectrico { Marca = "Tesla", Autonomia = 500 });

            vehiculos.Add(new Camioneta { Marca = "Ford", Traccion4x4 = true });

            Console.WriteLine("--- Concesionaria AutoDrive ---");

            foreach (Vehiculo vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.Arrancar());
            }

            Console.ReadLine();
        }
    }
}