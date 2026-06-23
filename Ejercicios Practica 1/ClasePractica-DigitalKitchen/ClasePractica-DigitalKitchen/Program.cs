using System;
using System.Collections.Generic;

namespace DigitalKitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Plato> platos = new List<Plato>();

            platos.Add(new Pizza { NombrePlato = "Muzzarella", TipoMasa = "Fina" });
            platos.Add(new Ensalada { NombrePlato = "César", TipoAderezo = "César" });

            Console.WriteLine("--- DigitalKitchen ---");

            foreach (Plato plato in platos)
            {
                Console.WriteLine(plato.Preparar());
            }

            Console.ReadLine();
        }
    }
}