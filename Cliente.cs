class Cliente:Persona
{
  
    public string Telefono { get; set; }

    public Cliente(string Nombre, string NumeroIdentificacion, string Direccion, string Telefono):base(Nombre, NumeroIdentificacion, Direccion)
    {
        this.Telefono = Telefono;
    }
}
