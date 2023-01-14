abstract class Trabajador:Persona
{
    public abstract string NumeroEmpleado { get; set; }
    public abstract string Cargo { get; set; }
    public abstract double Salario { get; set; }
    public Trabajador (string Nombre, string NumeroIdentificacion, string Direccion, string NumeroEmpleado, string Cargo, double Salario):base(Nombre, NumeroIdentificacion, Direccion)
    {
        this.NumeroEmpleado= NumeroEmpleado;
        this.Cargo=Cargo;
        this.Salario=Salario;
    }
}