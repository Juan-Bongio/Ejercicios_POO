using System;

namespace AutoDrive
{
    internal class Camioneta : Vehiculo
    {
        public bool Traccion4x4 { get; set; }

        public override string Arrancar()
        {
            return $"[Camioneta] {Marca} arranca con tracción 4x4: {Traccion4x4}.";
        }
    }
}