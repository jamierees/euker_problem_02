using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euker_problem_02
{
    class evenFibonacciNumbers
    {
        static void Main(string[] args)
        {
            int num1 = 1, num2 = 1, fib = 0, sum = 0;
            while (num1 < 4000000)
            {
                fib = num1 + num2;
                if (evenFibCheck(fib) == true)
                {
                    sum = sum + fib;
                }
                num1 = num2;
                num2 = fib;
            }
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadKey();
        }

        private static bool evenFibCheck(int num)
        {
            return ((num % 2) == 0);
        }
    }
}
