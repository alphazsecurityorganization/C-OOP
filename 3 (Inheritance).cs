using System;
using System.IO;


// Inheritance
class A
{
    public string Name = "Adnan";
    public void tom()
    {
        Console.WriteLine("Mew Mew");
    }
}
class B : A
{
    public string Fname = "Aditta";

}
class C
{
    public static void Main()
    {
        B a = new B();
        Console.WriteLine(a.Name);
        a.tom();
        Console.WriteLine(a.Fname);
    }
}
