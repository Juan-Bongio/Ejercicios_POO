using System;

namespace SimuladorAutomovil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONFIGURACIÓN INICIAL DEL AUTOMÓVIL ===");

            Console.Write("Ingrese la marca del vehículo: ");
            string marca = Console.ReadLine();

            Console.Write("¿Tiene caja automática? (S/N): ");
            string caja = Console.ReadLine().ToUpper();

            bool automatica = false;
            if (caja == "S" || caja == "s")
            {
                automatica = true;
            }

            Automovil miAuto = new Automovil(marca, automatica);

            int op = 0;
            while (op != 7)
            {
                Console.Clear();

                Console.WriteLine("==================================================");
                Console.WriteLine(" IDENTIFICADOR: " + miAuto.IDENTIFICADOR);
                Console.WriteLine("==================================================");

                if (miAuto.MotorEncendido)
                {
                    Console.WriteLine(" MOTOR: ON");
                }
                else
                {
                    Console.WriteLine(" MOTOR: OFF");
                }

                Console.WriteLine(" VELOCIDAD ACTUAL: " + miAuto.VelocidadActual + " km/h");

                if (miAuto.ModoCrucero)
                {
                    Console.WriteLine(" CONTROL CRUCERO: ACTIVO");
                }
                else
                {
                    Console.WriteLine(" CONTROL CRUCERO: INACTIVO");
                }
                Console.WriteLine("==================================================");

                Console.WriteLine("1. Encender / Apagar Motor");
                Console.WriteLine("2. Acelerar (10 km/h)");
                Console.WriteLine("3. Acelerar (Elegir km/h)");
                Console.WriteLine("4. Frenar (Emergencia)");
                Console.WriteLine("5. Frenar (Elegir km/h)");
                Console.WriteLine("6. Activar Control de Crucero");
                Console.WriteLine("7. Salir de la simulación");
                Console.Write("Seleccione una opción del control remoto: ");
                op = Convert.ToInt32(Console.ReadLine());

                int kmh;
                switch (op) 
                {
                    case 1:
                        miAuto.EncenderApagar();
                        break;
                    case 2:
                        miAuto.Acelerar();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("¿Cuántos km/h quiere acelerar?: ");
                        kmh = Convert.ToInt32((Console.ReadLine()));
                        miAuto.Acelerar(kmh);
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        miAuto.Frenar();
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("¿Cuántos km/h quiere reducir?: ");
                        kmh = Convert.ToInt32((Console.ReadLine()));
                        miAuto.Frenar(kmh);
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 6:
                        miAuto.ActivarControlCrucero();
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Simulación finalizada. ¡Gracias por conducir!");
                        break;
                }
            }
        }
    }
}