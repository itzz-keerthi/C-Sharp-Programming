//Basic C# program to demonstrate the use of functions

using System;

public class Program
{
    public static void Main(String[] args)
    {
        Program obj= new Program();
        obj.display("Keerthana!");
        obj.age(18);
    }
    void display(string message)
    {
        Console.WriteLine("Myself "+message);
    }
    void age(int input)
    {
        Console.WriteLine("Am " + input+" years old.");
    }
}
