class RegistrarClientes
{
     public Cliente[] clientes;
    private int contadorClientes;

    public RegistrarClientes()
    {
        clientes = new Cliente[10];
        contadorClientes = 0;
    }
public Cliente BuscarCliente(string numeroIdentificacion)
    {
        for (int i = 0; i < contadorClientes; i++)
        {
            if (clientes[i].NumeroIdentificacion == numeroIdentificacion)
            {
                return clientes[i];
            }
        }
        return null;
    }
    public void AgregarCliente()
    {
        if (contadorClientes == clientes.Length)
        {
            Console.WriteLine("El registro de clientes esta lleno.");
            return;
        }

        Console.WriteLine("Ingrese el nombre del cliente:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el numero de identificacion del cliente:");
        string numeroIdentificacion = Console.ReadLine();

        Console.WriteLine("Ingrese la direccion del cliente:");
        string direccion = Console.ReadLine();

        Console.WriteLine("Ingrese el telefono del cliente:");
        string Telefono = Console.ReadLine();

        Cliente cliente = new Cliente(nombre, numeroIdentificacion, direccion, Telefono);
        clientes[contadorClientes] = cliente;
        contadorClientes++;
    }

    public void MostrarClientes()
    {
        for (int i = 0; i < contadorClientes; i++)
        {
            Console.WriteLine("Nombre: " + clientes[i].Nombre);
            Console.WriteLine("Numero de identificacion: " + clientes[i].NumeroIdentificacion);
            Console.WriteLine("Direccion: " + clientes[i].Direccion);
            Console.WriteLine("Telefono: "+clientes[i].Telefono);
            Console.WriteLine();
        }
    }
    public void EliminarCliente()
    {
        Console.WriteLine("Ingrese el numero de identificacion del cliente a eliminar:");
        string numeroIdentificacion = Console.ReadLine();
        int indice = -1;

        for (int i = 0; i < contadorClientes; i++)
        {
            if (clientes[i].NumeroIdentificacion == numeroIdentificacion)
            {
                indice = i;
                break;
            }
        }

        if (indice == -1)
        {
            Console.WriteLine("No se ha encontrado al cliente con el numero de identificacion: " + numeroIdentificacion);
            return;
        }

        for (int i = indice; i < contadorClientes - 1; i++)
        {
            clientes[i] = clientes[i + 1];
        }

        contadorClientes--;
        Console.WriteLine("Cliente eliminado exitosamente!");
    }
    
}
