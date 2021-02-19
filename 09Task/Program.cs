using System;

namespace _09Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter (n)5 number of numbers  ");
            int nNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nNumber; i++)
            {
                Console.Write($"Enter {i} number :");
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum of all number  =  {sum}");
        }
    }
}
