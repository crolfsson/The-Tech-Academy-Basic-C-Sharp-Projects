using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception One Drill");
            Console.WriteLine("\n");


            Console.Write("Please enter your age:  ");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                int birthYear = DateTime.Now.Year - (age);
                if (age > 0)
                {
                    Console.WriteLine("Wow!  You were born in {0}.  You are aging gracefully!", birthYear);
                }
                else
                {
                    throw new AgeException();
                }

            }
            catch (AgeException)
            {
                Console.WriteLine("Please enter a value greater than zero.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Sytem Error.  Please enter a valid value.");
                Console.ReadLine();
                return;
            }
        }
    }
}
