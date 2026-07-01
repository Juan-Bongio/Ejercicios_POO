namespace Cuenta_Bancaria
{
    public class Cuenta
    {
        private string titular;
        private double saldo;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
        }

        public Cuenta(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void Depositar(double cantidad)
        {
            saldo += cantidad;

            Console.WriteLine($"{titular} deposito ${cantidad}");
            Console.WriteLine($"Saldo actual: ${saldo}");
        }

        public void Retirar(double cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;

                Console.WriteLine($"{titular} retiro ${cantidad}");
                Console.WriteLine($"Saldo actual: ${saldo}");
            }
            else
            {
                Console.WriteLine("Error: Saldo insuficiente");
            }
        }
    }
}