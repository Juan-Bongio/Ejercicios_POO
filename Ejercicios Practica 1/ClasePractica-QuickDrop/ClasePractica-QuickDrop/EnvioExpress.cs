using System;

namespace QuickDrop
{
    internal class EnvioExpress : Envio
    {
        public int TiempoLimiteHoras { get; set; }

        public override string ProcesarEntrega()
        {
            return $"[Envío Express] Entrega hacia {Direccion} con límite de {TiempoLimiteHoras} horas.";
        }
    }
}