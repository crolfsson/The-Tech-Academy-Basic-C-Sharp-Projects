using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_While_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean Comparisons and WHILE Loops:  Halloween Edition");
            Console.WriteLine("\n");

            //WHILE LOOP
            Console.WriteLine("How many victims were there in the first Friday the 13th movie?");
            int victimsDead = Convert.ToInt32(Console.ReadLine());

            while (victimsDead != 10)
            {
                Console.WriteLine("You obviously don't know your Friday the 13th trivia.  Try again slacker.");
                Console.WriteLine("How many victims were there in the first Friday the 13th movie?");
                victimsDead = Convert.ToInt32(Console.ReadLine());
            }

            //DO WHILE LOOP
            Console.WriteLine("How many victims were there in the first Halloween movie?");
            int victimsHalloween = Convert.ToInt32(Console.ReadLine());
            bool halloweenVictims = victimsHalloween == 7;

            do
            {
               switch (victimsHalloween)
               {
                    case 7:
                        Console.WriteLine("Correct! You know your Halloween trivia.");
                        halloweenVictims = true;
                        break;
                    default:
                        Console.WriteLine("You obviously don't know your Halloween trivia.  Try again slacker!");
                        Console.WriteLine("How many victims were there in the first Halloween movie?");
                        victimsHalloween = Convert.ToInt32(Console.ReadLine());
                        break;
               }
            }
            while (!halloweenVictims); 
            Console.ReadLine();
        }
    }
}
