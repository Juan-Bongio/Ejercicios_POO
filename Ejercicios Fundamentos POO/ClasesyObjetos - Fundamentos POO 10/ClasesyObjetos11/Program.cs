using ClasesyObjetos2;

Estudiante estudiante1 = new Estudiante("Juan", 8, 7, 9);
Estudiante estudiante2 = new Estudiante("Maria", 4, 5, 3);

Console.WriteLine("--- Estudiante 1 ---");
Console.WriteLine($"Promedio: {estudiante1.CalcularPromedio()}");
Console.WriteLine(estudiante1.EstadoFinal());

Console.WriteLine("\n--- Estudiante 2 ---");
Console.WriteLine($"Promedio: {estudiante2.CalcularPromedio()}");
Console.WriteLine(estudiante2.EstadoFinal());

Console.ReadKey();