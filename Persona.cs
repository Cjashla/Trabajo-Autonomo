class Persona
{
    public string Nombre {get;set;}
    public string NumeroIdentificacion {get;set;}
    public string Direccion {get;set;}
    public Persona(string Nombre, string NumeroIdentificacion, string Direccion)
    {
        this.Nombre=Nombre;
        this.NumeroIdentificacion=NumeroIdentificacion;
        this.Direccion=Direccion;
    }
}