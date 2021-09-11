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
    public partial class arsiv : Form
    {
        public arsiv()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void arsiv_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand("select sum (ucret) from Arsiv",baglan))
                {
                    baglan.Open();
                    using (SQLiteDataReader oku = getir.ExecuteReader())
                    {
                        try
                        {
                            oku.Read();
                            txtgelir.Text = oku[0].ToString();
                        }
                        catch (Exception hata)
                        {
                            MessageBox.Show(" \n" + hata);
                        }
                        finally
                        {
                            baglan.Close();
                        }
                    }
                }
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Arsiv where giris_tarihi ='{dateTimePicker1.Text}'", baglan))
                {
                    using (SQLiteCommand ucretgetir = new SQLiteCommand($"select sum (ucret) from Arsiv where giris_tarihi ='{dateTimePicker1.Text}'", baglan))
                    {
                        baglan.Open();
                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(getir))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                try
                                {
                                    da.Fill(ds);
                                    dataGridView1.DataSource = ds.Tables[0];
                                    dataGridView1.Columns[0].HeaderText = "Araç Plaka";
                                    dataGridView1.Columns[1].HeaderText = "Araç Marka";
                                    dataGridView1.Columns[2].HeaderText = "Araç Model";
                                    dataGridView1.Columns[3].HeaderText = "Sürücü Adı";
                                    dataGridView1.Columns[4].HeaderText = "Sürücü Soyadı";
                                    dataGridView1.Columns[5].HeaderText = "Giriş Tarihi";
                                    dataGridView1.Columns[6].HeaderText = "Giriş Saati";
                                    dataGridView1.Columns[7].HeaderText = "Çıkış Tarihi";
                                    dataGridView1.Columns[8].HeaderText = "Çıkış Saati";
                                    dataGridView1.Columns[9].HeaderText = "Ücret";
                                }
                                catch (Exception hata)
                                {
                                    MessageBox.Show(" " + hata);
                                }
                            }
                        }
                        using (SQLiteDataReader oku = ucretgetir.ExecuteReader())
                        {
                            try
                            {
                                oku.Read();
                                txtgunluk.Text = oku[0].ToString();
                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show(" \n" + hata);
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
    }
}
