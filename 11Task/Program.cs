using System;

namespace _11Task
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum1 = 0;
            decimal sum2 = 1;
            decimal sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum = sum1 + sum2;
                sum1 = sum2;
                sum2 = sum;
                Console.WriteLine(sum);
            }

        }
    }
}
