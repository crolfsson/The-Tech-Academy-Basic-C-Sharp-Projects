using System;
using System.Collections.Generic;

namespace ArrayList_Drill
{
    class Program
    {
        private static int inputValue1;

        static void Main()
        {
            Console.WriteLine("ArrayList Drill");

            Console.WriteLine("\n");

            //STRING ARRAY

            string[] array1 = { "A", "B", "C", "D", "E" };

            Console.WriteLine("Find the index of the entered value.  Enter a letter between A and E.  (Only enter a capital letter.");
            string value = Console.ReadLine();
            int position = Array.IndexOf(array1, value);

            if (position > 0 || position <= 4)
            {
                Console.WriteLine("The index of the entered value is {0}:", position);
            }
            else 
            {
                Console.WriteLine("What's wrong with you? Enter a valid value.");
            }

            Console.ReadLine();

            //INT ARRAY
            int[] array2 = { 4, 1, 3, 2 };

            Console.WriteLine("Choose a number between 1 and 4 to find the index of the array:");
            string input = Console.ReadLine();
            Int32.TryParse(input, out inputValue1);
            int numPosition = Array.IndexOf(array2, inputValue1);

            if (numPosition == 0 || numPosition == 1 || numPosition == 2 || numPosition == 3)//finds index
            {
                Console.WriteLine("You chose index {0}.", numPosition);
            }
            else if (!Int32.TryParse(input, out inputValue1))//anything other than an integer
            {
                Console.WriteLine("C'mon, man!  Enter a valid value.");
            }
            else
            {
                Console.WriteLine("Dude, that number ain't even an index.");
            }
            Console.ReadLine();


            //LIST OF STRINGS
            List<string> myList = new List<string>() { "A", "B", "C", "D" };

            Console.WriteLine("Choose a letter A, B, C, or D to find the index of the list:");
            string listValue = Console.ReadLine();
            int index = myList.IndexOf(listValue);

            if (index > 0 || index <= 3)
            {
                Console.WriteLine("You chose index {0}.", index);
            }
            else
            {
                Console.WriteLine("That number ain't even an index.");
            }

            Console.ReadLine();


        }
    }
}
