namespace BerlinClock
{
    /// <summary>
    /// Responsible for validating a given time represented in string format
    /// </summary>
    public static class TimeValidator
    {
        public static bool IsTimeValid(string aTime)
        {
            if (string.IsNullOrWhiteSpace(aTime))
            {
                return false;
            }

            //TODO: use Regex for further enhancements...
            //For now, use simple split operator
            string[] parts = aTime.Split(":".ToCharArray());
            if (parts.Length != 3)
            {
                return false;
            }
            else
            {
                // Ensure hours, minutes and seconds are valid
                int hour, minute, second;
                if (!int.TryParse(parts[0], out hour))
                {
                    return false;
                }
                if (!int.TryParse(parts[1], out minute))
                {
                    return false;
                }
                if (!int.TryParse(parts[2], out second))
                {
                    return false;
                }

                if (hour > 24 || hour < 0)
                {
                    return false;
                }
                if (minute > 59 || minute < 0)
                {
                    return false;
                }
                if (second > 59 || second < 0)
                {
                    return false;
                }
            }

            // If reach here, we can assume it is a valid time
            return true;
        }
    }
}