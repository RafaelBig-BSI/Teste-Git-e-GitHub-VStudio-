using System;

namespace Teste_Git_e_GitHub__VStudio_
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "João";
            string lastname = "Santos";

            Console.WriteLine("\n\nQual é o seu nome? " + "\n");
            Console.WriteLine("Meu nome é {0} {1}", firstname, lastname + "\n\n");

            int idade = 19;
            Console.WriteLine("\n\nQual é a sua idade? " + "\n");
            Console.WriteLine(
                "Meu idade é {0} ", idade + "\n\n");

            Console.ReadLine();
        }
    }
}
