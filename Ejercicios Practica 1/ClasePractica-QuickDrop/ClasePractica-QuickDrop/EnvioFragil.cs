using System;

namespace QuickDrop
{
    internal class EnvioFragil : Envio
    {
        public string MaterialProteccion { get; set; }

        public override string ProcesarEntrega()
        {
            return $"[Envío Frágil] Entrega hacia {Direccion} protegida con {MaterialProteccion}.";
        }
    }
}