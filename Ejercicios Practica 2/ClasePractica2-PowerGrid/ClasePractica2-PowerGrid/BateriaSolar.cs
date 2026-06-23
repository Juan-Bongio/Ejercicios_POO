using System;

namespace PowerGrid
{
    internal class BateriaSolar : Bateria
    {
        private int _eficienciaPanel;

        public int EficienciaPanel
        {
            get { return _eficienciaPanel; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _eficienciaPanel = value;
                }
            }
        }

        public override string ConsumirEnergia(int puntos)
        {
            int recuperacion = puntos * EficienciaPanel / 100;
            int gastoNeto = puntos - recuperacion;

            if (gastoNeto > PorcentajeCarga)
            {
                gastoNeto = PorcentajeCarga;
            }

            PorcentajeCarga -= gastoNeto;

            return $"[Batería Solar] Consumo: {puntos}%. Recuperación: {recuperacion}%. Gasto neto: {gastoNeto}%. Carga restante: {PorcentajeCarga}%.";
        }
    }
}