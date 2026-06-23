using System;
using System.Collections.Generic;

namespace NominaCorp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new Programador { IdEmpleado = "EMP 1", LenguajePrincipal = "C#" });
            empleados.Add(new Disenador { IdEmpleado = "EMP 2", HerramientaFavorita = "Photoshop" });

            Console.WriteLine("--- NominaCorp ---");

            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine(empleado.Trabajar());
            }

            Console.ReadLine();
        }
    }
}