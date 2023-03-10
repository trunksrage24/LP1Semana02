using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;
            Console.WriteLine("insert question: ");
            question = Console.ReadLine();
            response = question switch
                {
                    "how are you" => "im fine, thank you",
                    "whats your name?" => "grandpa",
                    "What's your mission?"=> "Destroy mankind!",
                    _ => "You got me, I'm not THAT smart!",
                };
            while (question = switch)
            {
                // Responder adequadamente
                Console.WriteLine(response);
            }

        }
    }
}
