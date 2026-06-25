using System;

namespace DigitalKitchen
{
    internal class Plato
    {
        private string _nombrePlato;

        public string NombrePlato
        {
            get { return _nombrePlato; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nombrePlato = value;
                }
            }
        }

        public virtual string Preparar()
        {
            return $"{NombrePlato} está siendo preparado.";
        }
    }
}