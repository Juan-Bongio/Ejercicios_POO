using Cafetera_Automatica;

Cafetera cafetera1 = new Cafetera(1000, 500);
Cafetera cafetera2 = new Cafetera(2000, 1500);

Console.WriteLine("--- Cafetera 1 ---");
cafetera1.LlenarCafetera();
cafetera1.ServirTaza(300);
cafetera1.VaciarCafetera();

Console.WriteLine("\n--- Cafetera 2 ---");
cafetera2.ServirTaza(700);

Console.ReadKey();