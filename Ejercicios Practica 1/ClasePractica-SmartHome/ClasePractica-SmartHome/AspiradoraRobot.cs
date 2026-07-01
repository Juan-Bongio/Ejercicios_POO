using System;

namespace SmartHome
{
    internal class AspiradoraRobot : Dispositivo
    {
        public int CapacidadTanque { get; set; }

        public override string EjecutarFuncion()
        {
            return $"[Aspiradora Robot] Limpieza iniciada en {Habitacion}. Capacidad del tanque: {CapacidadTanque} ml.";
        }
    }
}