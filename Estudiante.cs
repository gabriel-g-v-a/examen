using System;
class tutoria
{

    public string Nombre;
    public string Apellido;
    public string Nombredelainstitucion;
    public string cedula;

    public Estudiante(string Nombre,string Apellido, string Nombredelainstitucion, string cedula)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Nombredelainstitucion = Nombredelainstitucion;
        this.cedula = cedula;

    }
    public virtual void ImprimirPropiedades()
    {
        Console.writeLine("Datos")
    Console.writeLine("Nombre: " +Nombre)
    Console.writeLine("Apellido: " +Apellido)
    Console.writeLine("Nombredelainstitucion: " +Nombredelainstitucion)
    Console.writeLine("cedula: " +cedula)
    }
public void calcular()
{
    
}
}