class Productostec
{
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double Precio { get; set; }
    public string Codigo { get; set; }
    public int Cantidad { get; set; }


    public Productostec(string nombre, string marca, string modelo, double precio, string codigo, int Cantidad)
    {
        Nombre = nombre;
        Marca = marca;
        Modelo = modelo;
        Precio = precio;
        Codigo=codigo;
    }
}
