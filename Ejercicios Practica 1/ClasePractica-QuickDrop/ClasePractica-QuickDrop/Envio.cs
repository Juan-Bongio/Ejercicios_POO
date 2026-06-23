using System;

namespace QuickDrop
{
    internal class Envio
    {
        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _direccion = value;
                }
            }
        }

        public virtual string ProcesarEntrega()
        {
            return $"Procesando entrega hacia {Direccion}.";
        }
    }
}