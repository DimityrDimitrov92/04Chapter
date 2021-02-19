using System;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the radius of the circle : ");
            double r = double.Parse(Console.ReadLine());
            const double pi = 3.1415926535;
            Console.WriteLine($"The face of the circle with radius {r} is = {pi*(r*r)} ");


        }
    }
}
