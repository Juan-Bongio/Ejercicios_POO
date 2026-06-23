using System;
using System.Collections.Generic;

namespace CryptoCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mensaje> mensajes = new List<Mensaje>();

            mensajes.Add(new CifradoInvertido { TextoOriginal = "Hola Mundo" });

            mensajes.Add(new CifradoDesplazamiento { TextoOriginal = "Hola Mundo", ClaveNumerica = 4 });

            Console.WriteLine("--- CryptoCore ---");

            foreach (Mensaje mensaje in mensajes)
            {
                Console.WriteLine(mensaje.Cifrar());
            }

            Console.ReadLine();
        }
    }
}