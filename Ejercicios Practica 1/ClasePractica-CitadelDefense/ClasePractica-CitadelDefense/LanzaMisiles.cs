using System;

namespace CitadelDefense
{
    internal class Lanzamisiles : Torreta
    {
        public int MunicionRestante { get; set; }

        public override string Disparar()
        {
            return $"[Lanzamisiles] Lanzamiento realizado desde {Ubicacion}. Misiles restantes: {MunicionRestante}.";
        }
    }
}