using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Cliente p = new Cliente(24478569746,"Juansito",ETipos.Exento);
        Cliente p1 = new Cliente(25456978459);
        Cliente p2 = new Cliente();
        Cliente p3 = new Cliente(24478569746, "Juansito", ETipos.Exento,"BuenosAires");

        DispositivoElectronico d = new Celular(10,20,254.4);
        DispositivoElectronico d1 = new Celular(25, 8, 25415);
        DispositivoElectronico d2 = new Celular();
        DispositivoElectronico d3 = new Celular(18, 1, 24817,"samsung","a23", EFactura.C,20,256,10,5);
        DispositivoElectronico d4 = new Celular(74, 58, 47,"Samsung","S8+",EFactura.C);
        DispositivoElectronico t = new Televisor(2,10, 2547, "samsung", "a23", EFactura.C, 80, 1080,true);

        /*
        Console.WriteLine(p.ToString());
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
        Console.WriteLine(p3.ToString());
        Console.WriteLine(d.ToString());
        Console.WriteLine(d1.ToString());
        Console.WriteLine(d2.ToString());
        Console.WriteLine(d3.ToString());
        Console.WriteLine(d4.ToString());
        */

        p += d;
        p1 += d1;
        p1 += d2;
        p1 += d2;
        p2 += d3;
        p2 += d2;
        p3 += d4;
        p3 += t;

        
        Console.WriteLine(p.ToString());
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
        Console.WriteLine(p3.ToString());

        for (int i = 0; i < p3.Dispositivos.Count; i++)
            Console.WriteLine(p3.Dispositivos[i].MostrarVisor());


        Console.ReadLine();
    }
}