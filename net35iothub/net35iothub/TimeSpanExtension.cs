using System;

namespace net35iothub
{
    public static class TimeSpanExtension
    {
        public static double TotalSeconds(this TimeSpan timeSpan)
        {
            return timeSpan.Ticks * 1E-07;
        }

        public static double TotalMilliseconds(this TimeSpan timeSpan)
        {
            double num = timeSpan.Ticks * 0.0001;
            if (num > Int64.MaxValue)
            {
                return Int64.MaxValue;
            }
            if (num < Int64.MinValue)
            {
                return Int64.MinValue;
            }
            return num;
        }

        public static TimeSpan FromMilliseconds(double value)
        {
            return new TimeSpan((long)(value * 1E+04));
        }
    }
}
