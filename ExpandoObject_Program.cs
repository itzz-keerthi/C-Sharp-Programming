//To print the age of Daughter and father using ExpandoObject class

/* The ExpandoObject class refers to a class whose members can be explicitly added and removed from a application at runtime.
    It is important to note that the instance of ExpandoObject class are treated as dynamic object */
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Threading.Tasks;
public class Program
{
    public static void Main(string[] args)
    {
        dynamic daughter, father;
        daughter= new ExpandoObject();
        daughter.Name = "Keerthana";
        daughter.Age = 18;
        father = new ExpandoObject();
        father.Name = "Jothi Ramesh Kumar";
        father.Age = 45;
        father.Children = 2;
        WriteFamily(father);
        WriteFamily(daughter);
        Console.WriteLine("\n");
        Console.WriteLine("Press enter to quit...");
        Console.Read();
    }
    private static void WriteFamily(dynamic member)
    {
        Console.WriteLine("{0} is {1} years old.",member.Name,member.Age);
    }
}
