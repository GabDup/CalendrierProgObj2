using AppointementScheduler.Calendar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppointementScheduler.Controls
{
    public partial class ScheduleCalendar : UserControl
    {
        private MonthYear monthYear = new MonthYear(DateTime.Today.Month, DateTime.Today.Year);
        private CalendarEvents calendarEvents = new CalendarEvents();
        
        public MonthYear MonthYear 
        { 
            get { return monthYear; } 
            set 
            { 
                monthYear = value;
                Refresh();
            } 
        }

        public CalendarEvents CalendarEvents 
        { 
            get { return calendarEvents; } 
            set 
            { 
                calendarEvents = value;
                Refresh();
            }
        }

        public DateTime FirstDayOfMonth => new DateTime(monthYear.Year, monthYear.Month, 1);

        public ScheduleCalendar()
        {
            InitializeComponent();
        }

        public void AddEvent(string name, DateTime start, int lengthInMinutes, Color color)
        {
            calendarEvents.AddEvent(name, start, lengthInMinutes, color);
            Refresh();
        }

        public void AddEvent(string name, string description, DateTime start, int lengthInMinutes, Color color)
        {
            calendarEvents.AddEvent(name, description, start, lengthInMinutes, color);
            Refresh();
        }

        private void ScheduleCalendar_Load(object sender, EventArgs e)
        {
            DisplayCalendar();
        }

        private void DisplayTitle()
        {
            lblTitle.Text = $"{MonthYear.GetMonthName()} {MonthYear.Year}";
        }

        public override void Refresh()
        {
            DisplayCalendar();
            base.Refresh();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            var newFirstDayOfMonth = FirstDayOfMonth.AddMonths(-1);
            MonthYear = new MonthYear(newFirstDayOfMonth.Month, newFirstDayOfMonth.Year);
            DisplayCalendar();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var newFirstDayOfMonth = FirstDayOfMonth.AddMonths(1);
            MonthYear = new MonthYear(newFirstDayOfMonth.Month, newFirstDayOfMonth.Year);
            DisplayCalendar();
        }

        private int FindClosestMultiple(int baseNumber, int multiple)
        {
            while (baseNumber % multiple != 0)
            {
                baseNumber++;
            }

            return baseNumber;
        }

        private ScheduleCalendarHeader GetCalendarHeader()
        {
            ScheduleCalendarBox defaultCalendarBox = new ScheduleCalendarBox();
            ScheduleCalendarHeader calendarHeader = new ScheduleCalendarHeader();
            calendarHeader.ItemsWidth = defaultCalendarBox.Width;
            calendarHeader.MonthYear = MonthYear;
            return calendarHeader;
        }

        private Panel GetCalendarPanel(int positionY)
        {
            Panel boxedPanel = new Panel();
            boxedPanel.BorderStyle = BorderStyle.FixedSingle;
            boxedPanel.AutoSize = true;
            boxedPanel.Margin = new Padding(0, 0, 0, 0);
            boxedPanel.Padding = new Padding(0);
            boxedPanel.Location = new Point(0, positionY);

            return boxedPanel;
        }

        // Réusiner cette fonction pour un point boni.
        private void DisplayCalendar()
        {
            DisplayTitle();
            CalendarPanel.Visible = false;
            CalendarPanel.Controls.Clear();

            ScheduleCalendarHeader calendarHeader = GetCalendarHeader();
            Panel boxedPanel = GetCalendarPanel(calendarHeader.Height);
            
            DaysOfWeek daysOfWeek = new DaysOfWeek(FirstDayOfMonth.DayOfWeek);
            int daysInMonth = DateTime.DaysInMonth(MonthYear.Year, MonthYear.Month);
            int numberOfSquares = daysInMonth + daysOfWeek.DayNumber;
            int numberOfRows = FindClosestMultiple(numberOfSquares, 7) / 7;

            int firstDay = daysOfWeek.DayNumber;
            int totalCpt = 0;
            int dayCpt = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    ScheduleCalendarBox calendarBox = new ScheduleCalendarBox();
                    Point boxPosition = new Point(
                        j * calendarBox.Width,
                        i * calendarBox.Height
                    );
                    calendarBox.Location = boxPosition;
                    calendarBox.Padding = new Padding(0);
                    calendarBox.Margin = new Padding(0);

                    if (totalCpt + 1 >= firstDay && dayCpt < daysInMonth)
                    {
                        calendarBox.Date = FirstDayOfMonth.AddDays(dayCpt);
                        calendarBox.CalendarEvents = CalendarEvents.FindByDate(calendarBox.Date);
                        dayCpt++;
                    }

                    boxedPanel.Controls.Add(calendarBox);

                    totalCpt++;
                }
            }

            CalendarPanel.Controls.Add(calendarHeader);
            CalendarPanel.Controls.Add(boxedPanel);
            CalendarPanel.Visible = true;
        }
    }
}
