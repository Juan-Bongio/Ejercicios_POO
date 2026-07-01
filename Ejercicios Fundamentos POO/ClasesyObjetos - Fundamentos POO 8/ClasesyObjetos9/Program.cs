using Perfil_Usuario;

Usuario usuario1 = new Usuario("Juan123", "abc123", "juan@gmail.com");
Usuario usuario2 = new Usuario("Maria456", "pass456", "maria@gmail.com");

Console.WriteLine("--- Usuario 1 ---");
usuario1.CambiarPassword("abc123", "nueva123");

Console.WriteLine("\n--- Usuario 2 ---");
usuario2.CambiarPassword("incorrecta", "claveNueva");

Console.ReadKey();