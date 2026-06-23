using System;

namespace AutoDrive
{
    internal class Vehiculo
    {
        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _marca = value;
                }
            }
        }

        public virtual string Arrancar()
        {
            return $"{Marca} ha arrancado.";
        }
    }
}