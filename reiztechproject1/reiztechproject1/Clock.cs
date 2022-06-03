using System;


namespace reiztechproject1
{
    internal class Clock
    {
        static public double calcAngle(int h, int m)
        {
            //check input
            if (h < 0 || m < 0 || m >= 60)
            {
                Console.Write("Wrong input");
                return -1; 
            }
            if (h == 12) h = 0;
            if (h > 12)
            {
                h = h - 12;
            }
            
            double hour_angle = (0.5 * (h * 60 + m));
            double minute_angle = (6 * m);

            double angle = Math.Abs(hour_angle - minute_angle);

            angle = Math.Min(360 - angle, angle);

            return angle;
        }
    }
}
