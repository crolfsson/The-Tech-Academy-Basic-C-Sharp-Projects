using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationLoopDrill
{
    class Program
    {
        private static int i;
        private static int l;
        private static string presfname;
        private static string item;
        private static int m;

        static void Main(string[] args)
        {
            Console.WriteLine("IterationLoop Drill");
            Console.WriteLine("\n");


            //ONE DIMENSIONAL STRING ARRAY:  2 LOOPS REQUIRED
            string[] myArray = { "A", "B", "C", "D", "E" };

            Console.WriteLine("Enter the name of a Peanuts character:");
            string peanutsInput = Console.ReadLine();
            Console.WriteLine("The text has been added to the array string:");

            for (int i = 0; i < myArray.Length; i++)//adds user's text to the string
            {
                myArray[i] = myArray[i] + peanutsInput;
            }
            for (int i = 0; i < myArray.Length; i++)//prints off each string of the array
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();


            //INFINITE LOOP AND EXECUTION
            string[] myArray2 = { "A", "B", "C", "D", "E" };

            Console.WriteLine("Enter the name of a Peanuts character:");
            string peanutsInput2 = Console.ReadLine();

            for (int i = 0; ; i++)//deleted array length argument
            {
                if (peanutsInput2 == "Marcie")
                {
                    Console.WriteLine("Marcie stops the infinite loop.");
                    break;
                }
                else
                {
                    Console.WriteLine("Infinite Loop " + peanutsInput2);
                }
            }
            Console.ReadLine();


            //COMPARISON LOOP "<" OPERATOR
            int[] tempNum = { 40, 42, 34, 32, 39, 33, 27 };

            //starts at item  0 index; loop keeps running through lenght of array; add 1 to next int
            for (int k = 0; k < tempNum.Length; k++)
            {
                if (tempNum[k] < 35)
                {
                    Console.WriteLine("A number in the array that is less than 35 will be displayed: " + tempNum[k]);
                }
            }
            Console.ReadLine();


            //COMPARISON LOOP "<=" OPERATOR
            int[] tempNum2 = { 40, 42, 34, 32, 39, 33, 27 };

            for (int k = 0; k < tempNum2.Length; k++)
            {
                if (tempNum2[k] <= 40)
                {
                    Console.WriteLine("A number in the array that less than or equal to 40 will be displayed: " + tempNum2[k]);
                }
            }
            Console.ReadLine();


            //STRING LIST UNIQUE ITEM SEARCH - BREAK EXECUTION
            List<string> myList = new List<string>() { "Bob", "Dash", "Helen", "Jack Jack", "Violet" };

            Console.WriteLine("Enter the first name of a member of the \"Incredible\" family to find the index:");
            string fname = Console.ReadLine();
            int index = myList.IndexOf(fname);

            for (int l = 0; l <= myList.Count; l++)
            {
                if (index >= 0 && index < myList.Count)
                {
                    Console.WriteLine("The index is {0}.", index);
                    break;
                }
                else
                {
                    Console.WriteLine("The value entered is not a Member of the Incredible family.");
                    break;
                }

            }
            Console.ReadLine();


            //STRING LIST - TWO IDENTICAL STRINGS
            List<string> presList = new List<string>() { "Ronald", "George", "Bill", "George", "Barack", "Donald" };
            bool isPres = false;

            Console.WriteLine("Enter the first name of a President between 1981 and 2018:");
            string presFname = Console.ReadLine();

            for (int m = 0; m < presList.Count; m++)
            {
                if (presFname == presList[m])
                {
                    isPres = true;
                    Console.WriteLine("The index is " + m);
                    Console.ReadLine();
                }
            }
            if (isPres == false)
            {
                Console.WriteLine("The entered value is NOT a President between 1981 and 2018.");
                Console.ReadLine();
            }


            //STRING LIST - TWO IDENTICAL STRINGS - FOR EACH LOOP
            List<string> lemList = new List<string>() { "lemons", "sugar", "water", "lemons" };
            var duplicates = new List<string>();

            foreach (string item in lemList)
            {
                if (!duplicates.Contains(item))
                {
                    duplicates.Add(item);
                    Console.WriteLine("There is a duplicate in the list.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("There is NOT a duplicate.");
                    Console.ReadLine();
                }
            }
            foreach (string dup in duplicates)
            {
                Console.WriteLine("The duplicate in the list is {0}.", dup);
                Console.ReadLine();
            }
            Console.WriteLine("Thanks to all the instructors that helped me out with this drill!  This was a beast!");
            Console.ReadLine();
        }
    }
}
