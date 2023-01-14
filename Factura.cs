using System;
using System.Globalization;

class Factura
{
    private RegistrarClientes registroClientes;
    private RegistrarProductos registroProductos;

    public int Numero { get; set; }
    public DateTime Fecha { get; set; }
    public string NombreCliente { get; set; }
    public string NumeroIdentificacion { get; set; }
    public string Direccion { get; set; }
    public string[] Productos { get; set; }
    public double[] Cantidades { get; set; }
    public double[] PreciosUnitarios { get; set; }

    public Factura(RegistrarClientes registroClientes, RegistrarProductos registroProductos)
    {
        this.registroClientes = registroClientes;
        this.registroProductos = registroProductos;

        Console.WriteLine("Ingrese el numero de la factura:");
        Numero = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la fecha de la factura (dd/mm/yyyy):");
        Fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Ingrese el numero de identificacion del cliente:");
        NumeroIdentificacion = Console.ReadLine();

        // buscar el cliente en el registro de clientes
        var cliente = registroClientes.BuscarCliente(NumeroIdentificacion);
        if (cliente != null)
        {
            NombreCliente = cliente.Nombre;
            Direccion = cliente.Direccion;
        }
        else
        {
            Console.WriteLine("El cliente no se encuentra registrado.");
            return;
        }

        Console.WriteLine("Ingrese la cantidad de productos a registrar en la factura:");
        int cantidadProductos = Int32.Parse(Console.ReadLine());

        Productos = new string[cantidadProductos];
        Cantidades = new double[cantidadProductos];
        PreciosUnitarios = new double[cantidadProductos];

        for (int i = 0; i < cantidadProductos; i++)
        {
            Console.WriteLine("Ingrese el nombre del producto " + (i + 1) + ":");
            string nombreProducto = Console.ReadLine();

            // buscar el producto en el registro de productos
            var producto = registroProductos.BuscarProducto (nombreProducto);
            if (producto != null)
            {
                Productos[i] = producto.Nombre;
                PreciosUnitarios[i] = producto.Precio;
                Console.WriteLine("Ingrese la cantidad del producto " + (i + 1) + ":");
                Cantidades[i] = Double.Parse(Console.ReadLine());
            }
        }
    }
    public double CalcularTotal()
    {
        double total = 0;
        for (int i = 0; i < Productos.Length; i++)
        {
            total += Cantidades[i] * PreciosUnitarios[i];
        }
        return total;
    }
    public void MostrarDetalles()
    {
        Console.WriteLine("Datos de la factura");
        Console.WriteLine("Numero de factura: " + Numero);
        Console.WriteLine("Fecha: " + Fecha.ToString("dd/MM/yyyy"));
        Console.WriteLine("Nombre del cliente: " + NombreCliente);
        Console.WriteLine("Numero de identificacion: " + NumeroIdentificacion);
        Console.WriteLine("Direccion: " + Direccion);

        for (int i = 0; i < Productos.Length; i++)
        {
            Console.WriteLine("Producto " + (i + 1) + ": " + Productos[i]);
            Console.WriteLine("Cantidad: " + Cantidades[i]);
            Console.WriteLine("Precio unitario: " + PreciosUnitarios[i]);
            Console.WriteLine("Subtotal: " + (Cantidades[i] * PreciosUnitarios[i]));
        }
        Console.WriteLine("Total: " + CalcularTotal());
    }
}
