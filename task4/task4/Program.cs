using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = 0;
            int N2 = 0;
            int N3 = 0;

            Console.WriteLine("please enter your first number ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your second number ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enetr a multiple");
            N3 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {


                Console.WriteLine("{0} * {1} = {2} ", i,  N3, (N3 * i));
               
              }
            Console.ReadLine();
        }
    }
}
