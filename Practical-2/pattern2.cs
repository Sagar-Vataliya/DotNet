using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pat2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //int a=Convert.ToInt32(s);
            Console.WriteLine("Enter number");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}