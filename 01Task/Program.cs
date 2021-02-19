using System;

namespace _01Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number : ");
          
            bool Test = int.TryParse(Console.ReadLine(), out int b);

            Console.Write("Enter Third number : ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        
        }
    }
}
