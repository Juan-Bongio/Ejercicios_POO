using System;
using System.Collections.Generic;

namespace MarketCraft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ItemMercado> items = new List<ItemMercado>();

            items.Add(new Pocion { Nombre = "Poción de Vida", PrecioBase = 50, Stock = 6 });
            items.Add(new MineralRaro { Nombre = "Mithril", PrecioBase = 200, Stock = 3, FactorEscasez = 2 });

            Console.WriteLine("--- MarketCraft ---");

            foreach (ItemMercado item in items)
            {
                Console.WriteLine(item.CotizarVenta(10));
            }

            Console.ReadLine();
        }
    }
}