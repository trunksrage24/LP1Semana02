using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main()
        {
            //input values for high and radius
            Console.WriteLine("enter high value: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter radius value: ");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.Pi;
            //calc volume
            double V = pi * Math.Pow(r,2) * a;
            Console.WriteLine("your cylinder volume is: " + V);
            //calc surface
            double S = 2 * pi * r * (r + a);
            Console.WriteLine("your cylinder surface is: " + S);
        }
    }
}