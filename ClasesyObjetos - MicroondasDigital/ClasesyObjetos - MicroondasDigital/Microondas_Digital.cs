using System;

namespace Microondas_Digital
{
    public class Microondas
    {
        private int _potencia;
        private int _tiempoSegundos;
        private bool _puertaAbierta;
        private bool _enFuncionamiento;

        public int Potencia
        {
            get { return _potencia; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    _potencia = value;
                }
                else
                {
                    Console.WriteLine("Error: El microondas no permite esa potencia");
                }
            }
        }

        public bool PuertaAbierta
        {
            get { return _puertaAbierta; }
            set { _puertaAbierta = value; } 
        }

        public bool EnFuncionamiento
        {
            get { return _enFuncionamiento; }
        }

        public int TiempoSegundos 
        {
            get { return _tiempoSegundos; }
            set
            {
                if (_tiempoSegundos <= 0) {
                    Console.WriteLine("Error: Ingrese un tiempo valido (mayor a 0).");
                    return;
                }
                _tiempoSegundos = value;
            }
        }

        public string PANTALLA_TIEMPO
        {
            get
            {
                int minutos = _tiempoSegundos / 60;
                int segundos = _tiempoSegundos - (minutos * 60);
                string total = Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
                return total;
            }
            // sin set porque es Solo de Lectura
        }

        public Microondas()
        {
            _potencia = 5;
            _tiempoSegundos = 0;
            _puertaAbierta = false;
            _enFuncionamiento = false;
        }

        public void AgregarTiempo()
        {
            AgregarTiempo(30);
        }

        public void AgregarTiempo(int segundos)
        {
            if (_tiempoSegundos + segundos > 3600)
            {
                _tiempoSegundos = 3600;
                Console.WriteLine("Advertencia: Límite máximo de tiempo alcanzado (60:00).");
            }
            else
            {
                _tiempoSegundos += segundos;
            }
        }

        public void Iniciar()
        {
            if (_puertaAbierta)
            {
                Console.WriteLine("Error: No se puede iniciar con la puerta abierta.");
                return;
            }
            if (_tiempoSegundos <= 0)
            {
                Console.WriteLine("Error: Ingrese tiempo de cocción antes de iniciar.");
                return;
            }

            _enFuncionamiento = true;
        }

        public void Detener()
        {
            if (_enFuncionamiento)
            {
                _enFuncionamiento = false;
                Console.WriteLine("Cocción Pausada.");
            }
            else
            {
                _tiempoSegundos = 0; 
                Console.WriteLine("Tiempo reiniciado a 00:00.");
            }
        }

        public void AbrirCerrarPuerta()
        {
            _puertaAbierta = !_puertaAbierta;

            if (_puertaAbierta && _enFuncionamiento)
            {
                _enFuncionamiento = false;
                Console.WriteLine("\n¡SEGURIDAD! Puerta abierta. Proceso interrumpido.");
            }
        }
    }
}