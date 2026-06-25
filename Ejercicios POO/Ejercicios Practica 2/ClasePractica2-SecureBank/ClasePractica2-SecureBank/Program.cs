using System;
using System.Collections.Generic;

namespace SecureBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transaccion> transacciones = new List<Transaccion>();

            transacciones.Add(new Transferencia { TokenSeguridad = "ABC12345", Monto = 250000, CuentaDestino = "001-123456" });
            transacciones.Add(new Transferencia { TokenSeguridad = "XYZ98765", Monto = 800000, CuentaDestino = "002-654321" });
            transacciones.Add(new PagoServicio { TokenSeguridad = "SEG12345", Monto = 10000, DiasVencido = 5 });
            transacciones.Add(new PagoServicio { TokenSeguridad = "123", Monto = 5000, DiasVencido = 0 });

            Console.WriteLine("--- SecureBank ---");

            foreach (Transaccion transaccion in transacciones)
            {
                Console.WriteLine(transaccion.Procesar());
            }

            Console.ReadLine();
        }
    }
}