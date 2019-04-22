using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace P1
{
    class P1
    {
        static int j = 90;
      
        static void Main(string[] args)
        {
            Console.WriteLine("First Program");
            int i = 25;

            Console.WriteLine("Scope of Variables.\n1:");
            
            for (int  j = 0; j < 2; j++) 
            {
               
                Console.Write("{0} {1}\n", j, P1.j);
            }
            Console.WriteLine("2:");
            for (int k = 0; k < 3; k++)
            {
                Console.Write("{0} ", k);
            }
            Console.Write("\n");
        
            for (int k = 3; k > 0; k--)
            {
                Console.Write("{0} ", k);
            }



            Console.WriteLine("Constants");

            const int valConst = 100; 
            Console.WriteLine("{0} is constant value", valConst);
            //const int valConst2 = valConst + 9;
            //Console.WriteLine("Another Constant: {0}", valConst2);



            Console.WriteLine("\nPredefined Data Types\n\nValue Types and Reference Types");
           
            int vali = 2, valj = vali;
            Console.WriteLine("vali is: {0} and valj is: {1}", vali, valj);
            valj = 90;
            Console.WriteLine("vali is: {0} and valj is: {1}", vali, valj);
           
            Vector x, y;
            x = new Vector();
            x.value = 3;
            y = x;
            Console.WriteLine("x is: {0} and y is:{1}", x.value, y.value);
            y.value = 234;
            Console.WriteLine("x is: {0} and y is:{1}", x.value, y.value);
            y = null;


            Console.WriteLine("\nInteger Types");
            sbyte sb = 33;
            short s = 33;
            int _i = 33;
            long l = 33L;
            //Unsigned Integers
            byte b = 33;
            ushort us = 33;
            uint ui = 33U;
            ulong ul = 33UL;
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", sb, s, _i, l, b, us, ui, ul);
            //Floating point types
            float f = 11.22334455F;
            double d = 11.2233445566778899;
            Console.Write("\nFloat and Double:\n");
            Console.WriteLine("{0} and \n{1}", f, d);
            //Decimal Type
            decimal dec = 111.222333444555666777888999M;
            Console.WriteLine("Decimal:\n{0}", dec);
            //Boolean
            Console.WriteLine("\nBoolean:");
            bool valBoolean = true;
            Console.WriteLine("Status: " + valBoolean);
            //Character
            Console.WriteLine("\nCharacter:\nSingle Quote \'");
            Console.WriteLine("Double Quote \"");
            Console.WriteLine("Back Slash \\");
            char charA = 'A';
            Console.WriteLine(charA);
            charA = '\0';
            Console.WriteLine("Now null: " + charA);
            Console.WriteLine("\a");
            Thread.Sleep(1000);
            Console.Beep(); //another notification sound


          
            object o1 = "Hi, I am an Object";
            object o2 = 34;
            string strObj = o1 as string;
            Console.WriteLine(strObj);
            Console.WriteLine(o1.GetHashCode() + " " + o1.GetType());
            Console.WriteLine(o2.GetHashCode() + " " + o2.GetType());
            Console.WriteLine(o1.Equals(o2));

          
            string s1, s2;
            s1 = "String 1";
            s2 = s1;
            Console.WriteLine("S1 is: {0} and s2 is {1}", s1, s2);
            s2 = "New String 1";
            Console.WriteLine("S1 is: {0} and s2 is {1}", s1, s2);
            s1 = "c:\\NewFolder\\Hello\\P1.cs";
            Console.WriteLine(s1);
            s1 = @"c:\NewFolder\Hello\P1.cs";
            Console.WriteLine(s1);
            s1 = @"We can also write 
               like this";
            Console.WriteLine(s1);

            bool isZero;
            Console.WriteLine("\nFlow Control: (if)\ni is " + i);
            if (i == 0)
            {
                isZero = true;
                Console.WriteLine("i is Zero");
            }
            else
            {
                isZero = false;
                Console.WriteLine("i is Non - zero");
            }

           
            Console.WriteLine("\nType in a string:");
            string input;
            input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("You typed in an empty string");
            }
            else if (input.Length < 5)
            {
                Console.WriteLine("The string had less than 5 characters");
            }
            else if (input.Length < 10)
            {
                Console.WriteLine("The string had at least 5 but less than 10 characters");
            }
            Console.WriteLine("The string was " + input);

            //Switch
            int integerA = 2;
            Console.WriteLine("\nSwitch:");

            switch (integerA)
            {
                case 1:
                    Console.WriteLine("integerA = 1");
                    break;
                case 2:
                    Console.WriteLine("integerA = 2");
                   
                    break;
                case 3:
                    Console.WriteLine("integerA = 3");
                    break;
                default:
                    Console.WriteLine("integerA is not 1, 2, or 3");
                    break;
            }


            WriteGreeting(TimeOfDay.Afternoon);
            Console.WriteLine("Argument is: {0}", args[0]);
        }
        public enum TimeOfDay
        {
            Morning = 0,
            Afternoon = 1,
            Evening = 2
        }
        static void WriteGreeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good morning!");
                    break;
                case TimeOfDay.Afternoon:
                    Console.WriteLine("Good afternoon!");
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Good evening!");
                    break;
                default:
                    Console.WriteLine("Hello!");
                    break;
            }
        }
    }

    public class Vector
    {
        public int value;
    }
}
        
