using System;

namespace PowerGrid
{
    internal class Bateria
    {
        private int _porcentajeCarga;

        public int PorcentajeCarga
        {
            get { return _porcentajeCarga; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _porcentajeCarga = value;
                }
            }
        }

        public virtual string ConsumirEnergia(int puntos)
        {
            return "Consumo registrado.";
        }
    }
}