using System;
using System.Collections.Generic;
using System.Drawing;

namespace AppointementScheduler.Calendar
{
    public class CalendarEvents
    {
        private List<CalendarEvent> calendarEvents;

        public CalendarEvents()
        {
            calendarEvents = new List<CalendarEvent>();
        }

        public void AddEvent(string name, DateTime start, int lengthInMinutes, Color color)
        {
            AddEvent(name, string.Empty, start, lengthInMinutes, color);
        }

        public void AddEvent(string name, string description, DateTime start, int lengthInMinutes, Color color)
        {
            calendarEvents.Add(new CalendarEvent(name, description, start, lengthInMinutes, color));
        }

        public List<CalendarEvent> FindByDate(DateTime date)
        {
            List<CalendarEvent> calendarEventsOnDate = new List<CalendarEvent>();

            foreach (var calendarEvent in calendarEvents)
            {
                if(calendarEvent.Start.Date == date.Date)
                {
                    calendarEventsOnDate.Add(calendarEvent);
                }
            }

            return calendarEventsOnDate;
        }
    }
}
