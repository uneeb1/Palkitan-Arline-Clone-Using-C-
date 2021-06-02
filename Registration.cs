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
    
    public partial class Registration : Form
    {
        
        private  SqlDataReader dr;
        string gender = string.Empty;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
          }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                gender = "M";
            }
            else if (rd2.Checked)
            {
                gender = "F";
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Vpl\Pakistan International Airlines\Pakistan International Airlines\Database2.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Registration where Email='" + txtemail.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Email Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into Registration values(@UserNAME,@Email,@Password,@MobileNo,@Age,@Gender)", con);
                cmd.Parameters.AddWithValue("UserNAME", txtname.Text);
                cmd.Parameters.AddWithValue("Email", txtemail.Text);
                cmd.Parameters.AddWithValue("Password", txtpass.Text);
                cmd.Parameters.AddWithValue("MobileNo", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("Age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("Gender", gender);
                cmd.ExecuteNonQuery();

            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
