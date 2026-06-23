using System;

namespace SecureBank
{
    internal class Transferencia : Transaccion
    {
        private decimal _monto;
        private string _cuentaDestino;

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

        public string CuentaDestino
        {
            get { return _cuentaDestino; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _cuentaDestino = value;
                }
            }
        }

        public override string Procesar()
        {
            if (string.IsNullOrWhiteSpace(TokenSeguridad))
            {
                return "[Transferencia] Token inválido.";
            }

            if (Monto > 500000)
            {
                return "[Transferencia] Requiere autorización presencial.";
            }

            return $"[Transferencia] ${Monto} enviados a la cuenta {CuentaDestino}.";
        }
    }
}