using System;

namespace reiztechproject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag1 = 0;
            int flag2 = 0;
            int hours = 0;
            int minutes = 0;
            bool hours_input;
            bool minutes_input; 

            while (flag1 == 0)
            {
                Console.WriteLine("Input hours: ");
                hours_input = int.TryParse(Console.ReadLine(), out hours);
                if (!hours_input) Console.WriteLine("Invalid value entered");
                else if (hours>23 || hours<0) Console.WriteLine("Valid hours is between 0 and 23");
                else flag1 = 1;
                
            }
            //------------------
            while(flag2 == 0)
            {
                Console.WriteLine("Input minutes: ");
                minutes_input = int.TryParse(Console.ReadLine(), out minutes);
                if (!minutes_input) Console.WriteLine("Invalid value entered");
                else if (minutes > 59 || minutes<0) Console.WriteLine("Valid minutes is between 0 and 59");
                else flag2 = 1;
            }
            double i = Clock.calcAngle(hours, minutes);
            Console.WriteLine("Output angles: "+i);

        }
    }
}
