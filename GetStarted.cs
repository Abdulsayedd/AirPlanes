using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AirPlanes
{
    public partial class GetStarted : Form
    {
        public string From_;
        public string To_;
        public string Depart_;
        public string Return_;
        public int Adults_;
        public int Childs_;
        public bool direct;
        public string directt;
        public GetStarted()
        {
            InitializeComponent();
            monthCalendar1.Hide();
            monthCalendar2.Hide();
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            string temp = Fromtxtbox.Text;
            Fromtxtbox.Text = Totxtbox.Text;
            Totxtbox.Text = temp;
        }

        private void Oneway_CheckedChanged(object sender, EventArgs e)
        {
            if(Oneway.Checked)
            {
                Returntxtbox.Hide();
                Return.Hide();
                ReturnCalendarbtn.Hide();
            }
            else
            {
                Returntxtbox.Show();
                Return.Show();
                ReturnCalendarbtn.Show();
            }
        }
        private void RoundTrip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                From_ = Fromtxtbox.Text;
                To_ = Totxtbox.Text;
                Depart_ = Departxtbox.Text;
                Return_ = Returntxtbox.Text;
                Adults_ = int.Parse(Adultstxtbox.Text);
                Childs_ = int.Parse(Childstxtbox.Text);
                if (direct)
                {
                    directt = "Direct Flights only";
                }
                else
                {
                    directt = "Non direct flights";
                }
                MessageBox.Show("Going from " + From_ + " To " + To_ + " \nDeparture date is " + Depart_ + " Returns at " + Return_ + "\nAdults count = " + Adults_ + " Childs count = " + Childs_ + "\n" + directt);
        }

        private void Adultsplus_Click(object sender, EventArgs e)
        {
            Adults_ = int.Parse(Adultstxtbox.Text);
            Childs_ = int.Parse(Childstxtbox.Text);
            Adults_++;
            Adultstxtbox.Text = Adults_+"";
        }
        private void Adultsminus_Click(object sender, EventArgs e)
        {
            Adults_ = int.Parse(Adultstxtbox.Text);
            Childs_ = int.Parse(Childstxtbox.Text);
            Adults_--;
            Adultstxtbox.Text = Adults_ + "";

        }
        private void Childsplus_Click(object sender, EventArgs e)
        {
            Adults_ = int.Parse(Adultstxtbox.Text);
            Childs_ = int.Parse(Childstxtbox.Text);
            Childs_++;
            Childstxtbox.Text = Childs_ + "";

        }
        private void Childsminus_Click(object sender, EventArgs e)
        {
            Adults_ = int.Parse(Adultstxtbox.Text);
            Childs_ = int.Parse(Childstxtbox.Text);
            Childs_--;
            Childstxtbox.Text = Childs_ + "";
        }
        private void Directflights_CheckedChanged(object sender, EventArgs e)
        {
            if (Directflights.Checked)
                direct = true;
            else
                direct = false;
        }
        private void Fromtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetStarted_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Home p = new Home();
            this.Hide();
            p.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            From_ = Fromtxtbox.Text;
            To_ = Totxtbox.Text;
            Depart_ = Departxtbox.Text;
            Return_ = Returntxtbox.Text;
            Adults_ = int.Parse(Adultstxtbox.Text);
            Childs_ = int.Parse(Childstxtbox.Text);
            if (direct)
            {
                directt = "Direct Flights only";
            }
            else
            {
                directt = "Non direct flights";
            }
            Search p = new Search(From_,To_,Depart_,Return_,direct);
            this.Hide();
            p.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CalendarDepart_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }
        private void ReturnCalendar_Click(object sender, EventArgs e)
        {
            
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var monthcalendar = sender as MonthCalendar;
            Departxtbox.Text = monthcalendar.SelectionStart.ToShortDateString();
        }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            var monthcalendar = sender as MonthCalendar;
            Returntxtbox.Text = monthcalendar.SelectionStart.ToShortDateString();
        }
        private void ReturnCalendarbtn_Click(object sender, EventArgs e)
        {
            monthCalendar2.Show();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (!monthCalendar1.Focused)
                monthCalendar1.Visible = false;
            monthCalendar1.Hide();
        }

        private void hidereturn_Click(object sender, EventArgs e)
        {
            if (!monthCalendar2.Focused)
                monthCalendar2.Visible = false;
            monthCalendar2.Hide();
        }
    }
}
