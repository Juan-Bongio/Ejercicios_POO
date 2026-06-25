using System;

namespace SmartToll
{
    internal class Particular : Vehiculo
    {
        public override string PagarPeaje(decimal tarifa)
        {
            if (Saldo < tarifa)
            {
                return $"[Particular] {Patente}: Paso denegado. Saldo insuficiente.";
            }

            Saldo -= tarifa;

            return $"[Particular] {Patente}: Peaje abonado. Saldo restante: ${Saldo}.";
        }
    }
}