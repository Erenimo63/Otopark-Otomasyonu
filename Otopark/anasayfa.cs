using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Otopark
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acikotopark ackpark = new acikotopark();
            ackpark.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mustericikis cikis = new mustericikis();
            cikis.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arsiv arsiv = new arsiv();
            arsiv.Show();
            this.Hide();
        }
        
        private void anasayfa_Load(object sender, EventArgs e)
        {
            string no = Form1.personel;
            label1.Text = "Personel No : "+no;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kapaliotopark kapalipark = new kapaliotopark();
            kapalipark.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sorgu sorgu = new sorgu();
            sorgu.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            abone abone = new abone();
            this.Hide();
            abone.Show();
        }
    }
}
