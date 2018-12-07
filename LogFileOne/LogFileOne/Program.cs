using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogFileOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Log File One Drill");

            Console.Write("Please enter a number between 1 and 100:  ");
            string text = Console.ReadLine();
            File.WriteAllText("C:\\Users\\rolfsson\\Desktop\\TTA\\C and NET\\Logs\\logdrill.txt", text);
            string file = File.ReadAllText("C:\\Users\\rolfsson\\Desktop\\TTA\\C and NET\\Logs\\logdrill.txt");
            Console.WriteLine(file);
            Console.ReadLine();
        }
    }
}
