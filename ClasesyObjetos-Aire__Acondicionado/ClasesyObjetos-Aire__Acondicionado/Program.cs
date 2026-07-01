using System;

namespace AireAcondicionado
{
    public class AIRE
    {
        private string marca;
        private int frigorias;
        private bool split;
        private string pais;
        private bool frioSolo;
        private int temperatura;
        private bool encendido;
        private string _modelo;

        public string Marca
        {
            get { return marca; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Error: La marca no puede estar vacía.");
                    return;
                }
                marca = value;
            }
        }

        public int Frigorias
        {
            get { return frigorias; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: Las frigorías deben ser mayores a 0.");
                    return;
                }
                frigorias = value;
            }
        }

        public bool Split
        {
            get { return split; }
            set { split = value; }
        }

        public string Pais
        {
            get { return pais; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Error: El país no puede estar vacío.");
                    return;
                }
                pais = value;
            }
        }

        public bool FrioSolo
        {
            get { return frioSolo; }
            set { frioSolo = value; }
        }

        public string MODELO
        {
            get
            {
                if (_modelo != null && _modelo != "")
                {
                    return _modelo;
                }

                string tipo;
                if (frioSolo)
                {
                    tipo = "FS";
                }
                else
                {
                    tipo = "FC";
                }

                string modelofinal = marca.Substring(0, 3).ToUpper() + frigorias + pais.Substring(0, 3).ToUpper() + tipo;

                if (split)
                {
                    modelofinal = modelofinal + "/S";
                }

                return modelofinal;
            }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Error: El modelo ingresado no puede estar vacío.");
                    return;
                }

                if (value.Length < 8)
                {
                    Console.WriteLine("Error: El modelo es demasiado corto. Debe tener al menos 8 caracteres.");
                    return;
                }

                if (value.Length > 20)
                {
                    Console.WriteLine("Error: El modelo es demasiado largo. No puede superar los 20 caracteres.");
                    return;
                }

                _modelo = value;
            }
        }

        public bool Encendido
        {
            get { return encendido; }
        }

        public int Temperatura
        {
            get { return temperatura; }
        }

        public AIRE(string marca, int frigorias, bool split, string pais, bool frioSolo)
        {
            this.marca = marca;
            this.frigorias = frigorias;
            this.split = split;
            this.pais = pais;
            this.frioSolo = frioSolo;

            temperatura = 18;
            encendido = false;
        }

        public void POWER()
        {
            encendido = !encendido;
        }

        public void SUBIR(int grados)
        {
            if (encendido)
            {
                temperatura += grados;
            }
            else
            {
                Console.WriteLine("El aire esta apagado");
            }
        }

        public void BAJAR(int grados)
        {
            if (encendido)
            {
                temperatura -= grados;
            }
            else
            {
                Console.WriteLine("El aire esta apagado");
            }
        }

        public void SUBIR()
        {
            if (encendido)
            {
                temperatura = 30;
            }
            else
            {
                Console.WriteLine("El aire esta apagado");
            }
        }

        public void BAJAR()
        {
            if (encendido)
            {
                temperatura = 18;
            }
            else
            {
                Console.WriteLine("El aire esta apagado");
            }
        }
    }
}