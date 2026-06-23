using System;

namespace BioTech
{
    internal class Helecho : Planta
    {
        private int _humedadRequerida;

        public int HumedadRequerida
        {
            get { return _humedadRequerida; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _humedadRequerida = value;
                }
            }
        }

        public override string AplicarClima(string clima)
        {
            if (clima == "Seco")
            {
                Salud -= 20;

                if (Salud < 0)
                {
                    Salud = 0;
                }

                return $"Helecho requiere riego urgente. Salud: {Salud}";
            }

            return $"Helecho estable. Salud: {Salud}";
        }
    }
}