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
    public partial class OnlineCheckIn : Form
   
    { 
        private  SqlDataReader dr;
        public OnlineCheckIn()
        {
            InitializeComponent();
        }

        private void OnlineCheckIn_Load(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            dataGridView1.Visible = false;
        }

        private void btnCheckticket_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Vpl\Pakistan International Airlines\Pakistan International Airlines\Database2.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

           // cmd.CommandText = "select * from OneWay where Email='" + textBox1.Text + "'";
          
           
            dr = cmd.ExecuteReader();  
            if (cmbFrom.SelectedItem.ToString()=="OneWay")
            {
                 SqlDataAdapter da = new SqlDataAdapter("select * from OneWay where Email='" + textBox1.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds,"OneWay");
                dataGridView1.DataSource = ds.Tables["OneWay"].DefaultView;
            }
            else {
                MessageBox.Show("Email Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Open();
            //using (SqlDataReader rdr = cmd1.ExecuteReader())
            //{
            //    while (rdr.Read())
            //    {
                   
            //    }}
            
            con.Close();
        }
    }
}
