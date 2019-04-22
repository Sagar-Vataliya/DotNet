using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        class Car
        {
            protected String fuel, id, name;

        }

        class Maruti : Car
        {
            internal Maruti(String fuel, String id, String name)
            {
                this.fuel = fuel;
                this.id = id;
                this.name = name;
                Console.WriteLine("car id is {0} car name is {1} car fuel type {2}", this.id, this.name, this.fuel);
            }

        }
        class Mahindra : Car
        {
            internal Mahindra(String fuel, String id, String name)
            {
                this.fuel = fuel;
                this.id = id;
                this.name = name;
                Console.WriteLine("car id is {0} car name is {1} car fuel type {2}", this.id, this.name, this.fuel);

            }


        }



        static void Main(string[] args)
        {

            // Car car = new Car();
            Maruti maruti = new Maruti("petrol", "1", "maruti");
            Mahindra mahindra = new Mahindra("diesel", "2", "mahindra");
            Console.ReadKey();
        }
    }
}