const decimal DESCUENTO_ALTO = 0.10m;  
const decimal DESCUENTO_MEDIO = 0.05m; 
const decimal SIN_DESCUENTO = 0.00m;

//estapa 1
string NombreComercio = "lettera";
Console.WriteLine($"{NombreComercio}");
Console.Write("Ingrese el nombre de la persona que atiende en la caja: ");
string nombre = Console.ReadLine();
Console.WriteLine($"el nombre del cajero es {nombre}");
Console.WriteLine($"Bienvenido/a {nombre}. Caja abierta");

//etapa 3 
decimal totalVenta = 0;
int cantidadProductos = 0;
string opcion = "";

do
{
    // Mostrar el menú
    Console.WriteLine("\n¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Seleccione una opción: ");
    opcion = Console.ReadLine() ?? "";

    // Evaluar la opción ingresada
    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese el nombre del producto: ");
            string nombreProducto = Console.ReadLine() ?? "";

            Console.Write("Ingrese el precio del producto: ");
            decimal precioProducto = decimal.Parse(Console.ReadLine() ?? "0");

            
            totalVenta += precioProducto;
            cantidadProductos++;

            Console.WriteLine($"Producto '{nombreProducto}' agregado exitosamente.");
            break;

        case "2":
            Console.WriteLine("\nCerrando la venta...");
            break;

        default:
            Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
            break;
    }

} while (opcion != "2");

decimal porcentajeAplicado = SIN_DESCUENTO;

if (totalVenta > 50000)
{
    porcentajeAplicado = DESCUENTO_ALTO;
}
else if (totalVenta > 20000)
{
    porcentajeAplicado = DESCUENTO_MEDIO;
}
else
{
    porcentajeAplicado = SIN_DESCUENTO;
}
decimal montoDescuento = totalVenta * porcentajeAplicado;
decimal totalFinal = totalVenta - montoDescuento;

// Al salir del ciclo (cerrar la venta), mostrar los totales
Console.WriteLine("\n--- RESUMEN DE COMPRA ---");
Console.WriteLine($"Cantidad de productos cargados: {cantidadProductos}");
Console.WriteLine($"Total acumulado: ${totalVenta}");
Console.WriteLine($"Descuento aplicado ({porcentajeAplicado * 100}%): -${montoDescuento}");
Console.WriteLine($"Total a pagar: ${totalFinal}");

Console.ReadKey();