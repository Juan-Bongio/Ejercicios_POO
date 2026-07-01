using System;
using System.Collections.Generic;

namespace MediaStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contenido> contenidos = new List<Contenido>();

            contenidos.Add(new Pelicula { Titulo = "Interstellar", DuracionMinutos = 169, Clasificacion = "ATP" });
            contenidos.Add(new Serie { Titulo = "Dark", DuracionMinutos = 50, Episodios = 26 });

            Console.WriteLine("--- MediaStream ---");

            foreach (Contenido contenido in contenidos)
            {
                Console.WriteLine(contenido.Reproducir());
            }

            Console.ReadLine();
        }
    }
}