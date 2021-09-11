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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string personel;

        private void button1_Click(object sender, EventArgs e)
        {
            kayit kayit = new kayit();
            kayit.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                baglan.Open();
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Personel where personel_no = '{txtpersonel.Text}' and sifre = '{txtsifre.Text}'",baglan))
                {
                    using (SQLiteDataReader oku = getir.ExecuteReader())
                    {
                        if (oku.Read())
                        {
                            baglan.Close();
                            personel = txtpersonel.Text;
                            anasayfa anasayfa = new anasayfa();
                            anasayfa.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Personel Numarası ve Şifre Yanlış");
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
