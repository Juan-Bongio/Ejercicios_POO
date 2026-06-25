using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace OrquestaVirtual
{
    internal class Piano : Instrumento
    {
        public int NumeroTeclas { get; set; }

        public override string TocarNota()
        {
            return $"[Piano] {Modelo} ejecuta una melodía usando sus {NumeroTeclas} teclas.";
        }
    }
}