using System;

namespace BerlinClock
{
    /// <summary>
    /// Parses the given time represented as a string and returns an instance of TimeInfo
    /// associated to the given time
    /// </summary>
    public static class TimeInfoParser
    {
        public static TimeInfo Parse(string aTime)
        {
            //TODO: use Regex for further enhancements...
            //For now, use simple split operator
            string[] parts = aTime.Split(":".ToCharArray());

            // Ensure hours, minutes and seconds are valid
            int hour, minute, second;
            if (!int.TryParse(parts[0], out hour))
            {
                throw new Exception("Failed to parse hour");
            }
            if (!int.TryParse(parts[1], out minute))
            {
                throw new Exception("Failed to parse minute");
            }
            if (!int.TryParse(parts[2], out second))
            {
                throw new Exception("Failed to parse second");
            }

            return new TimeInfo() 
            { 
                Hour = hour,
                Minute = minute,
                Second = second
            };
        }
    }
}