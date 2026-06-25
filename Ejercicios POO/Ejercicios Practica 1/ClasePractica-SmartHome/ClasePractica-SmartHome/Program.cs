using System;
using System.Collections.Generic;

namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dispositivo> dispositivos = new List<Dispositivo>();

            dispositivos.Add(new AspiradoraRobot { Habitacion = "Living", CapacidadTanque = 500 });
            dispositivos.Add(new LamparaInteligente { Habitacion = "Dormitorio", ColorLed = "Azul" });

            Console.WriteLine("--- SmartHome ---");

            foreach (Dispositivo dispositivo in dispositivos)
            {
                Console.WriteLine(dispositivo.EjecutarFuncion());
            }

            Console.ReadLine();
        }
    }
}