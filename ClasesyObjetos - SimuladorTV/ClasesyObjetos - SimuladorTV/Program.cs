using System;

namespace SmartTv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONFIGURACIÓN INICIAL DEL SMART TV ===");

            Console.Write("Ingrese la marca del dispositivo: ");
            string marca = Console.ReadLine();

            Console.Write("Ingrese las pulgadas del dispositivo: ");
            int pulgadas = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Tiene el plan Premium? (S/N): ");
            string modelo = Console.ReadLine().ToUpper();

            bool premium = false;
            if (modelo == "S")
            {
                premium = true;
            }

            Smart miTV = new Smart(marca, pulgadas, premium);

            int op = 0;
            while (op != 7)
            {
                Console.Clear();

                Console.WriteLine("==================================================");
                Console.WriteLine(" CODIGO DE CONFIGURACION: " + miTV.CODIGO_CONFIG);
                Console.WriteLine("==================================================");

                if (miTV.Encendido)
                {
                    Console.WriteLine(" TV: ON");
                }
                else
                {
                    Console.WriteLine(" TV: OFF");
                }

                Console.Write(" CANAL ACTUAL: " + miTV.CanalActual);
                Console.Write(" | ");

                if (miTV.Volumen == 0)
                {
                    Console.WriteLine("VOLUMEN: MUTE");
                }
                else
                {
                    Console.WriteLine("VOLUMEN: " + miTV.Volumen);
                }

                Console.WriteLine("==================================================");

                Console.WriteLine("1. [Power]");
                Console.WriteLine("2. [CH +]");
                Console.WriteLine("3. [CH -]");
                Console.WriteLine("4. [Numerico]");
                Console.WriteLine("5. [VOL +]");
                Console.WriteLine("6. [VOL -]");
                Console.WriteLine("7. Salir de la simulación");
                Console.Write("Seleccione una opción del control remoto: ");
                op = Convert.ToInt32(Console.ReadLine());

                bool subir;
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        miTV.Power();
                        break;
                    case 2:
                        Console.Clear();
                        miTV.SubirCanal();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        miTV.BajarCanal();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();

                        Console.WriteLine("┌───┬───┬───┐");
                        Console.WriteLine("│ 1 │ 2 │ 3 │");
                        Console.WriteLine("├───┼───┼───┤");
                        Console.WriteLine("│ 4 │ 5 │ 6 │");
                        Console.WriteLine("├───┼───┼───┤");
                        Console.WriteLine("│ 7 │ 8 │ 9 │");
                        Console.WriteLine("├───┼───┼───┤");
                        Console.WriteLine("│     0     │");
                        Console.WriteLine("└───────────┘");

                        Console.Write("\nIngrese el canal: ");

                        int canal = Convert.ToInt32(Console.ReadLine());

                        miTV.CambiarCanal(canal);

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();

                        subir = true;
                        miTV.RegularVolumen(subir);

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();

                        subir = false;
                        miTV.RegularVolumen(subir);

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Simulación finalizada.");
                        break;
                }
            }
        }
    }
}