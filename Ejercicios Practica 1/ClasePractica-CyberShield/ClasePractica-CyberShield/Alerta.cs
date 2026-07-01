using System;

namespace CyberShield
{
    internal class Alerta
    {
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _codigo = value;
                }
            }
        }

        public virtual string DispararProtocolo()
        {
            return $"Protocolo ejecutado para la alerta {Codigo}.";
        }
    }
}