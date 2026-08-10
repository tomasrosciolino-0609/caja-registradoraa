//estapa 1
string NombreComercio = "lettera";
Console.WriteLine($"{NombreComercio}");
Console.Write("Ingrese el nombre de la persona que atiende en la caja: ");
string nombre = Console.ReadLine();
Console.WriteLine($"el nombre del cajero es {nombre}");
Console.WriteLine($"Bienvenido/a {nombre}. Caja abierta");

//etapa 2
Console.Write("Ingrese el nombre del producto: ");
string nombreProducto = Console.ReadLine();
Console.Write("Ingrese el precio del producto: ");
decimal precioProducto = decimal.Parse(Console.ReadLine());
Console.WriteLine($"El producto {nombreProducto} tiene un precio de {precioProducto}.");
Console.ReadKey();