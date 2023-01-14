class Busqueda

{
    private RegistrarClientes registroClientes;
    private RegistrarProductos registroProductos;

    public  Busqueda(RegistrarProductos registroProductos)
    {
        this.registroProductos = registroProductos;
    }

    public Busqueda(RegistrarClientes registroClientes)
    {
        this.registroClientes = registroClientes;
    }

    public void BuscarPorNombre()
    {
        Console.WriteLine("Ingrese el nombre del cliente a buscar: ");
        string nombre = Console.ReadLine();

        foreach (Cliente cliente in registroClientes.clientes)
        {
            if (cliente.Nombre.Contains(nombre))
            {
                Console.WriteLine("Nombre: " + cliente.Nombre);
                Console.WriteLine("Numero de identificacion: " + cliente.NumeroIdentificacion);
                Console.WriteLine("Direccion: " + cliente.Direccion);
                Console.WriteLine("Telefono: " + cliente.Telefono);

            }
        }
    }
    public void BuscarPorNombreProducto()
    {
        Console.WriteLine("Ingrese el nombre del producto a buscar: ");
        string nombreProducto = Console.ReadLine();

        foreach (Productostec producto in registroProductos.productos)
        {
            if (producto.Nombre.Contains(nombreProducto))
            {
                Console.WriteLine("Nombre: " + producto.Nombre);
                Console.WriteLine("Codigo: " + producto.Codigo);
                Console.WriteLine("Precio: " + producto.Precio);
                Console.WriteLine("Cantidad: " + producto.Cantidad);
            }
        }
    }
    public void BuscarPorCodigoProducto()
    {
        Console.WriteLine("Ingrese el codigo del producto a buscar: ");
        string codigoProducto = Console.ReadLine();

        foreach (Productostec producto in registroProductos.productos)
        {
            if (producto.Codigo.Contains(codigoProducto))
            {
                Console.WriteLine("Nombre: " + producto.Nombre);
                Console.WriteLine("Codigo: " + producto.Codigo);
                Console.WriteLine("Precio: " + producto.Precio);
                Console.WriteLine("Cantidad: " + producto.Cantidad);
            }
        }
    }
}