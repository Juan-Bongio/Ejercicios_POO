using System;

namespace Salon_Eventos
{
    public class Salon_Eventos
    {
        //Valores constantes
        private int _precioHoraSalon;
        private int _precioMozo;
        private int _cateringBasico;
        private int _cateringPremium;
        private int _precioAnimacion;

        //Atributos
        private string _nombreCliente;
        private char _dia;
        private char _tipoMenu;
        private int _cantidadInvitados;
        private int _cantidadHoras;
        private int _tipoReserva;
        private int _cantidadAnimaciones;
        private bool _incluyeMozos;

        public string NombreCliente
        {
            get { return _nombreCliente; }
            set
            {
                if (_nombreCliente == null || _nombreCliente == "")
                {
                    Console.WriteLine("Error: El nombre del cliente no puede estar vacío.");
                    return;
                }
                _nombreCliente = value;
            }
        }

        public string Dia
        {
            get
            {
                if (_dia == 'V') return "Viernes";
                if (_dia == 'S') return "Sábado";
                return "Domingo";
            }
            set
            {
                if (_dia == null || _dia == ' ')
                {
                    Console.WriteLine("Error: Debe ingresar un día válido.");
                    return;
                }

                char d = Convert.ToChar(value.ToUpper());
                if (d == 'V' || d == 'S' || d == 'D')
                {
                    _dia = d;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un día válido (V, S o D).");
                }
            }
        }

        public string TipoMenu
        {
            get
            {
                if (_tipoMenu == 'B') return "Básico";
                if (_tipoMenu == 'P') return "Premium";
                return "Ninguno";
            }
            set
            {
                if (_tipoMenu == null || _tipoMenu == ' ')
                {
                    Console.WriteLine("Error: Debe ingresar un menú válido.");
                    return;
                }

                char m = Convert.ToChar(value.ToUpper());
                if (m == 'B' || m == 'P' || m == 'N')
                {
                    _tipoMenu = m;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un menú válido (B, P o N).");
                }
            }
        }

        public int CantidadInvitados
        {
            get { return _cantidadInvitados; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: Ingrese una cantidad válida de invitados (mayor a 0).");
                    return;
                }
                _cantidadInvitados = value;
            }
        }

        public int CantidadHoras
        {
            get { return _cantidadHoras; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: Ingrese una cantidad válida de horas (mayor a 0).");
                    return;
                }
                _cantidadHoras = value;
            }
        }

        public int TipoReserva
        {
            get { return _tipoReserva; }
            set
            {
                if (value == 1 || value == 2 || value == 3)
                {
                    _tipoReserva = value;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar una reserva válida (1, 2 o 3).");
                    return;
                }
            }
        }

        public int CantidadAnimaciones
        {
            get { return _cantidadAnimaciones; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Ingrese una cantidad de animaciones válida.");
                    return;
                }
                _cantidadAnimaciones = value;
            }
        }

        public bool IncluyeMozos
        {
            get { return _incluyeMozos; }
            set { _incluyeMozos = value; }
        }

        public Salon_Eventos(string nombreCliente, int tipoReserva)
        {
            _precioHoraSalon = 6000;
            _precioMozo = 3000;
            _cateringBasico = 5000;
            _cateringPremium = 11000;
            _precioAnimacion = 18000;

            _nombreCliente = nombreCliente;
            _tipoReserva = tipoReserva;
            _dia = 'V';
            _tipoMenu = 'N';
            _cantidadInvitados = 0;
            _cantidadHoras = 0;
            _cantidadAnimaciones = 0;
            _incluyeMozos = false;
        }

        public int CalcularValor()
        {
            int total = 0;

            total += _cantidadHoras * _precioHoraSalon;

            if (_incluyeMozos)
            {
                int mozosNecesarios = (_cantidadInvitados + 14) / 15; ;
                total += mozosNecesarios * _precioMozo;
            }

            if (_dia == 'S')
            {
                total = (total * 80) / 100;
            }
            else if (_dia == 'D')
            {
                total = (total * 50) / 100;
            }

            if (_tipoReserva == 2 || _tipoReserva == 3)
            {
                if (_tipoMenu == 'B')
                {
                    total += _cantidadInvitados * _cateringBasico;
                }
                else if (_tipoMenu == 'P')
                {
                    total += _cantidadInvitados * _cateringPremium;
                }
            }

            if (_tipoReserva == 3)
            {
                total += _cantidadAnimaciones * _precioAnimacion;
            }

            return total;
        }

        public string ObtenerResumen()
        {
            return $"{_nombreCliente} Invitados: {_cantidadInvitados} Horas: {_cantidadHoras} PRECIO $ {CalcularValor()}";
        }
    }
}