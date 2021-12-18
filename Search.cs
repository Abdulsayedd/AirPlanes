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
    public partial class Search : Form
    {
        Random Rann1 = new Random();
        GetStarted n1 = new GetStarted();
        public string[] Ran1 =new string[] { "1", "A", "3", "4", "5", "B", "7", "C", "9", "0" , "2" , "6" , "8"} ;
        private object dir;

        public Search(string from,string to,string at,string rret,bool dir)
        {
            InitializeComponent();
            From.Text = From1.Text = From2.Text = From3.Text = From4.Text = From5.Text = From6.Text = From7.Text = from;
            To.Text = To1.Text = To2.Text = To3.Text = To4.Text = To5.Text = To6.Text = To7.Text = to;
            At.Text = at;
            Ret.Text = rret; 
            ///////////ID
            ID.Text = Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + "";
            ID1.Text = Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + "";
            ID2.Text = Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + "";
            ID3.Text = Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + "";
            ID4.Text = Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + "";
            ID5.Text = Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + "";
            ID6.Text = Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + Ran1[Rann1.Next(Ran1.Length)] + "";
            ///////////Prices
            Price.Text = Rann1.Next(100,900)+"$"; Price1.Text = Rann1.Next(100,900) + "$"; Price2.Text = Rann1.Next(100,900) + "$";
            Price3.Text = Rann1.Next(100,900) + "$"; Price4.Text = Rann1.Next(100,900) + "$"; Price5.Text = Rann1.Next(100,900) + "$";
            Price6.Text = Rann1.Next(100,900) + "$";
            ///////////FromTime
            From_Time_1.Text = Rann1.Next(23).ToString("00") + ":"+ Rann1.Next(59).ToString("00"); From_Time_2.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00");
            From_Time_3.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00"); From_Time_4.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00");
            From_Time_5.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00"); From_Time_6.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00");
            From_Time_7.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00");
            //////////ToTime
            To_Time_1.Text= Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00"); To_Time_2.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00");
            To_Time_3.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00"); To_Time_4.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00");
            To_Time_5.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00"); To_Time_6.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00");
            To_Time_7.Text = Rann1.Next(23).ToString("00") + ":" + Rann1.Next(59).ToString("00");
            /////////Direct
            if(dir)
            {
                Direct1.Text = Direct2.Text = Direct3.Text = Direct4.Text = Direct5.Text = Direct6.Text = Direct7.Text = "Direct";
            }
            else
            {
                Direct1.Text = Direct2.Text = Direct3.Text = Direct4.Text = Direct5.Text = Direct6.Text = Direct7.Text = "Not Direct";
            }
            button7.Hide();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Home p = new Home();
            this.Hide();
            p.Show();
        }

        private void TravelFrom_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void Book1_Click(object sender, EventArgs e)
        {
            Receipt p1 = new Receipt(Direct1.Text,ID.Text,From.Text,To.Text,From_Time_1.Text,To_Time_1.Text,Price.Text);
            this.Hide();
            p1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void From1_Click(object sender, EventArgs e)
        {

        }

        private void Book2_Click(object sender, EventArgs e)
        {
            Receipt p1 = new Receipt(Direct1.Text, ID1.Text, From.Text, To.Text, From_Time_2.Text, To_Time_2.Text, Price1.Text);
            this.Hide();
            p1.Show();
        }

        private void Book3_Click(object sender, EventArgs e)
        {
            Receipt p1 = new Receipt(Direct1.Text, ID2.Text, From.Text, To.Text, From_Time_3.Text, To_Time_3.Text, Price2.Text);
            this.Hide();
            p1.Show();
        }

        private void Book4_Click(object sender, EventArgs e)
        {
            Receipt p1 = new Receipt(Direct1.Text, ID3.Text, From.Text, To.Text, From_Time_4.Text, To_Time_4.Text, Price3.Text);
            this.Hide();
            p1.Show();
        }

        private void Book5_Click(object sender, EventArgs e)
        {
            Receipt p1 = new Receipt(Direct1.Text, ID4.Text, From.Text, To.Text, From_Time_5.Text, To_Time_5.Text, Price4.Text);
            this.Hide();
            p1.Show();
        }

        private void Book6_Click(object sender, EventArgs e)
        {
            Receipt p1 = new Receipt(Direct1.Text, ID5.Text, From.Text, To.Text, From_Time_6.Text, To_Time_6.Text, Price5.Text);
            this.Hide();
            p1.Show();
        }

        private void Book7_Click(object sender, EventArgs e)
        {
            Receipt p1 = new Receipt(Direct1.Text, ID6.Text, From.Text, To.Text, From_Time_7.Text, To_Time_7.Text, Price6.Text);
            this.Hide();
            p1.Show();
        }
    }
}
