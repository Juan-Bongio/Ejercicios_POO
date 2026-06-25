using System;

namespace NominaCorp
{
    internal class Programador : Empleado
    {
        public string LenguajePrincipal { get; set; }

        public override string Trabajar()
        {
            return $"[Programador] {IdEmpleado} desarrolla software utilizando {LenguajePrincipal}.";
        }
    }
}