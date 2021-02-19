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
            if (firstNumber > secondNumber)
            {
                biggestNumber = firstNumber;
                smallerNumber = secondNumber;
            }
            else
            {
                biggestNumber = secondNumber;
                smallerNumber = firstNumber;
            }
            for (int i = smallerNumber; i <= biggestNumber; i++)
            {
                if (i % 5 ==0)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }

        }
    }
}
