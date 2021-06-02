using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Pakistan_International_Airlines
{
    public partial class FlightStatus : Form
    {
        public FlightStatus()
        {
            InitializeComponent();
        }
        

        private void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            CheckFlightstatus check = new CheckFlightstatus();
            check.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void FlightStatus_Load(object sender, EventArgs e)
        {
            monthCalendar1.SetSelectionRange(DateTime.UtcNow ,DateTime.MaxValue);
           // monthCalendar1.MinDate = DateTime.UtcNow;
        }
    }
}
