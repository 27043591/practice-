using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = 0;
            int N2 = 0;

            Console.WriteLine("please enter your first number");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your second number");
            N2 = int.Parse(Console.ReadLine());
            int Answer = N1 + N2;
            Console.WriteLine("{0} + {1} = {2}",N1 , N2, Answer);
            Console.ReadLine();
        }
    }
}
