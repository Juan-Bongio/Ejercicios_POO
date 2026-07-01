using System;

namespace CitadelDefense
{
    internal class Torreta
    {
        private string _ubicacion;

        public string Ubicacion
        {
            get { return _ubicacion; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _ubicacion = value;
                }
            }
        }

        public virtual string Disparar()
        {
            return $"La torreta ubicada en {Ubicacion} ha disparado.";
        }
    }
}