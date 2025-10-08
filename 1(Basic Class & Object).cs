using System;
using System.IO;


//single object

class Anon
{
    string color = "Red";
    public static void Main()
    {
        Anon anon = new Anon();
        Console.WriteLine(anon.color);
    }
}




//Multi Object
class Anon
{
    string car = "Red";
    public static void Main()
    {
        Anon anon1 = new Anon();
        Anon anon2 = new Anon();

        Console.WriteLine(anon1.car);

        anon2.car = "Bluhit";
        Console.WriteLine(anon2.car);
    }
}
