﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverloading
{
    class Vector
    {
        public int x, y, z;
        public Vector()
        { }

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

    }




    class Program
    {
        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(Vector a, Vector b)
        {
            Vector temp = new Vector();
            temp.x = a.x + b.x;
            temp.y = a.y + b.y;
            temp.z = a.z + b.z;

            Console.WriteLine("{0} {1} {2}", temp.x, temp.y, temp.z);

        }
        public void add(int[,] x, int[,] y)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = x[i, j] + y[i, j];

                    Console.Write(result[i, j] + " ");
                }

                Console.WriteLine();
            }

        }


        static void Main(string[] args)
        {

            Program p = new Program();

            p.add(10, 20);
            Vector a = new Vector(1, 2, 3);
            Vector b = new Vector(4, 5, 6);
            p.add(a, b);

            int[,] x = new int[3, 3];

            Console.Write("Enter first Matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            int[,] y = new int[3, 3];
            Console.Write("Enter secoond Matrix");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    y[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            p.add(x, y);
            Console.ReadLine();
        }




    }
}
