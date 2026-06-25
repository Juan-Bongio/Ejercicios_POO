using System;

namespace PowerGrid
{
    internal class BateriaLitio : Bateria
    {
        private bool _modoAhorro;

        public override string ConsumirEnergia(int puntos)
        {
            int consumo = puntos;

            if (_modoAhorro)
            {
                consumo = puntos / 2;
                _modoAhorro = false;
            }

            if (consumo > PorcentajeCarga)
            {
                consumo = PorcentajeCarga;
            }

            PorcentajeCarga -= consumo;

            string mensaje = $"[Batería Litio] Consumió {consumo}% de energía. Carga restante: {PorcentajeCarga}%.";

            if (PorcentajeCarga == 0)
            {
                _modoAhorro = true;
                mensaje += " Modo de ahorro activado.";
            }

            return mensaje;
        }
    }
}