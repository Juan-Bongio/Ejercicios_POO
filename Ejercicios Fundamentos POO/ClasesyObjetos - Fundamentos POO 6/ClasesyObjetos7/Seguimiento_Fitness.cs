namespace Seguimiento_Fitness
{
    public class CalculadoraPasos
    {
        private string nombreUsuario;
        private int metaDiaria;
        private int totalPasos;

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public int MetaDiaria
        {
            get { return metaDiaria; }
            set { metaDiaria = value; }
        }

        public CalculadoraPasos(string nombreUsuario, int metaDiaria)
        {
            this.nombreUsuario = nombreUsuario;
            this.metaDiaria = metaDiaria;
            totalPasos = 0;
        }

        public void RegistrarPasos(int pasos)
        {
            totalPasos += pasos;

            Console.WriteLine($"{nombreUsuario} registro {pasos} pasos");
            Console.WriteLine($"Total acumulado: {totalPasos}");
        }

        public bool ObjetivoCumplido()
        {
            return totalPasos >= metaDiaria;
        }
    }
}