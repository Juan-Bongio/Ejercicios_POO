using System;

namespace SmartHome
{
    internal class Dispositivo
    {
        private string _habitacion;

        public string Habitacion
        {
            get { return _habitacion; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _habitacion = value;
                }
            }
        }

        public virtual string EjecutarFuncion()
        {
            return $"Dispositivo funcionando en {Habitacion}.";
        }
    }
}