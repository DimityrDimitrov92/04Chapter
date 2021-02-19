using System;

namespace _05Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestNumber;
            int smallerNumber;
            Console.Write("Enter first number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int secondNumber = int.Parse(Console.ReadLine());
            biggestNumber = Math.Max(firstNumber, secondNumber);
            smallerNumber = Math.Min(firstNumber, secondNumber);
            for (int i = smallerNumber; i <= biggestNumber; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }

        }
    }
}
