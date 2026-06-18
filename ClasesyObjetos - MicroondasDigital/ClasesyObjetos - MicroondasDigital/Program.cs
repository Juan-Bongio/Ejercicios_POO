using Microondas_Digital;
using System;

namespace SimuladorMicroondas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONFIGURACIÓN INICIAL DEL MICROONDAS ===");

            Microondas miMicro = new Microondas();

            Console.Write("Establezca la potencia inicial (1-10) [Por defecto 5]: ");
            string potencia = Console.ReadLine();
            if (!string.IsNullOrEmpty(potencia))
            {
                miMicro.Potencia = Convert.ToInt32(potencia);
            }

            int op = 0;
            while (op != 7)
            {
                Console.Clear();

                Console.WriteLine("==================================================");
                Console.WriteLine(" PANTALLA DIGITAL: " + miMicro.PANTALLA_TIEMPO);
                Console.WriteLine("==================================================");

                if (miMicro.EnFuncionamiento)
                {
                    Console.WriteLine(" ESTADO: EN FUNCIONAMIENTO (CALENTANDO...)");
                }
                else
                {
                    Console.WriteLine(" ESTADO: EN ESPERA / PAUSADO");
                }

                string puerta;
                if (miMicro.PuertaAbierta)
                {
                    puerta = "ABIERTA";
                }
                else {
                    puerta = "CERRADA";
                }

                Console.Write(" PUERTA: " + puerta);
                Console.WriteLine(" | POTENCIA: " + miMicro.Potencia);
                Console.WriteLine("==================================================");

                Console.WriteLine("1. [Abrir / Cerrar Puerta]");
                Console.WriteLine("2. [+30 Seg (Boton Rápido)]");
                Console.WriteLine("3. [Ingresar Tiempo Manual]");
                Console.WriteLine("4. [Configurar Potencia]");
                Console.WriteLine("5. [START / INICIAR]");
                Console.WriteLine("6. [STOP / DETENER]");
                Console.WriteLine("7. Salir del simulador");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Elija una opcion: ");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        miMicro.AbrirCerrarPuerta();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        miMicro.AgregarTiempo();
                        Console.WriteLine("Agregados 30 segundos.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Ingrese los segundos a añadir: ");
                        int segs = Convert.ToInt32(Console.ReadLine());
                        miMicro.AgregarTiempo(segs); 
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Defina nivel de potencia (1-10): ");
                        int nuevaPotencia = Convert.ToInt32(Console.ReadLine());
                        miMicro.Potencia = nuevaPotencia;
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        miMicro.Iniciar();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        miMicro.Detener();
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