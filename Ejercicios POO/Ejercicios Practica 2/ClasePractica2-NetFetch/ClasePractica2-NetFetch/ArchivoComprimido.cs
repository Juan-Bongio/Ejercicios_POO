using System;

namespace NetFetch
{
    internal class ArchivoComprimido : Descarga
    {
        private bool _esSeguro;

        public bool EsSeguro
        {
            get { return _esSeguro; }
            set
            {
                _esSeguro = value;
            }
        }

        public override string ActualizarProgreso(int megasDescargados)
        {
            if (!EsSeguro)
            {
                Progreso = 0;

                return "Descarga abortada por amenaza detectada";
            }

            int aumento = (megasDescargados * 100) / TamanoMegas;

            if (Progreso + aumento > 100)
            {
                Progreso = 100;
            }
            else
            {
                Progreso += aumento;
            }

            return $"Archivo descargándose. Progreso: {Progreso}%";
        }
    }
}