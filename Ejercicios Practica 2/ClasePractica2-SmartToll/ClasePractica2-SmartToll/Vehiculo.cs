using System;

namespace SmartToll
{
    internal class Vehiculo
    {
        private string _patente;
        private decimal _saldo;

        public string Patente
        {
            get { return _patente; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _patente = value;
                }
            }
        }

        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
            }
        }

        public virtual string PagarPeaje(decimal tarifa)
        {
            return "Procesando peaje...";
        }
    }
}