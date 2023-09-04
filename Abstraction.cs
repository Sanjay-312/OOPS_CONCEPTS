using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concepts
{
    public abstract class Shape
    {
        public abstract void draw();

    }

    class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing square");
        }
    }

    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle");
        }

    }

    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing recatngle");
        }
    }




    interface Car
    {
       void maxSpeed();
    }

    public class Audi : Car
    {
       public void maxSpeed()
        {
            Console.WriteLine("audi max speed is 180kmph");
        }
    }

    public class Benz : Car
    {
        public void maxSpeed()
        {
            Console.WriteLine("benz max speed is 200kmph");
        }
    }

}
