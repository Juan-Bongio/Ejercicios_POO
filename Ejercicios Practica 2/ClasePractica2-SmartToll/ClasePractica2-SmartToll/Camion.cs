using System;

namespace SmartToll
{
    internal class Camion : Vehiculo
    {
        private int _ejes;

        public int Ejes
        {
            get { return _ejes; }
            set
            {
                if (value > 0)
                {
                    _ejes = value;
                }
            }
        }

        public override string PagarPeaje(decimal tarifa)
        {
            decimal tarifaFinal = tarifa * Ejes;

            if (Ejes > 4)
            {
                tarifaFinal *= 0.90m;
            }

            if (Saldo < tarifaFinal)
            {
                return $"[Camión] {Patente}: Paso denegado. Saldo insuficiente.";
            }

            Saldo -= tarifaFinal;

            if (Ejes > 4)
            {
                return $"[Camión] {Patente}: Peaje abonado con 10% de descuento. Saldo restante: ${Saldo}.";
            }

            return $"[Camión] {Patente}: Peaje abonado. Saldo restante: ${Saldo}.";
        }
    }
}