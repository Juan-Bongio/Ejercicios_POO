using System;

namespace SecureBank
{
    internal class Transaccion
    {
        private string _tokenSeguridad;

        public string TokenSeguridad
        {
            get { return _tokenSeguridad; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 8)
                {
                    _tokenSeguridad = value;
                }
            }
        }

        public virtual string Procesar()
        {
            return "Transacción procesada.";
        }
    }
}