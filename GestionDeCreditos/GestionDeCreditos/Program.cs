using System;

namespace GestionCreditos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int id = rand.Next(1000, 9999);
            string nombre = "Sin Nombre";
            decimal saldo = 0m;

            bool continuar = true;

            Console.WriteLine("--- Gestión de Créditos: Modo Estructurado ---");

            while (continuar)
            {
                Console.WriteLine("--- MENÚ DE GESTIÓN ---");
                Console.WriteLine("1. Registrar Cliente Temporal ($100)");
                Console.WriteLine("2. Registrar Cliente Registrado ($500)");
                Console.WriteLine("3. Mostrar Estado Actual");
                Console.WriteLine("4. Cambiar ID");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        nombre = "Cliente Temporal";
                        SumarCredito(ref saldo, 100);
                        Console.WriteLine("Se han sumado $100.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        nombre = "Cliente Registrado";
                        SumarCredito(ref saldo, 500);
                        Console.WriteLine("Se han sumado $500.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine($"\nID del Cliente: {id}");
                        MostrarInformacion(nombre, saldo);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        id = rand.Next(1000, 9999);
                        Console.WriteLine($"Nuevo ID generado: {id}");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        continuar = false;
                        Console.WriteLine("Saliendo del sistema...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static void SumarCredito(ref decimal saldoActual, decimal montoASumar)
        {
            saldoActual += montoASumar;
        }

        static void MostrarInformacion(string nombre, decimal saldo)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine($"NOMBRE: {nombre}");
            Console.WriteLine($"SALDO ACUMULADO: {saldo:C}");
            Console.WriteLine("===========================================");
            Console.ReadKey();
            Console.Clear();
        }
    }
}