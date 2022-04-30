using System;

namespace InterfaceDemo
    // Interfaces are like contracts, where a class that implements an interface agrees to provide implementation for all
    // objects defined by that interface. this means an interface will contain the contract terms, methods and properties
    // but how we implement them is up to the class that implements the inteface.
    // interfaces cannot contains implementation.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating objects.
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            //Comparing their duration.
            Console.WriteLine(t1.Equals(t2));
        }
    }
}