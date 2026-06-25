namespace Termometros
{
    public class Termometro
    {
        private double celsius;

        public double Celsius
        {
            get { return celsius; }

            set
            {
                if (value >= -273.15)
                {
                    celsius = value;
                }
                else
                {
                    Console.WriteLine("Error: no existe temperatura menor al cero absoluto.");
                }
            }
        }

        public Termometro(double celsius)
        {
            Celsius = celsius;
        }

        public double ObtenerFahrenheit()
        {
            return (celsius * 9/5) + 32;
        }

        public double ObtenerKelvin()
        {
            return celsius + 273.15;
        }
    }
}