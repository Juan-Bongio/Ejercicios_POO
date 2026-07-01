using System;
using System.Collections.Generic;

namespace FactoryAlert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sensor> sensores = new List<Sensor>();

            sensores.Add(new SensorTemperatura { Id = "TEMP-01", LimiteCritico = 80 });
            sensores.Add(new SensorPresion { Id = "PRES-01" });

            Console.WriteLine("--- FactoryAlert ---");

            foreach (Sensor sensor in sensores)
            {
                if (sensor is SensorTemperatura)
                {
                    Console.WriteLine(sensor.EvaluarLectura(95));
                }

                if (sensor is SensorPresion)
                {
                    Console.WriteLine(sensor.EvaluarLectura(10));
                    Console.WriteLine(sensor.EvaluarLectura(20));
                    Console.WriteLine(sensor.EvaluarLectura(30));
                }
            }

            Console.ReadLine();
        }
    }
}