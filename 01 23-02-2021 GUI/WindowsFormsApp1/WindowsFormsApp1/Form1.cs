using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string output = "Hello " + name;
            lblRes.Text = output;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblRes.Text = txtName.Text;
        }

        private void chbCoupon_CheckedChanged(object sender, EventArgs e)
        {
            lblRes.Text = chbCoupon.Checked ? "Yes" : "No";
        }

        private void cmbCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRes.Text = cmbCount.SelectedIndex + "," + cmbCount.SelectedItem;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblRes.Text = monthCalendar1.SelectionStart.ToShortDateString() +
                "\n" + DateTime.Now.AddDays(3).DayOfWeek;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblRes.Text = "img pushed!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
