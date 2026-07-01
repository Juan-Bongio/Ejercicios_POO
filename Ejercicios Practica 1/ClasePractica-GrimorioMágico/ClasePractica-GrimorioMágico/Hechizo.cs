using System;

namespace GrimorioMagico
{
    internal class Hechizo
    {
        private string _encantamiento;

        public string Encantamiento
        {
            get { return _encantamiento; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _encantamiento = value;
                }
            }
        }

        public virtual string Lanzar()
        {
            return $"Se ha lanzado el hechizo {Encantamiento}.";
        }
    }
}