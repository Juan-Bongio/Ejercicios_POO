using System;

namespace SecureBank
{
    internal class PagoServicio : Transaccion
    {
        private decimal _monto;
        private int _diasVencido;

        public decimal Monto
        {
            get { return _monto; }
            set
            {
                if (value > 0)
                {
                    _monto = value;
                }
            }
        }

        public int DiasVencido
        {
            get { return _diasVencido; }
            set
            {
                if (value >= 0)
                {
                    _diasVencido = value;
                }
            }
        }

        public override string Procesar()
        {
            if (string.IsNullOrWhiteSpace(TokenSeguridad))
            {
                return "[Pago de Servicio] Token inválido.";
            }

            decimal total = Monto;

            if (DiasVencido > 0)
            {
                total = Monto * Convert.ToDecimal(Math.Pow(1.02, DiasVencido));
            }

            return $"[Pago de Servicio] Importe final: ${Math.Round(total, 2)}.";
        }
    }
}