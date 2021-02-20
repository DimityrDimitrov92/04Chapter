using System;

namespace _10Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n number :  ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
               // i++;
                Console.WriteLine(i);
            }
        }
    }
}
