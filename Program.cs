// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

   int opcion=0;
   
RegistrarProductos registroProductos = new RegistrarProductos();
RegistrarClientes registroClientes = new RegistrarClientes();
Busqueda busquedaP = new Busqueda(registroProductos);
Busqueda busqueda = new Busqueda(registroClientes);


Console.WriteLine("======================");
Console.WriteLine("---Menu de Opciones---");
Console.WriteLine("======================");
Console.WriteLine("Digite una de las opciones");
Console.WriteLine("1. Factura");
Console.WriteLine("2. Registrar cliente ");
Console.WriteLine("3. Eliminar  cliente ");
Console.WriteLine("4. Mostrar clientes ");
Console.WriteLine("5. Registrar productos");
Console.WriteLine("6. Eliminar productos del registro");
Console.WriteLine("7. Mostrar productos");
Console.WriteLine("8. Buscar Cliente");
Console.WriteLine("9. Buscar Producto");
Console.WriteLine();

opcion = int.Parse(Console.ReadLine());

do{
switch (opcion)
{
   
   case 1://facturacion
   Factura factura = new Factura(registroClientes, registroProductos);
   factura.CalcularTotal();
   factura.MostrarDetalles();
   break;

   case 2://Registro de Clientes Agregar, Eliminar un Cliente al Sistema o tambien imprimir los clientes registrados
   registroClientes.AgregarCliente();
   break;

   case 3:// Eliminar cliente Registrado por numero de identificacion
   registroClientes.EliminarCliente();
   break;

   case 4://Muestra los clientes registrados en el sistema
   registroClientes.MostrarClientes();
   break;

   case 5://Registrar nuevos productos
   registroProductos.AgregarProducto();
   break;

   case 6:// Eiminar productos registrados en el sistema
   registroProductos.EliminarProducto();
   break;

   case 7://Mostrar todos los productos registrados en el sistema
   registroProductos.MostrarProductos();
   break;


   case 8://buscar cliente por Nombre
   busqueda.BuscarPorNombre();
   break;

   case 9://Busca productos por NombreregistroProductos.AgregarProducto();
   busqueda.BuscarPorNombreProducto();
   break;

   default:
   break;

}
Console.WriteLine("Deseas Salir del Sistema?");
Console.WriteLine("1. SI   2.NO");
Console.ReadLine();
opcion = int.Parse(Console.ReadLine());

}while(opcion!=2);
         



