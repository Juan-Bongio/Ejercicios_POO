using System;

namespace AeroCheck
{
    internal class Aeronave
    {
        private string _matricula;
        private int _horasVuelo;

        public string Matricula
        {
            get { return _matricula; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _matricula = value;
                }
            }
        }

        public int HorasVuelo
        {
            get { return _horasVuelo; }
            set
            {
                if (value >= 0)
                {
                    _horasVuelo = value;
                }
            }
        }

        public virtual string RevisarEstado()
        {
            return $"Aeronave {Matricula} revisada.";
        }
    }
}