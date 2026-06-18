using System;
using System.Numerics;

namespace SmartTv
{
    public class Smart
    {
        private string _marca;
        private int _pulgadas;
        private bool _encendido;
        private int _canalActual;
        private int _volumen;
        private bool _esPremium;

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Error: La marca no puede estar vacía.");
                    return;
                }
                _marca = value;
            }
        }

        public bool Encendido
        {
            get { return _encendido; }
            set { _encendido = value; }
        }

        public int CanalActual
        {
            get { return _canalActual; }
            set { _canalActual = value; }
        }

        public int Pulgadas
        {
            get { return _pulgadas; }
            set { _pulgadas = value; }
        }

        public int Volumen
        {
            get
            {
                return _volumen;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: No existe volumen negativo");
                    return;
                }

                _volumen = value;
            }
        }

        public bool Premium
        {
            get { return _esPremium; }
            set { _esPremium = value; }
        }

        public string CODIGO_CONFIG
        {
            get
            {
                if (_marca == null || _marca == "")
                {
                    return "Ingrese una marca";
                }

                string marca = _marca.ToUpper();

                string premium;
                if (_esPremium)
                {
                    premium = "PREM";
                }
                else
                {
                    premium = "STD";
                }

                return marca + "-"+ _pulgadas + "-" + premium;
            }
        }

        public Smart(string marca, int pulgadas, bool premium)
        {
            _marca = marca;
            _pulgadas = pulgadas;
            _encendido = false;
            _esPremium = premium;
            _canalActual = 0;
            _volumen = 0;
        }

        public void Power()
        {
            _encendido = !_encendido;

            if (_encendido == false)
            {
                _canalActual = 0;
                _volumen = 0;
            }
        }

        public void CambiarCanal(int canal)
        {
            if (_encendido == false)
            {
                Console.WriteLine("Advertencia: No se puede cambiar el canal porque la TV está apagada.");
                return;
            }

            int canalMaximo;

            if (_esPremium)
            {
                canalMaximo = 500;
            }
            else
            {
                canalMaximo = 100;
            }

            if (canal <= 0)
            {
                Console.WriteLine("El canal no existe.");
            }
            else if (canal > canalMaximo)
            {
                Console.WriteLine("Ese canal supera el máximo permitido (" + canalMaximo + ").");
            }
            else
            {
                _canalActual = canal;
            }
        }

        public void SubirCanal()
        {
            if (_encendido)
            {
                int canalMaximo;

                if (_esPremium)
                {
                    canalMaximo = 500;
                }
                else
                {
                    canalMaximo = 100;
                }

                if (_canalActual == canalMaximo)
                {
                    _canalActual = 1;
                }
                else
                {
                    _canalActual++;
                }

                Console.WriteLine("Cambiando de Canal...");
            }
            else
            {
                Console.WriteLine("Advertencia: No se puede cambiar el canal porque la TV está apagada.");
            }
        }

        public void BajarCanal()
        {
            if (_encendido)
            {
                int canalMaximo;

                if (_esPremium)
                {
                    canalMaximo = 500;
                }
                else
                {
                    canalMaximo = 100;
                }

                if (_canalActual == 1)
                {
                    _canalActual = canalMaximo;
                }
                else
                {
                    _canalActual--;
                }

                Console.WriteLine("Cambiando de Canal...");
            }
            else
            {
                Console.WriteLine("Advertencia: No se puede cambiar el canal porque la TV está apagada.");
            }
        }

        public void RegularVolumen(bool subir)
        {
            if (_encendido == false)
            {
                Console.WriteLine("Advertencia: La TV está apagada.");
                return;
            }

            if (subir)
            {
                if (_volumen < 100)
                {
                    _volumen = _volumen + 2;

                    Console.WriteLine("Aumentando el volumen...");
                }
                else
                {
                    Console.WriteLine("Volumen Máximo");
                }
            }
            else
            {
                if (_volumen > 0)
                {
                    _volumen = _volumen - 2;

                    if (_volumen == 0)
                    {
                        Console.WriteLine("Volumen: MUTE");
                    }
                    else
                    {
                        Console.WriteLine("Disminuyendo el volumen...");
                    }
                }
                else
                {
                    Console.WriteLine("Volumen: MUTE");
                }
            }
        }
    }
}