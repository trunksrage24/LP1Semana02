using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            //input arg and covert to int
            string argu = (args[0]);

            int x = int.Parse(argu);
            Console.WriteLine(argu);
            Console.WriteLine(" increment '++' after var x: " + x++);
            int y = --x;
            Console.WriteLine(" decrement '--' before var x: " + y);

        }
    }
}

