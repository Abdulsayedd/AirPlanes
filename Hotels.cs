using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPlanes
{
    public partial class Hotels : Form
    {
        public string[] ho = new string[] {   "Crowne Plaza","Emerald Bay Inn","Hotel Bliss",
                                "University Inn","The New View","Ramada Limited & Suites",
                                "Sunset Lodge","Hotel Elite","Lake Place Inn","Beacon Motel",
                                "Comfort B&B","The Fresco Hotel","Motel On Main","Holly House",
                                "High Desert Inn","Four Seasons","Budget Suites","Egyptian Inn"};

        Random random = new Random();
        public Hotels()
        {
            InitializeComponent();
            Hotel1.Text = ho[random.Next(ho.Length)];
            Hotel2.Text = ho[random.Next(ho.Length)];
            Hotel3.Text = ho[random.Next(ho.Length)];
            Hotel4.Text = ho[random.Next(ho.Length)];

        }
        private void HomePage_Click(object sender, EventArgs e)
        {
            Home p = new Home();
            this.Hide();
            p.Show();
        }

        private void Hotel1pic_Click(object sender, EventArgs e)
        {
            Hotel1.Checked = true;
        }

        private void Hotel2pic_Click(object sender, EventArgs e)
        {
            Hotel2.Checked = true;
        }

        private void Hotel3pic_Click(object sender, EventArgs e)
        {
            Hotel3.Checked = true;
        }

        private void Hotel4pic_Click(object sender, EventArgs e)
        {
            Hotel4.Checked = true;
        }
    }
}
