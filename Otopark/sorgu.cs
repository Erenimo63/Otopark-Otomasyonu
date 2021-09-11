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
    public partial class sorgu : Form
    {
        public sorgu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtplaka.Text == "")
            {
                using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
                {
                    using (SQLiteCommand getir = new SQLiteCommand($"select * from Acik_otopark", baglan))
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
                                    dataGridView1.Columns[1].HeaderText = "Yer Numarası";
                                    dataGridView1.Columns[2].HeaderText = "Araç Marka";
                                    dataGridView1.Columns[3].HeaderText = "Araç Model";
                                    dataGridView1.Columns[4].HeaderText = "Sürücü Adı";
                                    dataGridView1.Columns[5].HeaderText = "Sürücü Soyadı";
                                    dataGridView1.Columns[6].HeaderText = "Giriş Tarihi";
                                    dataGridView1.Columns[7].HeaderText = "Giriş Saati";
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
            else
            {
                using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
                {
                    using (SQLiteCommand getir = new SQLiteCommand($"select * from Acik_otopark where arac_plakasi='{txtplaka.Text}'", baglan))
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
                                    dataGridView1.Columns[1].HeaderText = "Yer Numarası";
                                    dataGridView1.Columns[2].HeaderText = "Araç Marka";
                                    dataGridView1.Columns[3].HeaderText = "Araç Model";
                                    dataGridView1.Columns[4].HeaderText = "Sürücü Adı";
                                    dataGridView1.Columns[5].HeaderText = "Sürücü Soyadı";
                                    dataGridView1.Columns[6].HeaderText = "Giriş Tarihi";
                                    dataGridView1.Columns[7].HeaderText = "Giriş Saati";
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
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtplaka.Text == "")
            {
                using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
                {
                    using (SQLiteCommand getir = new SQLiteCommand($"select * from Kapalı_otopark", baglan))
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
                                    dataGridView1.Columns[1].HeaderText = "Yer Numarası";
                                    dataGridView1.Columns[2].HeaderText = "Araç Marka";
                                    dataGridView1.Columns[3].HeaderText = "Araç Model";
                                    dataGridView1.Columns[4].HeaderText = "Sürücü Adı";
                                    dataGridView1.Columns[5].HeaderText = "Sürücü Soyadı";
                                    dataGridView1.Columns[6].HeaderText = "Giriş Tarihi";
                                    dataGridView1.Columns[7].HeaderText = "Giriş Saati";
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
            else
            {
                using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
                {
                    using (SQLiteCommand getir = new SQLiteCommand($"select * from Kapalı_otopark where arac_plakasi='{txtplaka.Text}'", baglan))
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
                                    dataGridView1.Columns[1].HeaderText = "Yer Numarası";
                                    dataGridView1.Columns[2].HeaderText = "Araç Marka";
                                    dataGridView1.Columns[3].HeaderText = "Araç Model";
                                    dataGridView1.Columns[4].HeaderText = "Sürücü Adı";
                                    dataGridView1.Columns[5].HeaderText = "Sürücü Soyadı";
                                    dataGridView1.Columns[6].HeaderText = "Giriş Tarihi";
                                    dataGridView1.Columns[7].HeaderText = "Giriş Saati";
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
        }

        private void txtplaka_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sorgu_Load(object sender, EventArgs e)
        {

        }
    }
}
