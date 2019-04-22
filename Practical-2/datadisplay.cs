using System;
public class userdata
{
    public static void Main()
    {
        string name, country;
        Console.Write("Enter Your Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Your Country: ");
        country = Console.ReadLine();
        Console.WriteLine("Hello " + name + " from country " + country);
        Console.ReadKey();
    }
}