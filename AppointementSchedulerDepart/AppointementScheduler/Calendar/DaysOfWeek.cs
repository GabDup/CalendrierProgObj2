using System;

namespace AppointementScheduler.Calendar
{
    public class DaysOfWeek
    {
        private string[] daysOfWeek = { "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };

        public int DayNumber { get; }

        public DaysOfWeek(int dayNumber)
        {
            DayNumber = dayNumber;
        }

        public DaysOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    DayNumber = 1;
                    break;
                case DayOfWeek.Monday:
                    DayNumber = 2;
                    break;
                case DayOfWeek.Tuesday:
                    DayNumber = 3;
                    break;
                case DayOfWeek.Wednesday:
                    DayNumber = 4;
                    break;
                case DayOfWeek.Thursday:
                    DayNumber = 5;
                    break;
                case DayOfWeek.Friday:
                    DayNumber = 6;
                    break;
                case DayOfWeek.Saturday:
                    DayNumber = 7;
                    break;
                default:
                    throw new ArgumentNullException("Le jour de la semaine doit absolument être passé.");
            }
        }

        public string GetDayName()
        {
            return daysOfWeek[DayNumber - 1];
        }

    }
}
