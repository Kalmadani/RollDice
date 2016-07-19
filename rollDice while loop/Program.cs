using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollDice_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Random rollDice = new Random();

            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6)
            {
                attempt = rollDice.Next(1, 7);
                Console.WriteLine("Jason rolled a " + attempt);
                numberOfAttempts++;
            }

            Console.WriteLine("It took Jason  " + numberOfAttempts + " trys to roll a six");
            Console.ReadKey();
            Console.WriteLine();
            goto start;


        }
    }
}
