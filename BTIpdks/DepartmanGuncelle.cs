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
    public partial class DepartmanGuncelle : Form
    {
        public DepartmanGuncelle()
        {
            InitializeComponent();
            txtMeslekNo.Enabled = false;
        }
        SqlDataAdapter da;
        DataSet ds;

        connection conn = new connection();
        void txtTemizle()
        {
            txtMeslekNo.Clear();
            txtMeslekUnvan.Clear();
            txtDepartmanAdi.Clear();
        }
        void ButonOlustur()
        {
            DataGridViewButtonColumn dtyBtn = new DataGridViewButtonColumn();
            dtyBtn.Tag = "Sil";
            dtyBtn.Text = "Sil";
            dtyBtn.Name = "Sil";
            dtyBtn.UseColumnTextForButtonValue = true;
            dtyBtn.Width = 100;
            dataGridView1.Columns.Add(dtyBtn);
        }
        void gridDoldur()
        {
            da = new SqlDataAdapter("Select * From personJobs", conn.Connection);
            ds = new DataSet();
            conn.Connection.Open();
            da.Fill(ds, "personJobs");

            dataGridView1.DataSource = ds.Tables["personJobs"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Meslek Unvan";
            dataGridView1.Columns[2].HeaderText = "Departman Adı";
            ButonOlustur();

            conn.Connection.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gridDoldur();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMeslekUnvan.Text != "" && txtDepartmanAdi.Text != "")
            {

                try
                { 
                    var connect = conn.GrupUpdate(Convert.ToInt32(txtMeslekNo.Text.ToString()), txtMeslekUnvan.Text, txtDepartmanAdi.Text);
                    if (connect == true)
                    {
                        MessageBox.Show(" Başarıyla Güncellenmiştir !");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncellenirken Bir Hata Oluştu !" + ex.Message);

                }
                finally
                {
                    gridDoldur();
                    txtTemizle();
                }

            }
            else
            {
                txtTemizle();
                MessageBox.Show("Lütfen Boş Değer Girmeyiniz ! ");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMeslekNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMeslekUnvan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDepartmanAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Sil" && e.RowIndex >= 0)
                {
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        var personDelete = MessageBox.Show(@"Seçilen Personel  Kalıcı Olarak Silinecektir Onaylıyor musunuz?", @"Delete",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                        int selectedIndexId = Convert.ToInt32(selectedRow.Cells["GRUPREF"].Value);
                        if (personDelete.Equals(DialogResult.Yes))
                        {
                            conn.Connection.Open();
                            SqlCommand sqlPersonDelete = new SqlCommand("DELETE FROM personJobs WHERE GRUPREF=" + selectedIndexId, conn.Connection);
                            sqlPersonDelete.ExecuteNonQuery();
                            conn.Connection.Close();


                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Siliceğiniz Departmana Kayıtlı Personel Olmaması Gerekiyor !" + ex.Message);

            }
            finally
            {
                gridDoldur();

            }

    } }
}
