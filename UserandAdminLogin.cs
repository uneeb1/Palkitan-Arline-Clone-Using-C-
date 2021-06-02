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
    public partial class UserandAdminLogin : Form
    {
        public UserandAdminLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
           // Registration reg = new Registration();
          //  reg.Show();
            MainPage n = new MainPage();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-23RPG9S;Initial Catalog=Theater;Integrated Security=True");
            con.Open();
            using (SqlCommand cmd = new SqlCommand("select * from Cashier where Email=@Email and Password=@Password", con))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpass.Text);

                    int output = Convert.ToInt32(cmd.ExecuteScalar());
                    //Connection open here   
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (output > 0)
                    {
                        //username = FirstName.Text;

                        MainPage n = new MainPage();
                        n.Show();

                    }
                    else {
                        MessageBox.Show("Username or password invalid please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception exe) { }
            }
        }
    }
}