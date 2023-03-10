using System;

namespace GranpaPatternSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();
            response = question switch
            {
                "how are you" => "im fine, thank you",
                "whats your name?" => "grandpa",
                "What's your mission?"=> "Destroy mankind!",
                _ => "You got me, I'm not THAT smart!",
            };
            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
