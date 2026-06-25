using System;
using System.Collections.Generic;

namespace FactoryAlert
{
    internal class SensorPresion : Sensor
    {
        private List<double> _historialLecturas = new List<double>();

        public List<double> HistorialLecturas
        {
            get { return _historialLecturas; }
            set
            {
                if (value != null)
                {
                    _historialLecturas = value;
                }
            }
        }

        public override string EvaluarLectura(double valor)
        {
            HistorialLecturas.Add(valor);

            if (HistorialLecturas.Count >= 3)
            {
                int ultimo = HistorialLecturas.Count - 1;

                if (HistorialLecturas[ultimo - 2] <
                    HistorialLecturas[ultimo - 1] &&
                    HistorialLecturas[ultimo - 1] <
                    HistorialLecturas[ultimo])
                {
                    return $"Sensor {Id}: Tendencia inestable detectada.";
                }
            }

            return $"Sensor {Id}: presión registrada ({valor}) - Estado: {Estado}";
        }
    }
}