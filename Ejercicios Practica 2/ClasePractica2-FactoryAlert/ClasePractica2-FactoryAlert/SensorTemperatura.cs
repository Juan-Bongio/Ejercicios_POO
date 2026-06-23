using System;

namespace FactoryAlert
{
    internal class SensorTemperatura : Sensor
    {
        private double _limiteCritico;

        public double LimiteCritico
        {
            get { return _limiteCritico; }
            set
            {
                if (value > 0)
                {
                    _limiteCritico = value;
                }
            }
        }
        
        public override string EvaluarLectura(double valor)
        {
            if (valor > LimiteCritico)
            {
                Estado = "Peligro";

                return $"SENSOR {Id}: TEMPERATURA CRITICA ({valor}) - ESTADO: {Estado}".ToUpper();
            }

            return $"Sensor {Id}: temperatura normal ({valor}) - Estado: {Estado}";
        }
    }
}