using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main()
        {
            //input values for high and radius and calc volume
            Console.WriteLine("enter high value: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter radius value: ");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.1415926;
            double V = pi * Math.Pow(r,2) * a;
             Console.WriteLine("your cylinder volume is: " + V);
        }
    }
}
