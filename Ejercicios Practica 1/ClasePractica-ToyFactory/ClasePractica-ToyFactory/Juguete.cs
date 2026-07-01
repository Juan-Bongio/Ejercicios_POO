using System;

namespace ToyFactory
{
    internal class Juguete
    {
        private string _numeroSerie;

        public string NumeroSerie
        {
            get { return _numeroSerie; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _numeroSerie = value;
                }
            }
        }

        public virtual string ProbarJuguete()
        {
            return $"Probando juguete con serie {NumeroSerie}.";
        }
    }
}