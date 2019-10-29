using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drawing_Circle;
namespace DrawCircle
{
    class Program
    {
        public static void Main(string[] args)
        {
            Circle c1 = new Circle();

            Console.WriteLine("The circle has radius of {0} and area of {1}", c1.GetRadius(), c1.getArea());
            
            Circle c2 = new Circle();
            Console.WriteLine("The circle has radius of {0} and area of {1}", c2.GetRadius(), c2.getArea());
            
            Circle c3 = new Circle(3, "Orange");
            Console.WriteLine("The circle has radius of {0} and area of {1}", c3.GetRadius(), c3.Color);

            Console.WriteLine(c3.ToString());

        }
    }
}
