namespace Reloj_Digital
{
    public class Reloj
    {
        private int hora;
        private int minutos;
        private int segundos;

        public int Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }

        public int Segundos
        {
            get { return segundos; }
            set { segundos = value; }
        }

        public Reloj(int hora, int minutos, int segundos)
        {
            if (hora >= 0 && hora <= 23)
            {
                this.hora = hora;
            }
            else
            {
                Console.WriteLine("Error: ingrese una hora valida (0-23)");
            }

            if (minutos >= 0 && minutos <= 59)
            {
                this.minutos = minutos;
            }
            else
            {
                Console.WriteLine("Error: ingrese un minuto valido (0-59)");
            }

            if (segundos >= 0 && segundos <= 59)
            {
                this.segundos = segundos;
            }
            else
            {
                Console.WriteLine("Error: ingrese un segundo valido (0-59)");
            }
        }

        public void MostrarHora()
        {
            Console.WriteLine($"{hora}:{minutos}:{segundos}");
        }
    }
}