using Bateria_Smartphone;

namespace Bateria_Smartphone
{
    class Program
    {
        static void Main(string[] args)
        {
            Bateria miBateria = new Bateria();

            int op = 0;
            while (op != 6)
            {
                Console.Clear();

                Console.WriteLine("==================================================");
                Console.WriteLine(" " + miBateria.ESTADO_TEXTO);
                Console.WriteLine("==================================================");

                Console.Write(" MODO AHORRO: ");
                if (miBateria.ModoAhorroEnergia)
                {
                    Console.Write("[ACTIVO]");
                }
                else
                {
                    Console.Write("[INACTIVO]");
                }

                Console.WriteLine(" | SALUD DE BATERIA: " + miBateria.SaludBateria + "%");

                Console.Write(" CABLE CONECTADO: ");
                if (miBateria.ConectadoCargador)
                {
                    Console.WriteLine("[SI]");
                }
                else
                {
                    Console.WriteLine("[NO]");
                }
                Console.WriteLine("==================================================");

                Console.WriteLine("1. [Conectar / Desconectar Cargador]");
                Console.WriteLine("2. [Uso en Reposo] (-1% de bateria)");
                Console.WriteLine("3. [Abrir App Pesada / Juego] (Consumo personalizado)");
                Console.WriteLine("4. [Simular Tiempo Cargando] (+5% de bateria)");
                Console.WriteLine("5. [Ver estado del hardware interno]");
                Console.WriteLine("6. Salir del simulador de energia");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Seleccione una opcion: ");

                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        miBateria.AlternarCargador();
                        break;

                    case 2:
                        Console.Clear();
                        if (miBateria.ConectadoCargador)
                        {
                            Console.WriteLine("El telefono esta conectado. No consume bateria.");
                        }
                        else
                        {
                            miBateria.ConsumirEnergia();
                            Console.WriteLine("El telefono paso un tiempo en reposo.");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        if (miBateria.ConectadoCargador)
                        {
                            Console.WriteLine("El telefono esta conectado. No consume bateria.");
                        }
                        else
                        {
                            Console.Write("Ingrese el porcentaje que consume la app: ");
                            int cantidad = Convert.ToInt32(Console.ReadLine());
                            miBateria.ConsumirEnergia(cantidad);
                            Console.WriteLine("\nAlicacion cerrada.");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        if (!miBateria.ConectadoCargador)
                        {
                            Console.WriteLine("Error: Debe conectar el cargador primero.");
                        }
                        else
                        {
                            miBateria.CicloDeCarga();
                            Console.WriteLine("El dispositivo recibio carga de energia.");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("=== DIAGNOSTICO DE HARDWARE ===");
                        Console.WriteLine("Salud actual de las celdas: " + miBateria.SaludBateria + "%");
                        Console.WriteLine("Carga maxima real permitida: " + miBateria.SaludBateria + "%");
                        Console.WriteLine("\nPresione una tecla para volver...");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Simulacion finalizada.");
                        break;
                }
            }
        }
    }
}