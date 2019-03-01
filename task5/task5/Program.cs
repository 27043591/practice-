using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("please enter radius of the circle");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * (radius * radius);
            Console.WriteLine(" the area of your cirlce is: {0:0.00}", area);
            Console.ReadLine();

        }


    }
}
