using System;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string ConvertTime(string aTime)
        {
            if (string.IsNullOrWhiteSpace(aTime))
            {
                throw new ArgumentNullException();
            }
            if (!TimeValidator.IsTimeValid(aTime))
            {
                throw new Exception("Please enter a valid time");
            }

            TimeInfo timeInfo = TimeInfoParser.Parse(aTime);

            // Convert second representation
            string convertedSecondLamp = (timeInfo.Second % 2 == 0) ? "Y" : "O";

            // Execute the conversion of hour and minute from normal representation into lamp representation
            ClockRows clockRows = ExecuteConversion(timeInfo);

            return ClockFormatter.Format(convertedSecondLamp, clockRows);
        }

        #region Helper methods

        /// <summary>
        /// Execute the conversion of hour and minute from normal representation into lamp representation
        /// </summary>
        /// <param name="timeInfo"></param>
        /// <returns></returns>
        private ClockRows ExecuteConversion(TimeInfo timeInfo)
        {
            ClockRows clockRows = new ClockRows();

            clockRows.HourFirstRow = ConvertHourFirstRow(timeInfo.Hour);
            clockRows.HourSecondRow = ConvertHourSecondRow(timeInfo.Hour);

            clockRows.MinuteFirstRow = ConvertMinuteFirstRow(timeInfo.Minute);
            clockRows.MinuteSecondRow = ConvertMinuteSecondRow(timeInfo.Minute);

            return clockRows;
        }

        private string ConvertHourFirstRow(int hour)
        {
            string result = "OOOO";

            if (hour >= 20)
            {
                result = "RRRR";
            }
            else if (hour >= 15)
            {
                result = "RRRO";
            }
            else if (hour >= 10)
            {
                result = "RROO";
            }
            else if (hour >= 5)
            {
                result = "ROOO";
            }

            return result;
        }

        private string ConvertHourSecondRow(int hour)
        {
            string result = "OOOO";

            int remainder = hour % 5;

            if (remainder > 0)
            {
                switch(remainder)
                {
                    case 1:
                        result = "ROOO";
                        break;
                    case 2:
                        result = "RROO";
                        break;
                    case 3:
                        result = "RRRO";
                        break;
                    case 4:
                        result = "RRRR";
                        break;
                    default:
                        throw new Exception("Unexpected value.");
                }
            }

            return result;
        }

        private string ConvertMinuteFirstRow(int minute)
        {
            string result = "OOOOOOOOOOO";

            if (minute >= 55)
            {
                result = "YYRYYRYYRYY";
            }
            else if (minute >= 50)
            {
                result = "YYRYYRYYRYO";
            }
            else if (minute >= 45)
            {
                result = "YYRYYRYYROO";
            }
            else if (minute >= 40)
            {
                result = "YYRYYRYYOOO";
            }
            else if (minute >= 35)
            {
                result = "YYRYYRYOOOO";
            }
            else if (minute >= 30)
            {
                result = "YYRYYROOOOO";
            }
            else if (minute >= 25)
            {
                result = "YYRYYOOOOOO";
            }
            else if (minute >= 20)
            {
                result = "YYRYOOOOOOO";
            }
            else if (minute >= 15)
            {
                result = "YYROOOOOOOO";
            }
            else if (minute >= 10)
            {
                result = "YYOOOOOOOOO";
            }
            else if (minute >= 5)
            {
                result = "YOOOOOOOOOO";
            }

            return result;
        }

        private string ConvertMinuteSecondRow(int minute)
        {
            string result = "OOOO";

            int remainder = minute % 5;

            if (remainder > 0)
            {
                switch (remainder)
                {
                    case 1:
                        result = "YOOO";
                        break;
                    case 2:
                        result = "YYOO";
                        break;
                    case 3:
                        result = "YYYO";
                        break;
                    case 4:
                        result = "YYYY";
                        break;
                    default:
                        throw new Exception("Unexpected value.");
                }
            }

            return result;
        }

        #endregion
    }
}