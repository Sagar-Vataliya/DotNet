using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace p4
{

    class StudentData
    {
        String name, branch;
        String enrollment;
        public StudentData()
        {
        }
        public StudentData(String name)
        {
            this.name = name;
            Console.WriteLine("{0} ", this.name);
        }

        public StudentData(String name, String enrollment)
        {
            this.name = name;
            this.enrollment = enrollment;
            Console.WriteLine("{0} {1}", this.name, this.enrollment);
        }
        public StudentData(String name, String enrollment, String branch)
        {
            this.name = name;
            this.enrollment = enrollment;
            this.branch = branch;
            Console.WriteLine("{0} {1} {2}", this.name, this.enrollment, this.branch);
        }

        public void print()
        {
            Console.WriteLine("{0} ", this.name);

        }





    }
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("p4.StudentData");
            Console.WriteLine("constructor");
            ConstructorInfo[] c = T.GetConstructors();
            foreach (ConstructorInfo constructor in c)
            {
                Console.WriteLine(constructor.ToString());
            }
            Console.WriteLine("Methods");
            MethodInfo[] m = T.GetMethods();
            foreach (MethodInfo method in m)
            {
                Console.WriteLine(method.ToString());
            }

            Console.ReadKey();
        }
    }
}
