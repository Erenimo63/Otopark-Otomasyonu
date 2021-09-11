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
    public partial class abone : Form
    {
        public abone()
        {
            InitializeComponent();
        }

        string plaka;

        private void btngeri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand ekle = new SQLiteCommand($"insert into Abone (plaka,isim,soyisim) values ('{txtplaka.Text}','{txtsurucuadi.Text}','{txtsurucusoyadi.Text}')",baglan))
                {
                    try
                    {
                        baglan.Open();
                        ekle.ExecuteNonQuery();
                        MessageBox.Show("Abonelik Eklendi");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(" \n"+hata);
                    }
                    finally
                    {
                        baglan.Close();
                    }
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand sil = new SQLiteCommand($"delete from Abone where plaka='{plaka}'", baglan))
                {
                    try
                    {
                        baglan.Open();
                        sil.ExecuteNonQuery();
                        MessageBox.Show("Abonelik Silindi");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plaka = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtplaka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtsurucuadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsurucusoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void abone_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand getir = new SQLiteCommand($"select * from Abone", baglan))
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
                                dataGridView1.Columns[1].HeaderText = "Sürücü İsmi";
                                dataGridView1.Columns[2].HeaderText = "Sürücü Soyadı";
                                
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection baglan = new SQLiteConnection("data source=db/Otopark.db"))
            {
                using (SQLiteCommand güncelle = new SQLiteCommand($"update Abone set plaka = '{txtplaka.Text}',isim = '{txtsurucuadi.Text}',soyisim = '{txtsurucusoyadi.Text}' where plaka='{plaka}'", baglan))
                {
                    try
                    {
                        baglan.Open();
                        güncelle.ExecuteNonQuery();
                        MessageBox.Show("Abonelik Güncellendi");
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
