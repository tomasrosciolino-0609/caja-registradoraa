string NombreComercio = "lettera";
Console.WriteLine($"{NombreComercio}");
Console.Write("Ingrese el nombre de la persona que atiende en la caja: ");
string nombre = Console.ReadLine();
Console.WriteLine($"el nombre del cajero es {nombre}");
Console.WriteLine($"Bienvenido/a {nombre}. Caja abierta");
Console.ReadKey();