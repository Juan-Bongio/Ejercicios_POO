using Cuenta_Bancaria;

Cuenta cuenta1 = new Cuenta("Juan", 1000);
Cuenta cuenta2 = new Cuenta("Fran", 500);

Console.WriteLine("--- Cuenta 1 ---");
cuenta1.Depositar(300);
cuenta1.Retirar(200);

Console.WriteLine("\n--- Cuenta 2 ---");
cuenta2.Depositar(1000);
cuenta2.Retirar(700);

Console.ReadKey();