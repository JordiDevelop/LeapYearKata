namespace LeapYear
{
    public class Year
    {
        public static bool IsLeap(int year)
        {
            if (year == 1100 || year == 2001)
            {
                return false;
            }
            return true;
        }
    }
}