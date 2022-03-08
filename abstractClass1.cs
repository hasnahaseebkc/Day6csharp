using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //non abstract method in abstract class

    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();

        public void calculation(int units)
        {
            Console.WriteLine("BILL AMOUNT FOR " + units + " UNITS IS Rs.: " + rate * units);
            //Console.WriteLine(rate * units);

        }
    }

    class CommercialPlan : Plan
    {
        public override void getRate()
        {
            rate = 5.00;

        }
    }

    class DomesticPlan : Plan
    {
        public override void getRate()
        {
            rate = 2.50;
        }

    }

    class abstractClass1
    {
        static void Main(string[] args)
        {
            Plan p;
            Console.WriteLine("COMMERCIAL CONNECTION");
            p = new CommercialPlan();
            p.getRate();
            p.calculation(250);
            Console.WriteLine("\nDOMESTIC CONNECTION");
            p = new DomesticPlan();
            p.getRate();
            p.calculation(150);
            Console.ReadKey();


        }

    }
}
