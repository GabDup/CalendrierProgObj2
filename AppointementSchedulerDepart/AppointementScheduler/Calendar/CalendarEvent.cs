using System;
using System.Drawing;

namespace AppointementScheduler.Calendar
{
    [Serializable]
    public class CalendarEvent
    {
        public string Name { get; }
        public string Description { get; }
        public DateTime Start { get; }
        public int LengthInMinutes { get; }
        public DateTime End => Start.AddMinutes(LengthInMinutes);
        public Color EventColor { get; }

        public CalendarEvent(string name, string description, DateTime start, int lengthInMinutes, Color eventColor)
        {
            Name = name;
            Description = description;
            Start = start;
            LengthInMinutes = lengthInMinutes;
            EventColor = eventColor;
        }
    }
}
