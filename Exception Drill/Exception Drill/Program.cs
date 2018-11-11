using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50 };
            try
            {
                Console.WriteLine("Enter a number to divide each integer in the list: ");
                int divNum = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < myList.Count; i++)
                {
                    int result = myList[i] / divNum;
                    Console.WriteLine(myList[i] + " divided " + divNum + " equals " + result);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

            //Non-zero value: Input string as not in correct format.
            //Blank value: Input string as not in correct format.
            //String value: Input string as not in correct format.
            //Zero value: Attempted to divide by zero.
        }
    }
}
