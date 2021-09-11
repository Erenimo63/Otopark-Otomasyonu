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
    public partial class mustericikis : Form
    {
        public mustericikis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void mustericikis_Load(object sender, EventArgs e)
        {

        }

        int saat, ucret;
        string numara,plaka,abone;
        private void radioacik_CheckedChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Acik_otopark where arac_plakasi ='{txtplaka.Text}'", baglan))
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

        private void radiokapali_CheckedChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Kapalı_otopark where arac_plakasi ='{txtplaka.Text}'", baglan))
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

        private void txtcikissaat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (abone == "1")
            {
                string girisZamani = txtgirissaat.Text;
                string cikisZamani = txtcikissaat.Text;
                TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                int hesap = int.Parse(girisCikisFarki.Hours.ToString());
                txtucret.Text = Convert.ToString(hesap * 6) + " ₺";
            }
            else
            {
                string girisZamani = txtgirissaat.Text;
                string cikisZamani = txtcikissaat.Text;
                TimeSpan girisCikisFarki = DateTime.Parse(cikisZamani).Subtract(DateTime.Parse(girisZamani));
                int hesap = int.Parse(girisCikisFarki.Hours.ToString());
                txtucret.Text = Convert.ToString(hesap * 7) + " ₺";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioacik.Checked == true)
            {
                using (SQLiteConnection baglan = new SQLiteConnection("data source = db/Otopark.db"))
                {
                    using (SQLiteCommand kayit = new SQLiteCommand($"insert into Arsiv (arac_plaka,arac_marka,arac_model,surucu_adi,surucu_soyadi,giris_tarihi,giris_saati,cikis_tarihi,cikis_saati,ucret) values ('{txtplaka.Text}','{txtmarka.Text}','{txtmodel.Text}','{txtsurucuadi.Text}','{txtsurucusoyadi.Text}','{dategiris.Text}','{txtgirissaat.Text}','{datecikis.Text}','{txtcikissaat.Text}','{txtucret.Text}')", baglan))
                    {
                        using (SQLiteCommand sil = new SQLiteCommand($"delete from Acik_otopark where arac_plakasi = '{txtplaka.Text}'", baglan))
                        {
                            using (SQLiteCommand  güncelle = new SQLiteCommand($"update Acik_yer set durum = '{"Boş"}' where numara = '{numara}'",baglan))
                            {
                                try
                                {
                                    baglan.Open();
                                    sil.ExecuteNonQuery();
                                    kayit.ExecuteNonQuery();
                                    güncelle.ExecuteNonQuery();
                                    radioacik.Checked = false;
                                    radiokapali.Checked = false;
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
            if (radiokapali.Checked == true)
            {
                using (SQLiteConnection baglan = new SQLiteConnection("data source = db/Otopark.db"))
                {
                    using (SQLiteCommand kayit = new SQLiteCommand($"insert into Arsiv (arac_plaka,arac_marka,arac_model,surucu_adi,surucu_soyadi,giris_tarihi,giris_saati,cikis_tarihi,cikis_saati,ucret) values ('{txtplaka.Text}','{txtmarka.Text}','{txtmodel.Text}','{txtsurucuadi.Text}','{txtsurucusoyadi.Text}','{dategiris.Text}','{txtgirissaat.Text}','{datecikis.Text}','{txtcikissaat.Text}','{txtucret.Text}')", baglan))
                    {
                        using (SQLiteCommand sil = new SQLiteCommand($"delete from Kapalı_otopark where arac_plakasi = '{txtplaka.Text}'", baglan))
                        {
                            using (SQLiteCommand güncelle = new SQLiteCommand($"update Kapali_yer set durum = '{"Boş"}' where numara = '{numara}'",baglan))
                            {
                                try
                                {
                                    baglan.Open();
                                    sil.ExecuteNonQuery();
                                    kayit.ExecuteNonQuery();
                                    güncelle.ExecuteNonQuery();
                                    radiokapali.Checked = false;
                                    radioacik.Checked = false;
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plaka = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            using (SQLiteConnection baglan = new SQLiteConnection("data source = db/Otopark.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Abone where plaka = '{plaka}'",baglan))
                {
                    baglan.Open();
                    using (SQLiteDataReader oku = getir.ExecuteReader())
                    {
                        if (oku.Read())
                        {
                            abone = "1";
                            numara = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            txtmarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                            txtmodel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                            txtsurucuadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                            txtsurucusoyadi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                            dategiris.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                            txtgirissaat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        }
                        else
                        {
                            numara = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                            txtmarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                            txtmodel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                            txtsurucuadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                            txtsurucusoyadi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                            dategiris.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                            txtgirissaat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        }
                    }
                }
            }
        }
    }
}
