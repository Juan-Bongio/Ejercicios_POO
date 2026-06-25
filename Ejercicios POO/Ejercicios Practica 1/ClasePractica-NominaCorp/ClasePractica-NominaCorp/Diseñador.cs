using System;

namespace NominaCorp
{
    internal class Disenador : Empleado
    {
        public string HerramientaFavorita { get; set; }

        public override string Trabajar()
        {
            return $"[Diseñador] {IdEmpleado} crea diseños con {HerramientaFavorita}.";
        }
    }
}