using Control_Inventario;

Producto producto1 = new Producto("001", "Mouse", 25000);
Producto producto2 = new Producto("002", "Teclado", 40000);

Console.WriteLine("--- Producto 1 ---");
producto1.AplicarDescuento(20);

Console.WriteLine("\n--- Producto 2 ---");
producto2.AplicarDescuento(10);

Console.ReadKey();