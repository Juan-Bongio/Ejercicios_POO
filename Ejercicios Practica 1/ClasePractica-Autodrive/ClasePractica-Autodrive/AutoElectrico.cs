using System;

namespace AutoDrive
{
    internal class AutoElectrico : Vehiculo
    {
        public int Autonomia { get; set; }

        public override string Arrancar()
        {
            return $"[Auto Eléctrico] {Marca} inicia en modo silencioso. Autonomía: {Autonomia} km.";
        }
    }
}
