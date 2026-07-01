using System;

namespace CryptoCore
{
    internal class CifradoInvertido : Mensaje
    {
        public override string Cifrar()
        {
            char[] caracteres = TextoOriginal.ToCharArray();

            Array.Reverse(caracteres);

            return new string(caracteres);
        }
    }
}