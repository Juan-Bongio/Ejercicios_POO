using System;

namespace SimuladorAutomovil
{
    public class Automovil
    {
        private string _marca;
        private bool _motorEncendido;
        private int _velocidadActual;
        private bool _cajaAutomatica;
        private bool _modoCrucero;

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

        public bool MotorEncendido
        {
            get { return _motorEncendido; }
            set { _motorEncendido = value; }
        }

        public int VelocidadActual
        {
            get { return _velocidadActual; }
            set { _velocidadActual = value; }
        }

        public bool CajaAutomatica
        {
            get { return _cajaAutomatica; }
            set { _cajaAutomatica = value; }
        }

        public bool ModoCrucero
        {
            get { return _modoCrucero; }
            set { _modoCrucero = value; }
        }

        public string IDENTIFICADOR
        {
            get
            {
                if (_marca == null || _marca == "")
                {
                    return "Ingrese una marca";
                }

                string marca = _marca.Substring(0, 3).ToUpper();

                string caja;
                if (_cajaAutomatica)
                {
                    caja = "AUTO";
                }
                else
                {
                    caja = "MAN";
                }

                return marca + "-" + caja + "-" + DateTime.Now.Year;
            }
        }

        public Automovil(string marca, bool cajaAutomatica)
        {
            _marca = marca;
            _cajaAutomatica = cajaAutomatica;
            _motorEncendido = false;
            _velocidadActual = 0;
            _modoCrucero = false;
        }

        public void EncenderApagar()
        {
            _motorEncendido = !_motorEncendido;

            if (_motorEncendido == false)
            {
                _velocidadActual = 0;
                _modoCrucero = false;
            }
        }

        public void Acelerar(int kmh)
        {
            if (_motorEncendido == false)
            {
                Console.WriteLine("Advertencia: No se puede acelerar porque el motor está apagado.");
                return;
            }

            int velocidadMaxima;
            if (_cajaAutomatica)
            {
                velocidadMaxima = 220;
            }
            else
            {
                velocidadMaxima = 180;
            }

            if (_velocidadActual + kmh > velocidadMaxima)
            {
                _velocidadActual = velocidadMaxima;
                Console.WriteLine("Llegaste al límite de velocidad máxima (" + velocidadMaxima + " km/h).");
            }
            else
            {
                _velocidadActual = _velocidadActual + kmh;
            }
        }

        public void Acelerar()
        {
            if (_motorEncendido)
            {
                Acelerar(10);
                Console.WriteLine("Acelerando 10km/h...");
            }
            else {
                Console.WriteLine("Advertencia: No se puede acelerar porque el motor está apagado.");
                return;
            }
        }

        public void Frenar(int kmh)
        {
            if (_motorEncendido == false)
            {
                Console.WriteLine("Advertencia: El coche ya está detenido y con el motor apagado.");
                return;
            }

            _modoCrucero = false;

            if (_velocidadActual - kmh < 0)
            {
                _velocidadActual = 0;
            }
            else
            {
                _velocidadActual = _velocidadActual - kmh;
            }
        }

        public void Frenar()
        {
            if (_motorEncendido == false)
            {
                Console.WriteLine("Advertencia: El motor está apagado.");
                return;
            }

            _modoCrucero = false;
            _velocidadActual = 0;
            Console.WriteLine("¡Frenado de emergencia activado! El vehículo se detuvo por completo.");
        }

        public void ActivarControlCrucero()
        {
            if (_motorEncendido == false)
            {
                Console.WriteLine("Advertencia: El motor está apagado.");
                return;
            }

            if (_velocidadActual > 60)
            {
                _modoCrucero = true;
                Console.WriteLine("Modo crucero activado con éxito.");
            }
            else
            {
                Console.WriteLine("Error: El modo crucero solo puede activarse a más de 60 km/h.");
            }
        }
    }
}