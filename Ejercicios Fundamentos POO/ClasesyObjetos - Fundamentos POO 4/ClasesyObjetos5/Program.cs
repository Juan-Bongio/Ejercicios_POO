using Registro_Libros;

Libro libro1 = new Libro("It", "Stephen King", "12345", 1500);
Libro libro2 = new Libro("El Principito", "Saint-Exupery", "67890", 120);

Console.WriteLine("--- Libro 1 ---");
Console.WriteLine(libro1.EsLargo());

Console.WriteLine("\n--- Libro 2 ---");
Console.WriteLine(libro2.EsLargo());

Console.ReadKey();