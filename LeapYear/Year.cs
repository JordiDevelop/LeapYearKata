namespace LeapYear
{
    public class Year
    {
        public static bool IsLeap(int year)
        {
            if (year % 400 != 0)
            {
                return false;
            }
            return true;
        }
    }
}