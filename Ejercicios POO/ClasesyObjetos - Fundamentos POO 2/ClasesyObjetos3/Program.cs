using Reloj_Digital;

Reloj reloj1 = new Reloj(14, 30, 45);
Reloj reloj2 = new Reloj(9, 5, 10);

Console.WriteLine("--- Reloj 1 ---");
reloj1.MostrarHora();

Console.WriteLine("\n--- Reloj 2 ---");
reloj2.MostrarHora();

Console.ReadKey();