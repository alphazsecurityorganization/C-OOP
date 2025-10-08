using System;
using System.IO; //need must

//File.SomeFileMethod(); 

//AppendText()
//Copy()
//Create()
//Delete()
//Exists()
//Replace()


// File
class Anon
{
    public static void Main(string[] args)
    {
        //Create a File & Write A Text 

        File.WriteAllText("adnan.txt","adnan is a good buy");

        //Create a File & Write Some Text Line

        string[] c = { "A","B","C","D","E" };

        File.WriteAllLines("ppp.txt", c);

        //Read a File

        string x = File.ReadAllText("ppp.txt");

        Console.WriteLine(x);
    }
}
