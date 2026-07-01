using System;

namespace Bateria_Smartphone
{
    public class Bateria
    {
        private int _porcentajeCarga;
        private int _saludBateria;
        private bool _conectadoCargador;
        private bool _modoAhorroEnergia;
        private int _acumuladorCargaParaCiclo;

        public int PorcentajeCarga
        {
            get { return _porcentajeCarga; }
        }

        public int SaludBateria
        {
            get { return _saludBateria; }
        }

        public bool ConectadoCargador
        {
            get { return _conectadoCargador; }
        }

        public bool ModoAhorroEnergia
        {
            get { return _modoAhorroEnergia; }
        }

        public string ESTADO_TEXTO
        {
            get
            {
                string texto = "BATERIA: " + _porcentajeCarga + "%";
                if (_conectadoCargador)
                {
                    return "CARGANDO - " + texto;
                }
                return texto;
            }
        }

        public Bateria()
        {
            _porcentajeCarga = 50;
            _saludBateria = 100;
            _conectadoCargador = false;
            _modoAhorroEnergia = false;
            _acumuladorCargaParaCiclo = 0;
        }

        public void AlternarCargador()
        {
            _conectadoCargador = !_conectadoCargador;
        }

        public void ConsumirEnergia()
        {
            ConsumirEnergia(1);
        }

        public void ConsumirEnergia(int porcentaje)
        {
            if (_conectadoCargador)
            {
                return;
            }

            int consumoReal = porcentaje;
            if (_modoAhorroEnergia)
            {
                consumoReal = porcentaje / 2;
                if (consumoReal < 1 && porcentaje > 0)
                {
                    consumoReal = 1;
                }
            }

            _porcentajeCarga = _porcentajeCarga - consumoReal;
            if (_porcentajeCarga < 0)
            {
                _porcentajeCarga = 0;
            }

            if (_porcentajeCarga < 20)
            {
                _modoAhorroEnergia = true;
            }
        }

        public void CicloDeCarga()
        {
            if (!_conectadoCargador)
            {
                return;
            }

            if (_porcentajeCarga >= _saludBateria)
            {
                return;
            }

            _porcentajeCarga = _porcentajeCarga + 5;
            _acumuladorCargaParaCiclo = _acumuladorCargaParaCiclo + 5;

            if (_porcentajeCarga > _saludBateria)
            {
                int exceso = _porcentajeCarga - _saludBateria;
                _acumuladorCargaParaCiclo = _acumuladorCargaParaCiclo - exceso;
                _porcentajeCarga = _saludBateria;
            }

            if (_acumuladorCargaParaCiclo >= 100)
            {
                _saludBateria = _saludBateria - 1;
                _acumuladorCargaParaCiclo = _acumuladorCargaParaCiclo - 100;
                if (_saludBateria < 0)
                {
                    _saludBateria = 0;
                }
            }

            if (_porcentajeCarga > 50)
            {
                _modoAhorroEnergia = false;
            }
        }
    }
}