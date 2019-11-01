namespace BerlinClock.Tests
{
    public class ExpectedResults
    {
        public const string MidnightAt00_00Lamps = 
@"Y
OOOO
OOOO
OOOOOOOOOOO
OOOO";

        public const string MiddelAfternoonLamps = 
@"O
RROO
RRRO
YYROOOOOOOO
YYOO";

        public const string JustBeforeMidnightLamps = 
@"O
RRRR
RRRO
YYRYYRYYRYY
YYYY";

        public const string MidnightAt24_00Lamps = 
@"Y
RRRR
RRRR
OOOOOOOOOOO
OOOO";
    }
}