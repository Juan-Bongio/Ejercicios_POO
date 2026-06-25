using System;
using System.Collections.Generic;

namespace CyberShield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alerta> alertas = new List<Alerta>();

            alertas.Add(new IntrusionRed { Codigo = "ALERTA 1", IpOrigen = "192.168.1.100" });
            alertas.Add(new MalwareDetectado { Codigo = "ALERTA 2", RutaArchivo = "C:\\Archivos\\virus.exe" });

            Console.WriteLine("--- CyberShield ---");

            foreach (Alerta alerta in alertas)
            {
                Console.WriteLine(alerta.DispararProtocolo());
            }

            Console.ReadLine();
        }
    }
}