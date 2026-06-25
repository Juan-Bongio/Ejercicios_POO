using System;

namespace GrimorioMagico
{
    internal class BolaFuego : Hechizo
    {
        public int TemperaturaC { get; set; }

        public override string Lanzar()
        {
            return $"[Bola de Fuego] {Encantamiento} genera llamas a {TemperaturaC} °C.";
        }
    }
}