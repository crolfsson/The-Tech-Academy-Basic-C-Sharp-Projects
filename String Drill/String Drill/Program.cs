using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Drill:  Halloween Edition");
            Console.WriteLine("\n");

            //CONCATENATE THREE STRINGS
            string title1 = "A Nightmare";
            string title2 = "on";
            string title3 = "Elm Street";

            title2 = " " + title2.Trim();
            title3 = " " + title3.Trim();

            Console.WriteLine("Freddy Krueger is the burnt serial killer in the film series {0}.", string.Concat(string.Concat(title1, title2), title3));

            Console.WriteLine("\n");

            //STRING TO UPPERCASE
            string arms = "upper";
            arms = arms.ToUpper();

            Console.WriteLine("LeatherFace needs plenty of {0} arm strength to swing that chainsaw around.", arms);

            Console.WriteLine("\n");

            //STRINGBUILDER
            StringBuilder builder = new StringBuilder();
            builder.Append("\"Alright you Primitive screwheads, listen up!");
            builder.AppendLine();
            builder.Append("You see this?");
            builder.AppendLine();
            builder.Append("This... is my BOOMSTICK!");
            builder.AppendLine();
            builder.Append("The twelve-gauge double-barreled Remington.");
            builder.AppendLine();
            builder.Append("S-Mart's top of the line.");
            builder.AppendLine();
            builder.Append("You can find this in the sporting goods department.");
            builder.AppendLine();
            builder.Append("That's right, this sweet baby was made in Grand Rapids, Michigan.\"");

            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
