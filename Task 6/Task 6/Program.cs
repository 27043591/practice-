using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 3, temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("before swapping");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("After swapping");
            Console.WriteLine("A = " + b);
            Console.WriteLine("B = " + a);
            Console.ReadLine();
        }
    }
}
