namespace Triangulo_Prohibido
{
    public class Rectangulo
    {
        private double ancho;
        private double alto;

        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        public double Alto
        {
            get { return alto; }
            set { alto = value; }
        }

        public Rectangulo(double ancho, double alto)
        {
            if (ancho >= 0 && alto >= 0)
            {
                this.ancho = ancho;
                this.alto = alto;
            }
            else
            {
                Console.WriteLine("No se permiten valores negativos");
            }
        }

        public double Area()
        {
            return ancho * alto;
        }

        public double Perimetro()
        {
            return (ancho + alto) * 2;
        }
    }
}