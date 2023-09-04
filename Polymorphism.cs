using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    //method overloading
    internal class Calculation
    {
        public void addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void addition(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void addition(double a, double b, double c)
        {
            Console.WriteLine(a + b + c);
        }
    }

    //method overriding
    internal class Beast
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    internal class Cat : Beast
    {
        public override void makeSound()
        {
            Console.WriteLine("cat sounds meow meow");
        }
    }

    internal class Pig : Beast
    {
        public override void makeSound()
        {
            Console.WriteLine("pig sounds drrr drrrr");
        }
    }
    

}
