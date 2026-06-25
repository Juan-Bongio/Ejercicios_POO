using System;

namespace NetFetch
{
    internal class Descarga
    {
        private int _tamanoMegas;
        private int _progreso;

        public int TamanoMegas
        {
            get { return _tamanoMegas; }
            set
            {
                if (value > 0)
                {
                    _tamanoMegas = value;
                }
            }
        }

        public int Progreso
        {
            get { return _progreso; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _progreso = value;
                }
            }
        }

        public virtual string ActualizarProgreso(int megasDescargados)
        {
            return $"Descarga al {Progreso}%";
        }
    }
}