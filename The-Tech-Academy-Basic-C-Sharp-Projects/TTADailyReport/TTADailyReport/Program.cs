using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TTA_Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.Write("\n");

            Console.Write("What course are you on?: ");
            string courseName = Console.ReadLine();

            Console.Write("What page are you on?: ");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            bool helpNeed;
            Console.Write("Do you need help with anything?  Please answer \"True\" or \"False\".  ");
            helpNeed = bool.Parse(Console.ReadLine());

            Console.Write("Were there any positive experiences you would like to share?  Please give specifics: ");
            string courseExperience = Console.ReadLine();

            Console.Write("Is there any other feedback you would like to provide?  Please be specific: ");
            string courseFeedback = Console.ReadLine();

            Console.Write("How many hours did you study?: ");
            string studyHours = Console.ReadLine();
            int hoursNum = Convert.ToInt32(studyHours);

            Console.Write("\n\n");

            Console.Write("============================= DAILY REPORT SUMMARY =============================");

            Console.Write("\n");

            Console.WriteLine("Course Name: {0}", courseName);
            Console.WriteLine("Page Number: {0}", pageNumber);
            Console.WriteLine("Help Needed?: {0}", helpNeed);
            Console.WriteLine("Positive Experiences: {0}", courseExperience);
            Console.WriteLine("Feedback: {0}", courseFeedback);
            Console.WriteLine("Study Hours: {0}", studyHours);

            Console.Write("\n\n");

            Console.WriteLine("Thank you for your answers.  An Instructor will respond to thsi shortly.  Have a great day!");

            Console.ReadLine();
        }

        static Timer timer;
        static void schedule_Timer()
        {
            DateTime nowTime = DateTime.Now;
            DateTime scheduledTime = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, 18, 00, 0, 0); //[6pm and 30 minutes]
            if (nowTime > scheduledTime)
            {
                scheduledTime = scheduledTime.AddDays(1);
            }

            double tickTime = (double)(scheduledTime - DateTime.Now).TotalMilliseconds;
            timer = new Timer(tickTime);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            schedule_Timer();
        }
    }
}
