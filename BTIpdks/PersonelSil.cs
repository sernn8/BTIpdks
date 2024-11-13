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
    public partial class PersonelSil : Form
    {
        public PersonelSil()
        {
            InitializeComponent();
            DataGridDoldur();


        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KCMOCA6;Initial Catalog=BTI_PDKS;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        void ButonOlustur()
        {
            DataGridViewButtonColumn dtyBtn = new DataGridViewButtonColumn();
            dtyBtn.Tag = "Detay";
            dtyBtn.Text = "Detay";
            dtyBtn.Name = "Detay";
            dtyBtn.UseColumnTextForButtonValue = true;
            dtyBtn.Width = 100;
            dgvPersonel.Columns.Add(dtyBtn);




            DataGridViewButtonColumn silBtn = new DataGridViewButtonColumn();
            silBtn.HeaderText = "Sil";
            silBtn.Text = "Sil";
            silBtn.Tag = "Sil";
            silBtn.Name = "Sil";
            silBtn.UseColumnTextForButtonValue = true;
            silBtn.Width = 100;
            dgvPersonel.Columns.Add(silBtn);

        }
        void DataGridDoldur()
        {
            try
            {
                dgvPersonel.Columns.Clear();
                da = new SqlDataAdapter("SELECT * FROM personInformation", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "personInformation");
                ds.Tables["personInformation"].Columns[11].DefaultValue = new byte[0];
                dgvPersonel.DataSource = ds.Tables["personInformation"];
                dgvPersonel.Columns[0].Visible = false;
                dgvPersonel.Columns[0].Name = "PRSREF";

                dgvPersonel.Columns[1].HeaderText = "Personel Kodu";
                dgvPersonel.Columns[2].HeaderText = "Personel Adı";
                dgvPersonel.Columns[3].HeaderText = "Personel Soyadı";
                dgvPersonel.Columns[4].HeaderText = "Personel TC";
                dgvPersonel.Columns[5].HeaderText = "Personel Tel";
                dgvPersonel.Columns[6].HeaderText = "Personel Mail";
                dgvPersonel.Columns[7].HeaderText = "Personel İş Giriş Tarihi";
                dgvPersonel.Columns[8].HeaderText = "Personeş İş Çıkış Tarihi";
                dgvPersonel.Columns[9].HeaderText = "Personel Meslek No";
                dgvPersonel.Columns[10].HeaderText = "Personel Durum";
                dgvPersonel.Columns[11].HeaderText = "Personel Resmi";
                ButonOlustur();



            }
            catch (Exception)
            {
                MessageBox.Show("Datagrid Doldurulamadı !!", "@Data Hata !");
            }
            finally
            {
                con.Close();
            }
        }

        private void PersonelSil_Load(object sender, EventArgs e)
        {

        }

        private void dgvPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvPersonel.Columns[e.ColumnIndex].Name == "Detay" && e.RowIndex >= 0)
                {
                    personelDetay personDetails = new personelDetay();
                    if (dgvPersonel.SelectedCells.Count > 0)
                    {
                        int selectIndex = dgvPersonel.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dgvPersonel.Rows[selectIndex];
                        personDetails.secilenPersonId = Convert.ToString(selectedRow.Cells["PRSREF"].Value);
                        personDetails.ShowDialog();
                    }
                }


                if (dgvPersonel.Columns[e.ColumnIndex].Name == "Sil" && e.RowIndex >= 0)
                {
                    if (dgvPersonel.SelectedCells.Count > 0)
                    {
                        var personDelete = MessageBox.Show(@"Seçilen Personel  Kalıcı Olarak Silinecektir Onaylıyor musunuz?", @"Delete",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        int selectedrowindex = dgvPersonel.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dgvPersonel.Rows[selectedrowindex];
                        int selectedIndexId = Convert.ToInt32(selectedRow.Cells["PRSREF"].Value);
                        if (personDelete.Equals(DialogResult.Yes))
                        {
                            con.Open();
                            SqlCommand sqlPersonDelete = new SqlCommand("DELETE FROM personInformation WHERE PRSREF=" + selectedIndexId, con);
                            sqlPersonDelete.ExecuteNonQuery();
                            con.Close();
                            DataGridDoldur();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata var !" + ex.Message);
            }
        }


        private void dgvPersonel_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPersonel.ClearSelection();

        }
    }
}
