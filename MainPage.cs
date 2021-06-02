using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakistan_International_Airlines
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private int ImageNumber = 1;
        private void SLider()
        {
            if(ImageNumber == 4)
            {
                ImageNumber = 1;
            }
            SliderpictureBox2.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SLider();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OnlineCheckIn online = new OnlineCheckIn();
            online.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BookaFlight bookaflight = new BookaFlight();
            bookaflight.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ContactUs contactus = new ContactUs();
            contactus.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FlightStatus flightstatus = new FlightStatus();
            flightstatus.Show();
        }
    }
}
