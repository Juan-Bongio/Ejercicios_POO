using System;

namespace CryptoCore
{
    internal class CifradoDesplazamiento : Mensaje
    {
        private int _claveNumerica;

        public int ClaveNumerica
        {
            get { return _claveNumerica; }
            set
            {
                if (value > 0)
                {
                    _claveNumerica = value;
                }
            }
        }

        public override string Cifrar()
        {
            string resultado = "";

            foreach (char letra in TextoOriginal)
            {
                if (letra == ' ')
                {
                    resultado += " ";
                }
                else
                {
                    resultado += Convert.ToChar(letra + ClaveNumerica);
                }
            }

            return resultado;
        }
    }
}