using Triangulo_Prohibido;

Rectangulo rectangulo1 = new Rectangulo(10, 5);
Rectangulo rectangulo2 = new Rectangulo(8, 3);

Console.WriteLine("--- Rectangulo 1 ---");
Console.WriteLine($"Area: {rectangulo1.Area()}");
Console.WriteLine($"Perimetro: {rectangulo1.Perimetro()}");

Console.WriteLine("\n--- Rectangulo 2 ---");
Console.WriteLine($"Area: {rectangulo2.Area()}");
Console.WriteLine($"Perimetro: {rectangulo2.Perimetro()}");

Console.ReadKey();