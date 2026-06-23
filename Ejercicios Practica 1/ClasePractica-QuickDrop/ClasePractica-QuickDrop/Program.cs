using System;
using System.Collections.Generic;

namespace QuickDrop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Envio> envios = new List<Envio>();

            envios.Add(new EnvioExpress { Direccion = "Av. San Martín 123", TiempoLimiteHoras = 4 });
            envios.Add(new EnvioFragil { Direccion = "Calle Belgrano 456", MaterialProteccion = "Espuma de alta densidad" });

            Console.WriteLine("--- QuickDrop ---");

            foreach (Envio envio in envios)
            {
                Console.WriteLine(envio.ProcesarEntrega());
            }

            Console.ReadLine();
        }
    }
}