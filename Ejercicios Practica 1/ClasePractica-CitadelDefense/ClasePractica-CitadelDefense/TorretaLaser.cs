using System;

namespace CitadelDefense
{
    internal class TorretaLaser : Torreta
    {
        public int CargaBateria { get; set; }

        public override string Disparar()
        {
            return $"[Torreta Láser] Disparo efectuado desde {Ubicacion}. Batería restante: {CargaBateria}%.";
        }
    }
}