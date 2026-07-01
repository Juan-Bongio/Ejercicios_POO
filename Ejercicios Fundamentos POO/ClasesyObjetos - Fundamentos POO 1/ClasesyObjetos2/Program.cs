using Termometros;

Termometro termo1 = new Termometro(25);
Termometro termo2 = new Termometro(-10);

Console.WriteLine("--- Termometro 1 ---");
Console.WriteLine($"Celsius: {termo1.Celsius}");
Console.WriteLine($"Fahrenheit: {termo1.ObtenerFahrenheit()}");
Console.WriteLine($"Kelvin: {termo1.ObtenerKelvin()}");

Console.WriteLine("--- Termometro 2 ---");
Console.WriteLine($"Celsius: {termo2.Celsius}");
Console.WriteLine($"Fahrenheit: {termo2.ObtenerFahrenheit()}");
Console.WriteLine($"Kelvin: {termo2.ObtenerKelvin()}");

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();