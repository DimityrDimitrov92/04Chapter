using System;

namespace _12Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 13. Напишете програма, която пресмята сумата (с точност
             * до 0.001): 1/2 + 1/3 + 1/4 + 1/5 + ...
             */
            Console.WriteLine(
               "Task 13: Sum reciprocal numbers");

            double x, sum = 0.0;
            int n = 2;

            do
            {
                x = 1.0 / n;
                sum += x;
                Console.Write(
                   "...+1/{0,-4}={1,7:f4}; ", n++, sum);
            }
            while (x > 0.001);
            Console.WriteLine();
            Console.WriteLine("Sum = {0:f4}; ", sum);

        }
    }

}

