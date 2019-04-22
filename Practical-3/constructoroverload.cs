using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructoroverload
{
    class StudentData
    {
        String branch, name;
        int enrollment;

        public StudentData()
        {

        }
        public StudentData(String name)
        {
            this.name = name;
            Console.WriteLine("{0}", this.name);
        }
        public StudentData(String name, int enrollment)
        {
            this.name = name;
            this.enrollment = enrollment;
            Console.WriteLine("{0} {1}",this.name,this.enrollment );
        }
        public StudentData(String name, int enrollment, String branch)
        {
            this.name = name;
            this.enrollment = enrollment;
            this.branch=branch;
            Console.WriteLine("{0} {1} {2}", this.name, this.enrollment,this.branch);

        }
    }
    class Overload

    {
       
        static void Main(string[] args)
        {
            StudentData s1 = new StudentData("shyam");
           ;
            StudentData s2 = new StudentData("shyam",63);
            StudentData s3 = new StudentData("shyam", 63,"CE");
            Console.ReadLine();
        }

    }
}
