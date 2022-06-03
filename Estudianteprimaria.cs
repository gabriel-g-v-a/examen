using System;
namespace tutoria
{
    class Estudianteprimaria
}
    {
        public int valorP{set;get;}

        public estudiantep(string nombre,string apellido,string nombreinstitucion,int cedula):base(nombre,apellido,nombreinstitucion,cedula)
        {
            this.valorP=valorP;
        }

        public void Calcular()
    {
        int año;
        Console.writeLine("Cual es el numero de años");
        valorP=int.Parse(console.ReadLine());
    }
        {
            int total,años;
            Console.WriteLine("Ingrese el número de años ");
            años=int.Parse(Console.ReadLine());
            total=años*valorP;

            Console.WriteLine("El valor de la matricula anual es: " +total);
        }