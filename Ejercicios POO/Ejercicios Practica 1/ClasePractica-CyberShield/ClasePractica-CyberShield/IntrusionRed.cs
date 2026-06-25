using System;

namespace CyberShield
{
    internal class IntrusionRed : Alerta
    {
        public string IpOrigen { get; set; }

        public override string DispararProtocolo()
        {
            return $"[Intrusión de Red] Bloqueando conexiones provenientes de la IP {IpOrigen}.";
        }
    }
}