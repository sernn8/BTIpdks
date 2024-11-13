using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTIpdks
{
    public partial class DepartmanEkle : Form
    {
        public DepartmanEkle()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        connection conn = new connection();
        private void txtClear()
        {
            txtMeslekAdi.Clear();
            txtDepartmanAdi.Clear();

        }

        void gridDoldur()
        {
            da = new SqlDataAdapter("Select * From personJobs", conn.Connection);
            ds = new DataSet();
            conn.Connection.Open();
            da.Fill(ds, "personelMeslekleri");
            dataGridView1.DataSource = ds.Tables["personelMeslekleri"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Meslek Adı";
            dataGridView1.Columns[2].HeaderText = "Departman Adı";


            conn.Connection.Close();


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gridDoldur();
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMeslekAdi.Text != string.Empty && txtDepartmanAdi.Text != string.Empty)
            {
                try
                {
                    var connect = conn.GrupInsert(txtMeslekAdi.Text, txtDepartmanAdi.Text);
                    if (txtMeslekAdi.Text.Length >= 50 && txtDepartmanAdi.Text.Length >= 50)
                    {
                        MessageBox.Show("Lütfen 50 Karakteri Geçmeyiniz ! ");
                    }
                    else
                    {
                        if (connect)
                        {
                            MessageBox.Show("Kaydetme İşlemi Başarılı");

                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("İşlem Yapılırken Hata Oluştu ! " + ex.Message);

                }
                finally
                {
                    gridDoldur();
                    txtClear();
                }
            }
            else 
            {
                MessageBox.Show("Lütfen Boş Değer Girmeyiniz !!");
                txtClear();
            }
        }
    }
}
