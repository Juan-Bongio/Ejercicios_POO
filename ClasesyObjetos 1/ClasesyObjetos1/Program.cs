using ClasesyObjetos1;

Perro perro1 = new Perro();
perro1.nombre = "Negro";
perro1.raza = "Labrador";
perro1.altura = "60cm";

Perro perro2 = new Perro("Luna", "Poodle", "30cm");

Console.WriteLine("--- Perro 1 ---");
perro1.Dormir();
string resultadoComer = perro1.Comer("Hamburguesa");
Console.WriteLine(resultadoComer);

Console.WriteLine("\n--- Perro 2 ---");
perro2.Ladrar();
Console.WriteLine(perro2.Comer("Pollo"));

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();