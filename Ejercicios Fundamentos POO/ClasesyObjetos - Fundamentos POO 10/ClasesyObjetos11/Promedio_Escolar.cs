namespace ClasesyObjetos2
{
    public class Estudiante
    {
        private string nombre;
        private double nota1;
        private double nota2;
        private double nota3;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        public Estudiante(string nombre, double nota1, double nota2, double nota3)
        {
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double CalcularPromedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public string EstadoFinal()
        {
            if (CalcularPromedio() >= 6)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }
}