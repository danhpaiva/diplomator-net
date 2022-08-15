namespace Diplomator
{
    public class Calculate
    {
        public static string CalculateDays(DateTime dateUniversity, DateTime dateToday)
        {
            var days = dateToday.Date - dateUniversity;
            return days.Days.ToString();
        }
    }
}
