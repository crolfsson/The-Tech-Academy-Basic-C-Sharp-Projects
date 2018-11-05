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

            string[] array1 = { "Chicago Bears", "Detroit Lions", "Greenbay Packers", "Minnesota Vikings" };

            Console.WriteLine("Enter a number between 0 and 3 to find out what NFL team is in the NFC North division:");
            string value = Console.ReadLine();

            if (Int32.TryParse(value, out int resultIndex1))
            {
                if (resultIndex1 >= 0 && resultIndex1 < array1.Length)
                {
                    string valueAtIndex = array1[resultIndex1];
                    Console.WriteLine("The {0} are in the NFC North division.", valueAtIndex);
                }
                else
                {
                    Console.WriteLine("The value entered is not between 0 and 3.");
                }
            }
            else
            {
                Console.WriteLine("What's wrong with you? Enter a valid value.");
            }

            Console.ReadLine();


            //INT ARRAY
            int[] array2 = { 1991, 1993, 1994, 1996, 1998 };

            Console.WriteLine("Enter a number between 0 and 4 to find out which year in the 90's Pearl Jam released a new album:");
            string valueTwo = Console.ReadLine();
            int Num;

            if (Int32.TryParse(valueTwo, out Num))
            {
                if (Num >= 0 && Num < array2.Length)
                {
                    int numAtIndex = array2[Num];
                    Console.WriteLine("Pearl Jam released a new record in {0}.", numAtIndex);
                }
                else
                {
                    Console.WriteLine("The value entered is not between 0 and 4.");
                }
            }
            else
            {
                Console.WriteLine("What's wrong with you? Enter a valid value.");
            }

            Console.ReadLine();


            //LIST OF STRINGS
            List<string> myList = new List<string>() { "Snickers", "100 Grand", "Butterfinger", "Milky Way", "Baby Ruth", "Heath"  };

            Console.WriteLine("Enter a number betwen 0 and 5 to find a candy bar in the list:");
            string listValue = Console.ReadLine();

            if (Int32.TryParse(listValue, out int listIndex))
            {
                if (listIndex >= 0 && listIndex < myList.Count)
                {
                    string listValueAtIndex = myList[listIndex];
                    Console.WriteLine("The {0} candy bar is in the list.", listValueAtIndex);
                }
                else
                {
                    Console.WriteLine("The value entered is not between 0 and 5.");
                }
            }
            else
            {
                Console.WriteLine("What's wrong with you? Enter a valid value.");
            }

            Console.ReadLine();


        }
    }
}
