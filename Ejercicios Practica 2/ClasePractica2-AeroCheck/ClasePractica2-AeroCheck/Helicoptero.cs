using System;

namespace AeroCheck
{
    internal class Helicoptero : Aeronave
    {
        private bool _equipoRescate;

        public bool EquipoRescate
        {
            get { return _equipoRescate; }
            set
            {
                _equipoRescate = value;
            }
        }

        public override string RevisarEstado()
        {
            string mensaje = $"[Helicóptero] {Matricula}: Operativo.";

            if (EquipoRescate)
            {
                mensaje += " Equipado para rescate.";
            }

            return mensaje;
        }
    }
}