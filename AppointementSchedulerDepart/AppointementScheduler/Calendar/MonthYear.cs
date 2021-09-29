namespace AppointementScheduler.Calendar
{
    public class MonthYear
    {
        private string[] monthNames = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

        public int Month { get; }
        public int Year { get; }

        public MonthYear(int month, int year)
        {
            Month = month;
            Year = year;
        }

        public string GetMonthName()
        {
            return monthNames[Month - 1];
        }
    }
}