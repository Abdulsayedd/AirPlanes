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
    public partial class Receipt : Form
    {
        public string qr = "";
        private void HomePage_Click(object sender, EventArgs e)
        {
            Home p = new Home();
            this.Hide();
            p.Show();
        }
        public Receipt(string Dir, string ID, string From, string To, string From_Time, string To_Time,string Price)
        {
            InitializeComponent();
            Ticket_ID.Text = ID;
            Ticket_From.Text = From;
            Ticket_To.Text = To;
            Ticket_From_Time.Text = From_Time;
            Ticket_To_Time.Text = To_Time;
            Ticket_Price.Text = Price;
            qr = "ID : " + ID + "\nFrom : " + From + "\nTo : " + To + "\nFrom Time : " + From_Time + "\nTo Time : " + To_Time + "\nPrice : " + Price + "\nMohammedAbdulsayed@";
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(qr, 30);

        }
    }
}
