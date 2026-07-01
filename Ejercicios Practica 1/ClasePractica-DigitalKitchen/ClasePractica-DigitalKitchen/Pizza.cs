using System;

namespace DigitalKitchen
{
    internal class Pizza : Plato
    {
        public string TipoMasa { get; set; }

        public override string Preparar()
        {
            return $"[Pizza] Preparando {NombrePlato} con masa tipo {TipoMasa}.";
        }
    }
}