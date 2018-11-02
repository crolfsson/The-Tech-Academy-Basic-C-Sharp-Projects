using System;
using System.Collections.Generic;

namespace ArrayList_Drill
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("ArrayList Drill");

            Console.WriteLine("\n");

            //STRING ARRAY

            string[] array1 = { "Episode IV", "Episode V", "Episode VI", "Episode III", "Epidose II", "Episode I" };

            Console.WriteLine("What is your favorite Star Wars movie? (Enter the movie episode with Roman numeral.  i.e Episode I)");
            string value = Console.ReadLine();
            int position = Array.IndexOf(array1, value);

            if (position == 0 || position == 1 || position == 2)
            {
                Console.WriteLine("You have great taste in Star Wars movies!  That would be no. {0} on my list.", position +1);
            }
            else if (position == 3 || position == 4 || position == 5)
            {
                Console.WriteLine("Your taste in Star Wars movies is criminal! That would be no. {0} on my list.  For shame!", position +1);
            }
            else 
            {
                Console.WriteLine("What's wrong with you? Enter a valid value.");
            }

            Console.ReadLine();

            //INT ARRAY
            int[] array2 = { 4, 1, 3, 2 };

            Console.WriteLine("Choose a number between 1 and 4 to find the index of the array:");
            //string input = Console.ReadLine();
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int numPosition = Array.IndexOf(array2, inputNum);


            if (numPosition == 0 || numPosition == 1 || numPosition == 2 || numPosition == 3)
            {
                Console.WriteLine("You chose index {0}.", numPosition);
            }
            else if (numPosition != 0 || numPosition != 1 || numPosition != 2 || numPosition != 3)
            {
                Console.WriteLine("There is no index for this value.");
            }
            else
            {
                Console.WriteLine("Dude, that is not a valid value.");
            }
            Console.ReadLine();

            //LIST OF STRINGS
 
        }
    }
}
