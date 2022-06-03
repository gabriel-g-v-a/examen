using System;
namespace tutoria
class Estudiantesecundaria
{
    public int nivelcursado;
    public int PrecioFijo; 

    public profesorHoras(string direccion,string nombre, string apellido, string ID, int nivelcursado, int PrecioFijo):base(direccion,nombre,apellido,ID)
    {
        this.nivelcursado = nivelcursado;
        this.PrecioFijo = PrecioFijo;
    }
    public override void ImprimirPropiedades()
    {
        Console.WriteLine("direccion:" + direccion);
        Console.WriteLine("nombre:" + nombre);
        Console.WriteLine("apellido:" + apellido);
        Console.WriteLine("ID:" + ID);
        int sueldototal;
        sueldototal = nivelcursado*PrecioFijo;
        Console.WriteLine("el sueldo es de:" + sueldototal);
    }    
}