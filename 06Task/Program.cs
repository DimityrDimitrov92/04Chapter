using System;

namespace _06Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestNumber;
            Console.Write("Enter first number : ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter first number : ");
            int secondNumber = int.Parse(Console.ReadLine());
            biggestNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine($"The biggest number from {firstNumber} and {secondNumber} its : {biggestNumber}");

        }
    }
}
