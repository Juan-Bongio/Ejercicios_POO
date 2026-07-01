using Salon_Eventos;

namespace Salon_Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONFIGURACIÓN INICIAL DEL EVENTO ===");

            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nSeleccione el Tipo de Reserva:");
            Console.WriteLine("1: Solo Evento");
            Console.WriteLine("2: Con Catering");
            Console.WriteLine("3: Full (Catering + Animación)");
            Console.Write("Opción (1-3): ");
            int tipoReserva = Convert.ToInt32(Console.ReadLine());

            Salon_Eventos miEvento = new Salon_Eventos(nombre, tipoReserva);

            Console.Write("\nIngrese la cantidad de invitados: ");
            miEvento.CantidadInvitados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la cantidad de horas del evento: ");
            miEvento.CantidadHoras = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Requiere mozos? (S/N): ");
            string requiereMozos = Console.ReadLine().ToUpper();
            miEvento.IncluyeMozos = (requiereMozos == "S");

            Console.Write("Ingrese el día de la semana (V: Viernes, S: Sábado, D: Domingo): ");
            miEvento.Dia = Convert.ToString(Console.ReadLine());

            if (tipoReserva == 2 || tipoReserva == 3)
            {
                Console.Write("\nSeleccione el tipo de menú (B: Básico, P: Premium): ");
                miEvento.TipoMenu = Convert.ToString(Console.ReadLine());
            }

            if (tipoReserva == 3)
            {
                Console.Write("\nIngrese la cantidad de animaciones requeridas: ");
                miEvento.CantidadAnimaciones = Convert.ToInt32(Console.ReadLine());
            }

            int op = 0;
            while (op != 2)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("          SISTEMA DE GESTIÓN DE RESERVAS          ");
                Console.WriteLine("==================================================");
                Console.WriteLine(" CLIENTE: " + miEvento.NombreCliente);
                Console.WriteLine(" TIPO RESERVA: " + miEvento.TipoReserva);
                Console.WriteLine(" DÍA DEL EVENTO: " + miEvento.Dia);
                Console.WriteLine(" INVITADOS: " + miEvento.CantidadInvitados);
                Console.WriteLine(" HORAS: " + miEvento.CantidadHoras);
                if (tipoReserva > 1) Console.WriteLine(" MENÚ SELECCIONADO: " + miEvento.TipoMenu);
                if (tipoReserva == 3) Console.WriteLine(" ANIMACIONES: " + miEvento.CantidadAnimaciones);
                Console.WriteLine("==================================================");

                Console.WriteLine(" RESUMEN ACTUAL:");
                Console.WriteLine(" " + miEvento.ObtenerResumen());
                Console.WriteLine("==================================================");

                Console.WriteLine("1. Recalcular / Mostrar Presupuesto Completo");
                Console.WriteLine("2. Salir del sistema");
                Console.Write("Seleccione una opción: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("==================================================");
                        Console.WriteLine("               DETALLE DE COSTOS                  ");
                        Console.WriteLine("==================================================");
                        Console.WriteLine($"El costo total final calculado es: $ {miEvento.CalcularValor()}");
                        Console.WriteLine("==================================================");
                        Console.WriteLine("\nPresione una tecla para volver al menú...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Sistema finalizado. ¡Que tengas un excelente evento!");
                        break;
                }
            }
        }
    }
}