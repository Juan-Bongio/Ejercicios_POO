using System;

namespace Invernadero_Inteligente
{
    public class Invernadero
    {
        private string _nombreSector;
        private int _temperaturaActual;
        private int _humedadSuelo;
        private bool _sistemaRiegoActivo;
        private bool _calefaccionActiva;
        private string _tipoCultivo;

        public string NombreSector
        {
            get { return _nombreSector; }
            set { _nombreSector = value; }
        }

        public int TemperaturaActual
        {
            get { return _temperaturaActual; }
        }

        public int HumedadSuelo
        {
            get { return _humedadSuelo; }
        }

        public bool SistemaRiegoActivo
        {
            get { return _sistemaRiegoActivo; }
        }

        public bool CalefaccionActiva
        {
            get { return _calefaccionActiva; }
        }

        public string TipoCultivo
        {
            get { return _tipoCultivo; }
            set
            {
                string valorAlta = value.ToUpper();
                if (valorAlta == "TROPICAL" || valorAlta == "DESERTICO")
                {
                    _tipoCultivo = valorAlta;
                }
                else
                {
                    _tipoCultivo = "TROPICAL";
                }
            }
        }

        public string REPORTE_ESTADO
        {
            get
            {
                string sector = _nombreSector.ToUpper();
                string alerta = "PARAMETROS OPTIMOS";

                if (_tipoCultivo == "TROPICAL")
                {
                    if (_humedadSuelo <= 60 && (_temperaturaActual < 20 || _temperaturaActual > 28))
                    {
                        alerta = "ALERTA: BAJA HUMEDAD Y TEMPERATURA FUERA DE RANGO";
                    }
                    else if (_humedadSuelo <= 60)
                    {
                        alerta = "ALERTA: BAJA HUMEDAD";
                    }
                    else if (_temperaturaActual < 20 || _temperaturaActual > 28)
                    {
                        alerta = "ALERTA: TEMPERATURA FUERA DE RANGO";
                    }
                }
                else if (_tipoCultivo == "DESERTICO")
                {
                    if (_humedadSuelo >= 20 && (_temperaturaActual < 25 || _temperaturaActual > 35))
                    {
                        alerta = "ALERTA: ALTA HUMEDAD Y TEMPERATURA FUERA DE RANGO";
                    }
                    else if (_humedadSuelo >= 20)
                    {
                        alerta = "ALERTA: EXCESO DE HUMEDAD";
                    }
                    else if (_temperaturaActual < 25 || _temperaturaActual > 35)
                    {
                        alerta = "ALERTA: TEMPERATURA FUERA DE RANGO";
                    }
                }

                return "SECTOR: " + sector + " - CULTIVO: " + _tipoCultivo + " - " + alerta;
            }
        }

        public Invernadero(string nombreSector, string tipoCultivo)
        {
            _nombreSector = nombreSector;

            string cultivo = tipoCultivo.ToUpper();
            if (cultivo == "TROPICAL" || cultivo == "DESERTICO")
            {
                _tipoCultivo = cultivo;
            }
            else
            {
                _tipoCultivo = "TROPICAL";
            }

            _temperaturaActual = 24;
            _humedadSuelo = 50;
            _sistemaRiegoActivo = false;
            _calefaccionActiva = false;
        }

        public void SimularClima()
        {
            _humedadSuelo = _humedadSuelo - 5;
            if (_humedadSuelo < 0)
            {
                _humedadSuelo = 0;
            }

            _temperaturaActual = _temperaturaActual + 1;
        }

        public void SimularClima(int humedad, int temperatura)
        {
            if (humedad < 0)
            {
                humedad = 0;
            }

            if (humedad > 100)
            {
                humedad = 100;
            }

            _humedadSuelo = humedad;
            _temperaturaActual = temperatura;
        }

        public void ControlAutomatico()
        {
            if (_tipoCultivo == "TROPICAL")
            {
                if (_humedadSuelo <= 60)
                {
                    if (_humedadSuelo < 100)
                    {
                        _sistemaRiegoActivo = true;
                    }
                }
                else
                {
                    _sistemaRiegoActivo = false;
                }

                if (_temperaturaActual < 20)
                {
                    if (_temperaturaActual < 45)
                    {
                        _calefaccionActiva = true;
                    }
                }
                else
                {
                    _calefaccionActiva = false;
                }
            }
            else if (_tipoCultivo == "DESERTICO")
            {
                if (_humedadSuelo >= 20)
                {
                    _sistemaRiegoActivo = false;
                }

                if (_temperaturaActual < 25)
                {
                    if (_temperaturaActual < 45)
                    {
                        _calefaccionActiva = true;
                    }
                }
                else
                {
                    _calefaccionActiva = false;
                }
            }
        }
    }
}