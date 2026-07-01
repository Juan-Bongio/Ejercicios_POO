using Seguimiento_Fitness;

CalculadoraPasos usuario1 = new CalculadoraPasos("Juan", 10000);
CalculadoraPasos usuario2 = new CalculadoraPasos("Maria", 8000);

Console.WriteLine("--- Usuario 1 ---");
usuario1.RegistrarPasos(7000);
usuario1.RegistrarPasos(4000);
Console.WriteLine(usuario1.ObjetivoCumplido());

Console.WriteLine("\n--- Usuario 2 ---");
usuario2.RegistrarPasos(3000);
Console.WriteLine(usuario2.ObjetivoCumplido());

Console.ReadKey();