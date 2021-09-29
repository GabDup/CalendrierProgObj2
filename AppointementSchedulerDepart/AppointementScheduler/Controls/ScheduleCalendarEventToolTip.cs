using AppointementScheduler.Calendar;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppointementScheduler.Controls
{
    public partial class ScheduleCalendarEventToolTip : Form
    {
        public CalendarEvent CalendarEvent { get; set; }

        public ScheduleCalendarEventToolTip()
        {
            InitializeComponent();
        }

        private void ScheduleCalendarEventToolTip_Load(object sender, EventArgs e)
        {
            LoadEventInfo();
        }

        public override void Refresh()
        {
            LoadEventInfo();
            base.Refresh();
        }

        private void LoadEventInfo()
        {
            if (CalendarEvent != null)
            {
                lblEventName.Text = CalendarEvent.Name;
                lblEventName.ForeColor = Color.FromArgb(50, 50, 50);
                lblDateTime.Text = $"{CalendarEvent.Start.ToLongDateString()} - {CalendarEvent.Start.ToShortTimeString()} à {CalendarEvent.End.ToShortTimeString()}";
                lblDateTime.ForeColor = Color.FromArgb(75, 75, 75);
                lblDescription.Text = CalendarEvent.Description;
                lblDescription.ForeColor = Color.FromArgb(125, 125, 125);
            }
            else
            {
                Visible = false;
            }
        }
    }
}
