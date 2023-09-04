using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public class Animal
    {
        public string name = "Lion";
        public void bark()
        {
            Console.WriteLine("Lion is roaring");
        }
    }

    public class Dog : Animal
    {
        public void eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }

    public class BabyDog : Animal
    {
        public void run()
        {
            Console.WriteLine("Baby dog is Running");
        }
    }

}
