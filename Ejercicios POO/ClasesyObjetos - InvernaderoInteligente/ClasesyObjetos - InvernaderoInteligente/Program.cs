using Invernadero_Inteligente;
using System;

namespace Invernadero_Inteligente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONFIGURACIÓN INICIAL DEL INVERNADERO ===");

            Console.Write("Ingrese el nombre del sector (Ej: Norte, Lote A): ");
            string sector = Console.ReadLine();

            Console.Write("Ingrese tipo de cultivo (TROPICAL / DESERTICO): ");
            string tipo = Console.ReadLine();

            Invernadero miInvernadero = new Invernadero(sector, tipo);

            int op = 0;
            while (op != 5)
            {
                Console.Clear();

                Console.WriteLine("==========================================================================");
                Console.WriteLine(" " + miInvernadero.REPORTE_ESTADO);
                Console.WriteLine("==========================================================================");

                Console.Write(" SENSOR TEMPERATURA: " + miInvernadero.TemperaturaActual + "°C");
                Console.WriteLine(" | SENSOR HUMEDAD: " + miInvernadero.HumedadSuelo + "%");

                Console.Write(" ACTUADOR RIEGO: ");
                if (miInvernadero.SistemaRiegoActivo)
                {
                    Console.Write("[ON]");
                }
                else
                {
                    Console.Write("[OFF]");
                }

                Console.Write(" | ACTUADOR CALEFACCIÓN: ");
                if (miInvernadero.CalefaccionActiva)
                {
                    Console.WriteLine("[ON]");
                }
                else
                {
                    Console.WriteLine("[OFF]");
                }
                Console.WriteLine("==========================================================================");

                Console.WriteLine("1. [Paso del Tiempo] (Simular avance natural del clima)");
                Console.WriteLine("2. [Forzar Clima] (Ingresar valores de sensores manualmente)");
                Console.WriteLine("3. [Ejecutar Control Automático] (Chequear y activar sistemas)");
                Console.WriteLine("4. [Mostrar rangos ideales del cultivo actual]");
                Console.WriteLine("5. Salir del simulador agrícola");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.Write("Seleccione una opción: ");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        miInvernadero.SimularClima();
                        Console.WriteLine("Pasó el tiempo: Humedad bajó un 5% y Temperatura subió 1°C.");
                        Console.WriteLine("\nPresione una tecla para actualizar el panel...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- ENTRADA MANUAL DE SENSORES ---");
                        Console.Write("Ingrese nueva Humedad (0-100%): ");
                        int hum = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ingrese nueva Temperatura (°C): ");
                        int temp = Convert.ToInt32(Console.ReadLine());

                        miInvernadero.SimularClima(hum, temp);
                        Console.WriteLine("\nSensores actualizados con éxito.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        miInvernadero.ControlAutomatico();
                        Console.WriteLine("Análisis climático completado. Actuadores regulados.");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("=== RANGOS IDEALES DE CONFIGURACIÓN ===");
                        if (miInvernadero.TipoCultivo == "TROPICAL")
                        {
                            Console.WriteLine("Cultivo: TROPICAL");
                            Console.WriteLine("-> Humedad requerida: Mayor al 60%");
                            Console.WriteLine("-> Temperatura requerida: Entre 20°C y 28°C");
                        }
                        else
                        {
                            Console.WriteLine("Cultivo: DESÉRTICO");
                            Console.WriteLine("-> Humedad requerida: Menor al 20%");
                            Console.WriteLine("-> Temperatura requerida: Entre 25°C y 35°C");
                        }
                        Console.WriteLine("\nPresione una tecla para regresar...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Simulación agrícola finalizada.");
                        break;
                }
            }
        }
    }
}