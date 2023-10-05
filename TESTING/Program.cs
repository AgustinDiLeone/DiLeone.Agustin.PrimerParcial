using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Cliente p = new Cliente(24478569746,"Juansito",ETipos.Exento);
        Cliente p1 = new Cliente(25456978459);
        Cliente p2 = new Cliente();
        Cliente p3 = new Cliente(24478569746, "Juansito", ETipos.Exento,"BuenosAires");

        Console.WriteLine(p.ToString());
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
        Console.WriteLine(p3.ToString());

        Console.ReadLine();
    }
}