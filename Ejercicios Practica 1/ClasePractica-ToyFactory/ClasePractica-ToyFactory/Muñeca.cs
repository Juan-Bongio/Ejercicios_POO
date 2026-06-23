using System;

namespace ToyFactory
{
    internal class Muneca : Juguete
    {
        public string MaterialCabello { get; set; }

        public override string ProbarJuguete()
        {
            return $"[Muñeca] Serie {NumeroSerie}: cabello fabricado con material {MaterialCabello}.";
        }
    }
}