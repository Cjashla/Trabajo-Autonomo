class RegistroTrabajadores
{
    private List<Trabajador> trabajadores;

    public RegistroTrabajadores()
    {
        trabajadores = new List<Trabajador>();
    }

    public void AgregarTrabajador(Trabajador trabajador)
    {
        trabajadores.Add(trabajador);
    }

    public void EliminarTrabajador(string numeroEmpleado)
    {
        foreach (Trabajador trabajador in trabajadores)
        {
            if (trabajador.NumeroEmpleado == numeroEmpleado)
            {
                trabajadores.Remove(trabajador);
                break;
            }
        }
    }

    public void ImprimirTrabajadores()
    {
        foreach (Trabajador trabajador in trabajadores)
        {
            Console.WriteLine("Nombre: " + trabajador.Nombre);
            Console.WriteLine("Numero de empleado: " + trabajador.NumeroEmpleado);
            Console.WriteLine("Cargo: " + trabajador.Cargo);
        }
    }   
}