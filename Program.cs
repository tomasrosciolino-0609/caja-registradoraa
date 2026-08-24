const decimal DESCUENTO_ALTO = 0.10m;  
const decimal DESCUENTO_MEDIO = 0.05m; 
const decimal SIN_DESCUENTO = 0.00m;

const decimal DESCUENTO_EFECTIVO = 0.10m;
const decimal RECARGO_CREDITO = 0.15m;


string NombreComercio = "lettera";
Console.WriteLine($"{NombreComercio}");
Console.Write("Ingrese el nombre de la persona que atiende en la caja: ");
string nombre = Console.ReadLine();
Console.WriteLine($"el nombre del cajero es {nombre}");
Console.WriteLine($"Bienvenido/a {nombre}. Caja abierta");


decimal totalVenta = 0;
int cantidadProductos = 0;
string opcion = "";

do
{
    
    Console.WriteLine("\n¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Seleccione una opción: ");
    opcion = Console.ReadLine() ?? "";

    
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
decimal totalConDescuento = totalVenta - montoDescuento;

string medioPago = "";
decimal totalFinal = totalConDescuento;

do
{
    Console.WriteLine("\nMedio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito");
    Console.Write("Seleccione una opción: ");
    medioPago = Console.ReadLine() ?? "";

    switch (medioPago)
    {
        case "1":
            totalFinal = totalConDescuento - (totalConDescuento * DESCUENTO_EFECTIVO);
            break;
        case "2":
            totalFinal = totalConDescuento;
            break;
        case "3":
            totalFinal = totalConDescuento + (totalConDescuento * RECARGO_CREDITO);
            break;
        default:
            Console.WriteLine("Opción inválida. Ingrese 1, 2 o 3.");
            break;
    }

} while (medioPago != "1" && medioPago != "2" && medioPago != "3");


decimal montoDescuentoEfectivo = 0;
decimal montoRecargoCredito = 0;

if (medioPago == "1")
{
    montoDescuentoEfectivo = totalConDescuento * DESCUENTO_EFECTIVO;
}
else if (medioPago == "3")
{
    montoRecargoCredito = totalConDescuento * RECARGO_CREDITO;
}

decimal totalDescuentoTotal = montoDescuento + montoDescuentoEfectivo;

// Generación de línea divisoria con bucle for
string linea = "";
for (int i = 0; i < 30; i++)
{
    linea += "-";
}

Console.WriteLine();
Console.WriteLine(linea);
Console.WriteLine($"       {NombreComercio.ToUpper()}");
Console.WriteLine(linea);
Console.WriteLine($"Cajero: {nombre}");
Console.WriteLine($"Productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: {totalVenta}");
Console.WriteLine($"Descuento: {totalDescuentoTotal}");
Console.WriteLine($"Recargo: {montoRecargoCredito}");
Console.WriteLine(linea);
Console.WriteLine($"TOTAL: {totalFinal}");
Console.WriteLine(linea);

Console.ReadKey();