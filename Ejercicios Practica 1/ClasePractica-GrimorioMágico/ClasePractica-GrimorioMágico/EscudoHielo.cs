using System;

namespace GrimorioMagico
{
    internal class EscudoHielo : Hechizo
    {
        public int GrosorCapas { get; set; }

        public override string Lanzar()
        {
            return $"[Escudo de Hielo] {Encantamiento} crea una barrera de {GrosorCapas} capas de hielo.";
        }
    }
}