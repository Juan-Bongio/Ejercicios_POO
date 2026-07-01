using System;

namespace SmartHome
{
    internal class LamparaInteligente : Dispositivo
    {
        public string ColorLed { get; set; }

        public override string EjecutarFuncion()
        {
            return $"[Lámpara Inteligente] Iluminando la habitación {Habitacion} con color {ColorLed}.";
        }
    }
}