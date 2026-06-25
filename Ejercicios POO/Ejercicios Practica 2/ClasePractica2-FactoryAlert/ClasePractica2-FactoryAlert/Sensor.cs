using System;

namespace FactoryAlert
{
    internal class Sensor
    {
        private string _id;
        private string _estado = "Ok";

        public string Id
        {
            get { return _id; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _id = value;
                }
            }
        }

        public string Estado
        {
            get { return _estado; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _estado = value;
                }
            }
        }

        public virtual string EvaluarLectura(double valor)
        {
            return $"Sensor {Id}: lectura registrada ({valor}).";
        }
    }
}