using System;
using System.IO;


//Constructors Fixed


class Anon
{
    public string car;
    public Anon()
    {
        car = "Abdal";
    }
    public static void Main()
    {
        Anon anon = new Anon();
        Console.WriteLine(anon.car);
    }
}



//Constructors Data Pass & Multi


class Anon
{
    public string Name;
    public int Class;
    public int Roll;

    public Anon( string n, int C, int R )
    {
        Name = n;
        Class = C;
        Roll = R;
    }
    public static void Main()
    {
        
        Anon Man1 = new Anon("Atik",10,9);
        Anon Man2 = new Anon("Aditta",9,22);

        Console.WriteLine(Man1.Name + Man1.Class + Man1.Roll);

        Console.WriteLine(Man2.Name + Man2.Class + Man2.Roll);

    }
}

