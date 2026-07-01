using System;

namespace CryptoCore
{
    internal class Mensaje
    {
        private string _textoOriginal;

        public string TextoOriginal
        {
            get { return _textoOriginal; }
            set
            {
                foreach (char c in value)
                {
                    if (c != ' ' && c != null)
                    {
                        _textoOriginal = value;
                    }
                    else 
                    {
                        return;
                    }
                }

            }
        }

        public virtual string Cifrar()
        {
            return TextoOriginal;
        }
    }
}