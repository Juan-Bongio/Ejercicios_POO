using System;

namespace BioTech
{
    internal class Planta
    {
        private int _edadDias;
        private int _salud;

        public int EdadDias
        {
            get { return _edadDias; }
            set
            {
                if (value >= 0)
                {
                    _edadDias = value;
                }
            }
        }

        public int Salud
        {
            get { return _salud; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _salud = value;
                }
            }
        }

        public virtual string AplicarClima(string clima)
        {
            return $"Clima aplicado: {clima}";
        }
    }
}