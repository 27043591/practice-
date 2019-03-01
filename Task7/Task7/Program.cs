using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RandomNum = new Random();
            int nums;
            Console.WriteLine(" please press any key ");
            Console.ReadLine();
            for (int i = 0; i < 1001; i++)
            {
                nums = RandomNum.Next(999, 10001);
                int num1 = RandomNum.Next(999, 10001);
                int num2 = RandomNum.Next(999, 10001);
                int num3 = RandomNum.Next(999, 10001);
                Console.WriteLine(" {0} {1} {2} {3} \n",nums, num1, num2, num3);
            }
            Console.ReadLine();
        }
    }
}
