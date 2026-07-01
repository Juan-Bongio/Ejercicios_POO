using System;

namespace MediaStream
{
    internal class Contenido
    {
        private string _titulo;
        private int _duracionMinutos;

        public string Titulo
        {
            get { return _titulo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _titulo = value;
                }
            }
        }

        public int DuracionMinutos
        {
            get { return _duracionMinutos; }
            set
            {
                if (value > 0)
                {
                    _duracionMinutos = value;
                }
            }
        }

        public virtual string Reproducir()
        {
            return $"Reproduciendo {Titulo}.";
        }
    }
}