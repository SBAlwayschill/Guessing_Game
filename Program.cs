using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace Learning
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Guessing Game by Semantak";
            Random numbergen = new Random();

            int final_number = numbergen.Next(1, 11);

            Console.WriteLine("Welcome! what's your name?");
            string user = Console.ReadLine();
            Console.WriteLine("Hey " + user + " Let's play a guessing game.");
            Console.WriteLine("You have to pick a number between 1 - 10 and i will tell if it's high or low for hints \n You have only 3 attempts");
        
            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Console.WriteLine(" attempt no: " + attempt + " : Guess the number from 1 - 10! Try your luck kiddo!!");

                int ans = Convert.ToInt32(Console.ReadLine());

                if(ans > final_number)
                {
                    Console.WriteLine("You guessed too high baka!");
                }

                else if(ans < final_number)
                {
                    Console.WriteLine("You guessed to loww idiot");
                }

                else
                {
                    Console.WriteLine("You guessed it right idk how? but you won \n press any key to exit.");
                    break;
                }

                if(attempt == 3){
                    Console.WriteLine("Your attempts got finished LOLLLL \n Try next time ");
                    Console.WriteLine("The number was "+ final_number + "\n press enter to close");
                }

            }

            Console.ReadLine();

        }
    }
}
