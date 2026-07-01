using System;

namespace MediaStream
{
    internal class Pelicula : Contenido
    {
        private string _clasificacion;

        public string Clasificacion
        {
            get { return _clasificacion; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _clasificacion = value;
                }
            }
        }

        public override string Reproducir()
        {
            return $"[Película] {Titulo} ({Clasificacion}) - Duración: {DuracionMinutos} minutos.";
        }
    }
}