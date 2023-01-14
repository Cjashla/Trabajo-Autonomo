class RegistrarProductos
{
    public Productostec[] productos;
    private int contadorProductos;

    public RegistrarProductos()
    {
        productos = new Productostec[10];
        contadorProductos = 0;
    }
public Productostec BuscarProducto(string nombre)
    {
        for (int i = 0; i < contadorProductos; i++)
        {
            if (productos[i].Nombre == nombre)
            {
                return productos[i];
            }
        }
        return null;
    }
    public void AgregarProducto()
    {
        if (contadorProductos == productos.Length)
        {
            Console.WriteLine("El registro de productos esta lleno.");
            return;
        }

        Console.WriteLine("Ingrese el nombre del producto:");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el modelo del producto:");
        string Modelo = Console.ReadLine();

        Console.WriteLine("Ingrese la marca del producto:");
        string Marca = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del producto:");
        double Precio = Double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el codigo del producto:");
        string Codigo = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad del producto:");
        int Cantidad = Int32.Parse(Console.ReadLine());

        Productostec producto = new Productostec(Nombre, Marca, Modelo, Precio, Codigo, Cantidad);
        productos[contadorProductos] = producto;
        contadorProductos++;
    }
    public void EliminarProducto()
    {
        Console.WriteLine("Ingrese el nombre del producto a eliminar:");
        string nombreProducto = Console.ReadLine();

        for (int i = 0; i < contadorProductos; i++)
        {
            if (productos[i].Nombre == nombreProducto)
            {
                for (int j = i; j < contadorProductos - 1; j++)
                {
                    productos[j] = productos[j + 1];
                }
                contadorProductos--;
                Console.WriteLine("Producto eliminado.");
                return;
            }
        }
        Console.WriteLine("Producto no encontrado.");
    }
    public void MostrarProductos()
    {
        for (int i = 0; i < contadorProductos; i++)
        {
            Console.WriteLine("Nombre: " + productos[i].Nombre);
            Console.WriteLine("Marca: " + productos[i].Marca);
            Console.WriteLine("Modelo: " + productos[i].Modelo);
            Console.WriteLine("Precio: " + productos[i].Precio);
            Console.WriteLine("Precio: " + productos[i].Codigo);
            Console.WriteLine("Precio: " + productos[i].Cantidad);
        }
    }


   
}
