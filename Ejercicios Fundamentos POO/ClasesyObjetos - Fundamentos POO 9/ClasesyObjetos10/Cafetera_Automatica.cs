namespace Cafetera_Automatica
{
    public class Cafetera
    {
        private int capacidadMaxima;
        private int cantidadActual;

        public int CapacidadMaxima
        {
            get { return capacidadMaxima; }
            set { capacidadMaxima = value; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
            set { cantidadActual = value; }
        }

        public Cafetera(int capacidadMaxima, int cantidadActual)
        {
            this.capacidadMaxima = capacidadMaxima;
            this.cantidadActual = cantidadActual;
        }

        public void LlenarCafetera()
        {
            cantidadActual = capacidadMaxima;

            Console.WriteLine("La cafetera fue llenada");
            Console.WriteLine($"Cantidad actual: {cantidadActual}");
        }

        public void ServirTaza(int cantidad)
        {
            if (cantidad <= cantidadActual)
            {
                cantidadActual -= cantidad;

                Console.WriteLine($"Se sirvieron {cantidad}ml");
                Console.WriteLine($"Cantidad restante: {cantidadActual}");
            }
            else
            {
                Console.WriteLine("No hay suficiente cafe");
            }
        }

        public void VaciarCafetera()
        {
            cantidadActual = 0;

            Console.WriteLine("La cafetera fue vaciada");
        }
    }
}