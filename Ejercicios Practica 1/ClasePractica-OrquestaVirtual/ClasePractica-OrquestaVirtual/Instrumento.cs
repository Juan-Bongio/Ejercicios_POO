using System;

namespace OrquestaVirtual
{
    internal class Instrumento
    {
        private string _modelo;

        public string Modelo
        {
            get { return _modelo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _modelo = value;
                }
            }
        }

        public virtual string TocarNota()
        {
            return $"{Modelo} emite una nota musical.";
        }
    }
}