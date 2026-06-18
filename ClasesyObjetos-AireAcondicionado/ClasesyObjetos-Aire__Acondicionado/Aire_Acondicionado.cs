namespace Aire_Acondicionado
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

        public string MODELO
        {
            get
            {
                string tipo;

                if (frioSolo)
                {
                    tipo = "FS";
                }
                else
                {
                    tipo = "FC";
                }

                string modelo =
                    marca.Substring(0, 3).ToUpper() +
                    frigorias +
                    pais.Substring(0, 3).ToUpper() +
                    tipo;

                if (split)
                {
                    modelo += "/S";
                }

                return modelo;
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
            temperatura = 30;
        }

        public void BAJAR()
        {
            temperatura = 18;
        }
    }
}