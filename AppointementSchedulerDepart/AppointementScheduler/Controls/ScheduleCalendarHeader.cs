using AppointementScheduler.Calendar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppointementScheduler.Controls
{
    public partial class ScheduleCalendarHeader : UserControl
    {
        private MonthYear monthYear = new MonthYear(DateTime.Today.Month, DateTime.Today.Year);
        private int itemsWidth = 100;
        public int ItemsWidth 
        { 
            get 
            { 
                return itemsWidth; 
            } 
            set 
            { 
                itemsWidth = value;
                Refresh();
            }
        }
        public MonthYear MonthYear 
        { 
            get { return monthYear; }
            set 
            { 
                monthYear = value;
                Refresh();
            } 
        }

        public ScheduleCalendarHeader()
        {
            InitializeComponent();
        }

        private void ScheduleCalendarHeader_Load(object sender, EventArgs e)
        {
            LoadHeader();
        }

        public override void Refresh()
        {
            LoadHeader();
            base.Refresh();
        }

        private void LoadHeader()
        {
            headerPanel.Controls.Clear();

            for (int i = 1; i <= 7; i++)
            {
                DaysOfWeek daysOfWeek = new DaysOfWeek(i);
                Label label = new Label();
                string dayName = daysOfWeek.GetDayName();

                label.Text = dayName;
                label.Location = new Point((i - 1) * ItemsWidth, 10);
                label.Width = ItemsWidth;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font(label.Font.Name, 18, FontStyle.Bold);
                headerPanel.Controls.Add(label);
            }
        }
    }
}
