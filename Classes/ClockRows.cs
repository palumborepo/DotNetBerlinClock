using System;

namespace BerlinClock
{
    /// <summary>
    /// Represents the four rows of the clock corresponding to the hours and minutes
    /// </summary>
    public class ClockRows
    {
        public ClockRows()
        {
            HourFirstRow = "OOOO";
            HourSecondRow = "OOOO";

            MinuteFirstRow = "OOOOOOOOOOO";
            MinuteSecondRow = "OOOO";
        }

        public string HourFirstRow { get; set; }

        public string HourSecondRow { get; set; }

        public string MinuteFirstRow { get; set; }

        public string MinuteSecondRow { get; set; }

        public override string ToString()
        {
            return $"{HourFirstRow}{Environment.NewLine}" +
                $"{HourSecondRow}{Environment.NewLine}" +
                $"{MinuteFirstRow}{Environment.NewLine}" +
                $"{MinuteSecondRow}";
        }
    }
}