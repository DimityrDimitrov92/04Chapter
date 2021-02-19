using System;

namespace _08Task
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal result;
            Console.Write("Enter first number : ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.Write("Enter third number : ");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.Write("Enter fourth number : ");
            decimal d = decimal.Parse(Console.ReadLine());
            Console.Write("Enter fifth number : ");
            decimal e = decimal.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                result = a;
            }
            else if (b > a && b > c && b > d && b > e)
            {
                result = b;
            }
            else if (c > a && c > b && c > e && c > d)
            {
                result = c;
            }
            else if (d > a && d > b && d > c && d > e)
            {
                result = d;
            }
            else
            {
                result = e;
            }
            Console.WriteLine(result);
        }
    }
}
