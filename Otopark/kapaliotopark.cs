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
    public partial class kapaliotopark : Form
    {
        public kapaliotopark()
        {
            InitializeComponent();
        }

        private void kapaliotopark_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Kapali_yer where durum='{"Boş"}'", baglan))
                {
                    baglan.Open();
                    using (SQLiteDataReader oku = getir.ExecuteReader())
                    {
                        try
                        {
                            while (oku.Read())
                            {
                                comboyer.Items.Add(oku["numara"].ToString());
                            }
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
                using (SQLiteCommand bos = new SQLiteCommand($"select count(*) from Kapali_yer where durum = '{"Boş"}'", baglan))
                {
                    baglan.Open();
                    using (SQLiteDataReader oku = bos.ExecuteReader())
                    {
                        try
                        {
                            oku.Read();
                            labelbos.Text = oku[0].ToString();
                            labelbos.ForeColor = Color.White;
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
                using (SQLiteCommand dolu = new SQLiteCommand($"select count(*) from Kapali_yer where durum = '{"Dolu"}'", baglan))
                {
                    baglan.Open();
                    using (SQLiteDataReader oku = dolu.ExecuteReader())
                    {
                        try
                        {
                            oku.Read();
                            labeldolu.Text = oku[0].ToString();
                            labeldolu.ForeColor = Color.Black;
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

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source = db/Otopark.db"))
            {
                using (SQLiteCommand kayit = new SQLiteCommand($"insert into Kapalı_otopark (arac_plakasi,yer_numarasi,arac_marka,arac_model,surucu_adi,surucu_soyadi,tarih,saat) values ('{txtplaka.Text}','{comboyer.Text}','{txtmarka.Text}','{txtmodel.Text}','{txtsurucuadi.Text}','{txtsurucusoyadi.Text}','{dategiris.Text}','{txtgirissaat.Text}')", baglan))
                {
                    using (SQLiteCommand güncelle = new SQLiteCommand($"update Kapali_yer set durum = '{"Dolu"}' where numara ='{comboyer.Text}'", baglan))
                    {
                        try
                        {
                            baglan.Open();
                            kayit.ExecuteNonQuery();
                            güncelle.ExecuteNonQuery();
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
