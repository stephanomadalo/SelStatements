using System;

namespace SelStatements // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess what number I'm thinking of!");
            var r = new Random();
            var favNumber = r.Next(1, 1000);


            var userGuess = int.Parse(Console.ReadLine());


            if (userGuess >= favNumber)
            {
                Console.WriteLine("Number guess is too high :P");
            }
            else if (userGuess <= favNumber)
            {
                Console.WriteLine("Number guess is too low :3 ");
            }
            else 
            {
                Console.WriteLine("Nevermind >:[");
            }   
        }
    }
}