using System;

namespace _07Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            bool isAnumber = false;

            do
            {
                Console.Write("Enter first number : ");
                isAnumber = int.TryParse(Console.ReadLine(), out a);
            } while (isAnumber != true) ;
            do
            {
                Console.Write("Enter second number : ");
                isAnumber = int.TryParse(Console.ReadLine(), out b);
            } while (isAnumber != true);
            do
            {
                Console.Write("Enter third number : ");
                isAnumber = int.TryParse(Console.ReadLine(), out c);
            } while (isAnumber != true);
            do
            {
                Console.Write("Enter fourth number : ");
                isAnumber = int.TryParse(Console.ReadLine(), out d);
            } while (isAnumber != true);
            do
            {
                Console.Write("Enter fifth number : ");
                isAnumber = int.TryParse(Console.ReadLine(), out e);
            } while (isAnumber != true);
            Console.WriteLine($"a = {a} , b = {b} , c = {c} , d = {d} , e = {e}\nResult = {a} + {b} + {c} + {d} + {e} = {a+b+c+d+e}");
        }
    }
}
