using System;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace OrquestaVirtual
{
    internal class Guitarra : Instrumento
    {
        public int NumeroCuerdas { get; set; }

        public override string TocarNota()
        {
            return $"[Guitarra] {Modelo} toca un acorde con sus {NumeroCuerdas} cuerdas.";
        }
    }
}