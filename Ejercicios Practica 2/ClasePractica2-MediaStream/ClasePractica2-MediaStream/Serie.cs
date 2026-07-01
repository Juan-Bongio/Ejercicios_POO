using System;

namespace MediaStream
{
    internal class Serie : Contenido
    {
        private int _episodios;

        public int Episodios
        {
            get { return _episodios; }
            set
            {
                if (value > 0)
                {
                    _episodios = value;
                }
            }
        }

        public override string Reproducir()
        {
            return $"[Serie] {Titulo} - {Episodios} episodios disponibles.";
        }
    }
}