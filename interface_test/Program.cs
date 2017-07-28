using interface_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Chetah cheetah = new Chetah();
            cheetah.Hunt();
            cheetah.Eat();
            cheetah.Sleep();
            cheetah.Purr();
            Console.ReadLine();
        }
       

     
    }
    interface IPurrable
    {
        void Purr();
    }
    public class Chetah : Cat, IPurrable
    {
        public override void Eat()
        {
            Console.WriteLine($"The cheetah eats.");
        }

        public override void Hunt()
        {
            Console.WriteLine($"The cheetah hunts.");
        }

        public void Purr()
        {
            Console.WriteLine($"The cheetah has purr.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"The cheetah sleeps.");
        }
    }
}
