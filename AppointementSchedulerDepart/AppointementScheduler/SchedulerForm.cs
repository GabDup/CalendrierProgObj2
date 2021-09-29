using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppointementScheduler
{
    public partial class SchedulerForm : Form
    {
        public SchedulerForm()
        {
            InitializeComponent();
        }

        private void SchedulerForm_Load(object sender, EventArgs e)
        {
            //Exemple d'utilisation
            scheduleCalendar.AddEvent("Dîner avec Martin", new DateTime(2021, 09, 27, 12, 0, 0), 30, Color.FromArgb(11,128,67));
            scheduleCalendar.AddEvent("Garderie", "Aller chercher Antoine à la garderie.", new DateTime(2021, 09, 27, 15, 0, 0), 120, Color.DodgerBlue);
        }

        private void btnAddAppointement_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelAppointement_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerFile_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayAllCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
