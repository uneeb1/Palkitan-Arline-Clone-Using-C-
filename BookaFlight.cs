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
    public partial class BookaFlight : Form
    {
        public BookaFlight()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookaFlight_Load(object sender, EventArgs e)
        {
            PanelOneWay.Visible = true;
            panelRoundTrip.Visible = false;
            panelMuiltiCity.Visible = false;
            PanelOneWay.BringToFront();
        }

        private void lblOneWay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelMuiltiCity.Visible = false;
            panelRoundTrip.Visible = false;
            PanelOneWay.Visible = true;
            PanelOneWay.BringToFront();
        }

        private void lblRoundtrip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            PanelOneWay.Visible = false;
            panelMuiltiCity.Visible = false;
            panelRoundTrip.Visible = true;
            panelRoundTrip.BringToFront();
        }

        private void lblMultiCity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelOneWay.Visible = false;
            panelRoundTrip.Visible = false;
            panelMuiltiCity.Visible = true;
            panelMuiltiCity.BringToFront();
        }

        private void cmb_OneWay_Form_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_OneWay_TO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OneWay_monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cmb_Oneway_Adult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Oneway_Child_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_oneway_Infant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rb_oneway_Economy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_oneway_Executive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_oneway_Busiines_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_oneway_Click(object sender, EventArgs e)
        {

        }

        //MultiCity Flight 1
        private void cmb_MultiCity_from_Flight1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_MultiCity_TO_Flight1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void multiflihgt1_monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {

        }//MultiCity FLight2

        private void cmb_Multicity_From_FLight2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_MultiCity_TO_Flight2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void multiflihgt2_monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }//MultiCity COmbo box radio Button

        private void cmb_multi_Adult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_multi_Child_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_multi_Infant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rd_multi_Economy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_multi_Executive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_multi_bussiness_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        //RoundTrip
        private void cmb_roundtrip_form_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_roundtrip_TO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ROundtrip_DeparturemonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void RoundTrip_ReturnmonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cmb_Roundtrip_ADult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Roundtrip_Child_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Roundtrip_Infanr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rd_roundtrip_Economy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_roundtrip_Executive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_roundtrip_Bussiness_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Roundtrip_Click(object sender, EventArgs e)
        {

        }

        private void panelRoundTrip_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
