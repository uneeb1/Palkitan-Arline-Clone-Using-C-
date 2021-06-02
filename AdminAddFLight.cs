using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakistan_International_Airlines
{
    public partial class AdminAddFLight : Form
    {
        public AdminAddFLight()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            


                    }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Vpl\Pakistan International Airlines\Pakistan International Airlines\Database2.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand("insert into AddFlight values(@FlightNo,@tb_From,@tb_To,@Departure,@GoingTime,@LandingTime,@Price,@FlightClass)", con);
            cmd.Parameters.AddWithValue("FlightNo", txtFlightNo.Text);
            cmd.Parameters.AddWithValue("tb_From", txtfrom.Text);
            cmd.Parameters.AddWithValue("tb_To", txtTo.Text);
            cmd.Parameters.AddWithValue("Departure", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("GoingTime", txtstart.Text);
            cmd.Parameters.AddWithValue("LandingTime", txtlanding.Text);
            cmd.Parameters.AddWithValue("Price", TxtPrice.Text);
            cmd.Parameters.AddWithValue("FlightClass", textBox1.Text);
            cmd.ExecuteNonQuery();
                        
        }
                   
        }
    }

