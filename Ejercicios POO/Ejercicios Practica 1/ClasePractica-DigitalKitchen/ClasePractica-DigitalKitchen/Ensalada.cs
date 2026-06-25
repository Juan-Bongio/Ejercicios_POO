using System;

namespace DigitalKitchen
{
    internal class Ensalada : Plato
    {
        public string TipoAderezo { get; set; }

        public override string Preparar()
        {
            return $"[Ensalada] Preparando {NombrePlato} con aderezo {TipoAderezo}.";
        }
    }
}