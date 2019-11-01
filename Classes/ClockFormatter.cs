using System.Text;

namespace BerlinClock
{
    /// <summary>
    /// Build the formatted string for the given second lamp and the 4 rows for hours and minutes
    /// </summary>
    public static class ClockFormatter
    {
        public static string Format(string convertedSecondLamp, ClockRows clockRows)
        {
            StringBuilder sbResult = new StringBuilder();

            sbResult.AppendLine(convertedSecondLamp);
            sbResult.AppendLine(clockRows.HourFirstRow);
            sbResult.AppendLine(clockRows.HourSecondRow);
            sbResult.AppendLine(clockRows.MinuteFirstRow);
            sbResult.Append(clockRows.MinuteSecondRow);

            return sbResult.ToString();
        }
    }
}