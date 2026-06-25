using System;

namespace NominaCorp
{
    internal class Empleado
    {
        private string _idEmpleado;

        public string IdEmpleado
        {
            get { return _idEmpleado; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _idEmpleado = value;
                }
            }
        }

        public virtual string Trabajar()
        {
            return $"El empleado {IdEmpleado} está trabajando.";
        }
    }
}