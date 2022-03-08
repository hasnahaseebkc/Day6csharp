using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    //An interface is a completely "abstract class", which can only contain abstract methods and properties

    interface IFirstInterface
    {
        string Name { get; set; }
        void myMethod();    //interface method

    }

    interface ISecondInterface
    {
        void myOtherMethod();    //interface method

    }

    interface IThirdInterface
    {
        void myOtherMethod1();    //interface method
    }

    //Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface, IThirdInterface
    {
        public string Name { get; set; }

        public void myMethod()
        {
            Console.WriteLine("Interface1 text..");

        }

        public void myOtherMethod()
        {
            Console.WriteLine("Interface2 text..");

        }

        public void myOtherMethod1()
        {
            Console.WriteLine("Interface3 text..");

        }

    }
    class interfacesProgram
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.Name = "John Doe";
            myObj.myMethod();
            myObj.myOtherMethod();
            myObj.myOtherMethod1();
            Console.WriteLine(myObj.Name);

            Console.ReadKey();


        }
    }
}

//WHY DO WE NEED C# INTERFACE?
//BASICALLY WE HAVE UNDERSTOOD THAT THERE IS NO SPECIFIC FUNCTIONALITY INSIDE AN INTERFACE, IF IT IS SO, THEN WHY DO WE NEED INTERFACE?

//WHEN TO USE INTERFACE?

//SECURITY: When we have to hide some features and have to use those later.
//it is essential to hide a few details while only showing the details important to the user

//Multiple Inheritance: in C#, one class can inherit from a simple parent class, inheriting all its features.
//Multiple Inheritance is not supported in C# for the simple reason to not make C# complex.
//but with the use of an interface, multiple interfaces can be implemented into a single class.


//Advantages of C# Interface
//Below are some of the advantages given.

//1) One of the major advantages of Interface in C# is a better alternative to implement multiple inheritances.
//2) The interface enables the plug-and-play method.
//3) Complete Abstraction can be achieved by the implementation of Interface.
//4) Along with making our code easy to maintain, concept loose coupling can be achieved.
