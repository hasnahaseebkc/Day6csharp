using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public abstract class Vehicle
    {
        public abstract void display();
        protected string name;
        //abstract method
        public abstract string Name
        {
            get;
            set;
        }

        public abstract void calculate(double x);

    }

    public class Bus : Vehicle
    {
        
        //provide implementation of abstract method
        public override string Name
        {
            get { return name; }
            set { name = value; }   
        }

        public override void display()
        {
            Console.WriteLine("Bus");
        }

        public override void calculate(double x)
        {
            Console.WriteLine("Square Root is :" + Math.Sqrt(x));
        }

    }

    public class Car : Vehicle
    {
        //provide implementation of abstract method
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override void display()
        {
            Console.WriteLine("Car");
        }

        public override void calculate(double x)
        {
            Console.WriteLine("Square is :" + (x * x));
        }

    }

    public class Motorcycle : Vehicle
    {
        // provide implementation of abstract method
        public override string Name
        {
            get { return name; }
            set { name = value; }

        }

        public override void display()
        {
            Console.WriteLine("Motorcycle");
        }
        public override void calculate(double x)
        {
            Console.WriteLine("The cube is: " + (x * x * x));

        }
    }
    
    public class abstractClass
    {
        public static void Main()
        {
            Vehicle v;
            v = new Bus();
            Console.WriteLine(v.Name = "ABC");
            v.display();
            v.calculate(3);
            v = new Car();
            Console.WriteLine(v.Name = "XYZ");
            v.display();
            v.calculate(3);
            v = new Motorcycle();
            Console.WriteLine(v.Name = "012");
            v.display();
            v.calculate(3);

            Console.ReadKey();
        }
    }
}
