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
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            
            using (SQLiteConnection baglan = new SQLiteConnection("data source = db/Otopark.db"))
            {
                baglan.Open();
                using (SQLiteCommand kayit = new SQLiteCommand($"insert into Personel (personel_no,isim,soyisim,sifre) values ('{txtpersonel.Text}','{txtisim.Text}','{txtsoyisim.Text}','{txtsifre.Text}')", baglan))
                {
                    try
                    {
                        kayit.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Yapıldı");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(" " + hata);
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
            }
        }
    }
}
