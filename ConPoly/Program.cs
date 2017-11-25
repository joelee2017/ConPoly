using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPoly
{
    class Animal
    {
        public virtual void display()
        {
            Console.WriteLine("Animal");
        }        
    }

    class Person : Animal
    {
        public override void display()
        {
            Console.WriteLine("Person");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Person per = new Person();
            ani.display();
            per.display();
            Console.WriteLine("=========================");
            ani = per;
            ani.display();
            Console.Read();
        }
    }
}
