using System;

namespace ToyFactory
{
    internal class AutoControl : Juguete
    {
        public double Frecuencia { get; set; }

        public override string ProbarJuguete()
        {
            return $"[Auto a Control Remoto] Serie {NumeroSerie}: funcionando en frecuencia {Frecuencia} GHz.";
        }
    }
}