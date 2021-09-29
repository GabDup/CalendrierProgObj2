using AppointementScheduler.Calendar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppointementScheduler.Controls
{
    public partial class ScheduleCalendarBox : UserControl
    {
        private List<CalendarEvent> calendarEvents = new List<CalendarEvent>();
        private ScheduleCalendarEventToolTip tooltipComponent = new ScheduleCalendarEventToolTip();
        private DateTime date;
        
        public DateTime Date 
        { 
            get { return date; }
            set 
            { 
                date = value;
                Refresh();
            } 
        }

        public List<CalendarEvent> CalendarEvents 
        {
            get { return calendarEvents; } 
            set 
            { 
                calendarEvents = value;
                Refresh();
            }
        }

        public ScheduleCalendarBox()
        {
            InitializeComponent();
            tooltipComponent.StartPosition = FormStartPosition.Manual;
        }

        private void ScheduleCalendarBox_Load(object sender, EventArgs e)
        {
            DisplayDayNumber();
            DisplayCalendarEvents();
        }

        public override void Refresh()
        {
            DisplayDayNumber();
            DisplayCalendarEvents();
            base.Refresh();
        }

        private void DisplayDayNumber()
        {
            int defaultDateYear = 0001;

            if (Date.Year == defaultDateYear)
            {
                lblDay.Text = "";
                this.Enabled = false;
            }
            else
            {
                lblDay.Text = Date.Day.ToString();
            }
        }

        private void DisplayCalendarEvents()
        {
            int eventCpt = 0;
            eventsPanel.Controls.Clear();

            foreach (var calendarEvent in calendarEvents)
            {
                Panel eventPanel = CreateEventPanel(calendarEvent, eventCpt);
                Label eventLabel = CreateEventLabel(calendarEvent);

                eventPanel.Controls.Add(eventLabel);
                eventsPanel.Controls.Add(eventPanel);

                eventCpt++;
            }
        }

        private Label CreateEventLabel(CalendarEvent calendarEvent)
        {
            Label eventLabel = new Label();
            string eventName = calendarEvent.Name;
            string startTime = calendarEvent.Start.ToShortTimeString();

            if (eventName.Length > 10)
            {
                eventName = eventName.Substring(0, 10);
                eventName += "...";
            }

            eventLabel.Text = $"{eventName} {startTime}";
            eventLabel.ForeColor = Color.White;
            eventLabel.AutoSize = true;
            eventLabel.Font = new Font(eventLabel.Font.Name, 12);
            eventLabel.MouseHover += GetEventLabelMouseHover(calendarEvent);
            eventLabel.MouseLeave += EventLabel_MouseLeave;

            return eventLabel;
        }

        private Panel CreateEventPanel(CalendarEvent calendarEvent, int eventCpt)
        {
            Panel eventPanel = new Panel();
            eventPanel.Width = Width - 8;
            eventPanel.AutoSize = false;
            eventPanel.Height = 20;
            eventPanel.BackColor = calendarEvent.EventColor;
            eventPanel.Padding = new Padding(3, 3, 3, 3);
            eventPanel.Margin = new Padding(3, 3, 3, 3);
            eventPanel.Location = new Point(0, (eventCpt * (eventPanel.Height + eventPanel.Margin.Bottom)) + eventPanel.Margin.Top);

            return eventPanel;
        }

        private EventHandler GetEventLabelMouseHover(CalendarEvent calendarEvent)
        {
            return (s, e) =>
            {
                CalendarTooltipEventArgs eventArgs = new CalendarTooltipEventArgs(calendarEvent);
                EventLabel_MouseHover(s, eventArgs);
            };
        }

        private void EventLabel_MouseHover(object sender, CalendarTooltipEventArgs e)
        {
            Control control = (Control)sender;
            tooltipComponent.CalendarEvent = e.CalendarEvent;
            tooltipComponent.DesktopLocation = control.PointToScreen(Point.Empty);
            tooltipComponent.Location =  new Point(tooltipComponent.Location.X + Width,tooltipComponent.Location.Y);
            tooltipComponent.Refresh();
            tooltipComponent.Show();
        }

        private void EventLabel_MouseLeave(object sender, EventArgs e)
        {
            tooltipComponent.Hide();
        }

        private class CalendarTooltipEventArgs : EventArgs
        {
            public CalendarEvent CalendarEvent { get; }

            public CalendarTooltipEventArgs(CalendarEvent calendarEvent)
            {
                CalendarEvent = calendarEvent;
            }
        }
    }
}
