using System;

namespace NetFetch
{
    internal class StreamingVideo : Descarga
    {
        private int _bufferMinimo;

        public int BufferMinimo
        {
            get { return _bufferMinimo; }
            set
            {
                if (value > 0)
                {
                    _bufferMinimo = value;
                }
            }
        }

        public override string ActualizarProgreso(int megasDescargados)
        {
            int aumento = (megasDescargados * 100) / TamanoMegas;

            if (Progreso + aumento > 100)
            {
                Progreso = 100;
            }
            else
            {
                Progreso += aumento;
            }

            if (Progreso < BufferMinimo)
            {
                return "Cargando... Video pausado";
            }

            return $"Streaming listo. Progreso: {Progreso}%";
        }
    }
}