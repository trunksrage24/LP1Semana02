using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //input number and character
            int number = int.Parse(args[0]);
            string character = args[1];
            for (int i = 0; i < number; i += 1)
            {
                for (int write = 0; write <= i; write += 1)
                {
                    Console.Write($"{character}");
                }
                Console.Write("\n");
            }
        }
    }
}
