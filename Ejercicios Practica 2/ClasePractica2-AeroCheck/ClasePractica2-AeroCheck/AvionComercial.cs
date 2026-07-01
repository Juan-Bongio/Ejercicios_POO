using System;

namespace AeroCheck
{
    internal class AvionComercial : Aeronave
    {
        private int _cantidadPasajeros;

        public int CantidadPasajeros
        {
            get { return _cantidadPasajeros; }
            set
            {
                if (value >= 0)
                {
                    _cantidadPasajeros = value;
                }
            }
        }

        public override string RevisarEstado()
        {
            if (HorasVuelo > 1000)
            {
                return $"[Avión Comercial] {Matricula}: Requiere mantenimiento mayor.";
            }

            return $"[Avión Comercial] {Matricula}: Operativo para {CantidadPasajeros} pasajeros.";
        }
    }
}